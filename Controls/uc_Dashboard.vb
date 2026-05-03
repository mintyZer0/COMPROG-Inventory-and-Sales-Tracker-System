Public Class uc_Dashboard
    Private Sub ApplyPaint()
        pnlTotalRevenue.BackColor = Color.FromArgb(144, 238, 144)
        pnlProductsSold.BackColor = Color.FromArgb(83, 162, 190)
        pnlLowStock.BackColor = Color.FromArgb(174, 78, 78)
        pnlInventoryCount.BackColor = Color.FromArgb(200, 230, 240)
    End Sub
    Private Sub SetValues()
        lblInventoryCount.Text = Database.GetProductCount().ToString()
        lblLowStock.Text = Database.GetLowStockCount().ToString()
        lblTotalRevenue.Text = "₱" & Database.GetTotalRevenue().ToString("F2")
        lblProductsSold.Text = Database.GetTotalProductsSold().ToString()
    End Sub
    Private Sub uc_Dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            ApplyPaint()
        End If
    End Sub
End Class
