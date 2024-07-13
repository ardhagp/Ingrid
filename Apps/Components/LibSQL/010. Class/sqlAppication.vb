Imports System.Data
Imports System.Runtime.Versioning
Imports CMCv

Namespace Application

    Public Class Access
        Public Enum TypeOfAccess
            View = 1
            Add = 2
            Edit = 3
            Delete = 4
            Report = 5
        End Enum

        'Private ReadOnly varlocalDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function User(ByVal TCode As String, ByVal UID As String, ByVal TypeOfAccess As TypeOfAccess) As Boolean
            Dim varView As Integer
            Dim varTypeOfAccess As String = String.Empty

            Select Case TypeOfAccess
                Case Access.TypeOfAccess.View
                    varTypeOfAccess = "uac.useraccess_view"
                Case Access.TypeOfAccess.Add
                    varTypeOfAccess = "uac.useraccess_add"
                Case Access.TypeOfAccess.Edit
                    varTypeOfAccess = "uac.useraccess_edit"
                Case Access.TypeOfAccess.Delete
                    varTypeOfAccess = "uac.useraccess_delete"
                Case Access.TypeOfAccess.Report
                    varTypeOfAccess = "uac.useraccess_reports"
            End Select

            Try
                Dim varIsroot As Integer = 0
                varDBreader_mssql2008(1).Query = String.Format("select count(usr.user_id) from dbo.[[sys]]user] usr where (usr.user_id = '{0}') and (usr.user_root = 1)", UID)

                varIsroot = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

                If varIsroot = 1 Then
                    Return True
                Else
                    varDBreader_mssql2008(1).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.[[sys]]module] mo on mo.module_id = uac.useraccess_module where (mo.module_code = '{0}') and (uac.useraccess_user = '{1}') and ({2} = 1)", TCode, UID, varTypeOfAccess)
                    varView = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

                    If varView = 0 Then
                        Return False
                    Else
                        Return True
                    End If
                End If
            Catch ex As Exception
                Return False
            End Try

        End Function
    End Class

    Public Class Modules
        Private varDatatset As DataSet

        <SupportedOSPlatform("windows")>
        Public Shared Function Exist(ByVal TCODE As String) As Boolean
            Dim varIsexist As Boolean

            Try
                varDBreader_mssql2008(1).Query = String.Format("select count(mo.module_id) from dbo.[[sys]]module] mo where mo.module_code = '{0}'", TCODE)
                varIsexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Boolean)

                Return varIsexist
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Locked(ByVal TCODE As String) As Boolean
            Dim varIslocked As Boolean

            Try
                varDBreader_mssql2008(1).Query = String.Format("select count(mo.module_id) from dbo.[[sys]]module] mo where mo.module_code = '{0}' and mo.module_ismaintenance = 'true'", TCODE)
                varIslocked = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Boolean)

                Return varIslocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function DisplayAutoComplete() As DataSet
            Try
                varDatatset = New DataSet

                varDBreader_mssql2008(2).Query = "select mods.module_code from dbo.[[sys]]module] mods where mods.module_issystem = 0 order by mods.module_code"

                varDatatset = varDBengine_mssql2008.GETDATASET(varDBreader_mssql2008(2), "TCMD", "db_universe_erp")

                Return varDatatset
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxPDFAllowed() As Double
            Dim varSettingvalue As Double

            Try
                varDBreader_mssql2008(0).Query = String.Format("select top 1 s.settings_uploadpdf from db_universe_erp.dbo.[[sys]]settings] s")

                varSettingvalue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Double)
            Catch ex As Exception
                varSettingvalue = 0.9
            End Try

            Return varSettingvalue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxPhotoAllowed() As Double
            Dim varSettingvalue As Double

            Try
                varDBreader_mssql2008(0).Query = String.Format("select top 1 s.settings_uploadphoto from db_universe_erp.dbo.[[sys]]settings] s")

                varSettingvalue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Double)
            Catch ex As Exception
                varSettingvalue = 0.9
            End Try

            Return varSettingvalue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MinPasswordLength() As Integer
            Dim varMinpasswordlength As Integer

            Try
                varDBreader_mssql2008(0).Query = String.Format("select top 1 s.settings_minpasswordlength from db_universe_erp.dbo.[[sys]]settings] s")

                varMinpasswordlength = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)
            Catch ex As Exception
                varMinpasswordlength = 8
            End Try

            Return varMinpasswordlength
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function TextMark(ByVal IsAdministrator As Boolean) As String
            Dim varValue As Integer
            Dim varSettingvalue As String

            Try
                varDBreader_mssql2008(0).Query = String.Format("select s.settings_showwatermark from dbo.[[sys]]settings] s where s.settings_id = 1")
                varValue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

                varDBreader_mssql2008(0).Query = String.Format("select top 1 s.settings_textmark from db_universe_erp.dbo.[[sys]]settings] s")

                If (varValue = 1 AndAlso (IsAdministrator)) OrElse (varValue = 2 AndAlso Not (IsAdministrator)) OrElse (varValue = 3) Then
                    varSettingvalue = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
                Else
                    varSettingvalue = String.Empty
                End If
            Catch ex As Exception
                varSettingvalue = String.Empty
            End Try

            Return varSettingvalue
        End Function
    End Class

    Public Class Notification
        'Private ReadOnly varlocalDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function Exist(ByVal EmployeeID As String) As Integer
            Dim varIsexist As Integer

            Try
                varDBreader_mssql2008(0).Query = String.Format("select count(nt.notification_id) as [new_notification] from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') and (nt.notification_isread = 0)", EmployeeID)
                varIsexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

                Return varIsexist
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class RunningText
        Private ReadOnly varDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function Show(Optional ByVal IsAdministrator As Boolean = False) As Boolean
            Dim varValue As Integer

            Try
                varDBreader_mssql2008(0).Query = String.Format("select s.settings_showrunningtext from dbo.[[sys]]settings] s where s.settings_id = 1")
                varValue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

                If varValue = 1 AndAlso (IsAdministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (IsAdministrator)) Then
                    Return True
                ElseIf varValue = 3 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    Public Class StorageSense

        <SupportedOSPlatform("windows")>
        Public Shared Function Show(Optional ByVal IsAdmininstrator As Boolean = False) As Boolean
            Dim varValue As Integer

            Try
                varDBreader_mssql2008(0).Query = String.Format("select top 1 s.settings_showstorage from dbo.[[sys]]settings] s")
                varValue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

                If varValue = 1 AndAlso (IsAdmininstrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (IsAdmininstrator)) Then
                    Return True
                ElseIf varValue = 3 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DataCurrentSize() As Double
            Dim varSize As Double

            Try
                varDBreader_mssql2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp'")
                varSize = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Double)

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function FileCurrentSize() As Double
            Dim varSize As Double

            Try
                varDBreader_mssql2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp_file'")
                varSize = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp_file"), Double)

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Enum DBSizeType
            MaxSize = 1
            FreeSpace = 2
        End Enum

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxSize(ByVal SizeType As DBSizeType, Optional ByVal DBName As String = "") As Double
            Dim varSize As Double
            If DBName = String.Empty Then
                DBName = "db_universe_erp"
            End If

            Try
                'Line 1 For Production
                If SizeType = 1 Then
                    varDBreader_mssql2008(0).Query = String.Format("SELECT max_db_size_in_gb = CASE WHEN engine_edition = 4 THEN CASE WHEN d.sversion_name LIKE '%203%' THEN (10 * 1024)  WHEN d.sversion_name LIKE '%202%' THEN (10 * 1024)  WHEN d.sversion_name LIKE '%201%' THEN (10 * 1024) WHEN d.sversion_name LIKE '%2008 R2%' THEN (10 * 1024) WHEN d.sversion_name LIKE '%2008%' THEN (4 * 1024) WHEN d.sversion_name LIKE '%2005%' THEN (4 * 1024) END ELSE '0' END FROM (SELECT sversion_name = v.ver, engine_edition = SERVERPROPERTY('EngineEdition'), edition = SERVERPROPERTY('Edition'), server_name = SERVERPROPERTY('ServerName') FROM (SELECT ver = @@VERSION) v) d")
                    varSize = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, DBName), Double)
                Else
                    varDBreader_mssql2008(0).Query = "select sv.var_value from [dbo].[[sys]]variables] sv where sv.var_name = 'drive_free_space'"
                    varSize = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, DBName), Double)
                End If


                'Line 2 For testing bypass purpose
                '_Size = "0"
                'Please refer to actual remaining disk space. code : https://stackoverflow.com/questions/2243121/determine-available-disk-size-with-a-sql-query

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class ProfilePanel
        'ReadOnly varlocalDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request
        ReadOnly varImage As New CMCv.ImageEditor.Proccessor.Compress

        <SupportedOSPlatform("windows")>
        Public Function GETPhoto(ByVal EmployeeID As String, ByVal Gender As String) As System.Drawing.Image
            Dim varPhoto As System.Drawing.Image
            Dim varBytes As Byte()

            Try
                varDBreader_mssql2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.[[sto]]file] f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", EmployeeID)
                varBytes = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp_file"), Byte())

                If Not IsNothing(varBytes) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(varBytes)
                Else
                    If (Gender = "MALE") OrElse (Gender = "") Then
                        varPhoto = My.Resources.MALE_001_512_icon

                    Else
                        varPhoto = My.Resources.FEMALE_001_512_icon
                    End If
                End If

                Return varPhoto
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Show(Optional ByVal IsAdministrator As Boolean = False) As Boolean
            Dim varValue As Integer

            Try
                varDBreader_mssql2008(0).Query = String.Format("select top 1 s.settings_showprofile from dbo.[[sys]]settings] s")
                varValue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

                If varValue = 1 AndAlso (IsAdministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (IsAdministrator)) Then
                    Return True
                ElseIf varValue = 3 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Welcome() As String
            Dim V_Welcome As String

            Try
                varDBreader_mssql2008(0).Query = String.Format("select top 1 t.template_text1 from dbo.[[doc]]template] t where t.template_module = 'F2887E94E365C068D1CCB3FF03DB7969' and t.template_title = 'PROFILE' order by newid()")
                V_Welcome = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

                Return V_Welcome
            Catch ex As Exception
                Return "Welcome,"
            End Try
        End Function

    End Class
End Namespace

