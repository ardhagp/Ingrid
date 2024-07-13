﻿Imports System.Runtime.Versioning
Imports CMCv

Public Class CCIN_Editor

#Region "Variables"
    Private varSQLeditor As New LibSQL.Commands.CCIN.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"
    Private Sub CheckAllInput()
        'Call CheckAllControls()
        TxtCode.Focus()
        TxtName.Focus()
        TxtSearchTerm1.Focus()
        TxtSearchTerm2.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

#Region "Form Events"

    <SupportedOSPlatform("windows")>
    Private Sub CCIN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (varFORMAttribute.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            TxtCode.Text = Commands.CCIN.Editor.GETCompanyCode(varFORMAttribute.RowID)
            TxtName.Text = Commands.CCIN.Editor.GETCompanyName(varFORMAttribute.RowID)
            TxtSearchTerm1.Text = Commands.CCIN.Editor.GETSearchTerm1(varFORMAttribute.RowID)
            TxtSearchTerm2.Text = Commands.CCIN.Editor.GETSearchTerm2(varFORMAttribute.RowID)
            TxtDescription.Text = Commands.CCIN.Editor.GETDescription(varFORMAttribute.RowID)
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
        End If
    End Sub
#End Region

#Region "Component Events"
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (TxtCode.XOSQLText = String.Empty) OrElse (TxtName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Company Code & Company Name properly filled.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFORMAttribute.IsNew) AndAlso (Commands.CCIN.Editor.IsDuplicate(TxtCode.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already registered.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFORMAttribute.IsNew) AndAlso (Commands.CCIN.Editor.IsDuplicate(TxtCode.XOSQLText, varFORMAttribute.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already used by another company.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.CCIN.Editor.PUSHData(TxtCode.XOSQLText, TxtName.XOSQLText, TxtSearchTerm1.XOSQLText, TxtSearchTerm2.XOSQLText, TxtDescription.XOSQLText, varFORMAttribute.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtCode.Text = String.Empty
        TxtName.Text = String.Empty
        TxtSearchTerm1.Text = String.Empty
        TxtSearchTerm2.Text = String.Empty
        TxtDescription.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        End If
    End Sub
#End Region

End Class
