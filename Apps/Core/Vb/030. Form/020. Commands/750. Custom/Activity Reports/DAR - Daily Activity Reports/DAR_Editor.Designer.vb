<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAR_Editor
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DAR_Editor))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        CboTemplate = New cbo(components)
        DtpStart = New dtp(components)
        TxtContent = New txt(components)
        CboArea = New cbo(components)
        MebStart = New meb(components)
        BtnGETContent = New btn(components)
        ChkAddNew = New chk(components)
        MebEnd = New meb(components)
        DtpEnd = New dtp(components)
        TxtFeedback = New txt(components)
        OfdPhoto = New OpenFileDialog()
        TbctlAttachment = New tbctl(components)
        tpPhotos = New TabPage()
        PnlPhoto = New pnl(components)
        BtnBrowsePhoto = New btn(components)
        PctbxPhoto = New pctbx(components)
        DgnPictureList = New dgn(components)
        photo_id = New DataGridViewTextBoxColumn()
        photo_datetime = New DataGridViewTextBoxColumn()
        photo_content = New DataGridViewImageColumn()
        photo_status = New DataGridViewTextBoxColumn()
        photo_uploader = New DataGridViewTextBoxColumn()
        photo_delete = New DataGridViewButtonColumn()
        BtnPeekPhoto = New btn(components)
        TxtPhotoPath = New txt(components)
        BtnAddPhoto = New btn(components)
        tpFiles = New TabPage()
        PnlFile = New pnl(components)
        BtnBrowseFile = New btn(components)
        DgnFileList = New dgn(components)
        file_id = New DataGridViewTextBoxColumn()
        file_tag = New DataGridViewTextBoxColumn()
        file_datetime = New DataGridViewTextBoxColumn()
        file_content = New DataGridViewTextBoxColumn()
        file_status = New DataGridViewTextBoxColumn()
        file_uploader = New DataGridViewTextBoxColumn()
        file_delete = New DataGridViewButtonColumn()
        CboFileTag = New cbo(components)
        TxtFilePath = New txt(components)
        BtnAddFile = New btn(components)
        BtnPeekFile = New btn(components)
        ofdFile = New OpenFileDialog()
        ULbl1 = New ULbl()
        ULbl2 = New ULbl()
        ULbl3 = New ULbl()
        ULbl4 = New ULbl()
        ULbl5 = New ULbl()
        ULbl6 = New ULbl()
        ULbl7 = New ULbl()
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlAttachment.SuspendLayout()
        tpPhotos.SuspendLayout()
        PnlPhoto.SuspendLayout()
        CType(PctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnPictureList, ComponentModel.ISupportInitialize).BeginInit()
        tpFiles.SuspendLayout()
        PnlFile.SuspendLayout()
        CType(DgnFileList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkAddNew)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 687)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(842, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(842, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.AutoScroll = True
        SLFPanel.AutoScrollMinSize = New Size(1, 1)
        SLFPanel.Controls.Add(ULbl7)
        SLFPanel.Controls.Add(ULbl6)
        SLFPanel.Controls.Add(ULbl5)
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TbctlAttachment)
        SLFPanel.Controls.Add(TxtFeedback)
        SLFPanel.Controls.Add(MebEnd)
        SLFPanel.Controls.Add(DtpEnd)
        SLFPanel.Controls.Add(BtnGETContent)
        SLFPanel.Controls.Add(MebStart)
        SLFPanel.Controls.Add(CboArea)
        SLFPanel.Controls.Add(TxtContent)
        SLFPanel.Controls.Add(DtpStart)
        SLFPanel.Controls.Add(CboTemplate)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(842, 745)
        SLFPanel.Controls.SetChildIndex(CboTemplate, 0)
        SLFPanel.Controls.SetChildIndex(DtpStart, 0)
        SLFPanel.Controls.SetChildIndex(TxtContent, 0)
        SLFPanel.Controls.SetChildIndex(CboArea, 0)
        SLFPanel.Controls.SetChildIndex(MebStart, 0)
        SLFPanel.Controls.SetChildIndex(BtnGETContent, 0)
        SLFPanel.Controls.SetChildIndex(DtpEnd, 0)
        SLFPanel.Controls.SetChildIndex(MebEnd, 0)
        SLFPanel.Controls.SetChildIndex(TxtFeedback, 0)
        SLFPanel.Controls.SetChildIndex(TbctlAttachment, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
        SLFPanel.Controls.SetChildIndex(ULbl5, 0)
        SLFPanel.Controls.SetChildIndex(ULbl6, 0)
        SLFPanel.Controls.SetChildIndex(ULbl7, 0)
        ' 
        ' BtnSave
        ' 
        BtnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnSave.BackColor = Color.LimeGreen
        BtnSave.Cursor = Cursors.Hand
        BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnSave.FlatAppearance.BorderSize = 2
        BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(587, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 600
        BtnSave.Text = "&Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnCancel.BackColor = Color.Red
        BtnCancel.Cursor = Cursors.Hand
        BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnCancel.FlatAppearance.BorderSize = 2
        BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnCancel.FlatStyle = FlatStyle.Flat
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(711, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 602
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' CboTemplate
        ' 
        CboTemplate.DropDownStyle = ComboBoxStyle.DropDownList
        CboTemplate.DropDownWidth = 350
        CboTemplate.FlatStyle = FlatStyle.Flat
        CboTemplate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboTemplate.FormattingEnabled = True
        CboTemplate.Location = New Point(196, 133)
        CboTemplate.Margin = New Padding(4, 3, 4, 3)
        CboTemplate.Name = "CboTemplate"
        CboTemplate.Size = New Size(269, 29)
        CboTemplate.TabIndex = 5
        ' 
        ' DtpStart
        ' 
        DtpStart.CustomFormat = "dd MMMM yyyy"
        DtpStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpStart.Format = DateTimePickerFormat.Custom
        DtpStart.Location = New Point(196, 12)
        DtpStart.Margin = New Padding(4, 3, 4, 3)
        DtpStart.MaxDate = New Date(2026, 6, 13, 0, 0, 0, 0)
        DtpStart.MinDate = New Date(1916, 6, 13, 0, 0, 0, 0)
        DtpStart.Name = "DtpStart"
        DtpStart.Size = New Size(205, 29)
        DtpStart.SLFResetOnDisabled = False
        DtpStart.TabIndex = 0
        ' 
        ' TxtContent
        ' 
        TxtContent.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContent.Location = New Point(196, 173)
        TxtContent.Margin = New Padding(4, 3, 4, 3)
        TxtContent.MaxLength = 99999999
        TxtContent.Multiline = True
        TxtContent.Name = "TxtContent"
        TxtContent.ScrollBars = ScrollBars.Vertical
        TxtContent.Size = New Size(632, 138)
        TxtContent.SLFAutoTrim = True
        TxtContent.SLFHarusDiisi = True
        TxtContent.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtContent.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtContent.SLFHightlightSaatFokus = True
        TxtContent.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtContent.SLFIsBlank = True
        TxtContent.SLFIsSearchBox = False
        TxtContent.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtContent.SLFPilihSemuaSaatFokus = False
        TxtContent.SLFPwdLengthMin = 8
        TxtContent.SLFPwdStrengthCalculate = False
        TxtContent.SLFPwdStrengthScore = 0
        TxtContent.SLFPwdStrengthText = Nothing
        TxtContent.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtContent.SLFSearchBoxText = "Type then press Enter"
        TxtContent.SLFSQLText = Nothing
        TxtContent.SLFTanpaSpasi = False
        TxtContent.SLFValidasiField = Nothing
        TxtContent.TabIndex = 7
        TxtContent.Tag = "txt"
        ' 
        ' CboArea
        ' 
        CboArea.DropDownStyle = ComboBoxStyle.DropDownList
        CboArea.DropDownWidth = 350
        CboArea.FlatStyle = FlatStyle.Flat
        CboArea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboArea.FormattingEnabled = True
        CboArea.Location = New Point(196, 92)
        CboArea.Margin = New Padding(4, 3, 4, 3)
        CboArea.Name = "CboArea"
        CboArea.Size = New Size(269, 29)
        CboArea.TabIndex = 4
        ' 
        ' MebStart
        ' 
        MebStart.AsciiOnly = True
        MebStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MebStart.Location = New Point(408, 12)
        MebStart.Margin = New Padding(4, 3, 4, 3)
        MebStart.Mask = "00:00"
        MebStart.Name = "MebStart"
        MebStart.Size = New Size(56, 29)
        MebStart.SLFHarusDiisi = True
        MebStart.SLFHarusDiisiWarnaLatar = Color.LightPink
        MebStart.SLFHarusDiisiWarnaLatarDefault = Color.White
        MebStart.SLFHightlightSaatFokus = True
        MebStart.SLFHightlightSaatFokusWarna = Color.LightYellow
        MebStart.SLFPilihSemuaSaatFokus = True
        MebStart.TabIndex = 1
        MebStart.TextAlign = HorizontalAlignment.Center
        MebStart.ValidatingType = GetType(Date)
        ' 
        ' BtnGETContent
        ' 
        BtnGETContent.BackColor = Color.RoyalBlue
        BtnGETContent.Cursor = Cursors.Hand
        BtnGETContent.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnGETContent.FlatAppearance.BorderSize = 2
        BtnGETContent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnGETContent.FlatStyle = FlatStyle.Flat
        BtnGETContent.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnGETContent.ForeColor = Color.White
        BtnGETContent.Location = New Point(472, 125)
        BtnGETContent.Margin = New Padding(4, 3, 4, 3)
        BtnGETContent.Name = "BtnGETContent"
        BtnGETContent.Size = New Size(117, 46)
        BtnGETContent.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnGETContent.SLFTampilkanFocusBorder = False
        BtnGETContent.SLFValidasiSemuaInput = False
        BtnGETContent.SLFValidasiSemuaInputTag = Nothing
        BtnGETContent.TabIndex = 6
        BtnGETContent.Text = "Apply"
        BtnGETContent.UseVisualStyleBackColor = False
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(434, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 601
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' MebEnd
        ' 
        MebEnd.AsciiOnly = True
        MebEnd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MebEnd.Location = New Point(408, 52)
        MebEnd.Margin = New Padding(4, 3, 4, 3)
        MebEnd.Mask = "00:00"
        MebEnd.Name = "MebEnd"
        MebEnd.Size = New Size(56, 29)
        MebEnd.SLFHarusDiisi = True
        MebEnd.SLFHarusDiisiWarnaLatar = Color.LightPink
        MebEnd.SLFHarusDiisiWarnaLatarDefault = Color.White
        MebEnd.SLFHightlightSaatFokus = True
        MebEnd.SLFHightlightSaatFokusWarna = Color.LightYellow
        MebEnd.SLFPilihSemuaSaatFokus = True
        MebEnd.TabIndex = 3
        MebEnd.TextAlign = HorizontalAlignment.Center
        MebEnd.ValidatingType = GetType(Date)
        ' 
        ' DtpEnd
        ' 
        DtpEnd.CustomFormat = "dd MMMM yyyy"
        DtpEnd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpEnd.Format = DateTimePickerFormat.Custom
        DtpEnd.Location = New Point(196, 52)
        DtpEnd.Margin = New Padding(4, 3, 4, 3)
        DtpEnd.MaxDate = New Date(2026, 6, 13, 0, 0, 0, 0)
        DtpEnd.MinDate = New Date(1916, 6, 13, 0, 0, 0, 0)
        DtpEnd.Name = "DtpEnd"
        DtpEnd.Size = New Size(205, 29)
        DtpEnd.SLFResetOnDisabled = False
        DtpEnd.TabIndex = 2
        ' 
        ' TxtFeedback
        ' 
        TxtFeedback.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFeedback.Location = New Point(196, 318)
        TxtFeedback.Margin = New Padding(4, 3, 4, 3)
        TxtFeedback.MaxLength = 255
        TxtFeedback.Multiline = True
        TxtFeedback.Name = "TxtFeedback"
        TxtFeedback.ScrollBars = ScrollBars.Vertical
        TxtFeedback.Size = New Size(632, 71)
        TxtFeedback.SLFAutoTrim = True
        TxtFeedback.SLFHarusDiisi = False
        TxtFeedback.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtFeedback.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtFeedback.SLFHightlightSaatFokus = True
        TxtFeedback.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtFeedback.SLFIsBlank = True
        TxtFeedback.SLFIsSearchBox = False
        TxtFeedback.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtFeedback.SLFPilihSemuaSaatFokus = False
        TxtFeedback.SLFPwdLengthMin = 8
        TxtFeedback.SLFPwdStrengthCalculate = False
        TxtFeedback.SLFPwdStrengthScore = 0
        TxtFeedback.SLFPwdStrengthText = Nothing
        TxtFeedback.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtFeedback.SLFSearchBoxText = "Type then press Enter"
        TxtFeedback.SLFSQLText = ""
        TxtFeedback.SLFTanpaSpasi = False
        TxtFeedback.SLFValidasiField = Nothing
        TxtFeedback.TabIndex = 8
        TxtFeedback.Tag = "txt"
        ' 
        ' OfdPhoto
        ' 
        OfdPhoto.FileName = "OpenFileDialog1"
        ' 
        ' TbctlAttachment
        ' 
        TbctlAttachment.Controls.Add(tpPhotos)
        TbctlAttachment.Controls.Add(tpFiles)
        TbctlAttachment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlAttachment.Location = New Point(196, 397)
        TbctlAttachment.Margin = New Padding(4, 3, 4, 3)
        TbctlAttachment.Name = "TbctlAttachment"
        TbctlAttachment.SelectedIndex = 0
        TbctlAttachment.Size = New Size(637, 237)
        TbctlAttachment.TabIndex = 1002
        ' 
        ' tpPhotos
        ' 
        tpPhotos.AutoScroll = True
        tpPhotos.AutoScrollMinSize = New Size(1, 1)
        tpPhotos.Controls.Add(PnlPhoto)
        tpPhotos.Location = New Point(4, 30)
        tpPhotos.Margin = New Padding(4, 3, 4, 3)
        tpPhotos.Name = "tpPhotos"
        tpPhotos.Padding = New Padding(4, 3, 4, 3)
        tpPhotos.Size = New Size(629, 203)
        tpPhotos.TabIndex = 0
        tpPhotos.Text = "Photos"
        tpPhotos.UseVisualStyleBackColor = True
        ' 
        ' PnlPhoto
        ' 
        PnlPhoto.Controls.Add(BtnBrowsePhoto)
        PnlPhoto.Controls.Add(PctbxPhoto)
        PnlPhoto.Controls.Add(DgnPictureList)
        PnlPhoto.Controls.Add(BtnPeekPhoto)
        PnlPhoto.Controls.Add(TxtPhotoPath)
        PnlPhoto.Controls.Add(BtnAddPhoto)
        PnlPhoto.Dock = DockStyle.Fill
        PnlPhoto.Location = New Point(4, 3)
        PnlPhoto.Margin = New Padding(4, 3, 4, 3)
        PnlPhoto.Name = "PnlPhoto"
        PnlPhoto.Size = New Size(621, 197)
        PnlPhoto.TabIndex = 11
        ' 
        ' BtnBrowsePhoto
        ' 
        BtnBrowsePhoto.BackColor = Color.RoyalBlue
        BtnBrowsePhoto.Cursor = Cursors.Hand
        BtnBrowsePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnBrowsePhoto.FlatAppearance.BorderSize = 2
        BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnBrowsePhoto.FlatStyle = FlatStyle.Flat
        BtnBrowsePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowsePhoto.ForeColor = Color.White
        BtnBrowsePhoto.Image = My.Resources.Resources.Bullets_001_16_FFFFFFFF_
        BtnBrowsePhoto.Location = New Point(4, 3)
        BtnBrowsePhoto.Margin = New Padding(4, 3, 4, 3)
        BtnBrowsePhoto.Name = "BtnBrowsePhoto"
        BtnBrowsePhoto.Size = New Size(38, 33)
        BtnBrowsePhoto.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnBrowsePhoto.SLFTampilkanFocusBorder = False
        BtnBrowsePhoto.SLFValidasiSemuaInput = False
        BtnBrowsePhoto.SLFValidasiSemuaInputTag = Nothing
        BtnBrowsePhoto.TabIndex = 5
        BtnBrowsePhoto.UseVisualStyleBackColor = False
        ' 
        ' PctbxPhoto
        ' 
        PctbxPhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PctbxPhoto.BackColor = Color.DarkSlateGray
        PctbxPhoto.BackgroundImage = My.Resources.Resources.PCTPRV_001_512_icon
        PctbxPhoto.BackgroundImageLayout = ImageLayout.Zoom
        PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), Image)
        PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), Image)
        PctbxPhoto.Location = New Point(429, 3)
        PctbxPhoto.Margin = New Padding(4, 3, 4, 3)
        PctbxPhoto.Name = "PctbxPhoto"
        PctbxPhoto.Size = New Size(188, 194)
        PctbxPhoto.SizeMode = PictureBoxSizeMode.Zoom
        PctbxPhoto.SLFTampilkanBorder = False
        PctbxPhoto.SLFWarnaBorder = Color.DodgerBlue
        PctbxPhoto.TabIndex = 6
        PctbxPhoto.TabStop = False
        ' 
        ' DgnPictureList
        ' 
        DgnPictureList.AllowUserToAddRows = False
        DgnPictureList.AllowUserToDeleteRows = False
        DgnPictureList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(225), CByte(211), CByte(144))
        DgnPictureList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnPictureList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgnPictureList.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnPictureList.BorderStyle = BorderStyle.None
        DgnPictureList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnPictureList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnPictureList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnPictureList.ColumnHeadersHeight = 43
        DgnPictureList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnPictureList.Columns.AddRange(New DataGridViewColumn() {photo_id, photo_datetime, photo_content, photo_status, photo_uploader, photo_delete})
        DgnPictureList.EnableHeadersVisualStyles = False
        DgnPictureList.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnPictureList.Location = New Point(4, 44)
        DgnPictureList.Margin = New Padding(4, 3, 4, 3)
        DgnPictureList.MultiSelect = False
        DgnPictureList.Name = "DgnPictureList"
        DgnPictureList.ReadOnly = True
        DgnPictureList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnPictureList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnPictureList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnPictureList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgnPictureList.Size = New Size(419, 150)
        DgnPictureList.SLFGroupFirstRows = False
        DgnPictureList.SLFGunakanNomorBaris = True
        DgnPictureList.StandardTab = True
        DgnPictureList.TabIndex = 10
        ' 
        ' photo_id
        ' 
        photo_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        photo_id.DataPropertyName = "file_id"
        photo_id.HeaderText = "ID"
        photo_id.Name = "photo_id"
        photo_id.ReadOnly = True
        photo_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' photo_datetime
        ' 
        photo_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo_datetime.DataPropertyName = "file_datetime"
        photo_datetime.HeaderText = "Date Added"
        photo_datetime.Name = "photo_datetime"
        photo_datetime.ReadOnly = True
        photo_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_datetime.Width = 89
        ' 
        ' photo_content
        ' 
        photo_content.DataPropertyName = "file_content"
        photo_content.HeaderText = "Photo"
        photo_content.Name = "photo_content"
        photo_content.ReadOnly = True
        photo_content.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_content.Visible = False
        ' 
        ' photo_status
        ' 
        photo_status.DataPropertyName = "file_status"
        photo_status.HeaderText = "Status"
        photo_status.Name = "photo_status"
        photo_status.ReadOnly = True
        photo_status.SortMode = DataGridViewColumnSortMode.NotSortable
        photo_status.Visible = False
        ' 
        ' photo_uploader
        ' 
        photo_uploader.DataPropertyName = "file_uploader"
        photo_uploader.HeaderText = "Uploader"
        photo_uploader.Name = "photo_uploader"
        photo_uploader.ReadOnly = True
        photo_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_uploader.Visible = False
        ' 
        ' photo_delete
        ' 
        photo_delete.DataPropertyName = "file_delete"
        photo_delete.HeaderText = ""
        photo_delete.Name = "photo_delete"
        photo_delete.ReadOnly = True
        photo_delete.Text = "🗑"
        photo_delete.ToolTipText = "Delete"
        photo_delete.UseColumnTextForButtonValue = True
        photo_delete.Width = 19
        ' 
        ' BtnPeekPhoto
        ' 
        BtnPeekPhoto.BackColor = Color.Crimson
        BtnPeekPhoto.Cursor = Cursors.Hand
        BtnPeekPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(160), CByte(20), CByte(0))
        BtnPeekPhoto.FlatAppearance.BorderSize = 2
        BtnPeekPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(40), CByte(80))
        BtnPeekPhoto.FlatStyle = FlatStyle.Flat
        BtnPeekPhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPeekPhoto.ForeColor = Color.White
        BtnPeekPhoto.Image = My.Resources.Resources.Peek_001_16_FFFFFFFF_
        BtnPeekPhoto.Location = New Point(338, 3)
        BtnPeekPhoto.Margin = New Padding(4, 3, 4, 3)
        BtnPeekPhoto.Name = "BtnPeekPhoto"
        BtnPeekPhoto.Size = New Size(38, 33)
        BtnPeekPhoto.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnPeekPhoto.SLFTampilkanFocusBorder = False
        BtnPeekPhoto.SLFValidasiSemuaInput = False
        BtnPeekPhoto.SLFValidasiSemuaInputTag = Nothing
        BtnPeekPhoto.TabIndex = 8
        BtnPeekPhoto.UseVisualStyleBackColor = False
        ' 
        ' TxtPhotoPath
        ' 
        TxtPhotoPath.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPhotoPath.Location = New Point(49, 3)
        TxtPhotoPath.Margin = New Padding(4, 3, 4, 3)
        TxtPhotoPath.MaxLength = 255
        TxtPhotoPath.Name = "TxtPhotoPath"
        TxtPhotoPath.ReadOnly = True
        TxtPhotoPath.Size = New Size(282, 29)
        TxtPhotoPath.SLFAutoTrim = False
        TxtPhotoPath.SLFHarusDiisi = False
        TxtPhotoPath.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPhotoPath.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPhotoPath.SLFHightlightSaatFokus = False
        TxtPhotoPath.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPhotoPath.SLFIsBlank = True
        TxtPhotoPath.SLFIsSearchBox = False
        TxtPhotoPath.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPhotoPath.SLFPilihSemuaSaatFokus = False
        TxtPhotoPath.SLFPwdLengthMin = 8
        TxtPhotoPath.SLFPwdStrengthCalculate = False
        TxtPhotoPath.SLFPwdStrengthScore = 0
        TxtPhotoPath.SLFPwdStrengthText = Nothing
        TxtPhotoPath.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPhotoPath.SLFSearchBoxText = "Type then press Enter"
        TxtPhotoPath.SLFSQLText = ""
        TxtPhotoPath.SLFTanpaSpasi = False
        TxtPhotoPath.SLFValidasiField = Nothing
        TxtPhotoPath.TabIndex = 7
        TxtPhotoPath.Tag = "txt"
        ' 
        ' BtnAddPhoto
        ' 
        BtnAddPhoto.BackColor = Color.LimeGreen
        BtnAddPhoto.Cursor = Cursors.Hand
        BtnAddPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnAddPhoto.FlatAppearance.BorderSize = 2
        BtnAddPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnAddPhoto.FlatStyle = FlatStyle.Flat
        BtnAddPhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAddPhoto.ForeColor = Color.White
        BtnAddPhoto.Image = My.Resources.Resources.Plus_001_16_FFFFFFFF_
        BtnAddPhoto.Location = New Point(384, 3)
        BtnAddPhoto.Margin = New Padding(4, 3, 4, 3)
        BtnAddPhoto.Name = "BtnAddPhoto"
        BtnAddPhoto.Size = New Size(38, 33)
        BtnAddPhoto.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnAddPhoto.SLFTampilkanFocusBorder = False
        BtnAddPhoto.SLFValidasiSemuaInput = False
        BtnAddPhoto.SLFValidasiSemuaInputTag = Nothing
        BtnAddPhoto.TabIndex = 9
        BtnAddPhoto.UseVisualStyleBackColor = False
        ' 
        ' tpFiles
        ' 
        tpFiles.Controls.Add(PnlFile)
        tpFiles.Location = New Point(4, 30)
        tpFiles.Margin = New Padding(4, 3, 4, 3)
        tpFiles.Name = "tpFiles"
        tpFiles.Padding = New Padding(4, 3, 4, 3)
        tpFiles.Size = New Size(629, 203)
        tpFiles.TabIndex = 1
        tpFiles.Text = "PDF"
        tpFiles.UseVisualStyleBackColor = True
        ' 
        ' PnlFile
        ' 
        PnlFile.Controls.Add(BtnBrowseFile)
        PnlFile.Controls.Add(DgnFileList)
        PnlFile.Controls.Add(CboFileTag)
        PnlFile.Controls.Add(TxtFilePath)
        PnlFile.Controls.Add(BtnAddFile)
        PnlFile.Controls.Add(BtnPeekFile)
        PnlFile.Dock = DockStyle.Fill
        PnlFile.Location = New Point(4, 3)
        PnlFile.Margin = New Padding(4, 3, 4, 3)
        PnlFile.Name = "PnlFile"
        PnlFile.Size = New Size(621, 197)
        PnlFile.TabIndex = 16
        ' 
        ' BtnBrowseFile
        ' 
        BtnBrowseFile.BackColor = Color.RoyalBlue
        BtnBrowseFile.Cursor = Cursors.Hand
        BtnBrowseFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnBrowseFile.FlatAppearance.BorderSize = 2
        BtnBrowseFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnBrowseFile.FlatStyle = FlatStyle.Flat
        BtnBrowseFile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowseFile.ForeColor = Color.White
        BtnBrowseFile.Image = My.Resources.Resources.Bullets_001_16_FFFFFFFF_
        BtnBrowseFile.Location = New Point(4, 3)
        BtnBrowseFile.Margin = New Padding(4, 3, 4, 3)
        BtnBrowseFile.Name = "BtnBrowseFile"
        BtnBrowseFile.Size = New Size(38, 33)
        BtnBrowseFile.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnBrowseFile.SLFTampilkanFocusBorder = False
        BtnBrowseFile.SLFValidasiSemuaInput = False
        BtnBrowseFile.SLFValidasiSemuaInputTag = Nothing
        BtnBrowseFile.TabIndex = 10
        BtnBrowseFile.UseVisualStyleBackColor = False
        ' 
        ' DgnFileList
        ' 
        DgnFileList.AllowUserToAddRows = False
        DgnFileList.AllowUserToDeleteRows = False
        DgnFileList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(192), CByte(225), CByte(137))
        DgnFileList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DgnFileList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgnFileList.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnFileList.BorderStyle = BorderStyle.None
        DgnFileList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnFileList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnFileList.ColumnHeadersHeight = 43
        DgnFileList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnFileList.Columns.AddRange(New DataGridViewColumn() {file_id, file_tag, file_datetime, file_content, file_status, file_uploader, file_delete})
        DgnFileList.EnableHeadersVisualStyles = False
        DgnFileList.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnFileList.Location = New Point(4, 44)
        DgnFileList.Margin = New Padding(4, 3, 4, 3)
        DgnFileList.MultiSelect = False
        DgnFileList.Name = "DgnFileList"
        DgnFileList.ReadOnly = True
        DgnFileList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnFileList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnFileList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgnFileList.Size = New Size(614, 150)
        DgnFileList.SLFGroupFirstRows = False
        DgnFileList.SLFGunakanNomorBaris = True
        DgnFileList.StandardTab = True
        DgnFileList.TabIndex = 14
        ' 
        ' file_id
        ' 
        file_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        file_id.DataPropertyName = "file_id"
        file_id.HeaderText = "ID"
        file_id.Name = "file_id"
        file_id.ReadOnly = True
        file_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' file_tag
        ' 
        file_tag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_tag.DataPropertyName = "file_tag"
        file_tag.HeaderText = "Tag"
        file_tag.Name = "file_tag"
        file_tag.ReadOnly = True
        file_tag.SortMode = DataGridViewColumnSortMode.Programmatic
        file_tag.Width = 50
        ' 
        ' file_datetime
        ' 
        file_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_datetime.DataPropertyName = "file_datetime"
        file_datetime.HeaderText = "Date Added"
        file_datetime.Name = "file_datetime"
        file_datetime.ReadOnly = True
        file_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
        file_datetime.Width = 89
        ' 
        ' file_content
        ' 
        file_content.DataPropertyName = "file_content"
        file_content.HeaderText = "File"
        file_content.Name = "file_content"
        file_content.ReadOnly = True
        file_content.Resizable = DataGridViewTriState.True
        file_content.SortMode = DataGridViewColumnSortMode.Programmatic
        file_content.Visible = False
        ' 
        ' file_status
        ' 
        file_status.DataPropertyName = "file_status"
        file_status.HeaderText = "Status"
        file_status.Name = "file_status"
        file_status.ReadOnly = True
        file_status.SortMode = DataGridViewColumnSortMode.NotSortable
        file_status.Visible = False
        ' 
        ' file_uploader
        ' 
        file_uploader.DataPropertyName = "file_uploader"
        file_uploader.HeaderText = "Uploader"
        file_uploader.Name = "file_uploader"
        file_uploader.ReadOnly = True
        file_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
        file_uploader.Visible = False
        ' 
        ' file_delete
        ' 
        file_delete.DataPropertyName = "file_delete"
        file_delete.HeaderText = ""
        file_delete.Name = "file_delete"
        file_delete.ReadOnly = True
        file_delete.Text = "🗑"
        file_delete.ToolTipText = "Delete"
        file_delete.UseColumnTextForButtonValue = True
        file_delete.Width = 19
        ' 
        ' CboFileTag
        ' 
        CboFileTag.DropDownStyle = ComboBoxStyle.DropDownList
        CboFileTag.FlatStyle = FlatStyle.Flat
        CboFileTag.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboFileTag.FormattingEnabled = True
        CboFileTag.Location = New Point(308, 3)
        CboFileTag.Margin = New Padding(4, 3, 4, 3)
        CboFileTag.Name = "CboFileTag"
        CboFileTag.Size = New Size(218, 29)
        CboFileTag.TabIndex = 15
        ' 
        ' TxtFilePath
        ' 
        TxtFilePath.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFilePath.Location = New Point(49, 3)
        TxtFilePath.Margin = New Padding(4, 3, 4, 3)
        TxtFilePath.MaxLength = 255
        TxtFilePath.Name = "TxtFilePath"
        TxtFilePath.ReadOnly = True
        TxtFilePath.Size = New Size(251, 29)
        TxtFilePath.SLFAutoTrim = False
        TxtFilePath.SLFHarusDiisi = False
        TxtFilePath.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtFilePath.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtFilePath.SLFHightlightSaatFokus = False
        TxtFilePath.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtFilePath.SLFIsBlank = True
        TxtFilePath.SLFIsSearchBox = False
        TxtFilePath.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtFilePath.SLFPilihSemuaSaatFokus = False
        TxtFilePath.SLFPwdLengthMin = 8
        TxtFilePath.SLFPwdStrengthCalculate = False
        TxtFilePath.SLFPwdStrengthScore = 0
        TxtFilePath.SLFPwdStrengthText = Nothing
        TxtFilePath.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtFilePath.SLFSearchBoxText = "Type then press Enter"
        TxtFilePath.SLFSQLText = ""
        TxtFilePath.SLFTanpaSpasi = False
        TxtFilePath.SLFValidasiField = Nothing
        TxtFilePath.TabIndex = 11
        TxtFilePath.Tag = "txt"
        ' 
        ' BtnAddFile
        ' 
        BtnAddFile.BackColor = Color.LimeGreen
        BtnAddFile.Cursor = Cursors.Hand
        BtnAddFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnAddFile.FlatAppearance.BorderSize = 2
        BtnAddFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnAddFile.FlatStyle = FlatStyle.Flat
        BtnAddFile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAddFile.ForeColor = Color.White
        BtnAddFile.Image = My.Resources.Resources.Plus_001_16_FFFFFFFF_
        BtnAddFile.Location = New Point(579, 3)
        BtnAddFile.Margin = New Padding(4, 3, 4, 3)
        BtnAddFile.Name = "BtnAddFile"
        BtnAddFile.Size = New Size(38, 33)
        BtnAddFile.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnAddFile.SLFTampilkanFocusBorder = False
        BtnAddFile.SLFValidasiSemuaInput = False
        BtnAddFile.SLFValidasiSemuaInputTag = Nothing
        BtnAddFile.TabIndex = 13
        BtnAddFile.UseVisualStyleBackColor = False
        ' 
        ' BtnPeekFile
        ' 
        BtnPeekFile.BackColor = Color.Crimson
        BtnPeekFile.Cursor = Cursors.Hand
        BtnPeekFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(160), CByte(20), CByte(0))
        BtnPeekFile.FlatAppearance.BorderSize = 2
        BtnPeekFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(40), CByte(80))
        BtnPeekFile.FlatStyle = FlatStyle.Flat
        BtnPeekFile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPeekFile.ForeColor = Color.White
        BtnPeekFile.Image = My.Resources.Resources.Peek_001_16_FFFFFFFF_
        BtnPeekFile.Location = New Point(533, 3)
        BtnPeekFile.Margin = New Padding(4, 3, 4, 3)
        BtnPeekFile.Name = "BtnPeekFile"
        BtnPeekFile.Size = New Size(38, 33)
        BtnPeekFile.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnPeekFile.SLFTampilkanFocusBorder = False
        BtnPeekFile.SLFValidasiSemuaInput = False
        BtnPeekFile.SLFValidasiSemuaInputTag = Nothing
        BtnPeekFile.TabIndex = 12
        BtnPeekFile.UseVisualStyleBackColor = False
        ' 
        ' ofdFile
        ' 
        ofdFile.FileName = "OpenFileDialog1"
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(14, 12)
        ULbl1.Margin = New Padding(5, 3, 5, 3)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(175, 33)
        ULbl1.SLFText = "Activity Start"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1003
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(14, 52)
        ULbl2.Margin = New Padding(5, 3, 5, 3)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "To"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1004
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(14, 92)
        ULbl3.Margin = New Padding(5, 3, 5, 3)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Area Affected"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1005
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(14, 133)
        ULbl4.Margin = New Padding(5, 3, 5, 3)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Activity Template"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1006
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(14, 173)
        ULbl5.Margin = New Padding(5, 3, 5, 3)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(175, 138)
        ULbl5.SLFText = "Description"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1007
        ' 
        ' ULbl6
        ' 
        ULbl6.BackColor = Color.Moccasin
        ULbl6.Location = New Point(14, 318)
        ULbl6.Margin = New Padding(5, 3, 5, 3)
        ULbl6.Name = "ULbl6"
        ULbl6.Size = New Size(175, 72)
        ULbl6.SLFText = "Feedback" & vbCrLf & "(Supv. Only)"
        ULbl6.SLFTextAdjuster = False
        ULbl6.SLFTextBorder = False
        ULbl6.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl6.TabIndex = 1008
        ' 
        ' ULbl7
        ' 
        ULbl7.BackColor = Color.Moccasin
        ULbl7.Location = New Point(14, 397)
        ULbl7.Margin = New Padding(5, 3, 5, 3)
        ULbl7.Name = "ULbl7"
        ULbl7.Size = New Size(175, 237)
        ULbl7.SLFText = "Attachment(s)"
        ULbl7.SLFTextAdjuster = False
        ULbl7.SLFTextBorder = False
        ULbl7.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl7.TabIndex = 1009
        ' 
        ' DAR_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(842, 828)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "DAR_Editor"
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlAttachment.ResumeLayout(False)
        tpPhotos.ResumeLayout(False)
        PnlPhoto.ResumeLayout(False)
        PnlPhoto.PerformLayout()
        CType(PctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnPictureList, ComponentModel.ISupportInitialize).EndInit()
        tpFiles.ResumeLayout(False)
        PnlFile.ResumeLayout(False)
        PnlFile.PerformLayout()
        CType(DgnFileList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnSave As btn
    Friend WithEvents BtnCancel As btn
    Friend WithEvents DtpStart As dtp
    Friend WithEvents CboTemplate As cbo
    Friend WithEvents TxtContent As txt
    Friend WithEvents CboArea As cbo
    Friend WithEvents MebStart As meb
    Friend WithEvents BtnGETContent As btn
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents MebEnd As meb
    Friend WithEvents DtpEnd As dtp
    Friend WithEvents TxtFeedback As txt
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents TbctlAttachment As tbctl
    Friend WithEvents tpPhotos As TabPage
    Friend WithEvents BtnPeekPhoto As btn
    Friend WithEvents BtnBrowsePhoto As btn
    Friend WithEvents BtnAddPhoto As btn
    Friend WithEvents TxtPhotoPath As txt
    Friend WithEvents DgnPictureList As dgn
    Friend WithEvents PctbxPhoto As pctbx
    Friend WithEvents tpFiles As TabPage
    Friend WithEvents BtnPeekFile As btn
    Friend WithEvents BtnBrowseFile As btn
    Friend WithEvents BtnAddFile As btn
    Friend WithEvents TxtFilePath As txt
    Friend WithEvents DgnFileList As dgn
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents CboFileTag As cbo
    Friend WithEvents PnlPhoto As pnl
    Friend WithEvents PnlFile As pnl
    Friend WithEvents photo_id As DataGridViewTextBoxColumn
    Friend WithEvents photo_datetime As DataGridViewTextBoxColumn
    Friend WithEvents photo_content As DataGridViewImageColumn
    Friend WithEvents photo_status As DataGridViewTextBoxColumn
    Friend WithEvents photo_uploader As DataGridViewTextBoxColumn
    Friend WithEvents photo_delete As DataGridViewButtonColumn
    Friend WithEvents file_id As DataGridViewTextBoxColumn
    Friend WithEvents file_tag As DataGridViewTextBoxColumn
    Friend WithEvents file_datetime As DataGridViewTextBoxColumn
    Friend WithEvents file_content As DataGridViewTextBoxColumn
    Friend WithEvents file_status As DataGridViewTextBoxColumn
    Friend WithEvents file_uploader As DataGridViewTextBoxColumn
    Friend WithEvents file_delete As DataGridViewButtonColumn
    Friend WithEvents ULbl7 As ULbl
    Friend WithEvents ULbl6 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
End Class
