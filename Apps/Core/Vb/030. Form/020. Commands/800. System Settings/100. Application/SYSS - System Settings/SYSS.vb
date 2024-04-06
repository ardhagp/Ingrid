﻿Imports System.Runtime.Versioning

Public Class SYSS

    Private _SQL_View As New Commands.SYSS.View
    Private _SQL_Editor As New Commands.SYSS.Editor

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        'Get Profile
        With CboProfile.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboProfile.SelectedIndex = Commands.SYSS.View.GETSettingValue("settings_showprofile")

        'Get Storage
        With CboStorage.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboStorage.SelectedIndex = Commands.SYSS.View.GETSettingValue("settings_showstorage")

        'Get NewsTicker
        With CboNewsTicker.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboNewsTicker.SelectedIndex = Commands.SYSS.View.GETSettingValue("settings_showrunningtext")

        'Get Minimum Photo Upload
        nudUploadPhoto.Value = Commands.SYSS.View.GETSettingValue("settings_uploadphoto")

        'Get Minimum PDF Upload
        nudUploadPDF.Value = Commands.SYSS.View.GETSettingValue("settings_uploadpdf")

        'Get Watermark
        With CboWatermark.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboWatermark.SelectedIndex = Commands.SYSS.View.GETSettingValue("settings_showwatermark")
        TxtWatermark.Text = Commands.SYSS.View.GETSettingValue("settings_textmark")

        'Get Minimum Password
        nudMinPassword.Value = Commands.SYSS.View.GETSettingValue("settings_minpasswordlength")
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub SYSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETDATA()
    End Sub

    Private Sub CboWatermark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboWatermark.SelectedIndexChanged
        If CboWatermark.SelectedIndex = 0 Then
            TxtWatermark.Enabled = False
        Else
            TxtWatermark.Enabled = True
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If (Commands.SYSS.Editor.SaveSettings(CboProfile.SelectedIndex, CboStorage.SelectedIndex, CboNewsTicker.SelectedIndex, nudUploadPhoto.Value, nudUploadPDF.Value, CboWatermark.SelectedIndex, TxtWatermark.XOSQLText, nudMinPassword.Value)) Then
                SLFStatus.Items(0).Text = "Saved"
            End If
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
