Public Class uc_Reports
    Private Sub uc_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPaint()
        colLowStockName.Width = lvLowStock.Width - 4
        colLowStockName.Width = colLowStockName.Width - colLowStock.Width
        colLowStockName.TextAlign = HorizontalAlignment.Center
        colName.TextAlign = HorizontalAlignment.Center
        colIndex.TextAlign = HorizontalAlignment.Center
        colUnitsSold.TextAlign = HorizontalAlignment.Center
        colRevenue.TextAlign = HorizontalAlignment.Center
    End Sub

    Public Sub SetBestSellingItem()
        lblBestSellingItem.Text = Database.GetBestSellingItem()
    End Sub

    Public Sub SetTotalItemsSold()
        lblTotalItemsSold.Text = Database.GetTotalProductsSold().ToString()
    End Sub

    Public Sub SetTotalRevenue()
        lblTotalRevenue.Text = "₱" & Database.GetTotalRevenue().ToString("F2")
    End Sub

    Public Sub RefreshLowStockList()
        lvLowStock.Items.Clear()
        For i As Integer = 0 To Database.GetProductCount() - 1
            If Database.IsLowStock(i) Then
                Dim row As New ListViewItem(Database.GetProductName(i).ToString())
                row.Tag = i
                row.SubItems.Add(Database.GetProductStock(i).ToString())
                lvLowStock.Items.Add(row)
            End If
        Next
    End Sub

    Public Sub RefreshSalesReportList()
        lvSalesReport.Items.Clear()
        For i As Integer = 0 To Database.GetProductCount() - 1
            Dim row As New ListViewItem(i + 1)
            row.Tag = i
            row.SubItems.Add(Database.GetProductName(i).ToString())
            row.SubItems.Add(Database.GetSoldCount(i).ToString())
            row.SubItems.Add(Database.GetItemRevenue(i).ToString())
            lvSalesReport.Items.Add(row)
        Next
    End Sub

    Private Sub ApplyPaint()
        pnlLowStock.BackColor = Color.FromArgb(174, 78, 78)
        pnlTotalItemsSold.BackColor = Color.FromArgb(83, 162, 190)
        pnlBestSellingItem.BackColor = Color.FromArgb(255, 193, 7)
        pnlTotalRevenue.BackColor = Color.FromArgb(144, 238, 144)
    End Sub

    Private Sub lvSalesReport_VisibleChanged(sender As Object, e As EventArgs) Handles lvSalesReport.VisibleChanged
        If Me.Visible Then
            RefreshSalesReportList()
            RefreshLowStockList()
            SetBestSellingItem()
            SetTotalItemsSold()
            SetTotalRevenue()
        End If
    End Sub

    Private Sub lblTotalRevenue_Click(sender As Object, e As EventArgs) Handles lblTotalRevenue.Click

    End Sub
End Class
