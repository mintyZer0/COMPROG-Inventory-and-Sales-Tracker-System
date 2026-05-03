Imports MaterialSkin

Public Class uc_Dashboard
    Private Sub ApplyPaint()
        pnlTotalRevenue.BackColor = Color.FromArgb(144, 238, 144)
        pnlProductsSold.BackColor = Color.FromArgb(83, 162, 190)
        pnlInventoryCount.BackColor = Color.FromArgb(200, 230, 240)
        pnlInventoryValue.BackColor = Color.FromArgb(103, 58, 183)
        If pnlMostSold IsNot Nothing Then pnlMostSold.BackColor = Color.FromArgb(255, 193, 7)
        If pnlLeastSold IsNot Nothing Then pnlLeastSold.BackColor = Color.FromArgb(255, 193, 7)
        If pnlLowStock_New IsNot Nothing Then pnlLowStock_New.BackColor = Color.FromArgb(174, 78, 78)
        If pnlOutOfStock_New IsNot Nothing Then pnlOutOfStock_New.BackColor = Color.FromArgb(244, 67, 54)
    End Sub

    Private Sub SetValues()
        lblInventoryCount.Text = Database.GetProductCount().ToString()
        lblTotalRevenue.Text = "₱" & Database.GetTotalRevenue().ToString("F2")
        lblProductsSold.Text = Database.GetTotalProductsSold().ToString()
        lblInventoryValue.Text = "₱" & Database.GetTotalInventoryValue().ToString("F2")

        RefreshDashboardLists()
    End Sub

    Private Sub RefreshDashboardLists()
        lbHighestSelling.Items.Clear()
        lbLeastSelling.Items.Clear()
        lbOutOfStock.Items.Clear()
        lbLowStock.Items.Clear()

        ' Most Sold (Top 5)
        For Each index In Database.GetMostSoldIndices()
            Dim listItem As New MaterialListBoxItem()
            listItem.Text = Database.GetProductName(index)
            listItem.SecondaryText = "Units Sold: " & Database.GetSoldCount(index).ToString()
            listItem.Tag = index
            lbHighestSelling.Items.Add(listItem)
        Next

        ' Least Sold (Top 5)
        For Each index In Database.GetLeastSoldIndices()
            Dim listItem As New MaterialListBoxItem()
            listItem.Text = Database.GetProductName(index)
            listItem.SecondaryText = "Units Sold: " & Database.GetSoldCount(index).ToString()
            listItem.Tag = index
            lbLeastSelling.Items.Add(listItem)
        Next

        ' Low Stock
        For Each index In Database.GetLowStockIndices()
            Dim listItem As New MaterialListBoxItem()
            listItem.Text = Database.GetProductName(index)
            listItem.SecondaryText = "Current Stock: " & Database.GetProductStock(index).ToString()
            listItem.Tag = index
            lbLowStock.Items.Add(listItem)
        Next

        ' Out of Stock
        For Each index In Database.GetNoStockIndices()
            Dim listItem As New MaterialListBoxItem()
            listItem.Text = Database.GetProductName(index)
            listItem.SecondaryText = "Stock: 0"
            listItem.Tag = index
            lbOutOfStock.Items.Add(listItem)
        Next
    End Sub

    Private Sub uc_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPaint()
        SetValues()
    End Sub

    Private Sub uc_Dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            ApplyPaint()
            SetValues()
        End If
    End Sub
End Class
