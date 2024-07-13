Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace Commands.DAR
    Public Class View
        Public varISemployeefilter As Boolean
        Public varIDemployee As String
        Public varIDcontent As String
        Public varContentyear As String

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckSettings(ByVal UID As String, ByVal Attribute As String) As Boolean
            Dim varISexist As Integer
            Dim varAttribute(1) As String

            varAttribute(0) = "ViewPhotoTab"

            For varRow = 0 To 0
                varDBreader_mssql2008(0).Query = String.Format("select count(mods.modulesettings_id) from dbo.[[sys]]modulesettings] mods inner join " &
                                                        "dbo.[[sys]]module] mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') " &
                                                        "and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, varAttribute(varRow))
                varISexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

                If varISexist = 0 Then
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[sys]]modulesettings](modulesettings_id, modulesettings_module," &
                                                            "modulesettings_user, modulesettings_attribute, modulesettings_value) values('{0}', " &
                                                            "(select mo.module_id from dbo.[[sys]]module] mo where mo.module_code = 'DAR'),'{1}','{2}'," &
                                                            "'False')", CMCv.Security.Encrypt.MD5(), UID, varAttribute(varRow))
                    varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                End If
            Next

            Dim varValue As Boolean

            varDBreader_mssql2008(0).Query = String.Format("select mods.modulesettings_value from dbo.[[sys]]modulesettings] mods inner join dbo.[[sys]]module] " &
                                                    "mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') and " &
                                                    "(mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, "ViewPhotoTab")

            varValue = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Boolean)

            Return varValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(ByVal UID As String, ByVal Attribute As String, ByVal Values As String) As Boolean
            Dim varISsuccess As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("update dbo.[[sys]]modulesettings] set modulesettings_value = '{0}' where (modulesettings_module = " &
                                                        "(select mo.module_id from dbo.[[sys]]module] mo where mo.module_code = 'DAR')) and " &
                                                        "(modulesettings_user = '{1}') and (modulesettings_attribute = '{2}')", Values, UID, Attribute)

                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varISsuccess = True
            Catch ex As Exception
                varISsuccess = False
            End Try

            Return varISsuccess

        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillEmployee(ByVal Employee As Cbo)
            varDBreader_mssql2008(1).Query = String.Format("select em.employee_id, em.employee_fullname from dbo.[[man]]employee] em where em.employee_id in " &
                                                    "(select ea.employeeactivity_employee from dbo.[[doc]]employeeactivity] ea group by " &
                                                    "ea.employeeactivity_employee) order by em.employee_fullname;")
            varDBreader_mssql2008(1).Dropdown = Employee
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TEmployee", "db_universe_erp")
            Employee.DisplayMember = "employee_fullname"
            Employee.ValueMember = "employee_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub DisplayMainGrid(ByVal Find As Txt, ByVal DateGrid As Dgn, ByVal DateStatusBar As Stt, ContentStatusBar As Stt, ByVal chkDateFilter As Chk, ByVal dtpDateFilter As Dtp, ByVal chkByFilter As Chk, ByVal cboByFilter As Cbo, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim varWhere As String = String.Format("where ")

                If cboByFilter.Items.Count = 0 Then
                    varIDemployee = "-1"
                Else
                    varIDemployee = cboByFilter.SelectedValue().ToString
                End If

                If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh) Then
                    If Not (chkDateFilter.Checked) Then
                        varWhere += String.Format("(year(ea.employeeactivity_datetime) = year(getdate())) And (month(ea.employeeactivity_datetime) = " &
                                                "month(getdate()))")
                    Else
                        varWhere += String.Format("(year(ea.employeeactivity_datetime) = {0} And month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                    End If

                    If (chkByFilter.Checked) Then
                        varWhere += String.Format(" And (ea.employeeactivity_employee = '{0}')", varIDemployee)
                    End If
                Else
                    If Not (Find.XOSQLText.Trim.Contains("||")) Then
                        varWhere += String.Format("(ea.employeeactivity_description like '%{0}%')", Find.XOSQLText)
                    Else
                        Dim varContaintext As String() = Find.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each _Text As String In varContaintext
                            If (_Text <> "") Then
                                If varRepeater = 0 Then
                                    varWhere += String.Format("ea.employeeactivity_description like '%{0}%'", _Text)
                                Else
                                    varWhere += String.Format(" and ea.employeeactivity_description like '%{0}%'", _Text)
                                End If
                            End If

                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If

                    If (chkDateFilter.Checked) Then
                        varWhere += String.Format(" and (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                    End If

                    If (chkByFilter.Checked) Then
                        varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}')", varIDemployee)
                    End If
                End If

                varDBreader_mssql2008(0).Query = String.Format("select ea.employeeactivity_datetime, (convert(varchar,ea.employeeactivity_datetime,106) + '' + " &
                                                        "char(13) + char(10) + '' + left(datename(dw,ea.employeeactivity_datetime),3)) as [employeeactivity_longdate] " &
                                                        "from dbo.[[doc]]employeeactivity] ea {0} group by ea.employeeactivity_datetime " &
                                                        "order by ea.employeeactivity_datetime desc", varWhere)

                varDBreader_mssql2008(0).DataGrid = DateGrid
                varDBreader_mssql2008(0).StatusBar = DateStatusBar
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TDailyReportsDate", "db_universe_erp")

                varISemployeefilter = chkByFilter.Checked

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub DisplaySecondGrid(ByVal DateGrid As String, ByVal ContentGrid As Dgn, ByVal ContentStatusBar As Stt, ByVal Find As Txt, Optional ByVal ShowAttachment As Boolean = False, Optional ByVal PhotoGrid As Dgn = Nothing, Optional ByVal FileGrid As Dgn = Nothing)
            Try
                ReDim varDBreader_mssql2008(3)
                Dim varContentdate_s As String 'To store date as string
                Dim varWhere As String = "where "

                varContentdate_s = DateGrid

                'If DateGrid.Rows.Count = 0 Then
                '    'contentdate = Now.AddYears(2)
                '    varContentdate_s = "9999-12-31"
                'Else
                '    _CONTENTDATE = DateGrid.CurrentRow.Cells("employeeactivity_datetime").Value
                '    varContentdate_s = _CONTENTDATE.Year & "-" & _CONTENTDATE.Month & "-" & _CONTENTDATE.Day
                'End If

                'add date query-cut
                varWhere += String.Format(" (ea.employeeactivity_datetime = '{0}')", varContentdate_s)

                'add text query-cut
                If (Find.XOSQLText <> String.Empty) Then
                    varWhere += String.Format(" and ")

                    'multiple keywords execution
                    If Not (Find.XOSQLText.Trim.Contains("||")) Then
                        varWhere += String.Format("(ea.employeeactivity_description like '%{0}%') ", Find.XOSQLText)
                    Else
                        Dim varContaintext As String() = Find.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each _Text As String In varContaintext
                            If _Text <> "" Then

                                _Text.Trim()

                                If varRepeater = 0 Then
                                    varWhere += String.Format("ea.employeeactivity_description like '%{0}%'", _Text)
                                Else
                                    varWhere += String.Format(" and ea.employeeactivity_description like '%{0}%'", _Text)
                                End If
                            End If

                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If
                End If

                'add employee filter query-cut
                If (varISemployeefilter) Then
                    varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}') ", varIDemployee)
                End If

                Dim varTimeformat(2) As String

                'same day with different time
                varTimeformat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                               "as [employeeactivity_time]")

                'same day with time range format & different day format
                varTimeformat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
                                               "(ea.employeeactivity_time_end = ea.employeeactivity_time)) then (cast(ea.employeeactivity_datetime " &
                                               "as varchar(10))) + char(13) + char(10) + cast(ea.employeeactivity_time as varchar(8)) when " &
                                               "((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
                                               "(ea.employeeactivity_time_end > ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                               "when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + (cast(ea.employeeactivity_time as varchar(8))) " &
                                               "+ char(13) + char(10) + ' to ' + char(13) + char(10) + (cast(ea.employeeactivity_datetime_end as varchar(10))) " &
                                               "+ ' ' + cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                Dim varDescription As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') " &
                    "then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) " &
                "+ '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                varDBreader_mssql2008(2).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and " &
                                                        "(ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                        "(convert(varchar(max), e.employee_nickname) + ' / ' + convert(varchar(max), " &
                                                        "(select em.employee_nickname from dbo.[[man]]employee] em where " &
                                                        "em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as [employee_nickname], " &
                                                        "e.employee_id, ea.employeeactivity_id from dbo.[[doc]]employeeactivity] ea " &
                                                        "inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                        "inner join dbo.[[man]]employee] e on ea.employeeactivity_employee = e.employee_id {0} order by " &
                                                        "aa.areaaffected_order, ea.employeeactivity_time", varWhere, varTimeformat(2), varDescription)

                varDBreader_mssql2008(2).DataGrid = ContentGrid
                varDBreader_mssql2008(2).StatusBar = ContentStatusBar
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(2), "TDailyActivity", "db_universe_erp")

                If varDBreader_mssql2008(2).DataGrid Is Nothing Then
                    varDBreader_mssql2008(2).DataGrid = ContentGrid
                    varDBreader_mssql2008(2).StatusBar = ContentStatusBar
                End If

                If (PhotoGrid Is Nothing) AndAlso (FileGrid Is Nothing) Then
                    Return
                End If

                If (ShowAttachment) Then
                    If varDBreader_mssql2008(2).DataGrid.RowCount = 0 Then
                        varIDcontent = "-1"
                    Else
                        varIDcontent = varDBreader_mssql2008(2).DataGrid.CurrentRow.Cells("employeeactivity_id").Value.ToString
                    End If
                    Call DisplayPhotoGrid(varIDcontent, PhotoGrid)
                    Call DisplayFileGrid(varIDcontent, FileGrid)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayPhotoGrid(ByVal ContentID As String, ByVal FileGrid As Dgn, Optional ByVal RecordYear As String = "")
            ReDim varDBreader_mssql2008(5)
            Dim varIDcontent As String = ContentID

            varDBreader_mssql2008(4).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, (convert(varchar(25),fi.file_content_size) + ' KB') " &
                                                    "as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], " &
                                                    "fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' " &
                                                    "and fi.file_filetype = 'jpg') order by fi.file_score desc, fi.file_datetime;", varIDcontent)
            varDBreader_mssql2008(4).DataGrid = FileGrid
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(4), "TPhotoFile", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayFileGrid(ByVal ContentID As String, ByVal FileGrid As Dgn, Optional ByVal RecordYear As String = "")
            ReDim varDBreader_mssql2008(6)
            Dim varIDcontent As String = ContentID

            varDBreader_mssql2008(5).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, '' as [file_content], " &
                                                    "(convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], " &
                                                    "(convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, " &
                                                    "fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", varIDcontent)
            varDBreader_mssql2008(5).DataGrid = FileGrid
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(5), "TFile", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPDFFile(ByVal RowID As String, Optional ByVal RecordYear As String = "") As Object
            Dim varFile As Object

            varDBreader_mssql2008(1).Query = String.Format("select fi.file_content from db_universe_erp_file.dbo.[[sto]]file] fi where fi.file_id = '{0}'", RowID)

            varFile = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp")

            Return varFile
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete " &
                                                        "from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsLike(ByVal FileID As String, EID As String) As Boolean
            Dim varResult As Integer
            Try
                varDBreader_mssql2008(1).Query = String.Format("select count(ff.filefeedback_id) as [islike] from db_universe_erp_file.dbo.[[sto]]filefeedback] ff " &
                                                        "where ff.filefeedback_file = '{0}' and ff.filefeedback_employee = '{1}';", FileID, EID)
                varResult = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

            Catch ex As Exception
                varResult = 0
            End Try

            If varResult = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function LikePhoto(ByVal FileID As String, ByVal EID As String, ByVal FileOwner As String) As Boolean
            Dim varSuccess As Boolean

            Try
                varDBreader_mssql2008(1).Query = String.Format("insert into db_universe_erp_file.dbo.[[sto]]filefeedback](filefeedback_datetime, filefeedback_file, " &
                                                        "filefeedback_employee, filefeedback_type, filefeedback_value, filefeedback_text) values(GETDATE(), " &
                                                        "'{0}', '{1}', 'Like', 1, 'N/A'); insert into dbo.[[sys]]notification](notification_datetime, " &
                                                        "notification_employee, notification_message, notification_isread) values(GETDATE(), '{2}', " &
                                                        "(select em.employee_fullname from dbo.[[man]]employee] em where em.employee_id = '{1}') " &
                                                        "+ ' like one of your photo.', 0);update db_universe_erp_file.dbo.[[sto]]file] " &
                                                        "set file_score = (select count(ff.filefeedback_value) " &
                                                        "from db_universe_erp_file.dbo.[[sto]]filefeedback] ff where (ff.filefeedback_file = '{0}') and " &
                                                        "(ff.filefeedback_type = 'Like')) where (file_id = '{0}');", FileID, EID, FileOwner)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

    Public Class Editor
        Private _DS As DataSet

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETAffectedArea(ByVal ListOfAffectedArea As CMCv.Cbo)
            varDBreader_mssql2008(1).Query = "select aa.areaaffected_id, aa.areaaffected_name from dbo.[[doc]]areaaffected] aa order by aa.areaaffected_order"
            varDBreader_mssql2008(1).Dropdown = ListOfAffectedArea
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TAffectedArea", "db_universe_erp")
            ListOfAffectedArea.DisplayMember = "areaaffected_name"
            ListOfAffectedArea.ValueMember = "areaaffected_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETTemplateTitle(ByVal ListOfTemplate As CMCv.Cbo)

            varDBreader_mssql2008(1).Query = "select tp.template_id, tp.template_title from dbo.[[doc]]template] tp inner join dbo.[[sys]]module] mo on " &
                "mo.module_id = tp.template_module where mo.module_code = 'DAR' order by tp.template_title"
            varDBreader_mssql2008(1).Dropdown = ListOfTemplate
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TTemplate", "db_universe_erp")
            ListOfTemplate.DisplayMember = "template_title"
            ListOfTemplate.ValueMember = "template_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETTemplateContent(ByVal ListOfTemplate As CMCv.Cbo) As String
            varDBreader_mssql2008(1).Query = String.Format("select tp.template_text1 from dbo.[[doc]]template] tp where tp.template_id = '{0}'", ListOfTemplate.SelectedValue)
            Return varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETRowValue(ByVal RowID As String, ByVal DatePart As CMCv.Dtp, ByVal TimePart As CMCv.Meb, ByVal DatePartEnd As CMCv.Dtp, ByVal TimePartEnd As CMCv.Meb, ByVal ListOfAffectedArea As Cbo, ByVal ListOfTemplate As Cbo, ByVal TemplateContent As CMCv.Txt, ByVal FeedBack As CMCv.Txt)
            Dim varDatepart(3) As String
            Dim varTimeparts(1) As TimeSpan
            Dim varTimepart(3) As String

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            varDatepart(0) = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_time from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)

            varTimeparts(0) = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), TimeSpan)
            varDatepart(2) = Convert.ToString(varTimeparts(0))
            varTimepart = varDatepart(2).Split(":")
            varDatepart(1) = varTimepart(0) & ":" & varTimepart(1)

            DatePart.Value = CType(varDatepart(0), Date)
            TimePart.Text = varDatepart(1)

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_datetime_end from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            varDatepart(0) = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_time_end from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            varTimeparts(0) = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), TimeSpan)

            varDatepart(2) = Convert.ToString(varTimeparts(0))
            varTimepart = varDatepart(2).Split(":")
            varDatepart(1) = varTimepart(0) & ":" & varTimepart(1)

            DatePartEnd.Value = CType(varDatepart(0), Date)
            TimePartEnd.Text = varDatepart(1)

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_areaaffected from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            ListOfAffectedArea.SelectedValue = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp")

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_template from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            ListOfTemplate.SelectedValue = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp")

            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_description from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            TemplateContent.Text = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString

            Dim varFeedback As Object
            varDBreader_mssql2008(1).Query = String.Format("select ea.employeeactivity_feedback from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
            varFeedback = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp")
            FeedBack.Text = IIf(IsDBNull(varFeedback), "", varFeedback).ToString
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function DisplayPhotoGrid(ByVal RowID As String, ByVal FileGrid As Dgn) As DataSet
            _DS = New DataSet
            'ReDim varDBreader_mssql2008(3)
            varDBreader_mssql2008(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'jpg') order by fi.file_datetime;", RowID)

            _DS = varDBengine_mssql2008.GETDATASET(varDBreader_mssql2008(2), "TPhotoFileEditor", "db_universe_erp")

            Return _DS
        End Function

        <SupportedOSPlatform("windows")>
        Public Function DisplayFileGrid(ByVal RowID As String, ByVal FileGrid As Dgn) As DataSet
            _DS = New DataSet
            'ReDim varDBreader_mssql2008(3)
            varDBreader_mssql2008(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", RowID)

            _DS = varDBengine_mssql2008.GETDATASET(varDBreader_mssql2008(2), "TFileEditor", "db_universe_erp")

            Return _DS
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal AreaAffected As String, ByVal ActivityTemplate As String, ByVal DatePart As String, ByVal TimePart As String, ByVal DatePartEnd As String, ByVal TimePartEnd As String, ByVal Content As String, ByVal Feedback As String, ByVal UserID As String, ByVal RowID As String, ByVal IsNew As Boolean, Optional ExtendedQuery As String = "") As Boolean
            Dim varSuccess As Boolean

            Try
                If (IsNew) Then
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[doc]]employeeactivity](employeeactivity_id, employeeactivity_areaaffected, " &
                                                            "employeeactivity_template, employeeactivity_datetime, employeeactivity_time, " &
                                                            "employeeactivity_datetime_end, employeeactivity_time_end, employeeactivity_description, " &
                                                            "employeeactivity_employee,employeeactivity_feedback,employeeactivity_createon) values " &
                                                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',(select usr.user_employee " &
                                                            "from dbo.[[sys]]user] usr where usr.user_id = '{8}'),'{9}', " &
                                                            "(select getdate()));", RowID, AreaAffected, ActivityTemplate, DatePart, TimePart, DatePartEnd, TimePartEnd, Content, UserID, Feedback)
                Else
                    varDBreader_mssql2008(1).Query = String.Format("update dbo.[[doc]]employeeactivity] set employeeactivity_datetime = '{0}', " &
                                                            "employeeactivity_time = '{1}', employeeactivity_datetime_end = '{2}', " &
                                                            "employeeactivity_time_end = '{3}', employeeactivity_areaaffected = '{4}', " &
                                                            "employeeactivity_template = '{5}', employeeactivity_description = '{6}', " &
                                                            "employeeactivity_lastupdate = (select usr.user_employee from dbo.[[sys]]user] usr " &
                                                            "where usr.user_id = '{7}'), employeeactivity_feedback = '{9}', " &
                                                            "employeeactivity_updateon = (select getdate()) where employeeactivity_id = '{8}';", DatePart, TimePart, DatePartEnd, TimePartEnd, AreaAffected, ActivityTemplate, Content, UserID, RowID, Feedback)

                    varDBreader_mssql2008(1).Query += String.Format("update db_universe_erp_file.dbo.[[sto]]file] set file_parentdate = '{0}' " &
                                                             "where file_parent = '{1}';", DatePart, RowID)
                End If

                If ExtendedQuery IsNot String.Empty Then
                    varDBreader_mssql2008(1).Query += ExtendedQuery
                End If

                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHPhoto(ByVal FileGrid As Dgn, ByVal RowID As String, ByVal IsNew As Boolean, ByVal ParentDate As Date) As Boolean
            Dim varSuccess As Boolean = False
            Dim varComand As SqlClient.SqlCommand

            Try
                For Each Row As DataGridViewRow In FileGrid.Rows
                    If Row.Cells("photo_status").Value Is "Add" Then

                        Dim varQuery As String = String.Empty

                        varComand = New SqlClient.SqlCommand
                        varQuery = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, @FileName, 'jpg', @FileContent, '', @DateNow, " &
                            "'module=DAR;', @Uploader,@ParentDate);"

                        varComand.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY " &
                                                         "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 " &
                                                         "BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", varQuery)

                        With varComand
                            .Parameters.AddWithValue("@ID", Row.Cells("photo_id").Value)
                            .Parameters.AddWithValue("@ParentID", RowID)
                            .Parameters.AddWithValue("@FileName", Row.Cells("photo_filename").Value)
                            .Parameters.AddWithValue("@Uploader", Row.Cells("photo_uploader").Value)
                            .Parameters.AddWithValue("@ParentDate", ParentDate)
                        End With

                        Dim varMemorystream = New MemoryStream()
                        Dim varImage As Image = CType(Row.Cells("photo_content").Value, Image)
                        Dim varPhotobyte As Byte() = Nothing

                        varImage.Save(varMemorystream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                        varPhotobyte = varMemorystream.ToArray

                        Dim varImageparameter As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                        varImageparameter.Value = varPhotobyte

                        With varComand
                            .Parameters.Add(varImageparameter)
                            .Parameters.AddWithValue("@DateNow", Row.Cells("photo_datetime").Value)
                        End With

                        varSuccess = varDBengine_mssql2008.PUSHIMAGE(varComand)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHFile(ByVal FileGrid As Dgn, ByVal RowID As String, ByVal IsNew As Boolean, ByVal ParentDate As Date) As Boolean
            Dim varSuccess As Boolean = False
            Dim varComand As SqlClient.SqlCommand

            Try
                For Each Row As DataGridViewRow In FileGrid.Rows
                    If Row.Cells("file_status").Value Is "Add" Then

                        Dim varQuery As String = String.Empty

                        varComand = New SqlClient.SqlCommand
                        varQuery = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader,file_parentdate) values(@ID, @ParentID, @FileName, 'pdf', @FileContent, @Tag, @DateNow, " &
                            "'module=DAR;', @Uploader, @ParentDate);"

                        varComand.CommandText = "RETRY: BEGIN TRANSACTION BEGIN TRY " & varQuery & " COMMIT TRANSACTION END TRY " &
                            "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH"

                        With varComand
                            .Parameters.AddWithValue("@ID", Row.Cells("file_id").Value)
                            .Parameters.AddWithValue("@ParentID", RowID)
                            .Parameters.AddWithValue("@FileName", Row.Cells("file_filename").Value)
                            .Parameters.AddWithValue("@Uploader", Row.Cells("file_uploader").Value)
                            .Parameters.AddWithValue("@Tag", Row.Cells("file_tag").Value)
                            .Parameters.AddWithValue("@ParentDate", ParentDate)
                        End With

                        Dim varFilestream As FileStream = Nothing
                        varFilestream = New FileStream(Row.Cells("file_content").Value.ToString, FileMode.Open, FileAccess.Read)

                        Dim varMemorystream = New MemoryStream()
                        varFilestream.CopyTo(varMemorystream)

                        Dim varFilebyte As Byte() = Nothing
                        varFilebyte = varMemorystream.ToArray

                        Dim varFileparameter As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                        varFileparameter.Value = varFilebyte

                        With varComand
                            .Parameters.Add(varFileparameter)
                            .Parameters.AddWithValue("@DateNow", Row.Cells("file_datetime").Value)
                        End With

                        varSuccess = varDBengine_mssql2008.PUSHIMAGE(varComand)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
                varSuccess = False
            End Try

            Return varSuccess
        End Function

    End Class

    Public Class Reports
        Public Shared Sub DISPLAY(ByVal ChkFrom As Chk, ByVal ChkTo As Chk, ByVal ChkArea As Chk, ByVal ChkActivity As Chk, ByVal ChkBy As Chk, ByVal DTPFrom As Dtp, ByVal DTPTo As Dtp, ByVal CboArea As Cbo, ByVal CboActivity As Cbo, ByVal CboBy As Cbo, ByVal TxtDescription As Txt, ByVal DataSetName As DataSet)

            Dim varWhere As String
            Dim varDPfrom As String = DTPFrom.Value.Year & "-" & DTPFrom.Value.Month & "-" & DTPFrom.Value.Day
            Dim varDPto As String = DTPTo.Value.Year & "-" & DTPTo.Value.Month & "-" & DTPTo.Value.Day

            Try
                varWhere = "Where "

                If (ChkFrom.Checked) Then
                    If (ChkTo.Checked) Then
                        varWhere += String.Format("(ea.employeeactivity_datetime >= '{0}' and ea.employeeactivity_datetime <= '{1}')", varDPfrom, varDPto)
                    Else
                        varWhere += String.Format("(ea.employeeactivity_datetime = '{0}')", varDPfrom)
                    End If
                End If

                If (ChkArea.Checked) Then
                    If varWhere = "Where " Then
                        varWhere += String.Format("(aa.areaaffected_id = '{0}')", CboArea.SelectedValue)
                    Else
                        varWhere += String.Format(" and (aa.areaaffected_id = '{0}')", CboArea.SelectedValue)
                    End If
                End If

                If (ChkActivity.Checked) Then
                    If varWhere = "Where " Then
                        varWhere += String.Format("(ea.employeeactivity_template = '{0}')", CboActivity.SelectedValue)
                    Else
                        varWhere += String.Format(" and (ea.employeeactivity_template = '{0}')", CboActivity.SelectedValue)
                    End If
                End If

                If (ChkBy.Checked) Then
                    If varWhere = "Where " Then
                        varWhere += String.Format("(ea.employeeactivity_employee = '{0}')", CboBy.SelectedValue)
                    Else
                        varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}')", CboBy.SelectedValue)
                    End If
                End If

                If TxtDescription.XOSQLText.Trim <> String.Empty Then

                    If varWhere <> "Where " Then
                        varWhere += String.Format(" and ")
                    End If

                    'multiple keywords execution
                    If Not (TxtDescription.XOSQLText.Trim.Contains("||")) Then
                        varWhere += String.Format("(ea.employeeactivity_description like '%{0}%') ", TxtDescription.XOSQLText)
                    Else
                        Dim varContaintext As String() = TxtDescription.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each _Text As String In varContaintext
                            If _Text <> "" Then

                                _Text.Trim()

                                If varRepeater = 0 Then
                                    varWhere += String.Format("ea.employeeactivity_description like '%{0}%'", _Text)
                                Else
                                    varWhere += String.Format(" and ea.employeeactivity_description like '%{0}%'", _Text)
                                End If
                            End If

                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If
                End If

                If varWhere = "Where " Then
                    varWhere = String.Empty
                End If

                DataSetName.Clear()

                Dim varTimeformat(2) As String

                'same day with different time
                varTimeformat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8))) as [employeeactivity_time]")

                'same day with time range format & different day format
                varTimeformat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
                                               "(ea.employeeactivity_time_end = ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) " &
                                               "+ cast(ea.employeeactivity_time as varchar(8)) when " &
                                               "((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
                                               "(ea.employeeactivity_time_end > ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                               "when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + " &
                                               "(cast(ea.employeeactivity_time as varchar(8))) + char(13) + char(10) + ' to ' + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_datetime_end as varchar(10))) + ' ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                Dim varDescription As String = "case when (ea.employeeactivity_feedback is null) or " &
                    "(convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else " &
                    "convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' " &
                    "+ char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                varDBreader_mssql2008(0).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) " &
                                                        "and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                        "(convert(varchar(max),e.employee_nickname) + ' / ' + " &
                                                        "convert(varchar(max),(select em.employee_nickname from dbo.[[man]]employee] em " &
                                                        "where em.employee_id = ea.employeeactivity_lastupdate))) else " &
                                                        "e.employee_nickname end as [employee_nickname], aa.areaaffected_order " &
                                                        "from dbo.[[doc]]employeeactivity] ea " &
                                                        "inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                        "inner join dbo.[[man]]employee] e on ea.employeeactivity_employee = e.employee_id {0} " &
                                                        "order by aa.areaaffected_order", varWhere, varTimeformat(2), varDescription)

                DataSetName = varDBengine_mssql2008.FILLDATASET(varDBreader_mssql2008(0).Query, DataSetName, "employeeactivity", "db_universe_erp")

            Catch ex As Exception
                DataSetName = Nothing
            End Try
        End Sub
    End Class
End Namespace
