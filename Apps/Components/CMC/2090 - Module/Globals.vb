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
    Public V_BRIDGE_KEY As New Bridge.Security.GETKEY

    <SupportedOSPlatform("windows")>
    Public varBridgelog As New Bridge.Security.WRITELOG

    <SupportedOSPlatform("windows")>
    Public V_SALT As String = V_BRIDGE_KEY.SALT()

    <SupportedOSPlatform("windows")>
    Public V_SyncfusionKey As String = V_BRIDGE_KEY.SYNCFUSION

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public varSecurityencrypt As New Security.Encrypt

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public varSecuritydecrypt As New Security.Decrypt

    'new security
    Public varSecurity_aes As System.Security.Cryptography.Aes
    Public varSecurity_md5 As System.Security.Cryptography.MD5
    Public varSecurity_crc32 As New System.IO.Hashing.Crc32

#End Region

#Region "Class Globals"
    Public varControlcodebase As New ControlCodeBase
    Public varClassfileinfo As New OperatingSystem.File.Info

#End Region

#Region "Variabel Global"
    Public varRandomcolor As New Random
    Public varAutotrim As Boolean
    Public varHarusdiisi As Boolean

    Public frmError As New frmErrorReporting
    Public varERL As New Database.Engine.LocalDB
    Public clsErrorcatcher As Catcher.Error.Fields

    Public _APPVer As String
#End Region

    Public Function GETAPPVERSION() As String
        Dim varVersionmajor, varVersionminor, varVersionbuild, varVersionrevision As Integer
        varVersionmajor = My.Application.Info.Version.Major
        varVersionminor = My.Application.Info.Version.Minor
        varVersionbuild = My.Application.Info.Version.Build
        varVersionrevision = My.Application.Info.Version.Revision
        _APPVer = varVersionmajor & "." & varVersionminor & "." & varVersionbuild & "." & varVersionrevision
        Return _APPVer
    End Function

    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        'License for Syncfusion

        'nuget version : 21.2.9
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(V_SyncfusionKey)
    End Sub

    Public Sub GETMACHINENAME()
        'GET Machinge Name
    End Sub

    Public Sub PUSHERRORDATA(ByVal FromSender As String, ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With clsErrorcatcher
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
        frmError = New frmErrorReporting(clsErrorcatcher, )
        frmError.SLFNamaForm.Text = "Lady Bug (Error Catcher)"
        frmError.SLFSubNamaForm.Text = "Please check detail below and report to system administrator."
        frmError.ShowDialog()
        If Not (frmError.ResumeNext) Then
            Process.GetCurrentProcess.Kill()
        End If
        frmError.Dispose()
    End Sub
End Module
