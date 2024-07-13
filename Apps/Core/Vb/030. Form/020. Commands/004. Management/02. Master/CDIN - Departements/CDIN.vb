Imports System.Runtime.Versioning

Public Class CDIN

#Region "Variables"
    Private clsSQL As New LibSQL.Commands.CDIN.View
    Private WithEvents frmCDINeditor As CDIN_Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.CDIN.View.DISPLAYDATA(DgnCDIN, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        If DgnCDIN.RowCount = 0 Then
            frmAttribute.RowID = "-1"
        Else
            frmAttribute.RowID = DgnCDIN.CurrentRow.Cells("departement_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        With frmAttribute
            .IsNew = True
            .RowID = "-1"
        End With
        frmCDINeditor = New CDIN_Editor
        DISPLAY(frmCDINeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new departement data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        Call GETTableID()
        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmAttribute.IsNew = False
            frmCDINeditor = New CDIN_Editor
            DISPLAY(frmCDINeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your departement data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        Call GETTableID()
        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.CDIN.View.DELETEDATA(frmAttribute.RowID)) Then
                    Call GETDATA(True)
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
    Private Sub CDIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me)
            .ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        End With
        Call GETDATA()
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Component Events"
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
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub _CDIN_Editor_RecordSaved() Handles frmCDINeditor.RecordSaved
        Call GETDATA()
    End Sub

End Class
