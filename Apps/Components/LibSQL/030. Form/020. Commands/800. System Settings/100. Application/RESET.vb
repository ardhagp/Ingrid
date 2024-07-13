Imports System
Imports System.Runtime.Versioning
Imports CMCv
Imports FxResources

Namespace Commands.RESET

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData() As Boolean
            Dim varSuccess As Boolean

            Try
                varDBreader_mssql2008(1).Query = String.Format("update [db_universe_erp].[dbo].[[sys]]settings] set [settings_showprofile] = 0, " &
                                                        "[settings_showstorage] = 0, [settings_showwatermark] = 0, [settings_showrunningtext] = 0, " &
                                                        "[settings_uploadphoto] = 30, [settings_uploadpdf] = 30, [settings_textmark] = '', " &
                                                        "[settings_minpasswordlength] = 3")
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varSuccess = True
                Return varSuccess
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

End Namespace