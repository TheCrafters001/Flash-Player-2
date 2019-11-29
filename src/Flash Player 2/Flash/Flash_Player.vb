Public Class Flash_Player
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Flash Games (*.swf)|*.swf"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        AxShockwaveFlash1.Movie = OpenFileDialog1.FileName()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub CloseGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseGameToolStripMenuItem.Click
        AxShockwaveFlash1.Movie = Nothing
        AxShockwaveFlash1.EmbedMovie = Nothing
        AxShockwaveFlash1.Playing = False
    End Sub
End Class