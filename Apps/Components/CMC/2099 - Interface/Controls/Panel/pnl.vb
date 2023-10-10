Public Class pnl
    Inherits System.Windows.Forms.Panel

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub
End Class
