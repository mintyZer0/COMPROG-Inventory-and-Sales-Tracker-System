<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        txtNewProdName = New MaterialSkin.Controls.MaterialTextBox()
        btnEdit = New MaterialSkin.Controls.MaterialButton()
        txtNewPrice = New MaterialSkin.Controls.MaterialTextBox()
        txtNewStock = New MaterialSkin.Controls.MaterialTextBox()
        SuspendLayout()
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(435, 40)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(76, 19)
        MaterialLabel3.TabIndex = 12
        MaterialLabel3.Text = "New Stock"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(268, 40)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(71, 19)
        MaterialLabel2.TabIndex = 11
        MaterialLabel2.Text = "New Price"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(50, 40)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(137, 19)
        MaterialLabel1.TabIndex = 10
        MaterialLabel1.Text = "New Product Name"
        ' 
        ' txtNewProdName
        ' 
        txtNewProdName.AnimateReadOnly = False
        txtNewProdName.BorderStyle = BorderStyle.None
        txtNewProdName.Depth = 0
        txtNewProdName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNewProdName.LeadingIcon = Nothing
        txtNewProdName.Location = New Point(50, 88)
        txtNewProdName.MaxLength = 50
        txtNewProdName.MouseState = MaterialSkin.MouseState.OUT
        txtNewProdName.Multiline = False
        txtNewProdName.Name = "txtNewProdName"
        txtNewProdName.Size = New Size(144, 50)
        txtNewProdName.TabIndex = 7
        txtNewProdName.Text = ""
        txtNewProdName.TrailingIcon = Nothing
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnEdit.Depth = 0
        btnEdit.HighEmphasis = True
        btnEdit.Icon = Nothing
        btnEdit.Location = New Point(231, 192)
        btnEdit.Margin = New Padding(4, 6, 4, 6)
        btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        btnEdit.Name = "btnEdit"
        btnEdit.NoAccentTextColor = Color.Empty
        btnEdit.Size = New Size(128, 36)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Finish Editing"
        btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnEdit.UseAccentColor = False
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtNewPrice
        ' 
        txtNewPrice.AnimateReadOnly = False
        txtNewPrice.BorderStyle = BorderStyle.None
        txtNewPrice.Depth = 0
        txtNewPrice.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNewPrice.LeadingIcon = Nothing
        txtNewPrice.Location = New Point(231, 88)
        txtNewPrice.MaxLength = 50
        txtNewPrice.MouseState = MaterialSkin.MouseState.OUT
        txtNewPrice.Multiline = False
        txtNewPrice.Name = "txtNewPrice"
        txtNewPrice.Size = New Size(144, 50)
        txtNewPrice.TabIndex = 14
        txtNewPrice.Text = ""
        txtNewPrice.TrailingIcon = Nothing
        ' 
        ' txtNewStock
        ' 
        txtNewStock.AnimateReadOnly = False
        txtNewStock.BorderStyle = BorderStyle.None
        txtNewStock.Depth = 0
        txtNewStock.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNewStock.LeadingIcon = Nothing
        txtNewStock.Location = New Point(408, 88)
        txtNewStock.MaxLength = 50
        txtNewStock.MouseState = MaterialSkin.MouseState.OUT
        txtNewStock.Multiline = False
        txtNewStock.Name = "txtNewStock"
        txtNewStock.Size = New Size(144, 50)
        txtNewStock.TabIndex = 15
        txtNewStock.Text = ""
        txtNewStock.TrailingIcon = Nothing
        ' 
        ' InventoryEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 301)
        Controls.Add(txtNewStock)
        Controls.Add(txtNewPrice)
        Controls.Add(btnEdit)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(txtNewProdName)
        Name = "InventoryEdit"
        Text = "InventoryEdit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNewProdName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtNewPrice As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNewStock As MaterialSkin.Controls.MaterialTextBox
End Class
