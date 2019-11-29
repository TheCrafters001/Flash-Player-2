Imports AxWMPLib
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        About.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Media_Player.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Flash_Player.Show()
        Me.Close()
    End Sub
End Class
