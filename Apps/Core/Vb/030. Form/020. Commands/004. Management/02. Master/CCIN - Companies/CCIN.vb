Imports System.Runtime.Versioning
Imports CMCv

Public Class CCIN
#Region "Variables"
    Private clsSQL As New LibSQL.Commands.CCIN.View
    Private WithEvents frmCCINeditor As CCIN_Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Function Collections"
    'TODO: Add Function
#End Region

#Region "Sub Collections"

    ''' <summary>
    ''' Untuk mengambil data dari database
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        LibSQL.Commands.CCIN.View.DISPLAYDATA(DgnCCIN, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        If DgnCCIN.RowCount = 0 Then
            frmAttribute.RowID = "-1"
        Else
            frmAttribute.RowID = DgnCCIN.CurrentRow.Cells("company_id").Value.ToString
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

        frmCCINeditor = New CCIN_Editor
        DISPLAY(frmCCINeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new company data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        Call GETTableID()
        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmAttribute.IsNew = False
            frmCCINeditor = New CCIN_Editor
            DISPLAY(frmCCINeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your company data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        Call GETTableID()
        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmAttribute.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.CCIN.View.DELETEDATA(frmAttribute.RowID)) Then
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
    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me)
            .ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        End With
        Call GETDATA(True)
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
    Private Sub _CCIN_Editor_RecordSaved() Handles frmCCINeditor.RecordSaved
        Call GETDATA(True)
    End Sub

End Class
