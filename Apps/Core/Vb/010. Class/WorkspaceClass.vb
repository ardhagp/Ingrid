Imports System.Runtime.Versioning
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Public Class WorkspaceClass
#Region "Variables"
    Private ReadOnly varCommandexist As Boolean
    Private ReadOnly varCommandrestricted As Boolean
    Private varTCode As String
    Private ReadOnly varSQL As New LibSQL.varWorkspace
    Private varMODname As String
    Private varMODdescription As String
#End Region

#Region "Declare Modules"
    'Accounting
    Private WithEvents frmACGR As New ACGR
    Private WithEvents frmACBK As New ACBK

    'Management
    Private WithEvents frmCCIN As New CCIN
    Private WithEvents frmCDIN As New CDIN
    Private WithEvents frmPOST As New POST
    Private WithEvents frmEPLS As New EPLS

    'Logistic
    Private WithEvents frmPLNT As New PLNT
    Private WithEvents frmSLOC As New SLOC
    Private WithEvents frmMCTG As New MCTG
    Private WithEvents frmMMTY As New MMTY
    Private WithEvents frmMMGR As New MMGR

    'Custom
    Private WithEvents frmDAR As New DAR
    Private WithEvents frmDARD As New DARD
    Private WithEvents frmDRTM As New DRTM
    Private WithEvents frmDRAA As New DRAA
    Private WithEvents frmPEPR As New PEPR
    Private WithEvents frmREMS As New REMS

    'System
    Private WithEvents frmUAC As New UAC
    Private WithEvents frmMODS As New MODS
    Private WithEvents frmMOGS As New MOGS
    Private WithEvents frmSYSS As New SYSS

    'Tools
    Private WithEvents frmSAY As New SAY
    Private WithEvents frmPhotoresize As New CMCv.PHTRZ

    'DummVy
    Private WithEvents frmDUMMY As New Dummy

    Private WithEvents frmRESET As New RESET
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub Open(ByVal Mainframe As Form, ByVal varTCode As String, Optional StatusBar As CMCv.Stt = Nothing)
        Try
            'varTCode = varTCode.ToString.Split("-".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            'varCommandexist = True
            'varCommandrestricted = False
            varMODname = LibSQL.varWorkspace.GETModuleName(varTCode)
            varMODdescription = LibSQL.varWorkspace.GETModuleDescription(varTCode)

            Select Case varTCode(0)
                'ACCOUNTING
                Case CType("ACGR", Char)
                    If (Not (frmACGR.IsHandleCreated)) OrElse (IsNothing(frmACGR)) Then
                        frmACGR = New ACGR
                        DISPLAY(frmACGR, IMAGEDB.Main.ImageLibrary.ACGR_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmACGR.Focus()
                    End If
                Case CType("ACBK", Char)
                    If (Not (frmACBK.IsHandleCreated)) OrElse (IsNothing(frmACBK)) Then
                        frmACBK = New ACBK
                        DISPLAY(frmACBK, IMAGEDB.Main.ImageLibrary.ACBK_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmACBK.Focus()
                    End If


                    'LOGISTICS
                Case CType("MCTG", Char)
                    If (Not (frmMCTG.IsHandleCreated)) OrElse (IsNothing(frmMCTG)) Then
                        frmMCTG = New MCTG
                        DISPLAY(frmMCTG, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmMCTG.Focus()
                    End If
                Case CType("MMTY", Char)
                    If (Not (frmMMTY.IsHandleCreated)) OrElse (IsNothing(frmMMTY)) Then
                        frmMMTY = New MMTY
                        DISPLAY(frmMMTY, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmMMTY.Focus()
                    End If
                Case CType("MMGR", Char)
                    If (Not (frmMMGR.IsHandleCreated)) OrElse (IsNothing(frmMMGR)) Then
                        frmMMGR = New MMGR
                        DISPLAY(frmMMGR, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmMMGR.Focus()
                    End If
                Case CType("SLOC", Char)
                    If (Not (frmSLOC.IsHandleCreated)) OrElse (IsNothing(frmSLOC)) Then
                        frmSLOC = New SLOC
                        DISPLAY(frmSLOC, IMAGEDB.Main.ImageLibrary.STORAGE_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmSLOC.Focus()
                    End If
                Case CType("PLNT", Char)
                    If (Not (frmPLNT.IsHandleCreated)) OrElse (IsNothing(frmPLNT)) Then
                        frmPLNT = New PLNT
                        DISPLAY(frmPLNT, IMAGEDB.Main.ImageLibrary.PLANT_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmPLNT.Focus()
                    End If


                    'MANAGEMENT
                Case CType("CCIN", Char)
                    If (Not (frmCCIN.IsHandleCreated)) OrElse (IsNothing(frmCCIN)) Then
                        frmCCIN = New CCIN
                        DISPLAY(frmCCIN, IMAGEDB.Main.ImageLibrary.CCIN_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmCCIN.Focus()
                    End If
                Case CType("CDIN", Char)
                    If (Not (frmCDIN.IsHandleCreated)) OrElse (IsNothing(frmCDIN)) Then
                        frmCDIN = New CDIN
                        DISPLAY(frmCDIN, IMAGEDB.Main.ImageLibrary.CDIN_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmCDIN.Focus()
                    End If
                Case CType("EPLS", Char)
                    If (Not (frmEPLS.IsHandleCreated)) OrElse (IsNothing(frmEPLS)) Then
                        frmEPLS = New EPLS
                        DISPLAY(frmEPLS, IMAGEDB.Main.ImageLibrary.EPLS_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmEPLS.Focus()
                    End If
                Case CType("POST", Char)
                    If (Not (frmPOST.IsHandleCreated)) OrElse (IsNothing(frmPOST)) Then
                        frmPOST = New POST
                        DISPLAY(frmPOST, IMAGEDB.Main.ImageLibrary.POST_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmPOST.Focus()
                    End If


                    'CUSTOM
                Case CType("DAR", Char)
                    If (Not (frmDAR.IsHandleCreated)) OrElse (IsNothing(frmDAR)) Then
                        frmDAR = New DAR
                        DISPLAY(frmDAR, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmDAR.Focus()
                    End If
                Case CType("DARD", Char)
                    If (Not (frmDARD.IsHandleCreated)) OrElse (IsNothing(frmDARD)) Then
                        frmDARD = New DARD
                        DISPLAY(frmDARD, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmDAR.Focus()
                    End If
                Case CType("DRTM", Char)
                    If (Not (frmDRTM.IsHandleCreated)) OrElse (IsNothing(frmDRTM)) Then
                        frmDRTM = New DRTM
                        DISPLAY(frmDRTM, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmDRTM.Focus()
                    End If
                Case CType("DRAA", Char)
                    If (Not (frmDRAA.IsHandleCreated)) OrElse (IsNothing(frmDRAA)) Then
                        frmDRAA = New DRAA
                        DISPLAY(frmDRAA, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmDRAA.Focus()
                    End If
                Case CType("PEPR", Char)
                    If (Not (frmPEPR.IsHandleCreated)) OrElse (IsNothing(frmPEPR)) Then
                        frmPEPR = New PEPR
                        DISPLAY(frmPEPR, IMAGEDB.Main.ImageLibrary.JJP_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmREMS.Focus()
                    End If
                Case CType("REMS", Char)
                    If (Not (frmREMS.IsHandleCreated)) OrElse (IsNothing(frmREMS)) Then
                        frmREMS = New REMS
                        DISPLAY(frmREMS, IMAGEDB.Main.ImageLibrary.JJP_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmREMS.Focus()
                    End If
                Case CType("SAY", Char)
                    If (Not (frmSAY.IsHandleCreated)) OrElse (IsNothing(frmSAY)) Then
                        frmSAY = New SAY
                        DISPLAY(frmSAY, IMAGEDB.Main.ImageLibrary.PLANT_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False,)
                    Else
                        frmCCIN.Focus()
                    End If


                    'SYSTEM
                Case CType("MODS", Char)
                    If (Not (frmMODS.IsHandleCreated)) OrElse (IsNothing(frmMODS)) Then
                        frmMODS = New MODS
                        DISPLAY(frmMODS, IMAGEDB.Main.ImageLibrary.MODS_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmMODS.Focus()
                    End If
                Case CType("MOGS", Char)
                    If (Not (frmMOGS.IsHandleCreated)) OrElse (IsNothing(frmMOGS)) Then
                        frmMOGS = New MOGS
                        DISPLAY(frmMOGS, IMAGEDB.Main.ImageLibrary.MODS_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmMOGS.Focus()
                    End If
                Case CType("UAC", Char)
                    If (Not (frmUAC.IsHandleCreated)) OrElse (IsNothing(frmUAC)) Then
                        frmUAC = New UAC
                        DISPLAY(frmUAC, IMAGEDB.Main.ImageLibrary.UAC_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmUAC.Focus()
                    End If
                Case CType("SYSS", Char)
                    If (Not (frmSYSS.IsHandleCreated)) OrElse (IsNothing(frmSYSS)) Then
                        frmSYSS = New SYSS
                        DISPLAY(frmSYSS, IMAGEDB.Main.ImageLibrary.UAC_ICON, "[" & varTCode.ToUpper & "] " & varMODname, varMODdescription, False, Mainframe)
                    Else
                        frmSYSS.Focus()
                    End If


                 'INSIDE APPS
                Case CType("DUMMY", Char)
                    If (Not (frmDUMMY.IsHandleCreated)) OrElse (IsNothing(frmDUMMY)) Then
                        frmDUMMY = New Dummy
                        DISPLAY(frmDUMMY, IMAGEDB.Main.ImageLibrary.DUMMY_ICON, "[DUMMY] Dummy Form", "Dummy Form for testing", False, Mainframe)
                    Else
                        frmDUMMY.Focus()
                    End If
                Case CType("PHTRZ", Char)
                    If (Not (frmDUMMY.IsHandleCreated)) OrElse (IsNothing(frmDUMMY)) Then
                        frmPhotoresize = New CMCv.PHTRZ
                        DISPLAY(frmPhotoresize, IMAGEDB.Main.ImageLibrary.COMPRESS_ICON, varMODname, varMODdescription, True,)
                    Else
                        frmPhotoresize.Focus()
                    End If

                Case CType("RESET", Char)
                    If (Not (frmRESET.IsHandleCreated)) OrElse (IsNothing(frmRESET)) Then
                        frmRESET = New RESET
                        DISPLAY(frmRESET, IMAGEDB.Main.ImageLibrary.RESET_ICON, "[RESET] Reset Your Application Settings", "Restore your application to initial configuration", True,)
                    Else
                        frmRESET.Focus()
                    End If
            End Select

        Catch ex As Exception
            Call PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, 0.ToString, ex.StackTrace, GETAPPVERSION, , True, True)
            Call PUSHERRORDATASHOW()
        End Try
    End Sub

    Private Shared Sub V_MODS_DATACHANGED() Handles frmMODS.DATACHANGED
        varForcerefreshmainframedata = True
    End Sub
End Class