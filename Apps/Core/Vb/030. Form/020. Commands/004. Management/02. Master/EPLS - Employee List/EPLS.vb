﻿Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS
#Region "Variables"
    Private _SQL As New Commands.EPLS.View
    Private WithEvents F_EPLS_Editor As New EPLS_Editor
    Private WithEvents C_MMSMenu As New UI.View.MenuStrip
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        Commands.EPLS.View.DISPLAYDATA(DgnEPLS, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnEPLS.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnEPLS.CurrentRow.Cells("employee_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles C_MMSMenu.EventDataAddNew
        If Not (V_USERAccess.User("EPLS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"

        F_EPLS_Editor = New EPLS_Editor
        DISPLAY(F_EPLS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles C_MMSMenu.EventDataEdit
        If Not (V_USERAccess.User("EPLS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        V_FORMAttrib.IsNew = False
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            F_EPLS_Editor = New EPLS_Editor
            DISPLAY(F_EPLS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles C_MMSMenu.EventDataDelete
        If Not (V_USERAccess.User("EPLS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnEPLS.CurrentRow.Cells("employee_fullname").Value.ToString & vbCrLf & "=======================================================", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.EPLS.View.DELETEDATA(V_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles C_MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles C_MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles C_MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_MMSMenu.LoadIn(Me)
        C_MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        Call GETDATA()
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub F_EPLS_Editor_RecordSaved() Handles F_EPLS_Editor.RecordSaved
        Call GETDATA()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

End Class
