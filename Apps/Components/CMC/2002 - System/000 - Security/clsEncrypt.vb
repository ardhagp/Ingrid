Imports System.Runtime.Versioning
Imports System.Text
Imports NETCore.Encrypt

Namespace Security
    Public Class Encrypt

        Private Shared Function RandomString() As String
            Dim r As New Random
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
            Dim sb As New StringBuilder
            Dim cnt As Integer = r.Next(15, 33)
            For i As Integer = 1 To cnt
                Dim idx As Integer = r.Next(0, s.Length)
                sb.Append(s.AsSpan(idx, 1))
            Next
            Return sb.ToString()
        End Function

        Public Shared Function MD5(Optional ByVal Message As String = "") As String
            Dim varEmessage As String
            Dim varGuid As String

            If Message = String.Empty Then
                varGuid = System.Guid.NewGuid.ToString
                varEmessage = EncryptProvider.Md5(CStr(Now) & RandomString() & varGuid)
            Else
                varEmessage = EncryptProvider.Md5(Message)
            End If

            Return varEmessage
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function AES(Message As String) As String
            Dim varEmessage As String = EncryptProvider.AESEncrypt(Message, varSalt)
            Return varEmessage
        End Function
    End Class

    Public Class Decrypt
        <SupportedOSPlatform("windows")>
        Public Shared Function AES(Message As String) As String
            Dim varEmessage As String = EncryptProvider.AESDecrypt(Message, varSalt)
            Return varEmessage
        End Function
    End Class
End Namespace

