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

        Using login As New Login()
            If login.ShowDialog() = DialogResult.OK Then
                Me.Show()
            Else
                Application.Exit()
            End If
        End Using

    End Sub
End Class