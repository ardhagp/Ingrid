Imports System
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace Commands.REMS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayGrid(ByVal ProgressGrid As dgn, ByVal DoneGrid As dgn, ByVal VerifiedGrid As dgn, ByVal TodoStatusBar As stt, Optional ByVal ShowAll As Boolean = False)

            Try
                Dim varWhere As String = "where td.todos_iscomplete = 0 "

                If ShowAll = True Then
                    varWhere += ""
                Else
                    varWhere += "and (td.todos_ispublic=1 or (td.todos_ispublic=0 and (td.todos_id in (select tdc.todosworker_todos from [[cus]]todosworker] tdc where tdc.todosworker_employee = 'A23DA83B6023AA21A45BD87E73E23494') or td.todos_createdby = 'A23DA83B6023AA21A45BD87E73E23494')))"
                End If

                varDBreader_mssql2008(0).Query = String.Format("select td.todos_id, td.todos_name, td.todos_datestart, td.todos_dateend, td.todos_dayleft, td.todos_priority, td.todos_totalvalue, td.todos_currentvalue, td.todos_pfrmErrorentage, td.todos_instruction, td.todos_createdby, td.todos_datecreated, td.todos_iscomplete, td.todos_completedby, td.todos_verifiedby, td.todos_ispublic from db_universe_erp.dbo.[[cus]]todos] td {0} order by td.todos_priority, td.todos_datestart asc", varWhere)

                varDBreader_mssql2008(0).DataGrid = ProgressGrid
                varDBreader_mssql2008(0).StatusBar = TodoStatusBar
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TToDosProgress", "db_universe_erp")

            Catch ex As Exception

            End Try
        End Sub
    End Class

    Public Class Editor
        'TODO: Build
    End Class
End Namespace
