﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFistGuide
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Btn_Process = New btn(components)
        Lbl_Step = New lbl(components)
        Gbx_Company = New gbx(components)
        ULbl5 = New ULbl()
        Txt_EmployeeID = New txt(components)
        ULbl4 = New ULbl()
        ULbl3 = New ULbl()
        ULbl2 = New ULbl()
        ULbl1 = New ULbl()
        Txt_EmployeeName = New txt(components)
        Txt_Position = New txt(components)
        Txt_Department = New txt(components)
        Txt_Company = New txt(components)
        Btn_Close = New btn(components)
        Gbx_Login = New gbx(components)
        Btn_Check = New btn(components)
        UPwdStrength1 = New UPwdStrength()
        ULbl7 = New ULbl()
        ULbl6 = New ULbl()
        Txt_Password = New txt(components)
        Txt_Username = New txt(components)
        object_da28eea8_631c_4534_a532_605841b1d2bd = New lbl(components)
        Gbx_Modules = New gbx(components)
        Dgn1 = New dgn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Gbx_Company.SuspendLayout()
        Gbx_Login.SuspendLayout()
        Gbx_Modules.SuspendLayout()
        CType(Dgn1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn_Close)
        PnlBottomButton.Controls.Add(Btn_Process)
        PnlBottomButton.Location = New Point(0, 397)
        PnlBottomButton.Size = New Size(479, 58)
        PnlBottomButton.Controls.SetChildIndex(Btn_Process, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn_Close, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(479, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Lbl_Step)
        SLFPanel.Controls.Add(Gbx_Modules)
        SLFPanel.Controls.Add(Gbx_Login)
        SLFPanel.Controls.Add(Gbx_Company)
        SLFPanel.Size = New Size(479, 455)
        SLFPanel.Controls.SetChildIndex(Gbx_Company, 0)
        SLFPanel.Controls.SetChildIndex(Gbx_Login, 0)
        SLFPanel.Controls.SetChildIndex(Gbx_Modules, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Lbl_Step, 0)
        ' 
        ' Btn_Process
        ' 
        Btn_Process.BackColor = Color.RoyalBlue
        Btn_Process.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        Btn_Process.FlatAppearance.BorderSize = 2
        Btn_Process.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        Btn_Process.FlatStyle = FlatStyle.Flat
        Btn_Process.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Process.ForeColor = Color.White
        Btn_Process.Location = New Point(367, 11)
        Btn_Process.Name = "Btn_Process"
        Btn_Process.Size = New Size(100, 40)
        Btn_Process.TabIndex = 1
        Btn_Process.Text = "&Next"
        Btn_Process.UseVisualStyleBackColor = False
        Btn_Process.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        Btn_Process.XOTampilkanFocusBorder = False
        Btn_Process.XOValidasiSemuaInput = False
        Btn_Process.XOValidasiSemuaInputTag = Nothing
        ' 
        ' Lbl_Step
        ' 
        Lbl_Step.AutoSize = True
        Lbl_Step.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Step.Location = New Point(18, 18)
        Lbl_Step.Name = "Lbl_Step"
        Lbl_Step.Size = New Size(65, 21)
        Lbl_Step.TabIndex = 996
        Lbl_Step.Text = "Step 1 :"
        Lbl_Step.XOCustomElipsis = False
        ' 
        ' Gbx_Company
        ' 
        Gbx_Company.Controls.Add(ULbl5)
        Gbx_Company.Controls.Add(Txt_EmployeeID)
        Gbx_Company.Controls.Add(ULbl4)
        Gbx_Company.Controls.Add(ULbl3)
        Gbx_Company.Controls.Add(ULbl2)
        Gbx_Company.Controls.Add(ULbl1)
        Gbx_Company.Controls.Add(Txt_EmployeeName)
        Gbx_Company.Controls.Add(Txt_Position)
        Gbx_Company.Controls.Add(Txt_Department)
        Gbx_Company.Controls.Add(Txt_Company)
        Gbx_Company.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Gbx_Company.Location = New Point(12, 42)
        Gbx_Company.Name = "Gbx_Company"
        Gbx_Company.Size = New Size(455, 349)
        Gbx_Company.TabIndex = 998
        Gbx_Company.TabStop = False
        Gbx_Company.Text = "About You && Your Company"
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(7, 184)
        ULbl5.Margin = New Padding(4, 3, 4, 3)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(175, 33)
        ULbl5.SLFText = "Your Employee ID#"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1007
        ' 
        ' Txt_EmployeeID
        ' 
        Txt_EmployeeID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_EmployeeID.Location = New Point(189, 184)
        Txt_EmployeeID.MaxLength = 255
        Txt_EmployeeID.Name = "Txt_EmployeeID"
        Txt_EmployeeID.Size = New Size(260, 29)
        Txt_EmployeeID.TabIndex = 5
        Txt_EmployeeID.Tag = "txt"
        Txt_EmployeeID.XOAutoTrim = True
        Txt_EmployeeID.XOHarusDiisi = True
        Txt_EmployeeID.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_EmployeeID.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_EmployeeID.XOHightlightSaatFokus = True
        Txt_EmployeeID.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_EmployeeID.XOIsBlank = True
        Txt_EmployeeID.XOIsSearchBox = False
        Txt_EmployeeID.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_EmployeeID.XOPilihSemuaSaatFokus = False
        Txt_EmployeeID.XOPwdLengthMin = 8
        Txt_EmployeeID.XOPwdStrengthCalculate = False
        Txt_EmployeeID.XOPwdStrengthScore = 0
        Txt_EmployeeID.XOPwdStrengthText = Nothing
        Txt_EmployeeID.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_EmployeeID.XOSearchBoxText = "Type then press Enter"
        Txt_EmployeeID.XOSQLText = ""
        Txt_EmployeeID.XOTanpaSpasi = False
        Txt_EmployeeID.XOValidasiField = Nothing
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(7, 145)
        ULbl4.Margin = New Padding(4, 3, 4, 3)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Your Name"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1005
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(7, 106)
        ULbl3.Margin = New Padding(4, 3, 4, 3)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(175, 33)
        ULbl3.SLFText = "Position"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1004
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(7, 67)
        ULbl2.Margin = New Padding(4, 3, 4, 3)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(175, 33)
        ULbl2.SLFText = "Department"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1003
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(7, 28)
        ULbl1.Margin = New Padding(4, 3, 4, 3)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(175, 33)
        ULbl1.SLFText = "Company"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1002
        ' 
        ' Txt_EmployeeName
        ' 
        Txt_EmployeeName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_EmployeeName.Location = New Point(189, 145)
        Txt_EmployeeName.MaxLength = 255
        Txt_EmployeeName.Name = "Txt_EmployeeName"
        Txt_EmployeeName.Size = New Size(260, 29)
        Txt_EmployeeName.TabIndex = 4
        Txt_EmployeeName.Tag = "txt"
        Txt_EmployeeName.XOAutoTrim = True
        Txt_EmployeeName.XOHarusDiisi = True
        Txt_EmployeeName.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_EmployeeName.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_EmployeeName.XOHightlightSaatFokus = True
        Txt_EmployeeName.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_EmployeeName.XOIsBlank = True
        Txt_EmployeeName.XOIsSearchBox = False
        Txt_EmployeeName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_EmployeeName.XOPilihSemuaSaatFokus = False
        Txt_EmployeeName.XOPwdLengthMin = 8
        Txt_EmployeeName.XOPwdStrengthCalculate = False
        Txt_EmployeeName.XOPwdStrengthScore = 0
        Txt_EmployeeName.XOPwdStrengthText = Nothing
        Txt_EmployeeName.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_EmployeeName.XOSearchBoxText = "Type then press Enter"
        Txt_EmployeeName.XOSQLText = ""
        Txt_EmployeeName.XOTanpaSpasi = False
        Txt_EmployeeName.XOValidasiField = Nothing
        ' 
        ' Txt_Position
        ' 
        Txt_Position.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Position.Location = New Point(189, 106)
        Txt_Position.MaxLength = 255
        Txt_Position.Name = "Txt_Position"
        Txt_Position.Size = New Size(260, 29)
        Txt_Position.TabIndex = 3
        Txt_Position.Tag = "txt"
        Txt_Position.XOAutoTrim = True
        Txt_Position.XOHarusDiisi = True
        Txt_Position.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Position.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Position.XOHightlightSaatFokus = True
        Txt_Position.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Position.XOIsBlank = True
        Txt_Position.XOIsSearchBox = False
        Txt_Position.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Position.XOPilihSemuaSaatFokus = False
        Txt_Position.XOPwdLengthMin = 8
        Txt_Position.XOPwdStrengthCalculate = False
        Txt_Position.XOPwdStrengthScore = 0
        Txt_Position.XOPwdStrengthText = Nothing
        Txt_Position.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Position.XOSearchBoxText = "Type then press Enter"
        Txt_Position.XOSQLText = ""
        Txt_Position.XOTanpaSpasi = False
        Txt_Position.XOValidasiField = Nothing
        ' 
        ' Txt_Department
        ' 
        Txt_Department.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Department.Location = New Point(189, 67)
        Txt_Department.MaxLength = 255
        Txt_Department.Name = "Txt_Department"
        Txt_Department.Size = New Size(260, 29)
        Txt_Department.TabIndex = 2
        Txt_Department.Tag = "txt"
        Txt_Department.XOAutoTrim = True
        Txt_Department.XOHarusDiisi = True
        Txt_Department.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Department.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Department.XOHightlightSaatFokus = True
        Txt_Department.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Department.XOIsBlank = True
        Txt_Department.XOIsSearchBox = False
        Txt_Department.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Department.XOPilihSemuaSaatFokus = False
        Txt_Department.XOPwdLengthMin = 8
        Txt_Department.XOPwdStrengthCalculate = False
        Txt_Department.XOPwdStrengthScore = 0
        Txt_Department.XOPwdStrengthText = Nothing
        Txt_Department.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Department.XOSearchBoxText = "Type then press Enter"
        Txt_Department.XOSQLText = ""
        Txt_Department.XOTanpaSpasi = False
        Txt_Department.XOValidasiField = Nothing
        ' 
        ' Txt_Company
        ' 
        Txt_Company.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Company.Location = New Point(189, 28)
        Txt_Company.MaxLength = 255
        Txt_Company.Name = "Txt_Company"
        Txt_Company.Size = New Size(260, 29)
        Txt_Company.TabIndex = 1
        Txt_Company.Tag = "txt"
        Txt_Company.XOAutoTrim = True
        Txt_Company.XOHarusDiisi = True
        Txt_Company.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Company.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Company.XOHightlightSaatFokus = True
        Txt_Company.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Company.XOIsBlank = True
        Txt_Company.XOIsSearchBox = False
        Txt_Company.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Company.XOPilihSemuaSaatFokus = False
        Txt_Company.XOPwdLengthMin = 8
        Txt_Company.XOPwdStrengthCalculate = False
        Txt_Company.XOPwdStrengthScore = 0
        Txt_Company.XOPwdStrengthText = Nothing
        Txt_Company.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Company.XOSearchBoxText = "Type then press Enter"
        Txt_Company.XOSQLText = ""
        Txt_Company.XOTanpaSpasi = False
        Txt_Company.XOValidasiField = Nothing
        ' 
        ' Btn_Close
        ' 
        Btn_Close.BackColor = Color.Red
        Btn_Close.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        Btn_Close.FlatAppearance.BorderSize = 2
        Btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        Btn_Close.FlatStyle = FlatStyle.Flat
        Btn_Close.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Close.ForeColor = Color.White
        Btn_Close.Location = New Point(261, 11)
        Btn_Close.Name = "Btn_Close"
        Btn_Close.Size = New Size(100, 40)
        Btn_Close.TabIndex = 2
        Btn_Close.Text = "&Close"
        Btn_Close.UseVisualStyleBackColor = False
        Btn_Close.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        Btn_Close.XOTampilkanFocusBorder = False
        Btn_Close.XOValidasiSemuaInput = False
        Btn_Close.XOValidasiSemuaInputTag = Nothing
        ' 
        ' Gbx_Login
        ' 
        Gbx_Login.Controls.Add(Btn_Check)
        Gbx_Login.Controls.Add(UPwdStrength1)
        Gbx_Login.Controls.Add(ULbl7)
        Gbx_Login.Controls.Add(ULbl6)
        Gbx_Login.Controls.Add(Txt_Password)
        Gbx_Login.Controls.Add(Txt_Username)
        Gbx_Login.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Gbx_Login.Location = New Point(12, 42)
        Gbx_Login.Name = "Gbx_Login"
        Gbx_Login.Size = New Size(455, 349)
        Gbx_Login.TabIndex = 1007
        Gbx_Login.TabStop = False
        Gbx_Login.Text = "About Your Login"
        ' 
        ' Btn_Check
        ' 
        Btn_Check.BackColor = Color.RoyalBlue
        Btn_Check.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        Btn_Check.FlatAppearance.BorderSize = 2
        Btn_Check.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        Btn_Check.FlatStyle = FlatStyle.Flat
        Btn_Check.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Check.ForeColor = Color.White
        Btn_Check.Location = New Point(349, 159)
        Btn_Check.Name = "Btn_Check"
        Btn_Check.Size = New Size(100, 40)
        Btn_Check.TabIndex = 11
        Btn_Check.Text = "&Check"
        Btn_Check.UseVisualStyleBackColor = False
        Btn_Check.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        Btn_Check.XOTampilkanFocusBorder = False
        Btn_Check.XOValidasiSemuaInput = False
        Btn_Check.XOValidasiSemuaInputTag = Nothing
        ' 
        ' UPwdStrength1
        ' 
        UPwdStrength1.BackColor = Color.Transparent
        UPwdStrength1.Location = New Point(189, 102)
        UPwdStrength1.Name = "UPwdStrength1"
        UPwdStrength1.Size = New Size(260, 51)
        UPwdStrength1.SLFPasswordStrengthScore = 0
        UPwdStrength1.SLFPasswordStrengthText = Nothing
        UPwdStrength1.TabIndex = 10
        ' 
        ' ULbl7
        ' 
        ULbl7.BackColor = Color.MistyRose
        ULbl7.Location = New Point(7, 67)
        ULbl7.Margin = New Padding(4, 3, 4, 3)
        ULbl7.Name = "ULbl7"
        ULbl7.Size = New Size(175, 33)
        ULbl7.SLFText = "Password"
        ULbl7.SLFTextAdjuster = False
        ULbl7.SLFTextBorder = False
        ULbl7.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Red
        ULbl7.TabIndex = 9
        ' 
        ' ULbl6
        ' 
        ULbl6.BackColor = Color.MistyRose
        ULbl6.Location = New Point(7, 28)
        ULbl6.Margin = New Padding(4, 3, 4, 3)
        ULbl6.Name = "ULbl6"
        ULbl6.Size = New Size(175, 33)
        ULbl6.SLFText = "Username"
        ULbl6.SLFTextAdjuster = False
        ULbl6.SLFTextBorder = False
        ULbl6.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Red
        ULbl6.TabIndex = 8
        ' 
        ' Txt_Password
        ' 
        Txt_Password.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Password.Location = New Point(189, 67)
        Txt_Password.MaxLength = 255
        Txt_Password.Name = "Txt_Password"
        Txt_Password.Size = New Size(260, 29)
        Txt_Password.TabIndex = 7
        Txt_Password.Tag = "txt"
        Txt_Password.UseSystemPasswordChar = True
        Txt_Password.XOAutoTrim = False
        Txt_Password.XOHarusDiisi = True
        Txt_Password.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_Password.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_Password.XOHightlightSaatFokus = True
        Txt_Password.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_Password.XOIsBlank = True
        Txt_Password.XOIsSearchBox = False
        Txt_Password.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_Password.XOPilihSemuaSaatFokus = True
        Txt_Password.XOPwdLengthMin = 8
        Txt_Password.XOPwdStrengthCalculate = True
        Txt_Password.XOPwdStrengthScore = 0
        Txt_Password.XOPwdStrengthText = Nothing
        Txt_Password.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_Password.XOSearchBoxText = "Type then press Enter"
        Txt_Password.XOSQLText = ""
        Txt_Password.XOTanpaSpasi = False
        Txt_Password.XOValidasiField = Nothing
        ' 
        ' Txt_Username
        ' 
        Txt_Username.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_Username.Location = New Point(189, 28)
        Txt_Username.MaxLength = 255
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(260, 29)
        Txt_Username.TabIndex = 6
        Txt_Username.Tag = "txt"
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
        ' 
        ' object_da28eea8_631c_4534_a532_605841b1d2bd
        ' 
        object_da28eea8_631c_4534_a532_605841b1d2bd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        object_da28eea8_631c_4534_a532_605841b1d2bd.BackColor = Color.Transparent
        object_da28eea8_631c_4534_a532_605841b1d2bd.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        object_da28eea8_631c_4534_a532_605841b1d2bd.ForeColor = Color.Black
        object_da28eea8_631c_4534_a532_605841b1d2bd.Location = New Point(12, 0)
        object_da28eea8_631c_4534_a532_605841b1d2bd.Margin = New Padding(4, 0, 4, 0)
        object_da28eea8_631c_4534_a532_605841b1d2bd.Name = "object_da28eea8_631c_4534_a532_605841b1d2bd"
        object_da28eea8_631c_4534_a532_605841b1d2bd.Size = New Size(160, 33)
        object_da28eea8_631c_4534_a532_605841b1d2bd.TabIndex = 1
        object_da28eea8_631c_4534_a532_605841b1d2bd.Text = "Username"
        object_da28eea8_631c_4534_a532_605841b1d2bd.TextAlign = ContentAlignment.MiddleLeft
        object_da28eea8_631c_4534_a532_605841b1d2bd.XOCustomElipsis = False
        ' 
        ' Gbx_Modules
        ' 
        Gbx_Modules.Controls.Add(Dgn1)
        Gbx_Modules.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Gbx_Modules.Location = New Point(12, 42)
        Gbx_Modules.Name = "Gbx_Modules"
        Gbx_Modules.Size = New Size(455, 349)
        Gbx_Modules.TabIndex = 1008
        Gbx_Modules.TabStop = False
        Gbx_Modules.Text = "Preparing Necessary Modules"
        Gbx_Modules.Visible = False
        ' 
        ' Dgn1
        ' 
        Dgn1.AllowUserToAddRows = False
        Dgn1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(190), CByte(165))
        Dgn1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Dgn1.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Dgn1.BorderStyle = BorderStyle.None
        Dgn1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Dgn1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Dgn1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Dgn1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Dgn1.EnableHeadersVisualStyles = False
        Dgn1.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        Dgn1.Location = New Point(6, 63)
        Dgn1.Name = "Dgn1"
        Dgn1.ReadOnly = True
        Dgn1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        Dgn1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Dgn1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Dgn1.RowTemplate.Height = 25
        Dgn1.Size = New Size(443, 280)
        Dgn1.StandardTab = True
        Dgn1.TabIndex = 0
        Dgn1.XOGroupFirstRows = False
        Dgn1.XOGunakanNomorBaris = False
        ' 
        ' frmFistGuide
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(479, 538)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "frmFistGuide"
        ShowIcon = False
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Gbx_Company.ResumeLayout(False)
        Gbx_Company.PerformLayout()
        Gbx_Login.ResumeLayout(False)
        Gbx_Login.PerformLayout()
        Gbx_Modules.ResumeLayout(False)
        CType(Dgn1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Btn_Process As btn
    Friend WithEvents Lbl_Step As lbl
    Friend WithEvents Gbx_Company As gbx
    Friend WithEvents Txt_Company As txt
    Friend WithEvents Txt_EmployeeName As txt
    Friend WithEvents Txt_Position As txt
    Friend WithEvents Txt_Department As txt
    Friend WithEvents Btn_Close As btn
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents Txt_EmployeeID As txt
    Friend WithEvents Gbx_Login As gbx
    Friend WithEvents ULbl7 As ULbl
    Friend WithEvents ULbl6 As ULbl
    Friend WithEvents Txt_Password As txt
    Friend WithEvents Txt_Username As txt
    Friend WithEvents object_da28eea8_631c_4534_a532_605841b1d2bd As lbl
    Friend WithEvents UPwdStrength1 As UPwdStrength
    Friend WithEvents Gbx_Modules As gbx
    Friend WithEvents Btn_Check As btn
    Friend WithEvents Dgn1 As dgn

End Class
