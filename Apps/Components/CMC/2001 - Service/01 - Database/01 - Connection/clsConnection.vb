Imports CMCv.Database.Provider

Namespace Database.Connect
    ''' <summary>
    ''' Database connection string untuk berbagai provider
    ''' </summary>
    ''' <remarks></remarks>
    Friend Interface IMSAccess2003Connections
#Region "OLEDB"
        ''' <summary>
        ''' Koneksi database Access 2003 menggunakan OLEDB
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function MicrosoftOLEDBStandard(ByVal DatabasePath As String, ByVal Username As String, ByVal Password As String)
#End Region

#Region "ODBC"
        ''' <summary>
        ''' Koneksi database Access 2003 Standard
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function MicrosoftODBCStandard(ByVal DatabasePath As String, ByVal Username As String, ByVal Password As String)
#End Region
    End Interface

    Friend Interface IMSSQLServer2008Connections
#Region ".NET Standard"

        ''' <summary>
        ''' Koneksi SQL Server 2008 Standard
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="DatabaseName">Nama database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MSSQL2008Standard(ByVal ServerAddress As String, ByVal ServerPort As Integer, ByVal DatabaseName As String, ByVal Username As String, ByVal Password As String)

        ''' <summary>
        ''' Koneksi SQL Server 2008 Trusted Connection
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="DatabaseName">Nama database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MSSQL2008TrustedConnection(ByVal ServerAddress As String, ByVal DatabaseName As String)
#End Region
    End Interface

    Friend Interface IMySQLConnections
#Region "ODBC51"
        ''' <summary>
        ''' Konksi database ODBC51 Standard
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <param name="Database">Database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLODBC51Standard(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String) As String
#End Region

#Region ".NET InactivatingPreparedStatement"

        ''' <summary>
        ''' Koneksi database MySQL .NET Inactivating Prepared Statement
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <param name="Database">Database</param>
        ''' <param name="IgnorePrepare">Ignore Prepare</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETInactivatingPreparedStatement(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal IgnorePrepare As Options.IgnorePrepare) As String
#End Region

#Region ".NET NamedPipes"

        ''' <summary>
        ''' Koneksi database MySQL .NET Named Pipes
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Passoword</param>
        ''' <param name="Database">Database</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function MySQLNETNamedPipes(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String)
#End Region

#Region ".NET NetworkProtocol"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress">IP or Hostname</param>
        ''' <param name="Port"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Protocol"></param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function MySQLNETNetworkProtocol(ByVal ServerAddress As String, ByVal Port As Integer, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Protocol As Options.Protocol) As String
#End Region

#Region ".NET Standard"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETStandard(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String) As String
#End Region

#Region ".NET SpcifyingCharacterSet"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="CharSet"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETSpecifyingCharacterSet(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal CharSet As Options.CharSet) As String
#End Region

#Region ".NET SpecifyingCommandTimeout"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Port"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Timeout"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETSpecifyingCommandTimeout(ByVal ServerAddress As String, ByVal Port As Integer, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Timeout As Integer) As String
#End Region

#Region ".NET SpecifyingPort"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Port"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETSpecifyingPort(ByVal ServerAddress As String, ByVal Port As Integer, ByVal Username As String, ByVal Password As String, ByVal Database As String) As String
#End Region

#Region ".NET SpecifyingSharedMemoryName"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="SharedMemoryName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETSpecifyingSharedMemoryName(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal SharedMemoryName As Options.SharedMemoryName) As String
#End Region

#Region ".NET UsingEncryption"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Encryption"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETUsingEncryption(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Encryption As Options.Encryption) As String
#End Region

#Region ".NET UsingEncryptionAlternative"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Encrypt"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQLNETUsingEncryptionAlternative(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Encrypt As Options.Encryption) As String
#End Region

    End Interface

    Friend Interface ILocalDBConnections
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Function LocalDBAutomaticInstance() As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DBFileName"></param>
        ''' <returns></returns>
        Function LocalDBAttachDB(ByVal DBFileName As String) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="InstanceName"></param>
        ''' <returns></returns>
        Function LocalDBSpecifiedInstance(ByVal InstanceName As String) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DBFileName"></param>
        ''' <returns></returns>
        Function LocalDBInitialCatalog(ByVal DBFileName As String) As String

    End Interface

    Friend Interface ISQLite
        Function SQLiteBasic(ByVal DBFile As String) As String

        Function SQLiteOpenWithPassword(ByVal DBFile As String, ByVal Password As String) As String

    End Interface

    '-----------------------------------------------------------------------------
    Public Class MSAccess2003Connection
        Implements IMSAccess2003Connections
        ''' <summary>
        ''' Koneksi database Access 2003
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Function MicrosoftODBCStandard(DatabasePath As String, Username As String, Password As String) As Object Implements IMSAccess2003Connections.MicrosoftODBCStandard
            _RESULT = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & DatabasePath & ";Uid=" & Username & ";Pwd=" & Password & ";"
            Return _RESULT
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DatabasePath"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MicrosoftOLEDBStandard(DatabasePath As String, Username As String, Password As String) As Object Implements IMSAccess2003Connections.MicrosoftOLEDBStandard
            _RESULT = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabasePath & ";User Id=" & Username & ";Password=" & Password & ";"
            Return _RESULT
        End Function
    End Class

    Public Class MSSQLServer2008Connection
        Implements IMSSQLServer2008Connections

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="ServerPort"></param>
        ''' <param name="DatabaseName"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MSSQL2008Standard(ServerAddress As String, ByVal ServerPort As Integer, ByVal DatabaseName As String, Username As String, Password As String) As Object Implements IMSSQLServer2008Connections.MSSQL2008Standard
            _RESULT = String.Format("Server = {0},{1}; Database = {2}; User Id = {3}; Password = {4};", ServerAddress.Trim, ServerPort, DatabaseName, Username.Trim, Password)
            Return _RESULT
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="DatabaseName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MSSQL2008TrustedConnection(ServerAddress As String, DatabaseName As String) As Object Implements IMSSQLServer2008Connections.MSSQL2008TrustedConnection
            _RESULT = "Server = " & ServerAddress.Trim & "; Database = " & DatabaseName & "; Trusted_Connection = True;"
            Return _RESULT
        End Function
    End Class

    Public Class MySQLConnection
        Implements IMySQLConnections

        Public Function MySQLNETInactivatingPreparedStatement(ServerAddress As String, Username As String, Password As String, Database As String, IgnorePrepare As Options.IgnorePrepare) As String Implements IMySQLConnections.MySQLNETInactivatingPreparedStatement
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETNamedPipes(ServerAddress As String, Username As String, Password As String, Database As String) As Object Implements IMySQLConnections.MySQLNETNamedPipes
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETNetworkProtocol(ServerAddress As String, Port As Integer, Username As String, Password As String, Database As String, Protocol As Options.Protocol) As String Implements IMySQLConnections.MySQLNETNetworkProtocol
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETSpecifyingCharacterSet(ServerAddress As String, Username As String, Password As String, Database As String, CharSet As Options.CharSet) As String Implements IMySQLConnections.MySQLNETSpecifyingCharacterSet
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETSpecifyingCommandTimeout(ServerAddress As String, Port As Integer, Username As String, Password As String, Database As String, Timeout As Integer) As String Implements IMySQLConnections.MySQLNETSpecifyingCommandTimeout
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETSpecifyingPort(ServerAddress As String, Port As Integer, Username As String, Password As String, Database As String) As String Implements IMySQLConnections.MySQLNETSpecifyingPort
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETSpecifyingSharedMemoryName(ServerAddress As String, Username As String, Password As String, Database As String, SharedMemoryName As Options.SharedMemoryName) As String Implements IMySQLConnections.MySQLNETSpecifyingSharedMemoryName
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETStandard(ServerAddress As String, Username As String, Password As String, Database As String) As String Implements IMySQLConnections.MySQLNETStandard
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETUsingEncryption(ServerAddress As String, Username As String, Password As String, Database As String, Encryption As Options.Encryption) As String Implements IMySQLConnections.MySQLNETUsingEncryption
            Throw New NotImplementedException()
        End Function

        Public Function MySQLNETUsingEncryptionAlternative(ServerAddress As String, Username As String, Password As String, Database As String, Encrypt As Options.Encryption) As String Implements IMySQLConnections.MySQLNETUsingEncryptionAlternative
            Throw New NotImplementedException()
        End Function

        Public Function MySQLODBC51Standard(ServerAddress As String, Username As String, Password As String, Database As String) As String Implements IMySQLConnections.MySQLODBC51Standard
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class LocalDBConnection
        Implements ILocalDBConnections

        Public Function LocalDBAttachDB(DBFileName As String) As String Implements ILocalDBConnections.LocalDBAttachDB
            _RESULT = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" & DBFileName & ";"
            Return _RESULT
        End Function

        Public Function LocalDBAutomaticInstance() As String Implements ILocalDBConnections.LocalDBAutomaticInstance
            _RESULT = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"
            Return _RESULT
        End Function

        Public Function LocalDBSpecifiedInstance(InstanceName As String) As String Implements ILocalDBConnections.LocalDBSpecifiedInstance
            _RESULT = "Server=(localdb)\" & InstanceName & ";Integrated Security=true;"
            Return _RESULT
        End Function

        Public Function LocalDBInitialCatalog(DBFileName As String) As String Implements ILocalDBConnections.LocalDBInitialCatalog
            _RESULT = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" & DBFileName & ";Encrypt=False; TrustServerCertificate=False;"
            Return _RESULT
        End Function
    End Class

    Public Class SQLiteConnection
        Implements ISQLite

        Public Function SQLiteBasic(DBFile As String) As String Implements ISQLite.SQLiteBasic
            '_RESULT = "Data Source=" & DBFile & ";Version=3;Mode=ReadWrite;Journal Mode=Off;"
            _RESULT = "Data Source=" & DBFile & ";Version=3;Journal Mode=Persist;Synchronous=Full;Max Page Count=5000;"
            Return _RESULT
        End Function

        Public Function SQLiteOpenWithPassword(DBFile As String, Password As String) As String Implements ISQLite.SQLiteOpenWithPassword
            _RESULT = "Data Source=" & DBFile & ";Password=" & Password & ";"
            Return _RESULT
        End Function
    End Class
End Namespace
