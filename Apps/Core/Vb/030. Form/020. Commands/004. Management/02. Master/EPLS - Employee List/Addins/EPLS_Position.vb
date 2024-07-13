Imports System.Runtime.Versioning

Public Class EPLS_Position
#Region "Variables"
    Private varSQL As New Commands.EPLS.Addins.Browse.Position
    Public Event RecordSelected()
#End Region

#Region "Subs Collections"
    Private Sub GETTableID()
        varFORMAttribute.RowID = "-1"
        If DgnAddinPosition.RowCount > 0 Then
            varFORMAttribute.RowID = DgnAddinPosition.CurrentRow.Cells("employee_id").Value.ToString
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        Commands.EPLS.Addins.Browse.Position.DISPLAYDATA(DgnAddinPosition, SLFStatus, TxtFind, ForceRefresh)
    End Sub
#End Region

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If DgnAddinPosition.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            With DgnAddinPosition.CurrentRow
                varFORMAttribute.Field01 = .Cells("company_name").Value
                varFORMAttribute.Field02 = .Cells("departement_name").Value
                varFORMAttribute.Field03 = .Cells("position_id").Value
                varFORMAttribute.Field04 = .Cells("position_name").Value
            End With
            RaiseEvent RecordSelected()
            Me.Close()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETDATA()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub
End Class
