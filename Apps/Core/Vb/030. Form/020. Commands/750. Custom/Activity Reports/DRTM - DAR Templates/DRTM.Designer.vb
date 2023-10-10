<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DRTM
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
        DgnTemplate = New dgn(components)
        template_id = New DataGridViewTextBoxColumn()
        template_title = New DataGridViewTextBoxColumn()
        template_text1 = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnTemplate, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnTemplate)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnTemplate, 0)
        ' 
        ' DgnTemplate
        ' 
        DgnTemplate.AllowUserToAddRows = False
        DgnTemplate.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(203), CByte(236), CByte(181))
        DgnTemplate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnTemplate.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnTemplate.BorderStyle = BorderStyle.None
        DgnTemplate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnTemplate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnTemplate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnTemplate.ColumnHeadersHeight = 43
        DgnTemplate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnTemplate.Columns.AddRange(New DataGridViewColumn() {template_id, template_title, template_text1})
        DgnTemplate.Dock = DockStyle.Fill
        DgnTemplate.EnableHeadersVisualStyles = False
        DgnTemplate.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnTemplate.Location = New Point(0, 53)
        DgnTemplate.Margin = New Padding(4, 3, 4, 3)
        DgnTemplate.Name = "DgnTemplate"
        DgnTemplate.ReadOnly = True
        DgnTemplate.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnTemplate.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnTemplate.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnTemplate.Size = New Size(915, 511)
        DgnTemplate.SLFGroupFirstRows = False
        DgnTemplate.SLFGunakanNomorBaris = False
        DgnTemplate.StandardTab = True
        DgnTemplate.TabIndex = 802
        ' 
        ' template_id
        ' 
        template_id.DataPropertyName = "template_id"
        template_id.HeaderText = "ID"
        template_id.Name = "template_id"
        template_id.ReadOnly = True
        ' 
        ' template_title
        ' 
        template_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        template_title.DataPropertyName = "template_title"
        template_title.HeaderText = "Name / Title"
        template_title.Name = "template_title"
        template_title.ReadOnly = True
        template_title.Width = 70
        ' 
        ' template_text1
        ' 
        template_text1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        template_text1.DataPropertyName = "template_text1"
        template_text1.HeaderText = "Template Text"
        template_text1.Name = "template_text1"
        template_text1.ReadOnly = True
        ' 
        ' DRTM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "DRTM"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnTemplate, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnTemplate As dgn
    Friend WithEvents template_id As DataGridViewTextBoxColumn
    Friend WithEvents template_title As DataGridViewTextBoxColumn
    Friend WithEvents template_text1 As DataGridViewTextBoxColumn
End Class
