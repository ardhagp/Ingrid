Public Class UAC_Employee
#Region "Variables"
    Private _SQL As New LibSQL.Commands.UAC.Addins.Browse.Employee
    Public Event RecordSelected()
#End Region

#Region "Subs Collections"
    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"
        If DgnAddinEmployee.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnAddinEmployee.CurrentRow.Cells("employee_id").Value
        End If
    End Sub

    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnAddinEmployee, SLFStatus, TxtFind, ForceRefresh)
    End Sub

#End Region

    Private Sub UAC_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETDATA()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If DgnAddinEmployee.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            With DgnAddinEmployee.CurrentRow
                V_FORMAttrib.Field01 = .Cells("employee_id").Value
                V_FORMAttrib.Field02 = .Cells("employee_number").Value
                V_FORMAttrib.Field03 = .Cells("employee_fullname").Value
            End With
            RaiseEvent RecordSelected()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
End Class
