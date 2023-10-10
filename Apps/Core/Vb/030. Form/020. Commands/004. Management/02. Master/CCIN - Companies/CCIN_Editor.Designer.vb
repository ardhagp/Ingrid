<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CCIN_Editor
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
        TxtCode = New txt(components)
        TxtSearchTerm1 = New txt(components)
        TxtSearchTerm2 = New txt(components)
        TxtDescription = New txt(components)
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        TxtName = New txt(components)
        ChkAddNew = New chk(components)
        ULbl1 = New ULbl()
        ULbl2 = New ULbl()
        ULbl3 = New ULbl()
        ULbl4 = New ULbl()
        ULbl5 = New ULbl()
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
        PnlBottomButton.Location = New Point(0, 398)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(629, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(629, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ULbl5)
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TxtName)
        SLFPanel.Controls.Add(TxtDescription)
        SLFPanel.Controls.Add(TxtSearchTerm2)
        SLFPanel.Controls.Add(TxtSearchTerm1)
        SLFPanel.Controls.Add(TxtCode)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(629, 456)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TxtCode, 0)
        SLFPanel.Controls.SetChildIndex(TxtSearchTerm1, 0)
        SLFPanel.Controls.SetChildIndex(TxtSearchTerm2, 0)
        SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
        SLFPanel.Controls.SetChildIndex(TxtName, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
        SLFPanel.Controls.SetChildIndex(ULbl5, 0)
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCode.Location = New Point(197, 12)
        TxtCode.Margin = New Padding(4, 3, 4, 3)
        TxtCode.MaxLength = 255
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(240, 29)
        TxtCode.SLFAutoTrim = True
        TxtCode.SLFHarusDiisi = True
        TxtCode.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtCode.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtCode.SLFHightlightSaatFokus = True
        TxtCode.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtCode.SLFIsBlank = True
        TxtCode.SLFIsSearchBox = False
        TxtCode.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtCode.SLFPilihSemuaSaatFokus = True
        TxtCode.SLFPwdLengthMin = 8
        TxtCode.SLFPwdStrengthCalculate = False
        TxtCode.SLFPwdStrengthScore = 0
        TxtCode.SLFPwdStrengthText = Nothing
        TxtCode.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtCode.SLFSearchBoxText = "Type then press Enter"
        TxtCode.SLFSQLText = ""
        TxtCode.SLFTanpaSpasi = False
        TxtCode.SLFValidasiField = Nothing
        TxtCode.TabIndex = 0
        TxtCode.Tag = "txt"
        ' 
        ' TxtSearchTerm1
        ' 
        TxtSearchTerm1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm1.Location = New Point(196, 92)
        TxtSearchTerm1.Margin = New Padding(4, 3, 4, 3)
        TxtSearchTerm1.MaxLength = 255
        TxtSearchTerm1.Name = "TxtSearchTerm1"
        TxtSearchTerm1.Size = New Size(240, 29)
        TxtSearchTerm1.SLFAutoTrim = True
        TxtSearchTerm1.SLFHarusDiisi = False
        TxtSearchTerm1.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm1.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm1.SLFHightlightSaatFokus = False
        TxtSearchTerm1.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtSearchTerm1.SLFIsBlank = True
        TxtSearchTerm1.SLFIsSearchBox = False
        TxtSearchTerm1.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtSearchTerm1.SLFPilihSemuaSaatFokus = False
        TxtSearchTerm1.SLFPwdLengthMin = 8
        TxtSearchTerm1.SLFPwdStrengthCalculate = False
        TxtSearchTerm1.SLFPwdStrengthScore = 0
        TxtSearchTerm1.SLFPwdStrengthText = Nothing
        TxtSearchTerm1.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtSearchTerm1.SLFSearchBoxText = "Type then press Enter"
        TxtSearchTerm1.SLFSQLText = ""
        TxtSearchTerm1.SLFTanpaSpasi = False
        TxtSearchTerm1.SLFValidasiField = Nothing
        TxtSearchTerm1.TabIndex = 2
        TxtSearchTerm1.Tag = "txt"
        ' 
        ' TxtSearchTerm2
        ' 
        TxtSearchTerm2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm2.Location = New Point(196, 133)
        TxtSearchTerm2.Margin = New Padding(4, 3, 4, 3)
        TxtSearchTerm2.MaxLength = 255
        TxtSearchTerm2.Name = "TxtSearchTerm2"
        TxtSearchTerm2.Size = New Size(415, 29)
        TxtSearchTerm2.SLFAutoTrim = True
        TxtSearchTerm2.SLFHarusDiisi = False
        TxtSearchTerm2.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm2.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm2.SLFHightlightSaatFokus = False
        TxtSearchTerm2.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtSearchTerm2.SLFIsBlank = True
        TxtSearchTerm2.SLFIsSearchBox = False
        TxtSearchTerm2.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtSearchTerm2.SLFPilihSemuaSaatFokus = False
        TxtSearchTerm2.SLFPwdLengthMin = 8
        TxtSearchTerm2.SLFPwdStrengthCalculate = False
        TxtSearchTerm2.SLFPwdStrengthScore = 0
        TxtSearchTerm2.SLFPwdStrengthText = Nothing
        TxtSearchTerm2.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtSearchTerm2.SLFSearchBoxText = "Type then press Enter"
        TxtSearchTerm2.SLFSQLText = ""
        TxtSearchTerm2.SLFTanpaSpasi = False
        TxtSearchTerm2.SLFValidasiField = Nothing
        TxtSearchTerm2.TabIndex = 3
        TxtSearchTerm2.Tag = "txt"
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(196, 173)
        TxtDescription.Margin = New Padding(4, 3, 4, 3)
        TxtDescription.MaxLength = 255
        TxtDescription.Multiline = True
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(415, 134)
        TxtDescription.SLFAutoTrim = True
        TxtDescription.SLFHarusDiisi = False
        TxtDescription.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.SLFHightlightSaatFokus = False
        TxtDescription.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.SLFIsBlank = True
        TxtDescription.SLFIsSearchBox = False
        TxtDescription.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtDescription.SLFPilihSemuaSaatFokus = False
        TxtDescription.SLFPwdLengthMin = 8
        TxtDescription.SLFPwdStrengthCalculate = False
        TxtDescription.SLFPwdStrengthScore = 0
        TxtDescription.SLFPwdStrengthText = Nothing
        TxtDescription.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtDescription.SLFSearchBoxText = "Type then press Enter"
        TxtDescription.SLFSQLText = ""
        TxtDescription.SLFTanpaSpasi = False
        TxtDescription.SLFValidasiField = Nothing
        TxtDescription.TabIndex = 4
        TxtDescription.Tag = "txt"
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
        BtnSave.Location = New Point(374, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 5
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
        BtnCancel.Location = New Point(498, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 7
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(196, 52)
        TxtName.Margin = New Padding(4, 3, 4, 3)
        TxtName.MaxLength = 255
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(240, 29)
        TxtName.SLFAutoTrim = True
        TxtName.SLFHarusDiisi = True
        TxtName.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtName.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtName.SLFHightlightSaatFokus = True
        TxtName.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtName.SLFIsBlank = True
        TxtName.SLFIsSearchBox = False
        TxtName.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtName.SLFPilihSemuaSaatFokus = False
        TxtName.SLFPwdLengthMin = 8
        TxtName.SLFPwdStrengthCalculate = False
        TxtName.SLFPwdStrengthScore = 0
        TxtName.SLFPwdStrengthText = Nothing
        TxtName.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtName.SLFSearchBoxText = "Type then press Enter"
        TxtName.SLFSQLText = ""
        TxtName.SLFTanpaSpasi = False
        TxtName.SLFValidasiField = Nothing
        TxtName.TabIndex = 1
        TxtName.Tag = "txt"
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(221, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 6
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(14, 12)
        ULbl1.Margin = New Padding(5, 3, 5, 3)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(175, 33)
        ULbl1.SLFText = "Company Code"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1006
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(14, 52)
        ULbl2.Margin = New Padding(5, 3, 5, 3)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Company Name"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1007
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(14, 92)
        ULbl3.Margin = New Padding(5, 3, 5, 3)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Search Term 1"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1008
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(14, 133)
        ULbl4.Margin = New Padding(5, 3, 5, 3)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Search Term 2"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1009
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(14, 173)
        ULbl5.Margin = New Padding(5, 3, 5, 3)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(175, 135)
        ULbl5.SLFText = "Description"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1010
        ' 
        ' CCIN_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(629, 539)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "CCIN_Editor"
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
    Friend WithEvents TxtCode As txt
    Friend WithEvents TxtDescription As txt
    Friend WithEvents TxtSearchTerm2 As txt
    Friend WithEvents TxtSearchTerm1 As txt
    Friend WithEvents BtnCancel As btn
    Friend WithEvents BtnSave As btn
    Friend WithEvents TxtName As txt
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
End Class
