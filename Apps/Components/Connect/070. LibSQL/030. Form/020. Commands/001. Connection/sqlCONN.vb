Namespace Commands.CONN
    Public Class View

        Public Sub DisplayData(ByVal Datagrid As CMCv.dgn, ByVal StatusBar As CMCv.stt, ByVal Find As CMCv.txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.SLFSQLText = String.Empty) OrElse (ForceRefresh) Then
                v_DBR_SQLITE(0).Query = "select serverlist.ID, serverlist.CONNECTIONNAME, serverlist.SERVERADDRESS, serverlist.SERVERPORT, serverlist.DEFAULTCONNECTION from serverlist ORDER BY serverlist.CONNECTIONNAME;"
            Else
                v_DBR_SQLITE(0).Query = String.Format("select serverlist.ID, serverlist.CONNECTIONNAME, serverlist.SERVERADDRESS, serverlist.SERVERPORT, serverlist.DEFAULTCONNECTION from serverlist where (serverlist.CONNECTIONNAME like '%{0}%') or (serverlist.SERVERADDRESS like '%{0}%') or (serverlist.SERVERPORT like '%{0}%') ORDER BY serverlist.CONNECTIONNAME;", Find.SLFSQLText)
            End If
            v_DBR_SQLITE(0).DataGrid = Datagrid
            v_DBR_SQLITE(0).StatusBar = StatusBar
            v_DBE_SQLite.GETDATATABLE(v_DBR_SQLITE(0), "TDBList")
        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                v_DBR_SQLITE(1).Query = String.Format("DELETE FROM serverlist WHERE ID = '{0}';", RowID)
                v_DBE_SQLite.PUSHDATA(v_DBR_SQLITE(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function
    End Class

    Public Class Editor

        Public Sub GETRowValue(ByVal RowID As String, ByVal ConnectionName As CMCv.txt, ByVal Address As CMCv.txt, ByVal Port As CMCv.txt, ByVal Username As CMCv.txt, ByVal Password As CMCv.txt, ByVal OldPassword As String, ByVal DataStorage As CMCv.txt, ByVal FileStorage As CMCv.txt, ByVal IsDefault As CMCv.chk)
            v_DBR_SQLITE(1).Query = String.Format("select serverlist.CONNECTIONNAME from serverlist where serverlist.ID ='{0}'", RowID)
            ConnectionName.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.SERVERADDRESS from serverlist where serverlist.ID ='{0}'", RowID)
            Address.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.SERVERPORT from serverlist where serverlist.ID ='{0}'", RowID)
            Port.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.USERNAME from serverlist where serverlist.ID ='{0}'", RowID)
            Username.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.PASSWORD from serverlist where serverlist.ID ='{0}'", RowID)
            Password.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)
            OldPassword = Password.Text

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.DBFORDATA from serverlist where serverlist.ID ='{0}'", RowID)
            DataStorage.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.DBFORFILE from serverlist serverlist where serverlist.ID ='{0}'", RowID)
            FileStorage.Text = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)

            v_DBR_SQLITE(1).Query = String.Format("select serverlist.DEFAULTCONNECTION from serverlist where serverlist.ID ='{0}'", RowID)
            IsDefault.Checked = v_DBE_SQLite.GETVALUE(v_DBR_SQLITE(1).Query)
        End Sub

        Public Function PUSHData(ByVal ConnectionName As String, ByVal Address As String, ByVal Port As String, ByVal Username As String, ByVal Password As String, ByVal DataStorage As String, ByVal FileStorage As String, ByVal IsDefault As Boolean, ByVal RowID As String, ByVal IsNew As Boolean, ByVal IsPasswordChange As Boolean)
            Dim _Success As Boolean = False
            Dim _IsDefaultActivate As String = String.Empty

            Try
                If (IsDefault) Then 'to check if isdefault is set
                    _IsDefaultActivate = "update serverlist set DEFAULTCONNECTION=0;"
                End If

                If (IsNew) Then
                    v_DBR_SQLITE(1).Query = _IsDefaultActivate & String.Format("insert into serverlist(ID, CONNECTIONNAME, SERVERADDRESS, SERVERPORT, USERNAME, PASSWORD, DBFORDATA, DBFORFILE, DEFAULTCONNECTION) values ('{0}','{1}','{2}',{3},'{4}','{5}','{7}','{8}',{6})", RowID, ConnectionName, Address, Port, Username, v_SECEncrypt.Rijndael(Password), IsDefault, DataStorage, FileStorage)
                Else
                    If Not (IsPasswordChange) Then
                        v_DBR_SQLITE(1).Query = _IsDefaultActivate & String.Format("update serverlist set CONNECTIONNAME='{1}', SERVERADDRESS='{2}', SERVERPORT={3}, USERNAME='{4}', DEFAULTCONNECTION={5}, DBFORDATA='{6}', DBFORFILE='{7}' where ID='{0}'", RowID, ConnectionName, Address, Port, Username, IsDefault, DataStorage, FileStorage)
                    Else
                        v_DBR_SQLITE(1).Query = _IsDefaultActivate & String.Format("update serverlist set CONNECTIONNAME='{1}', SERVERADDRESS='{2}', SERVERPORT={3}, USERNAME='{4}', PASSWORD='{5}', DEFAULTCONNECTION={6}, DBFORDATA='{7}', DBFORFILE='{8}' where ID='{0}'", RowID, ConnectionName, Address, Port, Username, v_SECEncrypt.Rijndael(Password), IsDefault, DataStorage, FileStorage)
                    End If
                End If

                v_DBE_SQLite.PUSHDATA(v_DBR_SQLITE(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class

End Namespace


