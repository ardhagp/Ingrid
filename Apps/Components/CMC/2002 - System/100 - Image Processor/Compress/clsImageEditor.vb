Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Versioning

Namespace ImageEditor.Proccessor
    Public Class Compress
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsFile(ByVal File As String, ByVal SaveAs As String) As Boolean
            ' Get a bitmap.
            Dim varSuccess As Boolean
            Try
                Dim varPhoto As New Bitmap(File)
                Dim varPhototemporary As New Bitmap(varPhoto)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim myEncoderParameters As New EncoderParameters(1)

                Dim varMemorystream As New MemoryStream

                Dim myEncoderParameter As New EncoderParameter(myEncoder, 20&)

                myEncoderParameters.Param(0) = myEncoderParameter

                varPhototemporary.Save(varMemorystream, System.Drawing.Imaging.ImageFormat.Jpeg)

                Dim varNewphoto As New Bitmap(System.Drawing.Image.FromStream(varMemorystream))

                'varNewphoto = System.Drawing.Image.FromStream(varMemorystream)
                varNewphoto.Save(SaveAs, jpgEncoder, myEncoderParameters)
                varNewphoto.Dispose()
                varMemorystream.Dispose()
                varPhototemporary.Dispose()
                varPhoto.Dispose()
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            GC.Collect()

            Return varSuccess
        End Function

        ''' <summary>
        ''' Convert File Path to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(ByVal File As String) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varPhoto As New Bitmap(File)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim myEncoderParameters As New EncoderParameters(1)

                Dim myEncoderParameter As New EncoderParameter(myEncoder, 20&)
                myEncoderParameters.Param(0) = myEncoderParameter

                Dim varNewimage As System.Drawing.Image = Nothing

                Dim varMemorystream = New MemoryStream()
                'varPhoto.Save(varMemorystream, System.Drawing.Imaging.ImageFormat.Jpeg)
                varPhoto.Save(varMemorystream, jpgEncoder, myEncoderParameters)
                'Dim varByte = varMemorystream.ToArray

                varNewimage = System.Drawing.Image.FromStream(varMemorystream)

                GC.Collect()

                Return varNewimage
            Catch ex As Exception
                PUSHERRORDATA("[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Filestream to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(ByVal File As FileStream) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varNewimage As System.Drawing.Image = Nothing
                Dim varMemorystream = New MemoryStream()

                varMemorystream.SetLength(File.Length)
                File.Read(varMemorystream.GetBuffer, 0, CType(File.Length, Integer))

                varMemorystream.Flush()
                File.Close()
                varMemorystream.Close()

                varNewimage = System.Drawing.Image.FromStream(varMemorystream)

                GC.Collect()

                Return varNewimage
            Catch ex As Exception
                PUSHERRORDATA("[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Byte to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(ByVal File() As Byte) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varNewimage As System.Drawing.Image = Nothing
                Dim varMemorystream = New MemoryStream()

                varMemorystream.Write(File, 0, File.Length)
                varMemorystream.Seek(0, SeekOrigin.Begin)

                varNewimage = System.Drawing.Image.FromStream(varMemorystream)

                GC.Collect()

                Return varNewimage
            Catch ex As Exception
                PUSHERRORDATA("[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsByte(ByVal File As String) As Byte()
            ' Get a bitmap.
            Dim varPhoto As New Bitmap(File)

            ' Create an Encoder object based on the GUID
            ' for the Quality parameter category.
            Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

            ' Create an EncoderParameters object.
            ' An EncoderParameters object has an array of EncoderParameter
            ' objects. In this case, there is only one
            ' EncoderParameter object in the array.
            Dim myEncoderParameters As New EncoderParameters(1)

            Dim myEncoderParameter As New EncoderParameter(myEncoder, 20&)
            myEncoderParameters.Param(0) = myEncoderParameter
            'varPhoto.Save(SaveAs, jpgEncoder, myEncoderParameters)

            Dim varMemorystream = New MemoryStream()
            varPhoto.Save(varMemorystream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim varByte = varMemorystream.ToArray

            GC.Collect()

            Return varByte
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

            Dim codec As ImageCodecInfo
            For Each codec In codecs
                If codec.FormatID = format.Guid Then
                    Return codec
                End If
            Next codec
            Return Nothing
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function Watermarker(ByVal Picture As System.Drawing.Image, ByVal Text As String) As System.Drawing.Image
            Try
                Dim varBmp As New Bitmap(Picture)
                Dim varWatertext As String = Text
                Dim varCanvas As Graphics = Graphics.FromImage(varBmp)
                Dim varStringsizef As SizeF,
    varDesiredwidth As Double,
    varDesiredwidth2 As Double,
    varDesireheight As Double,
    wmFont As Font,
    varRequiredfontsize As Double,
    varRatio As Double

                wmFont = New Font("Verdana", 14, FontStyle.Bold)

                varDesiredwidth = varBmp.Width * 0.5
                varDesiredwidth2 = varBmp.Width * 0.25
                varDesireheight = varBmp.Height * 0.5

                varStringsizef = varCanvas.MeasureString(varWatertext, wmFont)
                varRatio = varStringsizef.Width / wmFont.SizeInPoints
                varRequiredfontsize = varDesiredwidth / varRatio

                wmFont = New Font("Verdana", CType(varRequiredfontsize, Single), CType(FontStyle.Bold, FontStyle))

                varCanvas.DrawString(varWatertext,
        wmFont,
        New SolidBrush(Color.FromArgb(128, 0, 0, 0)), CType(varDesiredwidth2 + 2, Single), CType(varDesireheight + 2, Single))

                varCanvas.DrawString(varWatertext,
        wmFont,
        CType(New SolidBrush(Color.FromArgb(128, 255, 255, 255)), Brush), CType(varDesiredwidth2, Single), CType(varDesireheight, Single))

                varBmp.SetResolution(96, 96)

                Return varBmp
            Catch ex As Exception
                PUSHERRORDATA("[Watermarker] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

