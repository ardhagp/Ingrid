Imports System.Runtime.Versioning

Public Class frmERerrorreporting
    'Private Catcher As New Catcher.Error.Fields
    Public ResumeNext As Boolean

    'Private varERL As New Database.Engine.LocalDB
    Private varERL As New Database.Engine.SQLiteV3

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub New(ByVal clsECerrorcatcher As Catcher.Error.Fields, Optional ByVal DBEngine As Database.Engine.SQLiteV3 = Nothing)
        InitializeComponent()
        TxtErrorType.Text = TypeOfFaultiesConverter(clsECerrorcatcher)
        TxtErrorMessage.Text = clsECerrorcatcher.Message & System.Environment.NewLine & System.Environment.NewLine & "Sender: " & clsECerrorcatcher.FromSender
        TxtErrorNumber.Text = clsECerrorcatcher.Number
        TxtAppBuild.Text = clsECerrorcatcher.AppVersion
        ChkErrorReporting.Enabled = clsECerrorcatcher.EnableErrorReporting
        ResumeNext = clsECerrorcatcher.ResumeNext

        'Send Error to Ingrid Log Center
        Bridge.Security.WRITELOG.SENDLOG(TxtErrorMessage.Text & Environment.NewLine & "Error Number: " & TxtErrorNumber.Text & Environment.NewLine & "Error Type: " & TxtErrorType.Text & Environment.NewLine & "App Build: " & TxtAppBuild.Text, Bridge.Security.WRITELOG.LogType.Error)

        'Record Error into local database
        If (clsECerrorcatcher.SaveError) Then
            If DBEngine Is Nothing Then
                Return
            End If
            varERL = DBEngine
            varERL.Open()
            varERL.SaveErrorData(clsECerrorcatcher)
        End If


        'Tbctl1.TabPages.RemoveByKey("tp_SystemInformation")

    End Sub

    Private Function TypeOfFaultiesConverter(ByVal clsECerrorcatcher As Catcher.Error.Fields) As String
        Dim varResult As String = ""
        Select Case clsECerrorcatcher.Type
            Case CType(20010102, Catcher.Error.Fields.TypeOfFaulties)
                varResult = "SupportServiceDatabaseEngine"
            Case CType(200102, Catcher.Error.Fields.TypeOfFaulties)
                varResult = "SupportServiceSOAP"
            Case CType(200103, Catcher.Error.Fields.TypeOfFaulties)
                varResult = "SupportServiceWeb"
            Case CType(100100, Catcher.Error.Fields.TypeOfFaulties)
                varResult = "ApplicationRunTime"
        End Select

        Return varResult
    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        Me.Dispose()
        If Not (ResumeNext) Then
            'put your code here
        End If
    End Sub
End Class
