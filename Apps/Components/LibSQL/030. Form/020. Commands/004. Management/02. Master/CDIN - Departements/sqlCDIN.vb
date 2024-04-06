Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CDIN
    Public Class View
        ReadOnly _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim _Where As String = "where "

            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                _Where = String.Format("")
            Else
                _Where += String.Format(" (c.company_code like '%{0}%') or (d.departement_code like '%{0}%') or (d.departement_name like '%{0}%') or (d.departement_description like '%{0}%')", Find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("select d.departement_id, c.company_code, d.departement_code, d.departement_name, d.departement_description from dbo.[[man]]departement] d inner join dbo.[[man]]company] c " &
                                                    "on d.departement_company = c.company_id {0} order by c.company_code, d.departement_code ", _Where)

            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TDepartement")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal RowID As String) As Boolean
            Dim _Success As Boolean
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[man]]departement] where (departement_id = '{0}')", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class

    Public Class Editor
        ReadOnly _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal CompanyID As String, ByVal DeptCode As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _IsDuplicate As Integer
            Dim _Where As String = "where "

            If RowID = "-1" Then
                _Where += String.Format("(d.departement_company = '{0}') and (d.departement_code = '{1}')", CompanyID, DeptCode)
            Else
                _Where += String.Format("(d.departement_company = '{0}') and (d.departement_code = '{1}') and (d.departement_id <> '{2}')", CompanyID, DeptCode, RowID)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("select count(d.departement_id) as [rows] from dbo.[[man]]departement] d {0}", _Where)

            _IsDuplicate = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)

            If _IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub FILLCompany(ByVal Company As cbo)
            V_DBR_MSSQL2008(0).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_code] from dbo.[[man]]company] c order by c.company_code"
            _DBR_MSSQL2008(0).Dropdown = Company
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TCompany")
            Company.ValueMember = "company_id"
            Company.DisplayMember = "company_code"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyID(ByVal RowID As String) As Object
            Dim _CompanyID As String
            V_DBR_MSSQL2008(0).Query = String.Format("select d.departement_company from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            _CompanyID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)
            Return _CompanyID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptCode(ByVal RowID As String) As Object
            Dim _DeptCode As String
            V_DBR_MSSQL2008(0).Query = String.Format("select d.departement_code from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            _DeptCode = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)
            Return _DeptCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptName(ByVal RowID As String) As Object
            Dim _DeptName As String
            V_DBR_MSSQL2008(0).Query = String.Format("select d.departement_name from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            _DeptName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)
            Return _DeptName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDescription(ByVal RowID As String) As Object
            Dim _Description As String
            V_DBR_MSSQL2008(0).Query = String.Format("select d.departement_description from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            _Description = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)
            Return _Description
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal Company As String, ByVal DepartementCode As String, ByVal DepartementName As String, ByVal DepartementDescription As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _Success As Boolean
            Try
                If RowID = "-1" Then
                    Dim Hash As String = CMCv.Security.Encrypt.MD5()
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]departement](departement_id, departement_company, departement_code, departement_name, departement_description) " &
                                                            "values('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Company, DepartementCode, DepartementName, DepartementDescription)
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]departement] set departement_company = '{0}', departement_code = '{1}', departement_name = '{2}', departement_description = '{3}' " &
                                                            "where departement_id = '{4}'", Company, DepartementCode, DepartementName, DepartementDescription, RowID)
                End If

                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class
End Namespace
