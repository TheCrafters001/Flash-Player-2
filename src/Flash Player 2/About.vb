Imports AutoUpdaterDotNET

Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label4.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

        ' Gather Info To Set Title
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        ' Set the Title of the Form.
        Me.Text = String.Format("About {0}", ApplicationTitle)

        ' Product Info Section
        Me.Label1.Text = My.Application.Info.ProductName
        Me.Label2.Text = My.Application.Info.Copyright

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AutoUpdater.ShowSkipButton = False
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(554, 489)
        AutoUpdater.Start("http://api.thecrafters001.ga/updates/Flash_Two.xml")
    End Sub
End Class