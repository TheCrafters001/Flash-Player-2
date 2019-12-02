Public Class Page5
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Private Sub Page5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Public Sub ShellandWait(ByVal ProcessPath As String, ByVal Arguments As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.Arguments = Arguments
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            exit_failed.Show()
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
            Me.Close()
        End Try
    End Sub


    Public Sub Install_Now()
        If ProgressBar2.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Increment(50)
            Label3.Text = "Installing Program..."
            Dim arguments_pass As String
            If My.Settings.User_Type = "users_all" Then
                arguments_pass = "/ALLUSERS "
                arguments_pass &= "/DIR=""" + My.Settings.folder.ToString + """ /SILENT"
            ElseIf My.Settings.User_Type = "user_me" Then
                arguments_pass = "/CURRENTUSER "
                arguments_pass &= "/DIR=""" + My.Settings.folder.ToString + """ /SILENT"
            End If
            ShellandWait("setup_full_real.exe", arguments_pass.ToString)
            ProgressBar1.Increment(49)
            Label3.Text = "Opening Website..."
            Process.Start("https://thecrafters001.ga/software/flash_two.html")
            ProgressBar1.Increment(1)
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Increment(5)
        Install_Now()
    End Sub
End Class