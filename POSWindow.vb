Imports MaterialSkin
Imports System.ComponentModel

Public Class POSWindow
    Private _shouldLogout As Boolean

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    <Browsable(False)>
    Public ReadOnly Property ShouldLogout As Boolean
        Get
            Return _shouldLogout
        End Get
    End Property

    Private Sub POSWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New ColorScheme(
            ColorTranslator.FromHtml("#1d84b5"),
            ColorTranslator.FromHtml("#0a2239"),
            ColorTranslator.FromHtml("#176087"),
            ColorTranslator.FromHtml("#53a2be"),
            TextShade.WHITE
        )
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result = MaterialConfirmDialog.ShowConfirmation(Me, "Are you sure you want to log out?", "Confirm Logout")
        If result <> DialogResult.Yes Then
            Return
        End If

        _shouldLogout = True
        Close()
    End Sub
End Class
