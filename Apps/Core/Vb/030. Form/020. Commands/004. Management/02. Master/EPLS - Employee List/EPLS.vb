Imports CMCv

Public Class EPLS
#Region "Variables"
    Private _SQL As New LibSQL.Commands.EPLS.View
    Private WithEvents _EPLS_Editor As New EPLS_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnEPLS, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnEPLS.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnEPLS.CurrentRow.Cells("employee_id").Value
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        If Not (V_USERAccess.User("EPLS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"

        _EPLS_Editor = New EPLS_Editor
        Display(_EPLS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
    End Sub

    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
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
            _EPLS_Editor = New EPLS_Editor
            Display(_EPLS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        If Not (V_USERAccess.User("EPLS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnEPLS.CurrentRow.Cells("employee_fullname").Value & vbCrLf & "=======================================================", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
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

    Private Sub EPLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        Call GETDATA()
        TxtFind.ClearSearch()
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub _EPLS_Editor_RecordSaved() Handles _EPLS_Editor.RecordSaved
        Call GETDATA()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

End Class
