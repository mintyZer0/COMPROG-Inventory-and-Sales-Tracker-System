<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MaterialDialog

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.lblMessage = New MaterialSkin.Controls.MaterialLabel()
        Me.btnNo = New MaterialSkin.Controls.MaterialButton()
        Me.btnYes = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = False
        Me.lblMessage.Depth = 0
        Me.lblMessage.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMessage.Location = New System.Drawing.Point(20, 78)
        Me.lblMessage.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(380, 72)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Message"
        '
        'btnNo
        '
        Me.btnNo.AutoSize = False
        Me.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        Me.btnNo.Depth = 0
        Me.btnNo.HighEmphasis = True
        Me.btnNo.Icon = Nothing
        Me.btnNo.Location = New System.Drawing.Point(312, 174)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNo.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNo.Name = "btnNo"
        Me.btnNo.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnNo.Size = New System.Drawing.Size(88, 36)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "No"
        Me.btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnNo.UseAccentColor = False
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.AutoSize = False
        Me.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        Me.btnYes.Depth = 0
        Me.btnYes.HighEmphasis = True
        Me.btnYes.Icon = Nothing
        Me.btnYes.Location = New System.Drawing.Point(216, 174)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnYes.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnYes.Name = "btnYes"
        Me.btnYes.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnYes.Size = New System.Drawing.Size(88, 36)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        Me.btnYes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnYes.UseAccentColor = False
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'MaterialConfirmDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 240)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblMessage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaterialConfirmDialog"
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnNo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnYes As MaterialSkin.Controls.MaterialButton
End Class
