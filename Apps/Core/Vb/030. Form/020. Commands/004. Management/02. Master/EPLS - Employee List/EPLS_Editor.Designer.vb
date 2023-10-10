<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EPLS_Editor
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(EPLS_Editor))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ChkAddNew = New chk(components)
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        pctbxPhoto = New pctbx(components)
        BtnBrowsePhoto = New btn(components)
        OfdPhoto = New OpenFileDialog()
        pcbxFrame = New pctbx(components)
        tpPermissions = New TabPage()
        GbxModulesRoles = New gbx(components)
        DgnModulesRoles = New dgn(components)
        modulegroup_name = New DataGridViewTextBoxColumn()
        module_code = New DataGridViewTextBoxColumn()
        useraccess_view = New DataGridViewCheckBoxColumn()
        useraccess_add = New DataGridViewCheckBoxColumn()
        useraccess_edit = New DataGridViewCheckBoxColumn()
        useraccess_delete = New DataGridViewCheckBoxColumn()
        useraccess_reports = New DataGridViewCheckBoxColumn()
        useraccess_id = New DataGridViewTextBoxColumn()
        module_id = New DataGridViewTextBoxColumn()
        GbxCredetials = New gbx(components)
        ULbl7 = New ULbl()
        TxtLogin = New txt(components)
        tpWorkIn = New TabPage()
        ULbl14 = New ULbl()
        ULbl13 = New ULbl()
        ULbl12 = New ULbl()
        ULbl11 = New ULbl()
        ULbl10 = New ULbl()
        ULbl9 = New ULbl()
        ULbl6 = New ULbl()
        ChkActiveEmployee = New chk(components)
        TxtEmployeeNickname = New txt(components)
        TxtContractType = New txt(components)
        TxtContractTypeID = New txt(components)
        TxtEmployeeNumber = New txt(components)
        TxtGrade = New txt(components)
        TxtPositionID = New txt(components)
        TxtPosition = New txt(components)
        TxtGradeID = New txt(components)
        BtnBrowsePosition = New btn(components)
        TxtDepartement = New txt(components)
        TxtCompany = New txt(components)
        tpGeneral = New TabPage()
        ULbl1 = New ULbl()
        ULbl5 = New ULbl()
        ULbl4 = New ULbl()
        ULbl3 = New ULbl()
        ULbl16 = New ULbl()
        ULbl2 = New ULbl()
        TxtAddress = New txt(components)
        TxtBirthPlace = New txt(components)
        DtpBirthDate = New dtp(components)
        TxtPersonalID = New txt(components)
        CboGender = New cbo(components)
        TxtFullName = New txt(components)
        TbctlEmployee = New tbctl(components)
        ULbl8 = New ULbl()
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(pctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(pcbxFrame, ComponentModel.ISupportInitialize).BeginInit()
        tpPermissions.SuspendLayout()
        GbxModulesRoles.SuspendLayout()
        CType(DgnModulesRoles, ComponentModel.ISupportInitialize).BeginInit()
        GbxCredetials.SuspendLayout()
        tpWorkIn.SuspendLayout()
        tpGeneral.SuspendLayout()
        TbctlEmployee.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Controls.Add(ChkAddNew)
        PnlBottomButton.Location = New Point(0, 438)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(827, 58)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(827, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ULbl8)
        SLFPanel.Controls.Add(TbctlEmployee)
        SLFPanel.Controls.Add(BtnBrowsePhoto)
        SLFPanel.Controls.Add(pctbxPhoto)
        SLFPanel.Controls.Add(pcbxFrame)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(827, 496)
        SLFPanel.Controls.SetChildIndex(pcbxFrame, 0)
        SLFPanel.Controls.SetChildIndex(pctbxPhoto, 0)
        SLFPanel.Controls.SetChildIndex(BtnBrowsePhoto, 0)
        SLFPanel.Controls.SetChildIndex(TbctlEmployee, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(ULbl8, 0)
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(419, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 803
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
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
        BtnSave.Location = New Point(572, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 801
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
        BtnCancel.Location = New Point(696, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 802
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' pctbxPhoto
        ' 
        pctbxPhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pctbxPhoto.BackColor = Color.White
        pctbxPhoto.ErrorImage = CType(resources.GetObject("pctbxPhoto.ErrorImage"), Image)
        pctbxPhoto.Image = CType(resources.GetObject("pctbxPhoto.Image"), Image)
        pctbxPhoto.InitialImage = CType(resources.GetObject("pctbxPhoto.InitialImage"), Image)
        pctbxPhoto.Location = New Point(653, 99)
        pctbxPhoto.Margin = New Padding(4, 3, 4, 3)
        pctbxPhoto.Name = "pctbxPhoto"
        pctbxPhoto.Padding = New Padding(18, 17, 18, 17)
        pctbxPhoto.Size = New Size(125, 145)
        pctbxPhoto.SizeMode = PictureBoxSizeMode.Zoom
        pctbxPhoto.SLFTampilkanBorder = False
        pctbxPhoto.SLFWarnaBorder = Color.Transparent
        pctbxPhoto.TabIndex = 1038
        pctbxPhoto.TabStop = False
        ' 
        ' BtnBrowsePhoto
        ' 
        BtnBrowsePhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnBrowsePhoto.BackColor = Color.RoyalBlue
        BtnBrowsePhoto.Cursor = Cursors.Hand
        BtnBrowsePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnBrowsePhoto.FlatAppearance.BorderSize = 2
        BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnBrowsePhoto.FlatStyle = FlatStyle.Flat
        BtnBrowsePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowsePhoto.ForeColor = Color.White
        BtnBrowsePhoto.Location = New Point(653, 257)
        BtnBrowsePhoto.Margin = New Padding(4, 3, 4, 3)
        BtnBrowsePhoto.Name = "BtnBrowsePhoto"
        BtnBrowsePhoto.Size = New Size(125, 48)
        BtnBrowsePhoto.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnBrowsePhoto.SLFTampilkanFocusBorder = False
        BtnBrowsePhoto.SLFValidasiSemuaInput = False
        BtnBrowsePhoto.SLFValidasiSemuaInputTag = Nothing
        BtnBrowsePhoto.TabIndex = 800
        BtnBrowsePhoto.Text = "Browse"
        BtnBrowsePhoto.UseVisualStyleBackColor = False
        ' 
        ' OfdPhoto
        ' 
        OfdPhoto.FileName = "OpenFileDialog1"
        ' 
        ' pcbxFrame
        ' 
        pcbxFrame.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pcbxFrame.BackColor = Color.White
        pcbxFrame.BorderStyle = BorderStyle.FixedSingle
        pcbxFrame.ErrorImage = CType(resources.GetObject("pcbxFrame.ErrorImage"), Image)
        pcbxFrame.InitialImage = CType(resources.GetObject("pcbxFrame.InitialImage"), Image)
        pcbxFrame.Location = New Point(647, 93)
        pcbxFrame.Margin = New Padding(4, 3, 4, 3)
        pcbxFrame.Name = "pcbxFrame"
        pcbxFrame.Size = New Size(136, 157)
        pcbxFrame.SizeMode = PictureBoxSizeMode.Zoom
        pcbxFrame.SLFTampilkanBorder = False
        pcbxFrame.SLFWarnaBorder = Color.DodgerBlue
        pcbxFrame.TabIndex = 1040
        pcbxFrame.TabStop = False
        ' 
        ' tpPermissions
        ' 
        tpPermissions.Controls.Add(GbxModulesRoles)
        tpPermissions.Controls.Add(GbxCredetials)
        tpPermissions.Location = New Point(4, 30)
        tpPermissions.Margin = New Padding(4, 3, 4, 3)
        tpPermissions.Name = "tpPermissions"
        tpPermissions.Padding = New Padding(4, 3, 4, 3)
        tpPermissions.Size = New Size(573, 382)
        tpPermissions.TabIndex = 1
        tpPermissions.Text = "PERMISSIONS"
        tpPermissions.UseVisualStyleBackColor = True
        ' 
        ' GbxModulesRoles
        ' 
        GbxModulesRoles.AutoSize = True
        GbxModulesRoles.Controls.Add(DgnModulesRoles)
        GbxModulesRoles.Dock = DockStyle.Fill
        GbxModulesRoles.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GbxModulesRoles.Location = New Point(4, 111)
        GbxModulesRoles.Margin = New Padding(4, 3, 4, 3)
        GbxModulesRoles.Name = "GbxModulesRoles"
        GbxModulesRoles.Padding = New Padding(4, 3, 4, 3)
        GbxModulesRoles.Size = New Size(565, 268)
        GbxModulesRoles.TabIndex = 0
        GbxModulesRoles.TabStop = False
        GbxModulesRoles.Text = "Modules or roles"
        ' 
        ' DgnModulesRoles
        ' 
        DgnModulesRoles.AllowUserToAddRows = False
        DgnModulesRoles.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(246), CByte(229), CByte(149))
        DgnModulesRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnModulesRoles.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnModulesRoles.BorderStyle = BorderStyle.None
        DgnModulesRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnModulesRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnModulesRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnModulesRoles.ColumnHeadersHeight = 43
        DgnModulesRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnModulesRoles.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports, useraccess_id, module_id})
        DgnModulesRoles.Dock = DockStyle.Fill
        DgnModulesRoles.EnableHeadersVisualStyles = False
        DgnModulesRoles.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnModulesRoles.Location = New Point(4, 25)
        DgnModulesRoles.Margin = New Padding(4, 3, 4, 3)
        DgnModulesRoles.Name = "DgnModulesRoles"
        DgnModulesRoles.ReadOnly = True
        DgnModulesRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnModulesRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnModulesRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnModulesRoles.Size = New Size(557, 240)
        DgnModulesRoles.SLFGroupFirstRows = True
        DgnModulesRoles.SLFGunakanNomorBaris = True
        DgnModulesRoles.StandardTab = True
        DgnModulesRoles.TabIndex = 0
        ' 
        ' modulegroup_name
        ' 
        modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        modulegroup_name.DataPropertyName = "modulegroup_name"
        modulegroup_name.HeaderText = "Module Group"
        modulegroup_name.Name = "modulegroup_name"
        modulegroup_name.ReadOnly = True
        ' 
        ' module_code
        ' 
        module_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        module_code.DataPropertyName = "module_code"
        module_code.HeaderText = "Module Code"
        module_code.Name = "module_code"
        module_code.ReadOnly = True
        module_code.Width = 95
        ' 
        ' useraccess_view
        ' 
        useraccess_view.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_view.DataPropertyName = "useraccess_view"
        useraccess_view.HeaderText = "View"
        useraccess_view.Name = "useraccess_view"
        useraccess_view.ReadOnly = True
        useraccess_view.Resizable = DataGridViewTriState.True
        useraccess_view.SortMode = DataGridViewColumnSortMode.Automatic
        useraccess_view.Width = 40
        ' 
        ' useraccess_add
        ' 
        useraccess_add.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_add.DataPropertyName = "useraccess_add"
        useraccess_add.HeaderText = "Add"
        useraccess_add.Name = "useraccess_add"
        useraccess_add.ReadOnly = True
        useraccess_add.Resizable = DataGridViewTriState.True
        useraccess_add.SortMode = DataGridViewColumnSortMode.Automatic
        useraccess_add.Width = 40
        ' 
        ' useraccess_edit
        ' 
        useraccess_edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_edit.DataPropertyName = "useraccess_edit"
        useraccess_edit.HeaderText = "Edit"
        useraccess_edit.Name = "useraccess_edit"
        useraccess_edit.ReadOnly = True
        useraccess_edit.Resizable = DataGridViewTriState.True
        useraccess_edit.SortMode = DataGridViewColumnSortMode.Automatic
        useraccess_edit.Width = 40
        ' 
        ' useraccess_delete
        ' 
        useraccess_delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_delete.DataPropertyName = "useraccess_delete"
        useraccess_delete.HeaderText = "Del"
        useraccess_delete.Name = "useraccess_delete"
        useraccess_delete.ReadOnly = True
        useraccess_delete.Resizable = DataGridViewTriState.True
        useraccess_delete.SortMode = DataGridViewColumnSortMode.Automatic
        useraccess_delete.Width = 40
        ' 
        ' useraccess_reports
        ' 
        useraccess_reports.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_reports.DataPropertyName = "useraccess_reports"
        useraccess_reports.HeaderText = "Rpt"
        useraccess_reports.Name = "useraccess_reports"
        useraccess_reports.ReadOnly = True
        useraccess_reports.Resizable = DataGridViewTriState.True
        useraccess_reports.SortMode = DataGridViewColumnSortMode.Automatic
        useraccess_reports.Width = 40
        ' 
        ' useraccess_id
        ' 
        useraccess_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        useraccess_id.DataPropertyName = "useraccess_id"
        useraccess_id.HeaderText = "UID"
        useraccess_id.Name = "useraccess_id"
        useraccess_id.ReadOnly = True
        useraccess_id.Visible = False
        ' 
        ' module_id
        ' 
        module_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        module_id.DataPropertyName = "module_id"
        module_id.HeaderText = "Module ID"
        module_id.Name = "module_id"
        module_id.ReadOnly = True
        module_id.Visible = False
        ' 
        ' GbxCredetials
        ' 
        GbxCredetials.Controls.Add(ULbl7)
        GbxCredetials.Controls.Add(TxtLogin)
        GbxCredetials.Dock = DockStyle.Top
        GbxCredetials.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GbxCredetials.Location = New Point(4, 3)
        GbxCredetials.Margin = New Padding(4, 3, 4, 3)
        GbxCredetials.Name = "GbxCredetials"
        GbxCredetials.Padding = New Padding(4, 3, 4, 3)
        GbxCredetials.Size = New Size(565, 108)
        GbxCredetials.TabIndex = 3
        GbxCredetials.TabStop = False
        GbxCredetials.Text = "Credentials"
        ' 
        ' ULbl7
        ' 
        ULbl7.BackColor = Color.Moccasin
        ULbl7.Location = New Point(8, 46)
        ULbl7.Margin = New Padding(5, 6, 5, 6)
        ULbl7.Name = "ULbl7"
        ULbl7.Size = New Size(175, 33)
        ULbl7.SLFText = "Login"
        ULbl7.SLFTextAdjuster = True
        ULbl7.SLFTextBorder = False
        ULbl7.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl7.TabIndex = 301
        ' 
        ' TxtLogin
        ' 
        TxtLogin.BackColor = Color.White
        TxtLogin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtLogin.Location = New Point(191, 46)
        TxtLogin.Margin = New Padding(4, 3, 4, 3)
        TxtLogin.MaxLength = 255
        TxtLogin.Name = "TxtLogin"
        TxtLogin.ReadOnly = True
        TxtLogin.Size = New Size(240, 29)
        TxtLogin.SLFAutoTrim = False
        TxtLogin.SLFHarusDiisi = False
        TxtLogin.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtLogin.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtLogin.SLFHightlightSaatFokus = False
        TxtLogin.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtLogin.SLFIsBlank = False
        TxtLogin.SLFIsSearchBox = False
        TxtLogin.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtLogin.SLFPilihSemuaSaatFokus = False
        TxtLogin.SLFPwdLengthMin = 8
        TxtLogin.SLFPwdStrengthCalculate = False
        TxtLogin.SLFPwdStrengthScore = 0
        TxtLogin.SLFPwdStrengthText = Nothing
        TxtLogin.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtLogin.SLFSearchBoxText = "Type then press Enter"
        TxtLogin.SLFSQLText = ""
        TxtLogin.SLFTanpaSpasi = False
        TxtLogin.SLFValidasiField = Nothing
        TxtLogin.TabIndex = 300
        TxtLogin.Tag = "txt"
        TxtLogin.TextAlign = HorizontalAlignment.Center
        ' 
        ' tpWorkIn
        ' 
        tpWorkIn.Controls.Add(ULbl14)
        tpWorkIn.Controls.Add(ULbl13)
        tpWorkIn.Controls.Add(ULbl12)
        tpWorkIn.Controls.Add(ULbl11)
        tpWorkIn.Controls.Add(ULbl10)
        tpWorkIn.Controls.Add(ULbl9)
        tpWorkIn.Controls.Add(ULbl6)
        tpWorkIn.Controls.Add(ChkActiveEmployee)
        tpWorkIn.Controls.Add(TxtEmployeeNickname)
        tpWorkIn.Controls.Add(TxtContractType)
        tpWorkIn.Controls.Add(TxtContractTypeID)
        tpWorkIn.Controls.Add(TxtEmployeeNumber)
        tpWorkIn.Controls.Add(TxtGrade)
        tpWorkIn.Controls.Add(TxtPositionID)
        tpWorkIn.Controls.Add(TxtPosition)
        tpWorkIn.Controls.Add(TxtGradeID)
        tpWorkIn.Controls.Add(BtnBrowsePosition)
        tpWorkIn.Controls.Add(TxtDepartement)
        tpWorkIn.Controls.Add(TxtCompany)
        tpWorkIn.Location = New Point(4, 30)
        tpWorkIn.Margin = New Padding(4, 3, 4, 3)
        tpWorkIn.Name = "tpWorkIn"
        tpWorkIn.Size = New Size(573, 382)
        tpWorkIn.TabIndex = 2
        tpWorkIn.Text = "WORK IN"
        tpWorkIn.UseVisualStyleBackColor = True
        ' 
        ' ULbl14
        ' 
        ULbl14.BackColor = Color.Moccasin
        ULbl14.Location = New Point(8, 252)
        ULbl14.Margin = New Padding(5, 6, 5, 6)
        ULbl14.Name = "ULbl14"
        ULbl14.Size = New Size(175, 33)
        ULbl14.SLFText = "Initial"
        ULbl14.SLFTextAdjuster = True
        ULbl14.SLFTextBorder = False
        ULbl14.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl14.TabIndex = 1061
        ' 
        ' ULbl13
        ' 
        ULbl13.BackColor = Color.Moccasin
        ULbl13.Location = New Point(8, 211)
        ULbl13.Margin = New Padding(5, 6, 5, 6)
        ULbl13.Name = "ULbl13"
        ULbl13.Size = New Size(175, 33)
        ULbl13.SLFText = "Contract Type"
        ULbl13.SLFTextAdjuster = True
        ULbl13.SLFTextBorder = False
        ULbl13.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl13.TabIndex = 1060
        ' 
        ' ULbl12
        ' 
        ULbl12.BackColor = Color.Moccasin
        ULbl12.Location = New Point(8, 171)
        ULbl12.Margin = New Padding(5, 6, 5, 6)
        ULbl12.Name = "ULbl12"
        ULbl12.Size = New Size(175, 33)
        ULbl12.SLFText = "Emp. Number"
        ULbl12.SLFTextAdjuster = True
        ULbl12.SLFTextBorder = False
        ULbl12.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl12.TabIndex = 1059
        ' 
        ' ULbl11
        ' 
        ULbl11.BackColor = Color.Moccasin
        ULbl11.Location = New Point(8, 130)
        ULbl11.Margin = New Padding(5, 6, 5, 6)
        ULbl11.Name = "ULbl11"
        ULbl11.Size = New Size(175, 33)
        ULbl11.SLFText = "Grade"
        ULbl11.SLFTextAdjuster = True
        ULbl11.SLFTextBorder = False
        ULbl11.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl11.TabIndex = 1058
        ' 
        ' ULbl10
        ' 
        ULbl10.BackColor = Color.Moccasin
        ULbl10.Location = New Point(8, 90)
        ULbl10.Margin = New Padding(5, 6, 5, 6)
        ULbl10.Name = "ULbl10"
        ULbl10.Size = New Size(175, 33)
        ULbl10.SLFText = "Position"
        ULbl10.SLFTextAdjuster = True
        ULbl10.SLFTextBorder = False
        ULbl10.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl10.TabIndex = 1057
        ' 
        ' ULbl9
        ' 
        ULbl9.BackColor = Color.Moccasin
        ULbl9.Location = New Point(8, 50)
        ULbl9.Margin = New Padding(5, 6, 5, 6)
        ULbl9.Name = "ULbl9"
        ULbl9.Size = New Size(175, 33)
        ULbl9.SLFText = "Department"
        ULbl9.SLFTextAdjuster = True
        ULbl9.SLFTextBorder = False
        ULbl9.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl9.TabIndex = 1056
        ' 
        ' ULbl6
        ' 
        ULbl6.BackColor = Color.Moccasin
        ULbl6.Location = New Point(8, 9)
        ULbl6.Margin = New Padding(5, 6, 5, 6)
        ULbl6.Name = "ULbl6"
        ULbl6.Size = New Size(175, 33)
        ULbl6.SLFText = "Company"
        ULbl6.SLFTextAdjuster = True
        ULbl6.SLFTextBorder = False
        ULbl6.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl6.TabIndex = 1055
        ' 
        ' ChkActiveEmployee
        ' 
        ChkActiveEmployee.AutoSize = True
        ChkActiveEmployee.BackColor = Color.Transparent
        ChkActiveEmployee.FlatStyle = FlatStyle.Flat
        ChkActiveEmployee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkActiveEmployee.Location = New Point(191, 292)
        ChkActiveEmployee.Margin = New Padding(4, 3, 4, 3)
        ChkActiveEmployee.Name = "ChkActiveEmployee"
        ChkActiveEmployee.Size = New Size(140, 25)
        ChkActiveEmployee.TabIndex = 211
        ChkActiveEmployee.Text = "Active employee"
        ChkActiveEmployee.UseVisualStyleBackColor = False
        ' 
        ' TxtEmployeeNickname
        ' 
        TxtEmployeeNickname.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEmployeeNickname.Location = New Point(191, 252)
        TxtEmployeeNickname.Margin = New Padding(4, 3, 4, 3)
        TxtEmployeeNickname.MaxLength = 255
        TxtEmployeeNickname.Name = "TxtEmployeeNickname"
        TxtEmployeeNickname.Size = New Size(72, 29)
        TxtEmployeeNickname.SLFAutoTrim = True
        TxtEmployeeNickname.SLFHarusDiisi = False
        TxtEmployeeNickname.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtEmployeeNickname.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtEmployeeNickname.SLFHightlightSaatFokus = False
        TxtEmployeeNickname.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtEmployeeNickname.SLFIsBlank = True
        TxtEmployeeNickname.SLFIsSearchBox = False
        TxtEmployeeNickname.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtEmployeeNickname.SLFPilihSemuaSaatFokus = False
        TxtEmployeeNickname.SLFPwdLengthMin = 8
        TxtEmployeeNickname.SLFPwdStrengthCalculate = False
        TxtEmployeeNickname.SLFPwdStrengthScore = 0
        TxtEmployeeNickname.SLFPwdStrengthText = Nothing
        TxtEmployeeNickname.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtEmployeeNickname.SLFSearchBoxText = "Type then press Enter"
        TxtEmployeeNickname.SLFSQLText = ""
        TxtEmployeeNickname.SLFTanpaSpasi = False
        TxtEmployeeNickname.SLFValidasiField = Nothing
        TxtEmployeeNickname.TabIndex = 210
        TxtEmployeeNickname.Tag = "txt"
        TxtEmployeeNickname.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtContractType
        ' 
        TxtContractType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContractType.Location = New Point(271, 211)
        TxtContractType.Margin = New Padding(4, 3, 4, 3)
        TxtContractType.MaxLength = 255
        TxtContractType.Name = "TxtContractType"
        TxtContractType.ReadOnly = True
        TxtContractType.Size = New Size(240, 29)
        TxtContractType.SLFAutoTrim = False
        TxtContractType.SLFHarusDiisi = False
        TxtContractType.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtContractType.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtContractType.SLFHightlightSaatFokus = False
        TxtContractType.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtContractType.SLFIsBlank = True
        TxtContractType.SLFIsSearchBox = False
        TxtContractType.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtContractType.SLFPilihSemuaSaatFokus = False
        TxtContractType.SLFPwdLengthMin = 8
        TxtContractType.SLFPwdStrengthCalculate = False
        TxtContractType.SLFPwdStrengthScore = 0
        TxtContractType.SLFPwdStrengthText = Nothing
        TxtContractType.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtContractType.SLFSearchBoxText = "Type then press Enter"
        TxtContractType.SLFSQLText = ""
        TxtContractType.SLFTanpaSpasi = False
        TxtContractType.SLFValidasiField = Nothing
        TxtContractType.TabIndex = 209
        TxtContractType.TabStop = False
        TxtContractType.Tag = "txt"
        ' 
        ' TxtContractTypeID
        ' 
        TxtContractTypeID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContractTypeID.Location = New Point(191, 211)
        TxtContractTypeID.Margin = New Padding(4, 3, 4, 3)
        TxtContractTypeID.MaxLength = 255
        TxtContractTypeID.Name = "TxtContractTypeID"
        TxtContractTypeID.ReadOnly = True
        TxtContractTypeID.Size = New Size(72, 29)
        TxtContractTypeID.SLFAutoTrim = False
        TxtContractTypeID.SLFHarusDiisi = False
        TxtContractTypeID.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtContractTypeID.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtContractTypeID.SLFHightlightSaatFokus = False
        TxtContractTypeID.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtContractTypeID.SLFIsBlank = True
        TxtContractTypeID.SLFIsSearchBox = False
        TxtContractTypeID.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtContractTypeID.SLFPilihSemuaSaatFokus = False
        TxtContractTypeID.SLFPwdLengthMin = 8
        TxtContractTypeID.SLFPwdStrengthCalculate = False
        TxtContractTypeID.SLFPwdStrengthScore = 0
        TxtContractTypeID.SLFPwdStrengthText = Nothing
        TxtContractTypeID.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtContractTypeID.SLFSearchBoxText = "Type then press Enter"
        TxtContractTypeID.SLFSQLText = ""
        TxtContractTypeID.SLFTanpaSpasi = False
        TxtContractTypeID.SLFValidasiField = Nothing
        TxtContractTypeID.TabIndex = 208
        TxtContractTypeID.TabStop = False
        TxtContractTypeID.Tag = "txt"
        TxtContractTypeID.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtEmployeeNumber
        ' 
        TxtEmployeeNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEmployeeNumber.Location = New Point(191, 171)
        TxtEmployeeNumber.Margin = New Padding(4, 3, 4, 3)
        TxtEmployeeNumber.MaxLength = 255
        TxtEmployeeNumber.Name = "TxtEmployeeNumber"
        TxtEmployeeNumber.Size = New Size(198, 29)
        TxtEmployeeNumber.SLFAutoTrim = True
        TxtEmployeeNumber.SLFHarusDiisi = True
        TxtEmployeeNumber.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtEmployeeNumber.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtEmployeeNumber.SLFHightlightSaatFokus = True
        TxtEmployeeNumber.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtEmployeeNumber.SLFIsBlank = True
        TxtEmployeeNumber.SLFIsSearchBox = False
        TxtEmployeeNumber.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtEmployeeNumber.SLFPilihSemuaSaatFokus = False
        TxtEmployeeNumber.SLFPwdLengthMin = 8
        TxtEmployeeNumber.SLFPwdStrengthCalculate = False
        TxtEmployeeNumber.SLFPwdStrengthScore = 0
        TxtEmployeeNumber.SLFPwdStrengthText = Nothing
        TxtEmployeeNumber.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtEmployeeNumber.SLFSearchBoxText = "Type then press Enter"
        TxtEmployeeNumber.SLFSQLText = ""
        TxtEmployeeNumber.SLFTanpaSpasi = False
        TxtEmployeeNumber.SLFValidasiField = Nothing
        TxtEmployeeNumber.TabIndex = 207
        TxtEmployeeNumber.Tag = "txt"
        TxtEmployeeNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtGrade
        ' 
        TxtGrade.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtGrade.Location = New Point(271, 130)
        TxtGrade.Margin = New Padding(4, 3, 4, 3)
        TxtGrade.MaxLength = 255
        TxtGrade.Name = "TxtGrade"
        TxtGrade.ReadOnly = True
        TxtGrade.Size = New Size(240, 29)
        TxtGrade.SLFAutoTrim = False
        TxtGrade.SLFHarusDiisi = False
        TxtGrade.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtGrade.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtGrade.SLFHightlightSaatFokus = False
        TxtGrade.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtGrade.SLFIsBlank = True
        TxtGrade.SLFIsSearchBox = False
        TxtGrade.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtGrade.SLFPilihSemuaSaatFokus = False
        TxtGrade.SLFPwdLengthMin = 8
        TxtGrade.SLFPwdStrengthCalculate = False
        TxtGrade.SLFPwdStrengthScore = 0
        TxtGrade.SLFPwdStrengthText = Nothing
        TxtGrade.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtGrade.SLFSearchBoxText = "Type then press Enter"
        TxtGrade.SLFSQLText = ""
        TxtGrade.SLFTanpaSpasi = False
        TxtGrade.SLFValidasiField = Nothing
        TxtGrade.TabIndex = 206
        TxtGrade.TabStop = False
        TxtGrade.Tag = "txt"
        ' 
        ' TxtPositionID
        ' 
        TxtPositionID.BackColor = Color.LightPink
        TxtPositionID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPositionID.Location = New Point(191, 90)
        TxtPositionID.Margin = New Padding(4, 3, 4, 3)
        TxtPositionID.MaxLength = 255
        TxtPositionID.Name = "TxtPositionID"
        TxtPositionID.Size = New Size(72, 29)
        TxtPositionID.SLFAutoTrim = True
        TxtPositionID.SLFHarusDiisi = True
        TxtPositionID.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPositionID.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPositionID.SLFHightlightSaatFokus = True
        TxtPositionID.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPositionID.SLFIsBlank = True
        TxtPositionID.SLFIsSearchBox = False
        TxtPositionID.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPositionID.SLFPilihSemuaSaatFokus = True
        TxtPositionID.SLFPwdLengthMin = 8
        TxtPositionID.SLFPwdStrengthCalculate = False
        TxtPositionID.SLFPwdStrengthScore = 0
        TxtPositionID.SLFPwdStrengthText = Nothing
        TxtPositionID.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPositionID.SLFSearchBoxText = "Type then press Enter"
        TxtPositionID.SLFSQLText = ""
        TxtPositionID.SLFTanpaSpasi = True
        TxtPositionID.SLFValidasiField = Nothing
        TxtPositionID.TabIndex = 202
        TxtPositionID.Tag = "txt"
        TxtPositionID.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtPosition
        ' 
        TxtPosition.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPosition.Location = New Point(271, 90)
        TxtPosition.Margin = New Padding(4, 3, 4, 3)
        TxtPosition.MaxLength = 255
        TxtPosition.Name = "TxtPosition"
        TxtPosition.ReadOnly = True
        TxtPosition.Size = New Size(240, 29)
        TxtPosition.SLFAutoTrim = False
        TxtPosition.SLFHarusDiisi = False
        TxtPosition.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPosition.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPosition.SLFHightlightSaatFokus = False
        TxtPosition.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPosition.SLFIsBlank = True
        TxtPosition.SLFIsSearchBox = False
        TxtPosition.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPosition.SLFPilihSemuaSaatFokus = False
        TxtPosition.SLFPwdLengthMin = 8
        TxtPosition.SLFPwdStrengthCalculate = False
        TxtPosition.SLFPwdStrengthScore = 0
        TxtPosition.SLFPwdStrengthText = Nothing
        TxtPosition.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPosition.SLFSearchBoxText = "Type then press Enter"
        TxtPosition.SLFSQLText = ""
        TxtPosition.SLFTanpaSpasi = False
        TxtPosition.SLFValidasiField = Nothing
        TxtPosition.TabIndex = 203
        TxtPosition.TabStop = False
        TxtPosition.Tag = "txt"
        ' 
        ' TxtGradeID
        ' 
        TxtGradeID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtGradeID.Location = New Point(191, 130)
        TxtGradeID.Margin = New Padding(4, 3, 4, 3)
        TxtGradeID.MaxLength = 255
        TxtGradeID.Name = "TxtGradeID"
        TxtGradeID.ReadOnly = True
        TxtGradeID.Size = New Size(72, 29)
        TxtGradeID.SLFAutoTrim = False
        TxtGradeID.SLFHarusDiisi = False
        TxtGradeID.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtGradeID.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtGradeID.SLFHightlightSaatFokus = False
        TxtGradeID.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtGradeID.SLFIsBlank = True
        TxtGradeID.SLFIsSearchBox = False
        TxtGradeID.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtGradeID.SLFPilihSemuaSaatFokus = False
        TxtGradeID.SLFPwdLengthMin = 8
        TxtGradeID.SLFPwdStrengthCalculate = False
        TxtGradeID.SLFPwdStrengthScore = 0
        TxtGradeID.SLFPwdStrengthText = Nothing
        TxtGradeID.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtGradeID.SLFSearchBoxText = "Type then press Enter"
        TxtGradeID.SLFSQLText = ""
        TxtGradeID.SLFTanpaSpasi = False
        TxtGradeID.SLFValidasiField = Nothing
        TxtGradeID.TabIndex = 205
        TxtGradeID.TabStop = False
        TxtGradeID.Tag = "txt"
        TxtGradeID.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnBrowsePosition
        ' 
        BtnBrowsePosition.BackColor = Color.RoyalBlue
        BtnBrowsePosition.Cursor = Cursors.Hand
        BtnBrowsePosition.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnBrowsePosition.FlatAppearance.BorderSize = 2
        BtnBrowsePosition.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnBrowsePosition.FlatStyle = FlatStyle.Flat
        BtnBrowsePosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowsePosition.ForeColor = Color.White
        BtnBrowsePosition.Location = New Point(518, 90)
        BtnBrowsePosition.Margin = New Padding(4, 3, 4, 3)
        BtnBrowsePosition.Name = "BtnBrowsePosition"
        BtnBrowsePosition.Size = New Size(46, 33)
        BtnBrowsePosition.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnBrowsePosition.SLFTampilkanFocusBorder = False
        BtnBrowsePosition.SLFValidasiSemuaInput = False
        BtnBrowsePosition.SLFValidasiSemuaInputTag = Nothing
        BtnBrowsePosition.TabIndex = 204
        BtnBrowsePosition.Text = "..."
        BtnBrowsePosition.UseVisualStyleBackColor = False
        ' 
        ' TxtDepartement
        ' 
        TxtDepartement.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDepartement.Location = New Point(191, 50)
        TxtDepartement.Margin = New Padding(4, 3, 4, 3)
        TxtDepartement.MaxLength = 255
        TxtDepartement.Name = "TxtDepartement"
        TxtDepartement.ReadOnly = True
        TxtDepartement.Size = New Size(319, 29)
        TxtDepartement.SLFAutoTrim = False
        TxtDepartement.SLFHarusDiisi = False
        TxtDepartement.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtDepartement.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtDepartement.SLFHightlightSaatFokus = False
        TxtDepartement.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtDepartement.SLFIsBlank = True
        TxtDepartement.SLFIsSearchBox = False
        TxtDepartement.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtDepartement.SLFPilihSemuaSaatFokus = False
        TxtDepartement.SLFPwdLengthMin = 8
        TxtDepartement.SLFPwdStrengthCalculate = False
        TxtDepartement.SLFPwdStrengthScore = 0
        TxtDepartement.SLFPwdStrengthText = Nothing
        TxtDepartement.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtDepartement.SLFSearchBoxText = "Type then press Enter"
        TxtDepartement.SLFSQLText = ""
        TxtDepartement.SLFTanpaSpasi = False
        TxtDepartement.SLFValidasiField = Nothing
        TxtDepartement.TabIndex = 201
        TxtDepartement.TabStop = False
        TxtDepartement.Tag = "txt"
        ' 
        ' TxtCompany
        ' 
        TxtCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCompany.Location = New Point(191, 9)
        TxtCompany.Margin = New Padding(4, 3, 4, 3)
        TxtCompany.MaxLength = 255
        TxtCompany.Name = "TxtCompany"
        TxtCompany.ReadOnly = True
        TxtCompany.Size = New Size(319, 29)
        TxtCompany.SLFAutoTrim = False
        TxtCompany.SLFHarusDiisi = False
        TxtCompany.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtCompany.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtCompany.SLFHightlightSaatFokus = False
        TxtCompany.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtCompany.SLFIsBlank = True
        TxtCompany.SLFIsSearchBox = False
        TxtCompany.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtCompany.SLFPilihSemuaSaatFokus = False
        TxtCompany.SLFPwdLengthMin = 8
        TxtCompany.SLFPwdStrengthCalculate = False
        TxtCompany.SLFPwdStrengthScore = 0
        TxtCompany.SLFPwdStrengthText = Nothing
        TxtCompany.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtCompany.SLFSearchBoxText = "Type then press Enter"
        TxtCompany.SLFSQLText = ""
        TxtCompany.SLFTanpaSpasi = False
        TxtCompany.SLFValidasiField = Nothing
        TxtCompany.TabIndex = 200
        TxtCompany.TabStop = False
        TxtCompany.Tag = "txt"
        ' 
        ' tpGeneral
        ' 
        tpGeneral.AutoScroll = True
        tpGeneral.Controls.Add(ULbl1)
        tpGeneral.Controls.Add(ULbl5)
        tpGeneral.Controls.Add(ULbl4)
        tpGeneral.Controls.Add(ULbl3)
        tpGeneral.Controls.Add(ULbl16)
        tpGeneral.Controls.Add(ULbl2)
        tpGeneral.Controls.Add(TxtAddress)
        tpGeneral.Controls.Add(TxtBirthPlace)
        tpGeneral.Controls.Add(DtpBirthDate)
        tpGeneral.Controls.Add(TxtPersonalID)
        tpGeneral.Controls.Add(CboGender)
        tpGeneral.Controls.Add(TxtFullName)
        tpGeneral.Location = New Point(4, 30)
        tpGeneral.Margin = New Padding(4, 3, 4, 3)
        tpGeneral.Name = "tpGeneral"
        tpGeneral.Padding = New Padding(4, 3, 4, 3)
        tpGeneral.Size = New Size(573, 382)
        tpGeneral.TabIndex = 0
        tpGeneral.Text = "PERSONAL"
        tpGeneral.UseVisualStyleBackColor = True
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(8, 9)
        ULbl1.Margin = New Padding(5, 6, 5, 6)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(175, 33)
        ULbl1.SLFText = "Personal ID"
        ULbl1.SLFTextAdjuster = True
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1056
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(8, 211)
        ULbl5.Margin = New Padding(5, 6, 5, 6)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(175, 155)
        ULbl5.SLFText = "Address"
        ULbl5.SLFTextAdjuster = True
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1055
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(8, 171)
        ULbl4.Margin = New Padding(5, 6, 5, 6)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Gender"
        ULbl4.SLFTextAdjuster = True
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1054
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(8, 130)
        ULbl3.Margin = New Padding(5, 6, 5, 6)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Birth Place"
        ULbl3.SLFTextAdjuster = True
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1053
        ' 
        ' ULbl16
        ' 
        ULbl16.BackColor = Color.Moccasin
        ULbl16.Location = New Point(8, 90)
        ULbl16.Margin = New Padding(5, 6, 5, 6)
        ULbl16.Name = "ULbl16"
        ULbl16.Size = New Size(175, 33)
        ULbl16.SLFText = "Date of Birth"
        ULbl16.SLFTextAdjuster = True
        ULbl16.SLFTextBorder = False
        ULbl16.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl16.TabIndex = 1052
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(8, 50)
        ULbl2.Margin = New Padding(5, 6, 5, 6)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Full Name"
        ULbl2.SLFTextAdjuster = True
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1051
        ' 
        ' TxtAddress
        ' 
        TxtAddress.BackColor = Color.White
        TxtAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAddress.Location = New Point(191, 211)
        TxtAddress.Margin = New Padding(4, 3, 4, 3)
        TxtAddress.MaxLength = 1024
        TxtAddress.Multiline = True
        TxtAddress.Name = "TxtAddress"
        TxtAddress.ScrollBars = ScrollBars.Both
        TxtAddress.Size = New Size(374, 154)
        TxtAddress.SLFAutoTrim = True
        TxtAddress.SLFHarusDiisi = False
        TxtAddress.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtAddress.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtAddress.SLFHightlightSaatFokus = False
        TxtAddress.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtAddress.SLFIsBlank = False
        TxtAddress.SLFIsSearchBox = False
        TxtAddress.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtAddress.SLFPilihSemuaSaatFokus = False
        TxtAddress.SLFPwdLengthMin = 8
        TxtAddress.SLFPwdStrengthCalculate = False
        TxtAddress.SLFPwdStrengthScore = 0
        TxtAddress.SLFPwdStrengthText = Nothing
        TxtAddress.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtAddress.SLFSearchBoxText = "Type then press Enter"
        TxtAddress.SLFSQLText = ""
        TxtAddress.SLFTanpaSpasi = False
        TxtAddress.SLFValidasiField = Nothing
        TxtAddress.TabIndex = 105
        TxtAddress.Tag = "txt"
        ' 
        ' TxtBirthPlace
        ' 
        TxtBirthPlace.BackColor = Color.White
        TxtBirthPlace.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtBirthPlace.Location = New Point(191, 130)
        TxtBirthPlace.Margin = New Padding(4, 3, 4, 3)
        TxtBirthPlace.MaxLength = 255
        TxtBirthPlace.Name = "TxtBirthPlace"
        TxtBirthPlace.Size = New Size(240, 29)
        TxtBirthPlace.SLFAutoTrim = True
        TxtBirthPlace.SLFHarusDiisi = False
        TxtBirthPlace.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtBirthPlace.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtBirthPlace.SLFHightlightSaatFokus = False
        TxtBirthPlace.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtBirthPlace.SLFIsBlank = False
        TxtBirthPlace.SLFIsSearchBox = False
        TxtBirthPlace.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtBirthPlace.SLFPilihSemuaSaatFokus = False
        TxtBirthPlace.SLFPwdLengthMin = 8
        TxtBirthPlace.SLFPwdStrengthCalculate = False
        TxtBirthPlace.SLFPwdStrengthScore = 0
        TxtBirthPlace.SLFPwdStrengthText = Nothing
        TxtBirthPlace.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtBirthPlace.SLFSearchBoxText = "Type then press Enter"
        TxtBirthPlace.SLFSQLText = ""
        TxtBirthPlace.SLFTanpaSpasi = False
        TxtBirthPlace.SLFValidasiField = Nothing
        TxtBirthPlace.TabIndex = 103
        TxtBirthPlace.Tag = "txt"
        ' 
        ' DtpBirthDate
        ' 
        DtpBirthDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpBirthDate.Location = New Point(191, 90)
        DtpBirthDate.Margin = New Padding(4, 3, 4, 3)
        DtpBirthDate.MaxDate = New Date(2029, 4, 3, 0, 0, 0, 0)
        DtpBirthDate.MinDate = New Date(1919, 4, 3, 0, 0, 0, 0)
        DtpBirthDate.Name = "DtpBirthDate"
        DtpBirthDate.Size = New Size(276, 29)
        DtpBirthDate.SLFResetOnDisabled = False
        DtpBirthDate.TabIndex = 102
        ' 
        ' TxtPersonalID
        ' 
        TxtPersonalID.BackColor = Color.LightPink
        TxtPersonalID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPersonalID.Location = New Point(191, 9)
        TxtPersonalID.Margin = New Padding(4, 3, 4, 3)
        TxtPersonalID.MaxLength = 16
        TxtPersonalID.Name = "TxtPersonalID"
        TxtPersonalID.Size = New Size(240, 29)
        TxtPersonalID.SLFAutoTrim = True
        TxtPersonalID.SLFHarusDiisi = True
        TxtPersonalID.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPersonalID.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPersonalID.SLFHightlightSaatFokus = True
        TxtPersonalID.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPersonalID.SLFIsBlank = True
        TxtPersonalID.SLFIsSearchBox = False
        TxtPersonalID.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPersonalID.SLFPilihSemuaSaatFokus = False
        TxtPersonalID.SLFPwdLengthMin = 8
        TxtPersonalID.SLFPwdStrengthCalculate = False
        TxtPersonalID.SLFPwdStrengthScore = 0
        TxtPersonalID.SLFPwdStrengthText = Nothing
        TxtPersonalID.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPersonalID.SLFSearchBoxText = "Type then press Enter"
        TxtPersonalID.SLFSQLText = ""
        TxtPersonalID.SLFTanpaSpasi = False
        TxtPersonalID.SLFValidasiField = Nothing
        TxtPersonalID.TabIndex = 100
        TxtPersonalID.Tag = "txt"
        ' 
        ' CboGender
        ' 
        CboGender.DropDownStyle = ComboBoxStyle.DropDownList
        CboGender.FlatStyle = FlatStyle.Flat
        CboGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboGender.FormattingEnabled = True
        CboGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        CboGender.Location = New Point(191, 171)
        CboGender.Margin = New Padding(4, 3, 4, 3)
        CboGender.Name = "CboGender"
        CboGender.Size = New Size(159, 29)
        CboGender.TabIndex = 104
        ' 
        ' TxtFullName
        ' 
        TxtFullName.BackColor = Color.LightPink
        TxtFullName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFullName.Location = New Point(191, 50)
        TxtFullName.Margin = New Padding(4, 3, 4, 3)
        TxtFullName.MaxLength = 255
        TxtFullName.Name = "TxtFullName"
        TxtFullName.Size = New Size(319, 29)
        TxtFullName.SLFAutoTrim = True
        TxtFullName.SLFHarusDiisi = True
        TxtFullName.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtFullName.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtFullName.SLFHightlightSaatFokus = True
        TxtFullName.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtFullName.SLFIsBlank = False
        TxtFullName.SLFIsSearchBox = False
        TxtFullName.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtFullName.SLFPilihSemuaSaatFokus = False
        TxtFullName.SLFPwdLengthMin = 8
        TxtFullName.SLFPwdStrengthCalculate = False
        TxtFullName.SLFPwdStrengthScore = 0
        TxtFullName.SLFPwdStrengthText = Nothing
        TxtFullName.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtFullName.SLFSearchBoxText = "Type then press Enter"
        TxtFullName.SLFSQLText = ""
        TxtFullName.SLFTanpaSpasi = False
        TxtFullName.SLFValidasiField = Nothing
        TxtFullName.TabIndex = 101
        TxtFullName.Tag = "txt"
        ' 
        ' TbctlEmployee
        ' 
        TbctlEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TbctlEmployee.Controls.Add(tpGeneral)
        TbctlEmployee.Controls.Add(tpWorkIn)
        TbctlEmployee.Controls.Add(tpPermissions)
        TbctlEmployee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlEmployee.Location = New Point(14, 15)
        TbctlEmployee.Margin = New Padding(4, 3, 4, 3)
        TbctlEmployee.Name = "TbctlEmployee"
        TbctlEmployee.SelectedIndex = 0
        TbctlEmployee.Size = New Size(581, 416)
        TbctlEmployee.TabIndex = 1039
        ' 
        ' ULbl8
        ' 
        ULbl8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ULbl8.BackColor = Color.Moccasin
        ULbl8.Location = New Point(621, 50)
        ULbl8.Margin = New Padding(5, 3, 5, 3)
        ULbl8.Name = "ULbl8"
        ULbl8.Size = New Size(175, 33)
        ULbl8.SLFText = "Photo"
        ULbl8.SLFTextAdjuster = False
        ULbl8.SLFTextBorder = False
        ULbl8.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl8.TabIndex = 1041
        ' 
        ' EPLS_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(827, 579)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "EPLS_Editor"
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(pctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(pcbxFrame, ComponentModel.ISupportInitialize).EndInit()
        tpPermissions.ResumeLayout(False)
        tpPermissions.PerformLayout()
        GbxModulesRoles.ResumeLayout(False)
        CType(DgnModulesRoles, ComponentModel.ISupportInitialize).EndInit()
        GbxCredetials.ResumeLayout(False)
        GbxCredetials.PerformLayout()
        tpWorkIn.ResumeLayout(False)
        tpWorkIn.PerformLayout()
        tpGeneral.ResumeLayout(False)
        tpGeneral.PerformLayout()
        TbctlEmployee.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnCancel As btn
    Friend WithEvents BtnSave As btn
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents BtnBrowsePhoto As btn
    Friend WithEvents pctbxPhoto As pctbx
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents pcbxFrame As pctbx
    Friend WithEvents TbctlEmployee As tbctl
    Friend WithEvents tpGeneral As TabPage
    Friend WithEvents TxtPersonalID As txt
    Friend WithEvents CboGender As cbo
    Friend WithEvents TxtFullName As txt
    Friend WithEvents tpWorkIn As TabPage
    Friend WithEvents TxtEmployeeNickname As txt
    Friend WithEvents TxtContractType As txt
    Friend WithEvents TxtContractTypeID As txt
    Friend WithEvents TxtEmployeeNumber As txt
    Friend WithEvents TxtGrade As txt
    Friend WithEvents TxtPositionID As txt
    Friend WithEvents TxtPosition As txt
    Friend WithEvents TxtGradeID As txt
    Friend WithEvents BtnBrowsePosition As btn
    Friend WithEvents TxtDepartement As txt
    Friend WithEvents TxtCompany As txt
    Friend WithEvents tpPermissions As TabPage
    Friend WithEvents GbxModulesRoles As gbx
    Friend WithEvents DgnModulesRoles As dgn
    Friend WithEvents DtpBirthDate As dtp
    Friend WithEvents ChkActiveEmployee As chk
    Friend WithEvents TxtBirthPlace As txt
    Friend WithEvents TxtAddress As txt
    Friend WithEvents GbxCredetials As gbx
    Friend WithEvents TxtLogin As txt
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents module_code As DataGridViewTextBoxColumn
    Friend WithEvents useraccess_view As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_add As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_edit As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_delete As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_reports As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_id As DataGridViewTextBoxColumn
    Friend WithEvents module_id As DataGridViewTextBoxColumn
    Friend WithEvents ULbl8 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl16 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl14 As ULbl
    Friend WithEvents ULbl13 As ULbl
    Friend WithEvents ULbl12 As ULbl
    Friend WithEvents ULbl11 As ULbl
    Friend WithEvents ULbl10 As ULbl
    Friend WithEvents ULbl9 As ULbl
    Friend WithEvents ULbl6 As ULbl
    Friend WithEvents ULbl7 As ULbl
    Friend WithEvents ULbl1 As ULbl
End Class
