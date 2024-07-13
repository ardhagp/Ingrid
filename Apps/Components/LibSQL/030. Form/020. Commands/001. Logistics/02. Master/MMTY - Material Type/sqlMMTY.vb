Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMTY
    Public Class View
        'ReadOnly varDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                varDBreader_mssql2008(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.[[log]]material] m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.[[log]]materialtype] mt"
            Else
                varDBreader_mssql2008(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.[[log]]material] m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.[[log]]materialtype] mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TMaterialType", "db_universe_erp")
        End Sub
    End Class
End Namespace
