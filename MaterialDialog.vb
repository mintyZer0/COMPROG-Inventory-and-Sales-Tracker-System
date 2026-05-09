Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class MaterialDialog
    Inherits MaterialSkin.Controls.MaterialForm

    Public Sub New()        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        DialogResult = DialogResult.No
        Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        DialogResult = DialogResult.Yes
        Close()
    End Sub

    Public Shared Function ShowConfirmation(owner As IWin32Window, message As String, title As String, 
                                          Optional yesText As String = "Yes", 
                                          Optional noText As String = "No",
                                          Optional dialogSize As Size = Nothing) As DialogResult
        Using dialog As New MaterialDialog()
            dialog.Text = title
            dialog.lblMessage.Text = message
            dialog.btnYes.Text = yesText
            dialog.btnNo.Text = noText
            
            If dialogSize <> Nothing Then
                dialog.ClientSize = dialogSize
                ' Reposition buttons to bottom right based on new size
                dialog.btnNo.Location = New Point(dialog.ClientSize.Width - 108, dialog.ClientSize.Height - 66)
                dialog.btnYes.Location = New Point(dialog.ClientSize.Width - 204, dialog.ClientSize.Height - 66)
                ' Resize message label to fit
                dialog.lblMessage.Size = New Size(dialog.ClientSize.Width - 40, dialog.ClientSize.Height - 168)
            End If
            
            Return dialog.ShowDialog(owner)
        End Using
    End Function
End Class
