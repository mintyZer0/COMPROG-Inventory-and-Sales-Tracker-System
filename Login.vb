Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = "Lebron"
        Dim password As String = "James"
    End Sub

    Private Function IsValidCredentials(username As String, password As String) As Boolean
        Return username = "Lebron" AndAlso password = "James"
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        If IsValidCredentials(username, password) Then
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
