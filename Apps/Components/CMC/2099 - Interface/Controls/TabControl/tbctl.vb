Public Class tbctl
    Inherits System.Windows.Forms.TabControl

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
    End Sub


End Class
