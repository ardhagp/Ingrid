﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorReporting
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmErrorReporting))
        BtnClose = New btn(components)
        Tbctl1 = New tbctl(components)
        tp_ApplicationFault = New Windows.Forms.TabPage()
        Lbl4 = New lbl(components)
        TxtAppBuild = New txt(components)
        TxtErrorNumber = New txt(components)
        Lbl3 = New lbl(components)
        TxtErrorMessage = New txt(components)
        Lbl2 = New lbl(components)
        TxtErrorType = New txt(components)
        Lbl1 = New lbl(components)
        tp_SystemInformation = New Windows.Forms.TabPage()
        ChkErrorReporting = New chk(components)
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
        PnlBottomButton.Location = New Drawing.Point(0, 469)
        PnlBottomButton.Margin = New Windows.Forms.Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Drawing.Size(766, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkErrorReporting, 0)
        ' 
        ' SLFLogo
        ' 
        SLFLogo.BackColor = Drawing.Color.Red
        SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Drawing.Image)
        SLFLogo.Margin = New Windows.Forms.Padding(5, 3, 5, 3)
        SLFLogo.Size = New Drawing.Size(59, 59)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Windows.Forms.Padding(5, 3, 5, 3)
        pnl_.Size = New Drawing.Size(766, 68)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Tbctl1)
        SLFPanel.Location = New Drawing.Point(0, 68)
        SLFPanel.Margin = New Windows.Forms.Padding(5, 3, 5, 3)
        SLFPanel.Size = New Drawing.Size(766, 527)
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
        BtnClose.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New Drawing.Point(635, 8)
        BtnClose.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Drawing.Size(117, 46)
        BtnClose.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.SLFTampilkanFocusBorder = False
        BtnClose.SLFValidasiSemuaInput = False
        BtnClose.SLFValidasiSemuaInputTag = Nothing
        BtnClose.TabIndex = 0
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' Tbctl1
        ' 
        Tbctl1.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        Tbctl1.Controls.Add(tp_ApplicationFault)
        Tbctl1.Controls.Add(tp_SystemInformation)
        Tbctl1.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Tbctl1.Location = New Drawing.Point(14, 7)
        Tbctl1.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        Tbctl1.Name = "Tbctl1"
        Tbctl1.SelectedIndex = 0
        Tbctl1.Size = New Drawing.Size(738, 460)
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
        tp_ApplicationFault.Location = New Drawing.Point(4, 30)
        tp_ApplicationFault.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        tp_ApplicationFault.Name = "tp_ApplicationFault"
        tp_ApplicationFault.Padding = New Windows.Forms.Padding(4, 3, 4, 3)
        tp_ApplicationFault.Size = New Drawing.Size(730, 426)
        tp_ApplicationFault.TabIndex = 0
        tp_ApplicationFault.Text = "Application Fault"
        tp_ApplicationFault.UseVisualStyleBackColor = True
        ' 
        ' Lbl4
        ' 
        Lbl4.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        Lbl4.AutoSize = True
        Lbl4.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl4.Location = New Drawing.Point(296, 353)
        Lbl4.Margin = New Windows.Forms.Padding(4, 0, 4, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Drawing.Size(134, 21)
        Lbl4.SLFCustomElipsis = False
        Lbl4.TabIndex = 7
        Lbl4.Text = "Application Build :"
        ' 
        ' TxtAppBuild
        ' 
        TxtAppBuild.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        TxtAppBuild.BackColor = Drawing.Color.White
        TxtAppBuild.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtAppBuild.Location = New Drawing.Point(296, 380)
        TxtAppBuild.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        TxtAppBuild.MaxLength = 255
        TxtAppBuild.Name = "TxtAppBuild"
        TxtAppBuild.ReadOnly = True
        TxtAppBuild.Size = New Drawing.Size(240, 29)
        TxtAppBuild.SLFAutoTrim = False
        TxtAppBuild.SLFHarusDiisi = False
        TxtAppBuild.SLFHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtAppBuild.SLFHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtAppBuild.SLFHightlightSaatFokus = False
        TxtAppBuild.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtAppBuild.SLFIsBlank = True
        TxtAppBuild.SLFIsSearchBox = False
        TxtAppBuild.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtAppBuild.SLFPilihSemuaSaatFokus = False
        TxtAppBuild.SLFPwdLengthMin = 8
        TxtAppBuild.SLFPwdStrengthCalculate = False
        TxtAppBuild.SLFPwdStrengthScore = 0
        TxtAppBuild.SLFPwdStrengthText = Nothing
        TxtAppBuild.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtAppBuild.SLFSearchBoxText = "Type then press Enter"
        TxtAppBuild.SLFSQLText = Nothing
        TxtAppBuild.SLFTanpaSpasi = False
        TxtAppBuild.SLFValidasiField = Nothing
        TxtAppBuild.TabIndex = 6
        TxtAppBuild.Tag = "txt"
        ' 
        ' TxtErrorNumber
        ' 
        TxtErrorNumber.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        TxtErrorNumber.BackColor = Drawing.Color.White
        TxtErrorNumber.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorNumber.Location = New Drawing.Point(7, 380)
        TxtErrorNumber.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        TxtErrorNumber.MaxLength = 255
        TxtErrorNumber.Name = "TxtErrorNumber"
        TxtErrorNumber.ReadOnly = True
        TxtErrorNumber.Size = New Drawing.Size(282, 29)
        TxtErrorNumber.SLFAutoTrim = False
        TxtErrorNumber.SLFHarusDiisi = False
        TxtErrorNumber.SLFHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorNumber.SLFHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorNumber.SLFHightlightSaatFokus = False
        TxtErrorNumber.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorNumber.SLFIsBlank = True
        TxtErrorNumber.SLFIsSearchBox = False
        TxtErrorNumber.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorNumber.SLFPilihSemuaSaatFokus = False
        TxtErrorNumber.SLFPwdLengthMin = 8
        TxtErrorNumber.SLFPwdStrengthCalculate = False
        TxtErrorNumber.SLFPwdStrengthScore = 0
        TxtErrorNumber.SLFPwdStrengthText = Nothing
        TxtErrorNumber.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtErrorNumber.SLFSearchBoxText = "Type then press Enter"
        TxtErrorNumber.SLFSQLText = Nothing
        TxtErrorNumber.SLFTanpaSpasi = False
        TxtErrorNumber.SLFValidasiField = Nothing
        TxtErrorNumber.TabIndex = 5
        TxtErrorNumber.Tag = "txt"
        ' 
        ' Lbl3
        ' 
        Lbl3.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        Lbl3.AutoSize = True
        Lbl3.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl3.Location = New Drawing.Point(7, 353)
        Lbl3.Margin = New Windows.Forms.Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Drawing.Size(114, 21)
        Lbl3.SLFCustomElipsis = False
        Lbl3.TabIndex = 4
        Lbl3.Text = "Error Number :"
        ' 
        ' TxtErrorMessage
        ' 
        TxtErrorMessage.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        TxtErrorMessage.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorMessage.Location = New Drawing.Point(7, 96)
        TxtErrorMessage.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        TxtErrorMessage.MaxLength = 255
        TxtErrorMessage.Multiline = True
        TxtErrorMessage.Name = "TxtErrorMessage"
        TxtErrorMessage.Size = New Drawing.Size(713, 253)
        TxtErrorMessage.SLFAutoTrim = False
        TxtErrorMessage.SLFHarusDiisi = False
        TxtErrorMessage.SLFHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorMessage.SLFHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorMessage.SLFHightlightSaatFokus = False
        TxtErrorMessage.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorMessage.SLFIsBlank = True
        TxtErrorMessage.SLFIsSearchBox = False
        TxtErrorMessage.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorMessage.SLFPilihSemuaSaatFokus = False
        TxtErrorMessage.SLFPwdLengthMin = 8
        TxtErrorMessage.SLFPwdStrengthCalculate = False
        TxtErrorMessage.SLFPwdStrengthScore = 0
        TxtErrorMessage.SLFPwdStrengthText = Nothing
        TxtErrorMessage.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtErrorMessage.SLFSearchBoxText = "Type then press Enter"
        TxtErrorMessage.SLFSQLText = Nothing
        TxtErrorMessage.SLFTanpaSpasi = False
        TxtErrorMessage.SLFValidasiField = Nothing
        TxtErrorMessage.TabIndex = 3
        TxtErrorMessage.Tag = "txt"
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl2.Location = New Drawing.Point(7, 68)
        Lbl2.Margin = New Windows.Forms.Padding(4, 0, 4, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Drawing.Size(78, 21)
        Lbl2.SLFCustomElipsis = False
        Lbl2.TabIndex = 2
        Lbl2.Text = "Message :"
        ' 
        ' TxtErrorType
        ' 
        TxtErrorType.BackColor = Drawing.Color.White
        TxtErrorType.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorType.Location = New Drawing.Point(7, 31)
        TxtErrorType.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        TxtErrorType.MaxLength = 255
        TxtErrorType.Name = "TxtErrorType"
        TxtErrorType.ReadOnly = True
        TxtErrorType.Size = New Drawing.Size(282, 29)
        TxtErrorType.SLFAutoTrim = False
        TxtErrorType.SLFHarusDiisi = False
        TxtErrorType.SLFHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorType.SLFHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorType.SLFHightlightSaatFokus = False
        TxtErrorType.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorType.SLFIsBlank = True
        TxtErrorType.SLFIsSearchBox = False
        TxtErrorType.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorType.SLFPilihSemuaSaatFokus = False
        TxtErrorType.SLFPwdLengthMin = 8
        TxtErrorType.SLFPwdStrengthCalculate = False
        TxtErrorType.SLFPwdStrengthScore = 0
        TxtErrorType.SLFPwdStrengthText = Nothing
        TxtErrorType.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtErrorType.SLFSearchBoxText = "Type then press Enter"
        TxtErrorType.SLFSQLText = Nothing
        TxtErrorType.SLFTanpaSpasi = False
        TxtErrorType.SLFValidasiField = Nothing
        TxtErrorType.TabIndex = 1
        TxtErrorType.Tag = "txt"
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl1.Location = New Drawing.Point(7, 3)
        Lbl1.Margin = New Windows.Forms.Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Drawing.Size(49, 21)
        Lbl1.SLFCustomElipsis = False
        Lbl1.TabIndex = 0
        Lbl1.Text = "Type :"
        ' 
        ' tp_SystemInformation
        ' 
        tp_SystemInformation.Location = New Drawing.Point(4, 30)
        tp_SystemInformation.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        tp_SystemInformation.Name = "tp_SystemInformation"
        tp_SystemInformation.Padding = New Windows.Forms.Padding(4, 3, 4, 3)
        tp_SystemInformation.Size = New Drawing.Size(730, 426)
        tp_SystemInformation.TabIndex = 1
        tp_SystemInformation.Text = "Your System Information"
        tp_SystemInformation.UseVisualStyleBackColor = True
        ' 
        ' ChkErrorReporting
        ' 
        ChkErrorReporting.AutoSize = True
        ChkErrorReporting.BackColor = Drawing.Color.Transparent
        ChkErrorReporting.FlatStyle = Windows.Forms.FlatStyle.Flat
        ChkErrorReporting.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        ChkErrorReporting.Location = New Drawing.Point(348, 17)
        ChkErrorReporting.Margin = New Windows.Forms.Padding(4, 3, 4, 3)
        ChkErrorReporting.Name = "ChkErrorReporting"
        ChkErrorReporting.Size = New Drawing.Size(241, 25)
        ChkErrorReporting.TabIndex = 1
        ChkErrorReporting.Text = "Report this error to Developer?"
        ChkErrorReporting.TextAlign = Drawing.ContentAlignment.MiddleRight
        ChkErrorReporting.UseVisualStyleBackColor = True
        ChkErrorReporting.Visible = False
        ' 
        ' frmErrorReporting
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
        ClientSize = New Drawing.Size(766, 617)
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        KeyPreview = True
        Margin = New Windows.Forms.Padding(7, 3, 7, 3)
        MaximumSize = New Drawing.Size(782, 656)
        Name = "frmErrorReporting"
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
