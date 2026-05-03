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
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        pnlLowStock = New Panel()
        lblTextLowStock = New MaterialSkin.Controls.MaterialLabel()
        lblLowStock = New MaterialSkin.Controls.MaterialLabel()
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
        MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        pnlOutOfStock = New Panel()
        lblTextOutOfStock = New MaterialSkin.Controls.MaterialLabel()
        lblOutOfStock = New MaterialSkin.Controls.MaterialLabel()
        lbHighestSelling = New MaterialSkin.Controls.MaterialListBox()
        MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        lblTextMostSold = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard1.SuspendLayout()
        MaterialCard2.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard4.SuspendLayout()
        MaterialCard5.SuspendLayout()
        MaterialCard6.SuspendLayout()
        MaterialCard7.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(pnlLowStock)
        MaterialCard1.Controls.Add(lblTextLowStock)
        MaterialCard1.Controls.Add(lblLowStock)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(284, 22)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(244, 111)
        MaterialCard1.TabIndex = 1
        ' 
        ' pnlLowStock
        ' 
        pnlLowStock.BackColor = Color.FromArgb(CByte(174), CByte(78), CByte(78))
        pnlLowStock.Location = New Point(0, 0)
        pnlLowStock.Name = "pnlLowStock"
        pnlLowStock.Size = New Size(244, 14)
        pnlLowStock.TabIndex = 5
        ' 
        ' lblTextLowStock
        ' 
        lblTextLowStock.Anchor = AnchorStyles.Top
        lblTextLowStock.AutoSize = True
        lblTextLowStock.Depth = 0
        lblTextLowStock.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextLowStock.Location = New Point(83, 20)
        lblTextLowStock.MouseState = MaterialSkin.MouseState.HOVER
        lblTextLowStock.Name = "lblTextLowStock"
        lblTextLowStock.Size = New Size(75, 19)
        lblTextLowStock.TabIndex = 1
        lblTextLowStock.Text = "Low Stock"
        ' 
        ' lblLowStock
        ' 
        lblLowStock.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblLowStock.AutoSize = True
        lblLowStock.Depth = 0
        lblLowStock.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblLowStock.Location = New Point(115, 48)
        lblLowStock.MouseState = MaterialSkin.MouseState.HOVER
        lblLowStock.Name = "lblLowStock"
        lblLowStock.Size = New Size(10, 19)
        lblLowStock.TabIndex = 0
        lblLowStock.Text = "0"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.Anchor = AnchorStyles.Top
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(70, 17)
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
        lblTotalRevenue.Location = New Point(76, 36)
        lblTotalRevenue.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(76, 42)
        lblTotalRevenue.TabIndex = 0
        lblTotalRevenue.Text = " ₱ 0.00"
        lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(pnlTotalRevenue)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Controls.Add(lblTotalRevenue)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(556, 159)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(244, 111)
        MaterialCard2.TabIndex = 3
        ' 
        ' pnlTotalRevenue
        ' 
        pnlTotalRevenue.BackColor = Color.LightGreen
        pnlTotalRevenue.Location = New Point(0, 0)
        pnlTotalRevenue.Name = "pnlTotalRevenue"
        pnlTotalRevenue.Size = New Size(244, 14)
        pnlTotalRevenue.TabIndex = 5
        ' 
        ' lblTextInventoryCount
        ' 
        lblTextInventoryCount.Anchor = AnchorStyles.Top
        lblTextInventoryCount.AutoSize = True
        lblTextInventoryCount.Depth = 0
        lblTextInventoryCount.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextInventoryCount.Location = New Point(70, 20)
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
        lblInventoryCount.Location = New Point(115, 48)
        lblInventoryCount.MouseState = MaterialSkin.MouseState.HOVER
        lblInventoryCount.Name = "lblInventoryCount"
        lblInventoryCount.Size = New Size(10, 19)
        lblInventoryCount.TabIndex = 0
        lblInventoryCount.Text = "0"
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(pnlInventoryCount)
        MaterialCard3.Controls.Add(lblTextInventoryCount)
        MaterialCard3.Controls.Add(lblInventoryCount)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(556, 22)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(244, 111)
        MaterialCard3.TabIndex = 3
        ' 
        ' pnlInventoryCount
        ' 
        pnlInventoryCount.BackColor = Color.FromArgb(CByte(200), CByte(230), CByte(240))
        pnlInventoryCount.Location = New Point(0, 0)
        pnlInventoryCount.Name = "pnlInventoryCount"
        pnlInventoryCount.Size = New Size(244, 14)
        pnlInventoryCount.TabIndex = 5
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.Anchor = AnchorStyles.Top
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(66, 17)
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
        lblProductsSold.Location = New Point(115, 49)
        lblProductsSold.MouseState = MaterialSkin.MouseState.HOVER
        lblProductsSold.Name = "lblProductsSold"
        lblProductsSold.Size = New Size(10, 19)
        lblProductsSold.TabIndex = 0
        lblProductsSold.Text = "0"
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(pnlProductsSold)
        MaterialCard4.Controls.Add(MaterialLabel5)
        MaterialCard4.Controls.Add(lblProductsSold)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(284, 159)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(244, 111)
        MaterialCard4.TabIndex = 3
        ' 
        ' pnlProductsSold
        ' 
        pnlProductsSold.BackColor = Color.FromArgb(CByte(83), CByte(162), CByte(190))
        pnlProductsSold.Location = New Point(0, 0)
        pnlProductsSold.Name = "pnlProductsSold"
        pnlProductsSold.Size = New Size(244, 14)
        pnlProductsSold.TabIndex = 4
        ' 
        ' MaterialCard5
        ' 
        MaterialCard5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        MaterialCard5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard5.Controls.Add(pnlInventoryValue)
        MaterialCard5.Controls.Add(lblTextInventoryValue)
        MaterialCard5.Controls.Add(lblInventoryValue)
        MaterialCard5.Depth = 0
        MaterialCard5.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard5.Location = New Point(284, 298)
        MaterialCard5.Margin = New Padding(14)
        MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard5.Name = "MaterialCard5"
        MaterialCard5.Padding = New Padding(14)
        MaterialCard5.Size = New Size(244, 111)
        MaterialCard5.TabIndex = 5
        ' 
        ' pnlInventoryValue
        ' 
        pnlInventoryValue.BackColor = Color.FromArgb(CByte(103), CByte(58), CByte(183))
        pnlInventoryValue.Location = New Point(0, 0)
        pnlInventoryValue.Name = "pnlInventoryValue"
        pnlInventoryValue.Size = New Size(244, 14)
        pnlInventoryValue.TabIndex = 5
        ' 
        ' lblTextInventoryValue
        ' 
        lblTextInventoryValue.Anchor = AnchorStyles.Top
        lblTextInventoryValue.AutoSize = True
        lblTextInventoryValue.Depth = 0
        lblTextInventoryValue.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextInventoryValue.Location = New Point(66, 17)
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
        lblInventoryValue.Location = New Point(38, 49)
        lblInventoryValue.MouseState = MaterialSkin.MouseState.HOVER
        lblInventoryValue.Name = "lblInventoryValue"
        lblInventoryValue.Size = New Size(166, 19)
        lblInventoryValue.TabIndex = 0
        lblInventoryValue.Text = "₱ 0.00"
        lblInventoryValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MaterialCard6
        ' 
        MaterialCard6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        MaterialCard6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard6.Controls.Add(pnlOutOfStock)
        MaterialCard6.Controls.Add(lblTextOutOfStock)
        MaterialCard6.Controls.Add(lblOutOfStock)
        MaterialCard6.Depth = 0
        MaterialCard6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard6.Location = New Point(556, 298)
        MaterialCard6.Margin = New Padding(14)
        MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard6.Name = "MaterialCard6"
        MaterialCard6.Padding = New Padding(14)
        MaterialCard6.Size = New Size(244, 111)
        MaterialCard6.TabIndex = 6
        ' 
        ' pnlOutOfStock
        ' 
        pnlOutOfStock.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        pnlOutOfStock.Location = New Point(0, 0)
        pnlOutOfStock.Name = "pnlOutOfStock"
        pnlOutOfStock.Size = New Size(244, 14)
        pnlOutOfStock.TabIndex = 5
        ' 
        ' lblTextOutOfStock
        ' 
        lblTextOutOfStock.Anchor = AnchorStyles.Top
        lblTextOutOfStock.AutoSize = True
        lblTextOutOfStock.Depth = 0
        lblTextOutOfStock.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextOutOfStock.Location = New Point(76, 17)
        lblTextOutOfStock.MouseState = MaterialSkin.MouseState.HOVER
        lblTextOutOfStock.Name = "lblTextOutOfStock"
        lblTextOutOfStock.Size = New Size(89, 19)
        lblTextOutOfStock.TabIndex = 1
        lblTextOutOfStock.Text = "Out of Stock"
        ' 
        ' lblOutOfStock
        ' 
        lblOutOfStock.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOutOfStock.AutoSize = True
        lblOutOfStock.Depth = 0
        lblOutOfStock.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblOutOfStock.Location = New Point(124, 50)
        lblOutOfStock.MouseState = MaterialSkin.MouseState.HOVER
        lblOutOfStock.Name = "lblOutOfStock"
        lblOutOfStock.Size = New Size(10, 19)
        lblOutOfStock.TabIndex = 0
        lblOutOfStock.Text = "0"
        ' 
        ' lbHighestSelling
        ' 
        lbHighestSelling.BackColor = Color.White
        lbHighestSelling.BorderColor = Color.LightGray
        lbHighestSelling.Depth = 0
        lbHighestSelling.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        lbHighestSelling.Location = New Point(17, 48)
        lbHighestSelling.MouseState = MaterialSkin.MouseState.HOVER
        lbHighestSelling.Name = "lbHighestSelling"
        lbHighestSelling.SelectedIndex = -1
        lbHighestSelling.SelectedItem = Nothing
        lbHighestSelling.ShowScrollBar = True
        lbHighestSelling.Size = New Size(201, 168)
        lbHighestSelling.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine
        lbHighestSelling.TabIndex = 7
        ' 
        ' MaterialCard7
        ' 
        MaterialCard7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard7.Controls.Add(lblTextMostSold)
        MaterialCard7.Controls.Add(lbHighestSelling)
        MaterialCard7.Depth = 0
        MaterialCard7.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard7.Location = New Point(21, 22)
        MaterialCard7.Margin = New Padding(14)
        MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard7.Name = "MaterialCard7"
        MaterialCard7.Padding = New Padding(14)
        MaterialCard7.Size = New Size(235, 233)
        MaterialCard7.TabIndex = 8
        ' 
        ' lblTextMostSold
        ' 
        lblTextMostSold.AutoSize = True
        lblTextMostSold.Depth = 0
        lblTextMostSold.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextMostSold.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTextMostSold.Location = New Point(68, 14)
        lblTextMostSold.MouseState = MaterialSkin.MouseState.HOVER
        lblTextMostSold.Name = "lblTextMostSold"
        lblTextMostSold.Size = New Size(91, 24)
        lblTextMostSold.TabIndex = 8
        lblTextMostSold.Text = "Most Sold"
        ' 
        ' uc_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(MaterialCard7)
        Controls.Add(MaterialCard6)
        Controls.Add(MaterialCard5)
        Controls.Add(MaterialCard2)
        Controls.Add(MaterialCard3)
        Controls.Add(MaterialCard4)
        Controls.Add(MaterialCard1)
        MinimumSize = New Size(825, 471)
        Name = "uc_Dashboard"
        Size = New Size(825, 471)
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        MaterialCard5.ResumeLayout(False)
        MaterialCard5.PerformLayout()
        MaterialCard6.ResumeLayout(False)
        MaterialCard6.PerformLayout()
        MaterialCard7.ResumeLayout(False)
        MaterialCard7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextLowStock As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblLowStock As MaterialSkin.Controls.MaterialLabel
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
    Friend WithEvents pnlLowStock As Panel
    Friend WithEvents pnlTotalRevenue As Panel
    Friend WithEvents pnlInventoryCount As Panel
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pnlInventoryValue As Panel
    Friend WithEvents lblTextInventoryValue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInventoryValue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pnlOutOfStock As Panel
    Friend WithEvents lblTextOutOfStock As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblOutOfStock As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbHighestSelling As MaterialSkin.Controls.MaterialListBox
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextMostSold As MaterialSkin.Controls.MaterialLabel

End Class
