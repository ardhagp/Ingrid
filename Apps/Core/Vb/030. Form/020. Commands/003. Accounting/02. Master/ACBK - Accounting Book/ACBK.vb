Imports System.Runtime.Versioning
Imports CMCv

Public Class ACBK
#Region "Variables"
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
    Private clsSQL As New Commands.ACBK.View
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        Commands.ACBK.View.DISPLAYDATA(DgnACBK, SLFStatus, TxtFind, True)
    End Sub
#End Region

#Region "Menu Strip Functions"
    'TODO: Add Menu Items
#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub frmACBK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsMMSmenu.LoadIn(Me)
        clsMMSmenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)

        Call GETDATA()
    End Sub
#End Region

#Region "Component Events"
    'TODO: Add Component Events
#End Region

End Class
