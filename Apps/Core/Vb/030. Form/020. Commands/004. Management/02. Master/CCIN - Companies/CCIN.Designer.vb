﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCIN
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
        DgnCCIN = New dgn(components)
        company_id = New DataGridViewTextBoxColumn()
        company_code = New DataGridViewTextBoxColumn()
        company_name = New DataGridViewTextBoxColumn()
        company_searchterm1 = New DataGridViewTextBoxColumn()
        company_searchterm2 = New DataGridViewTextBoxColumn()
        company_description = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnCCIN, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnCCIN)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnCCIN, 0)
        ' 
        ' DgnCCIN
        ' 
        DgnCCIN.AllowUserToAddRows = False
        DgnCCIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(212), CByte(223), CByte(186))
        DgnCCIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnCCIN.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnCCIN.BorderStyle = BorderStyle.None
        DgnCCIN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnCCIN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnCCIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnCCIN.ColumnHeadersHeight = 43
        DgnCCIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnCCIN.Columns.AddRange(New DataGridViewColumn() {company_id, company_code, company_name, company_searchterm1, company_searchterm2, company_description})
        DgnCCIN.Dock = DockStyle.Fill
        DgnCCIN.EnableHeadersVisualStyles = False
        DgnCCIN.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnCCIN.Location = New Point(0, 53)
        DgnCCIN.Margin = New Padding(4, 3, 4, 3)
        DgnCCIN.MultiSelect = False
        DgnCCIN.Name = "DgnCCIN"
        DgnCCIN.ReadOnly = True
        DgnCCIN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnCCIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnCCIN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnCCIN.Size = New Size(915, 511)
        DgnCCIN.XOGroupFirstRows = False
        DgnCCIN.XOGunakanNomorBaris = True
        DgnCCIN.StandardTab = True
        DgnCCIN.TabIndex = 0
        ' 
        ' company_id
        ' 
        company_id.DataPropertyName = "company_id"
        company_id.HeaderText = "Company ID"
        company_id.Name = "company_id"
        company_id.ReadOnly = True
        company_id.SortMode = DataGridViewColumnSortMode.Programmatic
        company_id.Visible = False
        ' 
        ' company_code
        ' 
        company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        company_code.DataPropertyName = "company_code"
        company_code.HeaderText = "Company Code"
        company_code.Name = "company_code"
        company_code.ReadOnly = True
        company_code.SortMode = DataGridViewColumnSortMode.Programmatic
        company_code.Width = 5
        ' 
        ' company_name
        ' 
        company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        company_name.DataPropertyName = "company_name"
        company_name.HeaderText = "Company Name"
        company_name.Name = "company_name"
        company_name.ReadOnly = True
        company_name.SortMode = DataGridViewColumnSortMode.Programmatic
        company_name.Width = 112
        ' 
        ' company_searchterm1
        ' 
        company_searchterm1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        company_searchterm1.DataPropertyName = "company_searchterm1"
        company_searchterm1.HeaderText = "Company Search Term 1"
        company_searchterm1.Name = "company_searchterm1"
        company_searchterm1.ReadOnly = True
        company_searchterm1.SortMode = DataGridViewColumnSortMode.Programmatic
        company_searchterm1.Width = 5
        ' 
        ' company_searchterm2
        ' 
        company_searchterm2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        company_searchterm2.DataPropertyName = "company_searchterm2"
        company_searchterm2.HeaderText = "Company Search Term 2"
        company_searchterm2.Name = "company_searchterm2"
        company_searchterm2.ReadOnly = True
        company_searchterm2.SortMode = DataGridViewColumnSortMode.Programmatic
        company_searchterm2.Width = 5
        ' 
        ' company_description
        ' 
        company_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        company_description.DataPropertyName = "company_description"
        company_description.HeaderText = "Description"
        company_description.Name = "company_description"
        company_description.ReadOnly = True
        company_description.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' CCIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "CCIN"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnCCIN, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnCCIN As dgn
    Friend WithEvents company_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents company_name As DataGridViewTextBoxColumn
    Friend WithEvents company_searchterm1 As DataGridViewTextBoxColumn
    Friend WithEvents company_searchterm2 As DataGridViewTextBoxColumn
    Friend WithEvents company_description As DataGridViewTextBoxColumn

End Class
