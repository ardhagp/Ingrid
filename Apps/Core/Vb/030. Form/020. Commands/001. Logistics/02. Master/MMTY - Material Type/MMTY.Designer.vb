<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMTY
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnMMTY = New dgn(components)
        materialtype_id = New DataGridViewTextBoxColumn()
        materialtype_description = New DataGridViewTextBoxColumn()
        itemcount = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnMMTY, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnMMTY)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnMMTY, 0)
        ' 
        ' DgnMMTY
        ' 
        DgnMMTY.AllowUserToAddRows = False
        DgnMMTY.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(242), CByte(249), CByte(185))
        DgnMMTY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnMMTY.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnMMTY.BorderStyle = BorderStyle.None
        DgnMMTY.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnMMTY.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnMMTY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnMMTY.ColumnHeadersHeight = 43
        DgnMMTY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnMMTY.Columns.AddRange(New DataGridViewColumn() {materialtype_id, materialtype_description, itemcount})
        DgnMMTY.Dock = DockStyle.Fill
        DgnMMTY.EnableHeadersVisualStyles = False
        DgnMMTY.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnMMTY.Location = New Point(0, 53)
        DgnMMTY.Margin = New Padding(4, 3, 4, 3)
        DgnMMTY.Name = "DgnMMTY"
        DgnMMTY.ReadOnly = True
        DgnMMTY.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.YellowGreen
        DataGridViewCellStyle4.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgnMMTY.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgnMMTY.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnMMTY.Size = New Size(915, 511)
        DgnMMTY.XOGroupFirstRows = False
        DgnMMTY.XOGunakanNomorBaris = True
        DgnMMTY.StandardTab = True
        DgnMMTY.TabIndex = 0
        ' 
        ' materialtype_id
        ' 
        materialtype_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        materialtype_id.DataPropertyName = "materialtype_id"
        materialtype_id.HeaderText = "Material Type"
        materialtype_id.Name = "materialtype_id"
        materialtype_id.ReadOnly = True
        materialtype_id.SortMode = DataGridViewColumnSortMode.Programmatic
        materialtype_id.Width = 5
        ' 
        ' materialtype_description
        ' 
        materialtype_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        materialtype_description.DataPropertyName = "materialtype_description"
        materialtype_description.HeaderText = "Type Description"
        materialtype_description.Name = "materialtype_description"
        materialtype_description.ReadOnly = True
        materialtype_description.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' itemcount
        ' 
        itemcount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        itemcount.DataPropertyName = "itemcount"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        itemcount.DefaultCellStyle = DataGridViewCellStyle3
        itemcount.HeaderText = "Consist of"
        itemcount.Name = "itemcount"
        itemcount.ReadOnly = True
        itemcount.SortMode = DataGridViewColumnSortMode.Programmatic
        itemcount.Width = 5
        ' 
        ' MMTY
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "MMTY"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnMMTY, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnMMTY As dgn
    Friend WithEvents materialtype_id As DataGridViewTextBoxColumn
    Friend WithEvents materialtype_description As DataGridViewTextBoxColumn
    Friend WithEvents itemcount As DataGridViewTextBoxColumn

End Class
