﻿Imports System.Runtime.Versioning

Public Class MODS
#Region "Variables"
    Private clsSQLview As New Commands.MODS.View
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
    Private WithEvents frmMODSeditor As New MODS_Editor
    Public Event DATACHANGED()
#End Region

#Region "Subs Collection"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        DblBuffer(DgnMODS)
        Commands.MODS.View.DisplayData(DgnMODS, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        frmAttribute.RowID = "-1"

        If DgnMODS.RowCount > 0 Then
            frmAttribute.RowID = DgnMODS.CurrentRow.Cells("module_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        If Not (varUSERaccess.User("MODS", varUSERattribute.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        With frmAttribute
            .IsNew = True
            .RowID = "-1"
            .Hash = CMCv.Security.Encrypt.MD5()
        End With
        frmMODSeditor = New MODS_Editor
        DISPLAY(frmMODSeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new module", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        If Not (varUSERaccess.User("UAC", varUSERattribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        frmAttribute.IsNew = False

        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmAttribute.IsNew = False
            frmMODSeditor = New MODS_Editor
            DISPLAY(frmMODSeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        If Not (varUSERaccess.User("MODS", varUSERattribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()

        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.DAR.View.DELETEData(frmAttribute.RowID)) Then
                    Call GETDATA(True)
                    RaiseEvent DATACHANGED()
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles clsMMSmenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub EventDataClose() Handles clsMMSmenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub MODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me)
            .ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        End With
        TxtFind.ClearSearch()
        DgnMODS.XOGETNewColor()
        Call GETDATA(True)
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

    Private Sub _MMSMenu_EventToolsFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MODS_Editor_RecordSaved() Handles frmMODSeditor.RecordSaved
        Call GETDATA()
        RaiseEvent DATACHANGED()
    End Sub

#End Region
End Class
