Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.DRTM
    Public Class View
        Public varISemployeefilter As Boolean
        Public varIDemployee As String
        Public varIDcontent As String

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayGrid(ByVal Find As txt, ByVal DateGrid As dgn, ByVal ContentStatusBar As stt, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim varWhere As String = String.Format("where ")

                If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                    varWhere += "tpl.template_module = (select mdl.module_id from dbo.[[sys]]module] mdl where mdl.module_code = 'DAR') "
                Else
                    varWhere += "tpl.template_module = (select mdl.module_id from dbo.[[sys]]module] mdl where mdl.module_code = 'DAR') and "

                    Dim varContaintext() As String = Find.XOSQLText.Split("||")
                    Dim varRepeater As Integer = 0

                    varWhere += String.Format("(")

                    For Each varText As String In varContaintext
                        If Not varText = "" Then
                            If varRepeater = 0 Then
                                varWhere += String.Format("tpl.template_text1 like '%{0}%'", varText)
                            Else
                                varWhere += String.Format(" and tpl.template_text1 like '%{0}%'", varText)
                            End If
                        End If
                        varRepeater += 1
                    Next

                    varWhere += String.Format(")")
                End If

                varDBreader_mssql2008(0).Query = String.Format("select tpl.template_id, tpl.template_title, tpl.template_text1 from dbo.[[doc]]template] tpl {0} order by tpl.template_title", varWhere)

                varDBreader_mssql2008(0).DataGrid = DateGrid
                varDBreader_mssql2008(0).StatusBar = ContentStatusBar
                varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TDARTemplate", "db_universe_erp")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor
        'TODO: Build
    End Class
End Namespace
