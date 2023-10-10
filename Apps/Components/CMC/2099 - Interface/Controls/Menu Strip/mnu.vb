Public Class mnu
    Inherits System.Windows.Forms.MenuStrip

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub

End Class
