﻿Imports System.Runtime.Versioning

Public Class Stt
    Inherits System.Windows.Forms.StatusStrip

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub
End Class
