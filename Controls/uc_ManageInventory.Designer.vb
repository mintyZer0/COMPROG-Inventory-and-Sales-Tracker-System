<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_ManageInventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        btnAddProduct = New MaterialSkin.Controls.MaterialButton()
        txtProdName = New MaterialSkin.Controls.MaterialTextBox()
        txtPrice = New MaterialSkin.Controls.MaterialTextBox()
        txtStock = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        btnEdit = New MaterialSkin.Controls.MaterialButton()
        btnSearchProduct = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        txtSearch = New MaterialSkin.Controls.MaterialTextBox()
        InventoryDataGrid = New uc_DataGrid()
        SuspendLayout()
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAddProduct.Depth = 0
        btnAddProduct.HighEmphasis = True
        btnAddProduct.Icon = Nothing
        btnAddProduct.Location = New Point(416, 34)
        btnAddProduct.Margin = New Padding(4, 6, 4, 6)
        btnAddProduct.MouseState = MaterialSkin.MouseState.HOVER
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.NoAccentTextColor = Color.Empty
        btnAddProduct.Size = New Size(121, 36)
        btnAddProduct.TabIndex = 0
        btnAddProduct.Text = "Add Product"
        btnAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnAddProduct.UseAccentColor = False
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' txtProdName
        ' 
        txtProdName.AnimateReadOnly = False
        txtProdName.BorderStyle = BorderStyle.None
        txtProdName.Depth = 0
        txtProdName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtProdName.LeadingIcon = Nothing
        txtProdName.Location = New Point(42, 34)
        txtProdName.MaxLength = 50
        txtProdName.MouseState = MaterialSkin.MouseState.OUT
        txtProdName.Multiline = False
        txtProdName.Name = "txtProdName"
        txtProdName.Size = New Size(100, 50)
        txtProdName.TabIndex = 1
        txtProdName.Text = ""
        txtProdName.TrailingIcon = Nothing
        ' 
        ' txtPrice
        ' 
        txtPrice.AnimateReadOnly = False
        txtPrice.BorderStyle = BorderStyle.None
        txtPrice.Depth = 0
        txtPrice.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPrice.LeadingIcon = Nothing
        txtPrice.Location = New Point(175, 34)
        txtPrice.MaxLength = 50
        txtPrice.MouseState = MaterialSkin.MouseState.OUT
        txtPrice.Multiline = False
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 50)
        txtPrice.TabIndex = 2
        txtPrice.Text = ""
        txtPrice.TrailingIcon = Nothing
        ' 
        ' txtStock
        ' 
        txtStock.AnimateReadOnly = False
        txtStock.BorderStyle = BorderStyle.None
        txtStock.Depth = 0
        txtStock.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtStock.LeadingIcon = Nothing
        txtStock.Location = New Point(303, 34)
        txtStock.MaxLength = 50
        txtStock.MouseState = MaterialSkin.MouseState.OUT
        txtStock.Multiline = False
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 50)
        txtStock.TabIndex = 3
        txtStock.Text = ""
        txtStock.TrailingIcon = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(17, 12)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(102, 19)
        MaterialLabel1.TabIndex = 4
        MaterialLabel1.Text = "Product Name"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(149, 12)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(36, 19)
        MaterialLabel2.TabIndex = 5
        MaterialLabel2.Text = "Price"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(284, 12)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(41, 19)
        MaterialLabel3.TabIndex = 6
        MaterialLabel3.Text = "Stock"
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnEdit.Depth = 0
        btnEdit.HighEmphasis = True
        btnEdit.Icon = Nothing
        btnEdit.Location = New Point(473, 111)
        btnEdit.Margin = New Padding(4, 6, 4, 6)
        btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        btnEdit.Name = "btnEdit"
        btnEdit.NoAccentTextColor = Color.Empty
        btnEdit.Size = New Size(64, 36)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit"
        btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnEdit.UseAccentColor = False
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSearchProduct
        ' 
        btnSearchProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearchProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearchProduct.Depth = 0
        btnSearchProduct.HighEmphasis = True
        btnSearchProduct.Icon = Nothing
        btnSearchProduct.Location = New Point(175, 111)
        btnSearchProduct.Margin = New Padding(4, 6, 4, 6)
        btnSearchProduct.MouseState = MaterialSkin.MouseState.HOVER
        btnSearchProduct.Name = "btnSearchProduct"
        btnSearchProduct.NoAccentTextColor = Color.Empty
        btnSearchProduct.Size = New Size(64, 36)
        btnSearchProduct.TabIndex = 8
        btnSearchProduct.Text = "Find"
        btnSearchProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSearchProduct.UseAccentColor = False
        btnSearchProduct.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(17, 87)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(109, 19)
        MaterialLabel4.TabIndex = 9
        MaterialLabel4.Text = "Search Product"
        ' 
        ' txtSearch
        ' 
        txtSearch.AnimateReadOnly = False
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Depth = 0
        txtSearch.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtSearch.LeadingIcon = Nothing
        txtSearch.Location = New Point(42, 111)
        txtSearch.MaxLength = 50
        txtSearch.MouseState = MaterialSkin.MouseState.OUT
        txtSearch.Multiline = False
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 50)
        txtSearch.TabIndex = 10
        txtSearch.Text = ""
        txtSearch.TrailingIcon = Nothing
        ' 
        ' InventoryDataGrid
        ' 
        InventoryDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        InventoryDataGrid.Location = New Point(3, 189)
        InventoryDataGrid.Name = "InventoryDataGrid"
        InventoryDataGrid.Size = New Size(630, 173)
        InventoryDataGrid.TabIndex = 11
        ' 
        ' uc_ManageInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(InventoryDataGrid)
        Controls.Add(txtSearch)
        Controls.Add(MaterialLabel4)
        Controls.Add(btnSearchProduct)
        Controls.Add(btnEdit)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(txtProdName)
        Controls.Add(btnAddProduct)
        Name = "uc_ManageInventory"
        Size = New Size(636, 374)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddProduct As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtProdName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPrice As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtStock As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSearchProduct As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSearch As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents InventoryDataGrid As uc_DataGrid

End Class
