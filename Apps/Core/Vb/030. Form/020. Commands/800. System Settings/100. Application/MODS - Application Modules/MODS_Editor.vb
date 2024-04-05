Imports System.Runtime.Versioning
Imports CMCv

Public Class MODS_Editor
#Region "Variables"
    Private _SQL As New LibSQL.Commands.MODS.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collection"
    <SupportedOSPlatform("windows")>
    Private Sub FILLGroup(ByVal ModuleGroup As cbo)
        _SQL.FILLModuleGroup(ModuleGroup)
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
        DgnUserRoles.SLF_GETNewColor()

        Call FILLGroup(CboGroup)
        If (V_FORMAttrib.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
            CboGroup.Focus()
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            TxtID.Text = V_FORMAttrib.RowID
            CboGroup.SelectedValue = _SQL.GETMODGroupID(V_FORMAttrib.RowID)
            TxtCode.Text = _SQL.GETMODCode(V_FORMAttrib.RowID)
            TxtName.Text = _SQL.GETMODName(V_FORMAttrib.RowID)
            TxtDescription.Text = _SQL.GETMODDescription(V_FORMAttrib.RowID)
            ChkSystem.Checked = _SQL.GETMODSystem(V_FORMAttrib.RowID)
            ChkLocked.Checked = _SQL.GETMODLocked(V_FORMAttrib.RowID)
            TxtCode.ReadOnly = True
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Call CheckAllInput()

        If (CboGroup.Items.Count = 0) OrElse (TxtCode.SLFSQLText = String.Empty) OrElse (TxtName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Module Group selected, Module Code and Module Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(TxtCode.SLFSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(TxtCode.SLFSQLText, V_FORMAttrib.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (_SQL.PUSHData(TxtID.SLFSQLText, CboGroup.SelectedValue, TxtCode.SLFSQLText, TxtName.SLFSQLText, TxtDescription.SLFSQLText, ChkSystem.Checked, ChkLocked.Checked, V_FORMAttrib.RowID)) Then
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

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged
        If (V_FORMAttrib.IsNew) Then
            TxtID.Text = CMCv.Security.Encrypt.MD5(TxtCode.SLFSQLText.ToUpper)
        End If
    End Sub
End Class
