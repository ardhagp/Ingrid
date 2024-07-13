Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.ACGR
    Public Class View
#Region "Variables"
        'ReadOnly varDBreader_mssql2008(3) As Database.Adapter.MSSQL2008.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLCompany(ByVal Company As cbo)
            varDBreader_mssql2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.[[man]]company] cm order by cm.company_code")
            varDBreader_mssql2008(1).Dropdown = Company
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TCompany", "db_universe_erp")
            Company.DisplayMember = "company_name"
            Company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLAccountingBook(ByVal AccountingBook As cbo, ByVal Company As cbo)
            Dim varCompanyid As String = String.Empty

            If Not Company.Items.Count = 0 Then
                varCompanyid = Company.SelectedValue.ToString
            End If

            varDBreader_mssql2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.[[ac]]book] ab inner join dbo.[[man]]company] cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyid)
            varDBreader_mssql2008(1).Dropdown = AccountingBook
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TAccountingBook", "db_universe_erp")
            AccountingBook.DisplayMember = "book_bookname"
            AccountingBook.ValueMember = "book_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data nama akun dari database
        ''' </summary>
        ''' <param name="Assets">Datagrid untuk menampilkan akun Asset / Harta</param>
        ''' <param name="Liability">Datagrid untuk menampilkan akun Liability / Hutang</param>
        ''' <param name="Equity">Datagrid untuk menampilkan akun Equity / Modal</param>
        ''' <param name="Revenue">Datagrid untuk menampilkan akun Revenue / Pendapatan</param>
        ''' <param name="Expense">Datagrid untuk menampilkan akun Expense / Pengeluaran</param>
        ''' <param name="AccountingBook">ComboBox yang berisi Buku Akuntansi</param>
        ''' <param name="Find">TextBox Pencarian</param>
        ''' <param name="ForceRefresh">True / False</param>
        ''' <remarks>ForceRefresh = True akan menampilkan semua data tanpa filter</remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub GETAccountList(ByVal Assets As Dgn, ByVal Liability As Dgn, ByVal Equity As Dgn, ByVal Revenue As Dgn, ByVal Expense As Dgn, ByVal AccountingBook As Cbo, ByVal Find As Txt, Optional ForceRefresh As Boolean = False)
            Dim varCB_index As String
            'Isikan index combobox dengan data dari mainframe
            varCB_index = AccountingBook.SelectedValue.ToString

            'Tampilkan data awal / tanpa filter / ForceRefresh=True
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", varCB_index)
                varDBreader_mssql2008(0).DataGrid = Assets
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TAssets", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", varCB_index)
                varDBreader_mssql2008(0).DataGrid = Liability
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TLiability", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", varCB_index)
                varDBreader_mssql2008(0).DataGrid = Equity
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TEquity", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", varCB_index)
                varDBreader_mssql2008(0).DataGrid = Revenue
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TRevenue", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", varCB_index)
                varDBreader_mssql2008(0).DataGrid = Expense
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TExpense", "db_universe_erp")
            Else 'Tampilkan data berdasarkan filter
                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", varCB_index, Find.XOSQLText)
                varDBreader_mssql2008(0).DataGrid = Assets
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TAssets", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", varCB_index, Find.XOSQLText)
                varDBreader_mssql2008(0).DataGrid = Liability
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TLiability", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", varCB_index, Find.XOSQLText)
                varDBreader_mssql2008(0).DataGrid = Equity
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TEquity", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", varCB_index, Find.XOSQLText)
                varDBreader_mssql2008(0).DataGrid = Revenue
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TRevenue", "db_universe_erp")

                varDBreader_mssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", varCB_index, Find.XOSQLText)
                varDBreader_mssql2008(0).DataGrid = Expense
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TExpense", "db_universe_erp")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[ac]]account] where account_id = '{0}'", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

    End Class

    Public Class Editor
#Region "Variables"
        'ReadOnly varDBreader_mssql2008(3) As Database.Adapter.MSSQL2008.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLCompany(ByVal Company As Cbo)
            varDBreader_mssql2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.[[man]]company] cm order by cm.company_code")
            varDBreader_mssql2008(1).Dropdown = Company
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TCompany", "db_universe_erp")
            Company.DisplayMember = "company_name"
            Company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLAccountingBook(ByVal AccountingBook As Cbo, ByVal Company As Cbo)
            Dim varCompanyid As String = String.Empty
            If Not Company.Items.Count = 0 Then
                varCompanyid = Company.SelectedValue.ToString
            End If

            varDBreader_mssql2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.[[ac]]book] ab inner join dbo.[[man]]company] cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyid)
            varDBreader_mssql2008(1).Dropdown = AccountingBook
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TAccountingBook", "db_universe_erp")
            AccountingBook.DisplayMember = "book_bookname"
            AccountingBook.ValueMember = "book_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountGroup"></param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLAccountGroup(ByVal AccountGroup As Cbo)
            varDBreader_mssql2008(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from dbo.[[ac]]group] ag order by ag.group_order"
            varDBreader_mssql2008(1).Dropdown = AccountGroup
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(1), "TAccountingBook", "db_universe_erp")
            AccountGroup.DisplayMember = "group_name"
            AccountGroup.ValueMember = "group_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyID(ByVal RowID As String) As String
            Dim varCompanyid As String
            varDBreader_mssql2008(1).Query = String.Format("select ab.book_company from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            varCompanyid = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Return varCompanyid
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountBookID(ByVal RowID As String) As String
            Dim varAccountbookid As String
            varDBreader_mssql2008(1).Query = String.Format("select ab.book_id from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            varAccountbookid = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Return varAccountbookid
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountGroupID(ByVal RowID As String) As String
            Dim varAccountgroupid As String
            varDBreader_mssql2008(1).Query = String.Format("select ac.account_group from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            varAccountgroupid = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Return varAccountgroupid
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountNumber(ByVal RowID As String) As String
            Dim varAccountnumber As String
            varDBreader_mssql2008(1).Query = String.Format("select ac.account_num from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            varAccountnumber = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Return varAccountnumber
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountName(ByVal RowID As String) As String
            Dim varAccountnumber As String
            varDBreader_mssql2008(1).Query = String.Format("select ac.account_name from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            varAccountnumber = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp").ToString
            Return varAccountnumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEnableTransaction(ByVal RowID As String) As Boolean
            Dim varEnabletransaction As Boolean
            varDBreader_mssql2008(1).Query = String.Format("select ac.account_enable from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            varEnabletransaction = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Boolean)
            Return varEnabletransaction
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal AccountBookID As String, ByVal AccountGroupID As String, ByVal AccountNumber As String, Optional RowID As String = "-1") As Boolean
            Dim varISduplicate As Integer
            Dim varWhere As String = "where "

            If RowID = "-1" Then
                varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", AccountBookID, AccountNumber)
            Else
                varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", AccountBookID, AccountNumber, RowID)
            End If

            varDBreader_mssql2008(1).Query = String.Format("select count(ac.account_id) as [rows] from dbo.[[ac]]account] ac {0}", varWhere)

            varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

            If varISduplicate > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal AccountBookID As String, ByVal AccountGroupID As String, ByVal AccountNumber As String, ByVal AccountName As String, ByVal AccountEnable As Boolean, Optional ByVal RowID As String = "-1") As Boolean
            Dim varSuccess As Boolean
            Try
                If RowID = "-1" Then
                    Dim Hash As String = CMCv.Security.Encrypt.MD5()
                    varDBreader_mssql2008(0).Query = String.Format("insert into dbo.[[ac]]account](account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, AccountBookID, AccountGroupID, AccountNumber, AccountName, AccountEnable)
                Else
                    varDBreader_mssql2008(0).Query = String.Format("update dbo.[[ac]]account] set account_num = '{0}', account_name = '{1}', account_enable = '{2}' where account_id = '{3}'", AccountNumber, AccountName, AccountEnable, RowID)
                End If
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(0).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

    End Class
End Namespace
