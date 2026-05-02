Public Class uc_ManageInventory
    Public Sub Refreshdata()
        InventoryDataGrid.RefreshList()
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If txtProdName.Text.Trim() = "" Or Val(txtPrice.Text) <= 0 Or Val(txtStock.Text) <= 0 Then
            Return
        End If

        Database.AddNewProduct(txtProdName.Text, Val(txtPrice.Text), Val(txtStock.Text))

        InventoryDataGrid.RefreshList()

    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        If txtSearch.Text.Trim() = "" Then
            InventoryDataGrid.RefreshList()
            Return
        Else
            InventoryDataGrid.SearchList(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If InventoryDataGrid.DataGrid.SelectedItems.Count > 0 Then
            Dim editWindow As New InventoryEdit()

            editWindow.editIndex = CInt(InventoryDataGrid.DataGrid.SelectedItems(0).Tag)
            editWindow.ShowDialog()
            InventoryDataGrid.RefreshList()
        Else
            MsgBox("Choose an Item to Edit.")

        End If
    End Sub
End Class
