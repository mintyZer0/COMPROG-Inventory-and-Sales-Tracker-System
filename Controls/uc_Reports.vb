Public Class uc_Reports
    Private Sub uc_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeColumns()
    End Sub

    Public Sub RefreshSalesReportList()
        lvSalesReport.Items.Clear()
        For i As Integer = 0 To Database.GetProductCount() - 1
            Dim row As New ListViewItem(i + 1)
            row.Tag = i
            row.SubItems.Add(Database.GetProductName(i).ToString())
            row.SubItems.Add(Database.GetSoldCount(i).ToString())
            row.SubItems.Add("₱" & Database.GetItemRevenue(i).ToString("F2"))
            lvSalesReport.Items.Add(row)
        Next
        ResizeColumns()
    End Sub

    Private Sub ResizeColumns()
        If lvSalesReport.Columns.Count > 0 Then
            Dim totalWidth As Integer = lvSalesReport.ClientSize.Width
            lvSalesReport.Columns(0).Width = totalWidth * 0.1
            lvSalesReport.Columns(1).Width = totalWidth * 0.4
            lvSalesReport.Columns(2).Width = totalWidth * 0.25
            lvSalesReport.Columns(3).Width = totalWidth * 0.25
        End If
    End Sub

    Private Sub uc_Reports_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeColumns()
    End Sub

    Private Sub lvSalesReport_VisibleChanged(sender As Object, e As EventArgs) Handles lvSalesReport.VisibleChanged
        If Me.Visible Then
            RefreshSalesReportList()
            ResizeColumns()
        End If
    End Sub
End Class
