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
        MaterialCard1.SuspendLayout()
        MaterialCard2.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard4.SuspendLayout()
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
        MaterialCard1.Location = New Point(49, 22)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(200, 100)
        MaterialCard1.TabIndex = 1
        ' 
        ' pnlLowStock
        ' 
        pnlLowStock.BackColor = Color.FromArgb(CByte(174), CByte(78), CByte(78))
        pnlLowStock.Location = New Point(0, 0)
        pnlLowStock.Name = "pnlLowStock"
        pnlLowStock.Size = New Size(200, 14)
        pnlLowStock.TabIndex = 5
        ' 
        ' lblTextLowStock
        ' 
        lblTextLowStock.Anchor = AnchorStyles.Top
        lblTextLowStock.AutoSize = True
        lblTextLowStock.Depth = 0
        lblTextLowStock.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextLowStock.Location = New Point(59, 17)
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
        lblLowStock.Location = New Point(91, 48)
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
        MaterialLabel1.Location = New Point(48, 17)
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
        lblTotalRevenue.Location = New Point(58, 36)
        lblTotalRevenue.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(76, 42)
        lblTotalRevenue.TabIndex = 0
        lblTotalRevenue.Text = " ₱ 0.00"
        lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(pnlTotalRevenue)
        MaterialCard2.Controls.Add(MaterialLabel1)
        MaterialCard2.Controls.Add(lblTotalRevenue)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(362, 206)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(200, 100)
        MaterialCard2.TabIndex = 3
        ' 
        ' pnlTotalRevenue
        ' 
        pnlTotalRevenue.BackColor = Color.LightGreen
        pnlTotalRevenue.Location = New Point(0, 0)
        pnlTotalRevenue.Name = "pnlTotalRevenue"
        pnlTotalRevenue.Size = New Size(200, 14)
        pnlTotalRevenue.TabIndex = 5
        ' 
        ' lblTextInventoryCount
        ' 
        lblTextInventoryCount.Anchor = AnchorStyles.Top
        lblTextInventoryCount.AutoSize = True
        lblTextInventoryCount.Depth = 0
        lblTextInventoryCount.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTextInventoryCount.Location = New Point(48, 17)
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
        lblInventoryCount.Location = New Point(100, 48)
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
        MaterialCard3.Location = New Point(362, 22)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(200, 100)
        MaterialCard3.TabIndex = 3
        ' 
        ' pnlInventoryCount
        ' 
        pnlInventoryCount.BackColor = Color.FromArgb(CByte(200), CByte(230), CByte(240))
        pnlInventoryCount.Location = New Point(0, 0)
        pnlInventoryCount.Name = "pnlInventoryCount"
        pnlInventoryCount.Size = New Size(200, 14)
        pnlInventoryCount.TabIndex = 5
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.Anchor = AnchorStyles.Top
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(47, 17)
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
        lblProductsSold.Location = New Point(91, 49)
        lblProductsSold.MouseState = MaterialSkin.MouseState.HOVER
        lblProductsSold.Name = "lblProductsSold"
        lblProductsSold.Size = New Size(10, 19)
        lblProductsSold.TabIndex = 0
        lblProductsSold.Text = "0"
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(pnlProductsSold)
        MaterialCard4.Controls.Add(MaterialLabel5)
        MaterialCard4.Controls.Add(lblProductsSold)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(49, 206)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(200, 100)
        MaterialCard4.TabIndex = 3
        ' 
        ' pnlProductsSold
        ' 
        pnlProductsSold.BackColor = Color.FromArgb(CByte(83), CByte(162), CByte(190))
        pnlProductsSold.Location = New Point(0, 0)
        pnlProductsSold.Name = "pnlProductsSold"
        pnlProductsSold.Size = New Size(200, 14)
        pnlProductsSold.TabIndex = 4
        ' 
        ' uc_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(MaterialCard2)
        Controls.Add(MaterialCard3)
        Controls.Add(MaterialCard4)
        Controls.Add(MaterialCard1)
        Name = "uc_Dashboard"
        Size = New Size(631, 376)
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        MaterialCard2.ResumeLayout(False)
        MaterialCard2.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTextLowStock As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblLowStock As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblProductsSold As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTextInventoryCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInventoryCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalRevenue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlProductsSold As Panel
    Friend WithEvents pnlLowStock As Panel
    Friend WithEvents pnlTotalRevenue As Panel
    Friend WithEvents pnlInventoryCount As Panel

End Class
