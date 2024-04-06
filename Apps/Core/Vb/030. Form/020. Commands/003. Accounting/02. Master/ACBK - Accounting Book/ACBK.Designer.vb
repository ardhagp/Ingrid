<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACBK
    Inherits CMCv.frmStandard

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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Pnl1 = New pnl(components)
        BtnClear = New btn(components)
        Lbl1 = New lbl(components)
        TxtFind = New txt(components)
        DgnACBK = New dgn(components)
        book_id = New DataGridViewTextBoxColumn()
        company_code = New DataGridViewTextBoxColumn()
        book_code = New DataGridViewTextBoxColumn()
        book_bookname = New DataGridViewTextBoxColumn()
        book_datecreated = New DataGridViewTextBoxColumn()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Pnl1.SuspendLayout()
        CType(DgnACBK, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(DgnACBK)
        SLFPanel.Controls.Add(Pnl1)
        ' 
        ' Pnl1
        ' 
        Pnl1.Controls.Add(BtnClear)
        Pnl1.Controls.Add(Lbl1)
        Pnl1.Controls.Add(TxtFind)
        Pnl1.Dock = DockStyle.Top
        Pnl1.Location = New Point(0, 0)
        Pnl1.Margin = New Padding(4, 3, 4, 3)
        Pnl1.Name = "Pnl1"
        Pnl1.Size = New Size(915, 53)
        Pnl1.TabIndex = 800
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.Red
        BtnClear.Cursor = Cursors.Hand
        BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClear.FlatStyle = FlatStyle.Flat
        BtnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClear.ForeColor = Color.White
        BtnClear.Location = New Point(306, 3)
        BtnClear.Margin = New Padding(4, 3, 4, 3)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(117, 46)
        BtnClear.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClear.XOTampilkanFocusBorder = False
        BtnClear.XOValidasiSemuaInput = False
        BtnClear.XOValidasiSemuaInputTag = Nothing
        BtnClear.TabIndex = 801
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(14, 15)
        Lbl1.Margin = New Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(40, 21)
        Lbl1.XOCustomElipsis = False
        Lbl1.TabIndex = 5
        Lbl1.Text = "Find"
        ' 
        ' TxtFind
        ' 
        TxtFind.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFind.Location = New Point(74, 12)
        TxtFind.Margin = New Padding(4, 3, 4, 3)
        TxtFind.MaxLength = 255
        TxtFind.Name = "TxtFind"
        TxtFind.Size = New Size(224, 29)
        TxtFind.XOAutoTrim = False
        TxtFind.XOHarusDiisi = False
        TxtFind.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtFind.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtFind.XOHightlightSaatFokus = False
        TxtFind.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtFind.XOIsBlank = True
        TxtFind.XOIsSearchBox = False
        TxtFind.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtFind.XOPilihSemuaSaatFokus = False
        TxtFind.XOPwdLengthMin = 8
        TxtFind.XOPwdStrengthCalculate = False
        TxtFind.XOPwdStrengthScore = 0
        TxtFind.XOPwdStrengthText = Nothing
        TxtFind.XORestriction = ControlCodeBase.enuRestriction.None
        TxtFind.XOSearchBoxText = "Type then press Enter"
        TxtFind.XOSQLText = Nothing
        TxtFind.XOTanpaSpasi = False
        TxtFind.XOValidasiField = Nothing
        TxtFind.TabIndex = 800
        TxtFind.Tag = "txt"
        ' 
        ' DgnACBK
        ' 
        DgnACBK.AllowUserToAddRows = False
        DgnACBK.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(198), CByte(193), CByte(185))
        DgnACBK.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnACBK.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnACBK.BorderStyle = BorderStyle.None
        DgnACBK.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnACBK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnACBK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnACBK.ColumnHeadersHeight = 43
        DgnACBK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnACBK.Columns.AddRange(New DataGridViewColumn() {book_id, company_code, book_code, book_bookname, book_datecreated})
        DgnACBK.Dock = DockStyle.Fill
        DgnACBK.EnableHeadersVisualStyles = False
        DgnACBK.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnACBK.Location = New Point(0, 53)
        DgnACBK.Margin = New Padding(4, 3, 4, 3)
        DgnACBK.Name = "DgnACBK"
        DgnACBK.ReadOnly = True
        DgnACBK.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.YellowGreen
        DataGridViewCellStyle4.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgnACBK.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgnACBK.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnACBK.Size = New Size(915, 511)
        DgnACBK.XOGroupFirstRows = False
        DgnACBK.XOGunakanNomorBaris = True
        DgnACBK.StandardTab = True
        DgnACBK.TabIndex = 0
        ' 
        ' book_id
        ' 
        book_id.DataPropertyName = "book_id"
        book_id.HeaderText = "ID"
        book_id.Name = "book_id"
        book_id.ReadOnly = True
        book_id.Visible = False
        ' 
        ' company_code
        ' 
        company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        company_code.DataPropertyName = "company_code"
        company_code.HeaderText = "Company"
        company_code.Name = "company_code"
        company_code.ReadOnly = True
        company_code.SortMode = DataGridViewColumnSortMode.Programmatic
        company_code.Width = 85
        ' 
        ' book_code
        ' 
        book_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        book_code.DataPropertyName = "book_code"
        DataGridViewCellStyle3.BackColor = Color.GreenYellow
        book_code.DefaultCellStyle = DataGridViewCellStyle3
        book_code.HeaderText = "Acc Book Code"
        book_code.Name = "book_code"
        book_code.ReadOnly = True
        book_code.SortMode = DataGridViewColumnSortMode.Programmatic
        book_code.Width = 80
        ' 
        ' book_bookname
        ' 
        book_bookname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        book_bookname.DataPropertyName = "book_bookname"
        book_bookname.HeaderText = "Book Name"
        book_bookname.Name = "book_bookname"
        book_bookname.ReadOnly = True
        book_bookname.SortMode = DataGridViewColumnSortMode.Programmatic
        book_bookname.Width = 88
        ' 
        ' book_datecreated
        ' 
        book_datecreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        book_datecreated.DataPropertyName = "book_datecreated"
        book_datecreated.HeaderText = "Created On"
        book_datecreated.Name = "book_datecreated"
        book_datecreated.ReadOnly = True
        book_datecreated.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' ACBK
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(6, 3, 6, 3)
        Name = "ACBK"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Pnl1.ResumeLayout(False)
        Pnl1.PerformLayout()
        CType(DgnACBK, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Pnl1 As pnl
    Friend WithEvents BtnClear As btn
    Friend WithEvents Lbl1 As lbl
    Friend WithEvents TxtFind As txt
    Friend WithEvents DgnACBK As dgn
    Friend WithEvents book_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents book_code As DataGridViewTextBoxColumn
    Friend WithEvents book_bookname As DataGridViewTextBoxColumn
    Friend WithEvents book_datecreated As DataGridViewTextBoxColumn
End Class
