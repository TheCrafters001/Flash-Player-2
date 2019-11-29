Public Class MediaPlayer_Controls

    Private Sub MediaPlayer_Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = Media_Player.AxWindowsMediaPlayer1.settings.volume
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = TrackBar1.Value
        Media_Player.AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        Label1.Text = String.Format("Volume: {0}%", ((ProgressBar1.Value / ProgressBar1.Maximum) * 100).ToString("F2"))
        If Media_Player.AxWindowsMediaPlayer1.URL = "" Then

        ElseIf Not Media_Player.AxWindowsMediaPlayer1.URL = "" Then
            ProgressBar2.Maximum = Media_Player.AxWindowsMediaPlayer1.currentMedia.duration
            ProgressBar2.Value = Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            TrackBar2.Value = Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            TrackBar2.Maximum = Media_Player.AxWindowsMediaPlayer1.currentMedia.duration
            ProgressBar2.Increment(1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Media_Player.AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub
End Class