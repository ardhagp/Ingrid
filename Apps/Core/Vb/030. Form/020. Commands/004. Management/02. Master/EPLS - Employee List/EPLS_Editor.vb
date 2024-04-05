Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private _SQL As New LibSQL.Commands.EPLS.Editor
    Private _SQL_User As New LibSQL.Commands.UAC.Editor
    Public Event RecordSaved()
    Private WithEvents _AddinPosition As New EPLS_Position
    Private _HavePhoto As Integer
    Private _ChangePhoto As Boolean
    Private _PositionID As String
    Private _Photo As System.Drawing.Image
#End Region

#Region "Subs Collections"

#End Region

    Private Sub EPLS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _HavePhoto = 0
        _ChangePhoto = False
        If (V_FORMAttrib.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = _SQL.GETEmployeeFullName(V_FORMAttrib.RowID)
            CboGender.SelectedItem = _SQL.GETGender(V_FORMAttrib.RowID)
            TxtPersonalID.Text = _SQL.GETPersonalID(V_FORMAttrib.RowID)
            DtpBirthDate.Value = CDate(_SQL.GETBirthDate(V_FORMAttrib.RowID))
            TxtBirthPlace.Text = _SQL.GETBirthPlace(V_FORMAttrib.RowID)
            TxtAddress.Text = _SQL.GETAddress(V_FORMAttrib.RowID)

            'Work In...
            TxtCompany.Text = _SQL.GETCompany(V_FORMAttrib.RowID)
            TxtDepartement.Text = _SQL.GETDepartement(V_FORMAttrib.RowID)
            _PositionID = _SQL.GETPositionID(V_FORMAttrib.RowID)
            TxtPosition.Text = _SQL.GETPosition(V_FORMAttrib.RowID)
            TxtGradeID.Text = _SQL.GETGradeID(V_FORMAttrib.RowID)
            TxtGrade.Text = _SQL.GETGrade(V_FORMAttrib.RowID)
            TxtEmployeeNumber.Text = _SQL.GETEmployeeNumber(V_FORMAttrib.RowID)
            TxtEmployeeNickname.Text = _SQL.GETEmployeeNickname(V_FORMAttrib.RowID)
            TxtContractTypeID.Text = _SQL.GETContractTypeID(V_FORMAttrib.RowID)
            TxtContractType.Text = _SQL.GETContractType(V_FORMAttrib.RowID)
            ChkActiveEmployee.Checked = _SQL.GETActiveEmployee(V_FORMAttrib.RowID)
            _HavePhoto = _SQL.GETIsHavePhoto(V_FORMAttrib.RowID)

            'Permissions
            TxtLogin.Text = _SQL_User.GETUsernameByEmployeeID(V_FORMAttrib.RowID)
            V_FORMAttrib.Field01 = _SQL_User.GETUIDByEmployeeID(V_FORMAttrib.RowID)
            _SQL_User.DisplayData(DgnModulesRoles, V_FORMAttrib.Field01)

            TxtPersonalID.Focus()

            If _HavePhoto > 0 Then
                pctbxPhoto.Image = _SQL.GETPhoto(V_FORMAttrib.RowID)
            End If
        End If

    End Sub

    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        _AddinPosition = New EPLS_Position
        Display(_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Position", "Browse for position data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Sub CheckAllInputs()
        'TxtPersonalID.Focus()
        TxtEmployeeNumber.Focus()
        TxtFullName.Focus()
        TxtEmployeeNickname.Focus()
        ChkActiveEmployee.Focus()
        BtnSave.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInputs()

        If (_SQL.IsPersonalIDExist(V_FORMAttrib.IsNew, TxtPersonalID.Text, V_FORMAttrib.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.SLFSQLText = String.Empty) OrElse (_PositionID = String.Empty) OrElse (TxtEmployeeNumber.SLFSQLText = String.Empty) OrElse (TxtFullName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (_SQL.IsPositionExist(_PositionID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(_PositionID, TxtEmployeeNumber.SLFSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (V_FORMAttrib.IsNew) AndAlso (_SQL.IsDuplicate(_PositionID, TxtEmployeeNumber.SLFSQLText, V_FORMAttrib.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf _HavePhoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (_SQL.PUSHData(TxtPersonalID.SLFSQLText, _PositionID, TxtEmployeeNumber.SLFSQLText, TxtFullName.SLFSQLText, DtpBirthDate, TxtBirthPlace.SLFSQLText, TxtAddress.SLFSQLText, TxtEmployeeNickname.SLFSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem, _Photo, _ChangePhoto, V_USERAttrib.EID, V_FORMAttrib.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtCompany.Clear()
            TxtDepartement.Clear()
            _PositionID = String.Empty
            TxtPosition.Clear()
            TxtGradeID.Clear()
            TxtGrade.Clear()
            TxtEmployeeNumber.Clear()
            TxtFullName.Clear()
            TxtEmployeeNickname.Clear()
            TxtContractTypeID.Clear()
            TxtContractType.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _AddinPosition_RecordSelected() Handles _AddinPosition.RecordSelected
        TxtCompany.Text = V_FORMAttrib.Field01
        TxtDepartement.Text = V_FORMAttrib.Field02
        _PositionID = V_FORMAttrib.Field03
        TxtPosition.Text = V_FORMAttrib.Field04
    End Sub

    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        OfdPhoto.Title = "Ingrid Photo Picker"
        OfdPhoto.FileName = ""
        OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdPhoto.ShowDialog = DialogResult.OK Then
            If (OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, _MAXUPLOADSIZE_PHOTO, True)) Then
                _Photo = V_IMG_COMPRESS.OutputAsImage(OfdPhoto.FileName)
                pctbxPhoto.Image = _Photo
                _ChangePhoto = True
                _HavePhoto = 1
            End If
        Else
            _HavePhoto = 1
            Return
        End If

    End Sub

    Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
        If _HavePhoto = 0 Then
            If CboGender.Text = "MALE" Then
                pctbxPhoto.Image = My.Resources.MALE_001_512_icon
            Else
                pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
            End If
        End If
    End Sub

End Class
