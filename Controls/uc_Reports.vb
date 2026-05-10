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
                Dim lastSold = Database.GetLastSoldDate(pName)

                Dim row As New ListViewItem(lvSalesReport.Items.Count + 1)
                row.SubItems.Add(pName)
                row.SubItems.Add("₱" & Database.GetProductPrice(i).ToString("F2"))
                row.SubItems.Add(units.ToString())
                row.SubItems.Add("₱" & revenue.ToString("F2"))
                row.SubItems.Add(lastSold)
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
        Dim dateRangeText As String = cmbDateRange.Text
        If cmbDateRange.Text = "Custom Range" Then
            dateRangeText = $"{dtpStart.Value.ToString("yyyy-MM-dd")}_to_{dtpEnd.Value.ToString("yyyy-MM-dd")}"
        Else
            dateRangeText = dateRangeText.Replace(" ", "")
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Title = "Export Sales Report"

        Dim format As String = cmbExportFormat.Text
        Dim baseFileName As String = $"SalesReport_{dateRangeText}_{DateTime.Now.ToString("yyyyMMdd")}"

        If format.StartsWith("CSV") Then
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = baseFileName & ".csv"
        ElseIf format = "HTML" Then
            sfd.Filter = "HTML Files (*.html)|*.html"
            sfd.FileName = baseFileName & ".html"
        ElseIf format.StartsWith("Excel") Then
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            sfd.FileName = baseFileName & ".xlsx"
        ElseIf format = "PDF" Then
            sfd.Filter = "PDF Files (*.pdf)|*.pdf"
            sfd.FileName = baseFileName & ".pdf"
        Else
            MessageBox.Show("This export format is not yet implemented.", "Format Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If sfd.ShowDialog() = DialogResult.OK Then
            If format.StartsWith("CSV") Then
                ExportToCSV(sfd.FileName, dateRangeText)
            ElseIf format = "HTML" Then
                ExportToHTML(sfd.FileName, dateRangeText)
            ElseIf format.StartsWith("Excel") Then
                ExportToExcel(sfd.FileName, dateRangeText)
            ElseIf format = "PDF" Then
                ExportToPDF(sfd.FileName, dateRangeText)
            End If
        End If
    End Sub

    Private Sub ExportToExcel(filePath As String, dateRangeText As String)
        Dim excelApp As Object = Nothing
        Dim workbook As Object = Nothing
        Dim sheet As Object = Nothing

        Try
            excelApp = CreateObject("Excel.Application")
            workbook = excelApp.Workbooks.Add()
            sheet = workbook.Sheets(1)
            sheet.Name = "Sales Data"

            ' Headers start at Row 1, Column 1
            For i As Integer = 0 To lvSalesReport.Columns.Count - 1
                sheet.Cells(1, i + 1).Value = lvSalesReport.Columns(i).Text
                sheet.Cells(1, i + 1).Font.Bold = True
                sheet.Cells(1, i + 1).Interior.Color = RGB(240, 240, 240)
            Next

            ' Data starts at Row 2
            Dim currentExcelRow As Integer = 2
            For Each item As ListViewItem In lvSalesReport.Items
                sheet.Cells(currentExcelRow, 1).Value = item.SubItems(0).Text ' Index
                sheet.Cells(currentExcelRow, 2).Value = item.SubItems(1).Text ' Name

                ' Price
                Dim price As Double = 0
                Double.TryParse(item.SubItems(2).Text.Replace("₱", "").Replace(",", "").Trim(), price)
                sheet.Cells(currentExcelRow, 3).Value = price

                ' Units
                Dim units As Integer = 0
                Integer.TryParse(item.SubItems(3).Text, units)
                sheet.Cells(currentExcelRow, 4).Value = units

                ' Revenue Formula (Col E = C * D)
                sheet.Cells(currentExcelRow, 5).Formula = $"=C{currentExcelRow}*D{currentExcelRow}"

                ' Last Sold
                sheet.Cells(currentExcelRow, 6).Value = item.SubItems(5).Text

                currentExcelRow += 1
            Next

            ' Summary at Column H (1, 8)
            Dim lastDataRow As Integer = currentExcelRow - 1
            sheet.Cells(1, 8).Value = "Total Revenue"
            sheet.Cells(1, 8).Font.Bold = True
            sheet.Cells(2, 8).Formula = $"=SUM(E2:E{lastDataRow})"
            sheet.Cells(2, 8).Font.Bold = True
            sheet.Cells(2, 8).NumberFormat = "₱#,##0.00"

            ' Formatting
            sheet.Columns("C:C").NumberFormat = "₱#,##0.00"
            sheet.Columns("E:E").NumberFormat = "₱#,##0.00"
            sheet.Columns("A:H").AutoFit()

            workbook.SaveAs(filePath)
            MessageBox.Show("Excel report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error exporting to Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If workbook IsNot Nothing Then workbook.Close(False)
            If excelApp IsNot Nothing Then excelApp.Quit()

            If sheet IsNot Nothing Then Runtime.InteropServices.Marshal.ReleaseComObject(sheet)
            If workbook IsNot Nothing Then Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            If excelApp IsNot Nothing Then Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub

    Private Function GenerateHTMLString(dateRangeText As String) As String
        Dim html As New System.Text.StringBuilder()

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
        html.AppendLine("@media print { .summary { break-inside: avoid; } @page { margin: 0.5in; } }")
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

        Return html.ToString()
    End Function

    Private Sub ExportToHTML(filePath As String, dateRangeText As String)
        Try
            Dim htmlContent = GenerateHTMLString(dateRangeText)
            System.IO.File.WriteAllText(filePath, htmlContent)
            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error exporting report as HTML: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportToPDF(filePath As String, dateRangeText As String)
        Try
            Dim tempHtmlPath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "report_temp.html")
            Dim htmlContent = GenerateHTMLString(dateRangeText)
            System.IO.File.WriteAllText(tempHtmlPath, htmlContent)

            ' Find Edge path (Common locations)
            Dim edgePath As String = ""
            Dim commonPaths As String() = {
                "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
                "C:\Program Files\Microsoft\Edge\Application\msedge.exe"
            }

            For Each path In commonPaths
                If System.IO.File.Exists(path) Then
                    edgePath = path
                    Exit For
                End If
            Next

            If String.IsNullOrEmpty(edgePath) Then
                Throw New Exception("Microsoft Edge could not be found. Please ensure it is installed.")
            End If

            ' Use Microsoft Edge (headless) to convert HTML to PDF
            Dim startInfo As New ProcessStartInfo()
            startInfo.FileName = edgePath
            startInfo.Arguments = $"--headless --disable-gpu --no-pdf-header-footer --print-to-pdf=""{filePath}"" ""{tempHtmlPath}"""
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            startInfo.CreateNoWindow = True

            Using proc As Process = Process.Start(startInfo)
                proc.WaitForExit(10000) ' Wait up to 10 seconds
            End Using

            If System.IO.File.Exists(filePath) Then
                MessageBox.Show("PDF report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Throw New Exception("Conversion failed. Please try again.")
            End If

            ' Cleanup
            If System.IO.File.Exists(tempHtmlPath) Then System.IO.File.Delete(tempHtmlPath)

        Catch ex As Exception
            MessageBox.Show("Error exporting to PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportToCSV(filePath As String, dateRangeText As String)
        Try
            Dim csv As New System.Text.StringBuilder()

            ' Column Headers at Row 1
            Dim headers As New List(Of String)()
            For Each col As ColumnHeader In lvSalesReport.Columns
                headers.Add($"""{col.Text.Replace("""", """""")}""")
            Next
            csv.AppendLine(String.Join(",", headers))

            ' Data Rows
            For Each item As ListViewItem In lvSalesReport.Items
                Dim fields As New List(Of String)()
                For i As Integer = 0 To item.SubItems.Count - 1
                    fields.Add($"""{item.SubItems(i).Text.Replace("""", """""")}""")
                Next
                csv.AppendLine(String.Join(",", fields))
            Next

            System.IO.File.WriteAllText(filePath, csv.ToString(), System.Text.Encoding.UTF8)
            MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error exporting report as CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResizeColumns()
        If lvSalesReport.Columns.Count >= 6 Then
            Dim totalWidth As Integer = lvSalesReport.ClientSize.Width
            lvSalesReport.Columns(0).Width = totalWidth * 0.05
            lvSalesReport.Columns(1).Width = totalWidth * 0.25
            lvSalesReport.Columns(2).Width = totalWidth * 0.15
            lvSalesReport.Columns(3).Width = totalWidth * 0.15
            lvSalesReport.Columns(4).Width = totalWidth * 0.2
            lvSalesReport.Columns(5).Width = totalWidth * 0.2
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
