Public Class InventoryEdit
    Public editIndex As Integer
    Private Sub InventoryEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewProdName.Text = Database.GetProductName(editIndex)
        txtNewPrice.Text = Database.GetProductPrice(editIndex).ToString()
        txtNewStock.Text = Database.GetProductStock(editIndex).ToString()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtNewProdName.Text.Trim() = "" OrElse Not IsNumeric(txtNewPrice.Text) OrElse Val(txtNewPrice.Text) <= 0 OrElse Not IsNumeric(txtNewStock.Text) OrElse Val(txtNewStock.Text) < 0 Then
            MsgBox("Please fill in the required fields before finalizing edit.")
        End If
        Database.UpdateProduct(editIndex, txtNewPrice.Text, txtNewPrice.Text, txtNewStock.Text)
        Me.Close()
    End Sub
End Class