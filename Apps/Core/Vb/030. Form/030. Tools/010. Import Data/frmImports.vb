Imports System.IO
Imports System.Runtime.Versioning
Imports System.Security.Principal
Imports Syncfusion.Windows.Forms.Tools.Win32API

Public Class frmImports
    Private varSource As Import.Data.DataType.TypeofImports
    Private varOriginalsourcefile As String
    Private clsSQLcatalog As New LibSQL.Tools.Import.MaterialMaster.Catalog

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varOriginalsourcefile = String.Empty
    End Sub

    Public Sub New(ByVal Source As Import.Data.DataType.TypeofImports)
        InitializeComponent()
        varSource = Source
        varOriginalsourcefile = String.Empty
    End Sub

    <Obsolete>
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim varFileloaded As Integer = 0

        od.Filter = "Comma Separated Values|*.csv"
        od.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString
        varFileloaded = od.ShowDialog()
        If varFileloaded <> System.Windows.Forms.DialogResult.Cancel Then
            varOriginalsourcefile = od.FileName
            LblFileName.Text = CompactString(varOriginalsourcefile, LblFileName.Width, LblFileName.Font, TextFormatFlags.PathEllipsis)
            TxtProgress.AppendText("Preparing : " & varOriginalsourcefile & Environment.NewLine)
            TxtProgress.AppendText("Click [SAVE] to start importing your data..." & Environment.NewLine)
        End If
    End Sub

    <Obsolete>
    Private Function CompactString(ByVal MyString As String, ByVal Width As Integer,
ByVal Font As Drawing.Font,
ByVal FormatFlags As Windows.Forms.TextFormatFlags) As String

        Dim varResult As String = String.Copy(MyString)

        TextRenderer.MeasureText(varResult, Font, New Drawing.Size(Width, 0),
            FormatFlags Or TextFormatFlags.ModifyString)

        Return varResult

    End Function

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If varOriginalsourcefile <> String.Empty Then
            TxtProgress.AppendText("Checking if your file exist... ")
            If File.Exists(varOriginalsourcefile) Then
                Select Case varSource
                    Case Import.Data.DataType.TypeofImports.MaterialMastfrmErroratalog
                        clsSQLcatalog.Execute(TxtProgress, varOriginalsourcefile)
                    Case Import.Data.DataType.TypeofImports.MaterialMasterPlant
                        'nothing
                End Select
            End If
        Else
            TxtProgress.AppendText("No file selected." & Environment.NewLine)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
