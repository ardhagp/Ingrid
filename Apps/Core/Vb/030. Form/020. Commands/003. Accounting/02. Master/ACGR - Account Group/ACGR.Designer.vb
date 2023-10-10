<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACGR
    Inherits CMCv.Std_Fi

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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        CboCompany = New cbo(components)
        Lbl3 = New lbl(components)
        CboAccountingBook = New cbo(components)
        Lbl2 = New lbl(components)
        TbctlAccountGroup = New tbctl(components)
        tpAssets = New TabPage()
        DgnACGRAssets = New dgn(components)
        account_id_assets = New DataGridViewTextBoxColumn()
        account_num_assets = New DataGridViewTextBoxColumn()
        account_name_assets = New DataGridViewTextBoxColumn()
        account_enable_assets = New DataGridViewTextBoxColumn()
        tpLiabilities = New TabPage()
        DgnACGRLiabities = New dgn(components)
        account_id_liability = New DataGridViewTextBoxColumn()
        account_num_liabilities = New DataGridViewTextBoxColumn()
        account_name_liabilities = New DataGridViewTextBoxColumn()
        account_enable_liabilities = New DataGridViewTextBoxColumn()
        tpEquity = New TabPage()
        DgnACGREquity = New dgn(components)
        account_id_equity = New DataGridViewTextBoxColumn()
        account_num_equity = New DataGridViewTextBoxColumn()
        account_name_equity = New DataGridViewTextBoxColumn()
        account_enable_equity = New DataGridViewTextBoxColumn()
        tpRevenue = New TabPage()
        DgnACGRRevenue = New dgn(components)
        account_id_revenue = New DataGridViewTextBoxColumn()
        account_num_revenue = New DataGridViewTextBoxColumn()
        account_name_revenue = New DataGridViewTextBoxColumn()
        account_enable_revenue = New DataGridViewTextBoxColumn()
        tpExpense = New TabPage()
        DgnACGRExpense = New dgn(components)
        account_id_expense = New DataGridViewTextBoxColumn()
        account_num_expense = New DataGridViewTextBoxColumn()
        account_name_expense = New DataGridViewTextBoxColumn()
        account_enable_expense = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlAccountGroup.SuspendLayout()
        tpAssets.SuspendLayout()
        CType(DgnACGRAssets, ComponentModel.ISupportInitialize).BeginInit()
        tpLiabilities.SuspendLayout()
        CType(DgnACGRLiabities, ComponentModel.ISupportInitialize).BeginInit()
        tpEquity.SuspendLayout()
        CType(DgnACGREquity, ComponentModel.ISupportInitialize).BeginInit()
        tpRevenue.SuspendLayout()
        CType(DgnACGRRevenue, ComponentModel.ISupportInitialize).BeginInit()
        tpExpense.SuspendLayout()
        CType(DgnACGRExpense, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlFind
        ' 
        PnlFind.Controls.Add(CboCompany)
        PnlFind.Controls.Add(Lbl3)
        PnlFind.Controls.Add(Lbl2)
        PnlFind.Controls.Add(CboAccountingBook)
        PnlFind.Controls.SetChildIndex(TxtFind, 0)
        PnlFind.Controls.SetChildIndex(CboAccountingBook, 0)
        PnlFind.Controls.SetChildIndex(LblFind, 0)
        PnlFind.Controls.SetChildIndex(Lbl2, 0)
        PnlFind.Controls.SetChildIndex(Lbl3, 0)
        PnlFind.Controls.SetChildIndex(BtnClear, 0)
        PnlFind.Controls.SetChildIndex(CboCompany, 0)
        ' 
        ' BtnClear
        ' 
        BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        ' 
        ' TxtFind
        ' 
        TxtFind.Margin = New Padding(5, 3, 5, 3)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TbctlAccountGroup)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(TbctlAccountGroup, 0)
        ' 
        ' CboCompany
        ' 
        CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
        CboCompany.DropDownWidth = 350
        CboCompany.FlatStyle = FlatStyle.Flat
        CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboCompany.FormattingEnabled = True
        CboCompany.IntegralHeight = False
        CboCompany.Location = New Point(552, 12)
        CboCompany.Margin = New Padding(4, 3, 4, 3)
        CboCompany.Name = "CboCompany"
        CboCompany.Size = New Size(116, 29)
        CboCompany.TabIndex = 802
        ' 
        ' Lbl3
        ' 
        Lbl3.AutoSize = True
        Lbl3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(455, 15)
        Lbl3.Margin = New Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(77, 21)
        Lbl3.SLFCustomElipsis = False
        Lbl3.TabIndex = 9
        Lbl3.Text = "Company"
        ' 
        ' CboAccountingBook
        ' 
        CboAccountingBook.DropDownStyle = ComboBoxStyle.DropDownList
        CboAccountingBook.FlatStyle = FlatStyle.Flat
        CboAccountingBook.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboAccountingBook.FormattingEnabled = True
        CboAccountingBook.Location = New Point(735, 12)
        CboAccountingBook.Margin = New Padding(4, 3, 4, 3)
        CboAccountingBook.Name = "CboAccountingBook"
        CboAccountingBook.Size = New Size(271, 29)
        CboAccountingBook.TabIndex = 803
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl2.Location = New Point(676, 15)
        Lbl2.Margin = New Padding(4, 0, 4, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(45, 21)
        Lbl2.SLFCustomElipsis = False
        Lbl2.TabIndex = 7
        Lbl2.Text = "Book"
        ' 
        ' TbctlAccountGroup
        ' 
        TbctlAccountGroup.Controls.Add(tpAssets)
        TbctlAccountGroup.Controls.Add(tpLiabilities)
        TbctlAccountGroup.Controls.Add(tpEquity)
        TbctlAccountGroup.Controls.Add(tpRevenue)
        TbctlAccountGroup.Controls.Add(tpExpense)
        TbctlAccountGroup.Dock = DockStyle.Fill
        TbctlAccountGroup.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlAccountGroup.Location = New Point(0, 53)
        TbctlAccountGroup.Margin = New Padding(4, 3, 4, 3)
        TbctlAccountGroup.Name = "TbctlAccountGroup"
        TbctlAccountGroup.SelectedIndex = 0
        TbctlAccountGroup.Size = New Size(915, 511)
        TbctlAccountGroup.TabIndex = 0
        ' 
        ' tpAssets
        ' 
        tpAssets.AccessibleName = "tpAssets"
        tpAssets.Controls.Add(DgnACGRAssets)
        tpAssets.Location = New Point(4, 30)
        tpAssets.Margin = New Padding(4, 3, 4, 3)
        tpAssets.Name = "tpAssets"
        tpAssets.Padding = New Padding(4, 3, 4, 3)
        tpAssets.Size = New Size(907, 477)
        tpAssets.TabIndex = 0
        tpAssets.Text = "ASSETS"
        tpAssets.UseVisualStyleBackColor = True
        ' 
        ' DgnACGRAssets
        ' 
        DgnACGRAssets.AllowUserToAddRows = False
        DgnACGRAssets.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(207), CByte(234), CByte(135))
        DgnACGRAssets.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnACGRAssets.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnACGRAssets.BorderStyle = BorderStyle.None
        DgnACGRAssets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnACGRAssets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnACGRAssets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnACGRAssets.ColumnHeadersHeight = 43
        DgnACGRAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnACGRAssets.Columns.AddRange(New DataGridViewColumn() {account_id_assets, account_num_assets, account_name_assets, account_enable_assets})
        DgnACGRAssets.Dock = DockStyle.Fill
        DgnACGRAssets.EnableHeadersVisualStyles = False
        DgnACGRAssets.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnACGRAssets.Location = New Point(4, 3)
        DgnACGRAssets.Margin = New Padding(4, 3, 4, 3)
        DgnACGRAssets.Name = "DgnACGRAssets"
        DgnACGRAssets.ReadOnly = True
        DgnACGRAssets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.YellowGreen
        DataGridViewCellStyle4.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgnACGRAssets.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgnACGRAssets.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnACGRAssets.Size = New Size(899, 471)
        DgnACGRAssets.SLFGroupFirstRows = False
        DgnACGRAssets.SLFGunakanNomorBaris = True
        DgnACGRAssets.StandardTab = True
        DgnACGRAssets.TabIndex = 0
        ' 
        ' account_id_assets
        ' 
        account_id_assets.DataPropertyName = "account_id"
        account_id_assets.HeaderText = "ID"
        account_id_assets.Name = "account_id_assets"
        account_id_assets.ReadOnly = True
        account_id_assets.Visible = False
        ' 
        ' account_num_assets
        ' 
        account_num_assets.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_num_assets.DataPropertyName = "account_num"
        account_num_assets.HeaderText = "Number"
        account_num_assets.Name = "account_num_assets"
        account_num_assets.ReadOnly = True
        account_num_assets.SortMode = DataGridViewColumnSortMode.Programmatic
        account_num_assets.Width = 75
        ' 
        ' account_name_assets
        ' 
        account_name_assets.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_name_assets.DataPropertyName = "account_name"
        account_name_assets.HeaderText = "Account Name"
        account_name_assets.Name = "account_name_assets"
        account_name_assets.ReadOnly = True
        account_name_assets.SortMode = DataGridViewColumnSortMode.Programmatic
        account_name_assets.Width = 103
        ' 
        ' account_enable_assets
        ' 
        account_enable_assets.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        account_enable_assets.DataPropertyName = "account_enable"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        account_enable_assets.DefaultCellStyle = DataGridViewCellStyle3
        account_enable_assets.HeaderText = "Enable"
        account_enable_assets.Name = "account_enable_assets"
        account_enable_assets.ReadOnly = True
        account_enable_assets.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' tpLiabilities
        ' 
        tpLiabilities.Controls.Add(DgnACGRLiabities)
        tpLiabilities.Location = New Point(4, 30)
        tpLiabilities.Margin = New Padding(4, 3, 4, 3)
        tpLiabilities.Name = "tpLiabilities"
        tpLiabilities.Padding = New Padding(4, 3, 4, 3)
        tpLiabilities.Size = New Size(907, 477)
        tpLiabilities.TabIndex = 1
        tpLiabilities.Text = "LIABILITIES"
        tpLiabilities.UseVisualStyleBackColor = True
        ' 
        ' DgnACGRLiabities
        ' 
        DgnACGRLiabities.AllowUserToAddRows = False
        DgnACGRLiabities.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(190), CByte(214), CByte(102))
        DgnACGRLiabities.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DgnACGRLiabities.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnACGRLiabities.BorderStyle = BorderStyle.None
        DgnACGRLiabities.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnACGRLiabities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnACGRLiabities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnACGRLiabities.ColumnHeadersHeight = 43
        DgnACGRLiabities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnACGRLiabities.Columns.AddRange(New DataGridViewColumn() {account_id_liability, account_num_liabilities, account_name_liabilities, account_enable_liabilities})
        DgnACGRLiabities.Dock = DockStyle.Fill
        DgnACGRLiabities.EnableHeadersVisualStyles = False
        DgnACGRLiabities.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnACGRLiabities.Location = New Point(4, 3)
        DgnACGRLiabities.Margin = New Padding(4, 3, 4, 3)
        DgnACGRLiabities.Name = "DgnACGRLiabities"
        DgnACGRLiabities.ReadOnly = True
        DgnACGRLiabities.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.YellowGreen
        DataGridViewCellStyle8.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DgnACGRLiabities.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DgnACGRLiabities.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnACGRLiabities.Size = New Size(899, 471)
        DgnACGRLiabities.SLFGroupFirstRows = False
        DgnACGRLiabities.SLFGunakanNomorBaris = True
        DgnACGRLiabities.StandardTab = True
        DgnACGRLiabities.TabIndex = 0
        ' 
        ' account_id_liability
        ' 
        account_id_liability.DataPropertyName = "account_id"
        account_id_liability.HeaderText = "ID"
        account_id_liability.Name = "account_id_liability"
        account_id_liability.ReadOnly = True
        account_id_liability.SortMode = DataGridViewColumnSortMode.Programmatic
        account_id_liability.Visible = False
        ' 
        ' account_num_liabilities
        ' 
        account_num_liabilities.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_num_liabilities.DataPropertyName = "account_num"
        account_num_liabilities.HeaderText = "Number"
        account_num_liabilities.Name = "account_num_liabilities"
        account_num_liabilities.ReadOnly = True
        account_num_liabilities.SortMode = DataGridViewColumnSortMode.Programmatic
        account_num_liabilities.Width = 75
        ' 
        ' account_name_liabilities
        ' 
        account_name_liabilities.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_name_liabilities.DataPropertyName = "account_name"
        account_name_liabilities.HeaderText = "Account Name"
        account_name_liabilities.Name = "account_name_liabilities"
        account_name_liabilities.ReadOnly = True
        account_name_liabilities.SortMode = DataGridViewColumnSortMode.Programmatic
        account_name_liabilities.Width = 103
        ' 
        ' account_enable_liabilities
        ' 
        account_enable_liabilities.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        account_enable_liabilities.DataPropertyName = "account_enable"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        account_enable_liabilities.DefaultCellStyle = DataGridViewCellStyle7
        account_enable_liabilities.HeaderText = "Enable"
        account_enable_liabilities.Name = "account_enable_liabilities"
        account_enable_liabilities.ReadOnly = True
        account_enable_liabilities.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' tpEquity
        ' 
        tpEquity.Controls.Add(DgnACGREquity)
        tpEquity.Location = New Point(4, 30)
        tpEquity.Margin = New Padding(4, 3, 4, 3)
        tpEquity.Name = "tpEquity"
        tpEquity.Padding = New Padding(4, 3, 4, 3)
        tpEquity.Size = New Size(907, 477)
        tpEquity.TabIndex = 2
        tpEquity.Text = "EQUITY"
        tpEquity.UseVisualStyleBackColor = True
        ' 
        ' DgnACGREquity
        ' 
        DgnACGREquity.AllowUserToAddRows = False
        DgnACGREquity.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(215), CByte(237), CByte(140))
        DgnACGREquity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DgnACGREquity.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnACGREquity.BorderStyle = BorderStyle.None
        DgnACGREquity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnACGREquity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.YellowGreen
        DataGridViewCellStyle10.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle10.SelectionForeColor = Color.Black
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DgnACGREquity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DgnACGREquity.ColumnHeadersHeight = 43
        DgnACGREquity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnACGREquity.Columns.AddRange(New DataGridViewColumn() {account_id_equity, account_num_equity, account_name_equity, account_enable_equity})
        DgnACGREquity.Dock = DockStyle.Fill
        DgnACGREquity.EnableHeadersVisualStyles = False
        DgnACGREquity.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnACGREquity.Location = New Point(4, 3)
        DgnACGREquity.Margin = New Padding(4, 3, 4, 3)
        DgnACGREquity.Name = "DgnACGREquity"
        DgnACGREquity.ReadOnly = True
        DgnACGREquity.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.YellowGreen
        DataGridViewCellStyle12.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle12.SelectionForeColor = Color.Black
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DgnACGREquity.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DgnACGREquity.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnACGREquity.Size = New Size(899, 471)
        DgnACGREquity.SLFGroupFirstRows = False
        DgnACGREquity.SLFGunakanNomorBaris = True
        DgnACGREquity.StandardTab = True
        DgnACGREquity.TabIndex = 0
        ' 
        ' account_id_equity
        ' 
        account_id_equity.DataPropertyName = "account_id"
        account_id_equity.HeaderText = "ID"
        account_id_equity.Name = "account_id_equity"
        account_id_equity.ReadOnly = True
        account_id_equity.SortMode = DataGridViewColumnSortMode.Programmatic
        account_id_equity.Visible = False
        ' 
        ' account_num_equity
        ' 
        account_num_equity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_num_equity.DataPropertyName = "account_num"
        account_num_equity.HeaderText = "Number"
        account_num_equity.Name = "account_num_equity"
        account_num_equity.ReadOnly = True
        account_num_equity.SortMode = DataGridViewColumnSortMode.Programmatic
        account_num_equity.Width = 75
        ' 
        ' account_name_equity
        ' 
        account_name_equity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_name_equity.DataPropertyName = "account_name"
        account_name_equity.HeaderText = "Account Name"
        account_name_equity.Name = "account_name_equity"
        account_name_equity.ReadOnly = True
        account_name_equity.SortMode = DataGridViewColumnSortMode.Programmatic
        account_name_equity.Width = 103
        ' 
        ' account_enable_equity
        ' 
        account_enable_equity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        account_enable_equity.DataPropertyName = "account_enable"
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        account_enable_equity.DefaultCellStyle = DataGridViewCellStyle11
        account_enable_equity.HeaderText = "Enable"
        account_enable_equity.Name = "account_enable_equity"
        account_enable_equity.ReadOnly = True
        account_enable_equity.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' tpRevenue
        ' 
        tpRevenue.Controls.Add(DgnACGRRevenue)
        tpRevenue.Location = New Point(4, 30)
        tpRevenue.Margin = New Padding(4, 3, 4, 3)
        tpRevenue.Name = "tpRevenue"
        tpRevenue.Padding = New Padding(4, 3, 4, 3)
        tpRevenue.Size = New Size(907, 477)
        tpRevenue.TabIndex = 3
        tpRevenue.Text = "REVENUE"
        tpRevenue.UseVisualStyleBackColor = True
        ' 
        ' DgnACGRRevenue
        ' 
        DgnACGRRevenue.AllowUserToAddRows = False
        DgnACGRRevenue.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = Color.FromArgb(CByte(238), CByte(217), CByte(165))
        DgnACGRRevenue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DgnACGRRevenue.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnACGRRevenue.BorderStyle = BorderStyle.None
        DgnACGRRevenue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnACGRRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = Color.YellowGreen
        DataGridViewCellStyle14.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle14.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle14.SelectionForeColor = Color.Black
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
        DgnACGRRevenue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        DgnACGRRevenue.ColumnHeadersHeight = 43
        DgnACGRRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnACGRRevenue.Columns.AddRange(New DataGridViewColumn() {account_id_revenue, account_num_revenue, account_name_revenue, account_enable_revenue})
        DgnACGRRevenue.Dock = DockStyle.Fill
        DgnACGRRevenue.EnableHeadersVisualStyles = False
        DgnACGRRevenue.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnACGRRevenue.Location = New Point(4, 3)
        DgnACGRRevenue.Margin = New Padding(4, 3, 4, 3)
        DgnACGRRevenue.Name = "DgnACGRRevenue"
        DgnACGRRevenue.ReadOnly = True
        DgnACGRRevenue.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = Color.YellowGreen
        DataGridViewCellStyle16.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle16.SelectionForeColor = Color.Black
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
        DgnACGRRevenue.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        DgnACGRRevenue.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnACGRRevenue.Size = New Size(899, 471)
        DgnACGRRevenue.SLFGroupFirstRows = False
        DgnACGRRevenue.SLFGunakanNomorBaris = True
        DgnACGRRevenue.StandardTab = True
        DgnACGRRevenue.TabIndex = 0
        ' 
        ' account_id_revenue
        ' 
        account_id_revenue.DataPropertyName = "account_id"
        account_id_revenue.HeaderText = "ID"
        account_id_revenue.Name = "account_id_revenue"
        account_id_revenue.ReadOnly = True
        account_id_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
        account_id_revenue.Visible = False
        ' 
        ' account_num_revenue
        ' 
        account_num_revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_num_revenue.DataPropertyName = "account_num"
        account_num_revenue.HeaderText = "Number"
        account_num_revenue.Name = "account_num_revenue"
        account_num_revenue.ReadOnly = True
        account_num_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
        account_num_revenue.Width = 75
        ' 
        ' account_name_revenue
        ' 
        account_name_revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_name_revenue.DataPropertyName = "account_name"
        account_name_revenue.HeaderText = "Account Name"
        account_name_revenue.Name = "account_name_revenue"
        account_name_revenue.ReadOnly = True
        account_name_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
        account_name_revenue.Width = 103
        ' 
        ' account_enable_revenue
        ' 
        account_enable_revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        account_enable_revenue.DataPropertyName = "account_enable"
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft
        account_enable_revenue.DefaultCellStyle = DataGridViewCellStyle15
        account_enable_revenue.HeaderText = "Enable"
        account_enable_revenue.Name = "account_enable_revenue"
        account_enable_revenue.ReadOnly = True
        account_enable_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' tpExpense
        ' 
        tpExpense.Controls.Add(DgnACGRExpense)
        tpExpense.Location = New Point(4, 30)
        tpExpense.Margin = New Padding(4, 3, 4, 3)
        tpExpense.Name = "tpExpense"
        tpExpense.Padding = New Padding(4, 3, 4, 3)
        tpExpense.Size = New Size(907, 477)
        tpExpense.TabIndex = 4
        tpExpense.Text = "EXPENSE"
        tpExpense.UseVisualStyleBackColor = True
        ' 
        ' DgnACGRExpense
        ' 
        DgnACGRExpense.AllowUserToAddRows = False
        DgnACGRExpense.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.BackColor = Color.FromArgb(CByte(209), CByte(249), CByte(144))
        DgnACGRExpense.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        DgnACGRExpense.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnACGRExpense.BorderStyle = BorderStyle.None
        DgnACGRExpense.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnACGRExpense.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = Color.YellowGreen
        DataGridViewCellStyle18.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle18.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle18.SelectionForeColor = Color.Black
        DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True
        DgnACGRExpense.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        DgnACGRExpense.ColumnHeadersHeight = 43
        DgnACGRExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnACGRExpense.Columns.AddRange(New DataGridViewColumn() {account_id_expense, account_num_expense, account_name_expense, account_enable_expense})
        DgnACGRExpense.Dock = DockStyle.Fill
        DgnACGRExpense.EnableHeadersVisualStyles = False
        DgnACGRExpense.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnACGRExpense.Location = New Point(4, 3)
        DgnACGRExpense.Margin = New Padding(4, 3, 4, 3)
        DgnACGRExpense.Name = "DgnACGRExpense"
        DgnACGRExpense.ReadOnly = True
        DgnACGRExpense.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = Color.YellowGreen
        DataGridViewCellStyle20.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle20.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle20.SelectionForeColor = Color.Black
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True
        DgnACGRExpense.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        DgnACGRExpense.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnACGRExpense.Size = New Size(899, 471)
        DgnACGRExpense.SLFGroupFirstRows = False
        DgnACGRExpense.SLFGunakanNomorBaris = True
        DgnACGRExpense.StandardTab = True
        DgnACGRExpense.TabIndex = 0
        ' 
        ' account_id_expense
        ' 
        account_id_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_id_expense.DataPropertyName = "account_id"
        account_id_expense.HeaderText = "ID"
        account_id_expense.Name = "account_id_expense"
        account_id_expense.ReadOnly = True
        account_id_expense.SortMode = DataGridViewColumnSortMode.Programmatic
        account_id_expense.Visible = False
        ' 
        ' account_num_expense
        ' 
        account_num_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_num_expense.DataPropertyName = "account_num"
        account_num_expense.HeaderText = "Number"
        account_num_expense.Name = "account_num_expense"
        account_num_expense.ReadOnly = True
        account_num_expense.SortMode = DataGridViewColumnSortMode.Programmatic
        account_num_expense.Width = 75
        ' 
        ' account_name_expense
        ' 
        account_name_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        account_name_expense.DataPropertyName = "account_name"
        account_name_expense.HeaderText = "Account Name"
        account_name_expense.Name = "account_name_expense"
        account_name_expense.ReadOnly = True
        account_name_expense.SortMode = DataGridViewColumnSortMode.Programmatic
        account_name_expense.Width = 103
        ' 
        ' account_enable_expense
        ' 
        account_enable_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        account_enable_expense.DataPropertyName = "account_enable"
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft
        account_enable_expense.DefaultCellStyle = DataGridViewCellStyle19
        account_enable_expense.HeaderText = "Enable"
        account_enable_expense.Name = "account_enable_expense"
        account_enable_expense.ReadOnly = True
        account_enable_expense.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' ACGR
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "ACGR"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlAccountGroup.ResumeLayout(False)
        tpAssets.ResumeLayout(False)
        CType(DgnACGRAssets, ComponentModel.ISupportInitialize).EndInit()
        tpLiabilities.ResumeLayout(False)
        CType(DgnACGRLiabities, ComponentModel.ISupportInitialize).EndInit()
        tpEquity.ResumeLayout(False)
        CType(DgnACGREquity, ComponentModel.ISupportInitialize).EndInit()
        tpRevenue.ResumeLayout(False)
        CType(DgnACGRRevenue, ComponentModel.ISupportInitialize).EndInit()
        tpExpense.ResumeLayout(False)
        CType(DgnACGRExpense, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TbctlAccountGroup As tbctl
    Friend WithEvents tpAssets As TabPage
    Friend WithEvents DgnACGRAssets As dgn
    Friend WithEvents tpLiabilities As TabPage
    Friend WithEvents DgnACGRLiabities As dgn
    Friend WithEvents tpEquity As TabPage
    Friend WithEvents tpRevenue As TabPage
    Friend WithEvents DgnACGRRevenue As dgn
    Friend WithEvents tpExpense As TabPage
    Friend WithEvents DgnACGRExpense As dgn
    Friend WithEvents CboAccountingBook As cbo
    Friend WithEvents Lbl2 As lbl
    Friend WithEvents DgnACGREquity As dgn
    Friend WithEvents CboCompany As cbo
    Friend WithEvents Lbl3 As lbl
    Friend WithEvents account_id_assets As DataGridViewTextBoxColumn
    Friend WithEvents account_num_assets As DataGridViewTextBoxColumn
    Friend WithEvents account_name_assets As DataGridViewTextBoxColumn
    Friend WithEvents account_enable_assets As DataGridViewTextBoxColumn
    Friend WithEvents account_id_liability As DataGridViewTextBoxColumn
    Friend WithEvents account_num_liabilities As DataGridViewTextBoxColumn
    Friend WithEvents account_name_liabilities As DataGridViewTextBoxColumn
    Friend WithEvents account_enable_liabilities As DataGridViewTextBoxColumn
    Friend WithEvents account_id_equity As DataGridViewTextBoxColumn
    Friend WithEvents account_num_equity As DataGridViewTextBoxColumn
    Friend WithEvents account_name_equity As DataGridViewTextBoxColumn
    Friend WithEvents account_enable_equity As DataGridViewTextBoxColumn
    Friend WithEvents account_id_revenue As DataGridViewTextBoxColumn
    Friend WithEvents account_num_revenue As DataGridViewTextBoxColumn
    Friend WithEvents account_name_revenue As DataGridViewTextBoxColumn
    Friend WithEvents account_enable_revenue As DataGridViewTextBoxColumn
    Friend WithEvents account_id_expense As DataGridViewTextBoxColumn
    Friend WithEvents account_num_expense As DataGridViewTextBoxColumn
    Friend WithEvents account_name_expense As DataGridViewTextBoxColumn
    Friend WithEvents account_enable_expense As DataGridViewTextBoxColumn
End Class
