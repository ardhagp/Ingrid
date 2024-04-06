<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MODS_Editor
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnSave = New CMCv.btn(components)
        BtnCancel = New CMCv.btn(components)
        ChkAddNew = New CMCv.chk(components)
        Tbctl1 = New CMCv.tbctl(components)
        tpGeneral = New TabPage()
        ULbl5 = New CMCv.ULbl()
        ULbl4 = New CMCv.ULbl()
        ULbl3 = New CMCv.ULbl()
        ULbl2 = New CMCv.ULbl()
        ULbl1 = New CMCv.ULbl()
        ChkSystem = New CMCv.chk(components)
        TxtCode = New CMCv.txt(components)
        ChkLocked = New CMCv.chk(components)
        CboGroup = New CMCv.cbo(components)
        TxtDescription = New CMCv.txt(components)
        TxtName = New CMCv.txt(components)
        TxtID = New CMCv.txt(components)
        tpPermissions = New TabPage()
        GbxAccessBy = New CMCv.gbx(components)
        DgnUserRoles = New CMCv.dgn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Tbctl1.SuspendLayout()
        tpGeneral.SuspendLayout()
        tpPermissions.SuspendLayout()
        GbxAccessBy.SuspendLayout()
        CType(DgnUserRoles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkAddNew)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 344)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(663, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(663, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Tbctl1)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(663, 402)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Tbctl1, 0)
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
        BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(408, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnSave.XOTampilkanFocusBorder = False
        BtnSave.XOValidasiSemuaInput = False
        BtnSave.XOValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 6
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
        BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(532, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 8
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(255, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 7
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' Tbctl1
        ' 
        Tbctl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Tbctl1.Controls.Add(tpGeneral)
        Tbctl1.Controls.Add(tpPermissions)
        Tbctl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Tbctl1.Location = New Point(14, 7)
        Tbctl1.Margin = New Padding(4, 3, 4, 3)
        Tbctl1.Name = "Tbctl1"
        Tbctl1.SelectedIndex = 0
        Tbctl1.Size = New Size(635, 330)
        Tbctl1.TabIndex = 0
        ' 
        ' tpGeneral
        ' 
        tpGeneral.AutoScroll = True
        tpGeneral.Controls.Add(ULbl5)
        tpGeneral.Controls.Add(ULbl4)
        tpGeneral.Controls.Add(ULbl3)
        tpGeneral.Controls.Add(ULbl2)
        tpGeneral.Controls.Add(ULbl1)
        tpGeneral.Controls.Add(ChkSystem)
        tpGeneral.Controls.Add(TxtCode)
        tpGeneral.Controls.Add(ChkLocked)
        tpGeneral.Controls.Add(CboGroup)
        tpGeneral.Controls.Add(TxtDescription)
        tpGeneral.Controls.Add(TxtName)
        tpGeneral.Controls.Add(TxtID)
        tpGeneral.Location = New Point(4, 30)
        tpGeneral.Margin = New Padding(4, 3, 4, 3)
        tpGeneral.Name = "tpGeneral"
        tpGeneral.Padding = New Padding(4, 3, 4, 3)
        tpGeneral.Size = New Size(627, 296)
        tpGeneral.TabIndex = 0
        tpGeneral.Text = "General"
        tpGeneral.UseVisualStyleBackColor = True
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(8, 173)
        ULbl5.Margin = New Padding(5, 6, 5, 6)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(175, 33)
        ULbl5.SLFText = "Description"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1021
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(8, 133)
        ULbl4.Margin = New Padding(5, 6, 5, 6)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Module Name"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1020
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(8, 92)
        ULbl3.Margin = New Padding(5, 6, 5, 6)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Code"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1019
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(8, 52)
        ULbl2.Margin = New Padding(5, 6, 5, 6)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Group"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1018
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(8, 12)
        ULbl1.Margin = New Padding(5, 6, 5, 6)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(175, 33)
        ULbl1.SLFText = "Module ID"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1017
        ' 
        ' ChkSystem
        ' 
        ChkSystem.AutoSize = True
        ChkSystem.BackColor = Color.Transparent
        ChkSystem.FlatStyle = FlatStyle.Flat
        ChkSystem.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ChkSystem.Location = New Point(189, 213)
        ChkSystem.Margin = New Padding(4, 3, 4, 3)
        ChkSystem.Name = "ChkSystem"
        ChkSystem.Size = New Size(134, 25)
        ChkSystem.TabIndex = 6
        ChkSystem.Text = "System Module"
        ChkSystem.UseVisualStyleBackColor = False
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCode.Location = New Point(191, 92)
        TxtCode.Margin = New Padding(4, 3, 4, 3)
        TxtCode.MaxLength = 255
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(153, 29)
        TxtCode.XOAutoTrim = True
        TxtCode.XOHarusDiisi = True
        TxtCode.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtCode.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtCode.XOHightlightSaatFokus = False
        TxtCode.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtCode.XOIsBlank = True
        TxtCode.XOIsSearchBox = False
        TxtCode.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtCode.XOPilihSemuaSaatFokus = True
        TxtCode.XOPwdLengthMin = 8
        TxtCode.XOPwdStrengthCalculate = False
        TxtCode.XOPwdStrengthScore = 0
        TxtCode.XOPwdStrengthText = Nothing
        TxtCode.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtCode.XOSearchBoxText = "Type then press Enter"
        TxtCode.XOSQLText = ""
        TxtCode.XOTanpaSpasi = True
        TxtCode.XOValidasiField = Nothing
        TxtCode.TabIndex = 3
        TxtCode.Tag = "txt"
        ' 
        ' ChkLocked
        ' 
        ChkLocked.AutoSize = True
        ChkLocked.BackColor = Color.Transparent
        ChkLocked.FlatStyle = FlatStyle.Flat
        ChkLocked.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ChkLocked.Location = New Point(189, 249)
        ChkLocked.Margin = New Padding(4, 3, 4, 3)
        ChkLocked.Name = "ChkLocked"
        ChkLocked.Size = New Size(97, 25)
        ChkLocked.TabIndex = 7
        ChkLocked.Text = "Is Locked?"
        ChkLocked.UseVisualStyleBackColor = False
        ' 
        ' CboGroup
        ' 
        CboGroup.DropDownStyle = ComboBoxStyle.DropDownList
        CboGroup.FlatStyle = FlatStyle.Flat
        CboGroup.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        CboGroup.FormattingEnabled = True
        CboGroup.Location = New Point(191, 52)
        CboGroup.Margin = New Padding(4, 3, 4, 3)
        CboGroup.Name = "CboGroup"
        CboGroup.Size = New Size(240, 29)
        CboGroup.TabIndex = 2
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(191, 173)
        TxtDescription.Margin = New Padding(4, 3, 4, 3)
        TxtDescription.MaxLength = 255
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(387, 29)
        TxtDescription.XOAutoTrim = True
        TxtDescription.XOHarusDiisi = True
        TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.XOHightlightSaatFokus = False
        TxtDescription.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.XOIsBlank = True
        TxtDescription.XOIsSearchBox = False
        TxtDescription.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        TxtDescription.XOPilihSemuaSaatFokus = False
        TxtDescription.XOPwdLengthMin = 8
        TxtDescription.XOPwdStrengthCalculate = False
        TxtDescription.XOPwdStrengthScore = 0
        TxtDescription.XOPwdStrengthText = Nothing
        TxtDescription.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtDescription.XOSearchBoxText = "Type then press Enter"
        TxtDescription.XOSQLText = ""
        TxtDescription.XOTanpaSpasi = False
        TxtDescription.XOValidasiField = Nothing
        TxtDescription.TabIndex = 5
        TxtDescription.Tag = "txt"
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(191, 133)
        TxtName.Margin = New Padding(4, 3, 4, 3)
        TxtName.MaxLength = 255
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(266, 29)
        TxtName.XOAutoTrim = True
        TxtName.XOHarusDiisi = True
        TxtName.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtName.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtName.XOHightlightSaatFokus = False
        TxtName.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtName.XOIsBlank = True
        TxtName.XOIsSearchBox = False
        TxtName.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        TxtName.XOPilihSemuaSaatFokus = True
        TxtName.XOPwdLengthMin = 8
        TxtName.XOPwdStrengthCalculate = False
        TxtName.XOPwdStrengthScore = 0
        TxtName.XOPwdStrengthText = Nothing
        TxtName.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtName.XOSearchBoxText = "Type then press Enter"
        TxtName.XOSQLText = ""
        TxtName.XOTanpaSpasi = False
        TxtName.XOValidasiField = Nothing
        TxtName.TabIndex = 4
        TxtName.Tag = "txt"
        ' 
        ' TxtID
        ' 
        TxtID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtID.Location = New Point(191, 12)
        TxtID.Margin = New Padding(4, 3, 4, 3)
        TxtID.MaxLength = 255
        TxtID.Name = "TxtID"
        TxtID.ReadOnly = True
        TxtID.Size = New Size(387, 29)
        TxtID.XOAutoTrim = False
        TxtID.XOHarusDiisi = False
        TxtID.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtID.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtID.XOHightlightSaatFokus = False
        TxtID.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtID.XOIsBlank = True
        TxtID.XOIsSearchBox = False
        TxtID.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        TxtID.XOPilihSemuaSaatFokus = False
        TxtID.XOPwdLengthMin = 8
        TxtID.XOPwdStrengthCalculate = False
        TxtID.XOPwdStrengthScore = 0
        TxtID.XOPwdStrengthText = Nothing
        TxtID.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtID.XOSearchBoxText = "Type then press Enter"
        TxtID.XOSQLText = ""
        TxtID.XOTanpaSpasi = False
        TxtID.XOValidasiField = Nothing
        TxtID.TabIndex = 1
        TxtID.Tag = "txt"
        ' 
        ' tpPermissions
        ' 
        tpPermissions.Controls.Add(GbxAccessBy)
        tpPermissions.Location = New Point(4, 30)
        tpPermissions.Margin = New Padding(4, 3, 4, 3)
        tpPermissions.Name = "tpPermissions"
        tpPermissions.Padding = New Padding(4, 3, 4, 3)
        tpPermissions.Size = New Size(1032, 545)
        tpPermissions.TabIndex = 1
        tpPermissions.Text = "Permissions"
        tpPermissions.UseVisualStyleBackColor = True
        ' 
        ' GbxAccessBy
        ' 
        GbxAccessBy.Controls.Add(DgnUserRoles)
        GbxAccessBy.Dock = DockStyle.Fill
        GbxAccessBy.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        GbxAccessBy.Location = New Point(4, 3)
        GbxAccessBy.Margin = New Padding(4, 3, 4, 3)
        GbxAccessBy.Name = "GbxAccessBy"
        GbxAccessBy.Padding = New Padding(4, 3, 4, 3)
        GbxAccessBy.Size = New Size(1024, 539)
        GbxAccessBy.TabIndex = 0
        GbxAccessBy.TabStop = False
        GbxAccessBy.Text = "User or roles"
        ' 
        ' DgnUserRoles
        ' 
        DgnUserRoles.AllowUserToAddRows = False
        DgnUserRoles.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(193), CByte(232), CByte(150))
        DgnUserRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnUserRoles.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnUserRoles.BorderStyle = BorderStyle.None
        DgnUserRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnUserRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnUserRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnUserRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgnUserRoles.Dock = DockStyle.Fill
        DgnUserRoles.EnableHeadersVisualStyles = False
        DgnUserRoles.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DgnUserRoles.Location = New Point(4, 25)
        DgnUserRoles.Margin = New Padding(4, 3, 4, 3)
        DgnUserRoles.Name = "DgnUserRoles"
        DgnUserRoles.ReadOnly = True
        DgnUserRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnUserRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnUserRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnUserRoles.Size = New Size(1016, 511)
        DgnUserRoles.XOGroupFirstRows = False
        DgnUserRoles.XOGunakanNomorBaris = False
        DgnUserRoles.StandardTab = True
        DgnUserRoles.TabIndex = 0
        ' 
        ' MODS_Editor
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        ClientSize = New Size(663, 485)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "MODS_Editor"
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Tbctl1.ResumeLayout(False)
        tpGeneral.ResumeLayout(False)
        tpGeneral.PerformLayout()
        tpPermissions.ResumeLayout(False)
        GbxAccessBy.ResumeLayout(False)
        CType(DgnUserRoles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents Tbctl1 As CMCv.tbctl
    Friend WithEvents tpGeneral As TabPage
    Friend WithEvents TxtCode As CMCv.txt
    Friend WithEvents ChkLocked As CMCv.chk
    Friend WithEvents CboGroup As CMCv.cbo
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents TxtName As CMCv.txt
    Friend WithEvents TxtID As CMCv.txt
    Friend WithEvents tpPermissions As TabPage
    Friend WithEvents GbxAccessBy As CMCv.gbx
    Friend WithEvents DgnUserRoles As CMCv.dgn
    Friend WithEvents ChkSystem As CMCv.chk
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
End Class
