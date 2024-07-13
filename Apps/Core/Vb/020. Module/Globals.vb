﻿Imports System.IO
Imports System.Reflection
Imports System.Runtime.Versioning
'Imports System.Deployment.application

Module Globals
#Region "Activate Licenses"
    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim varKEYbridge As New Bridge.Security.Getkey
        Dim varKEYsyncfusion As String = varKEYbridge.Syncfusion()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varKEYsyncfusion)
    End Sub
#End Region

#Region "Variables"
    Public varFormimage(4) As System.Drawing.Image
    Public varWorkspace As New WorkspaceClass
    Public varFileinfo As New CMCv.OperatingSystem.File.Info
    Public varFolderhandler As New CMCv.OperatingSystem.Folder
    'Public SecurityEngine As New Security.Engine
    Public varIMGcompress As New CMCv.ImageEditor.Proccessor.Compress
    Public varIMGeditor As New CMCv.ImageEditor.Proccessor.Editor
    Public varUSERaccess As New Application.Access
    'Public V_SYSAPP As New Application.Modules
    Public varLoguser As New LibSQL.SystemLog.Activity.User
    Public varLOGapp As New LibSQL.SystemLog.Activity.Application
    Public varForcerefreshmainframedata As Boolean
    'Public varBridgelog As New Bridge.Security.WRITELOG


    Public varSecurityencrypt As New CMCv.Security.Encrypt

    Public clsErrorcatcher As New Catcher.Error.Fields

    'Public varERL As Database.Engine.LocalDB
    Public varERL As Database.Engine.SQLiteV3
    Public WithEvents frmError As New frmErrorReporting
    'Public WithEvents TED As New frmTextEditor
    Public WithEvents frmMessage As New frmDialogBox

    Public varVersionapplication As String
    Public varNETappver As Version

    Public frmAttribute As New Ingrid.Main.GlobalRecord
    Public varUSERattribute As New Ingrid.Main.GlobalUser
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
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
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
    Public Sub PUSHERRORDATA(ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With clsErrorcatcher
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
        frmError = New CMCv.frmErrorReporting(clsErrorcatcher, varERL)
        frmError.ShowDialog()
        If Not (frmError.ResumeNext) Then
            End
        End If
    End Sub
#End Region

#Region "Get App Version"

    ''' <summary>
    ''' Return App Version
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Function GETAPPVERSION() As String
        Try
            Dim varVersionmajor, varVersionminor, varVersionbuild, varVersionrevision As Integer

            With My.Application.Info.Version
                varVersionmajor = .Major
                varVersionminor = .Minor
                varVersionbuild = .Build
                varVersionrevision = .Revision
            End With

            varVersionapplication = varVersionmajor & "." & varVersionminor & "." & varVersionbuild & "." & varVersionrevision
            Return varVersionapplication
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            varVersionapplication = " - Failed Getting Version"
            Return varVersionapplication
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
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
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
            Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
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
        frmMessage = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return frmMessage.ShowDialog()
        frmMessage.Dispose()
    End Function
#End Region



End Module
