Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class LocalDB
        Private ReadOnly varConnectionstring(2) As String
        Private ReadOnly varFilepath(2) As String

        Private ReadOnly varConnection(2) As SqlClient.SqlConnection
        Private ReadOnly varCommand(2) As SqlClient.SqlCommand
        Private ReadOnly varDatareader(2) As SqlClient.SqlDataReader

        Private ReadOnly varLocaldb As New Connect.LocalDBConnection

        Shared ReadOnly varBasecatalog As String = "\Resources\CATALOG.mdf"
        Shared ReadOnly varBasedevcatalog As String = "\Resources\DEV_CATALOG.mdf"
        Shared ReadOnly varBaseerrorlog As String = "\Resources\ERRLOG.mdf"

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim varDbpath As String = Nothing
                Dim varDbexists(3) As Boolean

                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                System.IO.Directory.CreateDirectory(varLocation & "\Resources")

                varDbpath = varLocation & varBasecatalog
                If OperatingSystem.File.Info.IsExists(varDbpath) Then
                    varDbexists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & varBasecatalog, varLocation & varBasecatalog, True)
                    If OperatingSystem.File.Info.IsExists(varDbpath) Then
                        varDbexists(1) = True
                    Else
                        varDbexists(1) = False
                    End If
                End If

                varDbpath = varLocation & varBasedevcatalog
                If OperatingSystem.File.Info.IsExists(varDbpath) Then
                    varDbexists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & varBasedevcatalog, varLocation & varBasedevcatalog, True)
                    If OperatingSystem.File.Info.IsExists(varDbpath) Then
                        varDbexists(2) = True
                    Else
                        varDbexists(2) = False
                    End If
                End If

                varDbpath = varLocation & varBaseerrorlog
                If OperatingSystem.File.Info.IsExists(varDbpath) Then
                    varDbexists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & varBaseerrorlog, varLocation & varBaseerrorlog, True)
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
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                If Not (CheckDBCatalog()) Then
                    Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration Not found", 0.ToString, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Return
                End If

                If (IsProductionMode) Then
                    varFilepath(0) = varLocation & varBasecatalog
                Else
                    varFilepath(0) = varLocation & varBasedevcatalog
                End If

                If OperatingSystem.File.Info.IsExists(varFilepath(0)) Then
                    varConnectionstring(0) = varLocaldb.LocalDBInitialCatalog(varFilepath(0))

                    varConnection(1) = New SqlClient.SqlConnection(varConnectionstring(0)) 'OleDb.OleDbConnection(_CS(0))
                    varConnection(1).Open()
                End If

                varFilepath(1) = varLocation & varBaseerrorlog

                If OperatingSystem.File.Info.IsExists(varFilepath(1)) Then
                    varConnectionstring(1) = varLocaldb.LocalDBInitialCatalog(varFilepath(1))

                    varConnection(2) = New SqlClient.SqlConnection(varConnectionstring(1))
                    varConnection(2).Open()
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                varDatareader(1) = GETDATAROW("Select LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.SERVERPORT, LIST.DBFORDATA, LIST.DBFORFILE FROM LIST WHERE LIST.DEFAULTCONNECTION =1;")

                With varDatareader(1)
                    Fields.ServerAddress = .GetString(0)
                    Fields.Username = .GetString(1)
                    Fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                    Fields.Port = CType(.GetValue(3), Integer)
                    Fields.DataStorage = .GetString(4)
                    Fields.FileStorage = .GetString(5)
                End With

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Try
                Dim varNowdatetime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & varNowdatetime & "');")
            Catch ex As Exception
                PUSHERRORDATA("[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function GETDATAROW(ByVal Query As String) As SqlClient.SqlDataReader
            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                            .Connection = varConnection(1),
                            .CommandType = CommandType.Text,
                            .CommandText = Query
                }

                varDatareader(0) = varCommand(1).ExecuteReader

                If varDatareader(0).HasRows Then
                    varDatareader(0).Read()
                End If

                Return varDatareader(0)
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String) As Object
            Try
                Dim varRowvalue As Object

                varCommand(1) = New SqlClient.SqlCommand With {
                            .Connection = varConnection(1),
                            .CommandType = CommandType.Text,
                            .CommandTimeout = 30,
                            .CommandText = Query
                }

                varRowvalue = varCommand(1).ExecuteScalar

                Return varRowvalue
            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.LocalDB.Display.Request, ByVal TableName As String)

            Dim varDataadapter(1) As SqlClient.SqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingsource As New BindingSource

                If (varCommand(1) Is Nothing) Then
                    varCommand(1) = New SqlClient.SqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                varCommand(1).CommandText = DBR.Query

                varDataadapter(1) = New SqlClient.SqlDataAdapter(varCommand(1))
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

            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String)
            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                                .Connection = varConnection(1),
                                .CommandType = CommandType.Text,
                                .CommandText = Query
                                }

                varCommand(1).ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
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
