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
        MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        lvSalesReport = New MaterialSkin.Controls.MaterialListView()
        colIndex = New ColumnHeader()
        colName = New ColumnHeader()
        colUnitsSold = New ColumnHeader()
        colRevenue = New ColumnHeader()
        btnExport = New MaterialSkin.Controls.MaterialButton()
        lblExportText = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard6.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialCard6
        ' 
        MaterialCard6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard6.Controls.Add(lvSalesReport)
        MaterialCard6.Depth = 0
        MaterialCard6.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard6.Location = New Point(14, 70)
        MaterialCard6.Margin = New Padding(14)
        MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard6.Name = "MaterialCard6"
        MaterialCard6.Padding = New Padding(14)
        MaterialCard6.Size = New Size(796, 387)
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
        lvSalesReport.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lvSalesReport.FullRowSelect = True
        lvSalesReport.Location = New Point(5, 6)
        lvSalesReport.MinimumSize = New Size(200, 100)
        lvSalesReport.MouseLocation = New Point(-1, -1)
        lvSalesReport.MouseState = MaterialSkin.MouseState.OUT
        lvSalesReport.Name = "lvSalesReport"
        lvSalesReport.OwnerDraw = True
        lvSalesReport.Size = New Size(786, 375)
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
        colName.TextAlign = HorizontalAlignment.Center
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
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExport.AutoSize = False
        btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnExport.Depth = 0
        btnExport.HighEmphasis = True
        btnExport.Icon = Nothing
        btnExport.Location = New Point(652, 20)
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
        lblExportText.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblExportText.AutoSize = True
        lblExportText.Depth = 0
        lblExportText.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblExportText.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblExportText.Location = New Point(504, 26)
        lblExportText.MouseState = MaterialSkin.MouseState.HOVER
        lblExportText.Name = "lblExportText"
        lblExportText.Size = New Size(141, 24)
        lblExportText.TabIndex = 0
        lblExportText.Text = "Export to HTML"
        ' 
        ' uc_Reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblExportText)
        Controls.Add(btnExport)
        Controls.Add(MaterialCard6)
        MinimumSize = New Size(825, 471)
        Name = "uc_Reports"
        Size = New Size(825, 471)
        MaterialCard6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lvSalesReport As MaterialSkin.Controls.MaterialListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colUnitsSold As ColumnHeader
    Friend WithEvents colRevenue As ColumnHeader
    Friend WithEvents colIndex As ColumnHeader
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblExportText As MaterialSkin.Controls.MaterialLabel
End Class
