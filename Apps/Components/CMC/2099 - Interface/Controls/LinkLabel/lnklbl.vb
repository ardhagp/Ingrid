Imports System.Runtime.Versioning

Public Class Lnklbl
    Inherits System.Windows.Forms.LinkLabel

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
        MyBase.DoubleBuffered = True
    End Sub
End Class
