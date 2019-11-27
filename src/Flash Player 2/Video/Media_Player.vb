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

' <summary>
' When the Vlc control needs to find the location of the libvlc.dll.
' You could have set the VlcLibDirectory in the designer, but for this sample, we are in AnyCPU mode, And we don't know the process bitness.
' </summary>
' <param name="sender"></param>
' <param name="e"></param>

Public Class Media_Player
    Private Sub Media_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub vlcControl_VlcLibDirectoryNeeded(ByVal sender As Object, ByVal e As Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs)
        Dim currentAssembly = Assembly.GetEntryAssembly()
        Dim currentDirectory = New FileInfo(currentAssembly.Location).DirectoryName
        e.VlcLibDirectory = New DirectoryInfo(Path.Combine(currentDirectory, "libvlc", If(IntPtr.Size = 4, "win-x86", "win-x64")))
    End Sub
End Class