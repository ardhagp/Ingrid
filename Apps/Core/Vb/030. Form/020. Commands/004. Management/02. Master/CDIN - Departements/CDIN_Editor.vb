Imports System.Runtime.Versioning
Imports CMCv

Public Class CDIN_Editor

#Region "Variables"
    Public Event RecordSaved()
    Private _SQL As New LibSQL.Commands.CDIN.Editor
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub FILLCompany(ByVal Company As cbo)
        _SQL.FILLCompany(Company)
    End Sub

    Private Sub CheckAllInput()
        CboCompany.Focus()
        TxtDeptCode.Focus()
        TxtDeptName.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CDIN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FILLCompany(CboCompany)
        If V_FORMAttrib.RowID = "-1" Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
            CboCompany.SelectedValue = _SQL.GETCompanyID(V_FORMAttrib.RowID)
            TxtDeptCode.Text = _SQL.GETDeptCode(V_FORMAttrib.RowID)
            TxtDeptName.Text = _SQL.GETDeptName(V_FORMAttrib.RowID)
            TxtDescription.Text = _SQL.GETDescription(V_FORMAttrib.RowID)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If (CboCompany.Items.Count = 0) OrElse (TxtDeptCode.SLFSQLText = String.Empty) OrElse (TxtDeptName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Company Code selected, Departement Code and Departement Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(CboCompany.SelectedValue, TxtDeptCode.SLFSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(CboCompany.SelectedValue, TxtDeptCode.SLFSQLText, V_FORMAttrib.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (_SQL.PUSHData(CboCompany.SelectedValue, TxtDeptCode.SLFSQLText, TxtDeptName.SLFSQLText, TxtDescription.SLFSQLText, V_FORMAttrib.RowID)) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.Ts_status.Text = "Success"
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtDeptCode.Clear()
            TxtDeptName.Clear()
            TxtDescription.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
