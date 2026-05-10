Imports MaterialSkin
Imports System.ComponentModel

Public Class MainWindow
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property WasLogout As Boolean = False

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result = MaterialDialog.ShowConfirmation(Me, "Are you sure you want to log out?", "Confirm Logout")
        If result = DialogResult.Yes Then
            WasLogout = True
            Me.Close()
        End If
    End Sub
End Class
