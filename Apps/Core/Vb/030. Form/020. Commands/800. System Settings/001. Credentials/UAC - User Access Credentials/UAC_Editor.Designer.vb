﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UAC_Editor
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        TxtEmployeeNumber = New txt(components)
        TxtEmployeeFullName = New txt(components)
        TxtUsername = New txt(components)
        TxtPassword = New txt(components)
        BtnBrowseEmployee = New btn(components)
        ChkAddNew = New chk(components)
        LblPwdText = New lbl(components)
        ProgressBar1 = New ProgressBar()
        TbctlAccess = New tbctl(components)
        TpPermissions = New TabPage()
        DgnUACe = New dgn(components)
        modulegroup_name = New DataGridViewTextBoxColumn()
        module_code = New DataGridViewTextBoxColumn()
        useraccess_view = New DataGridViewCheckBoxColumn()
        useraccess_add = New DataGridViewCheckBoxColumn()
        useraccess_edit = New DataGridViewCheckBoxColumn()
        useraccess_delete = New DataGridViewCheckBoxColumn()
        useraccess_reports = New DataGridViewCheckBoxColumn()
        useraccess_id = New DataGridViewTextBoxColumn()
        module_id = New DataGridViewTextBoxColumn()
        TpAccessibility = New TabPage()
        ChkAdministrator = New chk(components)
        ChkLocked = New chk(components)
        ULbl1 = New ULbl()
        ULbl2 = New ULbl()
        ULbl3 = New ULbl()
        ULbl4 = New ULbl()
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlAccess.SuspendLayout()
        TpPermissions.SuspendLayout()
        CType(DgnUACe, ComponentModel.ISupportInitialize).BeginInit()
        TpAccessibility.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkAddNew)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 561)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(574, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(574, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TbctlAccess)
        SLFPanel.Controls.Add(ProgressBar1)
        SLFPanel.Controls.Add(LblPwdText)
        SLFPanel.Controls.Add(BtnBrowseEmployee)
        SLFPanel.Controls.Add(TxtPassword)
        SLFPanel.Controls.Add(TxtUsername)
        SLFPanel.Controls.Add(TxtEmployeeFullName)
        SLFPanel.Controls.Add(TxtEmployeeNumber)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(574, 619)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TxtEmployeeNumber, 0)
        SLFPanel.Controls.SetChildIndex(TxtEmployeeFullName, 0)
        SLFPanel.Controls.SetChildIndex(TxtUsername, 0)
        SLFPanel.Controls.SetChildIndex(TxtPassword, 0)
        SLFPanel.Controls.SetChildIndex(BtnBrowseEmployee, 0)
        SLFPanel.Controls.SetChildIndex(LblPwdText, 0)
        SLFPanel.Controls.SetChildIndex(ProgressBar1, 0)
        SLFPanel.Controls.SetChildIndex(TbctlAccess, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
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
        BtnSave.Location = New Point(319, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 7
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
        BtnCancel.Location = New Point(443, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 8
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' TxtEmployeeNumber
        ' 
        TxtEmployeeNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEmployeeNumber.Location = New Point(196, 12)
        TxtEmployeeNumber.Margin = New Padding(4, 3, 4, 3)
        TxtEmployeeNumber.MaxLength = 255
        TxtEmployeeNumber.Name = "TxtEmployeeNumber"
        TxtEmployeeNumber.ReadOnly = True
        TxtEmployeeNumber.Size = New Size(266, 29)
        TxtEmployeeNumber.SLFAutoTrim = False
        TxtEmployeeNumber.SLFHarusDiisi = False
        TxtEmployeeNumber.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtEmployeeNumber.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtEmployeeNumber.SLFHightlightSaatFokus = False
        TxtEmployeeNumber.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtEmployeeNumber.SLFIsBlank = False
        TxtEmployeeNumber.SLFIsSearchBox = False
        TxtEmployeeNumber.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
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
        TxtEmployeeNumber.TabIndex = 0
        TxtEmployeeNumber.Tag = "txt"
        TxtEmployeeNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtEmployeeFullName
        ' 
        TxtEmployeeFullName.BackColor = SystemColors.Window
        TxtEmployeeFullName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEmployeeFullName.Location = New Point(196, 52)
        TxtEmployeeFullName.Margin = New Padding(4, 3, 4, 3)
        TxtEmployeeFullName.MaxLength = 255
        TxtEmployeeFullName.Name = "TxtEmployeeFullName"
        TxtEmployeeFullName.ReadOnly = True
        TxtEmployeeFullName.Size = New Size(319, 29)
        TxtEmployeeFullName.SLFAutoTrim = False
        TxtEmployeeFullName.SLFHarusDiisi = False
        TxtEmployeeFullName.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtEmployeeFullName.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtEmployeeFullName.SLFHightlightSaatFokus = False
        TxtEmployeeFullName.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtEmployeeFullName.SLFIsBlank = True
        TxtEmployeeFullName.SLFIsSearchBox = False
        TxtEmployeeFullName.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtEmployeeFullName.SLFPilihSemuaSaatFokus = False
        TxtEmployeeFullName.SLFPwdLengthMin = 8
        TxtEmployeeFullName.SLFPwdStrengthCalculate = False
        TxtEmployeeFullName.SLFPwdStrengthScore = 0
        TxtEmployeeFullName.SLFPwdStrengthText = Nothing
        TxtEmployeeFullName.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtEmployeeFullName.SLFSearchBoxText = "Type then press Enter"
        TxtEmployeeFullName.SLFSQLText = ""
        TxtEmployeeFullName.SLFTanpaSpasi = False
        TxtEmployeeFullName.SLFValidasiField = Nothing
        TxtEmployeeFullName.TabIndex = 1
        TxtEmployeeFullName.TabStop = False
        TxtEmployeeFullName.Tag = "txt"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(196, 92)
        TxtUsername.Margin = New Padding(4, 3, 4, 3)
        TxtUsername.MaxLength = 255
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(319, 29)
        TxtUsername.SLFAutoTrim = True
        TxtUsername.SLFHarusDiisi = True
        TxtUsername.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtUsername.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtUsername.SLFHightlightSaatFokus = True
        TxtUsername.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtUsername.SLFIsBlank = True
        TxtUsername.SLFIsSearchBox = False
        TxtUsername.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtUsername.SLFPilihSemuaSaatFokus = True
        TxtUsername.SLFPwdLengthMin = 8
        TxtUsername.SLFPwdStrengthCalculate = False
        TxtUsername.SLFPwdStrengthScore = 0
        TxtUsername.SLFPwdStrengthText = Nothing
        TxtUsername.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtUsername.SLFSearchBoxText = "Type then press Enter"
        TxtUsername.SLFSQLText = ""
        TxtUsername.SLFTanpaSpasi = True
        TxtUsername.SLFValidasiField = Nothing
        TxtUsername.TabIndex = 3
        TxtUsername.Tag = "txt"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(196, 133)
        TxtPassword.Margin = New Padding(4, 3, 4, 3)
        TxtPassword.MaxLength = 255
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "●"c
        TxtPassword.Size = New Size(319, 29)
        TxtPassword.SLFAutoTrim = False
        TxtPassword.SLFHarusDiisi = True
        TxtPassword.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPassword.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPassword.SLFHightlightSaatFokus = True
        TxtPassword.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPassword.SLFIsBlank = True
        TxtPassword.SLFIsSearchBox = False
        TxtPassword.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPassword.SLFPilihSemuaSaatFokus = True
        TxtPassword.SLFPwdLengthMin = 8
        TxtPassword.SLFPwdStrengthCalculate = True
        TxtPassword.SLFPwdStrengthScore = 0
        TxtPassword.SLFPwdStrengthText = Nothing
        TxtPassword.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPassword.SLFSearchBoxText = "Type then press Enter"
        TxtPassword.SLFSQLText = ""
        TxtPassword.SLFTanpaSpasi = False
        TxtPassword.SLFValidasiField = Nothing
        TxtPassword.TabIndex = 4
        TxtPassword.Tag = "txt"
        ' 
        ' BtnBrowseEmployee
        ' 
        BtnBrowseEmployee.BackColor = Color.RoyalBlue
        BtnBrowseEmployee.Cursor = Cursors.Hand
        BtnBrowseEmployee.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnBrowseEmployee.FlatAppearance.BorderSize = 2
        BtnBrowseEmployee.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnBrowseEmployee.FlatStyle = FlatStyle.Flat
        BtnBrowseEmployee.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowseEmployee.ForeColor = Color.White
        BtnBrowseEmployee.Location = New Point(470, 12)
        BtnBrowseEmployee.Margin = New Padding(4, 3, 4, 3)
        BtnBrowseEmployee.Name = "BtnBrowseEmployee"
        BtnBrowseEmployee.Size = New Size(46, 33)
        BtnBrowseEmployee.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnBrowseEmployee.SLFTampilkanFocusBorder = False
        BtnBrowseEmployee.SLFValidasiSemuaInput = False
        BtnBrowseEmployee.SLFValidasiSemuaInputTag = Nothing
        BtnBrowseEmployee.TabIndex = 2
        BtnBrowseEmployee.Text = "..."
        BtnBrowseEmployee.UseVisualStyleBackColor = False
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(166, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 9
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' LblPwdText
        ' 
        LblPwdText.AutoSize = True
        LblPwdText.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblPwdText.Location = New Point(160, 188)
        LblPwdText.Margin = New Padding(4, 0, 4, 0)
        LblPwdText.Name = "LblPwdText"
        LblPwdText.Size = New Size(0, 21)
        LblPwdText.SLFCustomElipsis = False
        LblPwdText.TabIndex = 1006
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(196, 173)
        ProgressBar1.Margin = New Padding(4, 3, 4, 3)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(320, 12)
        ProgressBar1.Step = 1
        ProgressBar1.TabIndex = 1007
        ' 
        ' TbctlAccess
        ' 
        TbctlAccess.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TbctlAccess.Controls.Add(TpPermissions)
        TbctlAccess.Controls.Add(TpAccessibility)
        TbctlAccess.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlAccess.Location = New Point(0, 216)
        TbctlAccess.Margin = New Padding(4, 3, 4, 3)
        TbctlAccess.Name = "TbctlAccess"
        TbctlAccess.SelectedIndex = 0
        TbctlAccess.Size = New Size(574, 352)
        TbctlAccess.TabIndex = 1008
        ' 
        ' TpPermissions
        ' 
        TpPermissions.Controls.Add(DgnUACe)
        TpPermissions.Location = New Point(4, 30)
        TpPermissions.Margin = New Padding(4, 3, 4, 3)
        TpPermissions.Name = "TpPermissions"
        TpPermissions.Padding = New Padding(4, 3, 4, 3)
        TpPermissions.Size = New Size(566, 318)
        TpPermissions.TabIndex = 0
        TpPermissions.Text = "PERMISSIONS"
        TpPermissions.UseVisualStyleBackColor = True
        ' 
        ' DgnUACe
        ' 
        DgnUACe.AllowUserToAddRows = False
        DgnUACe.AllowUserToDeleteRows = False
        DgnUACe.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(222), CByte(155))
        DgnUACe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnUACe.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnUACe.BorderStyle = BorderStyle.None
        DgnUACe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnUACe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnUACe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnUACe.ColumnHeadersHeight = 43
        DgnUACe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnUACe.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports, useraccess_id, module_id})
        DgnUACe.Dock = DockStyle.Fill
        DgnUACe.EnableHeadersVisualStyles = False
        DgnUACe.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnUACe.Location = New Point(4, 3)
        DgnUACe.Margin = New Padding(4, 3, 4, 3)
        DgnUACe.MultiSelect = False
        DgnUACe.Name = "DgnUACe"
        DgnUACe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnUACe.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnUACe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnUACe.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgnUACe.Size = New Size(558, 312)
        DgnUACe.SLFGroupFirstRows = True
        DgnUACe.SLFGunakanNomorBaris = True
        DgnUACe.StandardTab = True
        DgnUACe.TabIndex = 7
        ' 
        ' modulegroup_name
        ' 
        modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        modulegroup_name.DataPropertyName = "modulegroup_name"
        modulegroup_name.HeaderText = "Module Group"
        modulegroup_name.Name = "modulegroup_name"
        modulegroup_name.ReadOnly = True
        modulegroup_name.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' module_code
        ' 
        module_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        module_code.DataPropertyName = "module_code"
        module_code.HeaderText = "Module Code"
        module_code.Name = "module_code"
        module_code.ReadOnly = True
        module_code.SortMode = DataGridViewColumnSortMode.Programmatic
        module_code.Width = 95
        ' 
        ' useraccess_view
        ' 
        useraccess_view.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_view.DataPropertyName = "useraccess_view"
        useraccess_view.HeaderText = "View"
        useraccess_view.Name = "useraccess_view"
        useraccess_view.Width = 40
        ' 
        ' useraccess_add
        ' 
        useraccess_add.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_add.DataPropertyName = "useraccess_add"
        useraccess_add.HeaderText = "Add"
        useraccess_add.Name = "useraccess_add"
        useraccess_add.Width = 40
        ' 
        ' useraccess_edit
        ' 
        useraccess_edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_edit.DataPropertyName = "useraccess_edit"
        useraccess_edit.HeaderText = "Edit"
        useraccess_edit.Name = "useraccess_edit"
        useraccess_edit.Width = 40
        ' 
        ' useraccess_delete
        ' 
        useraccess_delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_delete.DataPropertyName = "useraccess_delete"
        useraccess_delete.HeaderText = "Del"
        useraccess_delete.Name = "useraccess_delete"
        useraccess_delete.Width = 40
        ' 
        ' useraccess_reports
        ' 
        useraccess_reports.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        useraccess_reports.DataPropertyName = "useraccess_reports"
        useraccess_reports.HeaderText = "Rpt"
        useraccess_reports.Name = "useraccess_reports"
        useraccess_reports.Width = 40
        ' 
        ' useraccess_id
        ' 
        useraccess_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        useraccess_id.DataPropertyName = "useraccess_id"
        useraccess_id.HeaderText = "ID"
        useraccess_id.Name = "useraccess_id"
        useraccess_id.ReadOnly = True
        useraccess_id.SortMode = DataGridViewColumnSortMode.Programmatic
        useraccess_id.Visible = False
        ' 
        ' module_id
        ' 
        module_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        module_id.DataPropertyName = "module_id"
        module_id.HeaderText = "Module ID"
        module_id.Name = "module_id"
        module_id.ReadOnly = True
        module_id.SortMode = DataGridViewColumnSortMode.Programmatic
        module_id.Visible = False
        ' 
        ' TpAccessibility
        ' 
        TpAccessibility.Controls.Add(ChkAdministrator)
        TpAccessibility.Controls.Add(ChkLocked)
        TpAccessibility.Location = New Point(4, 30)
        TpAccessibility.Margin = New Padding(4, 3, 4, 3)
        TpAccessibility.Name = "TpAccessibility"
        TpAccessibility.Padding = New Padding(4, 3, 4, 3)
        TpAccessibility.Size = New Size(566, 318)
        TpAccessibility.TabIndex = 1
        TpAccessibility.Text = "ACCESSIBILITY"
        TpAccessibility.UseVisualStyleBackColor = True
        ' 
        ' ChkAdministrator
        ' 
        ChkAdministrator.AutoSize = True
        ChkAdministrator.BackColor = Color.Transparent
        ChkAdministrator.FlatStyle = FlatStyle.Flat
        ChkAdministrator.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAdministrator.Location = New Point(7, 47)
        ChkAdministrator.Margin = New Padding(4, 3, 4, 3)
        ChkAdministrator.Name = "ChkAdministrator"
        ChkAdministrator.Size = New Size(122, 25)
        ChkAdministrator.TabIndex = 1007
        ChkAdministrator.Text = "Administrator"
        ChkAdministrator.UseVisualStyleBackColor = False
        ' 
        ' ChkLocked
        ' 
        ChkLocked.AutoSize = True
        ChkLocked.BackColor = Color.Transparent
        ChkLocked.FlatStyle = FlatStyle.Flat
        ChkLocked.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkLocked.Location = New Point(7, 7)
        ChkLocked.Margin = New Padding(4, 3, 4, 3)
        ChkLocked.Name = "ChkLocked"
        ChkLocked.Size = New Size(75, 25)
        ChkLocked.TabIndex = 1006
        ChkLocked.Text = "Locked"
        ChkLocked.UseVisualStyleBackColor = False
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(14, 12)
        ULbl1.Margin = New Padding(5, 3, 5, 3)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(175, 33)
        ULbl1.SLFText = "Employee ID"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1010
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(14, 52)
        ULbl2.Margin = New Padding(5, 3, 5, 3)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Employee Name"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1011
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(14, 92)
        ULbl3.Margin = New Padding(5, 3, 5, 3)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Username"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1012
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(14, 133)
        ULbl4.Margin = New Padding(5, 3, 5, 3)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Password"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1013
        ' 
        ' UAC_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(574, 702)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "UAC_Editor"
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlAccess.ResumeLayout(False)
        TpPermissions.ResumeLayout(False)
        CType(DgnUACe, ComponentModel.ISupportInitialize).EndInit()
        TpAccessibility.ResumeLayout(False)
        TpAccessibility.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnCancel As btn
    Friend WithEvents BtnSave As btn
    Friend WithEvents TxtEmployeeNumber As txt
    Friend WithEvents TxtPassword As txt
    Friend WithEvents TxtUsername As txt
    Friend WithEvents TxtEmployeeFullName As txt
    Friend WithEvents BtnBrowseEmployee As btn
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents LblPwdText As lbl
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TbctlAccess As tbctl
    Friend WithEvents TpPermissions As TabPage
    Friend WithEvents DgnUACe As dgn
    Friend WithEvents TpAccessibility As TabPage
    Friend WithEvents ChkAdministrator As chk
    Friend WithEvents ChkLocked As chk
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents module_code As DataGridViewTextBoxColumn
    Friend WithEvents useraccess_view As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_add As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_edit As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_delete As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_reports As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_id As DataGridViewTextBoxColumn
    Friend WithEvents module_id As DataGridViewTextBoxColumn
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
End Class
