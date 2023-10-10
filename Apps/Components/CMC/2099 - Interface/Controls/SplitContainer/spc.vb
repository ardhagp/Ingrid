Public Class spc
    Inherits System.Windows.Forms.SplitContainer

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub
End Class
