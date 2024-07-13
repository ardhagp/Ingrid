
Imports System.Runtime.Versioning

Namespace Commands.DBIC
    Public Structure Modules

    End Structure

    ''' <summary>
    ''' DB Integrity Check for Applications
    ''' </summary>
    Public Class Applications
        Public Shared Sub Settings()
            'put your code here
        End Sub

        Public Shared Sub NativeModules()
            'put your code here
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function IsCompanyExist() As Boolean
            Dim varISexist As Integer

            varDBreader_mssql2008(0).Query = String.Format("select count(c.company_id) as [company_count] from dbo.[[man]]company] as c")

            varISexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

            If varISexist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDepartmentExist() As Boolean
            Dim varISexist As Integer

            varDBreader_mssql2008(0).Query = String.Format("select count(d.departement_id) as [department_count] from dbo.[[man]]departement] as d")

            varISexist = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Integer)

            If varISexist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Public Function IsEmployeePositionExist() As Integer
        'TODO: Make Function
        'End Function


    End Class

    ''' <summary>
    ''' DB Integrity Check for EPLS
    ''' </summary>
    Public Class EPLS
        Public Shared Sub Options()
            'put your code here
        End Sub
    End Class
End Namespace
