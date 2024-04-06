<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CDIN_Editor
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
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        TxtDeptCode = New txt(components)
        CboCompany = New cbo(components)
        TxtDeptName = New txt(components)
        TxtDescription = New txt(components)
        ChkAddNew = New chk(components)
        ULbl1 = New ULbl()
        ULbl2 = New ULbl()
        ULbl3 = New ULbl()
        ULbl4 = New ULbl()
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
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Location = New Point(0, 267)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(611, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(611, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TxtDescription)
        SLFPanel.Controls.Add(TxtDeptName)
        SLFPanel.Controls.Add(CboCompany)
        SLFPanel.Controls.Add(TxtDeptCode)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(611, 325)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TxtDeptCode, 0)
        SLFPanel.Controls.SetChildIndex(CboCompany, 0)
        SLFPanel.Controls.SetChildIndex(TxtDeptName, 0)
        SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
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
        BtnSave.Location = New Point(356, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.XOTampilkanFocusBorder = False
        BtnSave.XOValidasiSemuaInput = False
        BtnSave.XOValidasiSemuaInputTag = Nothing
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
        BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(480, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 6
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' TxtDeptCode
        ' 
        TxtDeptCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDeptCode.Location = New Point(196, 52)
        TxtDeptCode.Margin = New Padding(4, 3, 4, 3)
        TxtDeptCode.MaxLength = 255
        TxtDeptCode.Name = "TxtDeptCode"
        TxtDeptCode.Size = New Size(240, 29)
        TxtDeptCode.XOAutoTrim = True
        TxtDeptCode.XOHarusDiisi = True
        TxtDeptCode.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDeptCode.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDeptCode.XOHightlightSaatFokus = True
        TxtDeptCode.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDeptCode.XOIsBlank = True
        TxtDeptCode.XOIsSearchBox = False
        TxtDeptCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtDeptCode.XOPilihSemuaSaatFokus = True
        TxtDeptCode.XOPwdLengthMin = 8
        TxtDeptCode.XOPwdStrengthCalculate = False
        TxtDeptCode.XOPwdStrengthScore = 0
        TxtDeptCode.XOPwdStrengthText = Nothing
        TxtDeptCode.XORestriction = ControlCodeBase.enuRestriction.None
        TxtDeptCode.XOSearchBoxText = "Type then press Enter"
        TxtDeptCode.XOSQLText = ""
        TxtDeptCode.XOTanpaSpasi = False
        TxtDeptCode.XOValidasiField = Nothing
        TxtDeptCode.TabIndex = 1
        TxtDeptCode.Tag = "txt"
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
        ' TxtDeptName
        ' 
        TxtDeptName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDeptName.Location = New Point(196, 92)
        TxtDeptName.Margin = New Padding(4, 3, 4, 3)
        TxtDeptName.MaxLength = 255
        TxtDeptName.Name = "TxtDeptName"
        TxtDeptName.Size = New Size(240, 29)
        TxtDeptName.XOAutoTrim = True
        TxtDeptName.XOHarusDiisi = True
        TxtDeptName.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDeptName.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDeptName.XOHightlightSaatFokus = True
        TxtDeptName.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDeptName.XOIsBlank = True
        TxtDeptName.XOIsSearchBox = False
        TxtDeptName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtDeptName.XOPilihSemuaSaatFokus = False
        TxtDeptName.XOPwdLengthMin = 8
        TxtDeptName.XOPwdStrengthCalculate = False
        TxtDeptName.XOPwdStrengthScore = 0
        TxtDeptName.XOPwdStrengthText = Nothing
        TxtDeptName.XORestriction = ControlCodeBase.enuRestriction.None
        TxtDeptName.XOSearchBoxText = "Type then press Enter"
        TxtDeptName.XOSQLText = ""
        TxtDeptName.XOTanpaSpasi = False
        TxtDeptName.XOValidasiField = Nothing
        TxtDeptName.TabIndex = 2
        TxtDeptName.Tag = "txt"
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(196, 133)
        TxtDescription.Margin = New Padding(4, 3, 4, 3)
        TxtDescription.MaxLength = 255
        TxtDescription.Multiline = True
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(402, 112)
        TxtDescription.XOAutoTrim = False
        TxtDescription.XOHarusDiisi = False
        TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.XOHightlightSaatFokus = True
        TxtDescription.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.XOIsBlank = True
        TxtDescription.XOIsSearchBox = False
        TxtDescription.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtDescription.XOPilihSemuaSaatFokus = False
        TxtDescription.XOPwdLengthMin = 8
        TxtDescription.XOPwdStrengthCalculate = False
        TxtDescription.XOPwdStrengthScore = 0
        TxtDescription.XOPwdStrengthText = Nothing
        TxtDescription.XORestriction = ControlCodeBase.enuRestriction.None
        TxtDescription.XOSearchBoxText = "Type then press Enter"
        TxtDescription.XOSQLText = ""
        TxtDescription.XOTanpaSpasi = False
        TxtDescription.XOValidasiField = Nothing
        TxtDescription.TabIndex = 3
        TxtDescription.Tag = "txt"
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(203, 17)
        ChkAddNew.Margin = New Padding(4, 3, 4, 3)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(146, 25)
        ChkAddNew.TabIndex = 5
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
        ULbl1.TabIndex = 1004
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(14, 52)
        ULbl2.Margin = New Padding(5, 3, 5, 3)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Dept. Code"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1005
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(14, 92)
        ULbl3.Margin = New Padding(5, 3, 5, 3)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Dept. Name"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1006
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(14, 133)
        ULbl4.Margin = New Padding(5, 3, 5, 3)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 113)
        ULbl4.SLFText = "Description"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1007
        ' 
        ' CDIN_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(611, 408)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "CDIN_Editor"
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
    Friend WithEvents BtnSave As btn
    Friend WithEvents BtnCancel As btn
    Friend WithEvents TxtDeptName As txt
    Friend WithEvents CboCompany As cbo
    Friend WithEvents TxtDeptCode As txt
    Friend WithEvents TxtDescription As txt
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents ULbl4 As ULbl
End Class
