Public Class Page3
    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Dim cancel_message As DialogResult = MessageBox.Show("Are you sure you want to exit the installer?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cancel_message = DialogResult.Yes Then
            End
        Else
            'Do nothing
        End If
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        Page_4.Show()
        Me.Close()
    End Sub
End Class