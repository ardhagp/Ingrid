Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Versioning

Namespace Database.Engine
    Public Class SQLiteV3
        Private ReadOnly v_CS(2) As String
        Private ReadOnly v_FilePath(2) As String

        Private ReadOnly V_CONN(2) As SQLite.SQLiteConnection
        Private ReadOnly V_CMD(2) As SQLite.SQLiteCommand
        Private ReadOnly V_DR(2) As SQLite.SQLiteDataReader

        Private ReadOnly V_SQLite As New Connect.SQLiteConnection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim V_DBPath As String = Nothing
                Dim V_DBExists(3) As Boolean

                Dim V_Location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                System.IO.Directory.CreateDirectory(V_Location & "\Resources")

                V_DBPath = V_Location & "\Resources\catalog.db"
                If _CFILEInfo.IsExists(V_DBPath) Then
                    V_DBExists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\catalog.db", V_Location & "\Resources\catalog.db", True)
                    If _CFILEInfo.IsExists(V_DBPath) Then
                        V_DBExists(1) = True
                    Else
                        V_DBExists(1) = False
                    End If
                End If

                V_DBPath = V_Location & "\Resources\dev_catalog.db"
                If _CFILEInfo.IsExists(V_DBPath) Then
                    V_DBExists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\dev_catalog.db", V_Location & "\Resources\dev_catalog.db", True)
                    If _CFILEInfo.IsExists(V_DBPath) Then
                        V_DBExists(2) = True
                    Else
                        V_DBExists(2) = False
                    End If
                End If

                V_DBPath = V_Location & "\Resources\errlog.db"
                If _CFILEInfo.IsExists(V_DBPath) Then
                    V_DBExists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\errlog.db", V_Location & "\Resources\errlog.db", True)
                    If _CFILEInfo.IsExists(V_DBPath) Then
                        V_DBExists(3) = True
                    Else
                        V_DBExists(3) = False
                    End If
                End If

                If ((V_DBExists(1)) AndAlso (V_DBExists(3))) OrElse ((V_DBExists(2)) AndAlso (V_DBExists(3))) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                Dim V_Location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                If Not (CheckDBCatalog()) Then
                    Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration Not found", 0, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Return
                End If

                If (IsProductionMode) Then
                    v_FilePath(0) = V_Location & "\Resources\catalog.db"
                Else
                    v_FilePath(0) = V_Location & "\Resources\dev_catalog.db"
                End If

                Dim V_FileInfo As New OperatingSystem.File.Info

                If V_FileInfo.IsExists(v_FilePath(0)) Then
                    'For SQLite Only
                    v_FilePath(0) = Replace(v_FilePath(0), "\", "\\")
                    'v_FilePath(0) = Replace(v_FilePath(0), ".db", "")

                    v_CS(0) = v_SQLite.SQLite_Basic(v_FilePath(0))

                    v_CONN(1) = New SQLite.SQLiteConnection(v_CS(0)) 'OleDb.OleDbConnection(_CS(0))
                    v_CONN(1).Open()

                    'Else
                    '    GoTo FileNotFound
                End If

                v_FilePath(1) = V_Location & "\Resources\errlog.db"

                If V_FileInfo.IsExists(v_FilePath(1)) Then
                    'For SQLite Only
                    v_FilePath(1) = Replace(v_FilePath(1), "\", "\\")
                    'v_FilePath(1) = Replace(v_FilePath(0), ".db", "")

                    v_CS(1) = v_SQLite.SQLite_Basic(v_FilePath(1))

                    v_CONN(2) = New SQLite.SQLiteConnection(v_CS(1))
                    v_CONN(2).Open()
                    'Else
                    '    GoTo FileNotFound
                End If
                'FileNotFound:
                '                MsgBox("One Of your components has been missing", MsgBoxStyle.OkOnly, "Ingrid Supporting App")
                'Application.Exit()
            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub OpenAppSettings()
            Try

            Catch ex As Exception
                Call PUSHERRORDATA("[OpenAppSettings] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                v_DR(1) = GETDATAROW("Select SERVERADDRESS, USERNAME, PASSWORD, SERVERPORT, DBFORDATA, DBFORFILE FROM serverlist WHERE DEFAULTCONNECTION =1;")

                If v_DR(1).HasRows Then
                    Fields.ServerAddress = v_DR(1).GetString(0)
                    Fields.Username = v_DR(1).GetString(1)
                    'Fields.Password = V_SECDecrypt.Rijndael(v_DR(1).GetString(2))
                    Fields.Password = CMCv.Security.Decrypt.AES(v_DR(1).GetString(2))
                    Fields.Port = v_DR(1).GetValue(3)
                    Fields.DataStorage = v_DR(1).GetString(4)
                    Fields.FileStorage = v_DR(1).GetString(5)
                Else
                    Fields.ServerAddress = ""
                    Fields.Username = ""
                    Fields.Password = ""
                    Fields.Port = 1433
                    Fields.DataStorage = ""
                    Fields.FileStorage = ""
                End If

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Try
                Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & NowDateTime & "');")
            Catch ex As Exception
                PUSHERRORDATA("[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function GETDATAROW(ByVal Query As String) As SQLite.SQLiteDataReader
            Try
                v_CMD(1) = New SQLite.SQLiteCommand With {
                                .Connection = v_CONN(1),
                                .CommandType = CommandType.Text,
                                .CommandText = Query
                                                    }

                v_DR(0) = v_CMD(1).ExecuteReader

                If v_DR(0).HasRows Then
                    v_DR(0).Read()
                End If

                Return v_DR(0)
            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String) As Object
            Try
                Dim v_ROWValue As Object

                If (v_CONN(1) Is Nothing) Then
                    v_CONN(1).Open()
                End If

                v_CMD(1) = New SQLite.SQLiteCommand With {
                                .Connection = v_CONN(1),
                                .CommandTimeout = 30,
                                .CommandText = Query
                    }

                v_ROWValue = v_CMD(1).ExecuteScalar

                Return v_ROWValue
            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.SQLite.Display.Request, ByVal TableName As String)

            Dim v_DA(1) As SQLite.SQLiteDataAdapter

            Try
                GC.Collect()

                Dim v_DS As New DataSet
                Dim v_BS As New BindingSource

                If (v_CMD(1) Is Nothing) Then 'Or (_CMD = Nothing) Then
                    v_CMD(1) = New SQLite.SQLiteCommand
                End If

                v_CMD(1).Connection = v_CONN(1)
                v_CMD(1).CommandTimeout = 30

                'DBR.Query = "USE " & _FilePath(0) & " " & DBR.Query

                v_CMD(1).CommandText = DBR.Query

                v_DA(1) = New SQLite.SQLiteDataAdapter(v_CMD(1))
                v_DA(1).Fill(v_DS, TableName)

                v_BS = New BindingSource(v_DS, TableName)

                If Not (DBR.DataGrid Is Nothing) Then
                    DBR.DataGrid.DataSource = v_BS
                End If

                If Not (DBR.Dropdown Is Nothing) Then
                    DBR.Dropdown.DataSource = v_BS
                End If

                If Not (DBR.StatusBar Is Nothing) AndAlso (DBR.StatusBar.Items.Count <> 0) Then
                    DBR.StatusBar.Items(0).Text = v_BS.Count & " Row(s)"
                End If

                If Not (DBR.Chart Is Nothing) Then
                    DBR.Chart.DataSource = v_BS
                End If

            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String)
            Try
                Using TX = v_CONN(1).BeginTransaction
                    Dim W_CMD = v_CONN(1).CreateCommand
                    W_CMD.CommandText = Query

                    W_CMD.ExecuteNonQuery()

                    TX.Commit()
                End Using

            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub Close()
            v_CONN(1).Close()
            v_CONN(2).Close()
            v_CONN(1).Dispose()
            v_CONN(2).Dispose()
        End Sub
    End Class
End Namespace
