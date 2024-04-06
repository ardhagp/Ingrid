<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONN_Editor
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CONN_Editor))
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        TbctlBasic = New tbctl(components)
        tp1_ = New TabPage()
        ULbl_FileStorage = New ULbl()
        ULbl_DataStorage = New ULbl()
        Txt_FileStorage = New txt(components)
        Txt_DataStorage = New txt(components)
        Chk_Default = New chk(components)
        Txt_Password = New txt(components)
        Txt_Username = New txt(components)
        ULbl_Password = New ULbl()
        ULbl_Username = New ULbl()
        ULbl_Port = New ULbl()
        Txt_Port = New txt(components)
        ULbl_Address = New ULbl()
        ULbl_Name = New ULbl()
        Txt_ConnectionName = New txt(components)
        Txt_Address = New txt(components)
        Btn_Test = New btn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlBasic.SuspendLayout()
        tp1_.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn_Test)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 431)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(565, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn_Test, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(565, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TbctlBasic)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(565, 489)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TbctlBasic, 0)
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
        BtnSave.Location = New Point(310, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.XOTampilkanFocusBorder = False
        BtnSave.XOValidasiSemuaInput = False
        BtnSave.XOValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 9
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
        BtnCancel.Location = New Point(434, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 10
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' TbctlBasic
        ' 
        TbctlBasic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TbctlBasic.Controls.Add(tp1_)
        TbctlBasic.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlBasic.Location = New Point(14, 7)
        TbctlBasic.Margin = New Padding(4, 3, 4, 3)
        TbctlBasic.Name = "TbctlBasic"
        TbctlBasic.SelectedIndex = 0
        TbctlBasic.Size = New Size(537, 417)
        TbctlBasic.TabIndex = 997
        ' 
        ' tp1_
        ' 
        tp1_.Controls.Add(ULbl_FileStorage)
        tp1_.Controls.Add(ULbl_DataStorage)
        tp1_.Controls.Add(Txt_FileStorage)
        tp1_.Controls.Add(Txt_DataStorage)
        tp1_.Controls.Add(Chk_Default)
        tp1_.Controls.Add(Txt_Password)
        tp1_.Controls.Add(Txt_Username)
        tp1_.Controls.Add(ULbl_Password)
        tp1_.Controls.Add(ULbl_Username)
        tp1_.Controls.Add(ULbl_Port)
        tp1_.Controls.Add(Txt_Port)
        tp1_.Controls.Add(ULbl_Address)
        tp1_.Controls.Add(ULbl_Name)
        tp1_.Controls.Add(Txt_ConnectionName)
        tp1_.Controls.Add(Txt_Address)
        tp1_.Location = New Point(4, 30)
        tp1_.Margin = New Padding(4, 3, 4, 3)
        tp1_.Name = "tp1_"
        tp1_.Padding = New Padding(4, 3, 4, 3)
        tp1_.Size = New Size(529, 383)
        tp1_.TabIndex = 0
        tp1_.Text = "CONFIG"
        tp1_.UseVisualStyleBackColor = True
        ' 
        ' ULbl_FileStorage
        ' 
        ULbl_FileStorage.BackColor = Color.MistyRose
        ULbl_FileStorage.Location = New Point(8, 265)
        ULbl_FileStorage.Margin = New Padding(5, 6, 5, 6)
        ULbl_FileStorage.Name = "ULbl_FileStorage"
        ULbl_FileStorage.Size = New Size(197, 33)
        ULbl_FileStorage.SLFText = "File Storage"
        ULbl_FileStorage.SLFTextAdjuster = False
        ULbl_FileStorage.SLFTextBorder = False
        ULbl_FileStorage.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Red
        ULbl_FileStorage.TabIndex = 1009
        ' 
        ' ULbl_DataStorage
        ' 
        ULbl_DataStorage.BackColor = Color.MistyRose
        ULbl_DataStorage.Location = New Point(8, 225)
        ULbl_DataStorage.Margin = New Padding(5, 6, 5, 6)
        ULbl_DataStorage.Name = "ULbl_DataStorage"
        ULbl_DataStorage.Size = New Size(197, 33)
        ULbl_DataStorage.SLFText = "Data Storage"
        ULbl_DataStorage.SLFTextAdjuster = False
        ULbl_DataStorage.SLFTextBorder = False
        ULbl_DataStorage.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Red
        ULbl_DataStorage.TabIndex = 1008
        ' 
        ' Txt_FileStorage
        ' 
        Txt_FileStorage.BackColor = Color.White
        Txt_FileStorage.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_FileStorage.Location = New Point(214, 265)
        Txt_FileStorage.Margin = New Padding(4, 3, 4, 3)
        Txt_FileStorage.MaxLength = 255
        Txt_FileStorage.Name = "Txt_FileStorage"
        Txt_FileStorage.Size = New Size(306, 29)
        Txt_FileStorage.XOAutoTrim = True
        Txt_FileStorage.XOHarusDiisi = True
        Txt_FileStorage.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_FileStorage.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_FileStorage.XOHightlightSaatFokus = True
        Txt_FileStorage.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_FileStorage.XOIsBlank = True
        Txt_FileStorage.XOIsSearchBox = False
        Txt_FileStorage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_FileStorage.XOPilihSemuaSaatFokus = False
        Txt_FileStorage.XOPwdLengthMin = 0
        Txt_FileStorage.XOPwdStrengthCalculate = False
        Txt_FileStorage.XOPwdStrengthScore = 0
        Txt_FileStorage.XOPwdStrengthText = Nothing
        Txt_FileStorage.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_FileStorage.XOSearchBoxText = "Type then press Enter"
        Txt_FileStorage.XOSQLText = ""
        Txt_FileStorage.XOTanpaSpasi = False
        Txt_FileStorage.XOValidasiField = Nothing
        Txt_FileStorage.TabIndex = 6
        Txt_FileStorage.Tag = "txt"
        ' 
        ' Txt_DataStorage
        ' 
        Txt_DataStorage.BackColor = Color.White
        Txt_DataStorage.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_DataStorage.Location = New Point(214, 225)
        Txt_DataStorage.Margin = New Padding(4, 3, 4, 3)
        Txt_DataStorage.MaxLength = 255
        Txt_DataStorage.Name = "Txt_DataStorage"
        Txt_DataStorage.Size = New Size(306, 29)
        Txt_DataStorage.XOAutoTrim = True
        Txt_DataStorage.XOHarusDiisi = True
        Txt_DataStorage.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_DataStorage.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_DataStorage.XOHightlightSaatFokus = True
        Txt_DataStorage.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_DataStorage.XOIsBlank = True
        Txt_DataStorage.XOIsSearchBox = False
        Txt_DataStorage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_DataStorage.XOPilihSemuaSaatFokus = False
        Txt_DataStorage.XOPwdLengthMin = 8
        Txt_DataStorage.XOPwdStrengthCalculate = False
        Txt_DataStorage.XOPwdStrengthScore = 0
        Txt_DataStorage.XOPwdStrengthText = Nothing
        Txt_DataStorage.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_DataStorage.XOSearchBoxText = "Type then press Enter"
        Txt_DataStorage.XOSQLText = ""
        Txt_DataStorage.XOTanpaSpasi = False
        Txt_DataStorage.XOValidasiField = Nothing
        Txt_DataStorage.TabIndex = 5
        Txt_DataStorage.Tag = "txt"
        ' 
        ' Chk_Default
        ' 
        Chk_Default.AutoSize = True
        Chk_Default.BackColor = Color.Transparent
        Chk_Default.FlatStyle = FlatStyle.Flat
        Chk_Default.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Chk_Default.Location = New Point(214, 306)
        Chk_Default.Margin = New Padding(4, 3, 4, 3)
        Chk_Default.Name = "Chk_Default"
        Chk_Default.Size = New Size(204, 25)
        Chk_Default.TabIndex = 7
        Chk_Default.Text = "Set as Default Connection"
        Chk_Default.UseVisualStyleBackColor = False
        ' 
        ' Txt_Password
        ' 
        Txt_Password.BackColor = Color.White
        Txt_Password.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Password.Location = New Point(214, 185)
        Txt_Password.Margin = New Padding(4, 3, 4, 3)
        Txt_Password.MaxLength = 255
        Txt_Password.Name = "Txt_Password"
        Txt_Password.PasswordChar = "●"c
        Txt_Password.Size = New Size(306, 29)
        Txt_Password.XOAutoTrim = False
        Txt_Password.XOHarusDiisi = True
        Txt_Password.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Password.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Password.XOHightlightSaatFokus = True
        Txt_Password.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Password.XOIsBlank = True
        Txt_Password.XOIsSearchBox = False
        Txt_Password.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Password.XOPilihSemuaSaatFokus = False
        Txt_Password.XOPwdLengthMin = 8
        Txt_Password.XOPwdStrengthCalculate = False
        Txt_Password.XOPwdStrengthScore = 0
        Txt_Password.XOPwdStrengthText = Nothing
        Txt_Password.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Password.XOSearchBoxText = "Type then press Enter"
        Txt_Password.XOSQLText = ""
        Txt_Password.XOTanpaSpasi = False
        Txt_Password.XOValidasiField = Nothing
        Txt_Password.TabIndex = 4
        Txt_Password.Tag = "txt"
        ' 
        ' Txt_Username
        ' 
        Txt_Username.BackColor = Color.White
        Txt_Username.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Username.Location = New Point(214, 144)
        Txt_Username.Margin = New Padding(4, 3, 4, 3)
        Txt_Username.MaxLength = 255
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(306, 29)
        Txt_Username.XOAutoTrim = True
        Txt_Username.XOHarusDiisi = True
        Txt_Username.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Username.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Username.XOHightlightSaatFokus = True
        Txt_Username.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Username.XOIsBlank = True
        Txt_Username.XOIsSearchBox = False
        Txt_Username.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Username.XOPilihSemuaSaatFokus = False
        Txt_Username.XOPwdLengthMin = 8
        Txt_Username.XOPwdStrengthCalculate = False
        Txt_Username.XOPwdStrengthScore = 0
        Txt_Username.XOPwdStrengthText = Nothing
        Txt_Username.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Username.XOSearchBoxText = "Type then press Enter"
        Txt_Username.XOSQLText = ""
        Txt_Username.XOTanpaSpasi = False
        Txt_Username.XOValidasiField = Nothing
        Txt_Username.TabIndex = 3
        Txt_Username.Tag = "txt"
        ' 
        ' ULbl_Password
        ' 
        ULbl_Password.BackColor = Color.AliceBlue
        ULbl_Password.Location = New Point(8, 185)
        ULbl_Password.Margin = New Padding(5, 6, 5, 6)
        ULbl_Password.Name = "ULbl_Password"
        ULbl_Password.Size = New Size(197, 33)
        ULbl_Password.SLFText = "Password"
        ULbl_Password.SLFTextAdjuster = False
        ULbl_Password.SLFTextBorder = False
        ULbl_Password.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Password.TabIndex = 1005
        ' 
        ' ULbl_Username
        ' 
        ULbl_Username.BackColor = Color.AliceBlue
        ULbl_Username.Location = New Point(8, 144)
        ULbl_Username.Margin = New Padding(5, 6, 5, 6)
        ULbl_Username.Name = "ULbl_Username"
        ULbl_Username.Size = New Size(197, 33)
        ULbl_Username.SLFText = "Username"
        ULbl_Username.SLFTextAdjuster = False
        ULbl_Username.SLFTextBorder = False
        ULbl_Username.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Username.TabIndex = 1004
        ' 
        ' ULbl_Port
        ' 
        ULbl_Port.BackColor = Color.AliceBlue
        ULbl_Port.Location = New Point(8, 104)
        ULbl_Port.Margin = New Padding(5, 6, 5, 6)
        ULbl_Port.Name = "ULbl_Port"
        ULbl_Port.Size = New Size(197, 33)
        ULbl_Port.SLFText = "Port"
        ULbl_Port.SLFTextAdjuster = False
        ULbl_Port.SLFTextBorder = False
        ULbl_Port.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Port.TabIndex = 1003
        ' 
        ' Txt_Port
        ' 
        Txt_Port.BackColor = Color.White
        Txt_Port.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Port.Location = New Point(214, 104)
        Txt_Port.Margin = New Padding(4, 3, 4, 3)
        Txt_Port.MaxLength = 255
        Txt_Port.Name = "Txt_Port"
        Txt_Port.Size = New Size(114, 29)
        Txt_Port.XOAutoTrim = True
        Txt_Port.XOHarusDiisi = True
        Txt_Port.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Port.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Port.XOHightlightSaatFokus = True
        Txt_Port.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Port.XOIsBlank = True
        Txt_Port.XOIsSearchBox = False
        Txt_Port.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Port.XOPilihSemuaSaatFokus = False
        Txt_Port.XOPwdLengthMin = 8
        Txt_Port.XOPwdStrengthCalculate = False
        Txt_Port.XOPwdStrengthScore = 0
        Txt_Port.XOPwdStrengthText = Nothing
        Txt_Port.XORestriction = ControlCodeBase.enuRestriction.OnlyNumber
        Txt_Port.XOSearchBoxText = "Type then press Enter"
        Txt_Port.XOSQLText = ""
        Txt_Port.XOTanpaSpasi = False
        Txt_Port.XOValidasiField = Nothing
        Txt_Port.TabIndex = 2
        Txt_Port.Tag = "txt"
        Txt_Port.TextAlign = HorizontalAlignment.Center
        ' 
        ' ULbl_Address
        ' 
        ULbl_Address.BackColor = Color.AliceBlue
        ULbl_Address.Location = New Point(8, 63)
        ULbl_Address.Margin = New Padding(5, 6, 5, 6)
        ULbl_Address.Name = "ULbl_Address"
        ULbl_Address.Size = New Size(197, 33)
        ULbl_Address.SLFText = "Address"
        ULbl_Address.SLFTextAdjuster = False
        ULbl_Address.SLFTextBorder = False
        ULbl_Address.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Address.TabIndex = 1001
        ' 
        ' ULbl_Name
        ' 
        ULbl_Name.BackColor = Color.AliceBlue
        ULbl_Name.Location = New Point(8, 23)
        ULbl_Name.Margin = New Padding(5, 6, 5, 6)
        ULbl_Name.Name = "ULbl_Name"
        ULbl_Name.Size = New Size(197, 33)
        ULbl_Name.SLFText = "Connection Name"
        ULbl_Name.SLFTextAdjuster = False
        ULbl_Name.SLFTextBorder = False
        ULbl_Name.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Name.TabIndex = 1000
        ' 
        ' Txt_ConnectionName
        ' 
        Txt_ConnectionName.BackColor = Color.White
        Txt_ConnectionName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_ConnectionName.Location = New Point(214, 23)
        Txt_ConnectionName.Margin = New Padding(4, 3, 4, 3)
        Txt_ConnectionName.MaxLength = 255
        Txt_ConnectionName.Name = "Txt_ConnectionName"
        Txt_ConnectionName.Size = New Size(306, 29)
        Txt_ConnectionName.XOAutoTrim = True
        Txt_ConnectionName.XOHarusDiisi = True
        Txt_ConnectionName.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_ConnectionName.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_ConnectionName.XOHightlightSaatFokus = True
        Txt_ConnectionName.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_ConnectionName.XOIsBlank = True
        Txt_ConnectionName.XOIsSearchBox = False
        Txt_ConnectionName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_ConnectionName.XOPilihSemuaSaatFokus = False
        Txt_ConnectionName.XOPwdLengthMin = 8
        Txt_ConnectionName.XOPwdStrengthCalculate = False
        Txt_ConnectionName.XOPwdStrengthScore = 0
        Txt_ConnectionName.XOPwdStrengthText = Nothing
        Txt_ConnectionName.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_ConnectionName.XOSearchBoxText = "Type then press Enter"
        Txt_ConnectionName.XOSQLText = ""
        Txt_ConnectionName.XOTanpaSpasi = False
        Txt_ConnectionName.XOValidasiField = Nothing
        Txt_ConnectionName.TabIndex = 0
        Txt_ConnectionName.Tag = "txt"
        ' 
        ' Txt_Address
        ' 
        Txt_Address.BackColor = Color.White
        Txt_Address.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Address.Location = New Point(214, 63)
        Txt_Address.Margin = New Padding(4, 3, 4, 3)
        Txt_Address.MaxLength = 255
        Txt_Address.Name = "Txt_Address"
        Txt_Address.Size = New Size(306, 29)
        Txt_Address.XOAutoTrim = True
        Txt_Address.XOHarusDiisi = True
        Txt_Address.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Address.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Address.XOHightlightSaatFokus = True
        Txt_Address.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Address.XOIsBlank = True
        Txt_Address.XOIsSearchBox = False
        Txt_Address.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Address.XOPilihSemuaSaatFokus = False
        Txt_Address.XOPwdLengthMin = 8
        Txt_Address.XOPwdStrengthCalculate = False
        Txt_Address.XOPwdStrengthScore = 0
        Txt_Address.XOPwdStrengthText = Nothing
        Txt_Address.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Address.XOSearchBoxText = "Type then press Enter"
        Txt_Address.XOSQLText = ""
        Txt_Address.XOTanpaSpasi = False
        Txt_Address.XOValidasiField = Nothing
        Txt_Address.TabIndex = 1
        Txt_Address.Tag = "txt"
        ' 
        ' Btn_Test
        ' 
        Btn_Test.BackColor = Color.RoyalBlue
        Btn_Test.Cursor = Cursors.Hand
        Btn_Test.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        Btn_Test.FlatAppearance.BorderSize = 2
        Btn_Test.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        Btn_Test.FlatStyle = FlatStyle.Flat
        Btn_Test.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Test.ForeColor = Color.White
        Btn_Test.Location = New Point(14, 8)
        Btn_Test.Margin = New Padding(4, 3, 4, 3)
        Btn_Test.Name = "Btn_Test"
        Btn_Test.Size = New Size(117, 46)
        Btn_Test.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        Btn_Test.XOTampilkanFocusBorder = False
        Btn_Test.XOValidasiSemuaInput = False
        Btn_Test.XOValidasiSemuaInputTag = Nothing
        Btn_Test.TabIndex = 8
        Btn_Test.Text = "Test"
        Btn_Test.UseVisualStyleBackColor = False
        Btn_Test.Visible = False
        ' 
        ' CONN_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(565, 572)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "CONN_Editor"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlBasic.ResumeLayout(False)
        tp1_.ResumeLayout(False)
        tp1_.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSave As btn
    Friend WithEvents BtnCancel As btn
    Friend WithEvents TbctlBasic As tbctl
    Friend WithEvents tp1_ As TabPage
    Friend WithEvents Txt_Address As txt
    Friend WithEvents Txt_ConnectionName As txt
    Friend WithEvents Txt_Port As txt
    Friend WithEvents ULbl_Address As ULbl
    Friend WithEvents ULbl_Name As ULbl
    Friend WithEvents ULbl_Password As ULbl
    Friend WithEvents ULbl_Username As ULbl
    Friend WithEvents ULbl_Port As ULbl
    Friend WithEvents Txt_Password As txt
    Friend WithEvents Txt_Username As txt
    Friend WithEvents Btn_Test As btn
    Friend WithEvents Chk_Default As chk
    Friend WithEvents Txt_FileStorage As txt
    Friend WithEvents Txt_DataStorage As txt
    Friend WithEvents ULbl_FileStorage As ULbl
    Friend WithEvents ULbl_DataStorage As ULbl
End Class
