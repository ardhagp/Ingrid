﻿'Imports System.ComponentModel

Imports System.Runtime.Versioning

Public Class Tv
    Inherits System.Windows.Forms.TreeView

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
    End Sub
End Class
