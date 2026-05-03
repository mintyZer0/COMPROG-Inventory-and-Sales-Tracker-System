<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Reports
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
        lvLowStock = New MaterialSkin.Controls.MaterialListView()
        colLowStockName = New ColumnHeader()
        colLowStock = New ColumnHeader()
        pnlLowStock = New Panel()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        pnlTotalItemsSold = New Panel()
        lblTotalItemsSold = New MaterialSkin.Controls.MaterialLabel()
        lblTextTotalItemsSold = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        pnlBestSellingItem = New Panel()
        lblBestSellingItem = New MaterialSkin.Controls.MaterialLabel()
        lblTextBestSellingItem = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        pnlTotalRevenue = New Panel()
        lblTotalRevenue = New MaterialSkin.Controls.MaterialLabel()
        lblTextTotalRevenue = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        btnExport = New MaterialSkin.Controls.MaterialButton()
        lblExportText = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        lblLowStock = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        lvSalesReport = New MaterialSkin.Controls.MaterialListView()
        colIndex = New ColumnHeader()
        colName = New ColumnHeader()
        colUnitsSold = New ColumnHeader()
        colRevenue = New ColumnHeader()
        MaterialCard1.SuspendLayout()
        MaterialCard2.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard4.SuspendLayout()
        MaterialCard5.SuspendLayout()
        MaterialCard6.SuspendLayout()
        SuspendLayout()
        ' 
        ' lvLowStock
        ' 
        lvLowStock.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvLowStock.AutoSizeTable = False
        lvLowStock.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lvLowStock.BorderStyle = BorderStyle.None
        lvLowStock.Columns.AddRange(New ColumnHeader() {colLowStockName, colLowStock})
        lvLowStock.Depth = 0
        lvLowStock.FullRowSelect = True
        lvLowStock.Location = New Point(6, 56)
        lvLowStock.MinimumSize = New Size(200, 100)
        lvLowStock.MouseLocation = New Point(-1, -1)
        lvLowStock.MouseState = MaterialSkin.MouseState.OUT
        lvLowStock.Name = "lvLowStock"
        lvLowStock.OwnerDraw = True
        lvLowStock.Size = New Size(206, 169)
        lvLowStock.TabIndex = 0
        lvLowStock.UseCompatibleStateImageBehavior = False
        lvLowStock.View = View.Details
        ' 
        ' colLowStockName
        ' 
        colLowStockName.Text = "Name"
        colLowStockName.Width = 100
        ' 
        ' colLowStock
        ' 
        colLowStock.Text = "Stock"
        colLowStock.TextAlign = HorizontalAlignment.Center
        colLowStock.Width = 100
        ' 
        ' pnlLowStock
        ' 
        pnlLowStock.BackColor = Color.FromArgb(CByte(174), CByte(78), CByte(78))
        pnlLowStock.Location = New Point(0, 0)
        pnlLowStock.Name = "pnlLowStock"
        pnlLowStock.Size = New Size(219, 17)
        pnlLowStock.TabIndex = 1
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(pnlTotalItemsSold)
        MaterialCard1.Controls.Add(lblTotalItemsSold)
        MaterialCard1.Controls.Add(lblTextTotalItemsSold)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(252, 14)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(268, 111)
        MaterialCard1.TabIndex = 2
        ' 
        ' pnlTotalItemsSold
        ' 
        pnlTotalItemsSold.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTotalItemsSold.BackColor = Color.FromArgb(CByte(83), CByte(162), CByte(190))
        pnlTotalItemsSold.Location = New Point(0, 0)
        pnlTotalItemsSold.Name = "pnlTotalItemsSold"
        pnlTotalItemsSold.Size = New Size(268, 17)
        pnlTotalItemsSold.TabIndex = 2
        ' 
        ' lblTotalItemsSold
        ' 
        lblTotalItemsSold.Anchor = AnchorStyles.None
        lblTotalItemsSold.AutoSize = True
        lblTotalItemsSold.Depth = 0
        lblTotalItemsSold.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTotalItemsSold.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        lblTotalItemsSold.Location = New Point(121, 56)
        lblTotalItemsSold.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalItemsSold.Name = "lblTotalItemsSold"
        lblTotalItemsSold.Size = New Size(14, 29)
        lblTotalItemsSold.TabIndex = 1
        lblTotalItemsSold.Text = "0"
        lblTotalItemsSold.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTextTotalItemsSold
        ' 
        lblTextTotalItemsSold.Anchor = AnchorStyles.None
        lblTextTotalItemsSold.AutoSize = True
        lblTextTotalItemsSold.Depth = 0
        lblTextTotalItemsSold.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextTotalItemsSold.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTextTotalItemsSold.Location = New Point(60, 24)
        lblTextTotalItemsSold.MouseState = MaterialSkin.MouseState.HOVER
        lblTextTotalItemsSold.Name = "lblTextTotalItemsSold"
        lblTextTotalItemsSold.Size = New Size(147, 24)
        lblTextTotalItemsSold.TabIndex = 0
        lblTextTotalItemsSold.Text = "Total Items Sold"
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Controls.Add(pnlBestSellingItem)
        MaterialCard2.Controls.Add(lblBestSellingItem)
        MaterialCard2.Controls.Add(lblTextBestSellingItem)
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(252, 134)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(268, 111)
        MaterialCard2.TabIndex = 3
        ' 
        ' pnlBestSellingItem
        ' 
        pnlBestSellingItem.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBestSellingItem.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlBestSellingItem.Location = New Point(0, 0)
        pnlBestSellingItem.Name = "pnlBestSellingItem"
        pnlBestSellingItem.Size = New Size(268, 17)
        pnlBestSellingItem.TabIndex = 2
        ' 
        ' lblBestSellingItem
        ' 
        lblBestSellingItem.Anchor = AnchorStyles.None
        lblBestSellingItem.Depth = 0
        lblBestSellingItem.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblBestSellingItem.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        lblBestSellingItem.Location = New Point(64, 52)
        lblBestSellingItem.MouseState = MaterialSkin.MouseState.HOVER
        lblBestSellingItem.Name = "lblBestSellingItem"
        lblBestSellingItem.Size = New Size(144, 29)
        lblBestSellingItem.TabIndex = 1
        lblBestSellingItem.Text = "_"
        lblBestSellingItem.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTextBestSellingItem
        ' 
        lblTextBestSellingItem.Anchor = AnchorStyles.None
        lblTextBestSellingItem.AutoSize = True
        lblTextBestSellingItem.Depth = 0
        lblTextBestSellingItem.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextBestSellingItem.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTextBestSellingItem.Location = New Point(64, 19)
        lblTextBestSellingItem.MouseState = MaterialSkin.MouseState.HOVER
        lblTextBestSellingItem.Name = "lblTextBestSellingItem"
        lblTextBestSellingItem.Size = New Size(153, 24)
        lblTextBestSellingItem.TabIndex = 0
        lblTextBestSellingItem.Text = "Best Selling Item"
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(pnlTotalRevenue)
        MaterialCard3.Controls.Add(lblTotalRevenue)
        MaterialCard3.Controls.Add(lblTextTotalRevenue)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(537, 14)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(268, 111)
        MaterialCard3.TabIndex = 4
        ' 
        ' pnlTotalRevenue
        ' 
        pnlTotalRevenue.BackColor = Color.LightGreen
        pnlTotalRevenue.Location = New Point(0, 0)
        pnlTotalRevenue.Name = "pnlTotalRevenue"
        pnlTotalRevenue.Size = New Size(268, 17)
        pnlTotalRevenue.TabIndex = 2
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.Anchor = AnchorStyles.None
        lblTotalRevenue.Depth = 0
        lblTotalRevenue.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTotalRevenue.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        lblTotalRevenue.Location = New Point(69, 56)
        lblTotalRevenue.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(144, 29)
        lblTotalRevenue.TabIndex = 1
        lblTotalRevenue.Text = "_"
        lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTextTotalRevenue
        ' 
        lblTextTotalRevenue.Anchor = AnchorStyles.None
        lblTextTotalRevenue.AutoSize = True
        lblTextTotalRevenue.Depth = 0
        lblTextTotalRevenue.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTextTotalRevenue.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTextTotalRevenue.Location = New Point(74, 23)
        lblTextTotalRevenue.MouseState = MaterialSkin.MouseState.HOVER
        lblTextTotalRevenue.Name = "lblTextTotalRevenue"
        lblTextTotalRevenue.Size = New Size(129, 24)
        lblTextTotalRevenue.TabIndex = 0
        lblTextTotalRevenue.Text = "Total Revenue"
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(btnExport)
        MaterialCard4.Controls.Add(lblExportText)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(537, 134)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(268, 111)
        MaterialCard4.TabIndex = 4
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.None
        btnExport.AutoSize = False
        btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnExport.Depth = 0
        btnExport.HighEmphasis = True
        btnExport.Icon = Nothing
        btnExport.Location = New Point(63, 52)
        btnExport.Margin = New Padding(4, 6, 4, 6)
        btnExport.MouseState = MaterialSkin.MouseState.HOVER
        btnExport.Name = "btnExport"
        btnExport.NoAccentTextColor = Color.Empty
        btnExport.Size = New Size(158, 36)
        btnExport.TabIndex = 1
        btnExport.Text = "Export"
        btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnExport.UseAccentColor = False
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' lblExportText
        ' 
        lblExportText.Anchor = AnchorStyles.None
        lblExportText.AutoSize = True
        lblExportText.Depth = 0
        lblExportText.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblExportText.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblExportText.Location = New Point(72, 16)
        lblExportText.MouseState = MaterialSkin.MouseState.HOVER
        lblExportText.Name = "lblExportText"
        lblExportText.Size = New Size(141, 24)
        lblExportText.TabIndex = 0
        lblExportText.Text = "Export to HTML"
        ' 
        ' MaterialCard5
        ' 
        MaterialCard5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard5.Controls.Add(pnlLowStock)
        MaterialCard5.Controls.Add(lblLowStock)
        MaterialCard5.Controls.Add(lvLowStock)
        MaterialCard5.Depth = 0
        MaterialCard5.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard5.Location = New Point(16, 14)
        MaterialCard5.Margin = New Padding(14)
        MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard5.Name = "MaterialCard5"
        MaterialCard5.Padding = New Padding(14)
        MaterialCard5.Size = New Size(219, 231)
        MaterialCard5.TabIndex = 5
        ' 
        ' lblLowStock
        ' 
        lblLowStock.AutoSize = True
        lblLowStock.Depth = 0
        lblLowStock.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblLowStock.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblLowStock.Location = New Point(36, 20)
        lblLowStock.MouseState = MaterialSkin.MouseState.HOVER
        lblLowStock.Name = "lblLowStock"
        lblLowStock.Size = New Size(149, 24)
        lblLowStock.TabIndex = 1
        lblLowStock.Text = "Low Stock Items"
        ' 
        ' MaterialCard6
        ' 
        MaterialCard6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard6.Controls.Add(lvSalesReport)
        MaterialCard6.Depth = 0
        MaterialCard6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard6.Location = New Point(14, 259)
        MaterialCard6.Margin = New Padding(14)
        MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard6.Name = "MaterialCard6"
        MaterialCard6.Padding = New Padding(14)
        MaterialCard6.Size = New Size(796, 203)
        MaterialCard6.TabIndex = 7
        ' 
        ' lvSalesReport
        ' 
        lvSalesReport.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvSalesReport.AutoSizeTable = False
        lvSalesReport.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lvSalesReport.BorderStyle = BorderStyle.None
        lvSalesReport.Columns.AddRange(New ColumnHeader() {colIndex, colName, colUnitsSold, colRevenue})
        lvSalesReport.Depth = 0
        lvSalesReport.FullRowSelect = True
        lvSalesReport.Location = New Point(5, 6)
        lvSalesReport.MinimumSize = New Size(200, 100)
        lvSalesReport.MouseLocation = New Point(-1, -1)
        lvSalesReport.MouseState = MaterialSkin.MouseState.OUT
        lvSalesReport.Name = "lvSalesReport"
        lvSalesReport.OwnerDraw = True
        lvSalesReport.Size = New Size(786, 191)
        lvSalesReport.TabIndex = 0
        lvSalesReport.UseCompatibleStateImageBehavior = False
        lvSalesReport.View = View.Details
        ' 
        ' colIndex
        ' 
        colIndex.Text = "Index"
        colIndex.Width = 100
        ' 
        ' colName
        ' 
        colName.Text = "Name"
        colName.Width = 200
        ' 
        ' colUnitsSold
        ' 
        colUnitsSold.Text = "Units Sold"
        colUnitsSold.TextAlign = HorizontalAlignment.Center
        colUnitsSold.Width = 200
        ' 
        ' colRevenue
        ' 
        colRevenue.Text = "Item Revenue"
        colRevenue.TextAlign = HorizontalAlignment.Center
        colRevenue.Width = 200
        ' 
        ' uc_Reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard6)
        Controls.Add(MaterialCard5)
        Controls.Add(MaterialCard4)
        Controls.Add(MaterialCard3)
        Controls.Add(MaterialCard2)
        Controls.Add(MaterialCard1)
        MinimumSize = New Size(825, 471)
        Name = "uc_Reports"
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents lvLowStock As MaterialSkin.Controls.MaterialListView
    Friend WithEvents colLowStockName As ColumnHeader
    Friend WithEvents colLowStock As ColumnHeader
    Friend WithEvents pnlLowStock As Panel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblTotalItemsSold As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTextTotalItemsSold As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pnlTotalItemsSold As Panel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pnlBestSellingItem As Panel
    Friend WithEvents lblBestSellingItem As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTextBestSellingItem As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents pnlTotalRevenue As Panel
    Friend WithEvents lblTotalRevenue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTextTotalRevenue As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblExportText As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lvSalesReport As MaterialSkin.Controls.MaterialListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colUnitsSold As ColumnHeader
    Friend WithEvents colRevenue As ColumnHeader
    Friend WithEvents colIndex As ColumnHeader
    Friend WithEvents lblLowStock As MaterialSkin.Controls.MaterialLabel

End Class
