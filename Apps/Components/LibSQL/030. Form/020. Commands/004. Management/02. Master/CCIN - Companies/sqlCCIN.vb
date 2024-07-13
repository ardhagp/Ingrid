Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CCIN
    Public Class View
        'ReadOnly varDBreader_mssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim varWhere As String = "where "

            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format(" (c.company_code ='{0}') or (c.company_name like '%{0}%') or (c.company_searchterm2 like '%{0}%') or (c.company_searchterm1 like '%{0}%') or (c.company_description " &
                                        "like '%{0}%')", Find.XOSQLText)
            End If

            varDBreader_mssql2008(0).Query = String.Format("SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.[[man]]company] c {0} " &
                                                    "ORDER BY C.company_code", varWhere)

            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TCompany", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_mssql2008(0).Query = String.Format("delete from dbo.[[man]]company] where company_id='{0}'", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(0).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal Code As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim varISduplicate As Integer
            Dim varWhere As String = "where "

            If RowID = "-1" Then
                varWhere += String.Format(" c.company_code = '{0}'", Code)
            Else
                varWhere += String.Format(" c.company_code = '{0}' and c.company_id <> '{1}'", Code, RowID)
            End If

            varDBreader_mssql2008(1).Query = String.Format("select count(c.company_id) as [isduplicate] from dbo.[[man]]company] c {0}", varWhere)


            varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(1).Query, "db_universe_erp"), Integer)

            If varISduplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal CompanyCode As String, ByVal CompanyName As String, ByVal SearchTerm1 As String, ByVal SearchTerm2 As String, ByVal Description As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim varSuccess As Boolean

            Try
                If RowID = "-1" Then
                    Dim Hash As String = CMCv.Security.Encrypt.MD5()
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[man]]company](company_id,company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, CompanyCode, CompanyName, SearchTerm1, SearchTerm2, Description)
                Else
                    varDBreader_mssql2008(1).Query = String.Format("update dbo.[[man]]company] set company_code='{0}',company_name='{1}',company_searchterm1='{2}',company_searchterm2='{3}',company_description='{4}' " &
                                                            "where company_id='{5}'", CompanyCode, CompanyName, SearchTerm1, SearchTerm2, Description, RowID)
                End If
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyCode(ByVal RowID As String) As String
            Dim varCode As String
            varDBreader_mssql2008(0).Query = String.Format("select c.company_code from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            varCode = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyName(ByVal RowID As String) As String
            Dim varName As String
            varDBreader_mssql2008(0).Query = String.Format("select c.company_name from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            varName = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETSearchTerm1(ByVal RowID As String) As String
            Dim varSearchterm As String
            varDBreader_mssql2008(0).Query = String.Format("select c.company_searchterm1 from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            varSearchterm = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varSearchterm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETSearchTerm2(ByVal RowID As String) As String
            Dim varSearchterm As String
            varDBreader_mssql2008(0).Query = String.Format("select c.company_searchterm2 from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            varSearchterm = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varSearchterm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDescription(ByVal RowID As String) As String
            Dim varDesciption As String
            varDBreader_mssql2008(0).Query = String.Format("select c.company_description from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            varDesciption = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString
            Return varDesciption
        End Function
    End Class
End Namespace
