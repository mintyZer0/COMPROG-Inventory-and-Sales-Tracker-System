Public Class uc_Reports
    Private Sub uc_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeColumns()
    End Sub

    Public Sub RefreshSalesReportList()
        lvSalesReport.Items.Clear()

        Dim startDate As DateTime = DateTime.MinValue
        Dim endDate As DateTime = DateTime.MaxValue

        Select Case cmbDateRange.Text
            Case "This Week"
                ' Get most recent Sunday
                Dim diff = Today.DayOfWeek - DayOfWeek.Sunday
                startDate = Today.AddDays(-1 * diff).Date
                endDate = DateTime.MaxValue
            Case "This Month"
                startDate = New DateTime(Today.Year, Today.Month, 1)
                endDate = DateTime.MaxValue
            Case "This Year"
                startDate = New DateTime(Today.Year, 1, 1)
                endDate = DateTime.MaxValue
            Case "Custom Range"
                startDate = dtpStart.Value.Date
                endDate = dtpEnd.Value.Date.AddDays(1).AddSeconds(-1)
            Case Else ' All Time
                startDate = DateTime.MinValue
                endDate = DateTime.MaxValue
        End Select

        For i As Integer = 0 To Database.GetProductCount() - 1
            Dim pName = Database.GetProductName(i)
            Dim units = Database.GetSoldCountInRange(pName, startDate, endDate)

            If units > 0 Then
                Dim revenue = Database.GetRevenueInRange(pName, startDate, endDate)
                Dim row As New ListViewItem(lvSalesReport.Items.Count + 1)
                row.SubItems.Add(pName)
                row.SubItems.Add("₱" & Database.GetProductPrice(i).ToString("F2"))
                row.SubItems.Add(units.ToString())
                row.SubItems.Add("₱" & revenue.ToString("F2"))
                lvSalesReport.Items.Add(row)
            End If
        Next
        ResizeColumns()
    End Sub

    Private Sub cmbDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDateRange.SelectedIndexChanged
        pnlCustomRange.Visible = (cmbDateRange.Text = "Custom Range")
        RefreshSalesReportList()
    End Sub

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        RefreshSalesReportList()
    End Sub

    Private Sub dtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnd.ValueChanged
        RefreshSalesReportList()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "HTML Files (*.html)|*.html"
        sfd.Title = "Export Sales Report"
        sfd.FileName = "SalesReport_" & DateTime.Now.ToString("yyyyMMdd") & ".html"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim html As New System.Text.StringBuilder()
                Dim dateRangeText As String = cmbDateRange.Text
                If cmbDateRange.Text = "Custom Range" Then
                    dateRangeText &= $" ({dtpStart.Value.ToShortDateString()} - {dtpEnd.Value.ToShortDateString()})"
                End If

                html.AppendLine("<!DOCTYPE html>")
                html.AppendLine("<html>")
                html.AppendLine("<head>")
                html.AppendLine("<title>Sales Report</title>")
                html.AppendLine("<style>")
                html.AppendLine("body { font-family: 'Segoe UI', Arial, sans-serif; margin: 40px; color: #333; }")
                html.AppendLine("h1 { color: #1a73e8; margin-bottom: 10px; }")
                html.AppendLine(".metadata { margin-bottom: 30px; color: #666; }")
                html.AppendLine("table { width: 100%; border-collapse: collapse; margin-top: 20px; box-shadow: 0 2px 5px rgba(0,0,0,0.1); }")
                html.AppendLine("th, td { border: 1px solid #eee; padding: 15px; text-align: left; }")
                html.AppendLine("th { background-color: #f8f9fa; font-weight: 600; color: #444; text-transform: uppercase; font-size: 0.85em; }")
                html.AppendLine("tr:nth-child(even) { background-color: #fafafa; }")
                html.AppendLine("tr:hover { background-color: #f1f3f4; }")
                html.AppendLine(".summary { margin-top: 40px; padding: 20px; background-color: #f8f9fa; border-radius: 8px; border-left: 5px solid #1a73e8; }")
                html.AppendLine(".summary-item { font-size: 1.1em; margin-bottom: 10px; }")
                html.AppendLine(".summary-label { font-weight: 600; color: #555; display: inline-block; width: 180px; }")
                html.AppendLine(".summary-value { font-weight: 700; color: #1a73e8; font-size: 1.2em; }")
                html.AppendLine("</style>")
                html.AppendLine("</head>")
                html.AppendLine("<body>")
                html.AppendLine($"<h1>Sales Report</h1>")
                html.AppendLine("<div class='metadata'>")
                html.AppendLine($"<div><strong>Range:</strong> {dateRangeText}</div>")
                html.AppendLine($"<div><strong>Generated:</strong> {DateTime.Now.ToString("f")}</div>")
                html.AppendLine("</div>")

                html.AppendLine("<table>")
                html.AppendLine("<thead>")
                html.AppendLine("<tr>")
                For Each col As ColumnHeader In lvSalesReport.Columns
                    html.AppendLine($"<th>{col.Text}</th>")
                Next
                html.AppendLine("</tr>")
                html.AppendLine("</thead>")
                html.AppendLine("<tbody>")

                Dim totalUnits As Integer = 0
                Dim totalRevenue As Double = 0

                For Each item As ListViewItem In lvSalesReport.Items
                    html.AppendLine("<tr>")
                    For i As Integer = 0 To item.SubItems.Count - 1
                        html.AppendLine($"<td>{item.SubItems(i).Text}</td>")
                    Next
                    html.AppendLine("</tr>")

                    ' Calculate totals (Index 3 is Units Sold, Index 4 is Revenue)
                    Dim units As Integer = 0
                    Dim revenue As Double = 0
                    Integer.TryParse(item.SubItems(3).Text, units)
                    ' Remove currency symbol for parsing
                    Dim revText As String = item.SubItems(4).Text.Replace("₱", "").Replace(",", "").Trim()
                    Double.TryParse(revText, revenue)

                    totalUnits += units
                    totalRevenue += revenue
                Next

                html.AppendLine("</tbody>")
                html.AppendLine("</table>")

                html.AppendLine("<div class='summary'>")
                html.AppendLine($"<div class='summary-item'><span class='summary-label'>Total Units Sold:</span><span class='summary-value'>{totalUnits}</span></div>")
                html.AppendLine($"<div class='summary-item'><span class='summary-label'>Total Revenue:</span><span class='summary-value'>₱{totalRevenue.ToString("N2")}</span></div>")
                html.AppendLine("</div>")

                html.AppendLine("</body>")
                html.AppendLine("</html>")

                System.IO.File.WriteAllText(sfd.FileName, html.ToString())
                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error exporting report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ResizeColumns()
        If lvSalesReport.Columns.Count > 0 Then
            Dim totalWidth As Integer = lvSalesReport.ClientSize.Width
            lvSalesReport.Columns(0).Width = totalWidth * 0.1
            lvSalesReport.Columns(1).Width = totalWidth * 0.3
            lvSalesReport.Columns(2).Width = totalWidth * 0.2
            lvSalesReport.Columns(3).Width = totalWidth * 0.2
            lvSalesReport.Columns(4).Width = totalWidth * 0.2
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
