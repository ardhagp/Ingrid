﻿Imports System
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
            Dim _UID As String
            Dim _Exist As Integer
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                _Exist = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

                If _Exist = 0 Then
                    _UID = String.Empty
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_id from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                    _UID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]user] set user_lastlogin = getdate() where user_id = '{0}'", _UID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                End If
            Catch ex As Exception
                _UID = String.Empty
            End Try
            Return _UID
        End Function

        ''' <summary>
        ''' Get Employee ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETEID(ByVal UID As String) As String
            Dim _EID As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_employee from dbo.[[sys]]user] usr where usr.user_id = '{0}';", UID)
                _EID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _EID = String.Empty
            End Try

            Return _EID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETFirstName(ByVal UID As String) As String
            Dim _FullName As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                _FullName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _FullName = String.Empty
            End Try

            Return _FullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETLastName(ByVal UID As String) As String
            Dim _FullName As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                _FullName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _FullName = String.Empty
            End Try

            Return _FullName
        End Function

        ''' <summary>
        ''' Get Company Employee Number ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal UID As String) As String
            Dim _EmployeeNumber As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_number from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                _EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _EmployeeNumber = String.Empty
            End Try

            Return _EmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Gender
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETGender(ByVal UID As String) As String
            Dim _EmployeeNumber As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_gender from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                _EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _EmployeeNumber = "MALE"
            End Try

            Return _EmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Position
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETPosition(ByVal UID As String) As String
            Dim _EmployeeNumber As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select p.position_name from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee " &
                                                        "inner join dbo.[[man]]position] p on p.position_id = emp.employee_position where (usr.[user_id] = '{0}')", UID)
                _EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _EmployeeNumber = "#ERROR"
            End Try

            Return _EmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Authorization
        ''' </summary>
        ''' <param name="AuthType"></param>
        ''' <param name="SysModule"></param>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccess(ByVal AuthType As enuAuthType, ByVal SysModule As String, ByVal UID As Integer) As Boolean
            Dim _IsAuth As Integer

            If AuthType = enuAuthType.Read Then

            ElseIf AuthType = enuAuthType.Write Then

            ElseIf AuthType = enuAuthType.Execute Then

            End If

            V_DBR_MSSQL2008(0).Query = ""
            _IsAuth = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)

            If _IsAuth = 0 Then
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
            Dim _UID As String = UID
            Dim _Photo As System.Drawing.Image = Nothing
            Dim _FileStream As IO.FileStream

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.[[sto]]file] f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", _UID)
                _FileStream = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)

                If _FileStream IsNot Nothing Then
                    _Photo = ImageEditor.Proccessor.Compress.OutputAsImage(_FileStream)
                End If


            Catch ex As Exception
                _Photo = Nothing
            End Try

            Return _Photo

        End Function

        ''' <summary>
        ''' Get Employee Administrator state
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAdministrator(ByVal UID As String) As Boolean
            Dim _IsAdministrator As Boolean

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select u.user_root from dbo.[[sys]]user] u where u.user_id = '{0}'", UID)
                _IsAdministrator = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)
            Catch ex As Exception
                _IsAdministrator = False
            End Try

            Return _IsAdministrator
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
        Public Shared Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                V_DBR_MSSQL2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                        "usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee order by em.employee_fullname")
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                        "usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                        "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", Find.XOSQLText)
            End If
            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TUAC")
        End Sub

        ''' <summary>
        ''' Delete Data From UAC
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[sys]]user] where (user_id = '{0}')", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function
    End Class

    ''' <summary>
    ''' Editor Class
    ''' </summary>
    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal Grid As dgn, Optional ByVal RowID As String = "-1")
            ReDim V_DBR_MSSQL2008(2)

            If RowID = "-1" Then
                V_DBR_MSSQL2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                        "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from dbo.[[sys]]module] mo inner join dbo.[[sys]]modulegroup] mog " &
                                                        "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
            Else
                V_DBR_MSSQL2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
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

            V_DBR_MSSQL2008(2).DataGrid = Grid
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(2), "TUserAccess")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUIDByEmployeeID(ByVal EmployeeID As String) As String
            Dim _UID As Object

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_id from dbo.[[sys]]user] usr where usr.user_employee = '{0}';", EmployeeID)

                _UID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
                IIf(IsDBNull(_UID), "", _UID)

            Catch ex As Exception
                _UID = Nothing
            End Try

            Return _UID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal UserID As String) As String
            Dim _EmployeeNumber As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_number from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            _EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _EmployeeNumber = IIf(IsDBNull(_EmployeeNumber), "", _EmployeeNumber)

            Return _EmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeFullName(ByVal UserID As String) As String
            Dim _EmployeeFullName As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            _EmployeeFullName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _EmployeeFullName = IIf(IsDBNull(_EmployeeFullName), "", _EmployeeFullName)

            Return _EmployeeFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUsernameByUserID(ByVal UserID As String) As String
            Dim _Username As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_username from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            _Username = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _Username = IIf(IsDBNull(_Username), "", _Username)

            Return _Username
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUsernameByEmployeeID(ByVal EmployeeID As String) As String
            Dim _Username As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_username from dbo.[[sys]]user] usr where usr.user_employee = '{0}'", EmployeeID)

            _Username = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _Username = IIf(IsDBNull(_Username), "", _Username)

            Return _Username
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPassword(ByVal UserID As String) As String
            Dim _Password As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_password from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            _Password = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _Password = IIf(IsDBNull(_Password), "", _Password)

            Return _Password
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETLocked(ByVal UserID As String) As Boolean
            Dim _Locked As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            _Locked = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _Locked = IIf(IsDBNull(_Locked), False, _Locked)

            Return _Locked
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETAdministrator(ByVal UserID As String) As Boolean
            Dim _Root As Object

            V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_root from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

            _Root = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            _Root = IIf(IsDBNull(_Root), False, _Root)

            Return _Root
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal Username As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _IsDuplicate As Integer

            If RowID = "-1" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}')", Username)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_id <> '{1}')", Username, RowID)
            End If
            _IsDuplicate = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

            If _IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal EmployeeID As String, ByVal Username As String, ByVal Password As String, ByVal Locked As Boolean, ByVal Administrator As Boolean, ByVal UAC As dgn, Optional ByVal RowID As String = "-1", Optional ByVal Hash As String = "", Optional ByVal IsPasswordChange As Boolean = False) As Boolean
            Dim _Success As Boolean
            ReDim V_DBR_MSSQL2008(4)

            Try
                Dim _EQuery As String = String.Empty
                If RowID = "-1" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]user](user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", Hash, EmployeeID, Username, Password, Locked, Administrator)


                    For Each Row As DataGridViewRow In UAC.Rows
                        _EQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                "values('{0}', '{1}', (select mo.module_id from dbo.[[sys]]module] mo " &
                                                "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), Hash, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                        V_DBR_MSSQL2008(1).Query += _EQuery
                    Next

                Else
                    If (IsPasswordChange) Then
                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]user] set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", Username, Password, Locked, Administrator, RowID)
                    Else
                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]user] set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", Username, Locked, Administrator, RowID)
                    End If

                    Dim _Exist As Integer = 0
                    For Each Row As DataGridViewRow In UAC.Rows
                        V_DBR_MSSQL2008(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.[[sys]]module] mo on mo.module_id = uac.useraccess_module " &
                                                                "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", RowID, Row.Cells("module_code").Value)
                        _Exist = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(3).Query)

                        If _Exist = 0 Then
                            _EQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from dbo.[[sys]]module] mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), RowID, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                        Else
                            _EQuery = String.Format("update dbo.[[sys]]useraccess] set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                    "where useraccess_id = '{4}';", Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_id").Value, Row.Cells("useraccess_reports").Value)
                        End If
                        V_DBR_MSSQL2008(1).Query += _EQuery
                    Next
                End If
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                _Success = True
            Catch ex As Exception
                MsgBox(ex.ToString)
                _Success = False
            End Try

            Return _Success
        End Function
    End Class

End Namespace