﻿Imports System.IO
Imports System.Data
Imports System.ComponentModel

Public Class Mainframe

#Region "Interfaces"
    Public Interface ICommandFunction
        Function LoadCommand() As CMCv.frmStandard
    End Interface

    Public Interface ICommandName
        ReadOnly Property TCODE As String
    End Interface
#End Region

#Region "Variables"
    Private WithEvents _LOGIN As New LOGIN
    Private WithEvents _CONN As New Connect.CONN(_PRODUCTIONMODE) 'uncomment this When add Connect To library
    Private WithEvents V_PHTRZ As New CMCv.PHTRZ
    Private WithEvents _UAC_Editor As UAC_Editor
    Private WithEvents _CSETTINGS As New Connect.CONN
    Private _SYSS As SYSS
    Private _SQL As New LibSQL.Mainframe.Database
    Private _SQL_Notification As New LibSQL.Application.Notification
    Private _SQL_RunningText As New LibSQL.Application.RunningText
    Private _SQL_Modules As New LibSQL.Application.Modules
    Private _SQL_Profiles As New LibSQL.Application.ProfilePanel
    Private _SQL_Storage As New LibSQL.Application.StorageSense
    Private _GetNotifCounter As Integer
    Private _ClearStatus As Integer
    Private _Session As Boolean
    Private _TotalNotification As Integer
    Private _RunningTextActive As Integer
    Private _MyMarquee As New Application.Marquee
#End Region

#Region "Subs Collection"
    Private Sub CommandAutoComplete()
        Try
            Dim _DS As New DataSet
            Dim _List As New AutoCompleteStringCollection

            'Txt_shortcut.AutoCompleteSource = Nothing
            Txt_shortcut.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            _DS = _SQL_Modules.DisplayAutoComplete '.DisplayAutoComplete(V_FORMAttrib.RowID, DgnPictureList)

            For i As Integer = 0 To _DS.Tables("TCMD").Rows.Count - 1
                _List.Add(_DS.Tables("TCMD").Rows(i).Item("module_code"))
            Next

            Txt_shortcut.AutoCompleteCustomSource = _List
            Txt_shortcut.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
        End Try
    End Sub

    Private Sub GetRunningText()
        TxtRunning.Visible = _SQL_RunningText.Show(V_USERAttrib.IsAdministrator)
    End Sub

    Private Sub GetNotification()
        _TotalNotification = _SQL_Notification.Exist(V_USERAttrib.EID)
        If _TotalNotification > 0 Then
            USERMENU.Text = V_USERAttrib.FirstName & "*"
            USERMENU.BackColor = Global.System.Drawing.Color.LightPink
            USERMENU.ForeColor = Global.System.Drawing.Color.Black
        Else
            USERMENU.Text = V_USERAttrib.FirstName
            USERMENU.BackColor = Global.System.Drawing.Color.Yellow
            USERMENU.ForeColor = Global.System.Drawing.Color.Black
        End If

        NotificationToolStripMenuItem.Text = _TotalNotification & " Notification(s)"
    End Sub

    Private Sub ClearStatus()
        ts_status.Text = String.Empty
        _ClearStatus = 0
    End Sub

    Private Sub CloseAllWindows(Optional ByVal Forced As Boolean = False)
        Try
            If Not (Forced) Then
                If Global.System.Windows.Forms.MessageBox.Show("Do you want to close all workspace windows?", "Close All Windows", Global.System.Windows.Forms.MessageBoxButtons.YesNo, Global.System.Windows.Forms.MessageBoxIcon.Question) = Global.System.Windows.Forms.DialogResult.Yes Then
                    'tmdi_.AttachedTo = Nothing
                    For Each OpenedForms As CMCv.frmStandard In tmdi_.MdiChildren
                        OpenedForms.Close()
                        OpenedForms.Dispose()
                    Next
                End If
            Else
                For Each OpenedForms As CMCv.frmStandard In tmdi_.MdiChildren
                    OpenedForms.Close()
                    OpenedForms.Dispose()
                Next
            End If
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    Private Sub EnterCommand(ByVal TCode As String)
        Call LoginClicked()

        If Not (V_SYSAPP.IsModuleReady(TCode.ToUpper.Trim)) Then
            st_mainframe.Items(0).Text = "Module " & TCode.ToUpper.Trim & " not ready"
            Return
        ElseIf (V_SYSAPP.IsModuleLocked(TCode.ToUpper.Trim)) Then
            st_mainframe.Items(0).Text = "[" & TCode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator."
            Decision("[" & TCode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator.", "Module Under Maintenance", CMCv.frmDialogBox.MessageIcon.Information, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (V_USERAccess.User(TCode.ToUpper.Trim, V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.View, st_mainframe)) Then
            st_mainframe.Items(0).Text = "You are not authorized to access : " & TCode.ToUpper.Trim
            Beep()
            Return
        Else
            'tmdi_.AttachedTo = Me
            Globals.Workspace.Open(Me, V_USERAttrib.UID, TCode.ToUpper.Trim, st_mainframe)
            Txt_shortcut.Clear()
        End If
    End Sub

#End Region

#Region "Application Menu"
    'Start Menu
    Private Sub ms_start_Login_Click(sender As Object, e As EventArgs) Handles ms_start_Login.Click
        Call LoginClicked()
    End Sub

    Private Function LoginClicked() As Boolean
        If V_USERAttrib.UID = String.Empty Then
            _LOGIN = New LOGIN
            Display(_LOGIN, IMAGEDB.Main.ImageLibrary.LOGIN_ICON, "Login Screen", "Please enter your credential to access continue", True)
        End If
        If V_USERAttrib.UID = String.Empty Then
            _Session = False
            Call SystemLogout(True)
        Else
            _Session = True
            Call SystemLogout(False)
        End If
        Return _Session
    End Function

    Private Sub ms_start_Logout_Click(sender As Object, e As EventArgs) Handles ms_start_Logout.Click
        Call LogoutClicked()
    End Sub

    Private Sub LogoutClicked()
        If Global.System.Windows.Forms.MessageBox.Show("Are you sure want to logout from system?", "Logout", Global.System.Windows.Forms.MessageBoxButtons.YesNo, Global.System.Windows.Forms.MessageBoxIcon.Question) = Global.System.Windows.Forms.DialogResult.Yes Then
            Call SystemLogout()
            V_LOGUser.Logout(V_USERAttrib.EID)
            Call ClearLoginData()
        End If
    End Sub

    Private Sub ms_start_ConnectionProperties_Click(sender As Object, e As EventArgs) Handles ms_start_Connection.Click
        'uncomment this when add Connect to library
        _CONN = New Connect.CONN(_PRODUCTIONMODE, True)
        DISPLAY(_CONN, IMAGEDB.Main.ImageLibrary.CONN_ICON, "Connection Settings", "Configure Ingrid database connection", True)
    End Sub

    'Workspace Menu
    Private Sub ms_workspace_Cascade_Click(sender As Object, e As EventArgs) Handles ms_workspace_Cascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub ms_workspace_TileVertical_Click(sender As Object, e As EventArgs) Handles ms_workspace_TileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ms_workspace_TileHorizontal_Click(sender As Object, e As EventArgs) Handles ms_workspace_TileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ms_workspace_CloseAll_Click(sender As Object, e As EventArgs) Handles ms_workspace_CloseAll.Click
        Call CloseAllWindows()
    End Sub

    Private Sub ms_workspace_InputCommand_Click(sender As Object, e As EventArgs) Handles ms_workspace_InputCommand.Click
        Txt_shortcut.Focus()
    End Sub

    Private Sub ms_workspace_Maximize_Click(sender As Object, e As EventArgs) Handles ms_workspace_Maximize.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Try
            V_FORMAttrib.RowID = V_USERAttrib.UID
            V_FORMAttrib.IsNew = False
            V_FORMAttrib.IsChangePasswordForm = True
            _UAC_Editor = New UAC_Editor
            Display(_UAC_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Change My Account", "Update your account username or password", True)

        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub
#End Region

#Region "Form Events"
    Private Sub mainframe_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ActivateLicenses()

        Try
            _GetNotifCounter = 58
            V_ForceRefreshMainframeData = False
            TmrStatus.Interval = _STATUSTIMEWAIT * 1000

            'splash.Show()
            Call SystemLogout()
            Call FirstLoad()
            V_USERAttrib.UID = String.Empty

            If (_SQL.Connect(_PRODUCTIONMODE)) Then
                ts_connection.Text = "Connected"
                V_LOGApp.Run()
            Else
                ts_connection.Text = "Disconnected"
                Decision("Cannot connect to server." & Environment.NewLine & "Please check your settings in APP -> Connection." & Environment.NewLine & "<b>Restart</b> Ingrid after you made any changes!", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                Return
            End If
            'splash.Close()
            Call CommandAutoComplete()
            Text += " - Ver. " & V_APPVer
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
            PUSHERRORDATASHOW()
        End Try
    End Sub

#End Region

#Region "Componnts Events"
    Private Sub Tv_mainframe_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Tv_mainframe.NodeMouseDoubleClick
        Try
            With Tv_mainframe.SelectedNode
                If .Name = "nd_file" Then
                    Call EnterCommand(.Tag)
                End If
            End With
        Catch ex As Exception
            'please add error dialog box here
        End Try
    End Sub

    Private Sub TxtShortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_shortcut.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call EnterCommand(Txt_shortcut.Text.Trim)
            Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
        End If
    End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click
        Call EnterCommand(Txt_shortcut.Text)
        Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
    End Sub
#End Region

    Private Sub SystemLogout(Optional ByVal IsLogout As Boolean = True)
        If Not (IsLogout) Then
            ms_start_Login.Visible = False
            ms_start_Login.Enabled = False
            ms_start_Logout.Visible = True
            ms_start_Logout.Enabled = True
            ms_start_Connection.Enabled = False
            MyAccountToolStripMenuItem.Enabled = True
            LoginToolStripMenuItem.Visible = False
            LoginToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Visible = True
            LogoutToolStripMenuItem.Enabled = True
            _GetNotifCounter = 58
            Call GetNotification()
            TmrNotif.Enabled = True
            NotificationToolStripMenuItem.Enabled = True
            Call GetProfile()
            Call GetStorage()
            Call GetSettings()
        Else
            V_USERAttrib.UID = String.Empty
            ms_start_Login.Visible = True
            ms_start_Login.Enabled = True
            ms_start_Logout.Visible = False
            ms_start_Logout.Enabled = False
            ms_start_Connection.Enabled = True
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
            _GetNotifCounter = 0
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
        'Dim currentVersions As String = String.Empty
        'Dim recentVersions As String = String.Empty
        'Dim pathSimpleUpdater As String = String.Empty

        'currentVersions = Global.System.Windows.Forms.Application.StartupPath & "\current.txt"

        'If _PRODUCTIONMODE = True Then
        '    recentVersions = "\\ls-pc-098\Shared Folder\911. Software\QERP\Network\recent.txt"
        'Else
        '    recentVersions = "D:\0\recent.txt"
        'End If

        'pathSimpleUpdater = Global.System.Windows.Forms.Application.StartupPath & "\AppUpdater.exe"

        'AKLib.SimpleUpdater.FromDefinedList(currentVersions, recentVersions, pathSimpleUpdater)

    End Sub

    Private Sub PhotoResizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotoResizerToolStripMenuItem.Click
        Call EnterCommand("PHTRZ")
    End Sub

    Private Sub _PHTRZ_Done() Handles V_PHTRZ.Done
        V_PHTRZ.Dispose()
    End Sub

    Private Sub _CONN_Done() Handles _CONN.Done 'uncomment this when add Connect to library
        _CONN.Dispose()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
        Process.Start(My.Settings.URL_Wiki)
    End Sub

    Private Sub TmrNotif_Tick(sender As Object, e As EventArgs) Handles TmrNotif.Tick
        _GetNotifCounter += 1

        If _GetNotifCounter = 60 Then
            Call GetNotification()
            Call GetRunningText()
            Call GetProfile()
            Call GetStorage()
            Call GetSettings()

            _GetNotifCounter = 0
        End If
    End Sub

    Private Sub GetProfile()
        PnlProfile.Visible = _SQL_Profiles.Show(V_USERAttrib.IsAdministrator)
        If (PnlProfile.Visible) Then
            LblWelcome.Text = _SQL_Profiles.Welcome
            LblEmpNumber.Text = V_USERAttrib.EmployeeNumber

            Dim _Nama = V_USERAttrib.FirstName.Split({" "}, StringSplitOptions.RemoveEmptyEntries)

            LblEmployeeName.Text = String.Join(" ", _Nama.Take(2))
            LblPosition.Text = V_USERAttrib.Position
            PctProfile.Image = _SQL_Profiles.GETPhoto(V_USERAttrib.EID, V_USERAttrib.Gender)
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

    Private Sub GetStorage()
        Dim _DataCurrentSize As Double = 0
        Dim _FileCurrentSize As Double = 0
        Dim _FreeSpace As String = String.Empty

        PnlStorage.Visible = _SQL_Storage.Show(V_USERAttrib.IsAdministrator)

        If (PnlStorage.Visible) Then
            PnlStorage.Height = 158

            _FreeSpace = _SQL_Storage.MaxSize(LibSQL.Application.StorageSense.DBSizeType.FreeSpace, "db_universe_erp")
            pgDataStorage.Maximum = _FreeSpace

            _DataCurrentSize = _SQL_Storage.DataCurrentSize
            pgDataStorage.Value = _DataCurrentSize

            lblDataStorage.Text = String.Format("{0} / {1}", IIf(_DataCurrentSize < 1024, _DataCurrentSize & " MB", Math.Round((_DataCurrentSize / 1024), 2) & " GB"), Math.Round((_FreeSpace / 1024), 2) & " GB")

            _FreeSpace = _SQL_Storage.MaxSize(LibSQL.Application.StorageSense.DBSizeType.FreeSpace, "db_universe_erp_file")
            pgFileStorage.Maximum = _FreeSpace

            _FileCurrentSize = _SQL_Storage.FileCurrentSize
            pgFileStorage.Value = _FileCurrentSize

            lblFileStorage.Text = String.Format("{0} / {1}", IIf(_FileCurrentSize < 1024, _FileCurrentSize & " MB", Math.Round((_FileCurrentSize / 1024), 2) & " GB"), Math.Round((_FreeSpace / 1024), 2) & " GB")
        End If
    End Sub

    Private Sub NotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationToolStripMenuItem.Click
        Dim _NTFC As New NTFC
        Display(_NTFC, IMAGEDB.Main.ImageLibrary.NOTIF_ICON, "Notification", "Show all notification that addressed to you", True)
    End Sub

    Private Sub ts_status_Click(sender As Object, e As EventArgs) Handles ts_status.Click
        'waiting some code here
    End Sub

    Private Sub ts_status_TextChanged(sender As Object, e As EventArgs) Handles ts_status.TextChanged
        _ClearStatus = 0
        If ts_status.Text = String.Empty Then
            TmrStatus.Enabled = False
        Else
            TmrStatus.Enabled = True
        End If
    End Sub

    Private Sub TmrStatus_Tick(sender As Object, e As EventArgs) Handles TmrStatus.Tick
        _ClearStatus += 1
        If _ClearStatus = _STATUSTIMEWAIT Then
            Call ClearStatus()
        End If
    End Sub

    Private Sub _LOGIN_LoginSuccess() Handles _LOGIN.LoginSuccess
        Call GetNotification()
        PnlProfile.Visible = True
    End Sub

    Private Sub tmr_gc_Tick(sender As Object, e As EventArgs) Handles tmr_gc.Tick
        GC.Collect()
    End Sub

    'Private Sub BtnExecute2_Click(sender As Object, e As EventArgs) Handles BtnExecute2.Click
    '    Call EnterCommand(Txt_shortcut.SLFSQLText)
    '    Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.SLFSQLText.Trim)
    'End Sub

    Private Sub TmrMOD_Tick(sender As Object, e As EventArgs) Handles TmrMOD.Tick
        If (V_ForceRefreshMainframeData) Then
            Call CommandAutoComplete()
            V_ForceRefreshMainframeData = False
        End If
    End Sub

    Private Sub WORKSPACE_Click(sender As Object, e As EventArgs) Handles WORKSPACE.Click
        'waiting some code here
    End Sub

    Private Sub SUPPORT_Click(sender As Object, e As EventArgs) Handles SUPPORT.Click
        Process.Start(My.Settings.URL_Wiki)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call LogoutClicked()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Call LoginClicked()
    End Sub

    Private Sub mainframe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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

    Private Sub tmr_runningtext_Tick(sender As Object, e As EventArgs) Handles tmr_runningtext.Tick
        _MyMarquee.Tick()
        TxtRunning.Text = _MyMarquee.MarqueeText
    End Sub

    Private Sub BuymeacoffeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuymeacoffeToolStripMenuItem.Click
        Process.Start(My.Settings.URL_Paypal)
    End Sub

    Private Sub ms_start_Settings_Click(sender As Object, e As EventArgs) Handles ms_start_Settings.Click
        Call EnterCommand("SYSS")
    End Sub

    Private Sub _LOGIN_LoginFailed() Handles _LOGIN.LoginFailed
        Call ClearLoginData()
        Call SystemLogout(True)
    End Sub

    Private Sub ClearLoginData()
        _Session = False
        V_USERAttrib.EID = String.Empty
        V_USERAttrib.EmployeeNumber = String.Empty
        V_USERAttrib.FirstName = String.Empty
        V_USERAttrib.Gender = String.Empty
        V_USERAttrib.LastName = String.Empty
        V_USERAttrib.Position = String.Empty
        V_USERAttrib.UID = String.Empty
        V_USERAttrib.IsAdministrator = False
    End Sub

    Public Sub GetSettings()
        _MAXUPLOADSIZE_PDF = _SQL_Modules.MaxPDFAllowed
        _MAXUPLOADSIZE_PHOTO = _SQL_Modules.MaxPhotoAllowed
        _MINPASSWORDLENGTH = _SQL_Modules.MinPasswordLength
        _TEXTMARK = _SQL_Modules.TextMark(V_USERAttrib.IsAdministrator)
    End Sub

    Private Sub ms_start_Exit_Click(sender As Object, e As EventArgs) Handles ms_start_Exit.Click
        If (_Session) Then
            Call SystemLogout()
            V_LOGUser.Logout(V_USERAttrib.EID)
            Call ClearLoginData()
        End If

        Me.Close()
        System.Windows.Forms.Application.Exit()
        End
    End Sub

End Class