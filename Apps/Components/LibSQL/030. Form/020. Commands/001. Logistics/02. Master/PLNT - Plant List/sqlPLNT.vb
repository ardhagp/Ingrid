Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.PLNT
    Public Class View
        'ReadOnly varDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim varWhere As String = "where "

            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", Find.XOSQLText)
            End If

            varDBreader_mssql2008(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from " &
                                                    "dbo.[[man]]company] c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", varWhere)

            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TPlant", "db_universe_erp")

        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal CompanyCode As String, ByVal PlantCode As String, Optional ByVal RowID As String = "") As Boolean
            RowID = "0"
            Dim varISduplicate As Boolean

            Try
                If RowID = String.Empty Then
                    varDBreader_mssql2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'")
                Else
                    varDBreader_mssql2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                End If

                varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Boolean)

                Return varISduplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETCompany(ByVal ListOfCompany As CMCv.cbo)
            varDBreader_mssql2008(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.[[man]]company] com order by com.company_code"
            varDBreader_mssql2008(1).Dropdown = ListOfCompany
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TCompany", "db_universe_erp")
            ListOfCompany.DisplayMember = "company_name"
            ListOfCompany.ValueMember = "company_id"
        End Sub
    End Class
End Namespace
