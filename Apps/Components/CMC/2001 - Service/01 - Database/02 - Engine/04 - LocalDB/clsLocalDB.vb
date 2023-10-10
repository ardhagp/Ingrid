Imports System.Data
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class LocalDB
        Private v_CS(2) As String
        Private v_FilePath(2) As String

        Private v_CONN(2) As SqlClient.SqlConnection
        Private v_CMD(2) As SqlClient.SqlCommand
        Private v_DR(2) As SqlClient.SqlDataReader

        Private v_LocalDB As New Connect.LocalDBConnection

        Public Function CheckDBCatalog() As Boolean
            Try
                Dim v_DBPath As String = Nothing
                Dim v_DBExists(3) As Boolean

                Dim v_Location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                System.IO.Directory.CreateDirectory(v_Location & "\Resources")

                v_DBPath = v_Location & "\Resources\CATALOG.mdf"
                If _CFILEInfo.IsExists(v_DBPath) Then
                    v_DBExists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\CATALOG.mdf", v_Location & "\Resources\CATALOG.mdf", True)
                    If _CFILEInfo.IsExists(v_DBPath) Then
                        v_DBExists(1) = True
                    Else
                        v_DBExists(1) = False
                    End If
                End If

                v_DBPath = v_Location & "\Resources\DEV_CATALOG.mdf"
                If _CFILEInfo.IsExists(v_DBPath) Then
                    v_DBExists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\DEV_CATALOG.mdf", v_Location & "\Resources\DEV_CATALOG.mdf", True)
                    If _CFILEInfo.IsExists(v_DBPath) Then
                        v_DBExists(2) = True
                    Else
                        v_DBExists(2) = False
                    End If
                End If

                v_DBPath = v_Location & "\Resources\ERRLOG.mdf"
                If _CFILEInfo.IsExists(v_DBPath) Then
                    v_DBExists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\ERRLOG.mdf", v_Location & "\Resources\ERRLOG.mdf", True)
                    If _CFILEInfo.IsExists(v_DBPath) Then
                        v_DBExists(3) = True
                    Else
                        v_DBExists(3) = False
                    End If
                End If

                If ((v_DBExists(1)) AndAlso (v_DBExists(3))) OrElse ((v_DBExists(2)) AndAlso (v_DBExists(3))) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                Dim v_Location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                If Not (CheckDBCatalog()) Then
                    Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration Not found", 0, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Return
                End If

                If (IsProductionMode) Then
                    v_FilePath(0) = v_Location & "\Resources\CATALOG.mdf"
                Else
                    v_FilePath(0) = v_Location & "\Resources\DEV_CATALOG.mdf"
                End If

                Dim V_FileInfo As New OperatingSystem.File.Info

                If V_FileInfo.IsExists(v_FilePath(0)) Then
                    v_CS(0) = v_LocalDB.LocalDB_InitialCatalog(v_FilePath(0))

                    v_CONN(1) = New SqlClient.SqlConnection(v_CS(0)) 'OleDb.OleDbConnection(_CS(0))
                    v_CONN(1).Open()
                    'Else
                    '    GoTo FileNotFound
                End If

                v_FilePath(1) = v_Location & "\Resources\ERRLOG.mdf"

                If V_FileInfo.IsExists(v_FilePath(1)) Then
                    v_CS(1) = v_LocalDB.LocalDB_InitialCatalog(v_FilePath(1))

                    v_CONN(2) = New SqlClient.SqlConnection(v_CS(1))
                    v_CONN(2).Open()
                    'Else
                    '    GoTo FileNotFound
                End If
                'FileNotFound:
                '                MsgBox("One Of your components has been missing", MsgBoxStyle.OkOnly, "Ingrid Supporting App")
                'Application.Exit()
            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                v_DR(1) = GETDATAROW("Select LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.SERVERPORT, LIST.DBFORDATA, LIST.DBFORFILE FROM LIST WHERE LIST.DEFAULTCONNECTION =1;")

                Fields.ServerAddress = v_DR(1).GetString(0)
                Fields.Username = v_DR(1).GetString(1)
                Fields.Password = V_SECDecrypt.Rijndael(v_DR(1).GetString(2))
                Fields.Port = v_DR(1).GetValue(3)
                Fields.DataStorage = v_DR(1).GetString(4)
                Fields.FileStorage = v_DR(1).GetString(5)

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Try
                Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & NowDateTime & "');")
            Catch ex As Exception
                PUSHERRORDATA("[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        Private Function GETDATAROW(ByVal Query As String) As SqlClient.SqlDataReader
            Try
                v_CMD(1) = New SqlClient.SqlCommand With {
                            .Connection = v_CONN(1),
                            .CommandType = CommandType.Text,
                            .CommandText = Query
                }

                v_DR(0) = v_CMD(1).ExecuteReader

                If v_DR(0).HasRows Then
                    v_DR(0).Read()
                End If

                Return v_DR(0)
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Function GETVALUE(ByVal Query As String) As Object
            Try
                Dim v_ROWValue As Object

                v_CMD(1) = New SqlClient.SqlCommand With {
                            .Connection = v_CONN(1),
                            .CommandType = CommandType.Text,
                            .CommandTimeout = 30,
                            .CommandText = Query
                }

                v_ROWValue = v_CMD(1).ExecuteScalar

                Return v_ROWValue
            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Sub GETDATATABLE(ByVal DBR As Adapter.LocalDB.Display.Request, ByVal TableName As String)

            Dim v_DA(1) As SqlClient.SqlDataAdapter

            Try
                'If _DR(1) IsNot Nothing Then
                '    _DR(1).Close()
                'End If

                GC.Collect()

                Dim v_DS As New DataSet
                Dim v_BS As New BindingSource

                If (v_CMD(1) Is Nothing) Then 'Or (_CMD = Nothing) Then
                    v_CMD(1) = New SqlClient.SqlCommand
                End If

                v_CMD(1).Connection = v_CONN(1)
                v_CMD(1).CommandType = CommandType.Text
                v_CMD(1).CommandTimeout = 30

                'DBR.Query = "USE " & _FilePath(0) & " " & DBR.Query

                v_CMD(1).CommandText = DBR.Query

                v_DA(1) = New SqlClient.SqlDataAdapter(v_CMD(1))
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

            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub PUSHDATA(ByVal Query As String)
            Try
                v_CMD(1) = New SqlClient.SqlCommand With {
                                .Connection = v_CONN(1),
                                .CommandType = CommandType.Text,
                                .CommandText = Query
                                }

                v_CMD(1).ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode, ex.StackTrace, GETAPPVERSION, False, True, False)
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
