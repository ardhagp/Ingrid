<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmERerrorreporting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmERerrorreporting))
        BtnClose = New Btn(components)
        Tbctl1 = New Tbctl(components)
        tp_ApplicationFault = New Windows.Forms.TabPage()
        Lbl4 = New Lbl(components)
        TxtAppBuild = New Txt(components)
        TxtErrorNumber = New Txt(components)
        Lbl3 = New Lbl(components)
        TxtErrorMessage = New Txt(components)
        Lbl2 = New Lbl(components)
        TxtErrorType = New Txt(components)
        Lbl1 = New Lbl(components)
        tp_SystemInformation = New Windows.Forms.TabPage()
        ChkErrorReporting = New Chk(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Tbctl1.SuspendLayout()
        tp_ApplicationFault.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkErrorReporting)
        PnlBottomButton.Controls.Add(BtnClose)
        PnlBottomButton.Location = New System.Drawing.Point(0, 469)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New System.Drawing.Size(766, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkErrorReporting, 0)
        ' 
        ' SLFLogo
        ' 
        SLFLogo.BackColor = Drawing.Color.Red
        SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Drawing.Image)
        SLFLogo.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        SLFLogo.Size = New System.Drawing.Size(59, 59)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        pnl_.Size = New System.Drawing.Size(766, 68)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Tbctl1)
        SLFPanel.Location = New System.Drawing.Point(0, 68)
        SLFPanel.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        SLFPanel.Size = New System.Drawing.Size(766, 527)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Tbctl1, 0)
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.Red
        BtnClose.Cursor = Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New System.Drawing.Point(635, 8)
        BtnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(117, 46)
        BtnClose.TabIndex = 0
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.XOTampilkanFocusBorder = False
        BtnClose.XOValidasiSemuaInput = False
        BtnClose.XOValidasiSemuaInputTag = Nothing
        ' 
        ' Tbctl1
        ' 
        Tbctl1.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        Tbctl1.Controls.Add(tp_ApplicationFault)
        Tbctl1.Controls.Add(tp_SystemInformation)
        Tbctl1.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Tbctl1.Location = New System.Drawing.Point(14, 7)
        Tbctl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Tbctl1.Name = "Tbctl1"
        Tbctl1.SelectedIndex = 0
        Tbctl1.Size = New System.Drawing.Size(738, 460)
        Tbctl1.TabIndex = 1
        ' 
        ' tp_ApplicationFault
        ' 
        tp_ApplicationFault.Controls.Add(Lbl4)
        tp_ApplicationFault.Controls.Add(TxtAppBuild)
        tp_ApplicationFault.Controls.Add(TxtErrorNumber)
        tp_ApplicationFault.Controls.Add(Lbl3)
        tp_ApplicationFault.Controls.Add(TxtErrorMessage)
        tp_ApplicationFault.Controls.Add(Lbl2)
        tp_ApplicationFault.Controls.Add(TxtErrorType)
        tp_ApplicationFault.Controls.Add(Lbl1)
        tp_ApplicationFault.Location = New System.Drawing.Point(4, 30)
        tp_ApplicationFault.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        tp_ApplicationFault.Name = "tp_ApplicationFault"
        tp_ApplicationFault.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        tp_ApplicationFault.Size = New System.Drawing.Size(730, 426)
        tp_ApplicationFault.TabIndex = 0
        tp_ApplicationFault.Text = "Application Fault"
        tp_ApplicationFault.UseVisualStyleBackColor = True
        ' 
        ' Lbl4
        ' 
        Lbl4.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        Lbl4.AutoSize = True
        Lbl4.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl4.Location = New System.Drawing.Point(296, 353)
        Lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New System.Drawing.Size(134, 21)
        Lbl4.TabIndex = 7
        Lbl4.Text = "Application Build :"
        Lbl4.XOCustomElipsis = False
        ' 
        ' TxtAppBuild
        ' 
        TxtAppBuild.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        TxtAppBuild.BackColor = Drawing.Color.White
        TxtAppBuild.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtAppBuild.Location = New System.Drawing.Point(296, 380)
        TxtAppBuild.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        TxtAppBuild.MaxLength = 255
        TxtAppBuild.Name = "TxtAppBuild"
        TxtAppBuild.ReadOnly = True
        TxtAppBuild.Size = New System.Drawing.Size(240, 29)
        TxtAppBuild.TabIndex = 6
        TxtAppBuild.Tag = "txt"
        TxtAppBuild.XOAutoTrim = False
        TxtAppBuild.XOHarusDiisi = False
        TxtAppBuild.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtAppBuild.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtAppBuild.XOHightlightSaatFokus = False
        TxtAppBuild.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtAppBuild.XOIsBlank = True
        TxtAppBuild.XOIsSearchBox = False
        TxtAppBuild.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtAppBuild.XOPilihSemuaSaatFokus = False
        TxtAppBuild.XOPwdLengthMin = 8
        TxtAppBuild.XOPwdStrengthCalculate = False
        TxtAppBuild.XOPwdStrengthScore = 0
        TxtAppBuild.XOPwdStrengthText = Nothing
        TxtAppBuild.XORestriction = ControlCodeBase.enuRestriction.None
        TxtAppBuild.XOSearchBoxText = "Type then press Enter"
        TxtAppBuild.XOSQLText = Nothing
        TxtAppBuild.XOTanpaSpasi = False
        TxtAppBuild.XOValidasiField = Nothing
        ' 
        ' TxtErrorNumber
        ' 
        TxtErrorNumber.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        TxtErrorNumber.BackColor = Drawing.Color.White
        TxtErrorNumber.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorNumber.Location = New System.Drawing.Point(7, 380)
        TxtErrorNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        TxtErrorNumber.MaxLength = 255
        TxtErrorNumber.Name = "TxtErrorNumber"
        TxtErrorNumber.ReadOnly = True
        TxtErrorNumber.Size = New System.Drawing.Size(282, 29)
        TxtErrorNumber.TabIndex = 5
        TxtErrorNumber.Tag = "txt"
        TxtErrorNumber.XOAutoTrim = False
        TxtErrorNumber.XOHarusDiisi = False
        TxtErrorNumber.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorNumber.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorNumber.XOHightlightSaatFokus = False
        TxtErrorNumber.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorNumber.XOIsBlank = True
        TxtErrorNumber.XOIsSearchBox = False
        TxtErrorNumber.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorNumber.XOPilihSemuaSaatFokus = False
        TxtErrorNumber.XOPwdLengthMin = 8
        TxtErrorNumber.XOPwdStrengthCalculate = False
        TxtErrorNumber.XOPwdStrengthScore = 0
        TxtErrorNumber.XOPwdStrengthText = Nothing
        TxtErrorNumber.XORestriction = ControlCodeBase.enuRestriction.None
        TxtErrorNumber.XOSearchBoxText = "Type then press Enter"
        TxtErrorNumber.XOSQLText = Nothing
        TxtErrorNumber.XOTanpaSpasi = False
        TxtErrorNumber.XOValidasiField = Nothing
        ' 
        ' Lbl3
        ' 
        Lbl3.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        Lbl3.AutoSize = True
        Lbl3.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl3.Location = New System.Drawing.Point(7, 353)
        Lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New System.Drawing.Size(114, 21)
        Lbl3.TabIndex = 4
        Lbl3.Text = "Error Number :"
        Lbl3.XOCustomElipsis = False
        ' 
        ' TxtErrorMessage
        ' 
        TxtErrorMessage.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        TxtErrorMessage.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorMessage.Location = New System.Drawing.Point(7, 96)
        TxtErrorMessage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        TxtErrorMessage.MaxLength = 255
        TxtErrorMessage.Multiline = True
        TxtErrorMessage.Name = "TxtErrorMessage"
        TxtErrorMessage.Size = New System.Drawing.Size(713, 253)
        TxtErrorMessage.TabIndex = 3
        TxtErrorMessage.Tag = "txt"
        TxtErrorMessage.XOAutoTrim = False
        TxtErrorMessage.XOHarusDiisi = False
        TxtErrorMessage.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorMessage.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorMessage.XOHightlightSaatFokus = False
        TxtErrorMessage.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorMessage.XOIsBlank = True
        TxtErrorMessage.XOIsSearchBox = False
        TxtErrorMessage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorMessage.XOPilihSemuaSaatFokus = False
        TxtErrorMessage.XOPwdLengthMin = 8
        TxtErrorMessage.XOPwdStrengthCalculate = False
        TxtErrorMessage.XOPwdStrengthScore = 0
        TxtErrorMessage.XOPwdStrengthText = Nothing
        TxtErrorMessage.XORestriction = ControlCodeBase.enuRestriction.None
        TxtErrorMessage.XOSearchBoxText = "Type then press Enter"
        TxtErrorMessage.XOSQLText = Nothing
        TxtErrorMessage.XOTanpaSpasi = False
        TxtErrorMessage.XOValidasiField = Nothing
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl2.Location = New System.Drawing.Point(7, 68)
        Lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New System.Drawing.Size(78, 21)
        Lbl2.TabIndex = 2
        Lbl2.Text = "Message :"
        Lbl2.XOCustomElipsis = False
        ' 
        ' TxtErrorType
        ' 
        TxtErrorType.BackColor = Drawing.Color.White
        TxtErrorType.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorType.Location = New System.Drawing.Point(7, 31)
        TxtErrorType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        TxtErrorType.MaxLength = 255
        TxtErrorType.Name = "TxtErrorType"
        TxtErrorType.ReadOnly = True
        TxtErrorType.Size = New System.Drawing.Size(282, 29)
        TxtErrorType.TabIndex = 1
        TxtErrorType.Tag = "txt"
        TxtErrorType.XOAutoTrim = False
        TxtErrorType.XOHarusDiisi = False
        TxtErrorType.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorType.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorType.XOHightlightSaatFokus = False
        TxtErrorType.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorType.XOIsBlank = True
        TxtErrorType.XOIsSearchBox = False
        TxtErrorType.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorType.XOPilihSemuaSaatFokus = False
        TxtErrorType.XOPwdLengthMin = 8
        TxtErrorType.XOPwdStrengthCalculate = False
        TxtErrorType.XOPwdStrengthScore = 0
        TxtErrorType.XOPwdStrengthText = Nothing
        TxtErrorType.XORestriction = ControlCodeBase.enuRestriction.None
        TxtErrorType.XOSearchBoxText = "Type then press Enter"
        TxtErrorType.XOSQLText = Nothing
        TxtErrorType.XOTanpaSpasi = False
        TxtErrorType.XOValidasiField = Nothing
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl1.Location = New System.Drawing.Point(7, 3)
        Lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New System.Drawing.Size(49, 21)
        Lbl1.TabIndex = 0
        Lbl1.Text = "Type :"
        Lbl1.XOCustomElipsis = False
        ' 
        ' tp_SystemInformation
        ' 
        tp_SystemInformation.Location = New System.Drawing.Point(4, 30)
        tp_SystemInformation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        tp_SystemInformation.Name = "tp_SystemInformation"
        tp_SystemInformation.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        tp_SystemInformation.Size = New System.Drawing.Size(730, 426)
        tp_SystemInformation.TabIndex = 1
        tp_SystemInformation.Text = "Your System Information"
        tp_SystemInformation.UseVisualStyleBackColor = True
        ' 
        ' ChkErrorReporting
        ' 
        ChkErrorReporting.AutoSize = True
        ChkErrorReporting.BackColor = Drawing.Color.Transparent
        ChkErrorReporting.FlatStyle = Windows.Forms.FlatStyle.Flat
        ChkErrorReporting.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        ChkErrorReporting.Location = New System.Drawing.Point(348, 17)
        ChkErrorReporting.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        ChkErrorReporting.Name = "ChkErrorReporting"
        ChkErrorReporting.Size = New System.Drawing.Size(241, 25)
        ChkErrorReporting.TabIndex = 1
        ChkErrorReporting.Text = "Report this error to Developer?"
        ChkErrorReporting.TextAlign = Drawing.ContentAlignment.MiddleRight
        ChkErrorReporting.UseVisualStyleBackColor = True
        ChkErrorReporting.Visible = False
        ' 
        ' frmERerrorreporting
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        ClientSize = New System.Drawing.Size(766, 617)
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        MaximumSize = New System.Drawing.Size(782, 656)
        Name = "frmERerrorreporting"
        ShowInTaskbar = True
        TopMost = True
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Tbctl1.ResumeLayout(False)
        tp_ApplicationFault.ResumeLayout(False)
        tp_ApplicationFault.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents Tbctl1 As CMCv.tbctl
    Friend WithEvents tp_ApplicationFault As System.Windows.Forms.TabPage
    Friend WithEvents tp_SystemInformation As System.Windows.Forms.TabPage
    Friend WithEvents TxtErrorNumber As CMCv.txt
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents TxtErrorMessage As CMCv.txt
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents TxtErrorType As CMCv.txt
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents TxtAppBuild As CMCv.txt
    Friend WithEvents ChkErrorReporting As CMCv.chk

End Class
