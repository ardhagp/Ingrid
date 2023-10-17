Imports Microsoft.Reporting.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rpt_Bsc
    Inherits CMCv.Std_Fo

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
        BtnClose = New btn(components)
        Rv_ = New ReportViewer()
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnClose)
        PnlBottomButton.Location = New Drawing.Point(0, 0)
        PnlBottomButton.Size = New Drawing.Size(0, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Rv_)
        SLFPanel.Dock = Windows.Forms.DockStyle.None
        SLFPanel.Location = New Drawing.Point(0, 62)
        SLFPanel.Size = New Drawing.Size(0, 58)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Rv_, 0)
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.RoyalBlue
        BtnClose.Cursor = Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnClose.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New Drawing.Point(-131, 7)
        BtnClose.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Drawing.Size(117, 46)
        BtnClose.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnClose.SLFTampilkanFocusBorder = False
        BtnClose.SLFValidasiSemuaInput = False
        BtnClose.SLFValidasiSemuaInputTag = Nothing
        BtnClose.TabIndex = 1
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' Rv_
        ' 
        Rv_.Dock = Windows.Forms.DockStyle.Fill
        Rv_.DocumentMapWidth = 1
        Rv_.Location = New Drawing.Point(0, 0)
        Rv_.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        Rv_.Name = "Rv_"
        Rv_.ServerReport.BearerToken = Nothing
        Rv_.Size = New Drawing.Size(0, 0)
        Rv_.TabIndex = 996
        ' 
        ' Rpt_Bsc
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7.0F, 15.0F)
        ClientSize = New Drawing.Size(915, 647)
        KeyPreview = True
        Margin = New Windows.Forms.Padding(7, 3, 7, 3)
        Name = "Rpt_Bsc"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnClose As btn
    ' TODO: Microsoft.Reporting.WinForms.ReportViewer no longer supported.
    Public WithEvents Rv_ As ReportViewer 'Microsoft.Reporting.WinForms.ReportViewer
End Class
