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

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call ExecLogin()
    End Sub

    Private Sub ExecLogin()
        If (TxtUsername.SLFSQLText = String.Empty) OrElse (TxtPassword.SLFSQLText = String.Empty) Then
            Return
        End If

        V_USERAttrib.UID = _SQL.GETUID(TxtUsername.SLFSQLText, TxtPassword.SLFSQLText, V_USERAttrib.FirstName)

        If V_USERAttrib.UID = String.Empty Then
            RaiseEvent LoginFailed()
            _WrongLogin += 1
            SLFStatus.Items(0).Text = "Login Failed"
            V_LOGUser.LoginFailed(TxtUsername.SLFSQLText)
            V_BRIDGE_LOG.SENDLOG(TxtUsername.SLFSQLText & " failed to login.", Bridge.Security.WRITELOG.LogType.Error)
            tmr_status.Enabled = True
            If _WrongLogin = 3 Then
                tmr_control.Enabled = True
            End If
        Else
            V_USERAttrib.EID = _SQL.GETEID(V_USERAttrib.UID)
            V_USERAttrib.FirstName = _SQL.GETFirstName(V_USERAttrib.UID)
            V_USERAttrib.EmployeeNumber = _SQL.GETEmployeeNumber(V_USERAttrib.UID)
            V_USERAttrib.Gender = _SQL.GETGender(V_USERAttrib.UID)
            V_USERAttrib.Position = _SQL.GETPosition(V_USERAttrib.UID)
            V_USERAttrib.IsAdministrator = _SQL.GETAdministrator(V_USERAttrib.UID)
            V_LOGUser.LoginSuccess(V_USERAttrib.EID)
            V_BRIDGE_LOG.SENDLOG(V_USERAttrib.FirstName & " is login.", Bridge.Security.WRITELOG.LogType.Information)
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
