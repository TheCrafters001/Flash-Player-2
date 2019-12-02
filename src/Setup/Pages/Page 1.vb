Public Class Page_1
    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If AllUsers_Rad.Checked = True Then
            My.Settings.User_Type = "users_all"
        ElseIf JustMe_Rad.Checked = True Then
            My.Settings.User_Type = "user_me"
        Else
            MessageBox.Show("There was an error. The setup will now close", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            exit_failed.Show()
            Me.Close()
        End If
        Page_2.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Dim cancel_message As DialogResult = MessageBox.Show("Are you sure you want to exit the installer?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cancel_message = DialogResult.Yes Then
            End
        Else
            'Do nothing
        End If
    End Sub
End Class