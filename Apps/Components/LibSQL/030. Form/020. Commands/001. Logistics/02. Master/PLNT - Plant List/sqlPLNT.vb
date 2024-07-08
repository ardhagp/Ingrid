﻿Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.PLNT
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim _Where As String = "where "

            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                _Where = String.Format("")
            Else
                _Where += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", Find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from " &
                                                    "dbo.[[man]]company] c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", _Where)

            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TPlant")

        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal RowID As String) As Boolean
            Dim V_Success As Boolean
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal CompanyCode As String, ByVal PlantCode As String, Optional ByVal RowID As String = "") As Boolean
            RowID = "0"
            Dim V_IsDuplicate As Boolean

            Try
                If RowID = String.Empty Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'")
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                End If

                V_IsDuplicate = Convert.ToBoolean(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query))

                Return V_IsDuplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETCompany(ByVal ListOfCompany As CMCv.cbo)
            V_DBR_MSSQL2008(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.[[man]]company] com order by com.company_code"
            V_DBR_MSSQL2008(1).Dropdown = ListOfCompany
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TCompany")
            ListOfCompany.DisplayMember = "company_name"
            ListOfCompany.ValueMember = "company_id"
        End Sub
    End Class
End Namespace
