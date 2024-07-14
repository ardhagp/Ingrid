﻿'For clickonce .net 6 prequisites please paste here : C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Microsoft\VisualStudio\BootstrapperPackages

Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports System.Runtime.Versioning

Public Class Mainframe_n_6

#Region "Interfaces"
    Public Interface ICommandFunction
        Function LoadCommand() As CMCv.frmStandard
    End Interface

    Public Interface ICommandName
        ReadOnly Property varTCode As String
    End Interface
#End Region

#Region "Variables"
    Public Event IngridFrameOpen()
    Public Event IngridFrameClose()

    Private WithEvents frmLOGIN As New LOGIN
    Private WithEvents varCONN As New Connect.CONN(varProductionmode) 'uncomment this when add Connect to library
    Private WithEvents frmPHTRZ As New CMCv.PHTRZ
    Private WithEvents frmUACeditor As UAC_Editor
    'Private WithEvents _CSETTINGS As New Connect.CONN

    Private frmSYSS As SYSS

    Private clsSQL As New LibSQL.Mainframe.Database
    Private clsSQLdbcheck As New LibSQL.Commands.DBIC.Applications
    Private clsSQLnotification As New LibSQL.Application.Notification
    Private clsSQLrunningtext As New LibSQL.Application.RunningText
    Private clsSQLmodules As New LibSQL.Application.Modules
    Private clsSQLprofiles As New LibSQL.Application.ProfilePanel
    Private clsSQLstorage As New LibSQL.Application.StorageSense
    Private varGetnotifcounter As Integer
    Private varClearstatus As Integer
    Private varSession As Boolean
    Private varTotalnotification As Integer
    Private varRunningtextactive As Integer
    Private varMymarquee As New Application.Marquee
#End Region

#Region "Subs Collection"
    <SupportedOSPlatform("windows")>
    Private Sub CommandAutoComplete()
        Try
            Dim varDataset As New DataSet
            Dim varList As New AutoCompleteStringCollection

            'Txt_shortcut.AutoCompleteSource = Nothing
            Txt_shortcut.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            varDataset = clsSQLmodules.DisplayAutoComplete '.DisplayAutoComplete(varFORMAttribute.RowID, DgnPictureList)

            If varDataset Is Nothing Then
                Exit Sub
            End If

            For i As Integer = 0 To varDataset.Tables("TCMD").Rows.Count - 1
                varList.Add(varDataset.Tables("TCMD").Rows(i).Item("module_code").ToString)
            Next

            Txt_shortcut.AutoCompleteCustomSource = varList
            Txt_shortcut.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GetRunningText()
        TxtRunning.Visible = clsSQLrunningtext.Show(varUSERAttribute.IsAdministrator)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GetNotification()
        varTotalnotification = clsSQLnotification.Exist(varUSERAttribute.EID)
        If varTotalnotification > 0 Then
            USERMENU.Text = varUSERAttribute.FirstName & "*"
            USERMENU.BackColor = Global.System.Drawing.Color.LightPink
            USERMENU.ForeColor = Global.System.Drawing.Color.Black
        Else
            USERMENU.Text = varUSERAttribute.FirstName
            USERMENU.BackColor = Global.System.Drawing.Color.Yellow
            USERMENU.ForeColor = Global.System.Drawing.Color.Black
        End If

        NotificationToolStripMenuItem.Text = varTotalnotification & " Notification(s)"
    End Sub

    Private Sub ClearStatus()
        Ts_status.Text = String.Empty
        varClearstatus = 0
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CloseAllWindows(Optional ByVal Forced As Boolean = False)
        Try
            If Not (Forced) Then
                If Global.System.Windows.Forms.MessageBox.Show("Do you want to close all varWorkspace windows?", "Close All Windows", Global.System.Windows.Forms.MessageBoxButtons.YesNo, Global.System.Windows.Forms.MessageBoxIcon.Question) = Global.System.Windows.Forms.DialogResult.Yes Then
                    'tmdi_.AttachedTo = Nothing
                    For Each OpenedForms As CMCv.frmStandard In Tmdi_.MdiChildren
                        OpenedForms.Close()
                        OpenedForms.Dispose()
                    Next
                End If
            Else
                For Each OpenedForms As CMCv.frmStandard In Tmdi_.MdiChildren
                    OpenedForms.Close()
                    OpenedForms.Dispose()
                Next
            End If
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EnterCommand(ByVal varTCode As String)

        'For Modules That Not Required Login
        If (varTCode.ToUpper.Trim = "RESET") OrElse (varTCode.ToUpper.Trim = "PHTRZ") Then
            Globals.varWorkspace.Open(Me, varTCode.ToUpper.Trim, St_mainframe)
            Txt_shortcut.Clear()
            Return
        Else
            Call LoginClicked()
        End If

        'For Module That Required Login
        If Not (Application.Modules.IsModuleReady(varTCode.ToUpper.Trim)) Then
            St_mainframe.Items(0).Text = "Module " & varTCode.ToUpper.Trim & " not found."
            Return
        ElseIf (Application.Modules.IsModuleLocked(varTCode.ToUpper.Trim)) Then
            St_mainframe.Items(0).Text = "[" & varTCode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator."
            Bridge.Security.Writelog.Sendlog(varUSERAttribute.FirstName & " trying to open Under Maintenance Module " & varTCode.ToUpper.Trim, Bridge.Security.Writelog.LogType.Error)
            Decision("[" & varTCode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator.", "Module Under Maintenance", CMCv.frmDBdialogbox.MessageIcon.Information, CMCv.frmDBdialogbox.MessageTypes.OkOnly)

            System.Media.SystemSounds.Beep.Play()

            Return
        ElseIf Not (varUSRaccess.User(varTCode.ToUpper.Trim, varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.View, St_mainframe)) Then

            St_mainframe.Items(0).Text = "You are not authorized to access : " & varTCode.ToUpper.Trim

            Bridge.Security.Writelog.Sendlog(varUSERAttribute.FirstName & " trying to open Restricted Module " & varTCode.ToUpper.Trim, Bridge.Security.Writelog.LogType.Error)

            System.Media.SystemSounds.Beep.Play()

            Return
        Else
            Globals.varWorkspace.Open(Me, varTCode.ToUpper.Trim, St_mainframe)
            Bridge.Security.Writelog.Sendlog(varUSERAttribute.FirstName & " opening Module " & varTCode.ToUpper.Trim, Bridge.Security.Writelog.LogType.Information)
            Txt_shortcut.Clear()
        End If
    End Sub

#End Region

#Region "Application Menu"
    'Start Menu
    <SupportedOSPlatform("windows")>
    Private Sub Ms_start_Login_Click(sender As Object, e As EventArgs) Handles Ms_start_Login.Click
        Call LoginClicked()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Function LoginClicked() As Boolean
        If varUSERAttribute.UID = String.Empty Then
            frmLOGIN = New LOGIN
            DISPLAY(frmLOGIN, IMAGEDB.Main.ImageLibrary.LOGIN_ICON, "Login Screen", "Please enter your credential to access continue", True)
        End If
        If varUSERAttribute.UID = String.Empty Then
            varSession = False
            Call SystemLogout(True)
        Else
            varSession = True
            Call SystemLogout(False)
        End If
        Return varSession
    End Function

    <SupportedOSPlatform("windows")>
    Private Sub Ms_start_Logout_Click(sender As Object, e As EventArgs) Handles Ms_start_Logout.Click
        Call LogoutClicked()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LogoutClicked()
        If Decision("Are you sure want to logout from system?", "Logout", frmDBdialogbox.MessageIcon.Question, frmDBdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
            Bridge.Security.Writelog.Sendlog(varUSERAttribute.FirstName & " is logout.", Bridge.Security.Writelog.LogType.Information)
            Call SystemLogout()
            varLOGuser.Logout(varUSERAttribute.EID)
            Call ClearLoginData()
        End If
    End Sub

    'varWorkspace Menu
    Private Sub Ms_workspace_Cascade_Click(sender As Object, e As EventArgs) Handles Ms_workspace_Cascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub Ms_workspace_TileVertical_Click(sender As Object, e As EventArgs) Handles Ms_workspace_TileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub Ms_workspace_TileHorizontal_Click(sender As Object, e As EventArgs) Handles Ms_workspace_TileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Ms_workspace_CloseAll_Click(sender As Object, e As EventArgs) Handles Ms_workspace_CloseAll.Click
        Call CloseAllWindows()
    End Sub

    Private Sub Ms_workspace_InputCommand_Click(sender As Object, e As EventArgs) Handles Ms_workspace_InputCommand.Click
        Txt_shortcut.Focus()
    End Sub

    Private Sub Ms_workspace_Maximize_Click(sender As Object, e As EventArgs) Handles Ms_workspace_Maximize.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Try
            With varFORMAttribute
                .RowID = varUSERAttribute.UID
                .IsNew = False
                .IsChangePasswordForm = True
            End With

            frmUACeditor = New UAC_Editor
            DISPLAY(frmUACeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Change My Account", "Update your account username or password", True)

        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TmrNotif.Enabled = True
            RaiseEvent IngridFrameOpen()

            Bridge.Security.Writelog.Sendlog("Ingrid Main App is opened.", Bridge.Security.Writelog.LogType.Information)

            Call ActivateLicenses()

            'tmdi_.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererIE7)
            Tmdi_.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererVS2010)
            varGetnotifcounter = 58
            varForcerefreshmainframedata = False
            TmrStatus.Interval = varStatustimewait * 1000


            'splash.Show()
            Call SystemLogout()
            Call FirstLoad()
            varUSERAttribute.UID = String.Empty

            'Retrieve app version
            varVersionapplication = GETAPPVERSION()
            Text += " - Ver. " & varVersionapplication

            If Mainframe.Database.Connect(varProductionmode) Then
                Ts_connection.Text = "Connected"
                varLOGapp.Run()
            Else
                Ts_connection.Text = "Disconnected"
                Decision("Cannot connect to server." & Environment.NewLine & "Please check your settings in APP -> Connection." & Environment.NewLine & "<b>Restart</b> Ingrid after you made any changes!", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                Return
            End If

            'splash.Close()

            Call CommandAutoComplete() 'TODO: Raised Error

            If Not (LibSQL.Commands.DBIC.Applications.IsCompanyExist) OrElse Not (LibSQL.Commands.DBIC.Applications.IsDepartmentExist) Then
                DISPLAY(frmFistGuide,, "First Guide", "", True, Me)
            End If
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
            PUSHERRORDATASHOW()
        End Try
    End Sub

#End Region

#Region "Components Events"
    <SupportedOSPlatform("windows")>
    Private Sub Tv_mainframe_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Tv_mainframe.NodeMouseDoubleClick
        Try
            With Tv_mainframe.SelectedNode
                If .Name = "nd_file" Then
                    Call EnterCommand(.Tag.ToString)
                End If
            End With
        Catch ex As Exception
            'please add error dialog box here
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtShortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_shortcut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call EnterCommand(Txt_shortcut.Text.Trim)
            Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click
        Call EnterCommand(Txt_shortcut.Text)
        Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub SystemLogout(Optional ByVal IsLogout As Boolean = True)
        If Not (IsLogout) Then
            Ms_start_Login.Visible = False
            Ms_start_Login.Enabled = False
            Ms_start_Logout.Visible = True
            Ms_start_Logout.Enabled = True
            Ms_start_Connection.Enabled = False
            MyAccountToolStripMenuItem.Enabled = True
            LoginToolStripMenuItem.Visible = False
            LoginToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Visible = True
            LogoutToolStripMenuItem.Enabled = True
            varGetnotifcounter = 58
            Call GetNotification()
            TmrNotif.Enabled = True
            NotificationToolStripMenuItem.Enabled = True
            Call GetProfile()
            Call GetStorage()
            Call GetSettings()
        Else
            varUSERAttribute.UID = String.Empty
            Ms_start_Login.Visible = True
            Ms_start_Login.Enabled = True
            Ms_start_Logout.Visible = False
            Ms_start_Logout.Enabled = False
            Ms_start_Connection.Enabled = True
            MyAccountToolStripMenuItem.Enabled = False
            LoginToolStripMenuItem.Visible = True
            LoginToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Visible = False
            LogoutToolStripMenuItem.Enabled = False
            USERMENU.Text = "NOT LOGGED"
            USERMENU.BackColor = Global.System.Drawing.SystemColors.Control
            'tmdi_.AttachedTo = Nothing
            Call CloseAllWindows(True)
            TmrNotif.Enabled = False
            varGetnotifcounter = 0
            NotificationToolStripMenuItem.Text = "0 Notification(s)"
            NotificationToolStripMenuItem.Enabled = False
            PnlProfile.Visible = False
            PnlProfile.Height = 0
            LblWelcome.Text = ""
            LblEmpNumber.Text = "Loading..."
            LblEmployeeName.Text = "Loading..."
            LblPosition.Text = "Loading..."
            PctProfile.Image = My.Resources.AccountGroup_001_90_FFFFFFFF_
            PnlStorage.Visible = False
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'TODO: Update method
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub PhotoResizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotoResizerToolStripMenuItem.Click
        Call EnterCommand("PHTRZ")
    End Sub

    Private Sub V_PHTRZ_Done() Handles frmPHTRZ.Done
        frmPHTRZ.Dispose()
    End Sub

    Private Sub V_CONN_Done() Handles varCONN.ConnectFrameClose 'uncomment this when add Connect to library
        varCONN.Dispose()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
        Try
            Process.Start(New ProcessStartInfo(My.Settings.URL_Wiki) With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TmrNotif_Tick(sender As Object, e As EventArgs) Handles TmrNotif.Tick
        varGetnotifcounter += 1

        If varGetnotifcounter = 60 Then
            Call GetNotification()
            Call GetRunningText()
            Call GetProfile()
            Call GetStorage()
            Call GetSettings()

            varGetnotifcounter = 0
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GetProfile()
        PnlProfile.Visible = LibSQL.Application.ProfilePanel.Show(varUSERAttribute.IsAdministrator)
        If (PnlProfile.Visible) Then
            LblWelcome.Text = LibSQL.Application.ProfilePanel.Welcome
            LblEmpNumber.Text = varUSERAttribute.EmployeeNumber

            Dim varName = varUSERAttribute.FirstName.Split({" "}, StringSplitOptions.RemoveEmptyEntries)

            LblEmployeeName.Text = String.Join(" ", varName.Take(2))
            LblPosition.Text = varUSERAttribute.Position
            PctProfile.Image = clsSQLprofiles.GETPhoto(varUSERAttribute.EID, varUSERAttribute.Gender)
            PnlProfile.Height = 191
        Else
            LblWelcome.Text = String.Empty
            LblEmpNumber.Text = String.Empty
            LblEmployeeName.Text = String.Empty
            LblPosition.Text = String.Empty
            PctProfile.Image = Nothing
            PnlProfile.Height = 0
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GetStorage()
        Dim varDatacurrentsize As Integer
        Dim varFilecurrentsize As Integer
        Dim varFreespace As Integer

        PnlStorage.Visible = LibSQL.Application.StorageSense.Show(varUSERAttribute.IsAdministrator)

        If (PnlStorage.Visible) Then
            PnlStorage.Height = 158

            varFreespace = CType(LibSQL.Application.StorageSense.MaxSize(LibSQL.Application.StorageSense.DBSizeType.FreeSpace, "db_universe_erp"), Integer)
            pgDataStorage.Maximum = varFreespace

            varDatacurrentsize = CType(LibSQL.Application.StorageSense.DataCurrentSize, Integer)
            pgDataStorage.Value = varDatacurrentsize

            lblDataStorage.Text = String.Format("{0} / {1}", IIf(varDatacurrentsize < 1024, varDatacurrentsize & " MB", Math.Round((varDatacurrentsize / 1024), 2) & " GB"), Math.Round((varFreespace / 1024), 2) & " GB")

            varFreespace = CType(LibSQL.Application.StorageSense.MaxSize(LibSQL.Application.StorageSense.DBSizeType.FreeSpace, "db_universe_erp_file"), Integer)
            pgFileStorage.Maximum = varFreespace

            varFilecurrentsize = CType(LibSQL.Application.StorageSense.FileCurrentSize, Integer)
            pgFileStorage.Value = varFilecurrentsize

            lblFileStorage.Text = String.Format("{0} / {1}", IIf(varFilecurrentsize < 1024, varFilecurrentsize & " MB", Math.Round((varFilecurrentsize / 1024), 2) & " GB"), Math.Round((varFreespace / 1024), 2) & " GB")
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub NotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationToolStripMenuItem.Click
        Dim frmNTFC As New NTFC
        DISPLAY(frmNTFC, IMAGEDB.Main.ImageLibrary.NOTIF_ICON, "Notification", "Show all notification that addressed to you", True)
    End Sub

    Private Sub Ts_status_Click(sender As Object, e As EventArgs) Handles Ts_status.Click
        'TODO: Status method
    End Sub

    Private Sub Ts_status_TextChanged(sender As Object, e As EventArgs) Handles Ts_status.TextChanged
        varClearstatus = 0
        If Ts_status.Text = String.Empty Then
            TmrStatus.Enabled = False
        Else
            TmrStatus.Enabled = True
        End If
    End Sub

    Private Sub TmrStatus_Tick(sender As Object, e As EventArgs) Handles TmrStatus.Tick
        varClearstatus += 1
        If varClearstatus = varStatustimewait Then
            Call ClearStatus()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub V_LOGIN_LoginSuccess() Handles frmLOGIN.LoginSuccess
        Call GetNotification()
        PnlProfile.Visible = True
    End Sub

    Private Sub Tmr_gc_Tick(sender As Object, e As EventArgs) Handles Tmr_gc.Tick
        GC.Collect()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TmrMOD_Tick(sender As Object, e As EventArgs) Handles TmrMOD.Tick
        If (varForcerefreshmainframedata) Then
            Call CommandAutoComplete()
            varForcerefreshmainframedata = False
        End If
    End Sub

    Private Sub WORKSPACE_Click(sender As Object, e As EventArgs) Handles varWorkspace.Click
        'TODO: Workspace method
    End Sub

    Private Sub SUPPORT_Click(sender As Object, e As EventArgs) Handles SUPPORT.Click
        Try
            Process.Start(New ProcessStartInfo(My.Settings.URL_Wiki) With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call LogoutClicked()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Call LoginClicked()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Mainframe_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Dim _ReqFolder = CHECKREQUIREDFOLDER(DirName.PDF)

        Try
            For Each _DeleteFile In Directory.GetFiles(_ReqFolder, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(_DeleteFile)
            Next
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "", ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    Private Sub Tmr_runningtext_Tick(sender As Object, e As EventArgs) Handles Tmr_runningtext.Tick
        varMymarquee.Tick()
        TxtRunning.Text = varMymarquee.MarqueeText
    End Sub

    Private Sub BuymeacoffeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuymeacoffeToolStripMenuItem.Click
        Try
            Process.Start(New ProcessStartInfo(My.Settings.URL_Paypal) With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Ms_start_Settings_Click(sender As Object, e As EventArgs) Handles Ms_start_Settings.Click
        Call EnterCommand("SYSS")
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub V_LOGIN_LoginFailed() Handles frmLOGIN.LoginFailed
        Call ClearLoginData()
        Call SystemLogout(True)
    End Sub

    Private Sub ClearLoginData()
        varSession = False
        With varUSERAttribute
            .EID = String.Empty
            .EmployeeNumber = String.Empty
            .FirstName = String.Empty
            .Gender = String.Empty
            .LastName = String.Empty
            .Position = String.Empty
            .UID = String.Empty
            .IsAdministrator = False
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Public Shared Sub GetSettings()
        varMaxuploadsize_pdf = LibSQL.Application.Modules.MaxPDFAllowed
        varMaxuploadsize_photo = LibSQL.Application.Modules.MaxPhotoAllowed
        varMinpasswordlength = LibSQL.Application.Modules.MinPasswordLength
        varTextmark = LibSQL.Application.Modules.TextMark(varUSERAttribute.IsAdministrator)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Ms_start_Exit_Click(sender As Object, e As EventArgs) Handles Ms_start_Exit.Click
        If (varSession) Then
            Call SystemLogout()
            varLOGuser.Logout(varUSERAttribute.EID)
            Call ClearLoginData()
        End If

        Me.Close()
        System.Windows.Forms.Application.Exit()
        End
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Ms_start_connection_app_Click(sender As Object, e As EventArgs) Handles Ms_start_connection_app.Click 'uncomment this when add Connect to library
        varCONN = New Connect.CONN(varProductionmode, True)

        DISPLAY(varCONN, IMAGEDB.Main.ImageLibrary.CONN_ICON, "Connection Settings", "Configure Ingrid database connection", True)
    End Sub

    Private Sub Ms_start_connection_folder_Click(sender As Object, e As EventArgs) Handles Ms_start_connection_folder.Click
        Try
            Process.Start(New ProcessStartInfo(My.Application.Info.DirectoryPath & "\Resources\") With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Mainframe_n_6_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Bridge.Security.Writelog.Sendlog("Ingrid Main App is closed.", Bridge.Security.Writelog.LogType.Information)
        RaiseEvent IngridFrameClose()
    End Sub

    'TODO: Reactivate when supported by .net 6
    'Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
    'only supported in .net 4.8, please reactivate this when supported by .net 6
    'MsgBox("You are idle")
    'End Sub

End Class
