Imports System.Runtime.Versioning
Imports CMCv

Public Class POST_Editor
#Region "Variables"
    Public clsSQL As New LibSQL.Commands.POST.Editor
    Public varISfirstload As Boolean
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

    Public Sub CheckAllInput()
        CboCompany.Focus()
        CboDepartement.Focus()
        TxtPositionCode.Focus()
        TxtPositionName.Focus()
        BtnSave.Focus()
    End Sub

    'Private sub clsSQL as libsql.com
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub POST_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        varISfirstload = True
        clsSQL.FILLCompany(CboCompany)
        clsSQL.FILLDepartement(CboDepartement, CboCompany)

        If (frmAttribute.IsNew) Then
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = LibSQL.Commands.POST.Editor.GETCompanyID(frmAttribute.RowID)
            clsSQL.FILLDepartement(CboDepartement, CboCompany)
            CboDepartement.SelectedValue = LibSQL.Commands.POST.Editor.GETDepartementID(frmAttribute.RowID)
            TxtPositionCode.Text = LibSQL.Commands.POST.Editor.GETPositionCode(frmAttribute.RowID)
            TxtPositionName.Text = LibSQL.Commands.POST.Editor.GETPositionName(frmAttribute.RowID)
            TxtPositionDescription.Text = LibSQL.Commands.POST.Editor.GETPositionDescription(frmAttribute.RowID)
        End If

        varISfirstload = False
        '#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (varISfirstload) Then
            clsSQL.FILLDepartement(CboDepartement, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (CboDepartement.Items.Count = 0) OrElse (TxtPositionCode.XOSQLText = String.Empty) OrElse (TxtPositionName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Departement selected, Postition Code and Position Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((frmAttribute.IsNew) AndAlso (LibSQL.Commands.POST.Editor.IsDuplicate(CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, frmAttribute.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (frmAttribute.IsNew) AndAlso (LibSQL.Commands.POST.Editor.IsDuplicate(CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, frmAttribute.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (LibSQL.Commands.POST.Editor.PUSHData(CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, TxtPositionName.XOSQLText, TxtPositionDescription.XOSQLText, frmAttribute.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtPositionCode.Clear()
            TxtPositionName.Clear()
            TxtPositionDescription.Clear()
            TxtPositionCode.Focus()
        Else
            Me.Close()
        End If
    End Sub
End Class
