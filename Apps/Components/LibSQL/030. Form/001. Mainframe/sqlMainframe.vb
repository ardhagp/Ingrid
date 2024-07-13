Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Mainframe
    Public Class Database
        <SupportedOSPlatform("windows")>
        Public Shared Function Connect(Optional ByVal IsProduction As Boolean = False, Optional ByVal SplashScreen As Form = Nothing) As Boolean
            Dim varSuccess As Boolean
            Try

                varDBengine_sqlite.Open(IsProduction)
                varDBproperties(1) = varDBengine_sqlite.GetDatabaseProperties(varDBproperties(1))

                If (varDBengine_mssql2008.Open(varDBproperties(1), SplashScreen)) Then
                    varSuccess = True
                Else
                    'If SplashScreen IsNot Nothing Then
                    '    SplashScreen.Close()
                    'End If
                    SplashScreen?.Close()
                    varSuccess = False
                End If
                varDBengine_sqlite.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                SplashScreen?.Close()
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class
End Namespace
