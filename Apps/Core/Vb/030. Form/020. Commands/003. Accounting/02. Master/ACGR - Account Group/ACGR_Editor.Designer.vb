<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACGR_Editor
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
        BtnSave = New CMCv.btn(components)
        BtnCancel = New CMCv.btn(components)
        CboCompany = New CMCv.cbo(components)
        CboAccountingBook = New CMCv.cbo(components)
        Lbl1 = New CMCv.lbl(components)
        Lbl2 = New CMCv.lbl(components)
        CboAccountGroup = New CMCv.cbo(components)
        Lbl3 = New CMCv.lbl(components)
        TxtAccountNumber = New CMCv.txt(components)
        Lbl4 = New CMCv.lbl(components)
        TxtAccountName = New CMCv.txt(components)
        Lbl5 = New CMCv.lbl(components)
        ChkEnable = New CMCv.chk(components)
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
        PnlBottomButton.Location = New Point(0, 327)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(642, 58)
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
        pnl_.Size = New Size(642, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ChkEnable)
        SLFPanel.Controls.Add(Lbl5)
        SLFPanel.Controls.Add(TxtAccountName)
        SLFPanel.Controls.Add(Lbl4)
        SLFPanel.Controls.Add(TxtAccountNumber)
        SLFPanel.Controls.Add(Lbl3)
        SLFPanel.Controls.Add(CboAccountGroup)
        SLFPanel.Controls.Add(Lbl2)
        SLFPanel.Controls.Add(Lbl1)
        SLFPanel.Controls.Add(CboAccountingBook)
        SLFPanel.Controls.Add(CboCompany)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(642, 385)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(CboCompany, 0)
        SLFPanel.Controls.SetChildIndex(CboAccountingBook, 0)
        SLFPanel.Controls.SetChildIndex(Lbl1, 0)
        SLFPanel.Controls.SetChildIndex(Lbl2, 0)
        SLFPanel.Controls.SetChildIndex(CboAccountGroup, 0)
        SLFPanel.Controls.SetChildIndex(Lbl3, 0)
        SLFPanel.Controls.SetChildIndex(TxtAccountNumber, 0)
        SLFPanel.Controls.SetChildIndex(Lbl4, 0)
        SLFPanel.Controls.SetChildIndex(TxtAccountName, 0)
        SLFPanel.Controls.SetChildIndex(Lbl5, 0)
        SLFPanel.Controls.SetChildIndex(ChkEnable, 0)
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
        BtnSave.Location = New Point(387, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 6
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
        BtnCancel.Location = New Point(511, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 7
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' CboCompany
        ' 
        CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
        CboCompany.DropDownWidth = 350
        CboCompany.FlatStyle = FlatStyle.Flat
        CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboCompany.FormattingEnabled = True
        CboCompany.Location = New Point(164, 12)
        CboCompany.Margin = New Padding(4, 3, 4, 3)
        CboCompany.Name = "CboCompany"
        CboCompany.Size = New Size(328, 29)
        CboCompany.TabIndex = 0
        ' 
        ' CboAccountingBook
        ' 
        CboAccountingBook.DropDownStyle = ComboBoxStyle.DropDownList
        CboAccountingBook.DropDownWidth = 350
        CboAccountingBook.FlatStyle = FlatStyle.Flat
        CboAccountingBook.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboAccountingBook.FormattingEnabled = True
        CboAccountingBook.Location = New Point(164, 52)
        CboAccountingBook.Margin = New Padding(4, 3, 4, 3)
        CboAccountingBook.Name = "CboAccountingBook"
        CboAccountingBook.Size = New Size(328, 29)
        CboAccountingBook.TabIndex = 1
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(68, 15)
        Lbl1.Margin = New Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(77, 21)
        Lbl1.SLFCustomElipsis = False
        Lbl1.TabIndex = 3
        Lbl1.Text = "Company"
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl2.Location = New Point(9, 55)
        Lbl2.Margin = New Padding(4, 0, 4, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(127, 21)
        Lbl2.SLFCustomElipsis = False
        Lbl2.TabIndex = 4
        Lbl2.Text = "Accounting Book"
        ' 
        ' CboAccountGroup
        ' 
        CboAccountGroup.DropDownStyle = ComboBoxStyle.DropDownList
        CboAccountGroup.FlatStyle = FlatStyle.Flat
        CboAccountGroup.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboAccountGroup.FormattingEnabled = True
        CboAccountGroup.Location = New Point(164, 92)
        CboAccountGroup.Margin = New Padding(4, 3, 4, 3)
        CboAccountGroup.Name = "CboAccountGroup"
        CboAccountGroup.Size = New Size(238, 29)
        CboAccountGroup.TabIndex = 2
        ' 
        ' Lbl3
        ' 
        Lbl3.AutoSize = True
        Lbl3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(24, 96)
        Lbl3.Margin = New Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(114, 21)
        Lbl3.SLFCustomElipsis = False
        Lbl3.TabIndex = 6
        Lbl3.Text = "Account Group"
        ' 
        ' TxtAccountNumber
        ' 
        TxtAccountNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAccountNumber.Location = New Point(164, 133)
        TxtAccountNumber.Margin = New Padding(4, 3, 4, 3)
        TxtAccountNumber.MaxLength = 255
        TxtAccountNumber.Name = "TxtAccountNumber"
        TxtAccountNumber.Size = New Size(240, 29)
        TxtAccountNumber.SLFAutoTrim = True
        TxtAccountNumber.SLFHarusDiisi = True
        TxtAccountNumber.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtAccountNumber.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtAccountNumber.SLFHightlightSaatFokus = True
        TxtAccountNumber.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtAccountNumber.SLFIsBlank = True
        TxtAccountNumber.SLFIsSearchBox = False
        TxtAccountNumber.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtAccountNumber.SLFPilihSemuaSaatFokus = True
        TxtAccountNumber.SLFPwdLengthMin = 8
        TxtAccountNumber.SLFPwdStrengthCalculate = False
        TxtAccountNumber.SLFPwdStrengthScore = 0
        TxtAccountNumber.SLFPwdStrengthText = Nothing
        TxtAccountNumber.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtAccountNumber.SLFSearchBoxText = "Type then press Enter"
        TxtAccountNumber.SLFSQLText = ""
        TxtAccountNumber.SLFTanpaSpasi = False
        TxtAccountNumber.SLFValidasiField = Nothing
        TxtAccountNumber.TabIndex = 3
        TxtAccountNumber.Tag = "txt"
        ' 
        ' Lbl4
        ' 
        Lbl4.AutoSize = True
        Lbl4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl4.Location = New Point(8, 136)
        Lbl4.Margin = New Padding(4, 0, 4, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Size(128, 21)
        Lbl4.SLFCustomElipsis = False
        Lbl4.TabIndex = 8
        Lbl4.Text = "Account Number"
        ' 
        ' TxtAccountName
        ' 
        TxtAccountName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAccountName.Location = New Point(164, 173)
        TxtAccountName.Margin = New Padding(4, 3, 4, 3)
        TxtAccountName.MaxLength = 255
        TxtAccountName.Name = "TxtAccountName"
        TxtAccountName.Size = New Size(465, 29)
        TxtAccountName.SLFAutoTrim = True
        TxtAccountName.SLFHarusDiisi = True
        TxtAccountName.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtAccountName.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtAccountName.SLFHightlightSaatFokus = True
        TxtAccountName.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtAccountName.SLFIsBlank = True
        TxtAccountName.SLFIsSearchBox = False
        TxtAccountName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtAccountName.SLFPilihSemuaSaatFokus = True
        TxtAccountName.SLFPwdLengthMin = 8
        TxtAccountName.SLFPwdStrengthCalculate = False
        TxtAccountName.SLFPwdStrengthScore = 0
        TxtAccountName.SLFPwdStrengthText = Nothing
        TxtAccountName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtAccountName.SLFSearchBoxText = "Type then press Enter"
        TxtAccountName.SLFSQLText = ""
        TxtAccountName.SLFTanpaSpasi = False
        TxtAccountName.SLFValidasiField = Nothing
        TxtAccountName.TabIndex = 4
        TxtAccountName.Tag = "txt"
        ' 
        ' Lbl5
        ' 
        Lbl5.AutoSize = True
        Lbl5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl5.Location = New Point(27, 177)
        Lbl5.Margin = New Padding(4, 0, 4, 0)
        Lbl5.Name = "Lbl5"
        Lbl5.Size = New Size(112, 21)
        Lbl5.SLFCustomElipsis = False
        Lbl5.TabIndex = 10
        Lbl5.Text = "Account Name"
        ' 
        ' ChkEnable
        ' 
        ChkEnable.AutoSize = True
        ChkEnable.BackColor = Color.Transparent
        ChkEnable.FlatStyle = FlatStyle.Flat
        ChkEnable.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkEnable.Location = New Point(164, 213)
        ChkEnable.Margin = New Padding(4, 3, 4, 3)
        ChkEnable.Name = "ChkEnable"
        ChkEnable.Size = New Size(177, 25)
        ChkEnable.TabIndex = 5
        ChkEnable.Text = "Enable for transaction"
        ChkEnable.UseVisualStyleBackColor = False
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(234, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 8
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' ACGR_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(642, 468)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "ACGR_Editor"
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
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents Lbl5 As CMCv.lbl
    Friend WithEvents TxtAccountName As CMCv.txt
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents TxtAccountNumber As CMCv.txt
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents CboAccountGroup As CMCv.cbo
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents CboAccountingBook As CMCv.cbo
    Friend WithEvents CboCompany As CMCv.cbo
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents ChkEnable As CMCv.chk

End Class
