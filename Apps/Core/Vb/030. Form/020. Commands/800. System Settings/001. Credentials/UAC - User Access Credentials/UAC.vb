﻿Imports System.Runtime.Versioning
Imports CMCv

Public Class UAC
#Region "Variables"
    Private varSQLview As New Commands.UAC.View
    Private WithEvents frmUACeditor As UAC_Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        Commands.UAC.View.DisplayData(DgnUAC, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        varFORMAttribute.RowID = "-1"

        If DgnUAC.RowCount > 0 Then
            varFORMAttribute.RowID = DgnUAC.CurrentRow.Cells("user_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        varFORMAttribute.IsChangePasswordForm = False

        If Not (varUSRaccess.User("UAC", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        With varFORMAttribute
            .IsNew = True
            .RowID = "-1"
            .Hash = Security.Encrypt.MD5()
        End With

        frmUACeditor = New UAC_Editor
        DISPLAY(frmUACeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new credential data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        varFORMAttribute.IsChangePasswordForm = False

        If Not (varUSRaccess.User("UAC", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        varFORMAttribute.IsNew = False

        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            varFORMAttribute.IsNew = False
            frmUACeditor = New UAC_Editor
            DISPLAY(frmUACeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        If Not (varUSRaccess.User("UAC", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()

        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDBdialogbox.MessageIcon.Question, CMCv.frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes AndAlso (Commands.UAC.View.DELETEData(varFORMAttribute.RowID)) Then
                Call GETDATA(True)
                Mainframe_n_6.Ts_status.Text = "Success"
            Else
                Mainframe_n_6.Ts_status.Text = "Delete failed"
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles clsMMSmenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles clsMMSmenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub UAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me)
            .ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)

        End With

        DgnUAC.XOGETNewColor()
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
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _UAC_Editor_RecordSaved() Handles frmUACeditor.RecordSaved
        Call GETDATA()
    End Sub
End Class
