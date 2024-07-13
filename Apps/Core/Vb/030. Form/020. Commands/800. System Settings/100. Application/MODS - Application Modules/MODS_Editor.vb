Imports System.Runtime.Versioning
Imports CMCv

Public Class MODS_Editor
#Region "Variables"
    Private _SQL As New Commands.MODS.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collection"
    <SupportedOSPlatform("windows")>
    Private Sub FILLGroup(ByVal ModuleGroup As cbo)
        Commands.MODS.Editor.FILLModuleGroup(ModuleGroup)
    End Sub

    Private Sub CheckAllInput()
        TxtID.Focus()
        TxtCode.Focus()
        TxtName.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub MODS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgnUserRoles.XOGETNewColor()

        Call FILLGroup(CboGroup)
        If (varFORMAttribute.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
            CboGroup.Focus()
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            TxtID.Text = varFORMAttribute.RowID
            CboGroup.SelectedValue = Commands.MODS.Editor.GETMODGroupID(varFORMAttribute.RowID)
            TxtCode.Text = Commands.MODS.Editor.GETMODCode(varFORMAttribute.RowID)
            TxtName.Text = Commands.MODS.Editor.GETMODName(varFORMAttribute.RowID)
            TxtDescription.Text = Commands.MODS.Editor.GETMODDescription(varFORMAttribute.RowID)
            ChkSystem.Checked = Commands.MODS.Editor.GETMODSystem(varFORMAttribute.RowID)
            ChkLocked.Checked = Commands.MODS.Editor.GETMODLocked(varFORMAttribute.RowID)
            TxtCode.ReadOnly = True
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Call CheckAllInput()

        If (CboGroup.Items.Count = 0) OrElse (TxtCode.XOSQLText = String.Empty) OrElse (TxtName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Module Group selected, Module Code and Module Name are properly filled.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (varFORMAttribute.IsNew) AndAlso (Commands.MODS.Editor.IsDuplicate(TxtCode.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFORMAttribute.IsNew) AndAlso (Commands.MODS.Editor.IsDuplicate(TxtCode.XOSQLText, varFORMAttribute.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.MODS.Editor.PUSHData(TxtID.XOSQLText, CboGroup.SelectedValue.ToString, TxtCode.XOSQLText, TxtName.XOSQLText, TxtDescription.XOSQLText, ChkSystem.Checked, ChkLocked.Checked, varFORMAttribute.RowID)) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.Ts_status.Text = "Success"
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtID.Clear()
            TxtCode.Clear()
            TxtName.Clear()
            TxtDescription.Clear()
            ChkLocked.Checked = False
            TxtCode.ReadOnly = False
            TxtCode.Focus()
        Else
            Me.Close()
        End If

        RaiseEvent RecordSaved()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged
        If (varFORMAttribute.IsNew) Then
            TxtID.Text = CMCv.Security.Encrypt.MD5(TxtCode.XOSQLText.ToUpper)
        End If
    End Sub
End Class
