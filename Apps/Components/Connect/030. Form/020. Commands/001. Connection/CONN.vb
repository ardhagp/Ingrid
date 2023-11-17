Imports CMCv

Public Class CONN
    Public Event ConnectFrameClose()
    Private WithEvents v_MMSMenu As New UI.View.MenuStrip
    Private WithEvents v_CONN_Editor As New CONN_Editor
    Private v_SQL As New Commands.CONN.View
    Private v_IsProduction As Boolean = True
    Private v_IsExtension As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        v_IsProduction = True
    End Sub

    Public Sub New(Optional ByVal IsProduction As Boolean = False, Optional ByVal IsExtension As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        v_IsProduction = IsProduction
        v_IsExtension = IsExtension
    End Sub

#Region "Sub Collections"
    ''' <summary>
    ''' Ambil data dari database untuk mengisi datagrid Catalog
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks>True untuk mengambil data tanpa filter</remarks>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        DblBuffer(DgnConnection)
        v_SQL.DisplayData(DgnConnection, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GETTableID()
        v_FORMAttrib.RowID = "-1"

        If DgnConnection.RowCount > 0 Then
            v_FORMAttrib.RowID = DgnConnection.CurrentRow.Cells("ID").Value
        End If
    End Sub
#End Region

    Private Sub CONN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        V_BRIDGE_LOG.SENDLOG("Connection Settings is opened.", Bridge.Security.WRITELOG.LogType.Information)

        V_DBE_SQLite.Open(v_IsProduction)

        Call LoadMenu()

        DgnConnection.SLF_GETNewColor()

        Call GETDATA(True)
    End Sub

    Private Sub LoadMenu()
        v_MMSMenu.LoadIn(Me, True)
        v_MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
    End Sub

    Private Sub CONN_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        If Not (v_IsExtension) Then
            '_DBE_LocalDB.Close()
            v_DBE_SQLite.Close()
        End If

        V_BRIDGE_LOG.SENDLOG("Connection Settings is closed.", Bridge.Security.WRITELOG.LogType.Information)

        RaiseEvent ConnectFrameClose()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call GETDATA(False)
    End Sub

    ''' <summary>
    ''' Add new data
    ''' </summary>
    Private Sub EventDataAddNew() Handles v_MMSMenu.EventDataAddNew
        v_FORMAttrib.IsNew = True
        v_FORMAttrib.RowID = "-1"
        v_CONN_Editor = New CONN_Editor
        Display(v_CONN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new connection", True)
        SLFStatus.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    Public Sub EventDataEdit() Handles v_MMSMenu.EventDataEdit
        Call GETTableID()
        v_FORMAttrib.IsNew = False

        If v_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            v_CONN_Editor = New CONN_Editor
            Display(v_CONN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update connection", True)
        End If

        SLFStatus.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    Private Sub EventDataDelete() Handles v_MMSMenu.EventDataDelete
        Call GETTableID()
        If v_FORMAttrib.RowID = "-1" Then
            Decision("no record selected", "error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            v_FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnConnection.CurrentRow.Cells("connectionname").Value & vbCrLf & "=======================================================", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (v_SQL.DELETEData(v_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    SLFStatus.Text = "Success"
                Else
                    SLFStatus.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call GETDATA(False)
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA(False)
        End If
    End Sub

    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles v_MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Load data with filter applied
    ''' </summary>
    Private Sub EventDataRefresh() Handles v_MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles v_MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GETDATA(True)
    End Sub

    Private Sub v_CONN_Editor_RecordSaved() Handles v_CONN_Editor.RecordSaved
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class
