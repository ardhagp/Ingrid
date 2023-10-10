Imports CMCv

Public Class UAC_Editor

#Region "Variables"
    Private _SQL As New LibSQL.Commands.UAC.Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _AddinEmployee As New UAC_Employee
    Private _IsAdminstrator As Boolean
    Private _PWDChange As Boolean = False
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"
    Private Sub GETDATA()
        _SQL.DisplayData(DgnUACe, V_FORMAttrib.RowID)
    End Sub

    Private Sub CheckAllInput()
        TxtEmployeeNumber.Focus()
        TxtEmployeeFullName.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub _AddinEmployee_RecordSelected() Handles _AddinEmployee.RecordSelected
        TxtEmployeeNumber.Text = IIf(IsDBNull(V_FORMAttrib.Field02), "", V_FORMAttrib.Field02)
        TxtEmployeeFullName.Text = V_FORMAttrib.Field03
    End Sub

    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        _AddinEmployee = New UAC_Employee
        DISPLAY(_AddinEmployee, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Employee", "Browse for employee data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        V_FORMAttrib.IsChangePasswordForm = False
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UAC_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me, True)
        _MMSMenu.ShowMenuFILE(UI.View.MenuStrip.ShowItem.Yes)

        DgnUACe.SLF_GETNewColor()

        If (V_FORMAttrib.IsChangePasswordForm) Then
            TbctlAccess.Visible = False
            ProgressBar1.Visible = False
            TxtEmployeeNumber.Width = 274
            LblPwdText.Visible = False
            Me.Height = 351
            Me.Width = 451
        End If

        If (V_FORMAttrib.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            BtnBrowseEmployee.Visible = False
            TxtEmployeeNumber.Text = _SQL.GETEmployeeNumber(V_FORMAttrib.RowID)
            TxtEmployeeFullName.Text = _SQL.GETEmployeeFullName(V_FORMAttrib.RowID)
            TxtUsername.Text = _SQL.GETUsernameByUserID(V_FORMAttrib.RowID)
            V_FORMAttrib.Password = _SQL.GETPassword(V_FORMAttrib.RowID)
            ChkLocked.Checked = _SQL.GETLocked(V_FORMAttrib.RowID)
            _IsAdminstrator = _SQL.GETAdministrator(V_USERAttrib.UID)
            ChkAdministrator.Checked = _SQL.GETAdministrator(V_FORMAttrib.RowID)
            If (_IsAdminstrator) AndAlso Not (V_FORMAttrib.IsChangePasswordForm) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = V_FORMAttrib.Password
        End If
        TxtPassword.SLFPwdLengthMin = _MINPASSWORDLENGTH
        Call GETDATA()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If ((V_FORMAttrib.IsNew) AndAlso (V_FORMAttrib.Field01 = String.Empty)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Employee data selected.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtUsername.SLFSQLText = String.Empty) OrElse (TxtPassword.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Username and Password properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((_PWDChange) AndAlso (TxtPassword.TextLength < _MINPASSWORDLENGTH)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure your Password meets the minimum criteria.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(TxtUsername.SLFSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(TxtUsername.SLFSQLText, V_FORMAttrib.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call CheckPWDChange()

        If (_SQL.PUSHData(V_FORMAttrib.Field01, TxtUsername.SLFSQLText, V_SECEncrypt.MD5(TxtPassword.SLFSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, V_FORMAttrib.RowID, V_FORMAttrib.Hash, _PWDChange)) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.ts_status.Text = "Success"
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            V_FORMAttrib.Hash = V_SECEncrypt.MD5
            TxtEmployeeNumber.Clear()
            TxtEmployeeFullName.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckPWDChange()
        If TxtPassword.SLFSQLText = V_FORMAttrib.Password Then
            _PWDChange = False
        Else
            _PWDChange = True
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPWDChange()

        If (_PWDChange) Then
            LblPwdText.Text = TxtPassword.SLFPwdStrengthText
            ProgressBar1.Value = TxtPassword.SLFPwdStrengthScore
        End If
    End Sub
End Class
