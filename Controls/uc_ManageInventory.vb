Public Class uc_ManageInventory
    Public Sub Refreshdata()
        lvInventoryDataGrid.RefreshList()
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If txtProdName.Text.Trim() = "" Or Val(txtPrice.Text) <= 0 Or Val(txtStock.Text) <= 0 Then
            Return
        End If

        Database.AddNewProduct(txtProdName.Text, Val(txtPrice.Text), Val(txtStock.Text))

        lvInventoryDataGrid.RefreshList()

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
        If lvInventoryDataGrid.DataGrid.SelectedItems.Count > 0 Then
            Dim editWindow As New InventoryEdit()

            editWindow.editIndex = CInt(lvInventoryDataGrid.DataGrid.SelectedItems(0).Tag)
            editWindow.ShowDialog()
            lvInventoryDataGrid.RefreshList()
        Else
            MsgBox("Choose an Item to Edit.")

        End If
    End Sub

    Private Sub uc_ManageInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvInventoryDataGrid.ResizeColumns()
    End Sub
End Class
