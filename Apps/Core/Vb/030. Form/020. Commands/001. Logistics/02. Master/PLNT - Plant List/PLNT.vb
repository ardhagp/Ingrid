Imports System.Runtime.Versioning

Public Class PLNT
    Private varSQLview As New LibSQL.Commands.PLNT.View
    Private WithEvents frmPLNTeditor As New PLNT_Editor
    Private WithEvents varMMSmenu As New CMCv.UI.View.MenuStrip

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
        varFORMAttribute.RowID = "-1"

        If DgnPLNT.RowCount > 0 Then
            varFORMAttribute.RowID = DgnPLNT.CurrentRow.Cells("plant_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Functions"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles varMMSmenu.EventDataAddNew
        If varUSRaccess.User("PLNT", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Add) = False Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Exit Sub
        End If

        With varFORMAttribute
            .IsNew = True
            .RowID = "-1"
        End With

        frmPLNTeditor = New PLNT_Editor
        DISPLAY(frmPLNTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new plant", True)
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles varMMSmenu.EventDataEdit
        If varUSRaccess.User("PLNT", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit) = False Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        varFORMAttribute.IsNew = False
        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            frmPLNTeditor = New PLNT_Editor
            DISPLAY(frmPLNTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update plant data", True)
        End If
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataDelete() Handles varMMSmenu.EventDataDelete
        If varUSRaccess.User("PLNT", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete) = False Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            varFORMAttribute.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDBdialogbox.MessageIcon.Question, CMCv.frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes AndAlso (LibSQL.Commands.PLNT.View.DELETEDATA(varFORMAttribute.RowID) = True) Then
                Call GETDATA(True)
                Mainframe_n_6.Ts_status.Text = "Success"
            Else
                Mainframe_n_6.Ts_status.Text = "Delete failed"
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataRefresh() Handles varMMSmenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub _MMSMenu_EventDataClose() Handles varMMSmenu.EventDataClose
        Me.Close()
    End Sub
#End Region

#Region "Upper Form Bar"
    'TODO: Add upper form bar
#End Region

#Region "Main Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub PLNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varMMSmenu.LoadIn(Me)
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