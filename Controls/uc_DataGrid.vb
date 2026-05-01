Imports MaterialSkin.Controls

Public Class uc_DataGrid
    Private nameToggle As Boolean = True
    Private priceToggle As Boolean = True
    Private stockToggle As Boolean = True

    Public Sub RefreshList()
        DataGrid.Items.Clear()
        For i As Integer = 0 To Database.GetProductCount() - 1
            Dim row As New ListViewItem((i + 1).ToString())
            row.Tag = i

            row.SubItems.Add(Database.GetProductName(i).ToString())
            row.SubItems.Add("₱" & Database.GetProductPrice(i).ToString("F2"))
            row.SubItems.Add(Database.GetProductStock(i).ToString())

            DataGrid.Items.Add(row)
        Next
    End Sub

    Private Sub DataGrid_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles DataGrid.ColumnClick
        Dim colIndex As Integer = e.Column

        Select Case colIndex
            Case 1
                Database.Sort(colIndex, nameToggle)
                nameToggle = Not nameToggle
            Case 2
                Database.Sort(colIndex, priceToggle)
                priceToggle = Not priceToggle
            Case 3
                Database.Sort(colIndex, stockToggle)
                stockToggle = Not stockToggle
            Case Else
                Return
        End Select

        RefreshList()
    End Sub

    Public Sub SearchList(searched As String)
        DataGrid.Items.Clear()
        Dim word As String = searched.ToLower()

        For i As Integer = 0 To Database.GetProductCount() - 1
            Dim productName As String = Database.GetProductName(i).ToLower()
            If productName.Contains(word) Then
                Dim row As New ListViewItem((i + 1).ToString())
                row.Tag = i

                row.SubItems.Add(Database.GetProductName(i).ToString())
                row.SubItems.Add("₱" & Database.GetProductPrice(i).ToString("F2"))
                row.SubItems.Add(Database.GetProductStock(i).ToString())

                DataGrid.Items.Add(row)
            End If
        Next

    End Sub
End Class
