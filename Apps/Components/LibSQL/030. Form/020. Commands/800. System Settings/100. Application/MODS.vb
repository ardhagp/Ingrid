﻿Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MODS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) Or (ForceRefresh = True) Then
                V_DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup order by modg.modulegroup_order, mods.module_code")
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup where (mods.module_code = '{0}') or (mods.module_name like '%{0}%') order by modg.modulegroup_order, mods.module_code", Find.XOSQLText)
            End If
            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TMODS")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[sys]]module] where module_id = '{0}'", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal Code As String, Optional ByVal RowID As String = "") As Boolean
            Dim _IsDuplicate As Boolean

            Try
                If RowID = String.Empty Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'", Code.ToUpper)
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'", Code.ToUpper, RowID.ToUpper)
                End If

                _IsDuplicate = Convert.ToBoolean(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query))

                Return _IsDuplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLModuleGroup(ByVal ModuleGroup As cbo)
            V_DBR_MSSQL2008(1).Query = "select modg.modulegroup_id, modg.modulegroup_name from dbo.[[sys]]modulegroup] modg order by modg.modulegroup_order"
            V_DBR_MSSQL2008(1).Dropdown = ModuleGroup
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TModuleGroup")
            ModuleGroup.ValueMember = "modulegroup_id"
            ModuleGroup.DisplayMember = "modulegroup_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODCode(ByVal RowID As String) As String
            Dim _Code As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_code from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _Code = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString

            Return _Code
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODName(ByVal RowID As String) As String
            Dim _Name As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _Name = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString

            Return _Name
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODGroupID(ByVal RowID As String) As String
            Dim _GroupID As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_modulegroup from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _GroupID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString

            Return _GroupID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODDescription(ByVal RowID As String) As String
            Dim _Description As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _Description = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString

            Return _Description
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODSystem(ByVal RowID As String) As Boolean
            Dim _IsSystem As Boolean

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_issystem from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                _IsSystem = Convert.ToBoolean(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query))

                Return _IsSystem
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODLocked(ByVal RowID As String) As Boolean
            Dim _IsLocked As Boolean

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_ismaintenance from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                _IsLocked = Convert.ToBoolean(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query))

                Return _IsLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal ID As String, ByVal GroupID As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, ByVal IsSystem As Boolean, ByVal IsLocked As Boolean, Optional ByVal RowID As String = "") As Boolean
            Dim _Success As Boolean

            Try
                If RowID = "-1" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]module](module_id, module_modulegroup, module_code, module_name, module_description, module_issystem, module_ismaintenance) " &
                                                            "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", ID, GroupID, Code, Name, Description, IsSystem, IsLocked)
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]module] set module_modulegroup = '{0}', module_name = '{1}', module_description = '{2}', module_issystem = '{3}', module_ismaintenance = '{4}' " &
                                                            "where module_id = '{5}'", GroupID, Name, Description, IsSystem, IsLocked, RowID)
                End If

                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                _Success = True
                Return _Success
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
