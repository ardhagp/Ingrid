Imports System.Runtime.Versioning

Public Class LOGIN
#Region "Variables"
    Private clsSQL As New LibSQL.Commands.UAC.Login
    Public Event LoginSuccess()
    Public Event LoginFailed()
    Private varLoginwrong As Integer
    Private varLoginhold As Integer
    Private varStatustimer As Integer
#End Region

#Region "Subs Collection"
    Private Sub CheckAllInput()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnLogin.Focus()
    End Sub
#End Region

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        RaiseEvent LoginFailed()
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call ExecLogin()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ExecLogin()
        If (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Return
        End If

        varUSERattribute.UID = Commands.UAC.Login.GETUID(TxtUsername.XOSQLText, TxtPassword.XOSQLText, varUSERattribute.FirstName)

        If varUSERattribute.UID = String.Empty Then
            RaiseEvent LoginFailed()
            varLoginwrong += 1
            SLFStatus.Items(0).Text = "Login Failed"
            varLOGUser.LoginFailed(TxtUsername.XOSQLText)
            Bridge.Security.Writelog.Sendlog(TxtUsername.XOSQLText & " failed to login.", Bridge.Security.Writelog.LogType.Error)
            tmr_status.Enabled = True
            If varLoginwrong = 3 Then
                tmr_control.Enabled = True
            End If
        Else
            With varUSERAttribute
                .EID = Commands.UAC.Login.GETEID(varUSERAttribute.UID)
                .FirstName = Commands.UAC.Login.GETFirstName(varUSERAttribute.UID)
                .EmployeeNumber = Commands.UAC.Login.GETEmployeeNumber(varUSERAttribute.UID)
                .Gender = Commands.UAC.Login.GETGender(varUSERAttribute.UID)
                .Position = Commands.UAC.Login.GETPosition(varUSERAttribute.UID)
                .IsAdministrator = Commands.UAC.Login.GETAdministrator(varUSERAttribute.UID)
            End With

            varLOGUser.LoginSuccess(varUSERAttribute.EID)
            Bridge.Security.Writelog.Sendlog(varUSERattribute.FirstName & " is login.", Bridge.Security.Writelog.LogType.Information)
            RaiseEvent LoginSuccess()
            Me.Close()
        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varLoginwrong = 0
        varLoginhold = 15
        SLFStatus.Items(0).Text = String.Empty
        TxtUsername.Clear()
        TxtPassword.Clear()
        TxtUsername.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ExecLogin()
        End If
    End Sub

    Private Sub tmr_status_Tick(sender As Object, e As EventArgs) Handles tmr_status.Tick
        If varStatustimer = 5 Then
            SLFStatus.Items(0).Text = ""
            tmr_status.Enabled = False
            varStatustimer = 0
        Else
            varStatustimer += 1
        End If
    End Sub

    Private Sub tmr_control_Tick(sender As Object, e As EventArgs) Handles tmr_control.Tick
        If varLoginhold = 30 Then
            tmr_control.Enabled = False
            TxtUsername.Text = String.Empty
            TxtPassword.Text = String.Empty
            TxtUsername.Enabled = True
            TxtPassword.Enabled = True
            BtnLogin.Enabled = True
            BtnCancel.Enabled = True
            TxtUsername.Focus()
            varLoginwrong = 0
            varLoginhold = 0
        Else
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            BtnLogin.Enabled = False
            BtnCancel.Enabled = False
            varLoginhold += 1
        End If
    End Sub

    Private Sub LOGIN_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
End Class
