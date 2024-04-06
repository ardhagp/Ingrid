Imports System.Runtime.Versioning

''' <summary>
''' Module : DAR View
''' </summary>
Public Class DAR
#Region "Variables"
    'SQL Class
    Private _SQL As New Commands.DAR.View

    'Variabel -> Class
    Private WithEvents F_DAR_Editor As New DAR_Editor
    Private WithEvents F_DAR_Reports As DAR_RPTFilter
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _CSMenu As New CMCv.UI.View.ContextMenu
    Private WithEvents _DAR_SinglePhotoViewer As DAR_SinglePhotoViewer
    Private WithEvents _DAR_SinglePDFViewer As DAR_SinglePDFViewer

    'Variabel Biasa
    Private _ShowAttachment As Boolean
    Private _ContentID As String
    Private _LoadDGDateFinished As Boolean
    Private _LoadDGContentFinished As Boolean
    Private _PhotoByte As Byte() 'Variabel untuk konversi foto
    Private _PhotoRow As Integer = 0 'Variabel baris foto
    Private _CurrentDate As Date
    Private _CurrentDate_S As String
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Mengisi CBOBy dengan data karyawan
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub FillEmployee()
        Commands.DAR.View.FillEmployee(CboBy)
    End Sub

    ''' <summary>
    ''' Menampilkan data awal
    ''' </summary>
    ''' <param name="ForceRefresh">Boolean</param>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        'Menyatakan bahwa datagrid belum selesai memuat data
        _LoadDGDateFinished = False
        _LoadDGContentFinished = False

        'Buffer Datagrid
        DblBuffer(DgnDARDate)
        DblBuffer(DgnDARActivity)

        'Mengisi nilai variabel ShowAttachment
        _ShowAttachment = _MMSMenu.Checked("EventToolsViewAttachment")

        'Mengisi Datagrid dengan data dari database    
        _SQL.DisplayMainGrid(TxtFind, DgnDARDate, SLFStatus, SttActivity, ChkEnableDateFilter, DtpMonth, ChkEnableByFilter, CboBy, ForceRefresh)

        'Mengisi Datagrid Activity dengan data dari database
        Call OnDgnDateChange()
    End Sub

    ''' <summary>
    ''' Menyisipkan menu pada form saat pertama kali dimuat.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub LoadMenu()
        'Sisipkan ke dalam form
        _MMSMenu.LoadIn(Me)

        'Menampilkan Menu DATA
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        _MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        _MMSMenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        _MMSMenu.Visible("EventToolsViewAttachment", True)

        'Mengambil nilai dari database usersettings, jika ya maka tampilkan Menu Show Attachment
        If (Commands.DAR.View.CheckSettings(V_USERAttrib.UID, "viewphototab")) Then
            _MMSMenu.Checked("EventToolsViewAttachment", True)
            SpcContent.Panel2Collapsed = False
            Call LoadAttachment(_ShowAttachment)
        Else
            SpcContent.Panel2Collapsed = True
        End If
    End Sub

    ''' <summary>
    ''' Memuat setting datagrid
    ''' </summary>
    Private Sub LoadDGN()
        'Memuat warna acak
        DgnDARDate.XOGETNewColor()
        DgnDARActivity.XOGETNewColor()
        DgnPhoto.XOGETNewColor()
        DgnFile.XOGETNewColor()

        'Memuat menu klik kanan
        _CSMenu.LoadInGrid(DgnDARActivity)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub OnDgnDateChange()
        If DgnDARDate.RowCount <> 0 Then
            _CurrentDate = DgnDARDate.CurrentRow.Cells("employeeactivity_datetime").Value
            _CurrentDate_S = _CurrentDate.Year & "-" & _CurrentDate.Month & "-" & _CurrentDate.Day
        Else
            _CurrentDate = Now.AddYears(2)
            _CurrentDate_S = "9999-12-31"
        End If
        _SQL.DisplaySecondGrid(_CurrentDate_S, DgnDARActivity, SttActivity, TxtFind, _ShowAttachment, DgnPhoto, DgnFile)

        Call PhotoPlugin(_ShowAttachment)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    <SupportedOSPlatform("windows")>
    Private Sub DgnDARActivity_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnDARActivity.CellClick
        Call OnDgnActivityChange()
    End Sub

    ''' <summary>
    ''' Menampilkan foto pada picture box
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub PhotoPlugin(ByVal IsTabAttachmentVisible As Boolean)
        If (IsTabAttachmentVisible) Then
            If DgnPhoto.RowCount = 0 Then
                PctbxActivityPhoto.Image = Nothing
                BtnCopyPhoto.Enabled = False
                BtnSave.Enabled = False
                BtnLike.Enabled = False
            Else
                _PhotoByte = DgnPhoto.CurrentRow.Cells("photo_content").Value
                Dim _PhotoStream = New System.IO.MemoryStream(_PhotoByte)

                PctbxActivityPhoto.Image = System.Drawing.Image.FromStream(_PhotoStream)
                BtnCopyPhoto.Enabled = True
                BtnSave.Enabled = True
                BtnLike.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Get photo by option
    ''' </summary>
    ''' <param name="IsTabOpen"></param>
    Public Sub GETPHOTOS(Optional ByVal IsTabOpen As Boolean = False)
        If (IsTabOpen) AndAlso (DgnDARActivity.RowCount <> 0) Then
            'waiting some code
        End If
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnDARActivity.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value
        End If
    End Sub

    ''' <summary>
    ''' Clearing filters and load default data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        ChkEnableDateFilter.Checked = False
        ChkEnableByFilter.Checked = False
        DtpMonth.Enabled = False
        DtpMonth.Value = Now.Year & "-" & Now.Month & "-1"
        CboBy.Enabled = False
        Call GETDATA(True)
        Call FillEmployee()
    End Sub

    ''' <summary>
    ''' Load attachment
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub LoadAttachment(ByVal IsTabAttachmentVisible As Boolean)
        If (IsTabAttachmentVisible) Then
            DblBuffer(DgnPhoto)
            Commands.DAR.View.DisplayPhotoGrid(_ContentID, DgnPhoto)

            Call PhotoPlugin(_ShowAttachment)

            DblBuffer(DgnFile)
            Commands.DAR.View.DisplayFileGrid(_ContentID, DgnFile)
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        If Not (V_USERAccess.User("DAR", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If
        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        F_DAR_Editor = New DAR_Editor
        DISPLAY(F_DAR_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new activity", True)
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        If Not (V_USERAccess.User("DAR", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        V_FORMAttrib.IsNew = False

        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            F_DAR_Editor = New DAR_Editor
            DISPLAY(F_DAR_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "update activity", True)
        End If
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        If Not (V_USERAccess.User("DAR", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If
        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value & vbCrLf & "=======================================================", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.DAR.View.DELETEData(V_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    Call FillEmployee()
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Load data with filter applied
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        ChkEnableDateFilter.Checked = False
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Toogle view photo menu
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventToolsViewAttachment() Handles _MMSMenu.EventToolsViewAttachment
        If (_MMSMenu.Checked("EventToolsViewAttachment")) Then
            _MMSMenu.Checked("EventToolsViewAttachment", False)
            SpcContent.Panel2Collapsed = True
            _ShowAttachment = False
        Else
            _MMSMenu.Checked("EventToolsViewAttachment", True)
            SpcContent.Panel2Collapsed = False
            SpcContent.SplitterDistance = 200
            SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
            _ShowAttachment = True
        End If
        Call LoadAttachment(_ShowAttachment)
    End Sub
#End Region

#Region "Context Menu Event"
    Private Sub ContextCopy() Handles _CSMenu.ContextCopy
        If DgnDARActivity.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            Clipboard.SetText(DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value)
        End If
    End Sub
#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA(False)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DtpMonth_KeyDown(sender As Object, e As KeyEventArgs) Handles DtpMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA(False)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
    End Sub

    Private Sub ChkEnableDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEnableDateFilter.CheckedChanged
        DtpMonth.Enabled = ChkEnableDateFilter.Checked
    End Sub
#End Region

#Region "Main Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub frmDailyActivityReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Memuat Menu
        Call LoadMenu()

        'Memuat Datagrid
        Call LoadDGN()

        'Memuat Data
        Call ClearFind()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (_MMSMenu.Checked("EventToolsViewAttachment")) Then
            Commands.DAR.View.SaveSettings(V_USERAttrib.UID, "ViewPhotoTab", "True")
        Else
            Commands.DAR.View.SaveSettings(V_USERAttrib.UID, "ViewPhotoTab", "False")
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SpcDate.SplitterDistance = 190
        If (_MMSMenu.Checked("EventToolsViewAttachment")) Then
            'SpcContent.SplitterDistance = 200
        End If
        SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
    End Sub
#End Region

#Region "Component Events : Cbo"
    <SupportedOSPlatform("windows")>
    Private Sub CboBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBy.SelectedIndexChanged
        If (ChkEnableByFilter.Checked) Then
            Call GETDATA(False)
        End If
    End Sub
#End Region

#Region "Component Events : Chk"
    <SupportedOSPlatform("windows")>
    Private Sub ByFilterChkEnableBy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEnableByFilter.CheckedChanged
        CboBy.Enabled = ChkEnableByFilter.Checked
        If (ChkEnableByFilter.Checked) Then
            Call GETDATA(False)
        End If
    End Sub
#End Region

#Region "Component Events : Dgn"
    <SupportedOSPlatform("windows")>
    Private Sub DgnDARDate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnDARDate.CellClick
        If DgnDARDate.RowCount <> 0 Then
            Call OnDgnDateChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnDARDate_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARDate.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARDate.RowCount > 1) Then
            Call OnDgnDateChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub OnDgnActivityChange()
        If DgnDARActivity.RowCount <> 0 Then
            _ContentID = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value
        Else
            _ContentID = "-1"
        End If

        Call LoadAttachment(_ShowAttachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnDARActivity_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARActivity.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARActivity.RowCount > 1) Then
            Call OnDgnActivityChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.dgn)

        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            _DAR_SinglePhotoViewer = New DAR_SinglePhotoViewer(PctbxActivityPhoto.Image)
            Display(_DAR_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)
            Mainframe_n_6.Ts_status.Text = String.Empty
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellClick
        Call PhotoPlugin(_ShowAttachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnPhoto.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnPhoto.RowCount > 1) Then
            Call PhotoPlugin(_ShowAttachment)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnFile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFile.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.dgn)
        Dim _Bytes As Byte()

        Try
            If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim _FileName As String = DgnFile.CurrentRow.Cells("file_id").Value
                Dim _FullPath As String = Nothing
                Dim _DirTempLocation As String = Nothing

                'Cek apakah folder sudah ada
                _DirTempLocation = CHECKREQUIREDFOLDER(DirName.PDF)

                _FullPath = _DirTempLocation & _FileName & ".pdf"

                If (Not System.IO.File.Exists(_FullPath)) Then
                    _Bytes = Commands.DAR.View.GETPDFFile(_FileName)
                    System.IO.File.WriteAllBytes(_FullPath, _Bytes)
                End If

                _DAR_SinglePDFViewer = New DAR_SinglePDFViewer(_FullPath, _FileName, True)
                Display(_DAR_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
                Mainframe_n_6.Ts_status.Text = String.Empty

                _Bytes = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Component Events : Btn"

    <SupportedOSPlatform("windows")>
    Private Sub BtnCopyPhoto_Click(sender As Object, e As EventArgs) Handles BtnCopyPhoto.Click
        Dim CopyPicture As Image

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDialogBox.MessageIcon.Alert, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If _TEXTMARK = String.Empty Then
                CopyPicture = PctbxActivityPhoto.Image
            Else
                CopyPicture = V_IMG_EDITOR.Watermarker(PctbxActivityPhoto.Image, _TEXTMARK)
            End If
            Clipboard.SetImage(CopyPicture)
        End If
        CopyPicture = Nothing
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SavePicture As Image

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDialogBox.MessageIcon.Alert, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            SfdPhoto.Title = "Ingrid Photo - Save As..."
            SfdPhoto.FileName = DgnPhoto.CurrentRow.Cells("photo_id").Value & ".jpg"
            SfdPhoto.Filter = "Photo File|*.jpg"

            If SfdPhoto.ShowDialog = DialogResult.OK Then
                If _TEXTMARK = String.Empty Then
                    SavePicture = PctbxActivityPhoto.Image
                Else
                    SavePicture = V_IMG_EDITOR.Watermarker(PctbxActivityPhoto.Image, _TEXTMARK)
                End If
                SavePicture.Save(SfdPhoto.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
        SavePicture = Nothing
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnLike_Click(sender As Object, e As EventArgs) Handles BtnLike.Click
        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDialogBox.MessageIcon.Alert, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Not (Commands.DAR.View.IsLike(DgnPhoto.CurrentRow.Cells("photo_id").Value, V_USERAttrib.EID)) Then
                If (Commands.DAR.View.LikePhoto(DgnPhoto.CurrentRow.Cells("photo_id").Value, V_USERAttrib.EID, DgnDARActivity.CurrentRow.Cells("employee_id").Value)) Then
                    Mainframe_n_6.Ts_status.Text = DgnPhoto.CurrentRow.Cells("photo_employee_fullname").Value & " would like to say thank you for your appreciation."
                Else
                    SLFStatus.Items(0).Text = ""
                End If
            End If
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub F_DAR_Editor_RecordSaved() Handles F_DAR_Editor.RecordSaved
        Call GETDATA(True)
        Call FillEmployee()
    End Sub

    Private Sub F_DAR_Editor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles F_DAR_Editor.FormClosed
        Me.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventReportShow() Handles _MMSMenu.EventReportShow
        If Not (V_USERAccess.User("DAR", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Report)) Then
            Decision("You are not authorized to : Generate Report", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If
        F_DAR_Reports = New DAR_RPTFilter
        DISPLAY(F_DAR_Reports, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Report Filter", "", True,)
    End Sub
#End Region

End Class
