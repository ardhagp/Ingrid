<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MODS
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
        DgnMODS = New dgn(components)
        modulegroup_name = New DataGridViewTextBoxColumn()
        module_code = New DataGridViewTextBoxColumn()
        module_name = New DataGridViewTextBoxColumn()
        module_description = New DataGridViewTextBoxColumn()
        module_issystem = New DataGridViewTextBoxColumn()
        module_ismaintenance = New DataGridViewCheckBoxColumn()
        module_id = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnMODS, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnMODS)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnMODS, 0)
        ' 
        ' DgnMODS
        ' 
        DgnMODS.AllowUserToAddRows = False
        DgnMODS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(200), CByte(205), CByte(176))
        DgnMODS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnMODS.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnMODS.BorderStyle = BorderStyle.None
        DgnMODS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnMODS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnMODS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnMODS.ColumnHeadersHeight = 43
        DgnMODS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnMODS.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, module_name, module_description, module_issystem, module_ismaintenance, module_id})
        DgnMODS.Dock = DockStyle.Fill
        DgnMODS.EnableHeadersVisualStyles = False
        DgnMODS.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnMODS.Location = New Point(0, 53)
        DgnMODS.Margin = New Padding(4, 3, 4, 3)
        DgnMODS.Name = "DgnMODS"
        DgnMODS.ReadOnly = True
        DgnMODS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.YellowGreen
        DataGridViewCellStyle4.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgnMODS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgnMODS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnMODS.Size = New Size(915, 511)
        DgnMODS.SLFGroupFirstRows = True
        DgnMODS.SLFGunakanNomorBaris = True
        DgnMODS.StandardTab = True
        DgnMODS.TabIndex = 802
        ' 
        ' modulegroup_name
        ' 
        modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        modulegroup_name.DataPropertyName = "modulegroup_name"
        modulegroup_name.HeaderText = "Group"
        modulegroup_name.Name = "modulegroup_name"
        modulegroup_name.ReadOnly = True
        modulegroup_name.SortMode = DataGridViewColumnSortMode.Programmatic
        modulegroup_name.Width = 65
        ' 
        ' module_code
        ' 
        module_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        module_code.DataPropertyName = "module_code"
        module_code.HeaderText = "Code"
        module_code.Name = "module_code"
        module_code.ReadOnly = True
        module_code.SortMode = DataGridViewColumnSortMode.Programmatic
        module_code.Width = 60
        ' 
        ' module_name
        ' 
        module_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        module_name.DataPropertyName = "module_name"
        module_name.HeaderText = "Module Name"
        module_name.Name = "module_name"
        module_name.ReadOnly = True
        module_name.SortMode = DataGridViewColumnSortMode.Programmatic
        module_name.Width = 98
        ' 
        ' module_description
        ' 
        module_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        module_description.DataPropertyName = "module_description"
        module_description.HeaderText = "Description"
        module_description.Name = "module_description"
        module_description.ReadOnly = True
        module_description.SortMode = DataGridViewColumnSortMode.Programmatic
        module_description.Width = 94
        ' 
        ' module_issystem
        ' 
        module_issystem.DataPropertyName = "module_issystem"
        module_issystem.HeaderText = "System Module"
        module_issystem.Name = "module_issystem"
        module_issystem.ReadOnly = True
        ' 
        ' module_ismaintenance
        ' 
        module_ismaintenance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        module_ismaintenance.DataPropertyName = "module_ismaintenance"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = False
        module_ismaintenance.DefaultCellStyle = DataGridViewCellStyle3
        module_ismaintenance.HeaderText = "Lock For Maintenance"
        module_ismaintenance.Name = "module_ismaintenance"
        module_ismaintenance.ReadOnly = True
        module_ismaintenance.Resizable = DataGridViewTriState.True
        module_ismaintenance.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' module_id
        ' 
        module_id.DataPropertyName = "module_id"
        module_id.HeaderText = "ID"
        module_id.Name = "module_id"
        module_id.ReadOnly = True
        module_id.SortMode = DataGridViewColumnSortMode.Programmatic
        module_id.Visible = False
        ' 
        ' MODS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "MODS"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnMODS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnMODS As dgn
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents module_code As DataGridViewTextBoxColumn
    Friend WithEvents module_name As DataGridViewTextBoxColumn
    Friend WithEvents module_description As DataGridViewTextBoxColumn
    Friend WithEvents module_issystem As DataGridViewTextBoxColumn
    Friend WithEvents module_ismaintenance As DataGridViewCheckBoxColumn
    Friend WithEvents module_id As DataGridViewTextBoxColumn
End Class
