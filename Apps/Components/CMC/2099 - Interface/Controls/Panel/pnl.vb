Imports System.Runtime.Versioning

Public Class Pnl
    Inherits System.Windows.Forms.Panel

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub
End Class
