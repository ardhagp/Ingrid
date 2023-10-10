Public Class gbx
    Inherits System.Windows.Forms.GroupBox

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
        MyBase.DoubleBuffered = True
    End Sub
End Class
