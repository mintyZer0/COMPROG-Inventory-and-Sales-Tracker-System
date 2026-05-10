<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POSWindow
    Inherits MaterialSkin.Controls.MaterialForm

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        posControl = New uc_POS()
        btnLogOut = New Button()
        SuspendLayout()
        ' 
        ' posControl
        ' 
        posControl.Dock = DockStyle.Fill
        posControl.Location = New Point(3, 64)
        posControl.Margin = New Padding(0)
        posControl.MinimumSize = New Size(825, 471)
        posControl.Name = "posControl"
        posControl.Size = New Size(1018, 533)
        posControl.TabIndex = 0
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.Font = New Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.Location = New Point(879, 27)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(128, 34)
        btnLogOut.TabIndex = 1
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' POSWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1024, 600)
        Controls.Add(btnLogOut)
        Controls.Add(posControl)
        MinimumSize = New Size(1024, 600)
        Name = "POSWindow"
        Text = "Point of Sale"
        ResumeLayout(False)
    End Sub

    Friend WithEvents posControl As uc_POS
    Friend WithEvents btnLogOut As Button
End Class
