Imports System.Runtime.Versioning
Imports CMCv

Public Class UAC_Editor

#Region "Variables"
    Private clsSQLeditor As New Commands.UAC.Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
    Private WithEvents frmUACemployee As New UAC_Employee
    Private varISadminstrator As Boolean
    Private varISpasswordchanged As Boolean = False
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        Commands.UAC.Editor.DisplayData(DgnUACe, varFORMAttribute.RowID)
    End Sub

    Private Sub CheckAllInput()
        TxtEmployeeNumber.Focus()
        TxtEmployeeFullName.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub _AddinEmployee_RecordSelected() Handles frmUACemployee.RecordSelected
        TxtEmployeeNumber.Text = IIf(IsDBNull(varFORMAttribute.Field02), "", varFORMAttribute.Field02).ToString
        TxtEmployeeFullName.Text = varFORMAttribute.Field03.ToString
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        frmUACemployee = New UAC_Employee
        DISPLAY(frmUACemployee, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Employee", "Browse for employee data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        varFORMAttribute.IsChangePasswordForm = False
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub UAC_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsMMSmenu.LoadIn(Me, True)
        clsMMSmenu.ShowMenuFILE(UI.View.MenuStrip.ShowItem.Yes)

        DgnUACe.XOGETNewColor()

        If (varFORMAttribute.IsChangePasswordForm) Then
            TbctlAccess.Visible = False
            ProgressBar1.Visible = False
            TxtEmployeeNumber.Width = 274
            LblPwdText.Visible = False
            Me.Height = 351
            Me.Width = 451
        End If

        If (varFORMAttribute.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            BtnBrowseEmployee.Visible = False
            TxtEmployeeNumber.Text = Commands.UAC.Editor.GETEmployeeNumber(varFORMAttribute.RowID)
            TxtEmployeeFullName.Text = Commands.UAC.Editor.GETEmployeeFullName(varFORMAttribute.RowID)
            TxtUsername.Text = Commands.UAC.Editor.GETUsernameByUserID(varFORMAttribute.RowID)
            varFORMAttribute.Password = Commands.UAC.Editor.GETPassword(varFORMAttribute.RowID)
            ChkLocked.Checked = Commands.UAC.Editor.GETLocked(varFORMAttribute.RowID)
            varISadminstrator = Commands.UAC.Editor.GETAdministrator(varUSERAttribute.UID)
            ChkAdministrator.Checked = Commands.UAC.Editor.GETAdministrator(varFORMAttribute.RowID)
            If (varISadminstrator) AndAlso Not (varFORMAttribute.IsChangePasswordForm) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = varFORMAttribute.Password
        End If
        TxtPassword.XOPwdLengthMin = varMinpasswordlength
        Call GETDATA()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If ((varFORMAttribute.IsNew) AndAlso (varFORMAttribute.Field01.ToString Is String.Empty)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Employee data selected.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Username and Password properly filled.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf ((varISpasswordchanged) AndAlso (TxtPassword.TextLength < varMinpasswordlength)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure your Password meets the minimum criteria.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFORMAttribute.IsNew) AndAlso (Commands.UAC.Editor.IsDuplicate(TxtUsername.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already registered.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFORMAttribute.IsNew) AndAlso (Commands.UAC.Editor.IsDuplicate(TxtUsername.XOSQLText, varFORMAttribute.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already used by another employee.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call CheckPWDChange()

        If (Commands.UAC.Editor.PUSHData(varFORMAttribute.Field01.ToString, TxtUsername.XOSQLText, CMCv.Security.Encrypt.MD5(TxtPassword.XOSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, varFORMAttribute.RowID, varFORMAttribute.Hash, varISpasswordchanged)) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.Ts_status.Text = "Success"
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            varFORMAttribute.Hash = CMCv.Security.Encrypt.MD5()
            TxtEmployeeNumber.Clear()
            TxtEmployeeFullName.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckPWDChange()
        If TxtPassword.XOSQLText = varFORMAttribute.Password Then
            varISpasswordchanged = False
        Else
            varISpasswordchanged = True
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPWDChange()

        If (varISpasswordchanged) Then
            LblPwdText.Text = TxtPassword.XOPwdStrengthText
            ProgressBar1.Value = TxtPassword.XOPwdStrengthScore
        End If
    End Sub
End Class
