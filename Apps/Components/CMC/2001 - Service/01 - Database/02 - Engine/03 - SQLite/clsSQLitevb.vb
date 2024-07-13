Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Versioning

Namespace Database.Engine
    Public Class SQLiteV3
        Private ReadOnly varConnectionstring(2) As String
        Private ReadOnly varFilepath(2) As String

        Private ReadOnly varConnection(2) As SQLite.SQLiteConnection
        Private ReadOnly varCommand(2) As SQLite.SQLiteCommand
        Private ReadOnly varDatareader(2) As SQLite.SQLiteDataReader

        Private ReadOnly varSqlite As New Connect.SQLiteConnection

        Shared ReadOnly varBaseCatalog As String = "\Resources\catalog.db"
        Shared ReadOnly varBaseDevCatalog As String = "\Resources\dev_catalog.db"
        Shared ReadOnly varErrorlog As String = "\Resources\errlog.db"

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim varDbpath As String = Nothing
                Dim varDbexists(3) As Boolean

                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                System.IO.Directory.CreateDirectory(varLocation & "\Resources")

                varDbpath = varLocation & varBaseCatalog
                If OperatingSystem.File.Info.IsExists(varDbpath) Then
                    varDbexists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & varBaseCatalog, varLocation & varBaseCatalog, True)
                    If OperatingSystem.File.Info.IsExists(varDbpath) Then
                        varDbexists(1) = True
                    Else
                        varDbexists(1) = False
                    End If
                End If

                varDbpath = varLocation & varBaseDevCatalog
                If OperatingSystem.File.Info.IsExists(varDbpath) Then
                    varDbexists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & varBaseDevCatalog, varLocation & varBaseDevCatalog, True)
                    If OperatingSystem.File.Info.IsExists(varDbpath) Then
                        varDbexists(2) = True
                    Else
                        varDbexists(2) = False
                    End If
                End If

                varDbpath = varLocation & varErrorlog
                If OperatingSystem.File.Info.IsExists(varDbpath) Then
                    varDbexists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & varErrorlog, varLocation & varErrorlog, True)
                    If OperatingSystem.File.Info.IsExists(varDbpath) Then
                        varDbexists(3) = True
                    Else
                        varDbexists(3) = False
                    End If
                End If

                If ((varDbexists(1)) AndAlso (varDbexists(3))) OrElse ((varDbexists(2)) AndAlso (varDbexists(3))) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                If Not (CheckDBCatalog()) Then
                    Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration Not found", 0.ToString, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Return
                End If

                If (IsProductionMode) Then
                    varFilepath(0) = varLocation & varBaseCatalog
                Else
                    varFilepath(0) = varLocation & varBaseDevCatalog
                End If

                If OperatingSystem.File.Info.IsExists(varFilepath(0)) Then
                    varFilepath(0) = Replace(varFilepath(0), "\", "\\")

                    varConnectionstring(0) = varSqlite.SQLiteBasic(varFilepath(0))

                    varConnection(1) = New SQLite.SQLiteConnection(varConnectionstring(0)) 'OleDb.OleDbConnection(_CS(0))
                    varConnection(1).Open()
                End If

                varFilepath(1) = varLocation & varErrorlog

                If OperatingSystem.File.Info.IsExists(varFilepath(1)) Then
                    varFilepath(1) = Replace(varFilepath(1), "\", "\\")

                    varConnectionstring(1) = varSqlite.SQLiteBasic(varFilepath(1))

                    varConnection(2) = New SQLite.SQLiteConnection(varConnectionstring(1))
                    varConnection(2).Open()
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub OpenAppSettings()
            Try

            Catch ex As Exception
                Call PUSHERRORDATA("[OpenAppSettings] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                varDatareader(1) = GETDATAROW("Select SERVERADDRESS, USERNAME, PASSWORD, SERVERPORT, DBFORDATA, DBFORFILE FROM serverlist WHERE DEFAULTCONNECTION =1;")

                With varDatareader(1)
                    If .HasRows Then
                        Fields.ServerAddress = .GetString(0)
                        Fields.Username = .GetString(1)
                        Fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                        Fields.Port = CType(.GetValue(3), Integer)
                        Fields.DataStorage = .GetString(4)
                        Fields.FileStorage = .GetString(5)
                    Else
                        Fields.ServerAddress = String.Empty
                        Fields.Username = String.Empty
                        Fields.Password = String.Empty
                        Fields.Port = 1433
                        Fields.DataStorage = String.Empty
                        Fields.FileStorage = String.Empty
                    End If
                End With

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal clsErrorcatcher As Catcher.Error.Fields)
            Try
                Dim varNowdatetime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & clsErrorcatcher.Type & "','" & clsErrorcatcher.Message & "'," & clsErrorcatcher.Number & ",'" & clsErrorcatcher.InternalStackTrace & "'," & clsErrorcatcher.EnableErrorReporting & ",'" & varNowdatetime & "');")
            Catch ex As Exception
                PUSHERRORDATA("[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function GETDATAROW(ByVal Query As String) As SQLite.SQLiteDataReader
            Try
                varCommand(1) = New SQLite.SQLiteCommand With {
                                .Connection = varConnection(1),
                                .CommandType = CommandType.Text,
                                .CommandText = Query
                                                    }

                varDatareader(0) = varCommand(1).ExecuteReader

                If varDatareader(0).HasRows Then
                    varDatareader(0).Read()
                End If

                Return varDatareader(0)
            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String) As Object
            Try
                Dim varRowvalue As Object

                If (varConnection(1) Is Nothing) Then
                    varConnection(1).Open()
                End If

                varCommand(1) = New SQLite.SQLiteCommand With {
                                .Connection = varConnection(1),
                                .CommandTimeout = 30,
                                .CommandText = Query
                    }

                varRowvalue = varCommand(1).ExecuteScalar

                Return varRowvalue
            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.SQLite.Display.Request, ByVal TableName As String)

            Dim varDataadapter(1) As SQLite.SQLiteDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingsource As New BindingSource

                If (varCommand(1) Is Nothing) Then
                    varCommand(1) = New SQLite.SQLiteCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandTimeout = 30

                varCommand(1).CommandText = DBR.Query

                varDataadapter(1) = New SQLite.SQLiteDataAdapter(varCommand(1))
                varDataadapter(1).Fill(varDataset, TableName)

                varBindingsource = New BindingSource(varDataset, TableName)

                If Not (DBR.DataGrid Is Nothing) Then
                    DBR.DataGrid.DataSource = varBindingsource
                End If

                If Not (DBR.Dropdown Is Nothing) Then
                    DBR.Dropdown.DataSource = varBindingsource
                End If

                If Not (DBR.StatusBar Is Nothing) AndAlso (DBR.StatusBar.Items.Count <> 0) Then
                    DBR.StatusBar.Items(0).Text = varBindingsource.Count & " Row(s)"
                End If

                If Not (DBR.Chart Is Nothing) Then
                    DBR.Chart.DataSource = varBindingsource
                End If

            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String)
            Try
                Using varTransaction = varConnection(1).BeginTransaction
                    Dim varWcommand = varConnection(1).CreateCommand

                    varWcommand.CommandText = Query
                    varWcommand.ExecuteNonQuery()
                    varTransaction.Commit()
                End Using

            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub Close()
            varConnection(1).Close()
            varConnection(2).Close()
            varConnection(1).Dispose()
            varConnection(2).Dispose()
        End Sub
    End Class
End Namespace
