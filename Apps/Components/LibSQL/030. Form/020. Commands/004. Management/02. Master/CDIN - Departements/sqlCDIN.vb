Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CDIN
    Public Class View
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim varWhere As String = "where "

            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format(" (c.company_code like '%{0}%') or (d.departement_code like '%{0}%') or (d.departement_name like '%{0}%') or (d.departement_description like '%{0}%')", Find.XOSQLText)
            End If

            varDBreader_mssql2008(0).Query = String.Format("select d.departement_id, c.company_code, d.departement_code, d.departement_name, d.departement_description from dbo.[[man]]departement] d inner join dbo.[[man]]company] c " &
                                                    "on d.departement_company = c.company_id {0} order by c.company_code, d.departement_code ", varWhere)

            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TDepartement", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[man]]departement] where (departement_id = '{0}')", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

    Public Class Editor
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal CompanyID As String, ByVal DeptCode As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim varISduplicate As Integer
            Dim varWhere As String = "where "

            If RowID = "-1" Then
                varWhere += String.Format("(d.departement_company = '{0}') and (d.departement_code = '{1}')", CompanyID, DeptCode)
            Else
                varWhere += String.Format("(d.departement_company = '{0}') and (d.departement_code = '{1}') and (d.departement_id <> '{2}')", CompanyID, DeptCode, RowID)
            End If

            varDBreader_mssql2008(0).Query = String.Format("select count(d.departement_id) as [rows] from dbo.[[man]]departement] d {0}", varWhere)

            varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

            If varISduplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub FILLCompany(ByVal Company As Cbo)
            varDBreader_mssql2008(0).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_code] from dbo.[[man]]company] c order by c.company_code"
            varDBreader_mssql2008(0).Dropdown = Company
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TCompany", "db_universe_erp")
            Company.ValueMember = "company_id"
            Company.DisplayMember = "company_code"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyID(ByVal RowID As String) As Object
            Dim varCompanyid As String
            varDBreader_mssql2008(0).Query = String.Format("select d.departement_company from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            varCompanyid = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varCompanyid
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptCode(ByVal RowID As String) As Object
            Dim varDeptcode As String
            varDBreader_mssql2008(0).Query = String.Format("select d.departement_code from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            varDeptcode = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varDeptcode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptName(ByVal RowID As String) As Object
            Dim varDeptname As String
            varDBreader_mssql2008(0).Query = String.Format("select d.departement_name from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            varDeptname = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varDeptname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDescription(ByVal RowID As String) As Object
            Dim varDescription As String
            varDBreader_mssql2008(0).Query = String.Format("select d.departement_description from dbo.[[man]]departement] d where d.departement_id = '{0}'", RowID)
            varDescription = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varDescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal Company As String, ByVal DepartementCode As String, ByVal DepartementName As String, ByVal DepartementDescription As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim varSuccess As Boolean
            Try
                If RowID = "-1" Then
                    Dim Hash As String = CMCv.Security.Encrypt.MD5()
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[man]]departement](departement_id, departement_company, departement_code, departement_name, departement_description) " &
                                                            "values('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Company, DepartementCode, DepartementName, DepartementDescription)
                Else
                    varDBreader_mssql2008(1).Query = String.Format("update dbo.[[man]]departement] set departement_company = '{0}', departement_code = '{1}', departement_name = '{2}', departement_description = '{3}' " &
                                                            "where departement_id = '{4}'", Company, DepartementCode, DepartementName, DepartementDescription, RowID)
                End If

                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
