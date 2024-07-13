Imports System.Runtime.Versioning

Public Class ACGR

#Region "Variables"
    Private varSQLview As New LibSQL.Commands.ACGR.View
    Private varSelectedgroup As String = ""
    Private varISfirstload As Boolean = True
    Private varISclosing As Boolean = False
    Private WithEvents frmACGReditor As New ACGR_Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Isikan data buku akuntansi ke CBO
    ''' </summary>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        LibSQL.Commands.ACGR.View.FILLCompany(CboCompany)
        LibSQL.Commands.ACGR.View.FILLAccountingBook(CboAccountingBook, CboCompany)
    End Sub

    ''' <summary>
    ''' Isikan data nama-nama akun ke dalam datagrid sesuai pilihan buku akuntasi pada CBO
    ''' </summary>
    ''' <param name="ForceRefresh">True / False</param>
    ''' <remarks>True akan memaksa data untuk direfresh tanpa filter apapun</remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATAGRID(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.ACGR.View.GETAccountList(DgnACGRAssets, DgnACGRLiabities, DgnACGREquity, DgnACGRRevenue, DgnACGRExpense, CboAccountingBook, TxtFind, ForceRefresh)
    End Sub

    'Private _RowID As Integer

    ''' <summary>
    ''' Prosedur untuk mendapatkan Akun ID
    ''' </summary>
    ''' <param name="GridTable"></param>
    ''' <remarks></remarks>
    Private Function GetAccountID(ByVal GridTable As CMCv.Dgn) As String
        With GridTable
            If .Rows.Count < 1 Then
                varFORMAttribute.RowID = "-1"
            Else
                varFORMAttribute.RowID = .CurrentRow.Cells(0).Value.ToString
            End If
            Return varFORMAttribute.RowID
        End With
    End Function

    ''' <summary>
    ''' Prosedur untuk mendapatkan Tabel ID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetTableID()
        Select Case varSelectedgroup
            Case "tpAssets"
                GetAccountID(DgnACGRAssets)
                SLFStatus.Items(0).Text = DgnACGRAssets.RowCount & " Row(s)"
            Case "tpLiabilities"
                GetAccountID(DgnACGRLiabities)
                SLFStatus.Items(0).Text = DgnACGRLiabities.RowCount & " Row(s)"
            Case "tpEquity"
                GetAccountID(DgnACGREquity)
                SLFStatus.Items(0).Text = DgnACGREquity.RowCount & " Row(s)"
            Case "tpRevenue"
                GetAccountID(DgnACGRRevenue)
                SLFStatus.Items(0).Text = DgnACGRRevenue.RowCount & " Row(s)"
            Case "tpExpense"
                GetAccountID(DgnACGRExpense)
                SLFStatus.Items(0).Text = DgnACGRExpense.RowCount & " Row(s)"
        End Select
    End Sub

#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        With varFORMAttribute
            .RowID = "-1"
            .IsNew = True
        End With
        frmACGReditor = New ACGR_Editor
        DISPLAY(frmACGReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new account for each accounting book and accounting group", True)
        Call GetTableID()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles clsMMSmenu.EventDataEdit
        Call GetTableID()
        varFORMAttribute.IsNew = False
        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            frmACGReditor = New ACGR_Editor
            DISPLAY(frmACGReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your account data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataDelete() Handles clsMMSmenu.EventDataDelete
        Call GetTableID()
        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            varFORMAttribute.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDBdialogbox.MessageIcon.Question, CMCv.frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes AndAlso (LibSQL.Commands.ACGR.View.DELETEData(varFORMAttribute.RowID)) Then
                Call GETDATAGRID(True)
                Mainframe_n_6.Ts_status.Text = "Success"
            Else
                Mainframe_n_6.Ts_status.Text = "Delete failed"
            End If
        End If
        Call GetTableID()
    End Sub

    Private Sub _MMSMenu_EventToolsFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATAGRID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA()
        Call GETDATAGRID(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Main Form Events"
    Private Sub frmAccountGroup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        varISclosing = True
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmAccountGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me)
            .ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        End With

        Call GETDATA()
        Call GETDATAGRID()
        varSelectedgroup = TbctlAccountGroup.SelectedTab.Name
        Call GetTableID()
        varISfirstload = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub TbctlAccountGroup_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlAccountGroup.Selected
        If Not (varISclosing) Then
            varSelectedgroup = TbctlAccountGroup.SelectedTab.Name
            Call GetTableID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged
        If Not (varISfirstload) Then
            Call GETDATAGRID(True)
            Call GetTableID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (varISfirstload) Then
            LibSQL.Commands.ACGR.View.FILLAccountingBook(CboAccountingBook, CboCompany)
            Call GETDATAGRID(True)
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub RecordSaved() Handles frmACGReditor.RecordSaved
        Call GETDATAGRID(True)
    End Sub
#End Region

End Class
