<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dummy_Editor
    Inherits CMCv.Std_Fo

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
        Btn1 = New CMCv.btn(components)
        Btn2 = New CMCv.btn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn2)
        PnlBottomButton.Controls.Add(Btn1)
        PnlBottomButton.Location = New Point(0, 412)
        PnlBottomButton.Size = New Size(766, 58)
        PnlBottomButton.Controls.SetChildIndex(Btn1, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn2, 0)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Margin = New Padding(5, 0, 5, 0)
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Margin = New Padding(5, 0, 5, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(766, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Size = New Size(766, 470)
        ' 
        ' Btn1
        ' 
        Btn1.BackColor = Color.RoyalBlue
        Btn1.Cursor = Cursors.Hand
        Btn1.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        Btn1.FlatAppearance.BorderSize = 2
        Btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        Btn1.FlatStyle = FlatStyle.Flat
        Btn1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn1.ForeColor = Color.White
        Btn1.Location = New Point(512, 8)
        Btn1.Margin = New Padding(4, 3, 4, 3)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(117, 46)
        Btn1.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Default
        Btn1.XOTampilkanFocusBorder = False
        Btn1.XOValidasiSemuaInput = False
        Btn1.XOValidasiSemuaInputTag = Nothing
        Btn1.TabIndex = 1
        Btn1.Text = "Btn1"
        Btn1.UseVisualStyleBackColor = False
        ' 
        ' Btn2
        ' 
        Btn2.BackColor = Color.RoyalBlue
        Btn2.Cursor = Cursors.Hand
        Btn2.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        Btn2.FlatAppearance.BorderSize = 2
        Btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        Btn2.FlatStyle = FlatStyle.Flat
        Btn2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn2.ForeColor = Color.White
        Btn2.Location = New Point(636, 8)
        Btn2.Margin = New Padding(4, 3, 4, 3)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(117, 46)
        Btn2.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Default
        Btn2.XOTampilkanFocusBorder = False
        Btn2.XOValidasiSemuaInput = False
        Btn2.XOValidasiSemuaInputTag = Nothing
        Btn2.TabIndex = 2
        Btn2.Text = "Btn2"
        Btn2.UseVisualStyleBackColor = False
        ' 
        ' Dummy_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(766, 553)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "Dummy_Editor"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Btn1 As CMCv.btn
    Friend WithEvents Btn2 As CMCv.btn

End Class
