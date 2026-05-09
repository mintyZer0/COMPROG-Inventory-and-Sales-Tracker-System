Imports MaterialSkin

Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(
            ColorTranslator.FromHtml("#1d84b5"),
            ColorTranslator.FromHtml("#0a2239"),
            ColorTranslator.FromHtml("#176087"),
            ColorTranslator.FromHtml("#53a2be"),
            TextShade.WHITE
            )
        Me.Hide()

        LoginUser()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result = MaterialConfirmDialog.ShowConfirmation(Me, "Are you sure you want to log out?", "Confirm Logout")
        If result <> DialogResult.Yes Then
            Return
        End If

        Me.Hide()
        LoginUser()

    End Sub

    Private Sub LoginUser()
        Do
            Using login As New Login
                If login.ShowDialog() <> DialogResult.OK Then
                    Application.Exit()
                    Exit Sub
                End If

                If Not login.SelectedSystem.HasValue Then
                    Continue Do
                End If

                Select Case login.SelectedSystem.Value
                    Case Login.LoginSystem.Inventory
                        Me.Show()
                        Exit Sub
                    Case Login.LoginSystem.POS
                        Me.Hide()
                        Using posWindow As New POSWindow
                            posWindow.ShowDialog()
                            If Not posWindow.ShouldLogout Then
                                Application.Exit()
                                Exit Sub
                            End If
                        End Using
                End Select
            End Using
        Loop
    End Sub
End Class
