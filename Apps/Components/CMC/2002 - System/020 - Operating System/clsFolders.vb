Namespace OperatingSystem
    Public Class Folder
        Public Shared Function Exists(ByVal FolderPath As String) As Boolean
            Dim varFolderexists As New IO.DirectoryInfo(FolderPath)
            Return varFolderexists.Exists
        End Function
    End Class
End Namespace

