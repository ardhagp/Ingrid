﻿Imports System.Runtime.Versioning

Public Class PLNT
    Private _SQL As New LibSQL.Commands.PLNT.View
    Private WithEvents _PLNT_Editor As New PLNT_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        DblBuffer(DgnPLNT)
        LibSQL.Commands.PLNT.View.DisplayData(DgnPLNT, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ClearFind()
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnPLNT.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnPLNT.CurrentRow.Cells("plant_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Functions"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        If V_USERAccess.User("PLNT", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add) = False Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        _PLNT_Editor = New PLNT_Editor
        Display(_PLNT_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new plant", True)
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles _MMSMenu.EventDataEdit
        If V_USERAccess.User("PLNT", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit) = False Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        V_FORMAttrib.IsNew = False
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _PLNT_Editor = New PLNT_Editor
            Display(_PLNT_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update plant data", True)
        End If
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataDelete() Handles _MMSMenu.EventDataDelete
        If V_USERAccess.User("PLNT", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete) = False Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If LibSQL.Commands.PLNT.View.DELETEDATA(V_FORMAttrib.RowID) = True Then
                    Call GETDATA(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub _MMSMenu_EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub
#End Region

#Region "Upper Form Bar"

#End Region

#Region "Main Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub PLNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        DgnPLNT.XOGETNewColor()
        Call ClearFind()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
        TxtFind.ClearSearch()
    End Sub
#End Region

End Class
