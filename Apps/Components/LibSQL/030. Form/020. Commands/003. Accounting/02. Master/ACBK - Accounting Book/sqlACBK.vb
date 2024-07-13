Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.ACBK
    Public Class View

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim varWhere As String = "where "

            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                varWhere = ""
            Else
                varWhere += String.Format("c.company_code like '%{0}%' and ab.book_code like '%{0}%' and ab.book_bookname like '%{0}%'", Find.XOSQLText)
            End If

            varDBreader_mssql2008(0).Query = String.Format("select ab.book_id, c.company_code, ab.book_code, ab.book_bookname, ab.book_datecreated from dbo.[[ac]]book] ab inner join dbo.[[man]]company] c on " &
                                                    "ab.book_company = c.company_id {0}", varWhere)

            varDBreader_mssql2008(0).DataGrid = Datagrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TAccountingBook", "db_universe_erp")
        End Sub
    End Class
End Namespace
