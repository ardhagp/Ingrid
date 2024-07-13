Imports System.Runtime.Versioning

Public Class Meb
    Inherits System.Windows.Forms.MaskedTextBox

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontTxt
        MyBase.Width = 206
        Me.XOHarusDiisi = False
        Me.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        Me.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        Me.XOHightlightSaatFokus = False
        Me.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        Me.XOPilihSemuaSaatFokus = False
    End Sub

#Region "Properti"
    Private varHarusdiisi As Boolean
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Maskeditbox harus diisi")>
    Public Property XOHarusDiisi As Boolean
        Get
            Return varHarusdiisi
        End Get
        Set(value As Boolean)
            varHarusdiisi = value
        End Set
    End Property

    Private varHarusdiisiWarnaLatarDefault As System.Drawing.Color
    Private varHarusdiisiWarnaLatar As System.Drawing.Color
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Warna saat teksboks tidak diisi")>
    Public Property XOHarusDiisiWarnaLatar As System.Drawing.Color
        Get
            Return varHarusdiisiWarnaLatar
        End Get
        Set(value As System.Drawing.Color)
            varHarusdiisiWarnaLatar = value
        End Set
    End Property

    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Warna saat teksboks tidak diisi jika bernilai False")>
    Public Property XOHarusDiisiWarnaLatarDefault As System.Drawing.Color
        Get
            Return varHarusdiisiWarnaLatarDefault
        End Get
        Set(value As System.Drawing.Color)
            varHarusdiisiWarnaLatarDefault = value
        End Set
    End Property

    Private varHightlightSaatFokus As Boolean
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
    Public Property XOHightlightSaatFokus() As Boolean
        Get
            Return varHightlightSaatFokus
        End Get
        Set(value As Boolean)
            varHightlightSaatFokus = value
        End Set
    End Property

    Private varHighlightsaatfokuswarna As System.Drawing.Color
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Warna highlight")>
    Public Property XOHightlightSaatFokusWarna() As System.Drawing.Color
        Get
            Return varHighlightsaatfokuswarna
        End Get
        Set(value As System.Drawing.Color)
            varHighlightsaatfokuswarna = value
        End Set
    End Property

    Private varPilihsemuasaatfokus As Boolean
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Memilih semua teks saat fokus")>
    Public Property XOPilihSemuaSaatFokus() As Boolean
        Get
            Return varPilihsemuasaatfokus
        End Get
        Set(value As Boolean)
            varPilihsemuasaatfokus = value
        End Set
    End Property
#End Region

    Private _varFlagAutoSelect As Boolean
    Private Sub txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        If Me.XOPilihSemuaSaatFokus AndAlso (MouseButtons = Windows.Forms.MouseButtons.None) Then
            Me.SelectAll()
            _varFlagAutoSelect = True
        End If
        If Me.XOHightlightSaatFokus Then
            MyBase.BackColor = Me.XOHightlightSaatFokusWarna
        End If
        If Me.XOPilihSemuaSaatFokus Then
            Me.Select(0, Me.Text.Length)
        End If
    End Sub

    Private Sub txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        If XOHarusDiisi Then
            MyBase.BackColor = Me.XOHarusDiisiWarnaLatar
        Else
            MyBase.BackColor = Me.XOHarusDiisiWarnaLatarDefault
        End If
    End Sub

    Private Sub txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        If Me.XOHightlightSaatFokus Then
            MyBase.BackColor = Me.XOHightlightSaatFokusWarna
        End If
    End Sub

    Private Sub txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If Me.XOHightlightSaatFokus AndAlso Not Me.Focused Then
            MyBase.BackColor = Me.XOHarusDiisiWarnaLatarDefault
        End If
    End Sub

    Private Sub txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If Me.XOPilihSemuaSaatFokus AndAlso (Not _varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
            _varFlagAutoSelect = True
            Me.SelectAll()
        End If
    End Sub
End Class
