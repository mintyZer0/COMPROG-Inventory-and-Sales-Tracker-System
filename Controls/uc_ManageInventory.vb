Imports System.Text

Public Class uc_ManageInventory
    Public Sub Refreshdata()
        lvInventoryDataGrid.RefreshList()
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim price As Double
        Dim stock As Integer
        If txtProdName.Text.Trim() = "" OrElse Not Double.TryParse(txtPrice.Text, price) OrElse price <= 0 OrElse Not Integer.TryParse(txtStock.Text, stock) OrElse stock <= 0 Then
            MsgBox("Please fill the required fields with appropriate values to add a new product.", vbExclamation, "Invalid Input")
            Return
        End If

        Database.AddNewProduct(txtProdName.Text, Val(price), Val(stock))
        lvInventoryDataGrid.RefreshList()

        txtProdName.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        If txtSearch.Text.Trim() = "" Then
            lvInventoryDataGrid.RefreshList()
            Return
        Else
            lvInventoryDataGrid.SearchList(txtSearch.Text.Trim().ToLower())
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvInventoryDataGrid.DataGrid.SelectedItems.Count = 0 Then
            MsgBox("Choose a product to edit.")
            Return
        ElseIf lvInventoryDataGrid.DataGrid.SelectedItems.Count > 1 Then
            MsgBox("Please select only one product to edit.")
            Return
        End If
        Dim editWindow As New InventoryEdit()

        editWindow.editIndex = CInt(lvInventoryDataGrid.DataGrid.SelectedItems(0).Tag)
        editWindow.ShowDialog()
        lvInventoryDataGrid.RefreshList()

    End Sub

    Private Sub uc_ManageInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvInventoryDataGrid.ResizeColumns()
        AddHandler lvInventoryDataGrid.SortApplied, AddressOf ClearSearch
        AddHandler Database.InventoryChange, AddressOf Me.Refreshdata
    End Sub

    Private Sub ClearSearch()
        txtSearch.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedIndex As Integer
        Dim selectedProducts As New System.Text.StringBuilder()
        For Each item As ListViewItem In lvInventoryDataGrid.DataGrid.SelectedItems
            selectedProducts.AppendLine("- " & item.SubItems(1).Text)
        Next

        Dim deleteProduct As DialogResult = MsgBox("Are you sure to delete selected product? " & vbCrLf & selectedProducts.ToString(), vbYesNo + vbQuestion)
        If deleteProduct = DialogResult.No Then Return

        If lvInventoryDataGrid.DataGrid.SelectedIndices.Count = 0 Then
            MsgBox("Please select a product to remove.")
            Return
        ElseIf lvInventoryDataGrid.DataGrid.SelectedIndices.Count > 1 Then
            DeleteMultipleProducts()
        Else
            selectedIndex = CInt(lvInventoryDataGrid.DataGrid.SelectedIndices(0))
            Database.DeleteProduct(selectedIndex)
            lvInventoryDataGrid.RefreshList()
        End If


    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "CSV Files (*.csv)|*.csv|Excel Workbook (*.xlsx)|*.xlsx"
            ofd.Title = "Select Import File"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim added As Integer = 0
                Dim updated As Integer = 0
                Dim failed As Integer = 0

                Try
                    If ofd.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase) Then
                        ImportFromCSV(ofd.FileName, added, updated, failed)
                    ElseIf ofd.FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) Then
                        ImportFromExcel(ofd.FileName, added, updated, failed)
                    End If

                    MsgBox($"Import Complete!{vbCrLf}Added: {added}{vbCrLf}Updated: {updated}{vbCrLf}Failed: {failed}", vbInformation, "Import Summary")
                    lvInventoryDataGrid.RefreshList()
                Catch ex As Exception
                    MsgBox("An error occurred during import: " & ex.Message, vbCritical, "Import Error")
                End Try
            End If
        End Using
    End Sub

    Private Sub ImportFromCSV(filePath As String, ByRef added As Integer, ByRef updated As Integer, ByRef failed As Integer)
        Dim lines = System.IO.File.ReadAllLines(filePath)
        If lines.Length <= 1 Then Return ' Header only or empty

        For i As Integer = 1 To lines.Length - 1 ' Skip header
            Dim line = lines(i)
            If String.IsNullOrWhiteSpace(line) Then Continue For

            Dim parts = ParseCSVLine(line)
            If parts.Count >= 3 Then
                Dim name = parts(0).Trim()
                Dim price As Double
                Dim stock As Integer

                If Double.TryParse(parts(1), price) AndAlso Integer.TryParse(parts(2), stock) Then
                    Database.ImportProduct(name, price, stock, added, updated)
                Else
                    failed += 1
                End If
            Else
                failed += 1
            End If
        Next
    End Sub

    Private Function ParseCSVLine(line As String) As List(Of String)
        Dim result As New List(Of String)()
        Dim currentPart As New StringBuilder()
        Dim inQuotes As Boolean = False

        For i As Integer = 0 To line.Length - 1
            Dim c = line(i)
            If c = """"c Then
                inQuotes = Not inQuotes
            ElseIf c = ","c AndAlso Not inQuotes Then
                result.Add(currentPart.ToString())
                currentPart.Clear()
            Else
                currentPart.Append(c)
            End If
        Next
        result.Add(currentPart.ToString())
        Return result
    End Function

    Private Sub ImportFromExcel(filePath As String, ByRef added As Integer, ByRef updated As Integer, ByRef failed As Integer)
        Dim excelApp As Object = Nothing
        Dim workbook As Object = Nothing
        Dim sheet As Object = Nothing

        Try
            excelApp = CreateObject("Excel.Application")
            workbook = excelApp.Workbooks.Open(filePath)
            sheet = workbook.Sheets(1)

            Dim row As Integer = 2 ' Skip header
            While True
                Dim name = Convert.ToString(sheet.Cells(row, 1).Value)
                If String.IsNullOrEmpty(name) Then Exit While

                Dim priceVal = sheet.Cells(row, 2).Value
                Dim stockVal = sheet.Cells(row, 3).Value

                Dim price As Double
                Dim stock As Integer

                If priceVal IsNot Nothing AndAlso stockVal IsNot Nothing AndAlso
                   Double.TryParse(priceVal.ToString(), price) AndAlso
                   Integer.TryParse(stockVal.ToString(), stock) Then
                    Database.ImportProduct(name, price, stock, added, updated)
                Else
                    failed += 1
                End If

                row += 1
            End While
        Finally
            If workbook IsNot Nothing Then
                workbook.Close(False)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            End If
            If excelApp IsNot Nothing Then
                excelApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
            End If
        End Try
    End Sub

    Private Sub DeleteMultipleProducts()
        For i As Integer = lvInventoryDataGrid.DataGrid.SelectedIndices.Count - 1 To 0 Step -1
            Dim selectedProduct As Integer = lvInventoryDataGrid.DataGrid.SelectedIndices(i)
            Database.DeleteProduct(selectedProduct)
        Next
        lvInventoryDataGrid.RefreshList()
    End Sub
End Class
