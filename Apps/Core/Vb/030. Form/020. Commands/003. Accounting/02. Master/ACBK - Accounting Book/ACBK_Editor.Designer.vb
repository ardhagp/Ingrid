<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACBK_Editor
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
        Cbo1 = New CMCv.cbo(components)
        Txt1 = New CMCv.txt(components)
        Txt2 = New CMCv.txt(components)
        Txt3 = New CMCv.txt(components)
        Lbl1 = New CMCv.lbl(components)
        Lbl2 = New CMCv.lbl(components)
        Lbl3 = New CMCv.lbl(components)
        Lbl4 = New CMCv.lbl(components)
        BtnSave = New CMCv.btn(components)
        BtnCancel = New CMCv.btn(components)
        ChkAddNew = New CMCv.chk(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkAddNew)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 315)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(578, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
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
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(578, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Lbl4)
        SLFPanel.Controls.Add(Lbl3)
        SLFPanel.Controls.Add(Lbl2)
        SLFPanel.Controls.Add(Lbl1)
        SLFPanel.Controls.Add(Txt3)
        SLFPanel.Controls.Add(Txt2)
        SLFPanel.Controls.Add(Txt1)
        SLFPanel.Controls.Add(Cbo1)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(578, 373)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Cbo1, 0)
        SLFPanel.Controls.SetChildIndex(Txt1, 0)
        SLFPanel.Controls.SetChildIndex(Txt2, 0)
        SLFPanel.Controls.SetChildIndex(Txt3, 0)
        SLFPanel.Controls.SetChildIndex(Lbl1, 0)
        SLFPanel.Controls.SetChildIndex(Lbl2, 0)
        SLFPanel.Controls.SetChildIndex(Lbl3, 0)
        SLFPanel.Controls.SetChildIndex(Lbl4, 0)
        ' 
        ' Cbo1
        ' 
        Cbo1.DropDownStyle = ComboBoxStyle.DropDownList
        Cbo1.DropDownWidth = 350
        Cbo1.FlatStyle = FlatStyle.Flat
        Cbo1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Cbo1.FormattingEnabled = True
        Cbo1.Location = New Point(164, 12)
        Cbo1.Margin = New Padding(4, 3, 4, 3)
        Cbo1.Name = "Cbo1"
        Cbo1.Size = New Size(140, 29)
        Cbo1.TabIndex = 0
        ' 
        ' Txt1
        ' 
        Txt1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt1.Location = New Point(164, 52)
        Txt1.Margin = New Padding(4, 3, 4, 3)
        Txt1.MaxLength = 10
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(140, 29)
        Txt1.SLFAutoTrim = True
        Txt1.SLFHarusDiisi = True
        Txt1.SLFHarusDiisiWarnaLatar = Color.LightPink
        Txt1.SLFHarusDiisiWarnaLatarDefault = Color.White
        Txt1.SLFHightlightSaatFokus = True
        Txt1.SLFHightlightSaatFokusWarna = Color.LightYellow
        Txt1.SLFIsBlank = True
        Txt1.SLFIsSearchBox = False
        Txt1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Txt1.SLFPilihSemuaSaatFokus = False
        Txt1.SLFPwdLengthMin = 8
        Txt1.SLFPwdStrengthCalculate = False
        Txt1.SLFPwdStrengthScore = 0
        Txt1.SLFPwdStrengthText = Nothing
        Txt1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Txt1.SLFSearchBoxText = "Type then press Enter"
        Txt1.SLFSQLText = ""
        Txt1.SLFTanpaSpasi = False
        Txt1.SLFValidasiField = Nothing
        Txt1.TabIndex = 1
        Txt1.Tag = "txt"
        Txt1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Txt2
        ' 
        Txt2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt2.Location = New Point(164, 92)
        Txt2.Margin = New Padding(4, 3, 4, 3)
        Txt2.MaxLength = 50
        Txt2.Name = "Txt2"
        Txt2.Size = New Size(398, 29)
        Txt2.SLFAutoTrim = True
        Txt2.SLFHarusDiisi = True
        Txt2.SLFHarusDiisiWarnaLatar = Color.LightPink
        Txt2.SLFHarusDiisiWarnaLatarDefault = Color.White
        Txt2.SLFHightlightSaatFokus = True
        Txt2.SLFHightlightSaatFokusWarna = Color.LightYellow
        Txt2.SLFIsBlank = True
        Txt2.SLFIsSearchBox = False
        Txt2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Txt2.SLFPilihSemuaSaatFokus = False
        Txt2.SLFPwdLengthMin = 8
        Txt2.SLFPwdStrengthCalculate = False
        Txt2.SLFPwdStrengthScore = 0
        Txt2.SLFPwdStrengthText = Nothing
        Txt2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Txt2.SLFSearchBoxText = "Type then press Enter"
        Txt2.SLFSQLText = ""
        Txt2.SLFTanpaSpasi = False
        Txt2.SLFValidasiField = Nothing
        Txt2.TabIndex = 2
        Txt2.Tag = "txt"
        ' 
        ' Txt3
        ' 
        Txt3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt3.Location = New Point(164, 133)
        Txt3.Margin = New Padding(4, 3, 4, 3)
        Txt3.MaxLength = 255
        Txt3.Multiline = True
        Txt3.Name = "Txt3"
        Txt3.Size = New Size(398, 86)
        Txt3.SLFAutoTrim = True
        Txt3.SLFHarusDiisi = False
        Txt3.SLFHarusDiisiWarnaLatar = Color.LightPink
        Txt3.SLFHarusDiisiWarnaLatarDefault = Color.White
        Txt3.SLFHightlightSaatFokus = True
        Txt3.SLFHightlightSaatFokusWarna = Color.LightYellow
        Txt3.SLFIsBlank = True
        Txt3.SLFIsSearchBox = False
        Txt3.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Txt3.SLFPilihSemuaSaatFokus = False
        Txt3.SLFPwdLengthMin = 8
        Txt3.SLFPwdStrengthCalculate = False
        Txt3.SLFPwdStrengthScore = 0
        Txt3.SLFPwdStrengthText = Nothing
        Txt3.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Txt3.SLFSearchBoxText = "Type then press Enter"
        Txt3.SLFSQLText = ""
        Txt3.SLFTanpaSpasi = False
        Txt3.SLFValidasiField = Nothing
        Txt3.TabIndex = 3
        Txt3.Tag = "txt"
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(105, 15)
        Lbl1.Margin = New Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(45, 21)
        Lbl1.SLFCustomElipsis = False
        Lbl1.TabIndex = 5
        Lbl1.Text = "Plant"
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl2.Location = New Point(58, 55)
        Lbl2.Margin = New Padding(4, 0, 4, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(85, 21)
        Lbl2.SLFCustomElipsis = False
        Lbl2.TabIndex = 6
        Lbl2.Text = "Book Code"
        ' 
        ' Lbl3
        ' 
        Lbl3.AutoSize = True
        Lbl3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(51, 96)
        Lbl3.Margin = New Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(91, 21)
        Lbl3.SLFCustomElipsis = False
        Lbl3.TabIndex = 7
        Lbl3.Text = "Book Name"
        ' 
        ' Lbl4
        ' 
        Lbl4.AutoSize = True
        Lbl4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl4.Location = New Point(54, 136)
        Lbl4.Margin = New Padding(4, 0, 4, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Size(89, 21)
        Lbl4.SLFCustomElipsis = False
        Lbl4.TabIndex = 8
        Lbl4.Text = "Description"
        ' 
        ' BtnSave
        ' 
        BtnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnSave.BackColor = Color.LimeGreen
        BtnSave.Cursor = Cursors.Hand
        BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnSave.FlatAppearance.BorderSize = 2
        BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(323, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 4
        BtnSave.Text = "&Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnCancel.BackColor = Color.Red
        BtnCancel.Cursor = Cursors.Hand
        BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnCancel.FlatAppearance.BorderSize = 2
        BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnCancel.FlatStyle = FlatStyle.Flat
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(447, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 5
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(170, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 6
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' ACBK_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(578, 456)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "ACBK_Editor"
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Cbo1 As CMCv.cbo
    Friend WithEvents Txt1 As CMCv.txt
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Txt3 As CMCv.txt
    Friend WithEvents Txt2 As CMCv.txt
    Friend WithEvents ChkAddNew As CMCv.chk

End Class
