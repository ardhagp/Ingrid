Namespace OperatingSystem.File
    Public Class Info
        ''' <summary>
        ''' Fungsi untuk memastikan bahwa file ada.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsExists(ByVal FilePath As String) As Boolean
            Dim varFileexist As New IO.FileInfo(FilePath)
            Return varFileexist.Exists
        End Function

        ''' <summary>
        ''' Fungsi untuk menghitung besar suatu file.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Double</returns>
        Public Shared Function Size(ByVal FilePath As String) As Double
            Dim varFilesize As New IO.FileInfo(FilePath)
            Return varFilesize.Length
        End Function
    End Class

    Public Class Upload
        ''' <summary>
        ''' Fungsi untuk memeriksa ukuran maksimum file yang dapat diunggah.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <param name="MaxSize">Ukuran file maksimum (dalam Megabyte)</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsAllowedSize(ByVal FilePath As String, ByVal MaxSize As Double, Optional ByVal ShowNativeDialog As Boolean = False) As Boolean

            'Dim _File As New Info

            Dim varIsallowed As Boolean
            Dim size As String() = {"B", "KB", "MB", "GB", "TB"}
            Dim varPhotolength As Double = Info.Size(FilePath)
            Dim varOriginalphotolength As Double = varPhotolength
            Dim varOrder As Integer = 0
            Dim varMaximumorder As Integer = 0

            If MaxSize = 0 Then
                varIsallowed = True
                Return varIsallowed
                Exit Function
            End If

            While (varPhotolength >= 1024 AndAlso CType(size.Length - 1, Boolean))
                varOrder += 1
                varPhotolength /= 1024
            End While

            Dim varMaximumphotolength As Double = ((1024 ^ 2) * MaxSize) '1 indicate 1000KB or 1MB
            Dim varMaximumphotolengthdisplay As Double = varMaximumphotolength

            While (varMaximumphotolengthdisplay >= 1024 AndAlso CType(size.Length - 1, Boolean))
                varMaximumorder += 1
                varMaximumphotolengthdisplay /= 1024
            End While

            If varOriginalphotolength > varMaximumphotolength Then
                Dim varErrorbox As New CMCv.frmDialogBox("Your file size is : " & String.Format("{0:0.##} {1}", varPhotolength, size(varOrder)) & ", above the size that we can tolerate." & vbCrLf & "Please pick your file size under " & String.Format("{0:0.##} {1}", varMaximumphotolengthdisplay, size(varMaximumorder)) & " and then try again.", "Limit Exceeded", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                If (ShowNativeDialog) Then
                    varErrorbox.ShowDialog()
                    varErrorbox.Dispose()
                End If
                varIsallowed = False
            Else
                varIsallowed = True
            End If

            Return varIsallowed
        End Function
    End Class
End Namespace
