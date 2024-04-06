﻿Imports System.ComponentModel
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UPwdStrength
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New Container()
        pgb_PwdStrengthIndicator = New pgb(components)
        LblPwdStrength_Text = New lbl(components)
        SuspendLayout()
        ' 
        ' pgb_PwdStrengthIndicator
        ' 
        pgb_PwdStrengthIndicator.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        pgb_PwdStrengthIndicator.ForeColor = Drawing.Color.DodgerBlue
        pgb_PwdStrengthIndicator.Location = New System.Drawing.Point(0, 0)
        pgb_PwdStrengthIndicator.Name = "pgb_PwdStrengthIndicator"
        pgb_PwdStrengthIndicator.Size = New System.Drawing.Size(225, 23)
        pgb_PwdStrengthIndicator.XOArahGradien = ControlCodeBase.enuArahGradien.Horizontal
        pgb_PwdStrengthIndicator.XOWarnaProgressBar = ControlCodeBase.enuJenisWarna.Solid
        pgb_PwdStrengthIndicator.TabIndex = 0
        ' 
        ' LblPwdStrength_Text
        ' 
        LblPwdStrength_Text.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        LblPwdStrength_Text.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        LblPwdStrength_Text.Location = New System.Drawing.Point(3, 26)
        LblPwdStrength_Text.Name = "LblPwdStrength_Text"
        LblPwdStrength_Text.Size = New System.Drawing.Size(219, 21)
        LblPwdStrength_Text.XOCustomElipsis = False
        LblPwdStrength_Text.TabIndex = 1
        LblPwdStrength_Text.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' UPwdStrength
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        BackColor = Drawing.Color.Transparent
        Controls.Add(LblPwdStrength_Text)
        Controls.Add(pgb_PwdStrengthIndicator)
        Name = "UPwdStrength"
        Size = New System.Drawing.Size(225, 51)
        ResumeLayout(False)
    End Sub

#Region "Properties"

    Private _varPasswordStrengthScore As Integer
    <Category("Text"),
    Description("Skor kekuatan password")>
    Public Property SLFPasswordStrengthScore() As Integer
        Get
            Return _varPasswordStrengthScore
        End Get
        Set(value As Integer)
            _varPasswordStrengthScore = value
            Call RefreshStrengthIndicator(value)
        End Set
    End Property

    Private _varPasswordStrengthText As String

    <Category("Text"),
    Description("Teks kekuatan password")>
    Public Property SLFPasswordStrengthText() As String
        Get
            Return _varPasswordStrengthText
        End Get
        Set(value As String)
            _varPasswordStrengthText = value
            Call RefreshStrengthText(value)
        End Set
    End Property

    Private Sub RefreshStrengthIndicator(ByVal Score As Integer)
        pgb_PwdStrengthIndicator.Value = Score
        Me.Refresh()
        pgb_PwdStrengthIndicator.Refresh()
    End Sub

    Private Sub RefreshStrengthText(ByVal StrengthText As String)
        LblPwdStrength_Text.Text = StrengthText
        Me.Refresh()
        LblPwdStrength_Text.Refresh()
    End Sub

    Friend WithEvents pgb_PwdStrengthIndicator As pgb
    Friend WithEvents LblPwdStrength_Text As lbl

#End Region

End Class
