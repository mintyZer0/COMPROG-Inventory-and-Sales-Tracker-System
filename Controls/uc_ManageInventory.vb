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
    Private Sub DeleteMultipleProducts()
        For i As Integer = lvInventoryDataGrid.DataGrid.SelectedIndices.Count - 1 To 0 Step -1
            Dim selectedProduct As Integer = lvInventoryDataGrid.DataGrid.SelectedIndices(i)
            Database.DeleteProduct(selectedProduct)
        Next
        lvInventoryDataGrid.RefreshList()
    End Sub
End Class
