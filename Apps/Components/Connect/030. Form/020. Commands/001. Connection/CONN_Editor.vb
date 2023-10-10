Imports CMCv

Public Class CONN_Editor

    Public Event RecordSaved()
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private _SQL As New Commands.CONN.Editor
    Private _PWDChange As Boolean
    Private _OldPassword As String

    Private Sub CONN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me, True)
        _MMSMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        _PWDChange = False

        If (v_FORMAttrib.IsNew) Then
            v_FORMAttrib.RowID = v_SECEncrypt.MD5
        Else
            Call LoadData()
        End If
    End Sub

    Private Sub LoadData()
        _SQL.GETRowValue(v_FORMAttrib.RowID, Txt_ConnectionName, Txt_Address, Txt_Port, Txt_Username, Txt_Password, _OldPassword, Txt_DataStorage, Txt_FileStorage, Chk_Default)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call Save()
    End Sub

    Private Sub Save()
        Call CheckAllInput()

        If (Txt_ConnectionName.Text = String.Empty) OrElse (Txt_Address.Text = String.Empty) OrElse (Txt_Port.Text = String.Empty) OrElse (Txt_Username.Text = String.Empty) OrElse (Txt_Password.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Connection Name, Address, Port, Username, Password are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (_SQL.PUSHData(Txt_ConnectionName.Text, Txt_Address.Text, Txt_Port.Text, Txt_Username.Text, Txt_Password.Text, Txt_DataStorage.Text, Txt_FileStorage.Text, Chk_Default.Checked, v_FORMAttrib.RowID, v_FORMAttrib.IsNew, _PWDChange)) Then
            SLFStatus.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            SLFStatus.Text = "Failed to save"
            Return
        End If

        Me.Close()
    End Sub

    Private Sub CheckAllInput()
        Txt_ConnectionName.Focus()
        Txt_Address.Focus()
        Txt_Port.Focus()
        Txt_Username.Focus()
        Txt_Password.Focus()
    End Sub

    Private Sub CheckPWDChange()
        If Txt_Password.SLFSQLText = _OldPassword Then
            _PWDChange = False
        Else
            _PWDChange = True
        End If
    End Sub

    Private Sub Txt_Password_LostFocus(sender As Object, e As EventArgs) Handles Txt_Password.LostFocus
        Call CheckPWDChange()
    End Sub

    Private Sub _MMSMenu_EventFileSave() Handles _MMSMenu.EventFileSave
        Call Save()
    End Sub

    Private Sub _MMSMenu_EventFileCancel() Handles _MMSMenu.EventFileCancel
        Me.Close()
    End Sub

    Private Sub _MMSMenu_EventFileUndoAll() Handles _MMSMenu.EventFileUndoAll
        If Decision("Do you want to undo all changes?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (v_FORMAttrib.IsNew) Then
                Txt_ConnectionName.Clear()
                Txt_Address.Clear()
                Txt_Port.Clear()
                Txt_Username.Clear()
                Txt_Password.Clear()
                Txt_DataStorage.Clear()
                Txt_FileStorage.Clear()
            Else
                Call LoadData()
            End If
        End If
    End Sub
End Class
