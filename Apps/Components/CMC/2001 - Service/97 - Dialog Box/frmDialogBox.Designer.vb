﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDBdialogbox
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
        PnlBottomButtonYesNo = New Pnl(components)
        PictureBox1 = New Windows.Forms.PictureBox()
        BtnYes = New Btn(components)
        BtnNo = New Btn(components)
        BtnCancel = New Btn(components)
        BtnOk = New Btn(components)
        PnlBottomButtonOkOnly = New Pnl(components)
        PictureBox2 = New Windows.Forms.PictureBox()
        BtnOkOnly = New Btn(components)
        TxtMessage = New Txt(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        PnlBottomButtonYesNo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlBottomButtonOkOnly.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnOk)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Location = New System.Drawing.Point(0, 166)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New System.Drawing.Size(780, 58)
        PnlBottomButton.Visible = False
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnOk, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        pnl_.Size = New System.Drawing.Size(780, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TxtMessage)
        SLFPanel.Controls.Add(PnlBottomButtonOkOnly)
        SLFPanel.Controls.Add(PnlBottomButtonYesNo)
        SLFPanel.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        SLFPanel.Size = New System.Drawing.Size(780, 282)
        SLFPanel.Controls.SetChildIndex(PnlBottomButtonYesNo, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButtonOkOnly, 0)
        SLFPanel.Controls.SetChildIndex(TxtMessage, 0)
        ' 
        ' PnlBottomButtonYesNo
        ' 
        PnlBottomButtonYesNo.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButtonYesNo.Controls.Add(PictureBox1)
        PnlBottomButtonYesNo.Controls.Add(BtnYes)
        PnlBottomButtonYesNo.Controls.Add(BtnNo)
        PnlBottomButtonYesNo.Dock = Windows.Forms.DockStyle.Bottom
        PnlBottomButtonYesNo.Location = New System.Drawing.Point(0, 224)
        PnlBottomButtonYesNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PnlBottomButtonYesNo.Name = "PnlBottomButtonYesNo"
        PnlBottomButtonYesNo.Size = New System.Drawing.Size(780, 58)
        PnlBottomButtonYesNo.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Drawing.Color.Red
        PictureBox1.Dock = Windows.Forms.DockStyle.Top
        PictureBox1.Location = New System.Drawing.Point(0, 0)
        PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(780, 5)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' BtnYes
        ' 
        BtnYes.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnYes.BackColor = Drawing.Color.LimeGreen
        BtnYes.Cursor = Windows.Forms.Cursors.Hand
        BtnYes.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnYes.FlatAppearance.BorderSize = 2
        BtnYes.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnYes.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnYes.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnYes.ForeColor = Drawing.Color.White
        BtnYes.Location = New System.Drawing.Point(525, 8)
        BtnYes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnYes.Name = "BtnYes"
        BtnYes.Size = New System.Drawing.Size(117, 46)
        BtnYes.TabIndex = 0
        BtnYes.Text = "&Yes"
        BtnYes.UseVisualStyleBackColor = False
        BtnYes.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnYes.XOTampilkanFocusBorder = False
        BtnYes.XOValidasiSemuaInput = False
        BtnYes.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnNo
        ' 
        BtnNo.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnNo.BackColor = Drawing.Color.Red
        BtnNo.Cursor = Windows.Forms.Cursors.Hand
        BtnNo.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnNo.FlatAppearance.BorderSize = 2
        BtnNo.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnNo.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnNo.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnNo.ForeColor = Drawing.Color.White
        BtnNo.Location = New System.Drawing.Point(649, 8)
        BtnNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnNo.Name = "BtnNo"
        BtnNo.Size = New System.Drawing.Size(117, 46)
        BtnNo.TabIndex = 0
        BtnNo.Text = "&No"
        BtnNo.UseVisualStyleBackColor = False
        BtnNo.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnNo.XOTampilkanFocusBorder = False
        BtnNo.XOValidasiSemuaInput = False
        BtnNo.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnCancel.BackColor = Drawing.Color.Red
        BtnCancel.Cursor = Windows.Forms.Cursors.Hand
        BtnCancel.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnCancel.FlatAppearance.BorderSize = 2
        BtnCancel.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnCancel.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnCancel.ForeColor = Drawing.Color.White
        BtnCancel.Location = New System.Drawing.Point(649, 8)
        BtnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New System.Drawing.Size(117, 46)
        BtnCancel.TabIndex = 0
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnOk
        ' 
        BtnOk.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnOk.BackColor = Drawing.Color.LimeGreen
        BtnOk.Cursor = Windows.Forms.Cursors.Hand
        BtnOk.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnOk.FlatAppearance.BorderSize = 2
        BtnOk.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnOk.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnOk.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnOk.ForeColor = Drawing.Color.White
        BtnOk.Location = New System.Drawing.Point(525, 8)
        BtnOk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New System.Drawing.Size(117, 46)
        BtnOk.TabIndex = 0
        BtnOk.Text = "&Ok"
        BtnOk.UseVisualStyleBackColor = False
        BtnOk.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnOk.XOTampilkanFocusBorder = False
        BtnOk.XOValidasiSemuaInput = False
        BtnOk.XOValidasiSemuaInputTag = Nothing
        ' 
        ' PnlBottomButtonOkOnly
        ' 
        PnlBottomButtonOkOnly.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButtonOkOnly.Controls.Add(PictureBox2)
        PnlBottomButtonOkOnly.Controls.Add(BtnOkOnly)
        PnlBottomButtonOkOnly.Dock = Windows.Forms.DockStyle.Bottom
        PnlBottomButtonOkOnly.Location = New System.Drawing.Point(0, 108)
        PnlBottomButtonOkOnly.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PnlBottomButtonOkOnly.Name = "PnlBottomButtonOkOnly"
        PnlBottomButtonOkOnly.Size = New System.Drawing.Size(780, 58)
        PnlBottomButtonOkOnly.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Drawing.Color.Red
        PictureBox2.Dock = Windows.Forms.DockStyle.Top
        PictureBox2.Location = New System.Drawing.Point(0, 0)
        PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(780, 5)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' BtnOkOnly
        ' 
        BtnOkOnly.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnOkOnly.BackColor = Drawing.Color.RoyalBlue
        BtnOkOnly.Cursor = Windows.Forms.Cursors.Hand
        BtnOkOnly.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnOkOnly.FlatAppearance.BorderSize = 2
        BtnOkOnly.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnOkOnly.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnOkOnly.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnOkOnly.ForeColor = Drawing.Color.White
        BtnOkOnly.Location = New System.Drawing.Point(649, 9)
        BtnOkOnly.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnOkOnly.Name = "BtnOkOnly"
        BtnOkOnly.Size = New System.Drawing.Size(117, 46)
        BtnOkOnly.TabIndex = 0
        BtnOkOnly.Text = "&Ok"
        BtnOkOnly.UseVisualStyleBackColor = False
        BtnOkOnly.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnOkOnly.XOTampilkanFocusBorder = False
        BtnOkOnly.XOValidasiSemuaInput = False
        BtnOkOnly.XOValidasiSemuaInputTag = Nothing
        ' 
        ' TxtMessage
        ' 
        TxtMessage.AcceptsReturn = True
        TxtMessage.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        TxtMessage.BackColor = Drawing.SystemColors.Window
        TxtMessage.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtMessage.Location = New System.Drawing.Point(14, 17)
        TxtMessage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        TxtMessage.MaxLength = 255
        TxtMessage.Multiline = True
        TxtMessage.Name = "TxtMessage"
        TxtMessage.ReadOnly = True
        TxtMessage.ScrollBars = Windows.Forms.ScrollBars.Vertical
        TxtMessage.ShortcutsEnabled = False
        TxtMessage.Size = New System.Drawing.Size(751, 196)
        TxtMessage.TabIndex = 5
        TxtMessage.TabStop = False
        TxtMessage.Tag = "txt"
        TxtMessage.XOAutoTrim = False
        TxtMessage.XOHarusDiisi = False
        TxtMessage.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtMessage.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtMessage.XOHightlightSaatFokus = False
        TxtMessage.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtMessage.XOIsBlank = True
        TxtMessage.XOIsSearchBox = False
        TxtMessage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtMessage.XOPilihSemuaSaatFokus = False
        TxtMessage.XOPwdLengthMin = 8
        TxtMessage.XOPwdStrengthCalculate = False
        TxtMessage.XOPwdStrengthScore = 0
        TxtMessage.XOPwdStrengthText = Nothing
        TxtMessage.XORestriction = ControlCodeBase.enuRestriction.None
        TxtMessage.XOSearchBoxText = "Type then press Enter"
        TxtMessage.XOSQLText = ""
        TxtMessage.XOTanpaSpasi = False
        TxtMessage.XOValidasiField = Nothing
        ' 
        ' frmDBdialogbox
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        ClientSize = New System.Drawing.Size(780, 365)
        ControlBox = False
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmDBdialogbox"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        PnlBottomButtonYesNo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlBottomButtonOkOnly.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PnlBottomButtonYesNo As CMCv.pnl
    Friend WithEvents BtnOk As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnYes As CMCv.btn
    Friend WithEvents BtnNo As CMCv.btn
    Friend WithEvents PnlBottomButtonOkOnly As CMCv.pnl
    Friend WithEvents BtnOkOnly As CMCv.btn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtMessage As CMCv.txt

End Class
