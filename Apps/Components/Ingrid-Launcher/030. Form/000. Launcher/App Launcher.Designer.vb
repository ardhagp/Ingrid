<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App_Launcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App_Launcher))
        Lbl1 = New CMCv.lbl(components)
        LblBuild = New CMCv.lbl(components)
        BtnLaunch = New CMCv.btn(components)
        Lbl3 = New CMCv.lbl(components)
        Lbl4 = New CMCv.lbl(components)
        CboApplication = New CMCv.cbo(components)
        tmrCountdown = New Timer(components)
        Lbl5 = New CMCv.lbl(components)
        LblCountdown = New CMCv.lbl(components)
        SuspendLayout()
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
        ' LblBuild
        ' 
        LblBuild.BackColor = Color.Transparent
        LblBuild.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        LblBuild.ForeColor = Color.White
        LblBuild.Location = New Point(205, 112)
        LblBuild.Name = "LblBuild"
        LblBuild.Size = New Size(120, 51)
        LblBuild.SLFCustomElipsis = False
        LblBuild.TabIndex = 1
        LblBuild.Text = "Build"
        LblBuild.TextAlign = ContentAlignment.TopRight
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
        ' Lbl3
        ' 
        Lbl3.BackColor = Color.White
        Lbl3.BorderStyle = BorderStyle.Fixed3D
        Lbl3.Font = New Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(205, 110)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(160, 2)
        Lbl3.SLFCustomElipsis = False
        Lbl3.TabIndex = 3
        ' 
        ' Lbl4
        ' 
        Lbl4.BackColor = Color.White
        Lbl4.BorderStyle = BorderStyle.Fixed3D
        Lbl4.Font = New Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl4.Location = New Point(9, 110)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Size(126, 2)
        Lbl4.SLFCustomElipsis = False
        Lbl4.TabIndex = 4
        ' 
        ' CboApplication
        ' 
        CboApplication.DropDownStyle = ComboBoxStyle.DropDownList
        CboApplication.FlatStyle = FlatStyle.Flat
        CboApplication.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboApplication.FormattingEnabled = True
        CboApplication.Location = New Point(107, 302)
        CboApplication.Name = "CboApplication"
        CboApplication.Size = New Size(93, 29)
        CboApplication.TabIndex = 0
        ' 
        ' tmrCountdown
        ' 
        tmrCountdown.Interval = 1000
        ' 
        ' Lbl5
        ' 
        Lbl5.BackColor = Color.Transparent
        Lbl5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl5.ForeColor = Color.White
        Lbl5.Location = New Point(33, 305)
        Lbl5.Name = "Lbl5"
        Lbl5.Size = New Size(74, 21)
        Lbl5.SLFCustomElipsis = False
        Lbl5.TabIndex = 6
        Lbl5.Text = "Opening"
        ' 
        ' LblCountdown
        ' 
        LblCountdown.BackColor = Color.Transparent
        LblCountdown.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblCountdown.ForeColor = Color.White
        LblCountdown.Location = New Point(206, 305)
        LblCountdown.Name = "LblCountdown"
        LblCountdown.Size = New Size(144, 21)
        LblCountdown.SLFCustomElipsis = False
        LblCountdown.TabIndex = 7
        LblCountdown.Text = "app in 3 seconds..."
        ' 
        ' App_Launcher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(377, 450)
        ControlBox = False
        Controls.Add(LblCountdown)
        Controls.Add(Lbl5)
        Controls.Add(CboApplication)
        Controls.Add(Lbl4)
        Controls.Add(Lbl3)
        Controls.Add(LblBuild)
        Controls.Add(BtnLaunch)
        Controls.Add(Lbl1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "App_Launcher"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
    End Sub

    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents LblBuild As CMCv.lbl
    Friend WithEvents BtnLaunch As CMCv.btn
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents CboApplication As CMCv.cbo
    Friend WithEvents tmrCountdown As Timer
    Friend WithEvents Lbl5 As CMCv.lbl
    Friend WithEvents LblCountdown As CMCv.lbl
End Class
