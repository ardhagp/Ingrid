Imports System.Data
Imports System.IO
Imports System.Runtime.Versioning
Imports CMCv

Public Class DAR_Editor
#Region "Variables"
    Public Event RecordSaved()
    Private _DAR_SinglePhotoViewer As DAR_SinglePhotoViewer
    Private _DAR_SinglePDFViewer As DAR_SinglePDFViewer
    Private _SQL As New Commands.DAR.Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private _DS(2) As DataSet
    Private _PhotoByte As Byte()
    Private _ExtQuery As String
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
        _DS(0) = New DataSet

        DblBuffer(DgnPictureList)
        DgnPictureList.Rows.Clear()
        TxtPhotoPath.Clear()

        _DS(0) = _SQL.DisplayPhotoGrid(V_FORMAttrib.RowID, DgnPictureList)

        For i As Integer = 0 To _DS(0).Tables("TPhotoFileEditor").Rows.Count - 1
            DgnPictureList.Rows.Add(_DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_id"), _DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_datetime"), _DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_content"), "", _DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_uploader"))
        Next

        If DgnPictureList.RowCount = 0 Then
            PctbxPhoto.Image = Nothing
        End If

        DgnFileList.Rows.Clear()
        TxtFilePath.Clear()

        _DS(1) = New DataSet

        DblBuffer(DgnFileList)
        _DS(1) = _SQL.DisplayFileGrid(V_FORMAttrib.RowID, DgnFileList)

        For i As Integer = 0 To _DS(1).Tables("TFileEditor").Rows.Count - 1
            DgnFileList.Rows.Add(_DS(1).Tables("TFileEditor").Rows(i).Item("file_id"), _DS(1).Tables("TFileEditor").Rows(i).Item("file_tag"), _DS(1).Tables("TFileEditor").Rows(i).Item("file_datetime"), _DS(1).Tables("TFileEditor").Rows(i).Item("file_content"), "", _DS(1).Tables("TFileEditor").Rows(i).Item("file_uploader"))
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

        _MMSMenu.LoadIn(Me, True)
        _MMSMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        DgnPictureList.XOGETNewColor()

        If (V_FORMAttrib.IsNew) Then
            V_FORMAttrib.RowID = CMCv.Security.Encrypt.MD5()
            MebStart.Text = If(Convert.ToString(Now.Hour).Length = 0, "00", If(Convert.ToString(Now.Hour).Length = 1, "0" & Now.Hour, Now.Hour)) & ":" & If(Convert.ToString(Now.Minute).Length = 0, "00", If(Convert.ToString(Now.Minute).Length = 1, "0" & Now.Minute, Now.Minute))
            MebEnd.Text = MebStart.Text
            TxtContent.Text = String.Empty
            ChkAddNew.Visible = True
            DtpStart.MinDate = "01/01/" & Year(Now())
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
        If Not (V_FORMAttrib.IsNew) Then
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
        Dim _ActivityStart_S As String
        Dim _ActivityEnd_S As String
        Dim _ActivityStart_D As Date
        Dim _ActivityEnd_D As Date

        Call CheckAllInput()

        If (TxtContent.Text = String.Empty) OrElse (CboArea.Items.Count = 0) OrElse (CboTemplate.Items.Count = 0) OrElse (MebStart.Text = String.Empty) OrElse (MebEnd.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Start Time, End Time, Area Affected, Activity Template selected and Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        _ActivityStart_S = DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day & " " & MebStart.Text
        _ActivityEnd_S = DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day & " " & MebEnd.Text
        _ActivityStart_D = CDate(_ActivityStart_S)
        _ActivityEnd_D = CDate(_ActivityEnd_S)

        If (_ActivityStart_D > _ActivityEnd_D) Then
            Decision("Cannot save your record." & Environment.NewLine & "Start Time should be less than End Time.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.DAR.Editor.PUSHData(CboArea.SelectedValue, CboTemplate.SelectedValue, DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day, MebStart.Text.Replace(".", ":"), DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day, MebEnd.Text.Replace(".", ":"), TxtContent.XOSQLText, TxtFeedback.XOSQLText, V_USERAttrib.UID, V_FORMAttrib.RowID, V_FORMAttrib.IsNew, _ExtQuery)) Then
            _ExtQuery = String.Empty
            Mainframe_n_6.Ts_status.Text = "Success"

            Dim _NewPhotoAdded As Integer = 0
            For Each _Row As DataGridViewRow In DgnPictureList.Rows
                If _Row.Cells("photo_status").Value = "Add" Then
                    _NewPhotoAdded += 1
                End If
            Next

            If _NewPhotoAdded > 0 Then
                If (Commands.DAR.Editor.PUSHPhoto(DgnPictureList, V_FORMAttrib.RowID, V_FORMAttrib.IsNew, DtpStart.Value)) Then
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
                If _Row.Cells("file_status").Value = "Add" Then
                    _NewFileAdded += 1
                End If
            Next

            If _NewFileAdded > 0 Then
                If (Commands.DAR.Editor.PUSHFile(DgnFileList, V_FORMAttrib.RowID, V_FORMAttrib.IsNew, DtpStart.Value)) Then
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
            V_FORMAttrib.RowID = CMCv.Security.Encrypt.MD5()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.DAR.Editor.GETRowValue(V_FORMAttrib.RowID, DtpStart, MebStart, DtpEnd, MebEnd, CboArea, CboTemplate, TxtContent, TxtFeedback)
        Call LoadAttachment()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CboTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles CboTemplate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (V_FORMAttrib.IsNew) Then
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
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtPhotoPath.Text, _MAXUPLOADSIZE_PHOTO, True)) Then
                Return
            End If

            Dim Row As Object() = Nothing
            Dim _Date As Date = Now
            Dim _Photo As System.Drawing.Image = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(TxtPhotoPath.Text) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            Row = New Object() {CMCv.Security.Encrypt.MD5(), _Date, _Photo, "Add", V_USERAttrib.EID}

            With DgnPictureList.Rows
                .Add(Row)
            End With

            TxtPhotoPath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        OfdPhoto.Title = "Ingrid Photo Picker"
        OfdPhoto.FileName = ""
        OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdPhoto.ShowDialog = DialogResult.OK Then
            TxtPhotoPath.Text = OfdPhoto.FileName
        End If
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

        _DAR_SinglePhotoViewer = New DAR_SinglePhotoViewer(TxtPhotoPath.Text)
        Display(_DAR_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)

    End Sub

    Private Sub DgnPictureList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPictureList.CellContentClick
        Dim sendergrid = DirectCast(sender, dgn)

        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected photo?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnPictureList.CurrentRow.Cells("photo_status").Value IsNot "Add" Then
                    _ExtQuery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnPictureList.CurrentRow.Cells("photo_id").Value)
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
            If DgnPictureList.CurrentRow.Cells("photo_status").Value = "Add" Then
                PctbxPhoto.Image = DgnPictureList.CurrentRow.Cells("photo_content").Value
            Else
                _PhotoByte = DgnPictureList.CurrentRow.Cells("photo_content").Value
                Dim _PhotoStream = New System.IO.MemoryStream(_PhotoByte)

                PctbxPhoto.Image = System.Drawing.Image.FromStream(_PhotoStream)
            End If
        End If
    End Sub

    Private Sub BtnBrowseFile_Click(sender As Object, e As EventArgs) Handles BtnBrowseFile.Click
        ofdFile.Title = "Ingrid File Picker"
        ofdFile.FileName = ""
        ofdFile.Filter = "PDF File|*.pdf;"

        If ofdFile.ShowDialog = DialogResult.OK Then
            TxtFilePath.Text = ofdFile.FileName
        End If
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

        _DAR_SinglePDFViewer = New DAR_SinglePDFViewer(TxtFilePath.Text, "", False)
        Display(_DAR_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
    End Sub

    Private Sub BtnAddFile_Click(sender As Object, e As EventArgs) Handles BtnAddFile.Click
        Try
            If TxtFilePath.Text.Trim = String.Empty Then
                Decision("Plase pick your PDF file first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                Decision("Your file cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtFilePath.Text, _MAXUPLOADSIZE_PDF, True)) Then
                Return
            End If

            Dim Row As Object() = Nothing
            Dim V_Date As Date = Now
            'Dim _PDFFile As Object = New IO.FileStream(TxtFilePath.Text, FileMode.Open, FileAccess.Read) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            Row = New Object() {CMCv.Security.Encrypt.MD5(), CboFileTag.Text, V_Date, TxtFilePath.Text, "Add", V_USERAttrib.EID}

            With DgnFileList.Rows
                .Add(Row)
            End With

            TxtFilePath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DgnFileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFileList.CellContentClick
        Dim sendergrid = DirectCast(sender, dgn)

        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected file?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnFileList.CurrentRow.Cells("file_status").Value IsNot "Add" Then
                    _ExtQuery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnFileList.CurrentRow.Cells("file_id").Value)
                End If
                DgnFileList.Rows.Remove(DgnFileList.SelectedRows(0))

            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventFileSave() Handles _MMSMenu.EventFileSave
        Call Save()
    End Sub

    Private Sub _MMSMenu_EventFileCancel() Handles _MMSMenu.EventFileCancel
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventFileUndoAll() Handles _MMSMenu.EventFileUndoAll
        If Decision("Do you want to undo all changes?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (V_FORMAttrib.IsNew) Then
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
