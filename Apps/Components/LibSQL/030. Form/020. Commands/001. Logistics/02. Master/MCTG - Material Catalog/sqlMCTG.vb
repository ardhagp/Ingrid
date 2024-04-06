﻿Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MCTG
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                V_DBR_MSSQL2008(0).Query = "select m.material_id, m.material_number, m.material_name, m.material_longtext, mg.materialgroup_code, mt.materialtype_code, m.material_isidentifier, m.material_iscarrier from " &
                    "dbo.[[log]]material] m inner join dbo.[[log]]materialgroup] mg on m.material_materialgroup = mg.materialgroup_id inner join dbo.[[log]]materialtype] mt on m.material_materialtype = mt.materialtype_id " &
                    "order by m.material_number;"
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select m.material_id, m.material_number, m.material_name, m.material_longtext, mg.materialgroup_code, mt.materialtype_code, m.material_isidentifier, " &
                                                        "m.material_iscarrier from dbo.[[log]]material] m inner join dbo.[[log]]materialgroup] mg on m.material_materialgroup = mg.materialgroup_id inner join " &
                                                        "dbo.[[log]]materialtype] mt on m.material_materialtype = mt.materialtype_id where (m.material_number = '{0}') or (m.material_name like '%{0}%') or " &
                                                        "(m.material_longtext like '%{0}%') order by m.material_number;", Find.XOSQLText)
            End If
            V_DBR_MSSQL2008(0).DataGrid = Datagrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TMaterialCatalog")
        End Sub
    End Class
End Namespace
