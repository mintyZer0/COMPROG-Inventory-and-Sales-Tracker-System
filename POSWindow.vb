Imports MaterialSkin
Imports System.ComponentModel

Public Class POSWindow
    Public Property WasLogout As Boolean = False

    Private Sub POSWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result = MaterialDialog.ShowConfirmation(Me, "Are you sure you want to log out?", "Confirm Logout")
        If result = DialogResult.Yes Then
            WasLogout = True
            Me.Close()
        End If
    End Sub
End Class
