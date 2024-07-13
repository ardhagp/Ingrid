Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMVT
    Public Class View
        'ReadOnly varDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                varDBreader_mssql2008(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;"
            Else
                varDBreader_mssql2008(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = Datagrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TMaterialValuation", "db_universe_erp")
        End Sub
    End Class
End Namespace
