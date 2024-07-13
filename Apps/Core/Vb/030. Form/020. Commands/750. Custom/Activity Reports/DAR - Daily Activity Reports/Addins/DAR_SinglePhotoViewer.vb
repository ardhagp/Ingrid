Imports System.Runtime.Versioning

Public Class DAR_SinglePhotoViewer
    Private varFile As String
    Private varImage As Image
    Private varType As String

    Public Sub New(ByVal File As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varFile = File
        varType = "String"
    End Sub

    Public Sub New(ByVal Photo As Image)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varImage = Photo
        varType = "Image"
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_SinglePhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If varType = "String" Then
            PctbxPhoto.ImageLocation = varFile
        ElseIf varType = "Image" Then
            If varTextmark = String.Empty Then
                PctbxPhoto.Image = varImage
            Else
                PctbxPhoto.Image = CMCv.ImageEditor.Proccessor.Editor.Watermarker(varImage, varTextmark)
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
