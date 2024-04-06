Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Mainframe
    Public Class Database
        <SupportedOSPlatform("windows")>
        Public Shared Function Connect(Optional ByVal IsProduction As Boolean = False, Optional ByVal SplashScreen As Form = Nothing) As Boolean
            Dim V_Success As Boolean
            Try
                'Using MS Access Connection Properties
                '_DBE_MSACCESS2003.Open(IsProduction)
                '_DB_Properties(1) = _DBE_MSACCESS2003.GetDatabaseProperties(_DB_Properties(1))

                'Try Using LocalDB Connection Properties

                '_DBE_LocalDB.Open(IsProduction)
                '_DB_Properties(1) = _DBE_LocalDB.GetDatabaseProperties(_DB_Properties(1))


                V_DBE_SQLite.Open(IsProduction)
                V_DB_Properties(1) = V_DBE_SQLite.GetDatabaseProperties(V_DB_Properties(1))

                If (V_DBE_MSSQL2008.Open(V_DB_Properties(1), SplashScreen)) Then
                    V_Success = True
                Else
                    'If SplashScreen IsNot Nothing Then
                    '    SplashScreen.Close()
                    'End If
                    SplashScreen?.Close()
                    V_Success = False
                End If
                V_DBE_SQLite.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                'If SplashScreen IsNot Nothing Then
                '    SplashScreen.Close()
                'End If
                SplashScreen?.Close()
                V_Success = False
            End Try
            Return V_Success
        End Function
    End Class
End Namespace
