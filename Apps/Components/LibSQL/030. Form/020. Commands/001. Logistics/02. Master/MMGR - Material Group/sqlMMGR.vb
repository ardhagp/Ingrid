﻿Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMGR
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                V_DBR_MSSQL2008(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.[[log]]materialgroup] mg order by mg.materialgroup_id"
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.[[log]]materialgroup] mg where " &
                                                        "(mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or " &
                                                        "(mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", Find.XOSQLText)
            End If
            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TMaterialGroup")
        End Sub
    End Class
End Namespace
