<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtUsername = New MaterialSkin.Controls.MaterialTextBox2()
        txtPassword = New MaterialSkin.Controls.MaterialTextBox2()
        lblUsername = New MaterialSkin.Controls.MaterialLabel()
        lblPassword = New MaterialSkin.Controls.MaterialLabel()
        lblSystem = New MaterialSkin.Controls.MaterialLabel()
        btnLogin = New MaterialSkin.Controls.MaterialButton()
        cmbSystem = New MaterialSkin.Controls.MaterialComboBox()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.AnimateReadOnly = False
        txtUsername.BackgroundImageLayout = ImageLayout.None
        txtUsername.CharacterCasing = CharacterCasing.Normal
        txtUsername.Depth = 0
        txtUsername.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtUsername.HideSelection = True
        txtUsername.LeadingIcon = Nothing
        txtUsername.Location = New Point(309, 152)
        txtUsername.MaxLength = 32767
        txtUsername.MouseState = MaterialSkin.MouseState.OUT
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PrefixSuffixText = Nothing
        txtUsername.ReadOnly = False
        txtUsername.RightToLeft = RightToLeft.No
        txtUsername.SelectedText = ""
        txtUsername.SelectionLength = 0
        txtUsername.SelectionStart = 0
        txtUsername.ShortcutsEnabled = True
        txtUsername.Size = New Size(250, 36)
        txtUsername.TabIndex = 5
        txtUsername.TabStop = False
        txtUsername.TextAlign = HorizontalAlignment.Left
        txtUsername.TrailingIcon = Nothing
        txtUsername.UseSystemPasswordChar = False
        txtUsername.UseTallSize = False
        ' 
        ' txtPassword
        ' 
        txtPassword.AnimateReadOnly = False
        txtPassword.BackgroundImageLayout = ImageLayout.None
        txtPassword.CharacterCasing = CharacterCasing.Normal
        txtPassword.Depth = 0
        txtPassword.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPassword.HideSelection = True
        txtPassword.LeadingIcon = Nothing
        txtPassword.Location = New Point(309, 203)
        txtPassword.MaxLength = 32767
        txtPassword.MouseState = MaterialSkin.MouseState.OUT
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.PrefixSuffixText = Nothing
        txtPassword.ReadOnly = False
        txtPassword.RightToLeft = RightToLeft.No
        txtPassword.SelectedText = ""
        txtPassword.SelectionLength = 0
        txtPassword.SelectionStart = 0
        txtPassword.ShortcutsEnabled = True
        txtPassword.Size = New Size(250, 36)
        txtPassword.TabIndex = 6
        txtPassword.TabStop = False
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TrailingIcon = Nothing
        txtPassword.UseSystemPasswordChar = True
        txtPassword.UseTallSize = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Depth = 0
        lblUsername.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblUsername.Location = New Point(216, 167)
        lblUsername.MouseState = MaterialSkin.MouseState.HOVER
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(76, 19)
        lblUsername.TabIndex = 7
        lblUsername.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Depth = 0
        lblPassword.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblPassword.Location = New Point(217, 215)
        lblPassword.MouseState = MaterialSkin.MouseState.HOVER
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(75, 19)
        lblPassword.TabIndex = 8
        lblPassword.Text = "Password:"
        ' 
        ' lblSystem
        ' 
        lblSystem.AutoSize = True
        lblSystem.Depth = 0
        lblSystem.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblSystem.Location = New Point(233, 261)
        lblSystem.MouseState = MaterialSkin.MouseState.HOVER
        lblSystem.Name = "lblSystem"
        lblSystem.Size = New Size(58, 19)
        lblSystem.TabIndex = 9
        lblSystem.Text = "System:"
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = False
        btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLogin.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal
        btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnLogin.Depth = 0
        btnLogin.HighEmphasis = True
        btnLogin.Icon = Nothing
        btnLogin.Location = New Point(370, 328)
        btnLogin.Margin = New Padding(4, 6, 4, 6)
        btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        btnLogin.Name = "btnLogin"
        btnLogin.NoAccentTextColor = Color.Empty
        btnLogin.Size = New Size(114, 36)
        btnLogin.TabIndex = 9
        btnLogin.Text = "Login"
        btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnLogin.UseAccentColor = False
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' cmbSystem
        ' 
        cmbSystem.AutoResize = False
        cmbSystem.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbSystem.Depth = 0
        cmbSystem.DrawMode = DrawMode.OwnerDrawVariable
        cmbSystem.DropDownHeight = 118
        cmbSystem.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSystem.DropDownWidth = 250
        cmbSystem.Font = New Font("Roboto Medium", 10F, FontStyle.Bold, GraphicsUnit.Pixel)
        cmbSystem.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cmbSystem.FormattingEnabled = True
        cmbSystem.IntegralHeight = False
        cmbSystem.ItemHeight = 29
        cmbSystem.Location = New Point(309, 255)
        cmbSystem.MaxDropDownItems = 4
        cmbSystem.MouseState = MaterialSkin.MouseState.OUT
        cmbSystem.Name = "cmbSystem"
        cmbSystem.Size = New Size(250, 35)
        cmbSystem.StartIndex = 0
        cmbSystem.TabIndex = 10
        cmbSystem.UseTallSize = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmbSystem)
        Controls.Add(btnLogin)
        Controls.Add(lblSystem)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lblUsername As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPassword As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSystem As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmbSystem As MaterialSkin.Controls.MaterialComboBox

End Class
