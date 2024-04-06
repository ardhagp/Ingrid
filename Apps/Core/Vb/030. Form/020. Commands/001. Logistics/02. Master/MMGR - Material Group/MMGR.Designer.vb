<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMGR
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
        DgnMMGR = New dgn(components)
        materialgroup_id = New DataGridViewTextBoxColumn()
        materialgroup_description = New DataGridViewTextBoxColumn()
        materialgroup_description2 = New DataGridViewTextBoxColumn()
        materialgroup_language = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnMMGR, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnMMGR)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnMMGR, 0)
        ' 
        ' DgnMMGR
        ' 
        DgnMMGR.AllowUserToAddRows = False
        DgnMMGR.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(213), CByte(207), CByte(161))
        DgnMMGR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnMMGR.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnMMGR.BorderStyle = BorderStyle.None
        DgnMMGR.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnMMGR.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnMMGR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnMMGR.ColumnHeadersHeight = 43
        DgnMMGR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnMMGR.Columns.AddRange(New DataGridViewColumn() {materialgroup_id, materialgroup_description, materialgroup_description2, materialgroup_language})
        DgnMMGR.Dock = DockStyle.Fill
        DgnMMGR.EnableHeadersVisualStyles = False
        DgnMMGR.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnMMGR.Location = New Point(0, 53)
        DgnMMGR.Margin = New Padding(4, 3, 4, 3)
        DgnMMGR.Name = "DgnMMGR"
        DgnMMGR.ReadOnly = True
        DgnMMGR.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnMMGR.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnMMGR.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnMMGR.Size = New Size(915, 511)
        DgnMMGR.XOGroupFirstRows = False
        DgnMMGR.XOGunakanNomorBaris = True
        DgnMMGR.StandardTab = True
        DgnMMGR.TabIndex = 0
        ' 
        ' materialgroup_id
        ' 
        materialgroup_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        materialgroup_id.DataPropertyName = "materialgroup_id"
        materialgroup_id.HeaderText = "Group ID"
        materialgroup_id.Name = "materialgroup_id"
        materialgroup_id.ReadOnly = True
        materialgroup_id.SortMode = DataGridViewColumnSortMode.Programmatic
        materialgroup_id.Width = 77
        ' 
        ' materialgroup_description
        ' 
        materialgroup_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        materialgroup_description.DataPropertyName = "materialgroup_description"
        materialgroup_description.HeaderText = "Description"
        materialgroup_description.Name = "materialgroup_description"
        materialgroup_description.ReadOnly = True
        materialgroup_description.SortMode = DataGridViewColumnSortMode.Programmatic
        materialgroup_description.Width = 94
        ' 
        ' materialgroup_description2
        ' 
        materialgroup_description2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        materialgroup_description2.DataPropertyName = "materialgroup_description2"
        materialgroup_description2.HeaderText = "Description 2"
        materialgroup_description2.Name = "materialgroup_description2"
        materialgroup_description2.ReadOnly = True
        materialgroup_description2.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' materialgroup_language
        ' 
        materialgroup_language.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        materialgroup_language.DataPropertyName = "materialgroup_language"
        materialgroup_language.HeaderText = "Language"
        materialgroup_language.Name = "materialgroup_language"
        materialgroup_language.ReadOnly = True
        materialgroup_language.SortMode = DataGridViewColumnSortMode.Programmatic
        materialgroup_language.Width = 85
        ' 
        ' MMGR
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "MMGR"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnMMGR, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnMMGR As dgn
    Friend WithEvents materialgroup_id As DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_description As DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_description2 As DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_language As DataGridViewTextBoxColumn

End Class
