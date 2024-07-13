Module Globals
    Public varDBengine_mssql2008 As New CMCv.Database.Engine.Mssql2008
    Public varDBengine_localdb As New CMCv.Database.Engine.LocalDB
    Public varDBengine_sqlite As New CMCv.Database.Engine.SQLiteV3
    Public varDBproperties(1) As CMCv.Database.Properties.Fields

    Public varDBreader_mssql2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
    Public varDBadapter_mssql2008 As New CMCv.Database.Adapter.MSSQL2008.Execute

    Public varSecurityencrypt As New CMCv.Security.Encrypt

    Public clsSecurity_aes As Security.Cryptography.Aes
    Public clsSecurity_md5 As Security.Cryptography.MD5
    Public clsSecurity_crc32 As New System.IO.Hashing.Crc32

    Public varMajor As Integer = My.Application.Info.Version.Major
    Public varMinor As Integer = My.Application.Info.Version.Minor
    Public varBuild As Integer = My.Application.Info.Version.Build
    Public varRevision As Integer = My.Application.Info.Version.Revision
    Public varVersionapplication As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents frmMSG As New CMCv.frmDBdialogbox

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
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDBdialogbox.MessageIcon, ByVal ButtonType As CMCv.frmDBdialogbox.MessageTypes) As System.Windows.Forms.DialogResult
        frmMSG = New CMCv.frmDBdialogbox(Message, Title, MessageIcon, ButtonType)
        Return frmMSG.ShowDialog()
        frmMSG.Dispose()
    End Function
#End Region
End Module
