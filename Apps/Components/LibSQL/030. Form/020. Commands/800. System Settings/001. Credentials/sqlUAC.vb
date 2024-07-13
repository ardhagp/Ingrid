Imports System
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace Commands.UAC

    Public Class Login
        'ReadOnly _IMG As New ImageEditor.Proccessor.Compress

        Public Enum EnuAuthType
            Read = 4
            Write = 2
            Execute = 1
        End Enum

        ''' <summary>
        ''' Get User ID from Employee
        ''' </summary>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETUID(ByVal Username As String, ByVal Password As String, Optional ByVal AdditionalField As Object = Nothing) As String
            Dim varIDuser As String
            Dim varISexist As Integer
            Try
                varDBreader_mssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                varISexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

                If varISexist = 0 Then
                    varIDuser = String.Empty
                Else
                    varDBreader_mssql2008(1).Query = String.Format("select usr.user_id from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                    varIDuser = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

                    varDBreader_mssql2008(1).Query = String.Format("update dbo.[[sys]]user] set user_lastlogin = getdate() where user_id = '{0}'", varIDuser)
                    varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                End If
            Catch ex As Exception
                varIDuser = String.Empty
            End Try
            Return varIDuser
        End Function

        ''' <summary>
        ''' Get Employee ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETEID(ByVal UID As String) As String
            Dim varIDemployee As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select usr.user_employee from dbo.[[sys]]user] usr where usr.user_id = '{0}';", UID)
                varIDemployee = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Catch ex As Exception
                varIDemployee = String.Empty
            End Try

            Return varIDemployee
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETFirstName(ByVal UID As String) As String
            Dim varFullname As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select emp.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                varFullname = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Catch ex As Exception
                varFullname = String.Empty
            End Try

            Return varFullname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETLastName(ByVal UID As String) As String
            Dim varFullname As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select emp.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                varFullname = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Catch ex As Exception
                varFullname = String.Empty
            End Try

            Return varFullname
        End Function

        ''' <summary>
        ''' Get Company Employee Number ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal UID As String) As String
            Dim varEmployeennumber As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select emp.employee_number from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                varEmployeennumber = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Catch ex As Exception
                varEmployeennumber = String.Empty
            End Try

            Return varEmployeennumber
        End Function

        ''' <summary>
        ''' Get Employee Gender
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETGender(ByVal UID As String) As String
            Dim varEmployeennumber As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select emp.employee_gender from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                varEmployeennumber = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Catch ex As Exception
                varEmployeennumber = "MALE"
            End Try

            Return varEmployeennumber
        End Function

        ''' <summary>
        ''' Get Employee Position
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETPosition(ByVal UID As String) As String
            Dim varEmployeennumber As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select p.position_name from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee " &
                                                        "inner join dbo.[[man]]position] p on p.position_id = emp.employee_position where (usr.[user_id] = '{0}')", UID)
                varEmployeennumber = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Catch ex As Exception
                varEmployeennumber = "#ERROR"
            End Try

            Return varEmployeennumber
        End Function

        ''' <summary>
        ''' Get Employee Authorization
        ''' </summary>
        ''' <param name="AuthType"></param>
        ''' <param name="SysModule"></param>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccess(ByVal AuthType As EnuAuthType, ByVal SysModule As String, ByVal UID As Integer) As Boolean
            Dim varISauth As Integer

            If AuthType = EnuAuthType.Read Then
                'TODO: Read method
            ElseIf AuthType = EnuAuthType.Write Then
                'TODO: Write method
            ElseIf AuthType = EnuAuthType.Execute Then
                'TODO: Execute method
            End If

            varDBreader_mssql2008(0).Query = ""
            varISauth = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

            If varISauth = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' Get Employee Photo
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function GETPhoto(ByVal UID As String) As System.Drawing.Image
            Dim varIDuser As String = UID
            Dim varPhoto As System.Drawing.Image = Nothing
            Dim varFilestream As IO.FileStream

            Try
                varDBreader_mssql2008(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.[[sto]]file] f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", varIDuser)
                varFilestream = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), FileStream)

                If varFilestream IsNot Nothing Then
                    varPhoto = ImageEditor.Proccessor.Compress.OutputAsImage(varFilestream)
                End If
            Catch ex As Exception
                varPhoto = Nothing
            End Try

            Return varPhoto

        End Function

        ''' <summary>
        ''' Get Employee Administrator state
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAdministrator(ByVal UID As String) As Boolean
            Dim varISadministrator As Boolean

            Try
                varDBreader_mssql2008(0).Query = String.Format("select u.user_root from dbo.[[sys]]user] u where u.user_id = '{0}'", UID)
                varISadministrator = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Boolean)
            Catch ex As Exception
                varISadministrator = False
            End Try

            Return varISadministrator
        End Function

        Public Shared Function GETUID() As Integer
            Return 1
        End Function
    End Class

    Public Class View

        ''' <summary>
        ''' Display Data from UAC Table
        ''' </summary>
        ''' <param name="DataGrid"></param>
        ''' <param name="StatusBar"></param>
        ''' <param name="Find"></param>
        ''' <param name="ForceRefresh"></param>
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DataGrid As Dgn, ByVal StatusBar As Stt, ByVal Find As Txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                varDBreader_mssql2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                        "usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee order by em.employee_fullname")
            Else
                varDBreader_mssql2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                        "usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                        "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TUAC", "db_universe_erp")
        End Sub

        ''' <summary>
        ''' Delete Data From UAC
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[sys]]user] where (user_id = '{0}')", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    ''' <summary>
    ''' Editor Class
    ''' </summary>
    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal Grid As Dgn, Optional ByVal RowID As String = "-1")
            ReDim varDBreader_mssql2008(2)

            If RowID = "-1" Then
                varDBreader_mssql2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                        "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from dbo.[[sys]]module] mo inner join dbo.[[sys]]modulegroup] mog " &
                                                        "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
            Else
                varDBreader_mssql2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
                                                        "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_view], (select uac1.useraccess_add " &
                                                        "from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                        "mo1.module_code = mo.module_code) as [useraccess_add], (select uac1.useraccess_edit from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
                                                        "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_edit], " &
                                                        "(select uac1.useraccess_delete from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 on mo1.module_id = uac1.useraccess_module " &
                                                        "where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_delete], (select uac1.useraccess_reports from dbo.[[sys]]useraccess] uac1 " &
                                                        "inner join dbo.[[sys]]module] mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                        "mo1.module_code = mo.module_code) as [useraccess_reports], (select uac1.useraccess_id from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
                                                        "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_id], mo.module_id " &
                                                        "from dbo.[[sys]]module] mo inner join dbo.[[sys]]modulegroup] mog on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code", RowID)
            End If

            varDBreader_mssql2008(2).DataGrid = Grid
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(2), "TUserAccess", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUIDByEmployeeID(ByVal EmployeeID As String) As String
            Dim varIDuser As String

            Try
                varDBreader_mssql2008(1).Query = String.Format("select usr.user_id from dbo.[[sys]]user] usr where usr.user_employee = '{0}';", EmployeeID)

                varIDuser = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
                IIf(IsDBNull(varIDuser), "", varIDuser)

            Catch ex As Exception
                varIDuser = Nothing
            End Try

            Return varIDuser
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal UserID As String) As String
            Dim varEmployeennumber As String

            varDBreader_mssql2008(1).Query = String.Format("select em.employee_number from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            varEmployeennumber = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            Return varEmployeennumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeFullName(ByVal UserID As String) As String
            Dim varEmployeefullname As String

            varDBreader_mssql2008(1).Query = String.Format("select em.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            varEmployeefullname = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            Return varEmployeefullname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUsernameByUserID(ByVal UserID As String) As String
            Dim varUsername As String

            varDBreader_mssql2008(1).Query = String.Format("select usr.user_username from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            varUsername = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUsernameByEmployeeID(ByVal EmployeeID As String) As String
            Dim varUsername As String

            varDBreader_mssql2008(1).Query = String.Format("select usr.user_username from dbo.[[sys]]user] usr where usr.user_employee = '{0}'", EmployeeID)

            varUsername = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPassword(ByVal UserID As String) As String
            Dim varPassword As String

            varDBreader_mssql2008(1).Query = String.Format("select usr.user_password from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            varPassword = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            Return varPassword
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETLocked(ByVal UserID As String) As Boolean
            Dim varISlocked As Boolean

            varDBreader_mssql2008(1).Query = String.Format("select usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            varISlocked = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Boolean)

            Return varISlocked
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETAdministrator(ByVal UserID As String) As Boolean
            Dim varISroot As Boolean

            varDBreader_mssql2008(1).Query = String.Format("select usr.user_root from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            varISroot = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Boolean)

            Return varISroot
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal Username As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim varISduplicate As Integer

            If RowID = "-1" Then
                varDBreader_mssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}')", Username)
            Else
                varDBreader_mssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_id <> '{1}')", Username, RowID)
            End If
            varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

            If varISduplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal EmployeeID As String, ByVal Username As String, ByVal Password As String, ByVal Locked As Boolean, ByVal Administrator As Boolean, ByVal UAC As Dgn, Optional ByVal RowID As String = "-1", Optional ByVal Hash As String = "", Optional ByVal IsPasswordChange As Boolean = False) As Boolean
            Dim varSuccess As Boolean
            ReDim varDBreader_mssql2008(4)

            Try
                Dim varEQuery As String = String.Empty
                If RowID = "-1" Then
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[sys]]user](user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", Hash, EmployeeID, Username, Password, Locked, Administrator)


                    For Each Row As DataGridViewRow In UAC.Rows
                        varEQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                "values('{0}', '{1}', (select mo.module_id from dbo.[[sys]]module] mo " &
                                                "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), Hash, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                        varDBreader_mssql2008(1).Query += varEQuery
                    Next

                Else
                    If (IsPasswordChange) Then
                        varDBreader_mssql2008(1).Query = String.Format("update dbo.[[sys]]user] set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", Username, Password, Locked, Administrator, RowID)
                    Else
                        varDBreader_mssql2008(1).Query = String.Format("update dbo.[[sys]]user] set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", Username, Locked, Administrator, RowID)
                    End If

                    Dim varISexist As Integer = 0
                    For Each Row As DataGridViewRow In UAC.Rows
                        varDBreader_mssql2008(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.[[sys]]module] mo on mo.module_id = uac.useraccess_module " &
                                                                "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", RowID, Row.Cells("module_code").Value)
                        varISexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(3).Query, "db_universe_erp"), Integer)

                        If varISexist = 0 Then
                            varEQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from dbo.[[sys]]module] mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), RowID, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                        Else
                            varEQuery = String.Format("update dbo.[[sys]]useraccess] set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                    "where useraccess_id = '{4}';", Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_id").Value, Row.Cells("useraccess_reports").Value)
                        End If
                        varDBreader_mssql2008(1).Query += varEQuery
                    Next
                End If
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varSuccess = True
            Catch ex As Exception
                MsgBox(ex.ToString)
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace
