﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAR_RPTFilter
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        BtnShow = New CMCv.btn(components)
        BtnCancel = New CMCv.btn(components)
        ChkFrom = New CMCv.chk(components)
        DtpFrom = New CMCv.dtp(components)
        ChkTo = New CMCv.chk(components)
        DtpTo = New CMCv.dtp(components)
        ChkArea = New CMCv.chk(components)
        CboArea = New CMCv.cbo(components)
        CboActivity = New CMCv.cbo(components)
        ChkActivity = New CMCv.chk(components)
        CboBy = New CMCv.cbo(components)
        ChkBy = New CMCv.chk(components)
        TxtDescription = New CMCv.txt(components)
        LblNote = New CMCv.lbl(components)
        RdoColor = New CMCv.rdo(components)
        RdoBlackWhite = New CMCv.rdo(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnShow)
        PnlBottomButton.Location = New Point(0, 376)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(509, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnShow, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(509, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(RdoBlackWhite)
        SLFPanel.Controls.Add(RdoColor)
        SLFPanel.Controls.Add(LblNote)
        SLFPanel.Controls.Add(TxtDescription)
        SLFPanel.Controls.Add(ChkBy)
        SLFPanel.Controls.Add(CboBy)
        SLFPanel.Controls.Add(ChkActivity)
        SLFPanel.Controls.Add(CboActivity)
        SLFPanel.Controls.Add(CboArea)
        SLFPanel.Controls.Add(ChkArea)
        SLFPanel.Controls.Add(DtpTo)
        SLFPanel.Controls.Add(ChkTo)
        SLFPanel.Controls.Add(DtpFrom)
        SLFPanel.Controls.Add(ChkFrom)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(509, 434)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(ChkFrom, 0)
        SLFPanel.Controls.SetChildIndex(DtpFrom, 0)
        SLFPanel.Controls.SetChildIndex(ChkTo, 0)
        SLFPanel.Controls.SetChildIndex(DtpTo, 0)
        SLFPanel.Controls.SetChildIndex(ChkArea, 0)
        SLFPanel.Controls.SetChildIndex(CboArea, 0)
        SLFPanel.Controls.SetChildIndex(CboActivity, 0)
        SLFPanel.Controls.SetChildIndex(ChkActivity, 0)
        SLFPanel.Controls.SetChildIndex(CboBy, 0)
        SLFPanel.Controls.SetChildIndex(ChkBy, 0)
        SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
        SLFPanel.Controls.SetChildIndex(LblNote, 0)
        SLFPanel.Controls.SetChildIndex(RdoColor, 0)
        SLFPanel.Controls.SetChildIndex(RdoBlackWhite, 0)
        ' 
        ' BtnShow
        ' 
        BtnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnShow.BackColor = Color.LimeGreen
        BtnShow.Cursor = Cursors.Hand
        BtnShow.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnShow.FlatAppearance.BorderSize = 2
        BtnShow.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnShow.FlatStyle = FlatStyle.Flat
        BtnShow.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnShow.ForeColor = Color.White
        BtnShow.Location = New Point(254, 8)
        BtnShow.Margin = New Padding(4, 3, 4, 3)
        BtnShow.Name = "BtnShow"
        BtnShow.Size = New Size(117, 46)
        BtnShow.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        BtnShow.SLFTampilkanFocusBorder = False
        BtnShow.SLFValidasiSemuaInput = False
        BtnShow.SLFValidasiSemuaInputTag = Nothing
        BtnShow.TabIndex = 99
        BtnShow.Text = "&Show"
        BtnShow.UseVisualStyleBackColor = False
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
        BtnCancel.Location = New Point(378, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        BtnCancel.SLFTampilkanFocusBorder = False
        BtnCancel.SLFValidasiSemuaInput = False
        BtnCancel.SLFValidasiSemuaInputTag = Nothing
        BtnCancel.TabIndex = 98
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' ChkFrom
        ' 
        ChkFrom.AutoSize = True
        ChkFrom.BackColor = Color.Transparent
        ChkFrom.FlatStyle = FlatStyle.Flat
        ChkFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkFrom.Location = New Point(47, 44)
        ChkFrom.Margin = New Padding(4, 3, 4, 3)
        ChkFrom.Name = "ChkFrom"
        ChkFrom.Size = New Size(39, 25)
        ChkFrom.TabIndex = 0
        ChkFrom.Text = "In"
        ChkFrom.UseVisualStyleBackColor = False
        ' 
        ' DtpFrom
        ' 
        DtpFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpFrom.Location = New Point(144, 39)
        DtpFrom.Margin = New Padding(4, 3, 4, 3)
        DtpFrom.MaxDate = New Date(2028, 6, 24, 0, 0, 0, 0)
        DtpFrom.MinDate = New Date(1918, 6, 24, 0, 0, 0, 0)
        DtpFrom.Name = "DtpFrom"
        DtpFrom.Size = New Size(321, 29)
        DtpFrom.SLFResetOnDisabled = True
        DtpFrom.TabIndex = 5
        ' 
        ' ChkTo
        ' 
        ChkTo.AutoSize = True
        ChkTo.BackColor = Color.Transparent
        ChkTo.FlatStyle = FlatStyle.Flat
        ChkTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkTo.Location = New Point(47, 84)
        ChkTo.Margin = New Padding(4, 3, 4, 3)
        ChkTo.Name = "ChkTo"
        ChkTo.Size = New Size(41, 25)
        ChkTo.TabIndex = 1
        ChkTo.Text = "To"
        ChkTo.UseVisualStyleBackColor = False
        ' 
        ' DtpTo
        ' 
        DtpTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpTo.Location = New Point(144, 80)
        DtpTo.Margin = New Padding(4, 3, 4, 3)
        DtpTo.MaxDate = New Date(2028, 6, 24, 0, 0, 0, 0)
        DtpTo.MinDate = New Date(1918, 6, 24, 0, 0, 0, 0)
        DtpTo.Name = "DtpTo"
        DtpTo.Size = New Size(321, 29)
        DtpTo.SLFResetOnDisabled = True
        DtpTo.TabIndex = 6
        ' 
        ' ChkArea
        ' 
        ChkArea.AutoSize = True
        ChkArea.BackColor = Color.Transparent
        ChkArea.FlatStyle = FlatStyle.Flat
        ChkArea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkArea.Location = New Point(47, 121)
        ChkArea.Margin = New Padding(4, 3, 4, 3)
        ChkArea.Name = "ChkArea"
        ChkArea.Size = New Size(58, 25)
        ChkArea.TabIndex = 2
        ChkArea.Text = "Area"
        ChkArea.UseVisualStyleBackColor = False
        ' 
        ' CboArea
        ' 
        CboArea.DropDownStyle = ComboBoxStyle.DropDownList
        CboArea.FlatStyle = FlatStyle.Flat
        CboArea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboArea.FormattingEnabled = True
        CboArea.Location = New Point(144, 120)
        CboArea.Margin = New Padding(4, 3, 4, 3)
        CboArea.Name = "CboArea"
        CboArea.Size = New Size(321, 29)
        CboArea.TabIndex = 7
        ' 
        ' CboActivity
        ' 
        CboActivity.DropDownStyle = ComboBoxStyle.DropDownList
        CboActivity.FlatStyle = FlatStyle.Flat
        CboActivity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboActivity.FormattingEnabled = True
        CboActivity.Location = New Point(144, 160)
        CboActivity.Margin = New Padding(4, 3, 4, 3)
        CboActivity.Name = "CboActivity"
        CboActivity.Size = New Size(321, 29)
        CboActivity.TabIndex = 8
        ' 
        ' ChkActivity
        ' 
        ChkActivity.AutoSize = True
        ChkActivity.BackColor = Color.Transparent
        ChkActivity.FlatStyle = FlatStyle.Flat
        ChkActivity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkActivity.Location = New Point(47, 162)
        ChkActivity.Margin = New Padding(4, 3, 4, 3)
        ChkActivity.Name = "ChkActivity"
        ChkActivity.Size = New Size(77, 25)
        ChkActivity.TabIndex = 3
        ChkActivity.Text = "Activity"
        ChkActivity.UseVisualStyleBackColor = False
        ' 
        ' CboBy
        ' 
        CboBy.DropDownStyle = ComboBoxStyle.DropDownList
        CboBy.FlatStyle = FlatStyle.Flat
        CboBy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboBy.FormattingEnabled = True
        CboBy.Location = New Point(144, 201)
        CboBy.Margin = New Padding(4, 3, 4, 3)
        CboBy.Name = "CboBy"
        CboBy.Size = New Size(321, 29)
        CboBy.TabIndex = 9
        ' 
        ' ChkBy
        ' 
        ChkBy.AutoSize = True
        ChkBy.BackColor = Color.Transparent
        ChkBy.FlatStyle = FlatStyle.Flat
        ChkBy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkBy.Location = New Point(47, 202)
        ChkBy.Margin = New Padding(4, 3, 4, 3)
        ChkBy.Name = "ChkBy"
        ChkBy.Size = New Size(43, 25)
        ChkBy.TabIndex = 4
        ChkBy.Text = "By"
        ChkBy.UseVisualStyleBackColor = False
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(144, 241)
        TxtDescription.Margin = New Padding(4, 3, 4, 3)
        TxtDescription.MaxLength = 255
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(321, 29)
        TxtDescription.SLFAutoTrim = False
        TxtDescription.SLFHarusDiisi = False
        TxtDescription.SLFHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.SLFHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.SLFHightlightSaatFokus = False
        TxtDescription.SLFHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.SLFIsBlank = True
        TxtDescription.SLFIsSearchBox = False
        TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
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
        TxtDescription.TabIndex = 10
        TxtDescription.Tag = "txt"
        ' 
        ' LblNote
        ' 
        LblNote.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        LblNote.Location = New Point(139, 278)
        LblNote.Margin = New Padding(4, 0, 4, 0)
        LblNote.Name = "LblNote"
        LblNote.Size = New Size(327, 60)
        LblNote.SLFCustomElipsis = False
        LblNote.TabIndex = 1007
        LblNote.Text = "Note : The more specific your filter," & vbCrLf & "the more faster report will load."
        ' 
        ' RdoColor
        ' 
        RdoColor.AutoSize = True
        RdoColor.Checked = True
        RdoColor.FlatStyle = FlatStyle.Flat
        RdoColor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RdoColor.Location = New Point(144, 336)
        RdoColor.Margin = New Padding(4, 3, 4, 3)
        RdoColor.Name = "RdoColor"
        RdoColor.Size = New Size(65, 25)
        RdoColor.TabIndex = 1008
        RdoColor.TabStop = True
        RdoColor.Text = "Color"
        RdoColor.UseVisualStyleBackColor = True
        ' 
        ' RdoBlackWhite
        ' 
        RdoBlackWhite.AutoSize = True
        RdoBlackWhite.FlatStyle = FlatStyle.Flat
        RdoBlackWhite.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RdoBlackWhite.Location = New Point(248, 336)
        RdoBlackWhite.Margin = New Padding(4, 3, 4, 3)
        RdoBlackWhite.Name = "RdoBlackWhite"
        RdoBlackWhite.Size = New Size(125, 25)
        RdoBlackWhite.TabIndex = 1009
        RdoBlackWhite.TabStop = True
        RdoBlackWhite.Text = "Black && White"
        RdoBlackWhite.UseVisualStyleBackColor = True
        ' 
        ' DAR_RPTFilter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(509, 517)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "DAR_RPTFilter"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnShow As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents DtpFrom As CMCv.dtp
    Friend WithEvents ChkFrom As CMCv.chk
    Friend WithEvents CboActivity As CMCv.cbo
    Friend WithEvents CboArea As CMCv.cbo
    Friend WithEvents ChkArea As CMCv.chk
    Friend WithEvents DtpTo As CMCv.dtp
    Friend WithEvents ChkTo As CMCv.chk
    Friend WithEvents ChkBy As CMCv.chk
    Friend WithEvents CboBy As CMCv.cbo
    Friend WithEvents ChkActivity As CMCv.chk
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents LblNote As CMCv.lbl
    Friend WithEvents RdoBlackWhite As CMCv.rdo
    Friend WithEvents RdoColor As CMCv.rdo
End Class
