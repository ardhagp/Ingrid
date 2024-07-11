Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class Mssql2008
        Implements IDisposable

        Private ReadOnly varConnection(1) As SqlClient.SqlConnection
        Private ReadOnly varCommand(1) As SqlClient.SqlCommand
        Private varAdapter As SqlClient.SqlDataAdapter

        Private ReadOnly V_MSSQL2008 As New Connect.Mssqlserver2008connection

        Public Enum DatabaseID
            DbDefault
            DbCustom
        End Enum

        Private disposedValue As Boolean

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing AndAlso varAdapter IsNot Nothing Then
                    varAdapter.Dispose()
                End If

                varAdapter = Nothing

                disposedValue = True
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function Open(ByVal Fields As Properties.Fields, Optional ByVal Splash As Form = Nothing) As Boolean
            Dim varSuccess As Boolean
            Try
                varConnection(1) = New SqlClient.SqlConnection(V_MSSQL2008.Mssql2008standard(Fields.ServerAddress, Fields.Port, Fields.DataStorage, Fields.Username, Fields.Password))
                varConnection(1).Open()
                varSuccess = True
            Catch ex As SqlClient.SqlException
                Splash?.Close()
                varSuccess = False
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
                Call PUSHERRORDATASHOW()
            End Try
            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETDATAROW(ByVal Query As String, Optional ByVal DatabaseName As String = "db_universe_erp") As SqlClient.SqlDataReader ', ByVal MyConnection As SqlClient.SqlConnection, ByVal MyCommand As SqlClient.SqlCommand) As SqlClient.SqlDataReader
            Dim varDatareader(1) As SqlClient.SqlDataReader

            Try
                Dim varCommand0 As New SqlClient.SqlCommand

                Query = "USE " & DatabaseName & "; " & Query

                varCommand0 = New SqlClient.SqlCommand(Query, varConnection(1))
                varDatareader(1) = varCommand0.ExecuteReader(CommandBehavior.CloseConnection)

                If varDatareader(1).HasRows Then
                    varDatareader(1).Read()
                End If

                Return varDatareader(1)
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, 0.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String, Optional ByVal DatabaseName As String = "db_universe_erp") As Object
            Try
                Dim varRowvalue As Object

                varCommand(1) = New SqlClient.SqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text,
                .CommandTimeout = 30}

                Query = "USE " & DatabaseName & "; " & Query

                varCommand(1).CommandText = Query

                varRowvalue = varCommand(1).ExecuteScalar

                Return varRowvalue

            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETDATASET(ByVal DBR As Adapter.MSSQL2008.Display.Request, ByVal TableName As String, Optional ByVal DatabaseName As String = "db_universe_erp") As DataSet
            Dim varDataadapter(1) As SqlClient.SqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingsource As New BindingSource

                If IsNothing(varCommand(1)) Then
                    varCommand(1) = New SqlClient.SqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                DBR.Query = "USE " & DatabaseName & "; " & DBR.Query

                varCommand(1).CommandText = DBR.Query

                varDataadapter(1) = New SqlClient.SqlDataAdapter(varCommand(1))
                varDataadapter(1).Fill(varDataset, TableName)

                varBindingsource = New BindingSource(varDataset, TableName)

                Return varDataset
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATASET] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, 0.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.MSSQL2008.Display.Request, ByVal TableName As String, Optional ByVal DatabaseName As String = "db_universe_erp")

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

                DBR.Query = "USE " & DatabaseName & "; " & DBR.Query

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
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String, Optional ByVal DatabaseName As String = "db_universe_erp")
            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text}

                Query = "USE " & DatabaseName & "; " & Query

                varCommand(1).CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)
                varCommand(1).ExecuteNonQuery()
            Catch ex As Exception
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "0", ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function PUSHIMAGE(ByVal CMD As SqlClient.SqlCommand) As Boolean
            Dim varSuccess As Boolean

            Try
                varCommand(1) = New SqlClient.SqlCommand

                If CMD IsNot Nothing Then
                    varCommand(1) = CMD
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).ExecuteNonQuery()
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
                Call PUSHERRORDATA("[PUSHIMAGE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try

            Return varSuccess
        End Function

        Public Function FILLDATASET(ByVal Query As String, ByVal DataSetName As DataSet, ByVal TableName As String, Optional ByVal DatabaseName As String = "db_universe_erp") As DataSet
            GC.Collect()

            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text}

                Query = "USE " & DatabaseName & "; " & Query

                varCommand(1).CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)
                varAdapter = New SqlClient.SqlDataAdapter(varCommand(1))
                varAdapter.Fill(DataSetName, TableName)
                varAdapter = Nothing
            Catch ex As Exception
                DataSetName = Nothing
                Call PUSHERRORDATA("[FILLDATASET] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, False, False)
            End Try

            Return DataSetName
        End Function

        Public Sub Close()
            varConnection(1).Close()
            varConnection(1).Dispose()
        End Sub
    End Class

End Namespace
