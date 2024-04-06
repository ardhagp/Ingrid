<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPLS
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
        DgnEPLS = New dgn(components)
        employee_id = New DataGridViewTextBoxColumn()
        company_code = New DataGridViewTextBoxColumn()
        departement_code = New DataGridViewTextBoxColumn()
        position_code = New DataGridViewTextBoxColumn()
        employee_grade = New DataGridViewTextBoxColumn()
        employee_number = New DataGridViewTextBoxColumn()
        employee_fullname = New DataGridViewTextBoxColumn()
        employee_nickname = New DataGridViewTextBoxColumn()
        employee_contracttype = New DataGridViewTextBoxColumn()
        employee_gender = New DataGridViewTextBoxColumn()
        employee_active = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnEPLS, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnEPLS)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnEPLS, 0)
        ' 
        ' DgnEPLS
        ' 
        DgnEPLS.AllowUserToAddRows = False
        DgnEPLS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(228), CByte(199), CByte(106))
        DgnEPLS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnEPLS.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnEPLS.BorderStyle = BorderStyle.None
        DgnEPLS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnEPLS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnEPLS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnEPLS.ColumnHeadersHeight = 43
        DgnEPLS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnEPLS.Columns.AddRange(New DataGridViewColumn() {employee_id, company_code, departement_code, position_code, employee_grade, employee_number, employee_fullname, employee_nickname, employee_contracttype, employee_gender, employee_active})
        DgnEPLS.Dock = DockStyle.Fill
        DgnEPLS.EnableHeadersVisualStyles = False
        DgnEPLS.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnEPLS.Location = New Point(0, 53)
        DgnEPLS.Margin = New Padding(4, 3, 4, 3)
        DgnEPLS.Name = "DgnEPLS"
        DgnEPLS.ReadOnly = True
        DgnEPLS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.YellowGreen
        DataGridViewCellStyle4.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DgnEPLS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DgnEPLS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnEPLS.Size = New Size(915, 511)
        DgnEPLS.XOGroupFirstRows = False
        DgnEPLS.XOGunakanNomorBaris = True
        DgnEPLS.StandardTab = True
        DgnEPLS.TabIndex = 0
        ' 
        ' employee_id
        ' 
        employee_id.DataPropertyName = "employee_id"
        employee_id.HeaderText = "Employee ID"
        employee_id.Name = "employee_id"
        employee_id.ReadOnly = True
        employee_id.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_id.Visible = False
        ' 
        ' company_code
        ' 
        company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        company_code.DataPropertyName = "company_code"
        company_code.HeaderText = "Company"
        company_code.Name = "company_code"
        company_code.ReadOnly = True
        company_code.SortMode = DataGridViewColumnSortMode.NotSortable
        company_code.Width = 5
        ' 
        ' departement_code
        ' 
        departement_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        departement_code.DataPropertyName = "departement_code"
        departement_code.HeaderText = "Departement"
        departement_code.Name = "departement_code"
        departement_code.ReadOnly = True
        departement_code.SortMode = DataGridViewColumnSortMode.NotSortable
        departement_code.Width = 5
        ' 
        ' position_code
        ' 
        position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        position_code.DataPropertyName = "position_code"
        position_code.HeaderText = "Position"
        position_code.Name = "position_code"
        position_code.ReadOnly = True
        position_code.SortMode = DataGridViewColumnSortMode.NotSortable
        position_code.Width = 5
        ' 
        ' employee_grade
        ' 
        employee_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_grade.DataPropertyName = "employee_grade"
        employee_grade.HeaderText = "Grade"
        employee_grade.Name = "employee_grade"
        employee_grade.ReadOnly = True
        employee_grade.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_grade.Width = 46
        ' 
        ' employee_number
        ' 
        employee_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        employee_number.DataPropertyName = "employee_number"
        employee_number.HeaderText = "Emp. ID"
        employee_number.Name = "employee_number"
        employee_number.ReadOnly = True
        employee_number.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_number.Width = 5
        ' 
        ' employee_fullname
        ' 
        employee_fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_fullname.DataPropertyName = "employee_fullname"
        employee_fullname.HeaderText = "Full Name"
        employee_fullname.Name = "employee_fullname"
        employee_fullname.ReadOnly = True
        employee_fullname.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_fullname.Width = 60
        ' 
        ' employee_nickname
        ' 
        employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        employee_nickname.DataPropertyName = "employee_nickname"
        employee_nickname.HeaderText = "Nicname"
        employee_nickname.Name = "employee_nickname"
        employee_nickname.ReadOnly = True
        employee_nickname.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_nickname.Width = 5
        ' 
        ' employee_contracttype
        ' 
        employee_contracttype.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_contracttype.DataPropertyName = "employee_contracttype"
        employee_contracttype.HeaderText = "Contract Type"
        employee_contracttype.Name = "employee_contracttype"
        employee_contracttype.ReadOnly = True
        employee_contracttype.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_contracttype.Width = 82
        ' 
        ' employee_gender
        ' 
        employee_gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        employee_gender.DataPropertyName = "employee_gender"
        employee_gender.HeaderText = "Gender"
        employee_gender.Name = "employee_gender"
        employee_gender.ReadOnly = True
        employee_gender.SortMode = DataGridViewColumnSortMode.Programmatic
        employee_gender.Width = 72
        ' 
        ' employee_active
        ' 
        employee_active.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        employee_active.DataPropertyName = "employee_active"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        employee_active.DefaultCellStyle = DataGridViewCellStyle3
        employee_active.HeaderText = "Active"
        employee_active.Name = "employee_active"
        employee_active.ReadOnly = True
        employee_active.Resizable = DataGridViewTriState.True
        employee_active.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' EPLS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "EPLS"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnEPLS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnEPLS As dgn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents departement_code As DataGridViewTextBoxColumn
    Friend WithEvents position_code As DataGridViewTextBoxColumn
    Friend WithEvents employee_grade As DataGridViewTextBoxColumn
    Friend WithEvents employee_number As DataGridViewTextBoxColumn
    Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
    Friend WithEvents employee_nickname As DataGridViewTextBoxColumn
    Friend WithEvents employee_contracttype As DataGridViewTextBoxColumn
    Friend WithEvents employee_gender As DataGridViewTextBoxColumn
    Friend WithEvents employee_active As DataGridViewTextBoxColumn
End Class
