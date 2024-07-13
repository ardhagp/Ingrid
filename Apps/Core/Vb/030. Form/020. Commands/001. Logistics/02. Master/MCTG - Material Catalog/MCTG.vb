Imports System.Runtime.Versioning

Public Class MCTG

#Region "Variables"
    Private WithEvents clsMMSmenu As New UI.View.MenuStrip
    Private clsSQL As New Commands.MCTG.View
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Ambil data dari database untuk mengisi datagrid Catalog
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks>True untuk mengambil data tanpa filter</remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        DblBuffer(DgnMCTG)
        Commands.MCTG.View.DISPLAYDATA(DgnMCTG, SLFStatus, TxtFind, ForceRefresh)
    End Sub
#End Region

#Region "Menu Strip Function"

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles clsMMSmenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles clsMMSmenu.EventDataClose
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventToolsImport() Handles clsMMSmenu.EventToolsImport
        DISPLAY(New frmImports(Import.Data.DataType.TypeofImports.MaterialMastfrmErroratalog), IMAGEDB.Main.ImageLibrary.IMPORTS_ICON, "Catalog Imports", "Imports your catalog data from other database", True)
    End Sub

    Private Sub EventToolsFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles TxtFind.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub MCTG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMenu()
        Call LoadDGN()
        Call ClearFind()
    End Sub
#End Region

#Region "Component Events"

    <SupportedOSPlatform("windows")>
    Private Sub LoadMenu()
        'Sisipkan ke dalam form
        clsMMSmenu.LoadIn(Me)

        'Menampilkan Menu DATA
        clsMMSmenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        clsMMSmenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        clsMMSmenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        clsMMSmenu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))

    End Sub

    Private Sub LoadDGN()
        'Memuat warna acak
        DgnMCTG.XOGETNewColor()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GETDATA(True)
    End Sub

#End Region


End Class
