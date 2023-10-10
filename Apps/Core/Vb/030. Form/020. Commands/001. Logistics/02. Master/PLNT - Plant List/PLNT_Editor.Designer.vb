<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLNT_Editor
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        CboCompany = New CMCv.cbo(components)
        Lbl1 = New CMCv.lbl(components)
        TxtPlantCode = New CMCv.txt(components)
        TxtPlantName1 = New CMCv.txt(components)
        TxtSearchTerm1 = New CMCv.txt(components)
        TxtPlantName2 = New CMCv.txt(components)
        TxtCity = New CMCv.txt(components)
        TxtPostalCode = New CMCv.txt(components)
        TxtDescription = New CMCv.txt(components)
        TxtSearchTerm2 = New CMCv.txt(components)
        Lbl2 = New CMCv.lbl(components)
        Lbl3 = New CMCv.lbl(components)
        Lbl4 = New CMCv.lbl(components)
        Lbl5 = New CMCv.lbl(components)
        Lbl6 = New CMCv.lbl(components)
        Lbl7 = New CMCv.lbl(components)
        Lbl8 = New CMCv.lbl(components)
        Lbl9 = New CMCv.lbl(components)
        BtnSave = New CMCv.btn(components)
        BtnCancel = New CMCv.btn(components)
        Chk1 = New CMCv.chk(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Chk1)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 434)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(456, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(Chk1, 0)
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
        pnl_.Size = New Size(456, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.AutoScroll = True
        SLFPanel.Controls.Add(Lbl9)
        SLFPanel.Controls.Add(Lbl8)
        SLFPanel.Controls.Add(Lbl7)
        SLFPanel.Controls.Add(Lbl6)
        SLFPanel.Controls.Add(Lbl5)
        SLFPanel.Controls.Add(Lbl4)
        SLFPanel.Controls.Add(Lbl3)
        SLFPanel.Controls.Add(Lbl2)
        SLFPanel.Controls.Add(TxtSearchTerm2)
        SLFPanel.Controls.Add(TxtDescription)
        SLFPanel.Controls.Add(TxtPostalCode)
        SLFPanel.Controls.Add(TxtCity)
        SLFPanel.Controls.Add(TxtPlantName2)
        SLFPanel.Controls.Add(TxtSearchTerm1)
        SLFPanel.Controls.Add(TxtPlantName1)
        SLFPanel.Controls.Add(TxtPlantCode)
        SLFPanel.Controls.Add(Lbl1)
        SLFPanel.Controls.Add(CboCompany)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(456, 492)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(CboCompany, 0)
        SLFPanel.Controls.SetChildIndex(Lbl1, 0)
        SLFPanel.Controls.SetChildIndex(TxtPlantCode, 0)
        SLFPanel.Controls.SetChildIndex(TxtPlantName1, 0)
        SLFPanel.Controls.SetChildIndex(TxtSearchTerm1, 0)
        SLFPanel.Controls.SetChildIndex(TxtPlantName2, 0)
        SLFPanel.Controls.SetChildIndex(TxtCity, 0)
        SLFPanel.Controls.SetChildIndex(TxtPostalCode, 0)
        SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
        SLFPanel.Controls.SetChildIndex(TxtSearchTerm2, 0)
        SLFPanel.Controls.SetChildIndex(Lbl2, 0)
        SLFPanel.Controls.SetChildIndex(Lbl3, 0)
        SLFPanel.Controls.SetChildIndex(Lbl4, 0)
        SLFPanel.Controls.SetChildIndex(Lbl5, 0)
        SLFPanel.Controls.SetChildIndex(Lbl6, 0)
        SLFPanel.Controls.SetChildIndex(Lbl7, 0)
        SLFPanel.Controls.SetChildIndex(Lbl8, 0)
        SLFPanel.Controls.SetChildIndex(Lbl9, 0)
        ' 
        ' CboCompany
        ' 
        CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
        CboCompany.FlatStyle = FlatStyle.Flat
        CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboCompany.FormattingEnabled = True
        CboCompany.Location = New Point(164, 12)
        CboCompany.Margin = New Padding(4, 3, 4, 3)
        CboCompany.Name = "CboCompany"
        CboCompany.Size = New Size(241, 29)
        CboCompany.TabIndex = 0
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
        Lbl1.TabIndex = 997
        Lbl1.Text = "Company"
        ' 
        ' TxtPlantCode
        ' 
        TxtPlantCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlantCode.Location = New Point(164, 52)
        TxtPlantCode.Margin = New Padding(4, 3, 4, 3)
        TxtPlantCode.MaxLength = 10
        TxtPlantCode.Name = "TxtPlantCode"
        TxtPlantCode.Size = New Size(185, 29)
        TxtPlantCode.SLFAutoTrim = True
        TxtPlantCode.SLFHarusDiisi = True
        TxtPlantCode.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPlantCode.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPlantCode.SLFHightlightSaatFokus = True
        TxtPlantCode.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPlantCode.SLFIsBlank = True
        TxtPlantCode.SLFIsSearchBox = False
        TxtPlantCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPlantCode.SLFPilihSemuaSaatFokus = True
        TxtPlantCode.SLFPwdLengthMin = 8
        TxtPlantCode.SLFPwdStrengthCalculate = False
        TxtPlantCode.SLFPwdStrengthScore = 0
        TxtPlantCode.SLFPwdStrengthText = Nothing
        TxtPlantCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPlantCode.SLFSearchBoxText = "Type then press Enter"
        TxtPlantCode.SLFSQLText = ""
        TxtPlantCode.SLFTanpaSpasi = False
        TxtPlantCode.SLFValidasiField = Nothing
        TxtPlantCode.TabIndex = 1
        TxtPlantCode.Tag = "txt"
        TxtPlantCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtPlantName1
        ' 
        TxtPlantName1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlantName1.Location = New Point(166, 92)
        TxtPlantName1.Margin = New Padding(4, 3, 4, 3)
        TxtPlantName1.MaxLength = 255
        TxtPlantName1.Name = "TxtPlantName1"
        TxtPlantName1.Size = New Size(240, 29)
        TxtPlantName1.SLFAutoTrim = True
        TxtPlantName1.SLFHarusDiisi = True
        TxtPlantName1.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPlantName1.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPlantName1.SLFHightlightSaatFokus = True
        TxtPlantName1.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPlantName1.SLFIsBlank = True
        TxtPlantName1.SLFIsSearchBox = False
        TxtPlantName1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPlantName1.SLFPilihSemuaSaatFokus = True
        TxtPlantName1.SLFPwdLengthMin = 8
        TxtPlantName1.SLFPwdStrengthCalculate = False
        TxtPlantName1.SLFPwdStrengthScore = 0
        TxtPlantName1.SLFPwdStrengthText = Nothing
        TxtPlantName1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPlantName1.SLFSearchBoxText = "Type then press Enter"
        TxtPlantName1.SLFSQLText = ""
        TxtPlantName1.SLFTanpaSpasi = False
        TxtPlantName1.SLFValidasiField = Nothing
        TxtPlantName1.TabIndex = 2
        TxtPlantName1.Tag = "txt"
        ' 
        ' TxtSearchTerm1
        ' 
        TxtSearchTerm1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm1.Location = New Point(166, 294)
        TxtSearchTerm1.Margin = New Padding(4, 3, 4, 3)
        TxtSearchTerm1.MaxLength = 255
        TxtSearchTerm1.Name = "TxtSearchTerm1"
        TxtSearchTerm1.Size = New Size(240, 29)
        TxtSearchTerm1.SLFAutoTrim = True
        TxtSearchTerm1.SLFHarusDiisi = True
        TxtSearchTerm1.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm1.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm1.SLFHightlightSaatFokus = True
        TxtSearchTerm1.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtSearchTerm1.SLFIsBlank = True
        TxtSearchTerm1.SLFIsSearchBox = False
        TxtSearchTerm1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtSearchTerm1.SLFPilihSemuaSaatFokus = False
        TxtSearchTerm1.SLFPwdLengthMin = 8
        TxtSearchTerm1.SLFPwdStrengthCalculate = False
        TxtSearchTerm1.SLFPwdStrengthScore = 0
        TxtSearchTerm1.SLFPwdStrengthText = Nothing
        TxtSearchTerm1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtSearchTerm1.SLFSearchBoxText = "Type then press Enter"
        TxtSearchTerm1.SLFSQLText = ""
        TxtSearchTerm1.SLFTanpaSpasi = False
        TxtSearchTerm1.SLFValidasiField = Nothing
        TxtSearchTerm1.TabIndex = 7
        TxtSearchTerm1.Tag = "txt"
        ' 
        ' TxtPlantName2
        ' 
        TxtPlantName2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlantName2.Location = New Point(166, 133)
        TxtPlantName2.Margin = New Padding(4, 3, 4, 3)
        TxtPlantName2.MaxLength = 255
        TxtPlantName2.Name = "TxtPlantName2"
        TxtPlantName2.Size = New Size(240, 29)
        TxtPlantName2.SLFAutoTrim = True
        TxtPlantName2.SLFHarusDiisi = False
        TxtPlantName2.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPlantName2.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPlantName2.SLFHightlightSaatFokus = True
        TxtPlantName2.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPlantName2.SLFIsBlank = True
        TxtPlantName2.SLFIsSearchBox = False
        TxtPlantName2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPlantName2.SLFPilihSemuaSaatFokus = True
        TxtPlantName2.SLFPwdLengthMin = 8
        TxtPlantName2.SLFPwdStrengthCalculate = False
        TxtPlantName2.SLFPwdStrengthScore = 0
        TxtPlantName2.SLFPwdStrengthText = Nothing
        TxtPlantName2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPlantName2.SLFSearchBoxText = "Type then press Enter"
        TxtPlantName2.SLFSQLText = ""
        TxtPlantName2.SLFTanpaSpasi = False
        TxtPlantName2.SLFValidasiField = Nothing
        TxtPlantName2.TabIndex = 3
        TxtPlantName2.Tag = "txt"
        ' 
        ' TxtCity
        ' 
        TxtCity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCity.Location = New Point(166, 173)
        TxtCity.Margin = New Padding(4, 3, 4, 3)
        TxtCity.MaxLength = 255
        TxtCity.Name = "TxtCity"
        TxtCity.Size = New Size(240, 29)
        TxtCity.SLFAutoTrim = True
        TxtCity.SLFHarusDiisi = True
        TxtCity.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtCity.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtCity.SLFHightlightSaatFokus = True
        TxtCity.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtCity.SLFIsBlank = True
        TxtCity.SLFIsSearchBox = False
        TxtCity.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtCity.SLFPilihSemuaSaatFokus = True
        TxtCity.SLFPwdLengthMin = 8
        TxtCity.SLFPwdStrengthCalculate = False
        TxtCity.SLFPwdStrengthScore = 0
        TxtCity.SLFPwdStrengthText = Nothing
        TxtCity.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtCity.SLFSearchBoxText = "Type then press Enter"
        TxtCity.SLFSQLText = ""
        TxtCity.SLFTanpaSpasi = False
        TxtCity.SLFValidasiField = Nothing
        TxtCity.TabIndex = 4
        TxtCity.Tag = "txt"
        ' 
        ' TxtPostalCode
        ' 
        TxtPostalCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPostalCode.Location = New Point(166, 213)
        TxtPostalCode.Margin = New Padding(4, 3, 4, 3)
        TxtPostalCode.MaxLength = 6
        TxtPostalCode.Name = "TxtPostalCode"
        TxtPostalCode.Size = New Size(110, 29)
        TxtPostalCode.SLFAutoTrim = True
        TxtPostalCode.SLFHarusDiisi = False
        TxtPostalCode.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtPostalCode.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtPostalCode.SLFHightlightSaatFokus = True
        TxtPostalCode.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtPostalCode.SLFIsBlank = True
        TxtPostalCode.SLFIsSearchBox = False
        TxtPostalCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPostalCode.SLFPilihSemuaSaatFokus = True
        TxtPostalCode.SLFPwdLengthMin = 8
        TxtPostalCode.SLFPwdStrengthCalculate = False
        TxtPostalCode.SLFPwdStrengthScore = 0
        TxtPostalCode.SLFPwdStrengthText = Nothing
        TxtPostalCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPostalCode.SLFSearchBoxText = "Type then press Enter"
        TxtPostalCode.SLFSQLText = ""
        TxtPostalCode.SLFTanpaSpasi = False
        TxtPostalCode.SLFValidasiField = Nothing
        TxtPostalCode.TabIndex = 5
        TxtPostalCode.Tag = "txt"
        TxtPostalCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(166, 254)
        TxtDescription.Margin = New Padding(4, 3, 4, 3)
        TxtDescription.MaxLength = 255
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(240, 29)
        TxtDescription.SLFAutoTrim = True
        TxtDescription.SLFHarusDiisi = True
        TxtDescription.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.SLFHightlightSaatFokus = True
        TxtDescription.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.SLFIsBlank = True
        TxtDescription.SLFIsSearchBox = False
        TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtDescription.SLFPilihSemuaSaatFokus = False
        TxtDescription.SLFPwdLengthMin = 8
        TxtDescription.SLFPwdStrengthCalculate = False
        TxtDescription.SLFPwdStrengthScore = 0
        TxtDescription.SLFPwdStrengthText = Nothing
        TxtDescription.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtDescription.SLFSearchBoxText = "Type then press Enter"
        TxtDescription.SLFSQLText = ""
        TxtDescription.SLFTanpaSpasi = False
        TxtDescription.SLFValidasiField = Nothing
        TxtDescription.TabIndex = 6
        TxtDescription.Tag = "txt"
        ' 
        ' TxtSearchTerm2
        ' 
        TxtSearchTerm2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm2.Location = New Point(164, 335)
        TxtSearchTerm2.Margin = New Padding(4, 3, 4, 3)
        TxtSearchTerm2.MaxLength = 255
        TxtSearchTerm2.Name = "TxtSearchTerm2"
        TxtSearchTerm2.Size = New Size(240, 29)
        TxtSearchTerm2.SLFAutoTrim = True
        TxtSearchTerm2.SLFHarusDiisi = False
        TxtSearchTerm2.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm2.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm2.SLFHightlightSaatFokus = True
        TxtSearchTerm2.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtSearchTerm2.SLFIsBlank = True
        TxtSearchTerm2.SLFIsSearchBox = False
        TxtSearchTerm2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtSearchTerm2.SLFPilihSemuaSaatFokus = False
        TxtSearchTerm2.SLFPwdLengthMin = 8
        TxtSearchTerm2.SLFPwdStrengthCalculate = False
        TxtSearchTerm2.SLFPwdStrengthScore = 0
        TxtSearchTerm2.SLFPwdStrengthText = Nothing
        TxtSearchTerm2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtSearchTerm2.SLFSearchBoxText = "Type then press Enter"
        TxtSearchTerm2.SLFSQLText = ""
        TxtSearchTerm2.SLFTanpaSpasi = False
        TxtSearchTerm2.SLFValidasiField = Nothing
        TxtSearchTerm2.TabIndex = 8
        TxtSearchTerm2.Tag = "txt"
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
        Lbl2.TabIndex = 1006
        Lbl2.Text = "Plant Code"
        ' 
        ' Lbl3
        ' 
        Lbl3.AutoSize = True
        Lbl3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(37, 96)
        Lbl3.Margin = New Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(104, 21)
        Lbl3.SLFCustomElipsis = False
        Lbl3.TabIndex = 1007
        Lbl3.Text = "Plant Name 1"
        ' 
        ' Lbl4
        ' 
        Lbl4.AutoSize = True
        Lbl4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl4.Location = New Point(37, 136)
        Lbl4.Margin = New Padding(4, 0, 4, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Size(104, 21)
        Lbl4.SLFCustomElipsis = False
        Lbl4.TabIndex = 1008
        Lbl4.Text = "Plant Name 2"
        ' 
        ' Lbl5
        ' 
        Lbl5.AutoSize = True
        Lbl5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl5.Location = New Point(114, 177)
        Lbl5.Margin = New Padding(4, 0, 4, 0)
        Lbl5.Name = "Lbl5"
        Lbl5.Size = New Size(37, 21)
        Lbl5.SLFCustomElipsis = False
        Lbl5.TabIndex = 1009
        Lbl5.Text = "City"
        ' 
        ' Lbl6
        ' 
        Lbl6.AutoSize = True
        Lbl6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl6.Location = New Point(52, 217)
        Lbl6.Margin = New Padding(4, 0, 4, 0)
        Lbl6.Name = "Lbl6"
        Lbl6.Size = New Size(91, 21)
        Lbl6.SLFCustomElipsis = False
        Lbl6.TabIndex = 1010
        Lbl6.Text = "Postal Code"
        ' 
        ' Lbl7
        ' 
        Lbl7.AutoSize = True
        Lbl7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl7.Location = New Point(55, 257)
        Lbl7.Margin = New Padding(4, 0, 4, 0)
        Lbl7.Name = "Lbl7"
        Lbl7.Size = New Size(89, 21)
        Lbl7.SLFCustomElipsis = False
        Lbl7.TabIndex = 1011
        Lbl7.Text = "Description"
        ' 
        ' Lbl8
        ' 
        Lbl8.AutoSize = True
        Lbl8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl8.Location = New Point(31, 338)
        Lbl8.Margin = New Padding(4, 0, 4, 0)
        Lbl8.Name = "Lbl8"
        Lbl8.Size = New Size(108, 21)
        Lbl8.SLFCustomElipsis = False
        Lbl8.TabIndex = 1012
        Lbl8.Text = "Search Term 2"
        ' 
        ' Lbl9
        ' 
        Lbl9.AutoSize = True
        Lbl9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl9.Location = New Point(33, 298)
        Lbl9.Margin = New Padding(4, 0, 4, 0)
        Lbl9.Name = "Lbl9"
        Lbl9.Size = New Size(108, 21)
        Lbl9.SLFCustomElipsis = False
        Lbl9.TabIndex = 1013
        Lbl9.Text = "Search Term 1"
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
        BtnSave.Location = New Point(201, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnSave.SLFTampilkanFocusBorder = False
        BtnSave.SLFValidasiSemuaInput = False
        BtnSave.SLFValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 600
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
        BtnCancel.Location = New Point(325, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 602
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' Chk1
        ' 
        Chk1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Chk1.AutoSize = True
        Chk1.BackColor = Color.Transparent
        Chk1.FlatStyle = FlatStyle.Flat
        Chk1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Chk1.ForeColor = Color.Tomato
        Chk1.Location = New Point(48, 17)
        Chk1.Margin = New Padding(4, 3, 4, 3)
        Chk1.Name = "Chk1"
        Chk1.Size = New Size(146, 25)
        Chk1.TabIndex = 601
        Chk1.Text = "Add new on Save"
        Chk1.UseVisualStyleBackColor = False
        ' 
        ' PLNT_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(456, 575)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "PLNT_Editor"
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

    Friend WithEvents CboCompany As CMCv.cbo
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Lbl9 As CMCv.lbl
    Friend WithEvents Lbl8 As CMCv.lbl
    Friend WithEvents Lbl7 As CMCv.lbl
    Friend WithEvents Lbl6 As CMCv.lbl
    Friend WithEvents Lbl5 As CMCv.lbl
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents TxtSearchTerm2 As CMCv.txt
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents TxtPostalCode As CMCv.txt
    Friend WithEvents TxtCity As CMCv.txt
    Friend WithEvents TxtPlantName2 As CMCv.txt
    Friend WithEvents TxtSearchTerm1 As CMCv.txt
    Friend WithEvents TxtPlantName1 As CMCv.txt
    Friend WithEvents TxtPlantCode As CMCv.txt
    Friend WithEvents Chk1 As CMCv.chk
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
End Class
