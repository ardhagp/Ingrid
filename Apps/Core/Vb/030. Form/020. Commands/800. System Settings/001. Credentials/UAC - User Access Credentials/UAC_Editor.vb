Imports System.Runtime.Versioning
Imports CMCv

Public Class UAC_Editor

#Region "Variables"
    Private clsSQLeditor As New Commands.UAC.Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
    Private WithEvents frmAddinemployee As New UAC_Employee
    Private varISadminstrator As Boolean
    Private varISpasswordchange As Boolean = False
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        Commands.UAC.Editor.DisplayData(DgnUACe, frmAttribute.RowID)
    End Sub

    Private Sub CheckAllInput()
        TxtEmployeeNumber.Focus()
        TxtEmployeeFullName.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub _AddinEmployee_RecordSelected() Handles frmAddinemployee.RecordSelected
        TxtEmployeeNumber.Text = IIf(IsDBNull(frmAttribute.Field02), "", frmAttribute.Field02).ToString
        TxtEmployeeFullName.Text = frmAttribute.Field03.ToString
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        frmAddinemployee = New UAC_Employee
        DISPLAY(frmAddinemployee, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Employee", "Browse for employee data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        frmAttribute.IsChangePasswordForm = False
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub UAC_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me, True)
            .ShowMenuFILE(UI.View.MenuStrip.ShowItem.Yes)
        End With

        DgnUACe.XOGETNewColor()

        If (frmAttribute.IsChangePasswordForm) Then
            TbctlAccess.Visible = False
            ProgressBar1.Visible = False
            TxtEmployeeNumber.Width = 274
            LblPwdText.Visible = False
            Me.Height = 351
            Me.Width = 451
        End If

        If (frmAttribute.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            BtnBrowseEmployee.Visible = False
            TxtEmployeeNumber.Text = Commands.UAC.Editor.GETEmployeeNumber(frmAttribute.RowID)
            TxtEmployeeFullName.Text = Commands.UAC.Editor.GETEmployeeFullName(frmAttribute.RowID)
            TxtUsername.Text = Commands.UAC.Editor.GETUsernameByUserID(frmAttribute.RowID)
            frmAttribute.Password = Commands.UAC.Editor.GETPassword(frmAttribute.RowID)
            ChkLocked.Checked = Commands.UAC.Editor.GETLocked(frmAttribute.RowID)
            varISadminstrator = Commands.UAC.Editor.GETAdministrator(varUSERattribute.UID)
            ChkAdministrator.Checked = Commands.UAC.Editor.GETAdministrator(frmAttribute.RowID)
            If (varISadminstrator) AndAlso Not (frmAttribute.IsChangePasswordForm) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = frmAttribute.Password
        End If
        TxtPassword.XOPwdLengthMin = varMinpasswordlength
        Call GETDATA()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If ((frmAttribute.IsNew) AndAlso (frmAttribute.Field01.ToString Is String.Empty)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Employee data selected.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Username and Password properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((varISpasswordchange) AndAlso (TxtPassword.TextLength < varMinpasswordlength)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure your Password meets the minimum criteria.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((frmAttribute.IsNew) AndAlso (Commands.UAC.Editor.IsDuplicate(TxtUsername.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (frmAttribute.IsNew) AndAlso (Commands.UAC.Editor.IsDuplicate(TxtUsername.XOSQLText, frmAttribute.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call CheckPWDChange()

        If (Commands.UAC.Editor.PUSHData(frmAttribute.Field01.ToString, TxtUsername.XOSQLText, CMCv.Security.Encrypt.MD5(TxtPassword.XOSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, frmAttribute.RowID, frmAttribute.Hash, varISpasswordchange)) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.Ts_status.Text = "Success"
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            frmAttribute.Hash = CMCv.Security.Encrypt.MD5()
            TxtEmployeeNumber.Clear()
            TxtEmployeeFullName.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckPWDChange()
        If TxtPassword.XOSQLText = frmAttribute.Password Then
            varISpasswordchange = False
        Else
            varISpasswordchange = True
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPWDChange()

        If (varISpasswordchange) Then
            LblPwdText.Text = TxtPassword.XOPwdStrengthText
            ProgressBar1.Value = TxtPassword.XOPwdStrengthScore
        End If
    End Sub
End Class
