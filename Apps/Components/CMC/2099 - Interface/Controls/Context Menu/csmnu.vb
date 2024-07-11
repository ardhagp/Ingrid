Imports System.Runtime.Versioning

Public Class Csmnu
    Inherits System.Windows.Forms.ContextMenuStrip

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
    End Sub

End Class
