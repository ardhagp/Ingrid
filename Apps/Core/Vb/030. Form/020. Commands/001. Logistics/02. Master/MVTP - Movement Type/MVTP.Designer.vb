<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MVTP
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
        DgnMVTP = New dgn(components)
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnMVTP, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnMVTP)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnMVTP, 0)
        ' 
        ' DgnMVTP
        ' 
        DgnMVTP.AllowUserToAddRows = False
        DgnMVTP.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(198), CByte(231), CByte(151))
        DgnMVTP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnMVTP.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnMVTP.BorderStyle = BorderStyle.None
        DgnMVTP.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnMVTP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnMVTP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnMVTP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgnMVTP.Dock = DockStyle.Fill
        DgnMVTP.EnableHeadersVisualStyles = False
        DgnMVTP.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnMVTP.Location = New Point(0, 53)
        DgnMVTP.Margin = New Padding(4, 3, 4, 3)
        DgnMVTP.Name = "DgnMVTP"
        DgnMVTP.ReadOnly = True
        DgnMVTP.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnMVTP.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnMVTP.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnMVTP.Size = New Size(915, 511)
        DgnMVTP.SLFGroupFirstRows = False
        DgnMVTP.SLFGunakanNomorBaris = False
        DgnMVTP.StandardTab = True
        DgnMVTP.TabIndex = 802
        ' 
        ' MVTP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "MVTP"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnMVTP, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnMVTP As dgn

End Class
