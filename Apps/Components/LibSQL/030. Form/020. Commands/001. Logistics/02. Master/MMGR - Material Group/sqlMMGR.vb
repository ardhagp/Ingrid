Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMGR
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                varDBreader_mssql2008(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.[[log]]materialgroup] mg order by mg.materialgroup_id"
            Else
                varDBreader_mssql2008(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.[[log]]materialgroup] mg where " &
                                                        "(mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or " &
                                                        "(mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TMaterialGroup", "db_universe_erp")
        End Sub
    End Class
End Namespace
