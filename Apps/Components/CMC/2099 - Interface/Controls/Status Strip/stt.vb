Public Class stt
    Inherits System.Windows.Forms.StatusStrip

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub
End Class
