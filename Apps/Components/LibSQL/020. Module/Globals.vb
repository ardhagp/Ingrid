Module Globals
    Public varDBengine_mssql2008 As New CMCv.Database.Engine.Mssql2008
    Public V_DBE_LocalDB As New CMCv.Database.Engine.LocalDB
    Public varDBengine_sqlite As New CMCv.Database.Engine.SQLiteV3
    Public varDBproperties(1) As CMCv.Database.Properties.Fields

    Public varDBreader_mssql2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
    Public varDBdisplay_mssql2008 As New CMCv.Database.Adapter.MSSQL2008.Execute

    Public varSecurityencrypt As New CMCv.Security.Encrypt

    Public varSecurity_aes As Security.Cryptography.Aes
    Public varSecurity_md5 As Security.Cryptography.MD5
    Public varSecurity_crc32 As New System.IO.Hashing.Crc32

    Public varVersionmajor As Integer = My.Application.Info.Version.Major
    Public varVersionminor As Integer = My.Application.Info.Version.Minor
    Public varVersionbuild As Integer = My.Application.Info.Version.Build
    Public varVersionrevision As Integer = My.Application.Info.Version.Revision
    Public varVersionapplication As String = varVersionmajor & "." & varVersionminor & "." & varVersionbuild & "." & varVersionrevision

    Public WithEvents frmMessage As New CMCv.frmDialogBox

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
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        frmMessage = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return frmMessage.ShowDialog()
        frmMessage.Dispose()
    End Function
#End Region
End Module
