﻿Public Class rdo
    Inherits System.Windows.Forms.RadioButton

    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.DoubleBuffered = True
    End Sub
End Class
