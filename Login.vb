Imports MaterialSkin

Public Class Login
    Public Enum LoginSystem
        Inventory
        POS
    End Enum

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup MaterialSkin
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

        cmbSystem.Items.Clear()
        cmbSystem.Items.Add("Inventory System")
        cmbSystem.Items.Add("POS System")
        cmbSystem.SelectedIndex = -1
    End Sub

    Private Function IsValidCredentials(username As String, password As String) As Boolean
        Return username = "Lebron" AndAlso password = "James"
    End Function

    Private Function IsAdminCredentials(username As String, password As String) As Boolean
        Return username = "Admin" AndAlso password = "Admin"
    End Function


    Private Function TryGetSelectedSystem(ByRef selectedSystem As LoginSystem) As Boolean
        If cmbSystem.SelectedItem Is Nothing Then
            Return False
        End If

        Select Case cmbSystem.SelectedItem.ToString()
            Case "Inventory System"
                selectedSystem = LoginSystem.Inventory
                Return True
            Case "POS System"
                selectedSystem = LoginSystem.POS
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim selectedSystem As LoginSystem

        If Not TryGetSelectedSystem(selectedSystem) Then
            MessageBox.Show("Please select a system before logging in.", "System Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbSystem.SelectedIndex = -1

        Select Case selectedSystem
            Case LoginSystem.Inventory
                If (IsAdminCredentials(username, password)) Then
                    Dim inventory As New MainWindow()
                    AddHandler inventory.FormClosed, Sub(s, ev)
                                                         If DirectCast(s, MainWindow).WasLogout Then
                                                             Me.Show()
                                                         Else
                                                             Application.Exit()
                                                         End If
                                                     End Sub
                    Me.Hide()
                    inventory.Show()
                Else
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Case LoginSystem.POS
                    If IsValidCredentials(username, password) Then
                        Dim pos As New POSWindow()
                        AddHandler pos.FormClosed, Sub(s, ev)
                                                       If DirectCast(s, POSWindow).WasLogout Then
                                                           Me.Show()
                                                       Else
                                                           Application.Exit()
                                                       End If
                                                   End Sub
                        Me.Hide()
                        pos.Show()
                    Else
                        MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
    End Sub

End Class
