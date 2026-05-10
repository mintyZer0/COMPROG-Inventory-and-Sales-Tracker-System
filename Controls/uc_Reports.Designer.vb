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
        colPrice = New ColumnHeader()
        colUnitsSold = New ColumnHeader()
        colRevenue = New ColumnHeader()
        colLastSold = New ColumnHeader()
        btnExport = New MaterialSkin.Controls.MaterialButton()

        cmbDateRange = New MaterialSkin.Controls.MaterialComboBox()
        pnlCustomRange = New Panel()
        dtpStart = New DateTimePicker()
        dtpEnd = New DateTimePicker()
        cmbExportFormat = New MaterialSkin.Controls.MaterialComboBox()
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
        lvSalesReport.Columns.AddRange(New ColumnHeader() {colIndex, colName, colPrice, colUnitsSold, colRevenue, colLastSold})
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
        ' colPrice
        ' 
        colPrice.Text = "Price"
        colPrice.TextAlign = HorizontalAlignment.Center
        colPrice.Width = 200
        ' 
        ' colUnitsSold
        ' 
        colUnitsSold.Text = "Units Sold"
        colUnitsSold.TextAlign = HorizontalAlignment.Center
        colUnitsSold.Width = 200
        ' 
        ' colRevenue
        ' 
        colRevenue.Text = "Total Item Revenue"
        colRevenue.TextAlign = HorizontalAlignment.Center
        colRevenue.Width = 200
        ' 
        ' colLastSold
        ' 
        colLastSold.Text = "Last Sold Date"
        colLastSold.TextAlign = HorizontalAlignment.Center
        colLastSold.Width = 200
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
        ' cmbDateRange
        ' 
        cmbDateRange.AutoResize = False
        cmbDateRange.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbDateRange.Depth = 0
        cmbDateRange.DrawMode = DrawMode.OwnerDrawVariable
        cmbDateRange.DropDownHeight = 174
        cmbDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDateRange.DropDownWidth = 121
        cmbDateRange.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cmbDateRange.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cmbDateRange.FormattingEnabled = True
        cmbDateRange.Hint = "Date Range"
        cmbDateRange.IntegralHeight = False
        cmbDateRange.ItemHeight = 43
        cmbDateRange.Items.AddRange(New Object() {"All Time", "This Week", "This Month", "This Year", "Custom Range"})
        cmbDateRange.Location = New Point(14, 14)
        cmbDateRange.MaxDropDownItems = 4
        cmbDateRange.MouseState = MaterialSkin.MouseState.OUT
        cmbDateRange.Name = "cmbDateRange"
        cmbDateRange.Size = New Size(180, 49)
        cmbDateRange.StartIndex = 0
        cmbDateRange.TabIndex = 8
        ' 
        ' pnlCustomRange
        ' 
        pnlCustomRange.Controls.Add(dtpStart)
        pnlCustomRange.Controls.Add(dtpEnd)
        pnlCustomRange.Location = New Point(200, 14)
        pnlCustomRange.Name = "pnlCustomRange"
        pnlCustomRange.Size = New Size(240, 49)
        pnlCustomRange.TabIndex = 9
        pnlCustomRange.Visible = False
        ' 
        ' dtpStart
        ' 
        dtpStart.Format = DateTimePickerFormat.Short
        dtpStart.Location = New Point(3, 12)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(110, 23)
        dtpStart.TabIndex = 0
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Format = DateTimePickerFormat.Short
        dtpEnd.Location = New Point(127, 12)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(110, 23)
        dtpEnd.TabIndex = 1
        ' 
        ' cmbExportFormat
        ' 
        cmbExportFormat.AutoResize = False
        cmbExportFormat.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cmbExportFormat.Depth = 0
        cmbExportFormat.DrawMode = DrawMode.OwnerDrawVariable
        cmbExportFormat.DropDownHeight = 174
        cmbExportFormat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbExportFormat.DropDownWidth = 121
        cmbExportFormat.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cmbExportFormat.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cmbExportFormat.FormattingEnabled = True
        cmbExportFormat.Hint = "Export Format"
        cmbExportFormat.IntegralHeight = False
        cmbExportFormat.ItemHeight = 43
        cmbExportFormat.Items.AddRange(New Object() {"HTML", "CSV", "PDF (Coming Soon)"})
        cmbExportFormat.Location = New Point(450, 14)
        cmbExportFormat.MaxDropDownItems = 4
        cmbExportFormat.MouseState = MaterialSkin.MouseState.OUT
        cmbExportFormat.Name = "cmbExportFormat"
        cmbExportFormat.Size = New Size(180, 49)
        cmbExportFormat.StartIndex = 0
        cmbExportFormat.TabIndex = 10
        ' 
        ' uc_Reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(cmbExportFormat)
        Controls.Add(pnlCustomRange)
        Controls.Add(cmbDateRange)
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
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colUnitsSold As ColumnHeader
    Friend WithEvents colRevenue As ColumnHeader
    Friend WithEvents colLastSold As ColumnHeader
    Friend WithEvents colIndex As ColumnHeader
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblExportText As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbDateRange As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents pnlCustomRange As Panel
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents cmbExportFormat As MaterialSkin.Controls.MaterialComboBox
End Class
