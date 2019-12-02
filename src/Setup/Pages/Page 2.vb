Public Class Page_2
    Private Sub Page_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.User_Type = "users_all" Then
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
            TextBox1.Text += "\TheCrafters001\Flash Player\2\"
        ElseIf My.Settings.User_Type = "user_me" Then
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            TextBox1.Text += "\Programs\TheCrafters001\Flash Player\2\"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        If Not FolderBrowserDialog1.SelectedPath = "" Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
            TextBox1.Text += "\TheCrafters001\Flash Player\2\"
        End If
    End Sub

    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Dim cancel_message As DialogResult = MessageBox.Show("Are you sure you want to exit the installer?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cancel_message = DialogResult.Yes Then
            End
        Else
            'Do nothing
        End If
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Cannot move forward with install. No Install Location Selected.")
        Else
            My.Settings.folder = TextBox1.Text
            Page3.Show()
            Me.Close()
        End If
    End Sub
End Class