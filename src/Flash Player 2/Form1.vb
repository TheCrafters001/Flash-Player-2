Imports Vlc
Imports AxWMPLib
Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Forms
Imports Vlc.DotNet.Forms.VlcControl
Imports Vlc.DotNet.Wpf.VlcControl
Imports Vlc.DotNet.Wpf
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        About.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentAssembly = Assembly.GetEntryAssembly()
        Dim currentDirectory = New FileInfo(currentAssembly.Location).DirectoryName
        Media_Player.VlcControl1.VlcLibDirectory = New DirectoryInfo(Path.Combine(currentDirectory, "libvlc", If(IntPtr.Size = 4, "win-x86", "win-x64")))
        Media_Player.Show()
        Me.Close()
    End Sub
End Class
