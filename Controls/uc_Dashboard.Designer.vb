<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_Dashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        lblTotalRevenue = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        pnlTotalRevenue = New Panel()
        lblTextInventoryCount = New MaterialSkin.Controls.MaterialLabel()
        lblInventoryCount = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        pnlInventoryCount = New Panel()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        lblProductsSold = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        pnlProductsSold = New Panel()
        MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        pnlInventoryValue = New Panel()
        lblTextInventoryValue = New MaterialSkin.Controls.MaterialLabel()
        lblInventoryValue = New MaterialSkin.Controls.MaterialLabel()
        lbHighestSelling = New MaterialSkin.Controls.MaterialListBox()
        MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        pnlMostSold = New Panel()
        lblTextMostSold = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard_LeastSold = New MaterialSkin.Controls.MaterialCard()
        pnlLeastSold = New Panel()
        lblTextLeastSold = New MaterialSkin.Controls.MaterialLabel()
        lbLeastSelling = New MaterialSkin.Controls.MaterialListBox()
        MaterialCard_LowStock = New MaterialSkin.Controls.MaterialCard()
        pnlLowStock_New = New Panel()
        lblTextLowStock_New = New MaterialSkin.Controls.MaterialLabel()
        lbLowStock = New MaterialSkin.Controls.MaterialListBox()
        MaterialCard_OutOfStock = New MaterialSkin.Controls.MaterialCard()
        pnlOutOfStock_New = New Panel()
        lblTextOutOfStock_New = New MaterialSkin.Controls.MaterialLabel()
        lbOutOfStock = New MaterialSkin.Controls.MaterialListBox()
        MaterialCard2.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard4.SuspendLayout()
        MaterialCard5.SuspendLayout()
        MaterialCard7.SuspendLayout()
        MaterialCard_LeastSold.SuspendLayout()
        MaterialCard_LowStock.SuspendLayout()
        MaterialCard_OutOfStock.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.Anchor = AnchorStyles.Top
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(39, 25)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(102, 19)
        MaterialLabel1.TabIndex = 1
        MaterialLabel1.Text = "Total Revenue"
        MaterialLabel1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.Depth = 0
        lblTotalRevenue.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTotalRevenue.Location = New Point(10, 45)
        lblTotalRevenue.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(160, 42)
        lblTotalRevenue.TabIndex = 0
        lblTotalRevenue.Text = " ₱ 0.00"
        lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(pnlTotalRevenue)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Controls.Add(lblTotalRevenue)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(14, 14)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(180, 100)
        MaterialCard2.TabIndex = 3
        ' 
        ' pnlTotalRevenue
        ' 
        pnlTotalRevenue.BackColor = Color.LightGreen
        pnlTotalRevenue.Location = New Point(0, 0)
        pnlTotalRevenue.Name = "pnlTotalRevenue"
        pnlTotalRevenue.Size = New Size(180, 14)
        pnlTotalRevenue.TabIndex = 5
        ' 
        ' lblTextInventoryCount
        ' 
        lblTextInventoryCount.Anchor = AnchorStyles.Top
        lblTextInventoryCount.AutoSize = True
        lblTextInventoryCount.Depth = 0
        lblTextInventoryCount.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextInventoryCount.Location = New Point(39, 25)
        lblTextInventoryCount.MouseState = MaterialSkin.MouseState.HOVER
        lblTextInventoryCount.Name = "lblTextInventoryCount"
        lblTextInventoryCount.Size = New Size(112, 19)
        lblTextInventoryCount.TabIndex = 1
        lblTextInventoryCount.Text = "Inventory Count"
        ' 
        ' lblInventoryCount
        ' 
        lblInventoryCount.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInventoryCount.AutoSize = True
        lblInventoryCount.Depth = 0
        lblInventoryCount.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblInventoryCount.Location = New Point(85, 55)
        lblInventoryCount.MouseState = MaterialSkin.MouseState.HOVER
        lblInventoryCount.Name = "lblInventoryCount"
        lblInventoryCount.Size = New Size(10, 19)
        lblInventoryCount.TabIndex = 0
        lblInventoryCount.Text = "0"
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(pnlInventoryCount)
        MaterialCard3.Controls.Add(lblTextInventoryCount)
        MaterialCard3.Controls.Add(lblInventoryCount)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(214, 14)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(190, 100)
        MaterialCard3.TabIndex = 4
        ' 
        ' pnlInventoryCount
        ' 
        pnlInventoryCount.BackColor = Color.FromArgb(CByte(200), CByte(230), CByte(240))
        pnlInventoryCount.Location = New Point(0, 0)
        pnlInventoryCount.Name = "pnlInventoryCount"
        pnlInventoryCount.Size = New Size(192, 14)
        pnlInventoryCount.TabIndex = 5
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.Anchor = AnchorStyles.Top
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(45, 25)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(100, 19)
        MaterialLabel5.TabIndex = 1
        MaterialLabel5.Text = "Products Sold"
        ' 
        ' lblProductsSold
        ' 
        lblProductsSold.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProductsSold.AutoSize = True
        lblProductsSold.Depth = 0
        lblProductsSold.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblProductsSold.Location = New Point(85, 55)
        lblProductsSold.MouseState = MaterialSkin.MouseState.HOVER
        lblProductsSold.Name = "lblProductsSold"
        lblProductsSold.Size = New Size(10, 19)
        lblProductsSold.TabIndex = 0
        lblProductsSold.Text = "0"
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(pnlProductsSold)
        MaterialCard4.Controls.Add(MaterialLabel5)
        MaterialCard4.Controls.Add(lblProductsSold)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(421, 15)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(190, 100)
        MaterialCard4.TabIndex = 5
        ' 
        ' pnlProductsSold
        ' 
        pnlProductsSold.BackColor = Color.FromArgb(CByte(83), CByte(162), CByte(190))
        pnlProductsSold.Location = New Point(0, 0)
        pnlProductsSold.Name = "pnlProductsSold"
        pnlProductsSold.Size = New Size(190, 14)
        pnlProductsSold.TabIndex = 4
        ' 
        ' MaterialCard5
        ' 
        MaterialCard5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard5.Controls.Add(pnlInventoryValue)
        MaterialCard5.Controls.Add(lblTextInventoryValue)
        MaterialCard5.Controls.Add(lblInventoryValue)
        MaterialCard5.Depth = 0
        MaterialCard5.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard5.Location = New Point(631, 15)
        MaterialCard5.Margin = New Padding(14)
        MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard5.Name = "MaterialCard5"
        MaterialCard5.Padding = New Padding(14)
        MaterialCard5.Size = New Size(180, 100)
        MaterialCard5.TabIndex = 6
        ' 
        ' pnlInventoryValue
        ' 
        pnlInventoryValue.BackColor = Color.FromArgb(CByte(103), CByte(58), CByte(183))
        pnlInventoryValue.Location = New Point(0, 0)
        pnlInventoryValue.Name = "pnlInventoryValue"
        pnlInventoryValue.Size = New Size(180, 14)
        pnlInventoryValue.TabIndex = 5
        ' 
        ' lblTextInventoryValue
        ' 
        lblTextInventoryValue.Anchor = AnchorStyles.Top
        lblTextInventoryValue.AutoSize = True
        lblTextInventoryValue.Depth = 0
        lblTextInventoryValue.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextInventoryValue.Location = New Point(35, 25)
        lblTextInventoryValue.MouseState = MaterialSkin.MouseState.HOVER
        lblTextInventoryValue.Name = "lblTextInventoryValue"
        lblTextInventoryValue.Size = New Size(110, 19)
        lblTextInventoryValue.TabIndex = 1
        lblTextInventoryValue.Text = "Inventory Value"
        ' 
        ' lblInventoryValue
        ' 
        lblInventoryValue.Depth = 0
        lblInventoryValue.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblInventoryValue.Location = New Point(10, 45)
        lblInventoryValue.MouseState = MaterialSkin.MouseState.HOVER
        lblInventoryValue.Name = "lblInventoryValue"
        lblInventoryValue.Size = New Size(160, 42)
        lblInventoryValue.TabIndex = 0
        lblInventoryValue.Text = "₱ 0.00"
        lblInventoryValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbHighestSelling
        ' 
        lbHighestSelling.BackColor = Color.White
        lbHighestSelling.BorderColor = Color.LightGray
        lbHighestSelling.Depth = 0
        lbHighestSelling.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        lbHighestSelling.Location = New Point(23, 44)
        lbHighestSelling.MouseState = MaterialSkin.MouseState.HOVER
        lbHighestSelling.Name = "lbHighestSelling"
        lbHighestSelling.SelectedIndex = -1
        lbHighestSelling.SelectedItem = Nothing
        lbHighestSelling.ShowScrollBar = True
        lbHighestSelling.Size = New Size(346, 100)
        lbHighestSelling.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine
        lbHighestSelling.TabIndex = 7
        ' 
        ' MaterialCard7
        ' 
        MaterialCard7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard7.Controls.Add(pnlMostSold)
        MaterialCard7.Controls.Add(lblTextMostSold)
        MaterialCard7.Controls.Add(lbHighestSelling)
        MaterialCard7.Depth = 0
        MaterialCard7.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard7.Location = New Point(14, 132)
        MaterialCard7.Margin = New Padding(14)
        MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard7.Name = "MaterialCard7"
        MaterialCard7.Padding = New Padding(14)
        MaterialCard7.Size = New Size(392, 150)
        MaterialCard7.TabIndex = 8
        ' 
        ' pnlMostSold
        ' 
        pnlMostSold.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlMostSold.Location = New Point(0, 0)
        pnlMostSold.Name = "pnlMostSold"
        pnlMostSold.Size = New Size(392, 14)
        pnlMostSold.TabIndex = 9
        ' 
        ' lblTextMostSold
        ' 
        lblTextMostSold.AutoSize = True
        lblTextMostSold.Depth = 0
        lblTextMostSold.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextMostSold.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        lblTextMostSold.Location = New Point(166, 17)
        lblTextMostSold.MouseState = MaterialSkin.MouseState.HOVER
        lblTextMostSold.Name = "lblTextMostSold"
        lblTextMostSold.Size = New Size(64, 17)
        lblTextMostSold.TabIndex = 8
        lblTextMostSold.Text = "Most Sold"
        ' 
        ' MaterialCard_LeastSold
        ' 
        MaterialCard_LeastSold.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard_LeastSold.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard_LeastSold.Controls.Add(pnlLeastSold)
        MaterialCard_LeastSold.Controls.Add(lblTextLeastSold)
        MaterialCard_LeastSold.Controls.Add(lbLeastSelling)
        MaterialCard_LeastSold.Depth = 0
        MaterialCard_LeastSold.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard_LeastSold.Location = New Point(421, 132)
        MaterialCard_LeastSold.Margin = New Padding(14)
        MaterialCard_LeastSold.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard_LeastSold.Name = "MaterialCard_LeastSold"
        MaterialCard_LeastSold.Padding = New Padding(14)
        MaterialCard_LeastSold.Size = New Size(390, 150)
        MaterialCard_LeastSold.TabIndex = 11
        ' 
        ' pnlLeastSold
        ' 
        pnlLeastSold.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlLeastSold.Location = New Point(0, 0)
        pnlLeastSold.Name = "pnlLeastSold"
        pnlLeastSold.Size = New Size(390, 14)
        pnlLeastSold.TabIndex = 12
        ' 
        ' lblTextLeastSold
        ' 
        lblTextLeastSold.AutoSize = True
        lblTextLeastSold.Depth = 0
        lblTextLeastSold.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextLeastSold.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        lblTextLeastSold.Location = New Point(158, 17)
        lblTextLeastSold.MouseState = MaterialSkin.MouseState.HOVER
        lblTextLeastSold.Name = "lblTextLeastSold"
        lblTextLeastSold.Size = New Size(68, 17)
        lblTextLeastSold.TabIndex = 13
        lblTextLeastSold.Text = "Least Sold"
        ' 
        ' lbLeastSelling
        ' 
        lbLeastSelling.BackColor = Color.White
        lbLeastSelling.BorderColor = Color.LightGray
        lbLeastSelling.Depth = 0
        lbLeastSelling.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        lbLeastSelling.Location = New Point(23, 44)
        lbLeastSelling.MouseState = MaterialSkin.MouseState.HOVER
        lbLeastSelling.Name = "lbLeastSelling"
        lbLeastSelling.SelectedIndex = -1
        lbLeastSelling.SelectedItem = Nothing
        lbLeastSelling.ShowScrollBar = True
        lbLeastSelling.Size = New Size(346, 100)
        lbLeastSelling.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine
        lbLeastSelling.TabIndex = 10
        ' 
        ' MaterialCard_LowStock
        ' 
        MaterialCard_LowStock.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard_LowStock.Controls.Add(pnlLowStock_New)
        MaterialCard_LowStock.Controls.Add(lblTextLowStock_New)
        MaterialCard_LowStock.Controls.Add(lbLowStock)
        MaterialCard_LowStock.Depth = 0
        MaterialCard_LowStock.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard_LowStock.Location = New Point(14, 296)
        MaterialCard_LowStock.Margin = New Padding(14)
        MaterialCard_LowStock.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard_LowStock.Name = "MaterialCard_LowStock"
        MaterialCard_LowStock.Padding = New Padding(14)
        MaterialCard_LowStock.Size = New Size(392, 150)
        MaterialCard_LowStock.TabIndex = 15
        ' 
        ' pnlLowStock_New
        ' 
        pnlLowStock_New.BackColor = Color.FromArgb(CByte(174), CByte(78), CByte(78))
        pnlLowStock_New.Location = New Point(0, 0)
        pnlLowStock_New.Name = "pnlLowStock_New"
        pnlLowStock_New.Size = New Size(392, 14)
        pnlLowStock_New.TabIndex = 16
        ' 
        ' lblTextLowStock_New
        ' 
        lblTextLowStock_New.AutoSize = True
        lblTextLowStock_New.Depth = 0
        lblTextLowStock_New.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextLowStock_New.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        lblTextLowStock_New.Location = New Point(150, 17)
        lblTextLowStock_New.MouseState = MaterialSkin.MouseState.HOVER
        lblTextLowStock_New.Name = "lblTextLowStock_New"
        lblTextLowStock_New.Size = New Size(65, 17)
        lblTextLowStock_New.TabIndex = 17
        lblTextLowStock_New.Text = "Low Stock"
        ' 
        ' lbLowStock
        ' 
        lbLowStock.BackColor = Color.White
        lbLowStock.BorderColor = Color.LightGray
        lbLowStock.Depth = 0
        lbLowStock.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        lbLowStock.Location = New Point(23, 37)
        lbLowStock.MouseState = MaterialSkin.MouseState.HOVER
        lbLowStock.Name = "lbLowStock"
        lbLowStock.SelectedIndex = -1
        lbLowStock.SelectedItem = Nothing
        lbLowStock.ShowScrollBar = True
        lbLowStock.Size = New Size(346, 100)
        lbLowStock.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine
        lbLowStock.TabIndex = 14
        ' 
        ' MaterialCard_OutOfStock
        ' 
        MaterialCard_OutOfStock.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard_OutOfStock.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard_OutOfStock.Controls.Add(pnlOutOfStock_New)
        MaterialCard_OutOfStock.Controls.Add(lblTextOutOfStock_New)
        MaterialCard_OutOfStock.Controls.Add(lbOutOfStock)
        MaterialCard_OutOfStock.Depth = 0
        MaterialCard_OutOfStock.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard_OutOfStock.Location = New Point(421, 296)
        MaterialCard_OutOfStock.Margin = New Padding(14)
        MaterialCard_OutOfStock.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard_OutOfStock.Name = "MaterialCard_OutOfStock"
        MaterialCard_OutOfStock.Padding = New Padding(14)
        MaterialCard_OutOfStock.Size = New Size(390, 150)
        MaterialCard_OutOfStock.TabIndex = 19
        ' 
        ' pnlOutOfStock_New
        ' 
        pnlOutOfStock_New.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        pnlOutOfStock_New.Location = New Point(0, 0)
        pnlOutOfStock_New.Name = "pnlOutOfStock_New"
        pnlOutOfStock_New.Size = New Size(390, 14)
        pnlOutOfStock_New.TabIndex = 20
        ' 
        ' lblTextOutOfStock_New
        ' 
        lblTextOutOfStock_New.AutoSize = True
        lblTextOutOfStock_New.Depth = 0
        lblTextOutOfStock_New.Font = New Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextOutOfStock_New.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        lblTextOutOfStock_New.Location = New Point(140, 17)
        lblTextOutOfStock_New.MouseState = MaterialSkin.MouseState.HOVER
        lblTextOutOfStock_New.Name = "lblTextOutOfStock_New"
        lblTextOutOfStock_New.Size = New Size(78, 17)
        lblTextOutOfStock_New.TabIndex = 21
        lblTextOutOfStock_New.Text = "Out of Stock"
        ' 
        ' lbOutOfStock
        ' 
        lbOutOfStock.BackColor = Color.White
        lbOutOfStock.BorderColor = Color.LightGray
        lbOutOfStock.Depth = 0
        lbOutOfStock.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        lbOutOfStock.Location = New Point(23, 37)
        lbOutOfStock.MouseState = MaterialSkin.MouseState.HOVER
        lbOutOfStock.Name = "lbOutOfStock"
        lbOutOfStock.SelectedIndex = -1
        lbOutOfStock.SelectedItem = Nothing
        lbOutOfStock.ShowScrollBar = True
        lbOutOfStock.Size = New Size(346, 100)
        lbOutOfStock.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine
        lbOutOfStock.TabIndex = 18
        ' 
        ' uc_Dashboard
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        BackColor = Color.White
        Controls.Add(MaterialCard_OutOfStock)
        Controls.Add(MaterialCard_LowStock)
        Controls.Add(MaterialCard_LeastSold)
        Controls.Add(MaterialCard7)
        Controls.Add(MaterialCard5)
        Controls.Add(MaterialCard2)
        Controls.Add(MaterialCard3)
        Controls.Add(MaterialCard4)
        Name = "uc_Dashboard"
        Size = New Size(825, 471)
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        MaterialCard5.ResumeLayout(False)
        MaterialCard5.PerformLayout()
        MaterialCard7.ResumeLayout(False)
        MaterialCard7.PerformLayout()
        MaterialCard_LeastSold.ResumeLayout(False)
        MaterialCard_LeastSold.PerformLayout()
        MaterialCard_LowStock.ResumeLayout(False)
        MaterialCard_LowStock.PerformLayout()
        MaterialCard_OutOfStock.ResumeLayout(False)
        MaterialCard_OutOfStock.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblProductsSold As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTextInventoryCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInventoryCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalRevenue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pnlProductsSold As Panel
    Friend WithEvents pnlTotalRevenue As Panel
    Friend WithEvents pnlInventoryCount As Panel
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pnlInventoryValue As Panel
    Friend WithEvents lblTextInventoryValue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInventoryValue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbHighestSelling As MaterialSkin.Controls.MaterialListBox
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextMostSold As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pnlMostSold As Panel

    Friend WithEvents MaterialCard_LeastSold As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextLeastSold As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbLeastSelling As MaterialSkin.Controls.MaterialListBox
    Friend WithEvents pnlLeastSold As Panel

    Friend WithEvents MaterialCard_LowStock As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextLowStock_New As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbLowStock As MaterialSkin.Controls.MaterialListBox
    Friend WithEvents pnlLowStock_New As Panel

    Friend WithEvents MaterialCard_OutOfStock As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextOutOfStock_New As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbOutOfStock As MaterialSkin.Controls.MaterialListBox
    Friend WithEvents pnlOutOfStock_New As Panel

End Class
