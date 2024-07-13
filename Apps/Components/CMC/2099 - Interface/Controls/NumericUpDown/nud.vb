Imports System.ComponentModel
Imports System.Runtime.Versioning

Public Class Nud
    Inherits System.Windows.Forms.NumericUpDown

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Height = 23
        MyBase.Width = 206
        MyBase.Font = globalFontTxt
        Me.XOHightlightSaatFokus = False
        Me.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        Me.XOPilihSemuaSaatFokus = False
        MyBase.DoubleBuffered = True
    End Sub

#Region "Properti"
    <Category("Text"),
Description("Potong spasi kiri-kanan secara otomatis saat lost focus")>
    Public Property XOAutoTrim() As Boolean
        Get
            Return varAutotrim
        End Get
        Set(value As Boolean)
            varAutotrim = value
        End Set
    End Property

    <Category("Text"),
    Description("Teksboks harus diisi")>
    Public Property XOHarusDiisi As Boolean
        Get
            Return varHarusdiisi
        End Get
        Set(value As Boolean)
            varHarusdiisi = value
        End Set
    End Property

    Private varHightlightSaatFokus As Boolean
    <Category("Text"),
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
    Public Property XOHightlightSaatFokus() As Boolean
        Get
            Return varHightlightSaatFokus
        End Get
        Set(value As Boolean)
            varHightlightSaatFokus = value
        End Set
    End Property

    Private varHighlightsaatfokuswarna As System.Drawing.Color
    <Category("Text"),
    Description("Warna highlight")>
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
End Class
