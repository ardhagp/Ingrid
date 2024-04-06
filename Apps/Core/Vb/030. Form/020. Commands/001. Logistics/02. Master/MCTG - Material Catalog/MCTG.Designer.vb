<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCTG
    Inherits CMCv.Std_Fi

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
        DgnMCTG = New dgn(components)
        material_id = New DataGridViewTextBoxColumn()
        material_number = New DataGridViewTextBoxColumn()
        material_name = New DataGridViewTextBoxColumn()
        material_longtext = New DataGridViewTextBoxColumn()
        materialgroup_code = New DataGridViewTextBoxColumn()
        materialtype_code = New DataGridViewTextBoxColumn()
        material_isidentifier = New DataGridViewTextBoxColumn()
        material_iscarrier = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnMCTG, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        SLFPanel.Controls.Add(DgnMCTG)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnMCTG, 0)
        ' 
        ' DgnMCTG
        ' 
        DgnMCTG.AllowUserToAddRows = False
        DgnMCTG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(207), CByte(229), CByte(109))
        DgnMCTG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnMCTG.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnMCTG.BorderStyle = BorderStyle.None
        DgnMCTG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnMCTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnMCTG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnMCTG.ColumnHeadersHeight = 43
        DgnMCTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnMCTG.Columns.AddRange(New DataGridViewColumn() {material_id, material_number, material_name, material_longtext, materialgroup_code, materialtype_code, material_isidentifier, material_iscarrier})
        DgnMCTG.Dock = DockStyle.Fill
        DgnMCTG.EnableHeadersVisualStyles = False
        DgnMCTG.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnMCTG.Location = New Point(0, 53)
        DgnMCTG.Margin = New Padding(4, 3, 4, 3)
        DgnMCTG.Name = "DgnMCTG"
        DgnMCTG.ReadOnly = True
        DgnMCTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnMCTG.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnMCTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnMCTG.Size = New Size(915, 511)
        DgnMCTG.XOGroupFirstRows = False
        DgnMCTG.XOGunakanNomorBaris = True
        DgnMCTG.StandardTab = True
        DgnMCTG.TabIndex = 0
        ' 
        ' material_id
        ' 
        material_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        material_id.DataPropertyName = "material_id"
        material_id.Frozen = True
        material_id.HeaderText = "ID"
        material_id.Name = "material_id"
        material_id.ReadOnly = True
        material_id.SortMode = DataGridViewColumnSortMode.Programmatic
        material_id.Width = 44
        ' 
        ' material_number
        ' 
        material_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        material_number.DataPropertyName = "material_number"
        material_number.Frozen = True
        material_number.HeaderText = "Number"
        material_number.Name = "material_number"
        material_number.ReadOnly = True
        material_number.Width = 75
        ' 
        ' material_name
        ' 
        material_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        material_name.DataPropertyName = "material_name"
        material_name.HeaderText = "Material Name"
        material_name.Name = "material_name"
        material_name.ReadOnly = True
        material_name.SortMode = DataGridViewColumnSortMode.Programmatic
        material_name.Width = 103
        ' 
        ' material_longtext
        ' 
        material_longtext.DataPropertyName = "material_longtext"
        material_longtext.HeaderText = "Long Text"
        material_longtext.Name = "material_longtext"
        material_longtext.ReadOnly = True
        material_longtext.SortMode = DataGridViewColumnSortMode.Programmatic
        material_longtext.Width = 200
        ' 
        ' materialgroup_code
        ' 
        materialgroup_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        materialgroup_code.DataPropertyName = "materialgroup_code"
        materialgroup_code.HeaderText = "Material Group"
        materialgroup_code.Name = "materialgroup_code"
        materialgroup_code.ReadOnly = True
        materialgroup_code.SortMode = DataGridViewColumnSortMode.Programmatic
        materialgroup_code.Width = 104
        ' 
        ' materialtype_code
        ' 
        materialtype_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        materialtype_code.DataPropertyName = "materialtype_code"
        materialtype_code.HeaderText = "Material Type"
        materialtype_code.Name = "materialtype_code"
        materialtype_code.ReadOnly = True
        materialtype_code.SortMode = DataGridViewColumnSortMode.Programmatic
        materialtype_code.Width = 97
        ' 
        ' material_isidentifier
        ' 
        material_isidentifier.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        material_isidentifier.DataPropertyName = "material_isidentifier"
        material_isidentifier.HeaderText = "IsID"
        material_isidentifier.Name = "material_isidentifier"
        material_isidentifier.ReadOnly = True
        material_isidentifier.SortMode = DataGridViewColumnSortMode.Programmatic
        material_isidentifier.Width = 55
        ' 
        ' material_iscarrier
        ' 
        material_iscarrier.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        material_iscarrier.DataPropertyName = "material_iscarrier"
        material_iscarrier.HeaderText = "IsCa"
        material_iscarrier.Name = "material_iscarrier"
        material_iscarrier.ReadOnly = True
        material_iscarrier.SortMode = DataGridViewColumnSortMode.Programmatic
        material_iscarrier.Width = 57
        ' 
        ' MCTG
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "MCTG"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnMCTG, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnMCTG As dgn
    Friend WithEvents material_id As DataGridViewTextBoxColumn
    Friend WithEvents material_number As DataGridViewTextBoxColumn
    Friend WithEvents material_name As DataGridViewTextBoxColumn
    Friend WithEvents material_longtext As DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_code As DataGridViewTextBoxColumn
    Friend WithEvents materialtype_code As DataGridViewTextBoxColumn
    Friend WithEvents material_isidentifier As DataGridViewTextBoxColumn
    Friend WithEvents material_iscarrier As DataGridViewTextBoxColumn
End Class
