Imports System.Runtime.Versioning
Imports Serilog.Sinks.Http

''' <summary>
''' Module : DAR View
''' </summary>
Public Class DAR
#Region "Variables"
    'SQL Class
    Private _SQL As New Commands.DAR.View

    'Variabel -> Class
    Private WithEvents frmDAReditor As New DAR_Editor
    Private WithEvents frmDARreports As DAR_RPTFilter
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
    Private WithEvents clsCSmenu As New CMCv.UI.View.ContextMenu
    Private WithEvents frmDARsinglephotoviewer As DAR_SinglePhotoViewer
    Private WithEvents frmDARsinglepdfviewer As DAR_SinglePDFViewer

    'Variabel Biasa
    Private varShowattachment As Boolean
    Private varIDcontent As String
    Private varLoaddgdatefinished As Boolean
    Private varLoaddgcontentfinished As Boolean
    Private varPhotobyte As Byte() 'Variabel untuk konversi foto
    Private varPhotorow As Integer = 0 'Variabel baris foto
    Private varCurrentdate As Date
    Private varCurrentdate_s As String
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
        varLoaddgdatefinished = False
        varLoaddgcontentfinished = False

        'Buffer Datagrid
        DblBuffer(DgnDARDate)
        DblBuffer(DgnDARActivity)

        'Mengisi nilai variabel ShowAttachment
        varShowattachment = clsMMSmenu.Checked("EventToolsViewAttachment")

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
        clsMMSmenu.LoadIn(Me)

        'Menampilkan Menu DATA
        clsMMSmenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        clsMMSmenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        clsMMSmenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        clsMMSmenu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))

        'Mengambil nilai dari database usersettings, jika ya maka tampilkan Menu Show Attachment
        If (Commands.DAR.View.CheckSettings(varUSERAttribute.UID, "viewphototab")) Then
            clsMMSmenu.Checked("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = False
            Call LoadAttachment(varShowattachment)
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
        clsCSmenu.LoadInGrid(DgnDARActivity)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub OnDgnDateChange()
        If DgnDARDate.RowCount <> 0 Then
            varCurrentdate = CType(DgnDARDate.CurrentRow.Cells("employeeactivity_datetime").Value, Date)
            varCurrentdate_s = varCurrentdate.Year & "-" & varCurrentdate.Month & "-" & varCurrentdate.Day
        Else
            varCurrentdate = Now.AddYears(2)
            varCurrentdate_s = "9999-12-31"
        End If
        _SQL.DisplaySecondGrid(varCurrentdate_s, DgnDARActivity, SttActivity, TxtFind, varShowattachment, DgnPhoto, DgnFile)

        Call PhotoPlugin(varShowattachment)
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
                varPhotobyte = CType(DgnPhoto.CurrentRow.Cells("photo_content").Value, Byte())
                Dim _PhotoStream = New System.IO.MemoryStream(varPhotobyte)

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
        varFORMAttribute.RowID = "-1"

        If DgnDARActivity.RowCount > 0 Then
            varFORMAttribute.RowID = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value.ToString
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
        DtpMonth.Value = CType(Now.Year & "-" & Now.Month & "-1", Date)
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
            Commands.DAR.View.DisplayPhotoGrid(varIDcontent, DgnPhoto)

            Call PhotoPlugin(varShowattachment)

            DblBuffer(DgnFile)
            Commands.DAR.View.DisplayFileGrid(varIDcontent, DgnFile)
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        If Not (varUSRaccess.User("DAR", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If
        varFORMAttribute.IsNew = True
        varFORMAttribute.RowID = "-1"
        frmDAReditor = New DAR_Editor
        DISPLAY(frmDAReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new activity", True)
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        If Not (varUSRaccess.User("DAR", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        varFORMAttribute.IsNew = False

        If varFORMAttribute.RowID Is "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            frmDAReditor = New DAR_Editor
            DISPLAY(frmDAReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "update activity", True)
        End If
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        If Not (varUSRaccess.User("DAR", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If
        Call GETTableID()
        If varFORMAttribute.RowID Is "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            varFORMAttribute.IsNew = False
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value.ToString & vbCrLf & "=======================================================", "Delete", CMCv.frmDBdialogbox.MessageIcon.Question, CMCv.frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.DAR.View.DELETEData(varFORMAttribute.RowID.ToString)) Then
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
    Private Sub EventDataRefresh() Handles clsMMSmenu.EventDataRefresh
        TxtFind.Clear()
        ChkEnableDateFilter.Checked = False
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles clsMMSmenu.EventDataClose
        Me.Close()
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Toogle view photo menu
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventToolsViewAttachment() Handles clsMMSmenu.EventToolsViewAttachment
        If (clsMMSmenu.Checked("EventToolsViewAttachment")) Then
            clsMMSmenu.Checked("EventToolsViewAttachment", CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = True
            varShowattachment = False
        Else
            clsMMSmenu.Checked("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = False
            SpcContent.SplitterDistance = 200
            SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
            varShowattachment = True
        End If
        Call LoadAttachment(varShowattachment)
    End Sub
#End Region

#Region "Context Menu Event"
    Private Sub ContextCopy() Handles clsCSmenu.ContextCopy
        If DgnDARActivity.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            Clipboard.SetText(DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value.ToString)
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
        If (clsMMSmenu.Checked("EventToolsViewAttachment")) Then
            Commands.DAR.View.SaveSettings(varUSERAttribute.UID, "ViewPhotoTab", "True")
        Else
            Commands.DAR.View.SaveSettings(varUSERAttribute.UID, "ViewPhotoTab", "False")
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SpcDate.SplitterDistance = 190
        If (clsMMSmenu.Checked("EventToolsViewAttachment")) Then
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
            varIDcontent = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value.ToString
        Else
            varIDcontent = "-1"
        End If

        Call LoadAttachment(varShowattachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnDARActivity_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARActivity.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARActivity.RowCount > 1) Then
            Call OnDgnActivityChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.Dgn)

        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            frmDARsinglephotoviewer = New DAR_SinglePhotoViewer(PctbxActivityPhoto.Image)
            DISPLAY(frmDARsinglephotoviewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)
            Mainframe_n_6.Ts_status.Text = String.Empty
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellClick
        Call PhotoPlugin(varShowattachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnPhoto.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnPhoto.RowCount > 1) Then
            Call PhotoPlugin(varShowattachment)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnFile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFile.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.Dgn)
        Dim varBytes As Byte()

        Try
            If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim varFilename As String = DgnFile.CurrentRow.Cells("file_id").Value.ToString
                Dim varFullpath As String = Nothing
                Dim varDirtemplocation As String = Nothing

                'Cek apakah folder sudah ada
                varDirtemplocation = CHECKREQUIREDFOLDER(DirName.PDF)

                varFullpath = varDirtemplocation & varFilename & ".pdf"

                If (Not System.IO.File.Exists(varFullpath)) Then
                    varBytes = CType(Commands.DAR.View.GETPDFFile(varFilename), Byte())
                    System.IO.File.WriteAllBytes(varFullpath, varBytes)
                End If

                frmDARsinglepdfviewer = New DAR_SinglePDFViewer(varFullpath, varFilename, True)
                DISPLAY(frmDARsinglepdfviewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
                Mainframe_n_6.Ts_status.Text = String.Empty

                varBytes = Nothing
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
            Decision("No photo selected.", "Alert", CMCv.frmDBdialogbox.MessageIcon.Alert, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            If varTextmark = String.Empty Then
                CopyPicture = PctbxActivityPhoto.Image
            Else
                CopyPicture = CMCv.ImageEditor.Proccessor.Editor.Watermarker(PctbxActivityPhoto.Image, varTextmark)
            End If
            Clipboard.SetImage(CopyPicture)
        End If
        CopyPicture = Nothing
        'CopyPicture.Dispose()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SavePicture As Image

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDBdialogbox.MessageIcon.Alert, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            SfdPhoto.Title = "Ingrid Photo - Save As..."
            SfdPhoto.FileName = DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString & ".jpg"
            SfdPhoto.Filter = "Photo File|*.jpg"

            If SfdPhoto.ShowDialog = DialogResult.OK Then
                If varTextmark = String.Empty Then
                    SavePicture = PctbxActivityPhoto.Image
                Else
                    SavePicture = CMCv.ImageEditor.Proccessor.Editor.Watermarker(PctbxActivityPhoto.Image, varTextmark)
                End If
                SavePicture.Save(SfdPhoto.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
        SavePicture = Nothing
        'SavePicture.Dispose()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnLike_Click(sender As Object, e As EventArgs) Handles BtnLike.Click
        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDBdialogbox.MessageIcon.Alert, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            If Not (Commands.DAR.View.IsLike(DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString, varUSERAttribute.EID)) Then
                If (Commands.DAR.View.LikePhoto(DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString, varUSERAttribute.EID, DgnDARActivity.CurrentRow.Cells("employee_id").Value.ToString)) Then
                    Mainframe_n_6.Ts_status.Text = DgnPhoto.CurrentRow.Cells("photo_employee_fullname").Value.ToString & " would like to say thank you for your appreciation."
                Else
                    SLFStatus.Items(0).Text = ""
                End If
            End If
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub F_DAR_Editor_RecordSaved() Handles frmDAReditor.RecordSaved
        Call GETDATA(True)
        Call FillEmployee()
    End Sub

    Private Sub F_DAR_Editor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles frmDAReditor.FormClosed
        Me.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventReportShow() Handles clsMMSmenu.EventReportShow
        If Not (varUSRaccess.User("DAR", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Report)) Then
            Decision("You are not authorized to : Generate Report", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
            Return
        End If
        frmDARreports = New DAR_RPTFilter
        DISPLAY(frmDARreports, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Report Filter", "", True,)
    End Sub
#End Region

End Class
