Public Class frmFistGuide
    Private Field_Record As New Ingrid.Main.GlobalRecord
    Private _Step As Integer

    Private Sub Txt_Company_TextChanged(sender As Object, e As EventArgs) Handles Txt_Company.TextChanged

    End Sub

    Private Sub Btn_Process_Click(sender As Object, e As EventArgs) Handles Btn_Process.Click
        If _Step = 1 Then

            If (Txt_Company.SLFIsBlank) OrElse (Txt_Department.SLFIsBlank) OrElse (Txt_Position.SLFIsBlank) OrElse (Txt_EmployeeName.SLFIsBlank) OrElse (Txt_EmployeeID.SLFIsBlank) Then
                MsgBox("Field(s) cannot be emptied", MsgBoxStyle.Critical, "Ingrid")

                If (Txt_Company.SLFIsBlank) Then
                    Txt_Company.Focus()
                ElseIf (Txt_Department.SLFIsBlank) Then
                    Txt_Department.Focus()
                ElseIf (Txt_Position.SLFIsBlank) Then
                    Txt_Position.Focus()
                ElseIf (Txt_EmployeeName.SLFIsBlank) Then
                    Txt_EmployeeName.Focus()
                Else
                    Txt_EmployeeID.Focus()
                End If

                Exit Sub
            End If

            Field_Record.Field01 = CMCv.Security.Encrypt.MD5(Txt_Company.Text.ToUpper)
            Field_Record.Field02 = CMCv.Security.Encrypt.MD5(Txt_Department.Text.ToUpper)
            Field_Record.Field03 = CMCv.Security.Encrypt.MD5(Txt_Position.Text.ToUpper)
            Field_Record.Field04 = CMCv.Security.Encrypt.MD5(Txt_EmployeeID.Text.ToUpper)

            Gbx_Company.Visible = False
            Gbx_Login.Visible = True

            _Step += 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

            Btn_Close.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
            Btn_Close.Text = "&Prev"

        ElseIf _Step = 2 Then
            If (Txt_Username.SLFIsBlank) OrElse (Txt_Password.SLFIsBlank) Then
                MsgBox("Field(s) cannot be emptied", MsgBoxStyle.Critical, "Ingrid")

                If (Txt_Username.SLFIsBlank) Then
                    Txt_Username.Focus()
                Else
                    Txt_Password.Focus()
                End If

                Exit Sub
            End If

            If Txt_Password.SLFPwdStrengthScore < 70 Then
                MsgBox("Your password is not strong enough!", MsgBoxStyle.Exclamation, "Ingrid")
                Txt_Password.Focus()
                Exit Sub
            End If

            Gbx_Company.Visible = False
            Gbx_Login.Visible = False
            Gbx_Modules.Visible = True

            _Step += 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

        ElseIf _Step = 3 Then


            _Step += 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

        End If
    End Sub

    Private Sub frmFistGuide_Load(sender As Object, e As EventArgs) Handles Me.Load
        _Step = 1
        Gbx_Company.Visible = True
        Gbx_Login.Visible = False
    End Sub

    Private Sub Txt_Department_TextChanged(sender As Object, e As EventArgs) Handles Txt_Department.TextChanged

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        If _Step = 1 Then
            Me.Close()
        ElseIf _Step = 2 Then
            Gbx_Company.Visible = True
            Gbx_Login.Visible = False

            _Step -= 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

            Btn_Close.SLFJenisTombol = ControlCodeBase.enuJenisTombol.No
            Btn_Close.Text = "&Close"
        ElseIf _Step = 3 Then
            Gbx_Login.Visible = True
            Gbx_Modules.Visible = False

            _Step -= 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)
        End If
    End Sub

    Private Sub Txt_Position_TextChanged(sender As Object, e As EventArgs) Handles Txt_Position.TextChanged

    End Sub

    Private Sub Txt_EmployeeName_TextChanged(sender As Object, e As EventArgs) Handles Txt_EmployeeName.TextChanged

    End Sub

    Private Sub Txt_Username_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txt_Password_TextChanged(sender As Object, e As EventArgs) Handles Txt_Password.TextChanged
    End Sub

    Private Sub Txt_Password_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Password.KeyUp

    End Sub

    Private Sub Btn_Check_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        'TODO: Value not refreshing in realtime
        UPwdStrength1.SLFPasswordStrengthScore = Txt_Password.SLFPwdStrengthScore
        UPwdStrength1.SLFPasswordStrengthText = Txt_Password.SLFPwdStrengthText
    End Sub
End Class
