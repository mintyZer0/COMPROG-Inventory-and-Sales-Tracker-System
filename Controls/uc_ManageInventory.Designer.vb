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
        lvInventoryDataGrid = New uc_DataGrid()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        MaterialCard1.SuspendLayout()
        MaterialCard2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnAddProduct.Depth = 0
        btnAddProduct.HighEmphasis = True
        btnAddProduct.Icon = Nothing
        btnAddProduct.Location = New Point(659, 32)
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
        txtProdName.Location = New Point(19, 27)
        txtProdName.MaxLength = 50
        txtProdName.MouseState = MaterialSkin.MouseState.OUT
        txtProdName.Multiline = False
        txtProdName.Name = "txtProdName"
        txtProdName.Size = New Size(169, 50)
        txtProdName.TabIndex = 1
        txtProdName.Text = ""
        txtProdName.TrailingIcon = Nothing
        ' 
        ' txtPrice
        ' 
        txtPrice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPrice.AnimateReadOnly = False
        txtPrice.BorderStyle = BorderStyle.None
        txtPrice.Depth = 0
        txtPrice.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPrice.LeadingIcon = Nothing
        txtPrice.Location = New Point(211, 27)
        txtPrice.MaxLength = 50
        txtPrice.MouseState = MaterialSkin.MouseState.OUT
        txtPrice.Multiline = False
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(192, 50)
        txtPrice.TabIndex = 2
        txtPrice.Text = ""
        txtPrice.TrailingIcon = Nothing
        ' 
        ' txtStock
        ' 
        txtStock.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtStock.AnimateReadOnly = False
        txtStock.BorderStyle = BorderStyle.None
        txtStock.Depth = 0
        txtStock.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtStock.LeadingIcon = Nothing
        txtStock.Location = New Point(430, 27)
        txtStock.MaxLength = 50
        txtStock.MouseState = MaterialSkin.MouseState.OUT
        txtStock.Multiline = False
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(215, 50)
        txtStock.TabIndex = 3
        txtStock.Text = ""
        txtStock.TrailingIcon = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel1.Location = New Point(17, 5)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(129, 24)
        MaterialLabel1.TabIndex = 4
        MaterialLabel1.Text = "Product Name"
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel2.Location = New Point(211, 5)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(47, 24)
        MaterialLabel2.TabIndex = 5
        MaterialLabel2.Text = "Price"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel3.Location = New Point(430, 5)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(51, 24)
        MaterialLabel3.TabIndex = 6
        MaterialLabel3.Text = "Stock"
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.AutoSize = False
        btnEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnEdit.Depth = 0
        btnEdit.HighEmphasis = True
        btnEdit.Icon = Nothing
        btnEdit.Location = New Point(659, 104)
        btnEdit.Margin = New Padding(4, 6, 4, 6)
        btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        btnEdit.Name = "btnEdit"
        btnEdit.NoAccentTextColor = Color.Empty
        btnEdit.Size = New Size(121, 36)
        btnEdit.TabIndex = 7
        btnEdit.Text = "Edit"
        btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnEdit.UseAccentColor = False
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSearchProduct
        ' 
        btnSearchProduct.AutoSize = False
        btnSearchProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSearchProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSearchProduct.Depth = 0
        btnSearchProduct.HighEmphasis = True
        btnSearchProduct.Icon = Nothing
        btnSearchProduct.Location = New Point(286, 109)
        btnSearchProduct.Margin = New Padding(4, 6, 4, 6)
        btnSearchProduct.MouseState = MaterialSkin.MouseState.HOVER
        btnSearchProduct.Name = "btnSearchProduct"
        btnSearchProduct.NoAccentTextColor = Color.Empty
        btnSearchProduct.Size = New Size(121, 36)
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
        MaterialLabel4.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel4.Location = New Point(17, 80)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(138, 24)
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
        txtSearch.Location = New Point(19, 104)
        txtSearch.MaxLength = 50
        txtSearch.MouseState = MaterialSkin.MouseState.OUT
        txtSearch.Multiline = False
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(233, 50)
        txtSearch.TabIndex = 10
        txtSearch.Text = ""
        txtSearch.TrailingIcon = Nothing
        ' 
        ' lvInventoryDataGrid
        ' 
        lvInventoryDataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvInventoryDataGrid.Location = New Point(17, 17)
        lvInventoryDataGrid.Name = "lvInventoryDataGrid"
        lvInventoryDataGrid.Size = New Size(763, 230)
        lvInventoryDataGrid.TabIndex = 11
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(lvInventoryDataGrid)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 193)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(797, 264)
        MaterialCard1.TabIndex = 0
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(txtPrice)
        MaterialCard2.Controls.Add(btnEdit)
        MaterialCard2.Controls.Add(btnAddProduct)
        MaterialCard2.Controls.Add(txtSearch)
        MaterialCard2.Controls.Add(txtProdName)
        MaterialCard2.Controls.Add(MaterialLabel4)
        MaterialCard2.Controls.Add(txtStock)
        MaterialCard2.Controls.Add(btnSearchProduct)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Controls.Add(MaterialLabel2)
        MaterialCard2.Controls.Add(MaterialLabel3)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(14, 12)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(797, 170)
        MaterialCard2.TabIndex = 11
        ' 
        ' uc_ManageInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard1)
        Controls.Add(MaterialCard2)
        Name = "uc_ManageInventory"
        Size = New Size(825, 471)
        MaterialCard1.ResumeLayout(False)
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents lvInventoryDataGrid As uc_DataGrid
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard

End Class
