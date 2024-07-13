Imports System.Runtime.Versioning
Imports CMCv

Public Class POST
#Region "Variables"
    Private varSQLview As New LibSQL.Commands.POST.View
    Private WithEvents frmPOSTeditor As New POST_Editor
    Private WithEvents clsMMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.POST.View.DisplayData(DgnPOST, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        varFORMAttribute.RowID = "-1"

        If DgnPOST.RowCount > 0 Then
            varFORMAttribute.RowID = DgnPOST.CurrentRow.Cells("position_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles clsMMSmenu.EventDataAddNew
        With varFORMAttribute
            .IsNew = True
            .RowID = "-1"
        End With
        frmPOSTeditor = New POST_Editor
        DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new job position data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles clsMMSmenu.EventDataEdit
        Call GETTableID()
        varFORMAttribute.IsNew = False
        frmPOSTeditor = New POST_Editor
        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your position data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles clsMMSmenu.EventDataDelete
        Call GETTableID()

        If varFORMAttribute.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            varFORMAttribute.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDBdialogbox.MessageIcon.Question, CMCv.frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes AndAlso (LibSQL.Commands.POST.View.DELETEData(varFORMAttribute.RowID)) Then
                Call GETDATA(True)
                Mainframe_n_6.Ts_status.Text = "Success"
            Else
                Mainframe_n_6.Ts_status.Text = "Delete failed"
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
        Dim varItem As ToolStripMenuItem()
        Dim varItem_sub As ToolStripMenuItem()
        Dim varItem_sep As ToolStripSeparator()

        ReDim varItem(2)
        clsMMSmenu = New CMCv.Mnu
        clsMMSmenu.Visible = False

        varItem(0) = New ToolStripMenuItem() With {.Name = "DATAToolStripMenuItem", .Text = "DATA", .MergeAction = MergeAction.Insert, .MergeIndex = 1}
        clsMMSmenu.Items.Add(varItem(0))

        varItem(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
        clsMMSmenu.Items.Add(varItem(1))

        Me.Controls.Add(clsMMSmenu)

        ReDim varItem_sub(8)
        ReDim varItem_sep(4)

        For Each varS_item As ToolStripMenuItem In clsMMSmenu.Items

            Select Case varS_item.Name
                Case "DATAToolStripMenuItem"
                    'Insert "Add New..."
                    varItem_sub(0) = New ToolStripMenuItem() With {.Name = "AddNewToolStripMenuItem", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
                    varS_item.DropDown.Items.Add(varItem_sub(0))
                    AddHandler varItem_sub(0).Click, AddressOf AddNewToolStripMenuItem_Clicked

                    'Insert "Edit..."
                    varItem_sub(1) = New ToolStripMenuItem() With {.Name = "EditToolStripMenuItem", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
                    varS_item.DropDown.Items.Add(varItem_sub(1))
                    AddHandler varItem_sub(1).Click, AddressOf EditToolStripMenuItem_Clicked

                    'Insert "Delete..."
                    varItem_sub(2) = New ToolStripMenuItem() With {.Name = "DeleteToolStripMenuItem", .Text = "Delete", .ShortcutKeys = Keys.Delete, .ShortcutKeyDisplayString = "Del"}
                    varS_item.DropDown.Items.Add(varItem_sub(2))
                    AddHandler varItem_sub(2).Click, AddressOf DeleteToolStripMenuItem_Clicked

                    'Insert "Separator"
                    varItem_sep(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                    varS_item.DropDown.Items.Add(varItem_sep(0))

                    'Insert "Refresh"
                    varItem_sub(3) = New ToolStripMenuItem() With {.Name = "RefreshToolStripMenuItem", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                    varS_item.DropDown.Items.Add(varItem_sub(3))
                    AddHandler varItem_sub(3).Click, AddressOf RefreshToolStripMenuItem_Clicked

                    'Insert "Separator"
                    varItem_sep(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                    varS_item.DropDown.Items.Add(varItem_sep(1))

                    'Insert "Close"
                    varItem_sub(4) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.Q, Keys), .ShortcutKeyDisplayString = "Ctrl+Q"}
                    varS_item.DropDown.Items.Add(varItem_sub(4))
                    AddHandler varItem_sub(4).Click, AddressOf CloseToolStripMenuItem_Clicked

                Case "TOOLSToolStripMenuItem"
                    'Insert "Import"
                    varItem_sub(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
                    varS_item.DropDown.Items.Add(varItem_sub(5))
                    AddHandler varItem_sub(5).Click, AddressOf ImportToolStripMenuItem_Clicked

                    'Insert "Export"
                    varItem_sub(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
                    varS_item.DropDown.Items.Add(varItem_sub(6))
                    AddHandler varItem_sub(6).Click, AddressOf ExportToolStripMenuItem_Clicked

                    'Insert "Separator"
                    varItem_sep(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                    varS_item.DropDown.Items.Add(varItem_sep(2))

                    'Insert "Find"
                    varItem_sub(7) = New ToolStripMenuItem() With {.Name = "FindToolStripMenuItem", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
                    varS_item.DropDown.Items.Add(varItem_sub(7))
                    AddHandler varItem_sub(7).Click, AddressOf FindToolStripMenuItem_Clicked
            End Select
        Next
    End Sub
#End Region

#Region "UNUSED : CreateMenu_Events"
    <SupportedOSPlatform("windows")>
    Private Sub AddNewToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Try
                If Not (varUSRaccess.User("POST", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
                    Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                With varFORMAttribute
                    .IsNew = True
                    .RowID = "-1"
                End With

                frmPOSTeditor = New POST_Editor
                DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EditToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Try
                If Not (varUSRaccess.User("POST", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
                    Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Call GETTableID()
                varFORMAttribute.IsNew = False
                If varFORMAttribute.RowID = "-1" Then
                    Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                Else
                    varFORMAttribute.IsNew = False
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
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Try
                If Not (varUSRaccess.User("POST", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
                    Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Call GETTableID()
                If varFORMAttribute.RowID = "-1" Then
                    Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                Else
                    If Decision("Do you want to delete this record?", "Delete", CMCv.frmDBdialogbox.MessageIcon.Question, CMCv.frmDBdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                        If LibSQL.Commands.POST.View.DELETEData(varFORMAttribute.RowID) Then
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
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Call GETDATA()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Me.Close()
        End If
    End Sub

    Private Sub ImportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            'Put your code here
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            'TODO: Export method
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            TxtFind.Focus()
        End If
    End Sub
#End Region

End Class
