<Drawing.ToolboxBitmap(GetType(Dgn), "dgn.ico")>
Partial Class Dgn
    Inherits System.Windows.Forms.DataGridView

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgn
        '
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColumnHeadersHeight = 42
        Me.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private Sub dgn_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Me.RowPostPaint
        If Me.XOGunakanNomorBaris Then
            Dim RowNumWidth As Integer = Me.RowCount.ToString().Length
            Dim RowNumber As String = RowNumWidth.ToString

            RowNumber &= e.RowIndex + 1

            ' get the size of the row number string
            'SizeF(Sz = e.Graphics.MeasureString(RowNumber.ToString(), Me.Font))
            Dim Sz As System.Drawing.SizeF = e.Graphics.MeasureString(RowNumber.ToString(), Me.Font)

            ' adjust the width of the column that contains the row header cells 
            If Me.RowHeadersWidth < (Sz.Width + 20) Then
                Me.RowHeadersWidth = CType((Sz.Width + 20), Integer)
            End If

            ' draw the row number6
            e.Graphics.DrawString(CType(e.RowIndex + 1, String), Me.Font, System.Drawing.SystemBrushes.ControlText, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - Sz.Height) / 2))
            'Else
            '    e.Graphics.DrawString("", Me.Font, SystemBrushes.ControlText, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - Sz.Height) / 2))
        End If

        MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        MyBase.AllowUserToResizeRows = False
        MyBase.MultiSelect = False
        MyBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class
