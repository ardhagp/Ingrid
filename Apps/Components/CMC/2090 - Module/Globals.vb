Imports System.Runtime.Versioning

Module Globals
#Region "Font Globals"
    <SupportedOSPlatform("windows")>
    Public globalFontBtn As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
    <SupportedOSPlatform("windows")>
    Public globalFontTxt As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
    <SupportedOSPlatform("windows")>
    Public globalFontLbl As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
    <SupportedOSPlatform("windows")>
    Public globalFontDgn As New System.Drawing.Font("Verdana", 8, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
#End Region

#Region "Security Globals"
    <SupportedOSPlatform("windows")>
    Public clsBridgekey As New Bridge.Security.Getkey

    <SupportedOSPlatform("windows")>
    Public clsBridgelog As New Bridge.Security.Writelog

    <SupportedOSPlatform("windows")>
    Public varSalt As String = clsBridgekey.Salt()

    <SupportedOSPlatform("windows")>
    Public varSyncfusionkey As String = clsBridgekey.Syncfusion

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public clsSecurityencrypt As New Security.Encrypt

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public clsSecuritydecrypt As New Security.Decrypt

    'new security
    Public clsSecurity_aes As System.Security.Cryptography.Aes
    Public clsSecurity_md5 As System.Security.Cryptography.MD5
    Public clsSecurity_crc32 As New System.IO.Hashing.Crc32

#End Region

#Region "Class Globals"
    Public clsCodebase As New ControlCodeBase
    Public clsFileinfo As New OperatingSystem.File.Info

#End Region

#Region "Variabel Global"
    Public varRandomcolor As New Random
    Public varAutoTrim As Boolean
    Public varHarusDiisi As Boolean

    'Public SEC As New Security.Engine

    Public frmERC As New frmERerrorreporting
    Public clsDBsqlite As New Database.Engine.SQLiteV3
    Public clsECerrorcatcher As Catcher.Error.Fields

    Public varVersionapplication As String
#End Region

    Public Function GETAPPVERSION() As String
        Dim varMajor, varMinor, varBuild, varRevision As Integer
        varMajor = My.Application.Info.Version.Major
        varMinor = My.Application.Info.Version.Minor
        varBuild = My.Application.Info.Version.Build
        varRevision = My.Application.Info.Version.Revision
        varVersionapplication = varMajor & "." & varMinor & "." & varBuild & "." & varRevision
        Return varVersionapplication
    End Function

    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        'License for Syncfusion

        'nuget version : 21.2.9
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
    End Sub

    Public Sub GETMACHINENAME()
        'GET Machinge Name
    End Sub

    Public Sub PUSHERRORDATA(ByVal FromSender As String, ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With clsECerrorcatcher
            .FromSender = FromSender
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

    <SupportedOSPlatform("windows")>
    Public Sub PUSHERRORDATASHOW()
        frmERC = New frmERerrorreporting(clsECerrorcatcher, )

        With frmERC
            .SLFNamaForm.Text = "Lady Bug (Error Catcher)"
            .SLFSubNamaForm.Text = "Please check detail below and report to system administrator."
            .ShowDialog()
        End With

        If Not (frmERC.ResumeNext) Then
            Process.GetCurrentProcess.Kill()
        End If
        frmERC.Dispose()
    End Sub
End Module
