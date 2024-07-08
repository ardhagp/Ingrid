
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
            Dim V_IsExist As Integer

            V_DBR_MSSQL2008(0).Query = String.Format("select count(c.company_id) as [company_count] from dbo.[[man]]company] as c")

            V_IsExist = Convert.ToInt16(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query))

            If V_IsExist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDepartmentExist() As Boolean
            Dim V_IsExist As Integer

            V_DBR_MSSQL2008(0).Query = String.Format("select count(d.departement_id) as [department_count] from dbo.[[man]]departement] as d")

            V_IsExist = Convert.ToInt16(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query))

            If V_IsExist > 0 Then
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
