﻿Imports System.Runtime.Versioning

Public Class lbl
    Inherits System.Windows.Forms.Label

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontTxt
        Me.XOCustomElipsis = False
        'Me.SLFTypeOfElipsis = TextFormatFlags.Default
        MyBase.DoubleBuffered = True
    End Sub

    Private _varCustomElipsis As Boolean
    Public Property XOCustomElipsis As Boolean
        Get
            Return _varCustomElipsis
        End Get
        Set(value As Boolean)
            _varCustomElipsis = value
        End Set
    End Property

    'Private _varTypeOfElipsis As TextFormatFlags
    'Public Property SLFTypeOfElipsis As TextFormatFlags
    '    Get
    '        Return _varTypeOfElipsis
    '    End Get
    '    Set(value As TextFormatFlags)
    '        _varTypeOfElipsis = value
    '    End Set
    'End Property

    Private Sub lbl_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

    End Sub


End Class