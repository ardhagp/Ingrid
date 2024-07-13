﻿Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.UAC.Addins.Browse
    Public Class Employee
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal Grid As dgn, ByVal Status As CMCv.stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            ReDim varDBreader_mssql2008(2)

            If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                varDBreader_mssql2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, em.employee_number, em.employee_fullname from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (em.employee_active = 1) and (em.employee_id not in (select usr.user_employee from dbo.[[sys]]user] usr))  order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname")
            Else
                varDBreader_mssql2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, em.employee_number, em.employee_fullname from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (em.employee_active = 1) and (em.employee_id not in (select usr.user_employee from dbo.[[sys]]user] usr)) and (cm.company_code like '%{0}%' or dp.departement_code like '%{0}%' or ps.position_code like '%{0}%' or em.employee_number = '{0}' or em.employee_fullname like '%{0}%') order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = Grid
            varDBreader_mssql2008(0).StatusBar = Status
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TEmployee", "db_universe_erp")
        End Sub
    End Class
End Namespace

