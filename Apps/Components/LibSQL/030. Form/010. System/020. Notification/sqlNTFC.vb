Imports System.Runtime.Versioning

Namespace Commands.NTFC
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAY(ByVal NotificationGrid As CMCv.dgn, ByVal EID As String)
            varDBreader_mssql2008(0).Query = String.Format("select top 100 ((case nt.notification_isread when 0 then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", EID)

            varDBreader_mssql2008(0).DataGrid = NotificationGrid
            varDBreader_mssql2008(0).StatusBar = Nothing
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TNotification", "db_universe_erp")

            varDBreader_mssql2008(1).Query = String.Format("update dbo.[[sys]]notification] set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", EID)
            varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
        End Sub
    End Class
End Namespace
