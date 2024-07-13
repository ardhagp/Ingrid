Imports System.Media
Imports System.Runtime.Versioning
Imports CMCv
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Application
    Public Class Access
        ReadOnly _SQL As New LibSQL.Application.Access

        <SupportedOSPlatform("windows")>
        Public Function User(ByVal varTCode As String, ByVal UID As String, ByVal TypeOfAccess As LibSQL.Application.Access.TypeOfAccess, Optional Status As Stt = Nothing) As Boolean
            Dim varAccessvalue As Boolean

            Try
                varAccessvalue = CType(_SQL.User(varTCode, UID, TypeOfAccess), Boolean)

                If varAccessvalue = False Then
                    SystemSounds.Exclamation.Play()
                End If

                Return varAccessvalue

            Catch ex As Exception
                SystemSounds.Exclamation.Play()
                Return False
            End Try
        End Function
    End Class
End Namespace

Namespace Application
    Public Class Modules
        'ReadOnly _SQL As New LibSQL.Application.Modules

        <SupportedOSPlatform("windows")>
        Public Shared Function IsModuleReady(ByVal varTCode As String) As Boolean
            Dim varISmoduleready As Boolean

            Try
                varISmoduleready = CType(LibSQL.Application.Modules.Exist(varTCode), Boolean)

                Return varISmoduleready
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsModuleLocked(ByVal varTCode As String) As Boolean
            Dim varISmodulelocked As Boolean

            Try

                varISmodulelocked = CType(LibSQL.Application.Modules.Locked(varTCode), Boolean)

                Return varISmodulelocked
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    Public Class Marquee
        Private varCurrenttext As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private varText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private varDirection As Direction = Direction.Left
        Private varScrolllength As Integer = 1000000
        Public varMarqueetext As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Public ReadOnly Property MarqueeText As String
            Get
                Return varMarqueetext
            End Get
        End Property
        Public Property ScrollDirection As Direction
            Get
                Return varDirection
            End Get
            Set(ByVal value As Direction)
                varDirection = value
            End Set
        End Property
        Private ReadOnly Property CurrentText As String
            Get
                Return varCurrenttext
            End Get
        End Property
        Public Property Text As String
            Get
                Return varText
            End Get
            Set(ByVal value As String)
                varText = value
                varCurrenttext = value
            End Set
        End Property
        Public Property ScrollLength As Integer
            Get
                Return varScrolllength
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                varScrolllength = value
            End Set
        End Property
        Public Sub Tick()
            If ScrollLength > Len(varText) Then ScrollLength = Len(varText)
            If ScrollDirection = Direction.Left Then
                Dim MoveCharacter As String = Mid$(varCurrenttext, 1, 1)
                varCurrenttext = Replace(varCurrenttext, MoveCharacter, "", 1, 1)
                varCurrenttext &= MoveCharacter
                varMarqueetext = Mid$(varCurrenttext, 1, varScrolllength)
            ElseIf ScrollDirection = Direction.Right Then
                Dim MoveCharacter As String = Mid$(varCurrenttext, Len(varCurrenttext), 1)
                varCurrenttext = Mid$(varCurrenttext, 1, Len(varCurrenttext) - 1)
                varCurrenttext = MoveCharacter & varCurrenttext
                varMarqueetext = Mid$(varCurrenttext, 1, varScrolllength)
            End If
        End Sub
        Public Enum Direction
            Left
            Right
        End Enum
    End Class
End Namespace
