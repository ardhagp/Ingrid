﻿Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Public Class pgb
    Inherits System.Windows.Forms.ProgressBar

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.ForeColor = Color.DodgerBlue
        Me.XOArahGradien = ControlCodeBase.enuArahGradien.Horizontal
        Me.XOWarnaProgressBar = ControlCodeBase.enuJenisWarna.Solid
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub

#Region "Properti"

    <SupportedOSPlatform("windows")>
    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim brush As LinearGradientBrush = Nothing
        Dim brush2 As LinearGradientBrush
        Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim rec2 As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim scalefactor As Double = ((CDbl(Value) - CDbl(Minimum)) / (CDbl(Maximum) - CDbl(Minimum)))

        If ProgressBarRenderer.IsSupported Then
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec)
        End If

        rec.Width = CInt(Math.Truncate((rec.Width * scalefactor) - 4))
        rec.Height -= 4

        If Me.XOWarnaProgressBar = ControlCodeBase.enuJenisWarna.Gradien AndAlso Me.XOArahGradien = ControlCodeBase.enuArahGradien.Vertikal Then
            brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Vertical)
        ElseIf Me.XOWarnaProgressBar = ControlCodeBase.enuJenisWarna.Solid AndAlso Me.XOArahGradien = ControlCodeBase.enuArahGradien.Vertikal Then
            brush = New LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, LinearGradientMode.Vertical)
        ElseIf Me.XOWarnaProgressBar = ControlCodeBase.enuJenisWarna.Gradien AndAlso Me.XOArahGradien = ControlCodeBase.enuArahGradien.Horizontal Then
            brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Horizontal)
        ElseIf Me.XOWarnaProgressBar = ControlCodeBase.enuJenisWarna.Solid AndAlso Me.XOArahGradien = ControlCodeBase.enuArahGradien.Horizontal Then
            brush = New LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, LinearGradientMode.Horizontal)
        End If
        brush2 = New LinearGradientBrush(rec, Me.BackColor, Me.BackColor, LinearGradientMode.Vertical)
        rec2.Width -= 4
        rec2.Height -= 4
        e.Graphics.FillRectangle(brush2, 2, 2, rec2.Width, rec2.Height)
        e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height)
    End Sub

    Private _varWarnaProgressBar As ControlCodeBase.enuJenisWarna
    <Category("Appearance"),
    Description("Warna progressbar")>
    Public Property XOWarnaProgressBar As ControlCodeBase.enuJenisWarna
        Get
            Return _varWarnaProgressBar
        End Get
        Set(value As ControlCodeBase.enuJenisWarna)
            _varWarnaProgressBar = value
        End Set
    End Property

    Private _varArahGradien As ControlCodeBase.enuArahGradien
    <Category("Appearance"),
    Description("Arah gradien")>
    Public Property XOArahGradien As ControlCodeBase.enuArahGradien
        Get
            Return _varArahGradien
        End Get
        Set(value As ControlCodeBase.enuArahGradien)
            _varArahGradien = value
        End Set
    End Property
#End Region


End Class