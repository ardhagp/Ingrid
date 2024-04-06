<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PLNT_Editor
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
        CboCompany.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        Lbl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(68, 15)
        Lbl1.Margin = New Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(77, 21)
        Lbl1.XOCustomElipsis = False
        Lbl1.TabIndex = 997
        Lbl1.Text = "Company"
        ' 
        ' TxtPlantCode
        ' 
        TxtPlantCode.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlantCode.Location = New Point(164, 52)
        TxtPlantCode.Margin = New Padding(4, 3, 4, 3)
        TxtPlantCode.MaxLength = 10
        TxtPlantCode.Name = "TxtPlantCode"
        TxtPlantCode.Size = New Size(185, 29)
        TxtPlantCode.XOAutoTrim = True
        TxtPlantCode.XOHarusDiisi = True
        TxtPlantCode.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPlantCode.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPlantCode.XOHightlightSaatFokus = True
        TxtPlantCode.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPlantCode.XOIsBlank = True
        TxtPlantCode.XOIsSearchBox = False
        TxtPlantCode.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPlantCode.XOPilihSemuaSaatFokus = True
        TxtPlantCode.XOPwdLengthMin = 8
        TxtPlantCode.XOPwdStrengthCalculate = False
        TxtPlantCode.XOPwdStrengthScore = 0
        TxtPlantCode.XOPwdStrengthText = Nothing
        TxtPlantCode.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPlantCode.XOSearchBoxText = "Type then press Enter"
        TxtPlantCode.XOSQLText = ""
        TxtPlantCode.XOTanpaSpasi = False
        TxtPlantCode.XOValidasiField = Nothing
        TxtPlantCode.TabIndex = 1
        TxtPlantCode.Tag = "txt"
        TxtPlantCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtPlantName1
        ' 
        TxtPlantName1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlantName1.Location = New Point(166, 92)
        TxtPlantName1.Margin = New Padding(4, 3, 4, 3)
        TxtPlantName1.MaxLength = 255
        TxtPlantName1.Name = "TxtPlantName1"
        TxtPlantName1.Size = New Size(240, 29)
        TxtPlantName1.XOAutoTrim = True
        TxtPlantName1.XOHarusDiisi = True
        TxtPlantName1.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPlantName1.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPlantName1.XOHightlightSaatFokus = True
        TxtPlantName1.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPlantName1.XOIsBlank = True
        TxtPlantName1.XOIsSearchBox = False
        TxtPlantName1.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPlantName1.XOPilihSemuaSaatFokus = True
        TxtPlantName1.XOPwdLengthMin = 8
        TxtPlantName1.XOPwdStrengthCalculate = False
        TxtPlantName1.XOPwdStrengthScore = 0
        TxtPlantName1.XOPwdStrengthText = Nothing
        TxtPlantName1.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPlantName1.XOSearchBoxText = "Type then press Enter"
        TxtPlantName1.XOSQLText = ""
        TxtPlantName1.XOTanpaSpasi = False
        TxtPlantName1.XOValidasiField = Nothing
        TxtPlantName1.TabIndex = 2
        TxtPlantName1.Tag = "txt"
        ' 
        ' TxtSearchTerm1
        ' 
        TxtSearchTerm1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm1.Location = New Point(166, 294)
        TxtSearchTerm1.Margin = New Padding(4, 3, 4, 3)
        TxtSearchTerm1.MaxLength = 255
        TxtSearchTerm1.Name = "TxtSearchTerm1"
        TxtSearchTerm1.Size = New Size(240, 29)
        TxtSearchTerm1.XOAutoTrim = True
        TxtSearchTerm1.XOHarusDiisi = True
        TxtSearchTerm1.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm1.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm1.XOHightlightSaatFokus = True
        TxtSearchTerm1.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtSearchTerm1.XOIsBlank = True
        TxtSearchTerm1.XOIsSearchBox = False
        TxtSearchTerm1.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtSearchTerm1.XOPilihSemuaSaatFokus = False
        TxtSearchTerm1.XOPwdLengthMin = 8
        TxtSearchTerm1.XOPwdStrengthCalculate = False
        TxtSearchTerm1.XOPwdStrengthScore = 0
        TxtSearchTerm1.XOPwdStrengthText = Nothing
        TxtSearchTerm1.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtSearchTerm1.XOSearchBoxText = "Type then press Enter"
        TxtSearchTerm1.XOSQLText = ""
        TxtSearchTerm1.XOTanpaSpasi = False
        TxtSearchTerm1.XOValidasiField = Nothing
        TxtSearchTerm1.TabIndex = 7
        TxtSearchTerm1.Tag = "txt"
        ' 
        ' TxtPlantName2
        ' 
        TxtPlantName2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlantName2.Location = New Point(166, 133)
        TxtPlantName2.Margin = New Padding(4, 3, 4, 3)
        TxtPlantName2.MaxLength = 255
        TxtPlantName2.Name = "TxtPlantName2"
        TxtPlantName2.Size = New Size(240, 29)
        TxtPlantName2.XOAutoTrim = True
        TxtPlantName2.XOHarusDiisi = False
        TxtPlantName2.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPlantName2.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPlantName2.XOHightlightSaatFokus = True
        TxtPlantName2.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPlantName2.XOIsBlank = True
        TxtPlantName2.XOIsSearchBox = False
        TxtPlantName2.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPlantName2.XOPilihSemuaSaatFokus = True
        TxtPlantName2.XOPwdLengthMin = 8
        TxtPlantName2.XOPwdStrengthCalculate = False
        TxtPlantName2.XOPwdStrengthScore = 0
        TxtPlantName2.XOPwdStrengthText = Nothing
        TxtPlantName2.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPlantName2.XOSearchBoxText = "Type then press Enter"
        TxtPlantName2.XOSQLText = ""
        TxtPlantName2.XOTanpaSpasi = False
        TxtPlantName2.XOValidasiField = Nothing
        TxtPlantName2.TabIndex = 3
        TxtPlantName2.Tag = "txt"
        ' 
        ' TxtCity
        ' 
        TxtCity.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCity.Location = New Point(166, 173)
        TxtCity.Margin = New Padding(4, 3, 4, 3)
        TxtCity.MaxLength = 255
        TxtCity.Name = "TxtCity"
        TxtCity.Size = New Size(240, 29)
        TxtCity.XOAutoTrim = True
        TxtCity.XOHarusDiisi = True
        TxtCity.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtCity.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtCity.XOHightlightSaatFokus = True
        TxtCity.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtCity.XOIsBlank = True
        TxtCity.XOIsSearchBox = False
        TxtCity.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtCity.XOPilihSemuaSaatFokus = True
        TxtCity.XOPwdLengthMin = 8
        TxtCity.XOPwdStrengthCalculate = False
        TxtCity.XOPwdStrengthScore = 0
        TxtCity.XOPwdStrengthText = Nothing
        TxtCity.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtCity.XOSearchBoxText = "Type then press Enter"
        TxtCity.XOSQLText = ""
        TxtCity.XOTanpaSpasi = False
        TxtCity.XOValidasiField = Nothing
        TxtCity.TabIndex = 4
        TxtCity.Tag = "txt"
        ' 
        ' TxtPostalCode
        ' 
        TxtPostalCode.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPostalCode.Location = New Point(166, 213)
        TxtPostalCode.Margin = New Padding(4, 3, 4, 3)
        TxtPostalCode.MaxLength = 6
        TxtPostalCode.Name = "TxtPostalCode"
        TxtPostalCode.Size = New Size(110, 29)
        TxtPostalCode.XOAutoTrim = True
        TxtPostalCode.XOHarusDiisi = False
        TxtPostalCode.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPostalCode.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPostalCode.XOHightlightSaatFokus = True
        TxtPostalCode.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPostalCode.XOIsBlank = True
        TxtPostalCode.XOIsSearchBox = False
        TxtPostalCode.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtPostalCode.XOPilihSemuaSaatFokus = True
        TxtPostalCode.XOPwdLengthMin = 8
        TxtPostalCode.XOPwdStrengthCalculate = False
        TxtPostalCode.XOPwdStrengthScore = 0
        TxtPostalCode.XOPwdStrengthText = Nothing
        TxtPostalCode.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtPostalCode.XOSearchBoxText = "Type then press Enter"
        TxtPostalCode.XOSQLText = ""
        TxtPostalCode.XOTanpaSpasi = False
        TxtPostalCode.XOValidasiField = Nothing
        TxtPostalCode.TabIndex = 5
        TxtPostalCode.Tag = "txt"
        TxtPostalCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(166, 254)
        TxtDescription.Margin = New Padding(4, 3, 4, 3)
        TxtDescription.MaxLength = 255
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(240, 29)
        TxtDescription.XOAutoTrim = True
        TxtDescription.XOHarusDiisi = True
        TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.XOHightlightSaatFokus = True
        TxtDescription.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.XOIsBlank = True
        TxtDescription.XOIsSearchBox = False
        TxtDescription.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtDescription.XOPilihSemuaSaatFokus = False
        TxtDescription.XOPwdLengthMin = 8
        TxtDescription.XOPwdStrengthCalculate = False
        TxtDescription.XOPwdStrengthScore = 0
        TxtDescription.XOPwdStrengthText = Nothing
        TxtDescription.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtDescription.XOSearchBoxText = "Type then press Enter"
        TxtDescription.XOSQLText = ""
        TxtDescription.XOTanpaSpasi = False
        TxtDescription.XOValidasiField = Nothing
        TxtDescription.TabIndex = 6
        TxtDescription.Tag = "txt"
        ' 
        ' TxtSearchTerm2
        ' 
        TxtSearchTerm2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm2.Location = New Point(164, 335)
        TxtSearchTerm2.Margin = New Padding(4, 3, 4, 3)
        TxtSearchTerm2.MaxLength = 255
        TxtSearchTerm2.Name = "TxtSearchTerm2"
        TxtSearchTerm2.Size = New Size(240, 29)
        TxtSearchTerm2.XOAutoTrim = True
        TxtSearchTerm2.XOHarusDiisi = False
        TxtSearchTerm2.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm2.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm2.XOHightlightSaatFokus = True
        TxtSearchTerm2.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtSearchTerm2.XOIsBlank = True
        TxtSearchTerm2.XOIsSearchBox = False
        TxtSearchTerm2.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtSearchTerm2.XOPilihSemuaSaatFokus = False
        TxtSearchTerm2.XOPwdLengthMin = 8
        TxtSearchTerm2.XOPwdStrengthCalculate = False
        TxtSearchTerm2.XOPwdStrengthScore = 0
        TxtSearchTerm2.XOPwdStrengthText = Nothing
        TxtSearchTerm2.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        TxtSearchTerm2.XOSearchBoxText = "Type then press Enter"
        TxtSearchTerm2.XOSQLText = ""
        TxtSearchTerm2.XOTanpaSpasi = False
        TxtSearchTerm2.XOValidasiField = Nothing
        TxtSearchTerm2.TabIndex = 8
        TxtSearchTerm2.Tag = "txt"
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl2.Location = New Point(58, 55)
        Lbl2.Margin = New Padding(4, 0, 4, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(85, 21)
        Lbl2.XOCustomElipsis = False
        Lbl2.TabIndex = 1006
        Lbl2.Text = "Plant Code"
        ' 
        ' Lbl3
        ' 
        Lbl3.AutoSize = True
        Lbl3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(37, 96)
        Lbl3.Margin = New Padding(4, 0, 4, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(104, 21)
        Lbl3.XOCustomElipsis = False
        Lbl3.TabIndex = 1007
        Lbl3.Text = "Plant Name 1"
        ' 
        ' Lbl4
        ' 
        Lbl4.AutoSize = True
        Lbl4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl4.Location = New Point(37, 136)
        Lbl4.Margin = New Padding(4, 0, 4, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Size(104, 21)
        Lbl4.XOCustomElipsis = False
        Lbl4.TabIndex = 1008
        Lbl4.Text = "Plant Name 2"
        ' 
        ' Lbl5
        ' 
        Lbl5.AutoSize = True
        Lbl5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl5.Location = New Point(114, 177)
        Lbl5.Margin = New Padding(4, 0, 4, 0)
        Lbl5.Name = "Lbl5"
        Lbl5.Size = New Size(37, 21)
        Lbl5.XOCustomElipsis = False
        Lbl5.TabIndex = 1009
        Lbl5.Text = "City"
        ' 
        ' Lbl6
        ' 
        Lbl6.AutoSize = True
        Lbl6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl6.Location = New Point(52, 217)
        Lbl6.Margin = New Padding(4, 0, 4, 0)
        Lbl6.Name = "Lbl6"
        Lbl6.Size = New Size(91, 21)
        Lbl6.XOCustomElipsis = False
        Lbl6.TabIndex = 1010
        Lbl6.Text = "Postal Code"
        ' 
        ' Lbl7
        ' 
        Lbl7.AutoSize = True
        Lbl7.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl7.Location = New Point(55, 257)
        Lbl7.Margin = New Padding(4, 0, 4, 0)
        Lbl7.Name = "Lbl7"
        Lbl7.Size = New Size(89, 21)
        Lbl7.XOCustomElipsis = False
        Lbl7.TabIndex = 1011
        Lbl7.Text = "Description"
        ' 
        ' Lbl8
        ' 
        Lbl8.AutoSize = True
        Lbl8.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl8.Location = New Point(31, 338)
        Lbl8.Margin = New Padding(4, 0, 4, 0)
        Lbl8.Name = "Lbl8"
        Lbl8.Size = New Size(108, 21)
        Lbl8.XOCustomElipsis = False
        Lbl8.TabIndex = 1012
        Lbl8.Text = "Search Term 2"
        ' 
        ' Lbl9
        ' 
        Lbl9.AutoSize = True
        Lbl9.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl9.Location = New Point(33, 298)
        Lbl9.Margin = New Padding(4, 0, 4, 0)
        Lbl9.Name = "Lbl9"
        Lbl9.Size = New Size(108, 21)
        Lbl9.XOCustomElipsis = False
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
        BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(201, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnSave.XOTampilkanFocusBorder = False
        BtnSave.XOValidasiSemuaInput = False
        BtnSave.XOValidasiSemuaInputTag = Nothing
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
        BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(325, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
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
        Chk1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
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
