﻿Imports System.Runtime.Versioning
Imports CMCv

Public Class ACGR_Editor

#Region "Variables"
    Private _Size As New Size(566, 445)
    Private _SQL As New Commands.ACGR.Editor
    Private _FirstLoad As Boolean
    Public Event RecordSaved()
#End Region

#Region "Sub Collections"
    Private Sub CheckAllInput()
        CboCompany.Focus()
        CboAccountingBook.Focus()
        TxtAccountNumber.Focus()
        TxtAccountName.Focus()
        BtnSave.Focus()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub frmACGR_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = _Size
        Me.MinimumSize = Me.Size

        _FirstLoad = True
        'Fill cbo Plant
        Commands.ACGR.Editor.FILLCompany(CboCompany)

        'Fill Cbo Accounting Book
        Commands.ACGR.Editor.FILLAccountingBook(CboAccountingBook, CboCompany)

        'Fill Account Group
        Commands.ACGR.Editor.FILLAccountGroup(CboAccountGroup)

        If (V_FORMAttrib.IsNew) Then
            ChkEnable.Checked = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = Commands.ACGR.Editor.GETCompanyID(V_FORMAttrib.RowID)
            Commands.ACGR.Editor.FILLAccountingBook(CboAccountingBook, CboCompany)
            CboAccountingBook.SelectedValue = Commands.ACGR.Editor.GETAccountBookID(V_FORMAttrib.RowID)
            CboAccountGroup.SelectedValue = Commands.ACGR.Editor.GETAccountGroupID(V_FORMAttrib.RowID)
            TxtAccountNumber.Text = Commands.ACGR.Editor.GETAccountNumber(V_FORMAttrib.RowID)
            TxtAccountName.Text = Commands.ACGR.Editor.GETAccountName(V_FORMAttrib.RowID)
            ChkEnable.Checked = Commands.ACGR.Editor.GETEnableTransaction(V_FORMAttrib.RowID)

            'Disable all combobox
            CboCompany.Enabled = False
            CboAccountingBook.Enabled = False
            CboAccountGroup.Enabled = False
        End If

        _FirstLoad = False
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (_FirstLoad) Then
            Commands.ACGR.Editor.FILLAccountingBook(CboAccountingBook, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If (TxtAccountName.Text = String.Empty) OrElse (TxtAccountNumber.Text = String.Empty) OrElse (CboAccountingBook.Items.Count = 0) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (V_FORMAttrib.IsNew) AndAlso (Commands.ACGR.Editor.IsDuplicate(CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (V_FORMAttrib.IsNew) AndAlso (Commands.ACGR.Editor.IsDuplicate(CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, V_FORMAttrib.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.ACGR.Editor.PUSHData(CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, TxtAccountName.XOSQLText, ChkEnable.Checked, V_FORMAttrib.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtAccountNumber.Text = String.Empty
        TxtAccountName.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
#End Region

End Class
