Imports CMCv

Public Class UAC
#Region "Variables"
    Private _SQL As New LibSQL.Commands.UAC.View
    Private WithEvents _UAC_Editor As UAC_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnUAC, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnUAC.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnUAC.CurrentRow.Cells("user_id").Value
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        V_FORMAttrib.IsChangePasswordForm = False

        If Not (V_USERAccess.User("UAC", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        V_FORMAttrib.Hash = V_SECEncrypt.MD5
        _UAC_Editor = New UAC_Editor
        Display(_UAC_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new credential data", True)
    End Sub

    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        V_FORMAttrib.IsChangePasswordForm = False

        If Not (V_USERAccess.User("UAC", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        V_FORMAttrib.IsNew = False

        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            _UAC_Editor = New UAC_Editor
            Display(_UAC_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        If Not (V_USERAccess.User("UAC", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()

        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (_SQL.DELETEData(V_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    Mainframe_n_6.ts_status.Text = "Success"
                Else
                    Mainframe_n_6.ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region


    Private Sub UAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        DgnUAC.SLF_GETNewColor()
        Call GETDATA()
        TxtFind.ClearSearch()
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub _UAC_Editor_RecordSaved() Handles _UAC_Editor.RecordSaved
        Call GETDATA()
    End Sub
End Class
