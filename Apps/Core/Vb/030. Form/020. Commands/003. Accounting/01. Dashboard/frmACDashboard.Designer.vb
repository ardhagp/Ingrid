<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmACDashboard
    Inherits CMCv.frmStandard

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(766, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Size = New Size(766, 470)
        ' 
        ' frmACDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(766, 553)
        KeyPreview = True
        Margin = New Padding(6, 3, 6, 3)
        Name = "frmACDashboard"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
