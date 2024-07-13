Imports System.Runtime.Versioning

Namespace Commands.CONN
    <SupportedOSPlatform("windows")>
    Public Class View

        Public Shared Sub DisplayData(ByVal Datagrid As CMCv.dgn, ByVal StatusBar As CMCv.stt, ByVal Find As CMCv.txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                varDBreader_sqlite(0).Query = "select serverlist.ID, serverlist.CONNECTIONNAME, serverlist.DATABASEENGINE, serverlist.SERVERADDRESS, serverlist.SERVERPORT, serverlist.DEFAULTCONNECTION from serverlist ORDER BY serverlist.CONNECTIONNAME;"
            Else
                varDBreader_sqlite(0).Query = String.Format("select serverlist.ID, serverlist.CONNECTIONNAME, serverlist.DATABASEENGINE, serverlist.SERVERADDRESS, serverlist.SERVERPORT, serverlist.DEFAULTCONNECTION from serverlist where (serverlist.CONNECTIONNAME like '%{0}%') or (serverlist.SERVERADDRESS like '%{0}%') or (serverlist.SERVERPORT like '%{0}%') ORDER BY serverlist.CONNECTIONNAME;", Find.XOSQLText)
            End If
            varDBreader_sqlite(0).DataGrid = Datagrid
            varDBreader_sqlite(0).StatusBar = StatusBar
            varDBengine_sqlite.GETDATATABLE(varDBreader_sqlite(0), "TDBList")
        End Sub

        Public Shared Function DELETEData(ByVal RowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDBreader_sqlite(1).Query = String.Format("DELETE FROM serverlist WHERE ID = '{0}';", RowID)
                varDBengine_sqlite.PUSHDATA(varDBreader_sqlite(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub GETRowValue(ByVal RowID As String, ByVal ConnectionName As CMCv.txt, ByVal DBEngine As CMCv.cbo, ByVal Address As CMCv.txt, ByVal Port As CMCv.txt, ByVal Username As CMCv.txt, ByVal Password As CMCv.txt, ByVal OldPassword As String, ByVal DataStorage As CMCv.txt, ByVal FileStorage As CMCv.txt, ByVal IsDefault As CMCv.chk)
            varDBreader_sqlite(1).Query = String.Format("select serverlist.CONNECTIONNAME from serverlist where serverlist.ID ='{0}'", RowID)
            ConnectionName.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.DATABASEENGINE from serverlist where serverlist.ID ='{0}'", RowID)
            DBEngine.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.SERVERADDRESS from serverlist where serverlist.ID ='{0}'", RowID)
            Address.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.SERVERPORT from serverlist where serverlist.ID ='{0}'", RowID)
            Port.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.USERNAME from serverlist where serverlist.ID ='{0}'", RowID)
            Username.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.PASSWORD from serverlist where serverlist.ID ='{0}'", RowID)
            Password.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString
            OldPassword = Password.Text

            varDBreader_sqlite(1).Query = String.Format("select serverlist.DBFORDATA from serverlist where serverlist.ID ='{0}'", RowID)
            DataStorage.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.DBFORFILE from serverlist serverlist where serverlist.ID ='{0}'", RowID)
            FileStorage.Text = varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query).ToString

            varDBreader_sqlite(1).Query = String.Format("select serverlist.DEFAULTCONNECTION from serverlist where serverlist.ID ='{0}'", RowID)
            IsDefault.Checked = CType(varDBengine_sqlite.GETVALUE(varDBreader_sqlite(1).Query), Boolean)
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal ConnectionName As String, ByVal DBEngine As String, ByVal Address As String, ByVal Port As String, ByVal Username As String, ByVal Password As String, ByVal DataStorage As String, ByVal FileStorage As String, ByVal IsDefault As Boolean, ByVal RowID As String, ByVal IsNew As Boolean, ByVal IsPasswordChange As Boolean) As Boolean
            Dim varSuccess As Boolean
            Dim varIsdefaultactivate As String = ""

            Try
                If (IsDefault) Then 'to check if isdefault is set
                    varIsdefaultactivate = "update serverlist set DEFAULTCONNECTION=0;"
                End If

                If (IsNew) Then
                    varDBreader_sqlite(1).Query = varIsdefaultactivate & $"insert into serverlist(ID, CONNECTIONNAME, DATABASEENGINE, SERVERADDRESS, SERVERPORT, USERNAME, PASSWORD, DBFORDATA, DBFORFILE, DEFAULTCONNECTION) values ('{RowID}','{ConnectionName}','{Address}',{Port},'{Username}','{Security.Encrypt.AES(Password)}','{DataStorage}','{FileStorage}',{IsDefault})"
                Else
                    If Not (IsPasswordChange) Then
                        varDBreader_sqlite(1).Query = varIsdefaultactivate & String.Format("update serverlist set CONNECTIONNAME='{1}', SERVERADDRESS='{2}', SERVERPORT={3}, USERNAME='{4}', DEFAULTCONNECTION={5}, DBFORDATA='{6}', DBFORFILE='{7}', DATABASEENGINE='{8}' where ID='{0}'", RowID, ConnectionName, Address, Port, Username, IsDefault, DataStorage, FileStorage, DBEngine)
                    Else
                        varDBreader_sqlite(1).Query = varIsdefaultactivate & String.Format("update serverlist set CONNECTIONNAME='{1}', SERVERADDRESS='{2}', SERVERPORT={3}, USERNAME='{4}', PASSWORD='{5}', DEFAULTCONNECTION={6}, DBFORDATA='{7}', DBFORFILE='{8}', DATABASEENGINE='{9}' where ID='{0}'", RowID, ConnectionName, Address, Port, Username, Security.Encrypt.AES(Password), IsDefault, DataStorage, FileStorage, DBEngine)
                    End If
                End If

                varDBengine_sqlite.PUSHDATA(varDBreader_sqlite(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace


