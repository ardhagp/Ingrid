Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private clsSQL As New Commands.EPLS.Editor
    Private clsSQLuser As New Commands.UAC.Editor
    Private varHavephoto As Integer
    Private varChangephoto As Boolean
    Private varIDposition As String
    Private varPhoto As System.Drawing.Image
    Public Event RecordSaved()
    Private WithEvents frmAddinposition As New EPLS_Position
#End Region

#Region "Subs Collections"
    'TODO: Addin Position
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varHavephoto = 0
        varChangephoto = False
        If (frmAttribute.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = Commands.EPLS.Editor.GETEmployeeFullName(frmAttribute.RowID)
            CboGender.SelectedItem = Commands.EPLS.Editor.GETGender(frmAttribute.RowID)
            TxtPersonalID.Text = Commands.EPLS.Editor.GETPersonalID(frmAttribute.RowID)
            DtpBirthDate.Value = CDate(Commands.EPLS.Editor.GETBirthDate(frmAttribute.RowID))
            TxtBirthPlace.Text = Commands.EPLS.Editor.GETBirthPlace(frmAttribute.RowID)
            TxtAddress.Text = Commands.EPLS.Editor.GETAddress(frmAttribute.RowID)

            'Work In...
            TxtCompany.Text = Commands.EPLS.Editor.GETCompany(frmAttribute.RowID)
            TxtDepartement.Text = Commands.EPLS.Editor.GETDepartement(frmAttribute.RowID)
            varIDposition = Commands.EPLS.Editor.GETPositionID(frmAttribute.RowID)
            TxtPosition.Text = Commands.EPLS.Editor.GETPosition(frmAttribute.RowID)
            TxtGradeID.Text = Commands.EPLS.Editor.GETGradeID(frmAttribute.RowID)
            TxtGrade.Text = Commands.EPLS.Editor.GETGrade(frmAttribute.RowID)
            TxtEmployeeNumber.Text = Commands.EPLS.Editor.GETEmployeeNumber(frmAttribute.RowID)
            TxtEmployeeNickname.Text = Commands.EPLS.Editor.GETEmployeeNickname(frmAttribute.RowID)
            TxtContractTypeID.Text = Commands.EPLS.Editor.GETContractTypeID(frmAttribute.RowID)
            TxtContractType.Text = Commands.EPLS.Editor.GETContractType(frmAttribute.RowID)
            ChkActiveEmployee.Checked = Commands.EPLS.Editor.GETActiveEmployee(frmAttribute.RowID)
            varHavephoto = Commands.EPLS.Editor.GETIsHavePhoto(frmAttribute.RowID)

            'Permissions
            TxtLogin.Text = Commands.UAC.Editor.GETUsernameByEmployeeID(frmAttribute.RowID)
            frmAttribute.Field01 = Commands.UAC.Editor.GETUIDByEmployeeID(frmAttribute.RowID)
            Commands.UAC.Editor.DisplayData(DgnModulesRoles, frmAttribute.Field01.ToString)

            TxtPersonalID.Focus()

            If varHavephoto > 0 Then
                pctbxPhoto.Image = clsSQL.GETPhoto(frmAttribute.RowID)
            End If
        End If

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        frmAddinposition = New EPLS_Position
        DISPLAY(frmAddinposition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Position", "Browse for position data", True)
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

        If (Commands.EPLS.Editor.IsPersonalIDExist(frmAttribute.IsNew, TxtPersonalID.Text, frmAttribute.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (varIDposition = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (Commands.EPLS.Editor.IsPositionExist(varIDposition)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (frmAttribute.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varIDposition, TxtEmployeeNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (frmAttribute.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varIDposition, TxtEmployeeNumber.XOSQLText, frmAttribute.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf varHavephoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.EPLS.Editor.PUSHData(TxtPersonalID.XOSQLText, varIDposition, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, varPhoto, varChangephoto, varUSERattribute.EID, frmAttribute.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtCompany.Clear()
            TxtDepartement.Clear()
            varIDposition = String.Empty
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

    Private Sub F_AddinPosition_RecordSelected() Handles frmAddinposition.RecordSelected
        With frmAttribute
            TxtCompany.Text = .Field01.ToString
            TxtDepartement.Text = .Field02.ToString
            varIDposition = .Field03.ToString
            TxtPosition.Text = .Field04.ToString
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        With OfdPhoto
            .Title = "Ingrid Photo Picker"
            .FileName = ""
            .Filter = "Photo File|*.Jpg;*.Jpeg"

            If .ShowDialog = DialogResult.OK Then
                If (OperatingSystem.File.Upload.IsAllowedSize(.FileName, varMaxuploadsize_photo, True)) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(.FileName)
                    pctbxPhoto.Image = varPhoto
                    varChangephoto = True
                    varHavephoto = 1
                End If
            Else
                varHavephoto = 1
                Return
            End If

        End With


    End Sub

    Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
        If varHavephoto = 0 Then
            If CboGender.Text = "MALE" Then
                pctbxPhoto.Image = My.Resources.MALE_001_512_icon
            Else
                pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
            End If
        End If
    End Sub

End Class
