<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESET
    Inherits CMCv.Std_Fo

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
        LblNotification = New lbl(components)
        Txt_Confirmation = New txt(components)
        BtnClose = New btn(components)
        BtnRun = New btn(components)
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
        PnlBottomButton.Location = New Point(0, 309)
        PnlBottomButton.Size = New Size(800, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(800, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(BtnRun)
        SLFPanel.Controls.Add(Txt_Confirmation)
        SLFPanel.Controls.Add(LblNotification)
        SLFPanel.Size = New Size(800, 367)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(LblNotification, 0)
        SLFPanel.Controls.SetChildIndex(Txt_Confirmation, 0)
        SLFPanel.Controls.SetChildIndex(BtnRun, 0)
        ' 
        ' LblNotification
        ' 
        LblNotification.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblNotification.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblNotification.ForeColor = Color.Red
        LblNotification.Location = New Point(12, 84)
        LblNotification.Name = "LblNotification"
        LblNotification.Size = New Size(776, 21)
        LblNotification.SLFCustomElipsis = False
        LblNotification.TabIndex = 996
        LblNotification.Text = "This action will reset your database settings. Please type 'Confirm' then click 'Run' when you are ready."
        LblNotification.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Txt_Confirmation
        ' 
        Txt_Confirmation.AcceptsReturn = True
        Txt_Confirmation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Txt_Confirmation.AutoCompleteMode = AutoCompleteMode.Suggest
        Txt_Confirmation.AutoCompleteSource = AutoCompleteSource.CustomSource
        Txt_Confirmation.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Confirmation.Location = New Point(279, 121)
        Txt_Confirmation.MaxLength = 255
        Txt_Confirmation.Name = "Txt_Confirmation"
        Txt_Confirmation.Size = New Size(243, 29)
        Txt_Confirmation.SLFAutoTrim = False
        Txt_Confirmation.SLFHarusDiisi = True
        Txt_Confirmation.SLFHarusDiisiWarnaLatar = Color.LightPink
        Txt_Confirmation.SLFHarusDiisiWarnaLatarDefault = Color.White
        Txt_Confirmation.SLFHightlightSaatFokus = True
        Txt_Confirmation.SLFHightlightSaatFokusWarna = Color.LightYellow
        Txt_Confirmation.SLFIsBlank = False
        Txt_Confirmation.SLFIsSearchBox = False
        Txt_Confirmation.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Confirmation.SLFPilihSemuaSaatFokus = False
        Txt_Confirmation.SLFPwdLengthMin = 8
        Txt_Confirmation.SLFPwdStrengthCalculate = False
        Txt_Confirmation.SLFPwdStrengthScore = 0
        Txt_Confirmation.SLFPwdStrengthText = Nothing
        Txt_Confirmation.SLFRestriction = ControlCodeBase.enuRestriction.None
        Txt_Confirmation.SLFSearchBoxText = ""
        Txt_Confirmation.SLFSQLText = ""
        Txt_Confirmation.SLFTanpaSpasi = False
        Txt_Confirmation.SLFValidasiField = Nothing
        Txt_Confirmation.TabIndex = 0
        Txt_Confirmation.Tag = "txt"
        Txt_Confirmation.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.BackColor = Color.Red
        BtnClose.Cursor = Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClose.ForeColor = Color.White
        BtnClose.Location = New Point(670, 8)
        BtnClose.Margin = New Padding(4, 3, 4, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(117, 46)
        BtnClose.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.SLFTampilkanFocusBorder = False
        BtnClose.SLFValidasiSemuaInput = False
        BtnClose.SLFValidasiSemuaInputTag = Nothing
        BtnClose.TabIndex = 2
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' BtnRun
        ' 
        BtnRun.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        BtnRun.BackColor = Color.LimeGreen
        BtnRun.Cursor = Cursors.Hand
        BtnRun.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnRun.FlatAppearance.BorderSize = 2
        BtnRun.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnRun.FlatStyle = FlatStyle.Flat
        BtnRun.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnRun.ForeColor = Color.White
        BtnRun.Location = New Point(342, 162)
        BtnRun.Margin = New Padding(4, 3, 4, 3)
        BtnRun.Name = "BtnRun"
        BtnRun.Size = New Size(117, 46)
        BtnRun.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnRun.SLFTampilkanFocusBorder = False
        BtnRun.SLFValidasiSemuaInput = False
        BtnRun.SLFValidasiSemuaInputTag = Nothing
        BtnRun.TabIndex = 1
        BtnRun.Text = "&Run"
        BtnRun.UseVisualStyleBackColor = False
        ' 
        ' RESET
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "RESET"
        Text = "RESET"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNotification As lbl
    Friend WithEvents Txt_Confirmation As txt
    Friend WithEvents BtnClose As btn
    Friend WithEvents BtnRun As btn
End Class
