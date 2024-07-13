Imports System.Runtime.Versioning
Imports System.Security.Principal
Imports CMCv

Public Class RESET

#Region "Variables"
    Private _SQL As New Commands.RESET.Editor

#End Region

    <SupportedOSPlatform("windows")>
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
        If Txt_Confirmation.Text.Trim = "Confirm" Then
            'reset db settings
            If (Decision("Last Warning, do you want to reset application settings?", "Confirmation Before Resetting App Settings", frmDBdialogbox.MessageIcon.Alert, frmDBdialogbox.MessageTypes.YesNo) = DialogResult.Yes) AndAlso (Commands.RESET.Editor.PUSHData()) Then
                Decision("You have successfully resetting application settings", "Information", frmDBdialogbox.MessageIcon.Information, frmDBdialogbox.MessageTypes.OkOnly)
                Me.Close()
            End If
        Else
            'display warning
            Decision("Confirmation text is different from instruction.", "Wrong Instrution Set", frmDBdialogbox.MessageIcon.Error, frmDBdialogbox.MessageTypes.OkOnly)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class