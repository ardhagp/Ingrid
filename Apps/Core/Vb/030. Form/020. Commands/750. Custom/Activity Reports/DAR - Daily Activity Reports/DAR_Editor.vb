Imports System.Data
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Text
Imports CMCv
Imports Serilog.Sinks.Http

Public Class DAR_Editor
#Region "Variables"
    Private frmDARsinglephotoviewer As DAR_SinglePhotoViewer
    Private frmDARsinglepdfviewer As DAR_SinglePDFViewer
    Private clsSQLeditor As New Commands.DAR.Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
    Private varDataset(2) As DataSet
    Private varPhotobyte As Byte()
    Private varExtendedquery As String
    Private varHour, varMinute As String
    Public Event RecordSaved()
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETAffectedArea()
        Commands.DAR.Editor.GETAffectedArea(CboArea)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GETTemplateTitle()
        Commands.DAR.Editor.GETTemplateTitle(CboTemplate)
    End Sub

    Public Sub CheckAllInput()
        DtpStart.Focus()
        MebStart.Focus()
        DtpEnd.Focus()
        MebEnd.Focus()
        CboArea.Focus()
        CboTemplate.Focus()
        TxtContent.Focus()
        BtnSave.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub LoadAttachment()
        varDataset(0) = New DataSet

        DblBuffer(DgnPictureList)
        DgnPictureList.Rows.Clear()
        TxtPhotoPath.Clear()

        varDataset(0) = clsSQLeditor.DisplayPhotoGrid(frmAttribute.RowID.ToString, DgnPictureList)

        For i As Integer = 0 To varDataset(0).Tables("TPhotoFileEditor").Rows.Count - 1
            DgnPictureList.Rows.Add(varDataset(0).Tables("TPhotoFileEditor").Rows(i).Item("file_id"), varDataset(0).Tables("TPhotoFileEditor").Rows(i).Item("file_filename"), varDataset(0).Tables("TPhotoFileEditor").Rows(i).Item("file_datetime"), varDataset(0).Tables("TPhotoFileEditor").Rows(i).Item("file_content"), "", varDataset(0).Tables("TPhotoFileEditor").Rows(i).Item("file_uploader"))
        Next

        If DgnPictureList.RowCount = 0 Then
            PctbxPhoto.Image = Nothing
        End If

        DgnFileList.Rows.Clear()
        TxtFilePath.Clear()

        varDataset(1) = New DataSet

        DblBuffer(DgnFileList)
        varDataset(1) = clsSQLeditor.DisplayFileGrid(frmAttribute.RowID.ToString, DgnFileList)

        For i As Integer = 0 To varDataset(1).Tables("TFileEditor").Rows.Count - 1
            DgnFileList.Rows.Add(varDataset(1).Tables("TFileEditor").Rows(i).Item("file_id"), varDataset(1).Tables("TFileEditor").Rows(i).Item("file_filename"), varDataset(1).Tables("TFileEditor").Rows(i).Item("file_tag"), varDataset(1).Tables("TFileEditor").Rows(i).Item("file_datetime"), varDataset(1).Tables("TFileEditor").Rows(i).Item("file_content"), "", varDataset(1).Tables("TFileEditor").Rows(i).Item("file_uploader"))
        Next
    End Sub
#End Region

#Region "Function Collections"

#End Region

#Region "Form Events"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmDailyActivityReports_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETAffectedArea()
        Call GETTemplateTitle()

        With clsMMSmenu
            .LoadIn(Me, True)
            .ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        End With

        DgnPictureList.XOGETNewColor()

        If Now.Hour.ToString.Length = 1 Then
            varHour = "0" & Now.Hour.ToString
        ElseIf Now.Hour.ToString.Length = 2 Then
            varHour = Now.Hour.ToString
        End If

        If Now.Minute.ToString.Length = 1 Then
            varMinute = "0" & Now.Minute.ToString
        ElseIf Now.Minute.ToString.Length = 2 Then
            varMinute = Now.Minute.ToString
        End If

        If (frmAttribute.IsNew) Then
            frmAttribute.RowID = CMCv.Security.Encrypt.MD5()
            MebStart.Text = varHour & ":" & varMinute
            MebEnd.Text = varHour & ":" & varMinute
            TxtContent.Text = String.Empty
            ChkAddNew.Visible = True
            DtpStart.MinDate = CType("01/01/" & Year(Now()), Date)
        Else
            Call LoadData()
            ChkAddNew.Visible = False
        End If

        With CboFileTag
            .Items.Add("PACKING LIST / MANIFEST")
            .SelectedIndex = 0
            .Items.Add("CERTIFICATE")
            .Items.Add("MSDS / MANUALS")
            .Items.Add("BOOK / REFERENCE")
            .Items.Add("LETTER / AGREEMENT")
            .Items.Add("REVISION")
            .Items.Add("OTHERS")
        End With

        DtpStart.MaxDate = DtpEnd.Value
        DtpEnd.MinDate = DtpStart.Value
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub BtnGETContent_Click(sender As Object, e As EventArgs) Handles BtnGETContent.Click
        If Not (frmAttribute.IsNew) Then
            If Decision("Do you want to replace Description with template content?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(CboTemplate)
            End If
        Else
            TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(CboTemplate)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call Save()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Save()
        Dim varActivitystart_s As String
        Dim varActivityend_s As String
        Dim varActivitystart_d As Date
        Dim varActivityend_d As Date

        Call CheckAllInput()

        If (TxtContent.Text = String.Empty) OrElse (CboArea.Items.Count = 0) OrElse (CboTemplate.Items.Count = 0) OrElse (MebStart.Text = String.Empty) OrElse (MebEnd.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Start Time, End Time, Area Affected, Activity Template selected and Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        varActivitystart_s = DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day & " " & MebStart.Text
        varActivityend_s = DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day & " " & MebEnd.Text
        varActivitystart_d = CDate(varActivitystart_s)
        varActivityend_d = CDate(varActivityend_s)

        If (varActivitystart_d > varActivityend_d) Then
            Decision("Cannot save your record." & Environment.NewLine & "Start Time should be less than End Time.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.DAR.Editor.PUSHData(CboArea.SelectedValue.ToString, CboTemplate.SelectedValue.ToString, CType(DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day, String), CType(MebStart.Text.Replace(".", ":"), String), CType(DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day, String), CType(MebEnd.Text.Replace(".", ":"), String), TxtContent.XOSQLText, TxtFeedback.XOSQLText, varUSERattribute.UID, frmAttribute.RowID.ToString, frmAttribute.IsNew, varExtendedquery)) Then
            varExtendedquery = String.Empty
            Mainframe_n_6.Ts_status.Text = "Success"

            Dim varNewphotoadded As Integer = 0
            For Each varRow As DataGridViewRow In DgnPictureList.Rows
                If varRow.Cells("photo_status").Value.ToString Is "Add" Then
                    varNewphotoadded += 1
                End If
            Next

            If varNewphotoadded > 0 Then
                If (Commands.DAR.Editor.PUSHPhoto(DgnPictureList, frmAttribute.RowID.ToString, frmAttribute.IsNew, DtpStart.Value)) Then
                    Mainframe_n_6.Ts_status.Text = "Success + All pictures has been added"
                Else
                    Mainframe_n_6.Ts_status.Text = "Success + With errors while adding pictures"
                End If

                DgnPictureList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If

            'Add new File
            Dim varNewfileadded As Integer = 0
            For Each varRow As DataGridViewRow In DgnFileList.Rows
                If varRow.Cells("file_status").Value.ToString Is "Add" Then
                    varNewfileadded += 1
                End If
            Next

            If varNewfileadded > 0 Then
                If (Commands.DAR.Editor.PUSHFile(DgnFileList, frmAttribute.RowID.ToString, frmAttribute.IsNew, DtpStart.Value)) Then
                    Mainframe_n_6.Ts_status.Text = "Success + All file has been added"
                Else
                    Mainframe_n_6.Ts_status.Text = "Success + With errors while adding files"
                End If

                DgnFileList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If


            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtContent.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        Else
            frmAttribute.RowID = CMCv.Security.Encrypt.MD5()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.DAR.Editor.GETRowValue(frmAttribute.RowID.ToString, DtpStart, MebStart, DtpEnd, MebEnd, CboArea, CboTemplate, TxtContent, TxtFeedback)
        Call LoadAttachment()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CboTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles CboTemplate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (frmAttribute.IsNew) Then
                If Decision("Do you want to replace Description with template content?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                    TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(CboTemplate)
                End If
            Else
                TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(CboTemplate)
            End If
        End If
    End Sub

    Private Sub DtpStart_ValueChanged(sender As Object, e As EventArgs) Handles DtpStart.ValueChanged
        DtpEnd.MinDate = DtpStart.Value
    End Sub

    Private Sub DtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles DtpEnd.ValueChanged
        DtpStart.MaxDate = DtpEnd.Value
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnAddPhoto_Click(sender As Object, e As EventArgs) Handles BtnAddPhoto.Click
        Try
            If TxtPhotoPath.Text.Trim = String.Empty Then
                Decision("Plase pick your photo first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
                Decision("Your photo cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtPhotoPath.Text, varMaxuploadsize_photo, True)) Then
                Return
            End If

            Dim varRow As Object() = Nothing
            Dim varDate As Date = Now
            Dim varPhoto As System.Drawing.Image = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(TxtPhotoPath.Text) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtPhotoPath.Text), varDate, varPhoto, "Add", varUSERattribute.EID}

            With DgnPictureList.Rows
                .Add(varRow)
            End With

            TxtPhotoPath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        With OfdPhoto
            .Title = "Ingrid Photo Picker"
            .FileName = ""
            .Filter = "Photo File|*.Jpg;*.Jpeg"
            If .ShowDialog = DialogResult.OK Then
                TxtPhotoPath.Text = .FileName
            End If
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnPeekPhoto_Click(sender As Object, e As EventArgs) Handles BtnPeekPhoto.Click
        If TxtPhotoPath.Text.Trim = String.Empty Then
            Decision("Plase pick your photo first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
            Decision("Your photo cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        frmDARsinglephotoviewer = New DAR_SinglePhotoViewer(TxtPhotoPath.Text)
        DISPLAY(frmDARsinglephotoviewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)

    End Sub

    Private Sub DgnPictureList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPictureList.CellContentClick
        Dim varSendergrid = DirectCast(sender, Dgn)

        If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected photo?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnPictureList.CurrentRow.Cells("photo_status").Value IsNot "Add" Then
                    varExtendedquery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnPictureList.CurrentRow.Cells("photo_id").Value)
                End If

                DgnPictureList.Rows.Remove(DgnPictureList.SelectedRows(0))

                If DgnPictureList.RowCount = 0 Then
                    PctbxPhoto.Image = Nothing
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPictureList_SLF_Selected() Handles DgnPictureList.XOSelected
        If DgnPictureList.RowCount <> 0 Then
            If DgnPictureList.CurrentRow.Cells("photo_status").Value.ToString Is "Add" Then
                PctbxPhoto.Image = CType(DgnPictureList.CurrentRow.Cells("photo_content").Value, Image)
            Else
                varPhotobyte = CType(DgnPictureList.CurrentRow.Cells("photo_content").Value, Byte())

                Dim varPhotostream = New System.IO.MemoryStream(varPhotobyte)
                PctbxPhoto.Image = System.Drawing.Image.FromStream(varPhotostream)
            End If
        End If
    End Sub

    Private Sub BtnBrowseFile_Click(sender As Object, e As EventArgs) Handles BtnBrowseFile.Click
        With ofdFile
            .Title = "Ingrid File Picker"
            .FileName = ""
            .Filter = "PDF File|*.pdf;"

            If .ShowDialog = DialogResult.OK Then
                TxtFilePath.Text = .FileName
            End If
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnPeekFile_Click(sender As Object, e As EventArgs) Handles BtnPeekFile.Click
        If TxtFilePath.Text.Trim = String.Empty Then
            Decision("Plase pick your file first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
            Decision("Your file cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        frmDARsinglepdfviewer = New DAR_SinglePDFViewer(TxtFilePath.Text, "", False)
        DISPLAY(frmDARsinglepdfviewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
    End Sub

    Private Sub BtnAddFile_Click(sender As Object, e As EventArgs) Handles BtnAddFile.Click
        Try
            If TxtFilePath.Text.Trim = String.Empty Then
                Decision("Plase pick your PDF file first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                Decision("Your file cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtFilePath.Text, varMaxuploadsize_pdf, True)) Then
                Return
            End If

            Dim varRow As Object() = Nothing
            Dim varDate As Date = Now

            varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtFilePath.Text), CboFileTag.Text, varDate, TxtFilePath.Text, "Add", varUSERattribute.EID}

            With DgnFileList.Rows
                .Add(varRow)
            End With

            TxtFilePath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DgnFileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFileList.CellContentClick
        Dim varSendergrid = DirectCast(sender, Dgn)

        If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected file?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnFileList.CurrentRow.Cells("file_status").Value IsNot "Add" Then
                    varExtendedquery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnFileList.CurrentRow.Cells("file_id").Value)
                End If
                DgnFileList.Rows.Remove(DgnFileList.SelectedRows(0))
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventFileSave() Handles clsMMSmenu.EventFileSave
        Call Save()
    End Sub

    Private Sub _MMSMenu_EventFileCancel() Handles clsMMSmenu.EventFileCancel
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventFileUndoAll() Handles clsMMSmenu.EventFileUndoAll
        If Decision("Do you want to undo all changes?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (frmAttribute.IsNew) Then
                DtpStart.Value = Now.Date
                DtpEnd.Value = Now.Date
                CboArea.SelectedIndex = 0
                CboTemplate.SelectedIndex = 0
                TxtContent.Clear()
                TxtFeedback.Clear()
                TxtPhotoPath.Clear()
                DgnPictureList.Rows.Clear()
                PctbxPhoto.Image = Nothing
                CboFileTag.SelectedIndex = 0
                DgnFileList.Rows.Clear()
                TxtFilePath.Clear()
            Else
                Call LoadData()
            End If
        End If
    End Sub
End Class
