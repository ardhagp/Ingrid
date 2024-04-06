﻿Imports System.Runtime.Versioning
Imports CMCv

Public Class CCIN_Editor

#Region "Variables"
    Public Event RecordSaved()
    Private _SQL As New LibSQL.Commands.CCIN.Editor
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
        If (V_FORMAttrib.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            TxtCode.Text = Commands.CCIN.Editor.GETCompanyCode(V_FORMAttrib.RowID)
            TxtName.Text = Commands.CCIN.Editor.GETCompanyName(V_FORMAttrib.RowID)
            TxtSearchTerm1.Text = Commands.CCIN.Editor.GETSearchTerm1(V_FORMAttrib.RowID)
            TxtSearchTerm2.Text = Commands.CCIN.Editor.GETSearchTerm2(V_FORMAttrib.RowID)
            TxtDescription.Text = Commands.CCIN.Editor.GETDescription(V_FORMAttrib.RowID)
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
            Decision("Cannot save your record." & Environment.NewLine & "Company Code & Company Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((V_FORMAttrib.IsNew) AndAlso (Commands.CCIN.Editor.IsDuplicate(TxtCode.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (V_FORMAttrib.IsNew) AndAlso (Commands.CCIN.Editor.IsDuplicate(TxtCode.XOSQLText, V_FORMAttrib.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already used by another company.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.CCIN.Editor.PUSHData(TxtCode.XOSQLText, TxtName.XOSQLText, TxtSearchTerm1.XOSQLText, TxtSearchTerm2.XOSQLText, TxtDescription.XOSQLText, V_FORMAttrib.RowID)) Then
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
