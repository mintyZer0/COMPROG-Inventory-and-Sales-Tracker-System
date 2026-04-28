Public Class MainWindow
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()

        Using login As New Login()
            If login.ShowDialog() = DialogResult.OK Then
                Me.Show()
            Else
                Application.Exit()
            End If
        End Using

    End Sub
End Class