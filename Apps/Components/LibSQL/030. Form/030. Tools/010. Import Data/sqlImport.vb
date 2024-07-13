Imports System
Imports System.IO
Imports System.Runtime.Versioning
Imports CMCv

Namespace Tools.Import.SharedFunction
    Class Calculate
        Private varRowcount As Integer

        <SupportedOSPlatform("windows")>
        Public Function TotalRows(ByVal Query As String, ByVal Keyword As String) As Integer
            varRowcount = CType(varDBengine_mssql2008.GETVALUE(Query.Replace("%n", Keyword), "db_universe_erp"), Integer)
            Return varRowcount
        End Function
    End Class
End Namespace

Namespace Tools.Import.MaterialMaster
    Public Class Catalog
        ReadOnly varCalculate As New Tools.Import.SharedFunction.Calculate

        <SupportedOSPlatform("windows")>
        Public Function Execute(ByVal DisplayLogs As Txt, ByVal FileLocation As String, Optional ByVal HeaderExist As Boolean = True) As Boolean
            Dim varISsuccess As Boolean = True
            Dim varCSVvalue As String()
            Dim varCSVrow As Integer

            Dim varSearch As String = "SELECT COUNT(m.material_id) FROM dbo.[[log]]material] m WHERE m.material_id = '%n'"

            If File.Exists(FileLocation) = True Then
                DisplayLogs.AppendText("Done." & Environment.NewLine)

                Dim varCSVparser As New Microsoft.VisualBasic.FileIO.TextFieldParser(FileLocation) With {
                .TextFieldType = FileIO.FieldType.Delimited,
                .Delimiters = New String() {";"}
                }

                'varDBadapter_mssql2008.Query = "INSERT INTO dbo.material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) VALUES "
                varCSVrow = 1
                While Not varCSVparser.EndOfData
                    varCSVvalue = varCSVparser.ReadFields
                    If HeaderExist = True Then
                        If varCSVrow = 1 Then
                            DisplayLogs.AppendText("Skip Header Row.." & Environment.NewLine)
                        ElseIf varCSVrow > 1 Then
                            'first row
                            DisplayLogs.AppendText("Processing Line : " & varCSVrow & ". ")
                            If varCSVrow = 2 Then
                                If varCalculate.TotalRows(varSearch, varCSVvalue(1)) = 0 Then
                                    varDBadapter_mssql2008.Query += "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                        "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                    DisplayLogs.AppendText("NEW." & Environment.NewLine)
                                Else
                                    varDBadapter_mssql2008.Query += "UPDATE dbo.[[log]]material] SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                        "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                    DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                                End If
                            Else
                                If varCalculate.TotalRows(varSearch, varCSVvalue(1)) = 0 Then
                                    varDBadapter_mssql2008.Query += vbCrLf & "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                        "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                    DisplayLogs.AppendText("NEW." & Environment.NewLine)
                                Else
                                    varDBadapter_mssql2008.Query += vbCrLf & "UPDATE dbo.[[log]]material] SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                        "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                    DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                                End If
                            End If
                        End If
                    Else
                        If varCSVrow = 1 Then
                            If varCalculate.TotalRows(varSearch, varCSVvalue(1)) = 0 Then
                                varDBadapter_mssql2008.Query += "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                    "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                DisplayLogs.AppendText("NEW." & Environment.NewLine)
                            Else
                                varDBadapter_mssql2008.Query += "UPDATE dbo.[[log]]material] SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                    "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                            End If
                        Else
                            If varCalculate.TotalRows(varSearch, varCSVvalue(1)) = 0 Then
                                varDBadapter_mssql2008.Query += vbCrLf & "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                    "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                DisplayLogs.AppendText("NEW." & Environment.NewLine)
                            Else
                                varDBadapter_mssql2008.Query += vbCrLf & "UPDATE dbo.[[log]]material] SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                    "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                            End If
                        End If
                    End If
                    varCSVrow += 1
                End While
                Try
                    varDBengine_mssql2008.PUSHDATA(varDBadapter_mssql2008.Query, "db_universe_erp")
                Catch ex As Exception
                    varISsuccess = False
                End Try
            Else
                varISsuccess = False
                DisplayLogs.AppendText("Failed." & Environment.NewLine)
                DisplayLogs.AppendText("Your file is missing." & Environment.NewLine)
            End If

            Return varISsuccess
        End Function
    End Class
End Namespace

