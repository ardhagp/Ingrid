<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PLNT
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnPLNT = New dgn(components)
        plant_id = New DataGridViewTextBoxColumn()
        plant_code = New DataGridViewTextBoxColumn()
        plant_name = New DataGridViewTextBoxColumn()
        plant_name2 = New DataGridViewTextBoxColumn()
        plant_description = New DataGridViewTextBoxColumn()
        plant_city = New DataGridViewTextBoxColumn()
        plant_postalcode = New DataGridViewTextBoxColumn()
        plant_searchterm1 = New DataGridViewTextBoxColumn()
        plant_searchterm2 = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnPLNT, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnPLNT)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnPLNT, 0)
        ' 
        ' DgnPLNT
        ' 
        DgnPLNT.AllowUserToAddRows = False
        DgnPLNT.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(232), CByte(223), CByte(167))
        DgnPLNT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnPLNT.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnPLNT.BorderStyle = BorderStyle.None
        DgnPLNT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnPLNT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnPLNT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnPLNT.ColumnHeadersHeight = 43
        DgnPLNT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnPLNT.Columns.AddRange(New DataGridViewColumn() {plant_id, plant_code, plant_name, plant_name2, plant_description, plant_city, plant_postalcode, plant_searchterm1, plant_searchterm2})
        DgnPLNT.Dock = DockStyle.Fill
        DgnPLNT.EnableHeadersVisualStyles = False
        DgnPLNT.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnPLNT.Location = New Point(0, 53)
        DgnPLNT.Margin = New Padding(4, 3, 4, 3)
        DgnPLNT.Name = "DgnPLNT"
        DgnPLNT.ReadOnly = True
        DgnPLNT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnPLNT.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnPLNT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnPLNT.Size = New Size(915, 511)
        DgnPLNT.XOGroupFirstRows = False
        DgnPLNT.XOGunakanNomorBaris = True
        DgnPLNT.StandardTab = True
        DgnPLNT.TabIndex = 1
        ' 
        ' plant_id
        ' 
        plant_id.DataPropertyName = "plant_id"
        plant_id.HeaderText = "ID"
        plant_id.Name = "plant_id"
        plant_id.ReadOnly = True
        plant_id.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_id.Visible = False
        ' 
        ' plant_code
        ' 
        plant_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        plant_code.DataPropertyName = "plant_code"
        plant_code.HeaderText = "Code"
        plant_code.Name = "plant_code"
        plant_code.ReadOnly = True
        plant_code.SortMode = DataGridViewColumnSortMode.NotSortable
        plant_code.Width = 41
        ' 
        ' plant_name
        ' 
        plant_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        plant_name.DataPropertyName = "plant_name"
        plant_name.HeaderText = "Name 1"
        plant_name.Name = "plant_name"
        plant_name.ReadOnly = True
        plant_name.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_name.Width = 68
        ' 
        ' plant_name2
        ' 
        plant_name2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        plant_name2.DataPropertyName = "plant_name2"
        plant_name2.HeaderText = "Name 2"
        plant_name2.Name = "plant_name2"
        plant_name2.ReadOnly = True
        plant_name2.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_name2.Width = 68
        ' 
        ' plant_description
        ' 
        plant_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        plant_description.DataPropertyName = "plant_description"
        plant_description.HeaderText = "Description"
        plant_description.Name = "plant_description"
        plant_description.ReadOnly = True
        plant_description.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_description.Width = 5
        ' 
        ' plant_city
        ' 
        plant_city.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        plant_city.DataPropertyName = "plant_city"
        plant_city.HeaderText = "City"
        plant_city.Name = "plant_city"
        plant_city.ReadOnly = True
        plant_city.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_city.Width = 53
        ' 
        ' plant_postalcode
        ' 
        plant_postalcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        plant_postalcode.DataPropertyName = "plant_postalcode"
        plant_postalcode.HeaderText = "Postal Code"
        plant_postalcode.Name = "plant_postalcode"
        plant_postalcode.ReadOnly = True
        plant_postalcode.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_postalcode.Width = 90
        ' 
        ' plant_searchterm1
        ' 
        plant_searchterm1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        plant_searchterm1.DataPropertyName = "plant_searchterm1"
        plant_searchterm1.HeaderText = "Search Term 1"
        plant_searchterm1.Name = "plant_searchterm1"
        plant_searchterm1.ReadOnly = True
        plant_searchterm1.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_searchterm1.Width = 95
        ' 
        ' plant_searchterm2
        ' 
        plant_searchterm2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        plant_searchterm2.DataPropertyName = "plant_searchterm2"
        plant_searchterm2.HeaderText = "Search Term 2"
        plant_searchterm2.Name = "plant_searchterm2"
        plant_searchterm2.ReadOnly = True
        plant_searchterm2.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_searchterm2.Width = 95
        ' 
        ' PLNT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "PLNT"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnPLNT, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnPLNT As dgn
    Friend WithEvents plant_id As DataGridViewTextBoxColumn
    Friend WithEvents plant_code As DataGridViewTextBoxColumn
    Friend WithEvents plant_name As DataGridViewTextBoxColumn
    Friend WithEvents plant_name2 As DataGridViewTextBoxColumn
    Friend WithEvents plant_description As DataGridViewTextBoxColumn
    Friend WithEvents plant_city As DataGridViewTextBoxColumn
    Friend WithEvents plant_postalcode As DataGridViewTextBoxColumn
    Friend WithEvents plant_searchterm1 As DataGridViewTextBoxColumn
    Friend WithEvents plant_searchterm2 As DataGridViewTextBoxColumn
End Class
