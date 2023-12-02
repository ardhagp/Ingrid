Imports CMCv

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyLauncher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        tmrCountdown = New Timer(components)
        BtnLaunch = New btn(components)
        Lbl1 = New lbl(components)
        SuspendLayout()
        ' 
        ' tmrCountdown
        ' 
        tmrCountdown.Interval = 1000
        ' 
        ' BtnLaunch
        ' 
        BtnLaunch.BackColor = Color.LimeGreen
        BtnLaunch.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnLaunch.FlatAppearance.BorderSize = 2
        BtnLaunch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnLaunch.FlatStyle = FlatStyle.Flat
        BtnLaunch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLaunch.ForeColor = Color.White
        BtnLaunch.Location = New Point(138, 381)
        BtnLaunch.Name = "BtnLaunch"
        BtnLaunch.Size = New Size(100, 40)
        BtnLaunch.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnLaunch.SLFTampilkanFocusBorder = False
        BtnLaunch.SLFValidasiSemuaInput = False
        BtnLaunch.SLFValidasiSemuaInputTag = Nothing
        BtnLaunch.TabIndex = 1
        BtnLaunch.Text = "&Launch"
        BtnLaunch.UseVisualStyleBackColor = False
        ' 
        ' Lbl1
        ' 
        Lbl1.BackColor = Color.Transparent
        Lbl1.Font = New Font("Segoe UI", 72.0F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl1.ForeColor = Color.White
        Lbl1.Location = New Point(9, -5)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(368, 128)
        Lbl1.SLFCustomElipsis = False
        Lbl1.TabIndex = 0
        Lbl1.Text = "Ingrid"
        Lbl1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MyLauncher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(377, 450)
        ControlBox = False
        Controls.Add(Lbl1)
        Controls.Add(BtnLaunch)
        FormBorderStyle = FormBorderStyle.None
        Name = "MyLauncher"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tmrCountdown As Timer
    Friend WithEvents BtnLaunch As btn
    Friend WithEvents Lbl1 As lbl
End Class
