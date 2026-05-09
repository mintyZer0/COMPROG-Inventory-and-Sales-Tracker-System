Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class MaterialConfirmDialog
    Inherits MaterialForm

    Private Sub New(message As String, title As String)
        Text = title
        StartPosition = FormStartPosition.CenterParent
        Sizable = False
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        ClientSize = New Size(420, 240)

        Dim lblMessage As New MaterialLabel() With {
            .AutoSize = False,
            .Location = New Point(20, 78),
            .Size = New Size(380, 72),
            .Text = message
        }

        Dim btnNo As New MaterialButton() With {
            .AutoSize = False,
            .Size = New Size(88, 36),
            .Location = New Point(312, 174),
            .Text = "No",
            .Type = MaterialButton.MaterialButtonType.Contained
        }

        Dim btnYes As New MaterialButton() With {
            .AutoSize = False,
            .Size = New Size(88, 36),
            .Location = New Point(216, 174),
            .Text = "Yes",
            .Type = MaterialButton.MaterialButtonType.Contained
        }

        AddHandler btnNo.Click, Sub()
                                    DialogResult = DialogResult.No
                                    Close()
                                End Sub
        AddHandler btnYes.Click, Sub()
                                     DialogResult = DialogResult.Yes
                                     Close()
                                 End Sub

        Controls.Add(lblMessage)
        Controls.Add(btnNo)
        Controls.Add(btnYes)

        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
    End Sub

    Public Shared Function ShowConfirmation(owner As IWin32Window, message As String, title As String) As DialogResult
        Using dialog As New MaterialConfirmDialog(message, title)
            Return dialog.ShowDialog(owner)
        End Using
    End Function
End Class
