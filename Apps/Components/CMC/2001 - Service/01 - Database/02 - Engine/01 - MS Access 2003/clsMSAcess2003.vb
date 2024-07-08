Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class MSAccess2003
        Private ReadOnly _CS(2) As String
        Private ReadOnly _FilePath(2) As String

        Private ReadOnly _CONN(2) As OleDb.OleDbConnection
        Private ReadOnly _CMD(2) As OleDb.OleDbCommand
        Private ReadOnly _DR(2) As OleDb.OleDbDataReader

        Private ReadOnly _MSA2003C As New Connect.MSAccess2003Connection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim _DBPath As String = Nothing
                Dim _DBExists(2) As Boolean

                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Resources")

                _DBPath = Application.StartupPath & "\Resources\CATALOG.mdb"
                If OperatingSystem.File.Info.IsExists(_DBPath) Then
                    _DBExists(1) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.catalog, True)
                    _DBExists(1) = False
                End If

                _DBPath = Application.StartupPath & "\Resources\DEV_CATALOG.mdb"
                If OperatingSystem.File.Info.IsExists(_DBPath) Then
                    _DBExists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.dev_catalog, True)
                    _DBExists(2) = False
                End If

                _DBPath = Application.StartupPath & "\Resources\ERRLOG.mdb"
                If OperatingSystem.File.Info.IsExists(_DBPath) Then
                    _DBExists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.errlog, True)
                    _DBExists(2) = False
                End If

                If (_DBExists(1)) AndAlso (_DBExists(2)) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "", ex.StackTrace, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return False
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                CheckDBCatalog()

                If (IsProductionMode) Then
                    _FilePath(0) = Application.StartupPath & "\Resources\CATALOG.mdb"
                Else
                    _FilePath(0) = Application.StartupPath & "\Resources\DEV_CATALOG.mdb"
                End If

                Dim V_FileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(_FilePath(0)) Then
                    _CS(0) = _MSA2003C.MicrosoftOLEDBStandard(_FilePath(0), "admin", "")

                    _CONN(0) = New OleDb.OleDbConnection(_CS(0))
                    _CONN(0).Open()
                End If

                _FilePath(1) = Application.StartupPath & "\Resources\ERRLOG.mdb"

                If OperatingSystem.File.Info.IsExists(_FilePath(1)) Then
                    _CS(1) = _MSA2003C.MicrosoftOLEDBStandard(_FilePath(1), "admin", "")

                    _CONN(1) = New OleDb.OleDbConnection(_CS(1))
                    _CONN(1).Open()
                End If

            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "0", ex.StackTrace, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Database.Properties.Fields) As Database.Properties.Fields
            Try
                _DR(0) = GETDATAROW("SELECT LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.ACCEPTEDLINECONNECTION FROM LIST WHERE LIST.ID =1;", _CONN(0), _CMD(0))

                Fields.ServerAddress = _DR(0).GetString(0)
                Fields.Username = _DR(0).GetString(1)
                'Fields.Password = V_SECDecrypt.Rijndael(_DR(0).GetString(2))
                Fields.Password = CMCv.Security.Decrypt.AES(_DR(0).GetString(2))
                Fields.Port = _DR(0).GetValue(3)
                Fields.DataStorage = _DR(0).GetString(4)
                Fields.FileStorage = _DR(0).GetString(5)

                Return Fields
            Catch ex As System.Data.OleDb.OleDbException
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode, ex.StackTrace, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
            Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & NowDateTime & "');", _CONN(1), _CMD(1))
        End Sub

        <SupportedOSPlatform("windows")>
        Private Shared Function GETDATAROW(ByVal Query As String, ByVal MyConnection As OleDb.OleDbConnection, ByVal MyCommand As OleDb.OleDbCommand) As OleDb.OleDbDataReader
            Try
                Dim _DR As OleDb.OleDbDataReader

                MyCommand = New OleDb.OleDbCommand With {
                .Connection = MyConnection,
                .CommandType = CommandType.Text,
                .CommandText = Query}

                MyCommand = New System.Data.OleDb.OleDbCommand(Query, MyConnection)
                _DR = MyCommand.ExecuteReader

                If _DR.HasRows Then
                    _DR.Read()
                End If

                Return _DR
            Catch ex As System.Data.OleDb.OleDbException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Sub PUSHDATA(ByVal Query As String, ByVal MyConnection As OleDb.OleDbConnection, ByVal MyCommand As OleDb.OleDbCommand)
            Try
                MyCommand = New OleDb.OleDbCommand With {
                .Connection = MyConnection,
                .CommandType = CommandType.Text,
                .CommandText = Query}
                MyCommand.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode, ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Close()
            _CONN(1).Close()
            _CONN(2).Close()
            _CONN(1).Dispose()
            _CONN(2).Dispose()
        End Sub
    End Class
End Namespace
