Imports System.Runtime.Versioning

Public Class LOGIN
#Region "Variables"
    Private _SQL As New LibSQL.Commands.UAC.Login
    Public Event LoginSuccess()
    Public Event LoginFailed()
    Private _WrongLogin As Integer
    Private _HoldLogin As Integer
    Private _StatusTimer As Integer
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

        V_USERAttrib.UID = Commands.UAC.Login.GETUID(TxtUsername.XOSQLText, TxtPassword.XOSQLText, V_USERAttrib.FirstName)

        If V_USERAttrib.UID = String.Empty Then
            RaiseEvent LoginFailed()
            _WrongLogin += 1
            SLFStatus.Items(0).Text = "Login Failed"
            V_LOGUser.LoginFailed(TxtUsername.XOSQLText)
            Bridge.Security.WRITELOG.SENDLOG(TxtUsername.XOSQLText & " failed to login.", Bridge.Security.WRITELOG.LogType.Error)
            tmr_status.Enabled = True
            If _WrongLogin = 3 Then
                tmr_control.Enabled = True
            End If
        Else
            V_USERAttrib.EID = Commands.UAC.Login.GETEID(V_USERAttrib.UID)
            V_USERAttrib.FirstName = Commands.UAC.Login.GETFirstName(V_USERAttrib.UID)
            V_USERAttrib.EmployeeNumber = Commands.UAC.Login.GETEmployeeNumber(V_USERAttrib.UID)
            V_USERAttrib.Gender = Commands.UAC.Login.GETGender(V_USERAttrib.UID)
            V_USERAttrib.Position = Commands.UAC.Login.GETPosition(V_USERAttrib.UID)
            V_USERAttrib.IsAdministrator = Commands.UAC.Login.GETAdministrator(V_USERAttrib.UID)
            V_LOGUser.LoginSuccess(V_USERAttrib.EID)
            Bridge.Security.WRITELOG.SENDLOG(V_USERAttrib.FirstName & " is login.", Bridge.Security.WRITELOG.LogType.Information)
            RaiseEvent LoginSuccess()
            Me.Close()
        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _WrongLogin = 0
        _HoldLogin = 15
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
        If _StatusTimer = 5 Then
            SLFStatus.Items(0).Text = ""
            tmr_status.Enabled = False
            _StatusTimer = 0
        Else
            _StatusTimer += 1
        End If
    End Sub

    Private Sub tmr_control_Tick(sender As Object, e As EventArgs) Handles tmr_control.Tick
        If _HoldLogin = 30 Then
            tmr_control.Enabled = False
            TxtUsername.Text = String.Empty
            TxtPassword.Text = String.Empty
            TxtUsername.Enabled = True
            TxtPassword.Enabled = True
            BtnLogin.Enabled = True
            BtnCancel.Enabled = True
            TxtUsername.Focus()
            _WrongLogin = 0
            _HoldLogin = 0
        Else
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            BtnLogin.Enabled = False
            BtnCancel.Enabled = False
            _HoldLogin += 1
        End If
    End Sub

    Private Sub LOGIN_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
End Class
