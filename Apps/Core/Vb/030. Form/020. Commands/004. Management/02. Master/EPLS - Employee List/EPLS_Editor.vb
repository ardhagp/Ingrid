Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private varSQL As New Commands.EPLS.Editor
    Private varSQLuser As New Commands.UAC.Editor
    Private WithEvents frmEPLSposition As New EPLS_Position
    Private varHavephoto As Integer
    Private varISphotochanged As Boolean
    Private varIDposition As String
    Private varPhoto As System.Drawing.Image
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

#End Region

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varHavephoto = 0
        varISphotochanged = False
        If (varFORMAttribute.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = Commands.EPLS.Editor.GETEmployeeFullName(varFORMAttribute.RowID)
            CboGender.SelectedItem = Commands.EPLS.Editor.GETGender(varFORMAttribute.RowID)
            TxtPersonalID.Text = Commands.EPLS.Editor.GETPersonalID(varFORMAttribute.RowID)
            DtpBirthDate.Value = CDate(Commands.EPLS.Editor.GETBirthDate(varFORMAttribute.RowID))
            TxtBirthPlace.Text = Commands.EPLS.Editor.GETBirthPlace(varFORMAttribute.RowID)
            TxtAddress.Text = Commands.EPLS.Editor.GETAddress(varFORMAttribute.RowID)

            'Work In...
            TxtCompany.Text = Commands.EPLS.Editor.GETCompany(varFORMAttribute.RowID)
            TxtDepartement.Text = Commands.EPLS.Editor.GETDepartement(varFORMAttribute.RowID)
            varIDposition = Commands.EPLS.Editor.GETPositionID(varFORMAttribute.RowID)
            TxtPosition.Text = Commands.EPLS.Editor.GETPosition(varFORMAttribute.RowID)
            TxtGradeID.Text = Commands.EPLS.Editor.GETGradeID(varFORMAttribute.RowID)
            TxtGrade.Text = Commands.EPLS.Editor.GETGrade(varFORMAttribute.RowID)
            TxtEmployeeNumber.Text = Commands.EPLS.Editor.GETEmployeeNumber(varFORMAttribute.RowID)
            TxtEmployeeNickname.Text = Commands.EPLS.Editor.GETEmployeeNickname(varFORMAttribute.RowID)
            TxtContractTypeID.Text = Commands.EPLS.Editor.GETContractTypeID(varFORMAttribute.RowID)
            TxtContractType.Text = Commands.EPLS.Editor.GETContractType(varFORMAttribute.RowID)
            ChkActiveEmployee.Checked = Commands.EPLS.Editor.GETActiveEmployee(varFORMAttribute.RowID)
            varHavephoto = Commands.EPLS.Editor.GETIsHavePhoto(varFORMAttribute.RowID)

            'Permissions
            TxtLogin.Text = Commands.UAC.Editor.GETUsernameByEmployeeID(varFORMAttribute.RowID)
            varFORMAttribute.Field01 = Commands.UAC.Editor.GETUIDByEmployeeID(varFORMAttribute.RowID)
            Commands.UAC.Editor.DisplayData(DgnModulesRoles, varFORMAttribute.Field01.ToString)

            TxtPersonalID.Focus()

            If varHavephoto > 0 Then
                pctbxPhoto.Image = varSQL.GETPhoto(varFORMAttribute.RowID)
            End If
        End If

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        frmEPLSposition = New EPLS_Position
        DISPLAY(frmEPLSposition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Position", "Browse for position data", True)
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

        If (Commands.EPLS.Editor.IsPersonalIDExist(varFORMAttribute.IsNew, TxtPersonalID.Text, varFORMAttribute.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (varIDposition = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not (Commands.EPLS.Editor.IsPositionExist(varIDposition)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (varFORMAttribute.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varIDposition, TxtEmployeeNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFORMAttribute.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varIDposition, TxtEmployeeNumber.XOSQLText, varFORMAttribute.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf varHavephoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.EPLS.Editor.PUSHData(TxtPersonalID.XOSQLText, varIDposition, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, varPhoto, varISphotochanged, varUSERAttribute.EID, varFORMAttribute.RowID)) Then
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

    Private Sub F_AddinPosition_RecordSelected() Handles frmEPLSposition.RecordSelected
        With varFORMAttribute
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
                    varISphotochanged = True
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
