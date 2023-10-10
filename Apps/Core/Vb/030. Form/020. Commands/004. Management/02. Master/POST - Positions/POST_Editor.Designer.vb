<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POST_Editor
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
        TxtPositionDescription = New txt(components)
        TxtPositionName = New txt(components)
        CboDepartement = New cbo(components)
        CboCompany = New cbo(components)
        TxtPositionCode = New txt(components)
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
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
        PnlBottomButton.Location = New Point(0, 399)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(598, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(598, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ULbl5)
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TxtPositionDescription)
        SLFPanel.Controls.Add(TxtPositionName)
        SLFPanel.Controls.Add(CboDepartement)
        SLFPanel.Controls.Add(CboCompany)
        SLFPanel.Controls.Add(TxtPositionCode)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(598, 457)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TxtPositionCode, 0)
        SLFPanel.Controls.SetChildIndex(CboCompany, 0)
        SLFPanel.Controls.SetChildIndex(CboDepartement, 0)
        SLFPanel.Controls.SetChildIndex(TxtPositionName, 0)
        SLFPanel.Controls.SetChildIndex(TxtPositionDescription, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
        SLFPanel.Controls.SetChildIndex(ULbl5, 0)
        ' 
        ' TxtPositionDescription
        ' 
        TxtPositionDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPositionDescription.Location = New Point(196, 173)
        TxtPositionDescription.Margin = New Padding(4, 3, 4, 3)
        TxtPositionDescription.MaxLength = 255
        TxtPositionDescription.Multiline = True
        TxtPositionDescription.Name = "TxtPositionDescription"
        TxtPositionDescription.Size = New Size(383, 134)
        TxtPositionDescription.SLFAutoTrim = False
        TxtPositionDescription.SLFHarusDiisi = False
        TxtPositionDescription.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPositionDescription.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPositionDescription.SLFHightlightSaatFokus = False
        TxtPositionDescription.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPositionDescription.SLFIsBlank = True
        TxtPositionDescription.SLFIsSearchBox = False
        TxtPositionDescription.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPositionDescription.SLFPilihSemuaSaatFokus = False
        TxtPositionDescription.SLFPwdLengthMin = 8
        TxtPositionDescription.SLFPwdStrengthCalculate = False
        TxtPositionDescription.SLFPwdStrengthScore = 0
        TxtPositionDescription.SLFPwdStrengthText = Nothing
        TxtPositionDescription.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPositionDescription.SLFSearchBoxText = "Type then press Enter"
        TxtPositionDescription.SLFSQLText = ""
        TxtPositionDescription.SLFTanpaSpasi = False
        TxtPositionDescription.SLFValidasiField = Nothing
        TxtPositionDescription.TabIndex = 4
        TxtPositionDescription.Tag = "txt"
        ' 
        ' TxtPositionName
        ' 
        TxtPositionName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPositionName.Location = New Point(196, 133)
        TxtPositionName.Margin = New Padding(4, 3, 4, 3)
        TxtPositionName.MaxLength = 255
        TxtPositionName.Name = "TxtPositionName"
        TxtPositionName.Size = New Size(240, 29)
        TxtPositionName.SLFAutoTrim = True
        TxtPositionName.SLFHarusDiisi = True
        TxtPositionName.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPositionName.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPositionName.SLFHightlightSaatFokus = True
        TxtPositionName.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPositionName.SLFIsBlank = True
        TxtPositionName.SLFIsSearchBox = False
        TxtPositionName.SLFJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPositionName.SLFPilihSemuaSaatFokus = False
        TxtPositionName.SLFPwdLengthMin = 8
        TxtPositionName.SLFPwdStrengthCalculate = False
        TxtPositionName.SLFPwdStrengthScore = 0
        TxtPositionName.SLFPwdStrengthText = Nothing
        TxtPositionName.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPositionName.SLFSearchBoxText = "Type then press Enter"
        TxtPositionName.SLFSQLText = ""
        TxtPositionName.SLFTanpaSpasi = False
        TxtPositionName.SLFValidasiField = Nothing
        TxtPositionName.TabIndex = 3
        TxtPositionName.Tag = "txt"
        ' 
        ' CboDepartement
        ' 
        CboDepartement.DropDownStyle = ComboBoxStyle.DropDownList
        CboDepartement.DropDownWidth = 350
        CboDepartement.FlatStyle = FlatStyle.Flat
        CboDepartement.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboDepartement.FormattingEnabled = True
        CboDepartement.Location = New Point(196, 52)
        CboDepartement.Margin = New Padding(4, 3, 4, 3)
        CboDepartement.Name = "CboDepartement"
        CboDepartement.Size = New Size(240, 29)
        CboDepartement.TabIndex = 1
        ' 
        ' CboCompany
        ' 
        CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
        CboCompany.DropDownWidth = 350
        CboCompany.FlatStyle = FlatStyle.Flat
        CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboCompany.FormattingEnabled = True
        CboCompany.Location = New Point(196, 12)
        CboCompany.Margin = New Padding(4, 3, 4, 3)
        CboCompany.Name = "CboCompany"
        CboCompany.Size = New Size(240, 29)
        CboCompany.TabIndex = 0
        ' 
        ' TxtPositionCode
        ' 
        TxtPositionCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPositionCode.Location = New Point(196, 92)
        TxtPositionCode.Margin = New Padding(4, 3, 4, 3)
        TxtPositionCode.MaxLength = 255
        TxtPositionCode.Name = "TxtPositionCode"
        TxtPositionCode.Size = New Size(240, 29)
        TxtPositionCode.SLFAutoTrim = True
        TxtPositionCode.SLFHarusDiisi = True
        TxtPositionCode.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPositionCode.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPositionCode.SLFHightlightSaatFokus = True
        TxtPositionCode.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPositionCode.SLFIsBlank = True
        TxtPositionCode.SLFIsSearchBox = False
        TxtPositionCode.SLFJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPositionCode.SLFPilihSemuaSaatFokus = True
        TxtPositionCode.SLFPwdLengthMin = 8
        TxtPositionCode.SLFPwdStrengthCalculate = False
        TxtPositionCode.SLFPwdStrengthScore = 0
        TxtPositionCode.SLFPwdStrengthText = Nothing
        TxtPositionCode.SLFRestriction = ControlCodeBase.enuRestriction.None
        TxtPositionCode.SLFSearchBoxText = "Type then press Enter"
        TxtPositionCode.SLFSQLText = ""
        TxtPositionCode.SLFTanpaSpasi = False
        TxtPositionCode.SLFValidasiField = Nothing
        TxtPositionCode.TabIndex = 2
        TxtPositionCode.Tag = "txt"
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
        BtnSave.Location = New Point(343, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 801
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
        BtnCancel.Location = New Point(467, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 802
        BtnCancel.Text = "&Close"
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
        ChkAddNew.Location = New Point(193, 13)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 803
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
        ULbl1.SLFText = "Company"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1014
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(14, 52)
        ULbl2.Margin = New Padding(5, 3, 5, 3)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Department"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1015
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(14, 92)
        ULbl3.Margin = New Padding(5, 3, 5, 3)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Position Code"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1016
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(14, 133)
        ULbl4.Margin = New Padding(5, 3, 5, 3)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Position Name"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1017
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
        ULbl5.TabIndex = 1018
        ' 
        ' POST_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(598, 540)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "POST_Editor"
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
    Friend WithEvents TxtPositionDescription As txt
    Friend WithEvents TxtPositionName As txt
    Friend WithEvents CboDepartement As cbo
    Friend WithEvents CboCompany As cbo
    Friend WithEvents TxtPositionCode As txt
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents BtnCancel As btn
    Friend WithEvents BtnSave As btn
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
End Class
