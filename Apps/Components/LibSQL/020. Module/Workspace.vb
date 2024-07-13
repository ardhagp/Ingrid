Imports System
Imports System.Runtime.Versioning

Public Class varWorkspace
    <SupportedOSPlatform("windows")>
    Public Shared Function GETModuleName(ByVal TCode As String) As String
        Dim varValue As String

        Try
            varDBreader_mssql2008(1).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_code = '{0}'", TCode)
            varValue = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

        Catch ex As Exception
            varValue = String.Empty
        End Try
        Return varValue
    End Function

    <SupportedOSPlatform("windows")>
    Public Shared Function GETModuleDescription(ByVal TCode As String) As String
        Dim varValue As String

        Try
            varDBreader_mssql2008(1).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_code = '{0}'", TCode)
            varValue = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

        Catch ex As Exception
            varValue = String.Empty
        End Try
        Return varValue
    End Function
End Class
