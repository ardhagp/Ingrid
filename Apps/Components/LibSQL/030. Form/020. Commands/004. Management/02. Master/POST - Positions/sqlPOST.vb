Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.POST
    Public Class View
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal Grid As Dgn, ByVal Status As Stt, ByVal Find As Txt, Optional ByVal ForceRefresh As Boolean = False)
            'ReDim varDBreader_mssql2008(2)
            Dim varWhere As String = "where "

            If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format("(c.company_code Like '%{0}%') or (d.departement_code like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%')", Find.XOSQLText)
            End If

            varDBreader_mssql2008(0).Query = String.Format("select c.company_code, d.departement_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from dbo.[[man]]position] ps " &
                                                    "inner join dbo.[[man]]departement] d on d.departement_id = ps.position_departement inner join dbo.[[man]]company] c on c.company_id = d.departement_company {0} " &
                                                    "order by c.company_code, d.departement_code, ps.position_code", varWhere)

            varDBreader_mssql2008(0).DataGrid = Grid
            varDBreader_mssql2008(0).StatusBar = Status
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TPositions", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean

            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[man]]position] where (position_id = '{0}')", RowID)
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
        Public Sub FILLCompany(ByVal Company As Cbo)
            varDBreader_mssql2008(0).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as [company_name] from dbo.[[man]]company] c order by c.company_code"
            varDBreader_mssql2008(0).Dropdown = Company
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TCompany", "db_universe_erp")
            Company.ValueMember = "company_id"
            Company.DisplayMember = "company_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub FILLDepartement(ByVal Departement As Cbo, ByVal Company As Cbo)
            Dim varDepartment As String = String.Empty

            If Not Company.Items.Count = 0 Then
                varDepartment = Company.SelectedValue.ToString
            End If

            varDBreader_mssql2008(0).Query = String.Format("select d.departement_id, (d.departement_code + ' - ' + d.departement_name) as [departement_code] from dbo.[[man]]departement] d where d.departement_company = '{0}' " &
                                                    "order by d.departement_code", varDepartment)
            varDBreader_mssql2008(0).Dropdown = Departement
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "Departement", "db_universe_erp")
            Departement.ValueMember = "departement_id"
            Departement.DisplayMember = "departement_code"
        End Sub

        <SupportedOSPlatform("Windows")>
        Public Shared Function GETCompanyID(ByVal RowID As String) As String
            Dim varCompanyid As String

            varDBreader_mssql2008(0).Query = String.Format("select d.departement_company from dbo.[[man]]position] ps inner join dbo.[[man]]departement] d on d.departement_id = ps.position_departement " &
            "where ps.position_id = '{0}'", RowID)
            varCompanyid = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varCompanyid
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDepartementID(ByVal RowID As String) As String
            Dim varDepartmentid As String

            varDBreader_mssql2008(0).Query = String.Format("select ps.position_departement from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            varDepartmentid = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varDepartmentid
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionCode(ByVal RowID As String) As String
            Dim varPostitioncode As String

            varDBreader_mssql2008(0).Query = String.Format("select ps.position_code from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            varPostitioncode = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varPostitioncode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionName(ByVal RowID As String) As String
            Dim varPostitionname As String

            varDBreader_mssql2008(0).Query = String.Format("select ps.position_name from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            varPostitionname = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varPostitionname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionDescription(ByVal RowID As String) As String
            Dim varPostitiondescription As String

            varDBreader_mssql2008(0).Query = String.Format("select ps.position_description from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            varPostitiondescription = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varPostitiondescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal Departement As String, ByVal PositionCode As String, ByVal RowID As String) As Boolean
            Dim varISduplicate As Integer
            Dim varWhere As String = "where "

            If RowID = "-1" Then
                varWhere += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}')", Departement, PositionCode)
            Else
                varWhere += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}' and ps.position_id <> '{2}')", Departement, PositionCode, RowID)
            End If

            varDBreader_mssql2008(0).Query = String.Format("select (ps.position_id) as [rows] from dbo.[[man]]position] ps {0}", varWhere)

            varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

            If varISduplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal Departement As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim varSuccess As Boolean

            Try
                If RowID = "-1" Then
                    Dim Hash As String = CMCv.Security.Encrypt.MD5()
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[man]]position](position_id, position_departement, position_code, position_name, position_description) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Departement, Code, Name, Description)
                Else
                    varDBreader_mssql2008(1).Query = String.Format("update dbo.[[man]]position] set position_departement = '{0}', position_code = '{1}', position_name = '{2}', position_description = '{3}' " &
                                                            "where position_id = '{4}'", Departement, Code, Name, Description, RowID)
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
