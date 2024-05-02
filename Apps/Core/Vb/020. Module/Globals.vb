﻿Imports System.IO
Imports System.Reflection
Imports System.Runtime.Versioning
'Imports System.Deployment.application

Module Globals
#Region "Activate Licenses"
    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim V_BRIDGE_KEY As New Bridge.Security.GETKEY
        Dim V_SyncfusionKey As String = V_BRIDGE_KEY.SYNCFUSION()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(V_SyncfusionKey)
    End Sub
#End Region

#Region "Variables"
    Public V_FormImage(4) As System.Drawing.Image
    Public Workspace As New WorkspaceClass
    Public V_FileInfo As New CMCv.OperatingSystem.File.Info
    Public FolderHandler As New CMCv.OperatingSystem.Folder
    'Public SecurityEngine As New Security.Engine
    Public V_IMG_COMPRESS As New CMCv.ImageEditor.Proccessor.Compress
    Public V_IMG_EDITOR As New CMCv.ImageEditor.Proccessor.Editor
    Public V_USERAccess As New Application.Access
    'Public V_SYSAPP As New Application.Modules
    Public V_LOGUser As New LibSQL.SystemLog.Activity.User
    Public V_LOGApp As New LibSQL.SystemLog.Activity.Application
    Public V_ForceRefreshMainframeData As Boolean
    'Public V_BRIDGE_LOG As New Bridge.Security.WRITELOG


    Public V_SECEncrypt As New CMCv.Security.Encrypt

    Public ErrorCatcher As New Catcher.Error.Fields

    'Public ERL As Database.Engine.LocalDB
    Public ERL As Database.Engine.SQLiteV3
    Public WithEvents ERC As New frmErrorReporting
    'Public WithEvents TED As New frmTextEditor
    Public WithEvents MSG As New frmDialogBox

    Public V_APPVer As String
    Public V_NETAppVer As Version

    Public V_FORMAttrib As New Ingrid.Main.GlobalRecord
    Public V_USERAttrib As New Ingrid.Main.GlobalUser
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub FirstLoad()
        Call GETAPPVERSION()
        Call CHECKREQUIREDFOLDER()
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub DblBuffer(ByVal GridView As DataGridView)
        Try
            Dim systemType As Type = GridView.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", bindingAttr:=BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(GridView, True, Nothing)
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

#Region "Error Log"

    ''' <summary>
    ''' Metode untuk menyimpan log error
    ''' </summary>
    ''' <param name="ErrorType">Tipe Error</param>
    ''' <param name="ErrorMessage">Pesan Error</param>
    ''' <param name="ErrorNumber">Nomor Error</param>
    ''' <param name="InternalStackTrace">Internal Stack Trace</param>
    ''' <param name="AppVersion">Versi Aplikasi</param>
    ''' <param name="EnableErrorReporting">True/False</param>
    ''' <param name="SaveError">True/False</param>
    ''' <param name="ResumeNext">Lanjutkan saat terjadi kesalahan</param>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATA(ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As Integer, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With ErrorCatcher
            .Type = ErrorType
            .Message = ErrorMessage
            .Number = ErrorNumber
            .InternalStackTrace = InternalStackTrace
            .AppVersion = AppVersion
            .EnableErrorReporting = EnableErrorReporting
            .SaveError = SaveError
            .ResumeNext = ResumeNext
        End With
    End Sub

    ''' <summary>
    ''' Metode untuk menampilkan log error
    ''' </summary>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Sub PUSHERRORDATASHOW()
        ERC = New CMCv.frmErrorReporting(ErrorCatcher, ERL)
        ERC.ShowDialog()
        If Not (ERC.ResumeNext) Then
            End
        End If
    End Sub
#End Region

#Region "Get App Version"

    ''' <summary>
    ''' Fungsi untuk mendapatkan versi app
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Function GETAPPVERSION() As String
        Try
            Dim V_Major, V_Minor, V_Build, V_Revision As Integer
            V_Major = My.Application.Info.Version.Major
            V_Minor = My.Application.Info.Version.Minor
            V_Build = My.Application.Info.Version.Build
            V_Revision = My.Application.Info.Version.Revision
            V_APPVer = V_Major & "." & V_Minor & "." & V_Build & "." & V_Revision
            Return V_APPVer
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            v_APPVer = " - Failed Getting Version"
            Return v_APPVer
        End Try
    End Function
#End Region

#Region "Check Modules Folder"

    ''' <summary>
    ''' Memeriksa Folder tempat menyimpan semua module
    ''' </summary>
    Public Function CHECKREQUIREDFOLDER(ByVal Optional GetDirName As DirName = Nothing) As String
        If Not Directory.Exists("Commands") Then
            Directory.CreateDirectory("Commands")
        End If
        If Not Directory.Exists("Files.PDF") Then
            Directory.CreateDirectory("Files.PDF")
        End If
        If Not Directory.Exists("Files.Photo") Then
            Directory.CreateDirectory("Files.Photo")
        End If

        Select Case GetDirName
            Case DirName.Commands
                Return Directory.GetCurrentDirectory & "\Commands\" 'Folder for detachable modules
            Case DirName.PDF
                Return Directory.GetCurrentDirectory & "\Files.PDF\"
            Case DirName.PDF
                Return Directory.GetCurrentDirectory & "\Files.Photo\"
            Case Else
                Return ""
        End Select

    End Function

    Public Enum DirName
        Commands
        PDF
        Photo
    End Enum
#End Region

#Region "Display Form"

    ''' <summary>
    ''' Untuk menampilkan form Standard
    ''' </summary>
    ''' <param name="formName">Nama Form</param>
    ''' <param name="FormImage">Form Icon</param>
    ''' <param name="FormTitle">Form Title</param>
    ''' <param name="FormSubTitle">Form Subtitle</param>
    ''' <param name="IsDialog">True/False</param>
    ''' <param name="ParentFrame">MDI</param>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Sub DISPLAY(ByVal formName As CMCv.frmStandard, Optional ByVal FormImage As System.Drawing.Image = Nothing, Optional ByVal FormTitle As String = "", Optional ByVal FormSubTitle As String = "", Optional ByVal IsDialog As Boolean = False, Optional ByVal ParentFrame As Windows.Forms.Form = Nothing)
        Try
            formName.SLFNamaForm.Text = FormTitle
            If FormImage IsNot Nothing Then
                formName.SLFLogo.Image = FormImage
            End If
            formName.SLFSubNamaForm.Text = FormSubTitle
            If Not (IsDialog) Then
                If (formName.IsHandleCreated) Then
                    formName.Focus()
                Else
                    If ParentFrame IsNot Nothing Then
                        formName.Visible = False
                        formName.MdiParent = ParentFrame
                        'formName.WindowState = FormWindowState.Maximized
                        formName.Show()
                        formName.Visible = True
                    Else
                        formName.Show()
                    End If
                End If
            Else
                formName.ShowDialog()
                formName.Dispose()
            End If
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    ''' <summary>
    ''' Untuk menampilkan form Standard + Footer Container
    ''' </summary>
    ''' <param name="FormName">Nama Form</param>
    ''' <param name="FormImage">Form Icon</param>
    ''' <param name="FormTitle">Form Title</param>
    ''' <param name="FormSubTitle">Form Subtitle</param>
    ''' <param name="IsDialog">True/False</param>
    ''' <param name="ParentFrame">MDI</param>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Sub DISPLAY(ByVal FormName As CMCv.Std_Fo, Optional ByVal FormImage As System.Drawing.Image = Nothing, Optional ByVal FormTitle As String = "", Optional ByVal FormSubTitle As String = "", Optional ByVal IsDialog As Boolean = False, Optional ByVal ParentFrame As Windows.Forms.Form = Nothing)
        Try
            FormName.SLFNamaForm.Text = FormTitle
            If FormImage IsNot Nothing Then
                FormName.SLFLogo.Image = FormImage
            End If
            FormName.SLFSubNamaForm.Text = FormSubTitle
            If Not (IsDialog) Then
                If (FormName.IsHandleCreated) Then
                    FormName.Focus()
                Else
                    If ParentFrame IsNot Nothing Then
                        FormName.Visible = False
                        FormName.MdiParent = ParentFrame
                        FormName.WindowState = FormWindowState.Maximized
                        FormName.Show()
                        FormName.Visible = True
                    Else
                        FormName.Show()
                    End If
                End If
            Else
                FormName.ShowDialog()
                FormName.Dispose()
            End If
        Catch ex As Exception
            Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            Call PUSHERRORDATASHOW()
        End Try
    End Sub
#End Region

#Region "Custom Message Box"
    ''' <summary>
    ''' CMCv Message Box
    ''' </summary>
    ''' <param name="Message">Masukkan pesan anda di sini</param>
    ''' <param name="Title">Judul form</param>
    ''' <param name="MessageIcon">Jenis Icon</param>
    ''' <param name="ButtonType">Jenis Tombol</param>
    ''' <returns>DialogResult</returns>
    ''' <remarks></remarks>
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As DialogResult
        MSG = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region



End Module
