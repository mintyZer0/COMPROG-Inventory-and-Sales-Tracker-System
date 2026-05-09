Public Class Login
    Public Enum LoginSystem
        Inventory
        POS
    End Enum

    Private _selectedSystem As LoginSystem?

    Public ReadOnly Property SelectedSystem As LoginSystem?
        Get
            Return _selectedSystem
        End Get
    End Property

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSystem.Items.Clear()
        cmbSystem.Items.Add("Inventory System")
        cmbSystem.Items.Add("POS System")
        cmbSystem.SelectedIndex = -1
    End Sub

    Private Function IsValidCredentials(username As String, password As String) As Boolean
        Return username = "Lebron" AndAlso password = "James"
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

        If IsValidCredentials(username, password) Then
            If Not TryGetSelectedSystem(selectedSystem) Then
                MessageBox.Show("Please select a system before logging in.", "System Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _selectedSystem = selectedSystem
            DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
