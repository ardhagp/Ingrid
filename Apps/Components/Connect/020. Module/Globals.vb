Imports CMCv.Database.Engine
Imports CMCv.Database.Properties
Imports CMCv.Database.Adapter

Imports Bridge.Security

Imports System.Reflection
Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Module Globals
    Public varDBengine_mssql2008 As New CMCv.Database.Engine.Mssql2008
    Public varDBengine_sqlite As New SQLiteV3
    Public varDBproperties(1) As Fields
    Public varBridgelog As New Writelog

    Public varDBreader_sqlite(1) As SQLite.Display.Request
    Public varDBdisplay_sqlite As New SQLite.Execute

    Public varSecurityencrypt As New Security.Encrypt

    Public varVersionmajor As Integer = My.Application.Info.Version.Major
    Public varVersionminor As Integer = My.Application.Info.Version.Minor
    Public varVersionbuild As Integer = My.Application.Info.Version.Build
    Public varVersionrevision As Integer = My.Application.Info.Version.Revision
    Public varVersionapplication As String = varVersionmajor & "." & varVersionminor & "." & varVersionbuild & "." & varVersionrevision

    Public WithEvents frmMessage As New frmDialogBox
    Public WithEvents frmError As New frmErrorReporting
    Public clsErrorcatcher As New Catcher.Error.Fields

    Public frmAttribute As New Connect.Main.GlobalRecord

#Region "Custom Message Box"
    ''' <summary>
    ''' CMCv Message Box
    ''' </summary>
    ''' <param name="Message">Masukkan pesan anda di sini</param>
    ''' <param name="Title">Judul form</param>
    ''' <param name="MessageIcon">Jenis Icon</param>
    ''' <param name="ButtonType">Jenis Tombol</param>
    ''' <returns>DialogResult</returns>
    ''' <remarks></remarks>
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        frmMessage = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return frmMessage.ShowDialog()
        frmMessage.Dispose()
    End Function
#End Region

    Public Sub DblBuffer(ByVal GridView As DataGridView)
        Try
            Dim systemType As Type = GridView.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(GridView, True, Nothing)
        Catch ex As Exception
            PUSHERRORDATA("[DblBuffer] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message.ToString, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    Public Sub Display(ByVal FormName As CMCv.Std_Fo, Optional ByVal FormImage As System.Drawing.Image = Nothing, Optional ByVal FormTitle As String = "", Optional ByVal FormSubTitle As String = "", Optional ByVal IsDialog As Boolean = False, Optional ByVal ParentFrame As Windows.Forms.Form = Nothing)
        Try
            FormName.SLFNamaForm.Text = FormTitle
            If FormImage IsNot Nothing Then
                FormName.SLFLogo.Image = FormImage
            End If
            FormName.SLFSubNamaForm.Text = FormSubTitle
            If Not (IsDialog) Then
                If (FormName.IsHandleCreated) Then
                    FormName.Focus()
                Else
                    If ParentFrame IsNot Nothing Then
                        FormName.Visible = False
                        FormName.MdiParent = ParentFrame
                        FormName.WindowState = FormWindowState.Maximized
                        FormName.Show()
                        FormName.Visible = True
                    Else
                        FormName.Show()
                    End If
                End If
            Else
                FormName.ShowDialog()
                FormName.Dispose()
            End If
        Catch ex As Exception
            Call PUSHERRORDATA("[Display] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            Call PUSHERRORDATASHOW()
        End Try
    End Sub

#Region "Get App Version"

    ''' <summary>
    ''' Fungsi untuk mendapatkan versi app
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function GETAPPVERSION() As String
        Try
            Dim varVersionmajor, varVersionminor, varVersionbuild, varVersionrevision As Integer
            varVersionmajor = My.Application.Info.Version.Major
            varVersionminor = My.Application.Info.Version.Minor
            varVersionbuild = My.Application.Info.Version.Build
            varVersionrevision = My.Application.Info.Version.Revision
            varVersionapplication = varVersionmajor & "." & varVersionminor & "." & varVersionbuild & "." & varVersionrevision
            Return varVersionapplication
        Catch ex As Exception
            PUSHERRORDATA("[GETAPPVERSION] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            varVersionapplication = "0.0.0"
            Return varVersionapplication
        End Try
    End Function
#End Region


#Region "Error Log"

    ''' <summary>
    ''' Metode untuk menyimpan log error
    ''' </summary>
    ''' <param name="ErrorType">Tipe Error</param>
    ''' <param name="ErrorMessage">Pesan Error</param>
    ''' <param name="ErrorNumber">Nomor Error</param>
    ''' <param name="InternalStackTrace">Internal Stack Trace</param>
    ''' <param name="AppVersion">Versi Aplikasi</param>
    ''' <param name="EnableErrorReporting">True/False</param>
    ''' <param name="SaveError">True/False</param>
    ''' <param name="ResumeNext">Lanjutkan saat terjadi kesalahan</param>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATA(ByVal FromSender As String, ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With clsErrorcatcher
            .FromSender = FromSender
            .Type = ErrorType
            .Message = ErrorMessage
            .Number = ErrorNumber
            .InternalStackTrace = InternalStackTrace
            .AppVersion = AppVersion
            .EnableErrorReporting = EnableErrorReporting
            .SaveError = SaveError
            .ResumeNext = ResumeNext
        End With
    End Sub

    ''' <summary>
    ''' Metode untuk menampilkan log error
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATASHOW()
        frmError = New CMCv.frmErrorReporting(clsErrorcatcher, varDBengine_sqlite)
        frmError.ShowDialog()
        If Not (frmError.ResumeNext) Then
            Exit Sub
        End If
    End Sub
#End Region
End Module
