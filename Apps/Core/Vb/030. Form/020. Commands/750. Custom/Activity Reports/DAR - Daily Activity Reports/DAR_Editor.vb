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
    Private varExtendedQuery As String
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

        varDataset(0) = clsSQLeditor.DisplayPhotoGrid(varFORMAttribute.RowID.ToString, DgnPictureList)

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
        varDataset(1) = clsSQLeditor.DisplayFileGrid(varFORMAttribute.RowID.ToString, DgnFileList)

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

        clsMMSmenu.LoadIn(Me, True)
        clsMMSmenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)

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

        If (varFORMAttribute.IsNew) Then
            varFORMAttribute.RowID = CMCv.Security.Encrypt.MD5()
            MebStart.Text = varHour & ":" & varMinute
            MebEnd.Text = varHour & ":" & varMinute
            TxtContent.Text = String.Empty
            ChkAddNew.Visible = True
            DtpStart.MinDate = CType("01/01/" & Year(Now()), Date)
        Else
            Call LoadData()
            ChkAddNew.Visible = False
        End If

        CboFileTag.Items.Add("PACKING LIST / MANIFEST")
        CboFileTag.SelectedIndex = 0
        CboFileTag.Items.Add("CERTIFICATE")
        CboFileTag.Items.Add("MSDS / MANUALS")
        CboFileTag.Items.Add("BOOK / REFERENCE")
        CboFileTag.Items.Add("LETTER / AGREEMENT")
        CboFileTag.Items.Add("REVISION")
        CboFileTag.Items.Add("OTHERS")

        DtpStart.MaxDate = DtpEnd.Value
        DtpEnd.MinDate = DtpStart.Value
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub BtnGETContent_Click(sender As Object, e As EventArgs) Handles BtnGETContent.Click
        If Not (varFORMAttribute.IsNew) Then
            If Decision("Do you want to replace Description with template content?", "Question", frmDBdialogbox.MessageIcon.Question, frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
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
        Dim _ActivityStart_S As String
        Dim _ActivityEnd_S As String
        Dim _ActivityStart_D As Date
        Dim _ActivityEnd_D As Date

        Call CheckAllInput()

        If (TxtContent.Text = String.Empty) OrElse (CboArea.Items.Count = 0) OrElse (CboTemplate.Items.Count = 0) OrElse (MebStart.Text = String.Empty) OrElse (MebEnd.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Start Time, End Time, Area Affected, Activity Template selected and Description are properly filled.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        _ActivityStart_S = DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day & " " & MebStart.Text
        _ActivityEnd_S = DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day & " " & MebEnd.Text
        _ActivityStart_D = CDate(_ActivityStart_S)
        _ActivityEnd_D = CDate(_ActivityEnd_S)

        If (_ActivityStart_D > _ActivityEnd_D) Then
            Decision("Cannot save your record." & Environment.NewLine & "Start Time should be less than End Time.", "Alert", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.DAR.Editor.PUSHData(CboArea.SelectedValue.ToString, CboTemplate.SelectedValue.ToString, CType(DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day, String), CType(MebStart.Text.Replace(".", ":"), String), CType(DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day, String), CType(MebEnd.Text.Replace(".", ":"), String), TxtContent.XOSQLText, TxtFeedback.XOSQLText, varUSERAttribute.UID, varFORMAttribute.RowID.ToString, varFORMAttribute.IsNew, varExtendedQuery)) Then
            varExtendedQuery = String.Empty
            Mainframe_n_6.Ts_status.Text = "Success"

            Dim _NewPhotoAdded As Integer = 0
            For Each _Row As DataGridViewRow In DgnPictureList.Rows
                If _Row.Cells("photo_status").Value.ToString Is "Add" Then
                    _NewPhotoAdded += 1
                End If
            Next

            If _NewPhotoAdded > 0 Then
                If (Commands.DAR.Editor.PUSHPhoto(DgnPictureList, varFORMAttribute.RowID.ToString, varFORMAttribute.IsNew, DtpStart.Value)) Then
                    Mainframe_n_6.Ts_status.Text = "Success + All pictures has been added"
                Else
                    Mainframe_n_6.Ts_status.Text = "Success + With errors while adding pictures"
                End If

                DgnPictureList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If

            'Add new File
            Dim _NewFileAdded As Integer = 0
            For Each _Row As DataGridViewRow In DgnFileList.Rows
                If _Row.Cells("file_status").Value.ToString Is "Add" Then
                    _NewFileAdded += 1
                End If
            Next

            If _NewFileAdded > 0 Then
                If (Commands.DAR.Editor.PUSHFile(DgnFileList, varFORMAttribute.RowID.ToString, varFORMAttribute.IsNew, DtpStart.Value)) Then
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
            varFORMAttribute.RowID = CMCv.Security.Encrypt.MD5()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.DAR.Editor.GETRowValue(varFORMAttribute.RowID.ToString, DtpStart, MebStart, DtpEnd, MebEnd, CboArea, CboTemplate, TxtContent, TxtFeedback)
        Call LoadAttachment()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CboTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles CboTemplate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (varFORMAttribute.IsNew) Then
                If Decision("Do you want to replace Description with template content?", "Question", frmDBdialogbox.MessageIcon.Question, frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
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
                Decision("Plase pick your photo first.", "No file selected", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
                Decision("Your photo cannot be found.", "File not found", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtPhotoPath.Text, varMaxuploadsize_photo, True)) Then
                Return
            End If

            Dim varRow As Object() = Nothing
            Dim varDate As Date = Now
            Dim varPhoto As System.Drawing.Image = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(TxtPhotoPath.Text) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtPhotoPath.Text), varDate, varPhoto, "Add", varUSERAttribute.EID}

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
            Decision("Plase pick your photo first.", "No file selected", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
            Decision("Your photo cannot be found.", "File not found", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        frmDARsinglephotoviewer = New DAR_SinglePhotoViewer(TxtPhotoPath.Text)
        DISPLAY(frmDARsinglephotoviewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)

    End Sub

    Private Sub DgnPictureList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPictureList.CellContentClick
        Dim varSendergrid = DirectCast(sender, Dgn)

        If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected photo?", "Question", frmDBdialogbox.MessageIcon.Question, frmDBdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnPictureList.CurrentRow.Cells("photo_status").Value IsNot "Add" Then
                    varExtendedQuery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnPictureList.CurrentRow.Cells("photo_id").Value)
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
                'Dim string64 As String
                'string64 = DgnPictureList.CurrentRow.Cells("photo_content").Value.ToString
                'varPhotobyte = Convert.FromBase64String(string64)

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
            Decision("Plase pick your file first.", "No file selected", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
            Decision("Your file cannot be found.", "File not found", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        frmDARsinglepdfviewer = New DAR_SinglePDFViewer(TxtFilePath.Text, "", False)
        DISPLAY(frmDARsinglepdfviewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
    End Sub

    Private Sub BtnAddFile_Click(sender As Object, e As EventArgs) Handles BtnAddFile.Click
        Try
            If TxtFilePath.Text.Trim = String.Empty Then
                Decision("Plase pick your PDF file first.", "No file selected", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                Decision("Your file cannot be found.", "File not found", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtFilePath.Text, varMaxuploadsize_pdf, True)) Then
                Return
            End If

            Dim varRow As Object() = Nothing
            Dim varDate As Date = Now
            'Dim _PDFFile As Object = New IO.FileStream(TxtFilePath.Text, FileMode.Open, FileAccess.Read) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtFilePath.Text), CboFileTag.Text, varDate, TxtFilePath.Text, "Add", varUSERAttribute.EID}

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
            If Decision("Do you want to remove selected file?", "Question", frmDBdialogbox.MessageIcon.Question, frmDBdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnFileList.CurrentRow.Cells("file_status").Value IsNot "Add" Then
                    varExtendedQuery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnFileList.CurrentRow.Cells("file_id").Value)
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
        If Decision("Do you want to undo all changes?", "Question", frmDBdialogbox.MessageIcon.Question, frmDBdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (varFORMAttribute.IsNew) Then
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
