<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONN
    Inherits CMCv.Std_Fi_Fo

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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CONN))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnConnection = New dgn(components)
        id = New DataGridViewTextBoxColumn()
        connectionname = New DataGridViewTextBoxColumn()
        serveraddress = New DataGridViewTextBoxColumn()
        serverport = New DataGridViewTextBoxColumn()
        defaultconnection = New DataGridViewCheckBoxColumn()
        spring = New DataGridViewTextBoxColumn()
        Btn_Close = New btn(components)
        PnlBottomButton.SuspendLayout()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnConnection, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn_Close)
        PnlBottomButton.Location = New Point(0, 499)
        PnlBottomButton.Controls.SetChildIndex(Btn_Close, 0)
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
        ' SLFLogo
        ' 
        SLFLogo.BackColor = Color.Transparent
        SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Image)
        SLFLogo.Margin = New Padding(5, 3, 5, 3)
        SLFLogo.Size = New Size(59, 59)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Margin = New Padding(5, 0, 5, 0)
        SLFSubNamaForm.Size = New Size(207, 15)
        SLFSubNamaForm.Text = "Configure Ingrid database connection"
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Margin = New Padding(5, 0, 5, 0)
        SLFNamaForm.Size = New Size(244, 32)
        SLFNamaForm.Text = "Connection Settings"
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(915, 68)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(DgnConnection)
        SLFPanel.Location = New Point(0, 68)
        SLFPanel.Size = New Size(915, 557)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(DgnConnection, 0)
        ' 
        ' DgnConnection
        ' 
        DgnConnection.AllowUserToAddRows = False
        DgnConnection.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(244), CByte(237), CByte(153))
        DgnConnection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DgnConnection.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnConnection.BorderStyle = BorderStyle.None
        DgnConnection.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnConnection.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnConnection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnConnection.ColumnHeadersHeight = 43
        DgnConnection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnConnection.Columns.AddRange(New DataGridViewColumn() {id, connectionname, serveraddress, serverport, defaultconnection, spring})
        DgnConnection.Dock = DockStyle.Fill
        DgnConnection.EnableHeadersVisualStyles = False
        DgnConnection.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnConnection.Location = New Point(0, 53)
        DgnConnection.Margin = New Padding(4, 3, 4, 3)
        DgnConnection.Name = "DgnConnection"
        DgnConnection.ReadOnly = True
        DgnConnection.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnConnection.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnConnection.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnConnection.Size = New Size(915, 446)
        DgnConnection.XOGroupFirstRows = False
        DgnConnection.XOGunakanNomorBaris = True
        DgnConnection.StandardTab = True
        DgnConnection.TabIndex = 997
        ' 
        ' id
        ' 
        id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        id.DataPropertyName = "ID"
        id.HeaderText = "ID"
        id.Name = "id"
        id.ReadOnly = True
        id.Visible = False
        ' 
        ' connectionname
        ' 
        connectionname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        connectionname.DataPropertyName = "CONNECTIONNAME"
        connectionname.HeaderText = "CONNECTION NAME"
        connectionname.Name = "connectionname"
        connectionname.ReadOnly = True
        connectionname.Width = 132
        ' 
        ' serveraddress
        ' 
        serveraddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        serveraddress.DataPropertyName = "SERVERADDRESS"
        serveraddress.HeaderText = "SERVER ADDRESS"
        serveraddress.Name = "serveraddress"
        serveraddress.ReadOnly = True
        serveraddress.Width = 125
        ' 
        ' serverport
        ' 
        serverport.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        serverport.DataPropertyName = "SERVERPORT"
        serverport.HeaderText = "PORT"
        serverport.Name = "serverport"
        serverport.ReadOnly = True
        serverport.Width = 61
        ' 
        ' defaultconnection
        ' 
        defaultconnection.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        defaultconnection.DataPropertyName = "DEFAULTCONNECTION"
        defaultconnection.FalseValue = "0"
        defaultconnection.HeaderText = "DEFAULT"
        defaultconnection.Name = "defaultconnection"
        defaultconnection.ReadOnly = True
        defaultconnection.Resizable = DataGridViewTriState.True
        defaultconnection.SortMode = DataGridViewColumnSortMode.Automatic
        defaultconnection.TrueValue = "1"
        defaultconnection.Width = 79
        ' 
        ' spring
        ' 
        spring.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        spring.HeaderText = ""
        spring.Name = "spring"
        spring.ReadOnly = True
        ' 
        ' Btn_Close
        ' 
        Btn_Close.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn_Close.BackColor = Color.Red
        Btn_Close.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        Btn_Close.FlatAppearance.BorderSize = 2
        Btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        Btn_Close.FlatStyle = FlatStyle.Flat
        Btn_Close.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Close.ForeColor = Color.White
        Btn_Close.Location = New Point(803, 11)
        Btn_Close.Name = "Btn_Close"
        Btn_Close.Size = New Size(100, 40)
        Btn_Close.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        Btn_Close.XOTampilkanFocusBorder = False
        Btn_Close.XOValidasiSemuaInput = False
        Btn_Close.XOValidasiSemuaInputTag = Nothing
        Btn_Close.TabIndex = 1
        Btn_Close.Text = "&Close"
        Btn_Close.UseVisualStyleBackColor = False
        ' 
        ' CONN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        Margin = New Padding(8, 3, 8, 3)
        Name = "CONN"
        StartPosition = FormStartPosition.CenterScreen
        PnlBottomButton.ResumeLayout(False)
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnConnection, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DgnConnection As dgn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents connectionname As DataGridViewTextBoxColumn
    Friend WithEvents serveraddress As DataGridViewTextBoxColumn
    Friend WithEvents serverport As DataGridViewTextBoxColumn
    Friend WithEvents defaultconnection As DataGridViewCheckBoxColumn
    Friend WithEvents spring As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Close As btn
End Class
