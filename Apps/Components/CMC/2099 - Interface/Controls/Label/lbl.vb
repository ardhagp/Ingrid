﻿Imports System.Runtime.Versioning

Public Class Lbl
    Inherits System.Windows.Forms.Label

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontTxt
        Me.XOCustomElipsis = False
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
End Class
