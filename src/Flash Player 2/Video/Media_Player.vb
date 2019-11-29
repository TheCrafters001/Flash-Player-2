Imports AxWMPLib
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Public Class Media_Player
    Private Sub Media_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "All Supported Formats (.asf, .wma, .wmv, .wm, .asx, .wax, .wvx, .wmx, .wpl, .dvr-ms, .wmd, .avi, .mpg, .mpeg, .m1v, .mp2, .mp3, .mpa, .mpe, .m3u, .mid, .midi, .rmi, .aif, .aifc, .aiff, .au, .snd, .wav, .cda, .ivf, .mov, .m4a, .mp4, .m4v, .mp4v, .3g2, .3gp2, .3gp, .3gpp, .aac, .adt, .adts, .m2ts, .flac)|*.asf;*.wma;*.wmv;*.wm;*.asx;*.wax;*.wvx;*.wmx;*.wpl;*.dvr-ms;*.wmd;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;*.au;*.snd;*.wav;*.cda;*.ivf;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.aac;*.adt;*.adts;*.m2ts;*.flac"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName()
    End Sub
End Class