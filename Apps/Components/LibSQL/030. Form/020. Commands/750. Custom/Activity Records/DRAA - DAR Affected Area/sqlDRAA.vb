Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.DRAA
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayMainGrid(ByVal Find As txt, ByVal ContentGrid As dgn, ContentStatusBar As stt, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim varWhere As String = String.Format("where ")

                If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                    varWhere += String.Format("(aa.areaaffected_name like '%{0}%')", Find.XOSQLText)
                Else
                    If Find.XOSQLText = String.Empty Then

                    ElseIf Find.XOSQLText.Trim.Contains("||") = False Then
                        varWhere += String.Format("(aa.areaaffected_name like '%{0}%')", Find.XOSQLText)
                    Else
                        Dim _ContainText() As String = Find.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each _Text As String In _ContainText
                            If Not _Text = "" Then
                                If varRepeater = 0 Then
                                    varWhere += String.Format("aa.areaaffected_name like '%{0}%'", _Text)
                                Else
                                    varWhere += String.Format(" and aa.areaaffected_name like '%{0}%'", _Text)
                                End If
                            End If

                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If

                End If

                varDBreader_mssql2008(0).Query = String.Format("select aa.areaaffected_id, aa.areaaffected_order, aa.areaaffected_name from dbo.[[doc]]areaaffected] aa {0} order by aa.areaaffected_order, aa.areaaffected_name", varWhere)

                varDBreader_mssql2008(0).DataGrid = ContentGrid
                varDBreader_mssql2008(0).StatusBar = ContentStatusBar
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TAreaAffected", "db_universe_erp")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor
        'TODO: Build
    End Class
End Namespace
