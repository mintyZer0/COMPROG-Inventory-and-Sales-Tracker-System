Public Class uc_Dashboard
    Private Sub Apply_Paint(sender As Object, e As PaintEventArgs) _
        Handles pnlLowStock.Paint, pnlTotalRevenue.Paint, pnlProductsSold.Paint, pnlInventoryCount.Paint

        Dim pnl = DirectCast(sender, Panel)

        ' Logic to apply colors based on which panel is currently being painted
        If pnl.Name = "pnlTotalRevenue" Then
            pnl.BackColor = Color.FromArgb(144, 238, 144)
        ElseIf pnl.Name = "pnlProductsSold" Then
            pnl.BackColor = Color.FromArgb(83, 162, 190)
        ElseIf pnl.Name = "pnlLowStock" Then
            pnl.BackColor = Color.FromArgb(174, 78, 78)
        Else
            pnl.BackColor = Color.FromArgb(200, 230, 240)
        End If
    End Sub

    Private Sub uc_Dashboard_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        lblInventoryCount.Text = Database.GetProductCount().ToString()
        lblLowStock.Text = Database.GetLowStockCount().ToString()
        lblTotalRevenue.Text = "₱" & Database.GetTotalRevenue().ToString("F2")
        lblProductsSold.Text = Database.GetTotalProductsSold().ToString()
    End Sub

    Private Sub MaterialCard3_Paint(sender As Object, e As PaintEventArgs) Handles MaterialCard3.Paint

    End Sub

    Private Sub uc_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
