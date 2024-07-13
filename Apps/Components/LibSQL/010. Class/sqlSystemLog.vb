Imports System.Runtime.Versioning

Namespace SystemLog.Activity

    Public Class User
        ReadOnly varDBreader_mssql2008(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub LoginFailed(ByVal Username As String)
            Try
                varDBreader_mssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'Failed login with username : {0}', '{1}', '{2}', '{3}');", Username, My.Computer.Name, My.Computer.Info.OSFullName, varVersionapplication)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(0), "db_universe_erp")
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub LoginSuccess(ByVal EID As String)
            Try
                varDBreader_mssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Login Success', '{1}', '{2}', '{3}');", EID, My.Computer.Name, My.Computer.Info.OSFullName, varVersionapplication)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(0), "db_universe_erp")
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Logout(ByVal EID As String)
            Try
                varDBreader_mssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Logout', '{1}', '{2}', '{3}');", EID, My.Computer.Name, My.Computer.Info.OSFullName, varVersionapplication)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(0), "db_universe_erp")
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class

    Public Class Application
        ReadOnly varDBreader_mssql2008(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub Run()
            Try
                varDBreader_mssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'INGRID start running.', '{0}', '{1}', '{2}');", My.Computer.Name, My.Computer.Info.OSFullName, varVersionapplication)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(0), "db_universe_erp")
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class
End Namespace
