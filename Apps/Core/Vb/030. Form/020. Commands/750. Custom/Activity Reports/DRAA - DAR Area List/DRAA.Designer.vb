<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DRAA
    Inherits CMCv.frmStandard

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
        Pnl1 = New pnl(components)
        BtnClear = New btn(components)
        Lbl1 = New lbl(components)
        TxtFind = New txt(components)
        DgnArea = New dgn(components)
        areaaffected_id = New DataGridViewTextBoxColumn()
        areaaffected_order = New DataGridViewTextBoxColumn()
        areaaffected_name = New DataGridViewTextBoxColumn()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Pnl1.SuspendLayout()
        CType(DgnArea, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(DgnArea)
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
        Pnl1.TabIndex = 801
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
        BtnClear.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClear.SLFTampilkanFocusBorder = False
        BtnClear.SLFValidasiSemuaInput = False
        BtnClear.SLFValidasiSemuaInputTag = Nothing
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
        Lbl1.SLFCustomElipsis = False
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
        TxtFind.SLFAutoTrim = False
        TxtFind.SLFHarusDiisi = False
        TxtFind.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtFind.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtFind.SLFHightlightSaatFokus = False
        TxtFind.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtFind.SLFIsBlank = True
        TxtFind.SLFIsSearchBox = True
        TxtFind.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtFind.SLFPilihSemuaSaatFokus = False
        TxtFind.SLFPwdLengthMin = 8
        TxtFind.SLFPwdStrengthCalculate = False
        TxtFind.SLFPwdStrengthScore = 0
        TxtFind.SLFPwdStrengthText = Nothing
        TxtFind.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtFind.SLFSearchBoxText = "Type then press Enter"
        TxtFind.SLFSQLText = Nothing
        TxtFind.SLFTanpaSpasi = False
        TxtFind.SLFValidasiField = Nothing
        TxtFind.TabIndex = 800
        TxtFind.Tag = "txt"
        ' 
        ' DgnArea
        ' 
        DgnArea.AllowUserToAddRows = False
        DgnArea.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(192), CByte(228), CByte(156))
        DgnArea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnArea.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnArea.BorderStyle = BorderStyle.None
        DgnArea.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnArea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnArea.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnArea.ColumnHeadersHeight = 43
        DgnArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnArea.Columns.AddRange(New DataGridViewColumn() {areaaffected_id, areaaffected_order, areaaffected_name})
        DgnArea.Dock = DockStyle.Fill
        DgnArea.EnableHeadersVisualStyles = False
        DgnArea.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnArea.Location = New Point(0, 53)
        DgnArea.Margin = New Padding(4, 3, 4, 3)
        DgnArea.Name = "DgnArea"
        DgnArea.ReadOnly = True
        DgnArea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnArea.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnArea.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnArea.Size = New Size(915, 511)
        DgnArea.SLFGroupFirstRows = False
        DgnArea.SLFGunakanNomorBaris = True
        DgnArea.StandardTab = True
        DgnArea.TabIndex = 803
        ' 
        ' areaaffected_id
        ' 
        areaaffected_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        areaaffected_id.DataPropertyName = "areaaffected_id"
        areaaffected_id.HeaderText = "ID"
        areaaffected_id.Name = "areaaffected_id"
        areaaffected_id.ReadOnly = True
        areaaffected_id.Width = 44
        ' 
        ' areaaffected_order
        ' 
        areaaffected_order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        areaaffected_order.DataPropertyName = "areaaffected_order"
        areaaffected_order.HeaderText = "Order"
        areaaffected_order.Name = "areaaffected_order"
        areaaffected_order.ReadOnly = True
        areaaffected_order.Width = 63
        ' 
        ' areaaffected_name
        ' 
        areaaffected_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        areaaffected_name.DataPropertyName = "areaaffected_name"
        areaaffected_name.HeaderText = "Area Name"
        areaaffected_name.Name = "areaaffected_name"
        areaaffected_name.ReadOnly = True
        ' 
        ' DRAA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(6, 3, 6, 3)
        Name = "DRAA"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Pnl1.ResumeLayout(False)
        Pnl1.PerformLayout()
        CType(DgnArea, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Pnl1 As pnl
    Friend WithEvents BtnClear As btn
    Friend WithEvents Lbl1 As lbl
    Friend WithEvents TxtFind As txt
    Friend WithEvents DgnArea As dgn
    Friend WithEvents areaaffected_id As DataGridViewTextBoxColumn
    Friend WithEvents areaaffected_order As DataGridViewTextBoxColumn
    Friend WithEvents areaaffected_name As DataGridViewTextBoxColumn
End Class
