Imports System.Runtime.Versioning
Imports CMCv

Public Class POST
#Region "Variables"
    Private clsSQL As New LibSQL.Commands.POST.View
    Private WithEvents frmPOSTeditor As New POST_Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.POST.View.DisplayData(DgnPOST, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        frmAttribute.RowID = "-1"

        If DgnPOST.RowCount > 0 Then
            frmAttribute.RowID = DgnPOST.CurrentRow.Cells("position_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        With frmAttribute
            .IsNew = True
            .RowID = "-1"
        End With
        frmPOSTeditor = New POST_Editor
        DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new job position data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        Call GETTableID()
        frmAttribute.IsNew = False
        frmPOSTeditor = New POST_Editor
        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your position data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        Call GETTableID()

        If frmAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmAttribute.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.POST.View.DELETEData(frmAttribute.RowID)) Then
                    Call GETDATA(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles clsMMSmenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles clsMMSmenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventDataFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub

#End Region

    <SupportedOSPlatform("windows")>
    Private Sub POST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With clsMMSmenu
            .LoadIn(Me)
            .ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        End With
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _POST_Editor_RecordSaved() Handles frmPOSTeditor.RecordSaved
        Call GETDATA(True)
    End Sub

#Region "UNUSED : CreateMenu"
    <SupportedOSPlatform("windows")>
    Private Sub CreateMenu()
        Dim clsMMSmenu As New CMCv.Mnu
        Dim clsItem As ToolStripMenuItem()
        Dim clsItemsub As ToolStripMenuItem()
        Dim clsItemsep As ToolStripSeparator()

        ReDim clsItem(2)
        clsMMSmenu = New CMCv.Mnu
        clsMMSmenu.Visible = False

        clsItem(0) = New ToolStripMenuItem() With {.Name = "DATAToolStripMenuItem", .Text = "DATA", .MergeAction = MergeAction.Insert, .MergeIndex = 1}
        clsMMSmenu.Items.Add(clsItem(0))

        clsItem(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
        clsMMSmenu.Items.Add(clsItem(1))

        Me.Controls.Add(clsMMSmenu)

        ReDim clsItemsub(8)
        ReDim clsItemsep(4)

        For Each clsSitem As ToolStripMenuItem In clsMMSmenu.Items

            Select Case clsSitem.Name
                Case "DATAToolStripMenuItem"
                    'Insert "Add New..."
                    clsItemsub(0) = New ToolStripMenuItem() With {.Name = "AddNewToolStripMenuItem", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
                    clsSitem.DropDown.Items.Add(clsItemsub(0))
                    AddHandler clsItemsub(0).Click, AddressOf AddNewToolStripMenuItem_Clicked

                    'Insert "Edit..."
                    clsItemsub(1) = New ToolStripMenuItem() With {.Name = "EditToolStripMenuItem", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
                    clsSitem.DropDown.Items.Add(clsItemsub(1))
                    AddHandler clsItemsub(1).Click, AddressOf EditToolStripMenuItem_Clicked

                    'Insert "Delete..."
                    clsItemsub(2) = New ToolStripMenuItem() With {.Name = "DeleteToolStripMenuItem", .Text = "Delete", .ShortcutKeys = Keys.Delete, .ShortcutKeyDisplayString = "Del"}
                    clsSitem.DropDown.Items.Add(clsItemsub(2))
                    AddHandler clsItemsub(2).Click, AddressOf DeleteToolStripMenuItem_Clicked

                    'Insert "Separator"
                    clsItemsep(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                    clsSitem.DropDown.Items.Add(clsItemsep(0))

                    'Insert "Refresh"
                    clsItemsub(3) = New ToolStripMenuItem() With {.Name = "RefreshToolStripMenuItem", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                    clsSitem.DropDown.Items.Add(clsItemsub(3))
                    AddHandler clsItemsub(3).Click, AddressOf RefreshToolStripMenuItem_Clicked

                    'Insert "Separator"
                    clsItemsep(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                    clsSitem.DropDown.Items.Add(clsItemsep(1))

                    'Insert "Close"
                    clsItemsub(4) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.Q, Keys), .ShortcutKeyDisplayString = "Ctrl+Q"}
                    clsSitem.DropDown.Items.Add(clsItemsub(4))
                    AddHandler clsItemsub(4).Click, AddressOf CloseToolStripMenuItem_Clicked

                Case "TOOLSToolStripMenuItem"
                    'Insert "Import"
                    clsItemsub(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
                    clsSitem.DropDown.Items.Add(clsItemsub(5))
                    AddHandler clsItemsub(5).Click, AddressOf ImportToolStripMenuItem_Clicked

                    'Insert "Export"
                    clsItemsub(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
                    clsSitem.DropDown.Items.Add(clsItemsub(6))
                    AddHandler clsItemsub(6).Click, AddressOf ExportToolStripMenuItem_Clicked

                    'Insert "Separator"
                    clsItemsep(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                    clsSitem.DropDown.Items.Add(clsItemsep(2))

                    'Insert "Find"
                    clsItemsub(7) = New ToolStripMenuItem() With {.Name = "FindToolStripMenuItem", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
                    clsSitem.DropDown.Items.Add(clsItemsub(7))
                    AddHandler clsItemsub(7).Click, AddressOf FindToolStripMenuItem_Clicked
            End Select
        Next
    End Sub
#End Region

#Region "UNUSED : CreateMenu_Events"
    <SupportedOSPlatform("windows")>
    Private Sub AddNewToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            Try
                If Not (varUSERaccess.User("POST", varUSERattribute.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
                    Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                    Return
                End If

                frmAttribute.IsNew = True
                frmAttribute.RowID = "-1"

                frmPOSTeditor = New POST_Editor
                DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EditToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            Try
                If Not (varUSERaccess.User("POST", varUSERattribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
                    Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                    Return
                End If

                Call GETTableID()
                frmAttribute.IsNew = False
                If frmAttribute.RowID = "-1" Then
                    Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                Else
                    frmAttribute.IsNew = False
                    frmPOSTeditor = New POST_Editor
                    DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DeleteToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            Try
                If Not (varUSERaccess.User("POST", varUSERattribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
                    Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                    Return
                End If

                Call GETTableID()
                If frmAttribute.RowID = "-1" Then
                    Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                Else
                    If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                        If LibSQL.Commands.POST.View.DELETEData(frmAttribute.RowID) Then
                            Call GETDATA(True)
                            Mainframe_n_6.Ts_status.Text = "Success"
                        Else
                            Mainframe_n_6.Ts_status.Text = "Delete failed"
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub RefreshToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            Call GETDATA()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            Me.Close()
        End If
    End Sub

    Private Sub ImportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            'Put your code here
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            'Put your code here..
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim clsItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If clsItem IsNot Nothing Then
            TxtFind.Focus()
        End If
    End Sub
#End Region

End Class
