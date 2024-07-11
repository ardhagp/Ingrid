Imports System.ComponentModel
Imports System.Runtime.Versioning

''' <project>CMCC</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom button
''' </summary>
''' <remarks></remarks>
Public Class Btn
    Inherits System.Windows.Forms.Button
    Public Event ValidasiBerhasil()

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.FlatAppearance.BorderSize = 2
        MyBase.Size = New System.Drawing.Size(100, 40)
        MyBase.Cursor = System.Windows.Forms.Cursors.Hand
        MyBase.Font = globalFontBtn
        Me.XOTampilkanFocusBorder = False
        Me.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        MyBase.DoubleBuffered = True
    End Sub

    Private _varJenisTombol As ControlCodeBase.enuJenisTombol
    <Category("Text"),
        Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
    Public Property XOJenisTombol() As ControlCodeBase.enuJenisTombol
        Get
            Return _varJenisTombol
        End Get
        Set(value As ControlCodeBase.enuJenisTombol)
            _varJenisTombol = value
            GantiWarnaTombol(value)
        End Set
    End Property

    Private _varValidasiSemuaInput As Boolean
    <Category("Text"),
        Description("Memvalidasi semua input telah diisi")>
    Public Property XOValidasiSemuaInput() As Boolean
        Get
            Return _varValidasiSemuaInput
        End Get
        Set(value As Boolean)
            _varValidasiSemuaInput = value
        End Set
    End Property

    Private _varValidasiSemuaInputTag As String
    <Category("Text"),
        Description("Teksboks dengan Tag ini yang akan divalidasi")>
    Public Property XOValidasiSemuaInputTag() As String
        Get
            Return _varValidasiSemuaInputTag
        End Get
        Set(value As String)
            _varValidasiSemuaInputTag = value
        End Set
    End Property

    ''' <summary>
    ''' Ganti warna tombol.
    ''' </summary>
    ''' <param name="_valEnuJenisTombol">Enumerasi jenis tombol.</param>
    Private Sub GantiWarnaTombol(ByVal _valEnuJenisTombol As ControlCodeBase.enuJenisTombol)
        Select Case _valEnuJenisTombol
            Case ControlCodeBase.enuJenisTombol.Yes
                MyBase.BackColor = Drawing.Color.LimeGreen
                MyBase.ForeColor = Drawing.Color.White
            Case ControlCodeBase.enuJenisTombol.No
                MyBase.BackColor = Drawing.Color.Red
                MyBase.ForeColor = Drawing.Color.White
            Case ControlCodeBase.enuJenisTombol.Default
                MyBase.BackColor = Drawing.Color.RoyalBlue
                MyBase.ForeColor = Drawing.Color.White
            Case ControlCodeBase.enuJenisTombol.Warning
                MyBase.BackColor = Drawing.Color.Yellow
                MyBase.ForeColor = Drawing.Color.Black
            Case ControlCodeBase.enuJenisTombol.Custom
                'MyBase.BackColor = System.Drawing.Color.Orange
                'MyBase.ForeColor = Drawing.Color.Black
        End Select
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btn_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
        If Me.FlatStyle = Windows.Forms.FlatStyle.Flat Then
            MyBase.FlatAppearance.BorderColor = ControlCodeBase.AmbilWarna(MyBase.BackColor, ControlCodeBase.enuOpasitasWarna.Darker, 60)
            MyBase.FlatAppearance.MouseOverBackColor = ControlCodeBase.AmbilWarna(MyBase.BackColor, ControlCodeBase.enuOpasitasWarna.Lighter, 20)
        End If
    End Sub

    Private _varTampilkanFocusBorder As Boolean
    Protected Overrides ReadOnly Property ShowFocusCues() As Boolean
        Get
            Return _varTampilkanFocusBorder
        End Get
    End Property

    Public Property XOTampilkanFocusBorder() As Boolean
        Get
            Return _varTampilkanFocusBorder
        End Get
        Set(value As Boolean)
            _varTampilkanFocusBorder = value
        End Set
    End Property
End Class