Imports MaterialSkin

Public Class uc_TransactionLog
    Private Sub uc_TransactionLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshTransactions()
        ResizeColumns()
    End Sub

    Public Sub RefreshTransactions()
        lvTransactions.Items.Clear()
        lvDetails.Items.Clear()
        lblDetailsHeader.Text = "Select a transaction"

        For i As Integer = 0 To Database.GetTransactionCount() - 1
            Dim row As New ListViewItem((i + 1).ToString())
            row.SubItems.Add(Database.GetTransTimestamp(i))
            row.SubItems.Add("₱" & Database.GetTransTotal(i).ToString("F2"))
            row.Tag = i
            lvTransactions.Items.Add(row)
        Next
    End Sub

    Private Sub lvTransactions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTransactions.SelectedIndexChanged
        If lvTransactions.SelectedItems.Count > 0 Then
            Dim transIdx = CInt(lvTransactions.SelectedItems(0).Tag)
            ShowDetails(transIdx)
        End If
    End Sub

    Private Sub ShowDetails(transIdx As Integer)
        lvDetails.Items.Clear()
        lblDetailsHeader.Text = "Details for Transaction #" & (transIdx + 1)

        For i As Integer = 0 To Database.GetDetailCount() - 1
            If Database.GetDetailTransIndex(i) = transIdx Then
                Dim name = Database.GetDetailProdName(i)
                Dim qty = Database.GetDetailQuantity(i)
                Dim price = Database.GetDetailProdPrice(i)
                Dim subtotal = qty * price

                Dim row As New ListViewItem(name)
                row.SubItems.Add(qty.ToString())
                row.SubItems.Add("₱" & price.ToString("F2"))
                row.SubItems.Add("₱" & subtotal.ToString("F2"))
                lvDetails.Items.Add(row)
            End If
        Next
        ResizeDetailsColumns()
    End Sub

    Private Sub ResizeColumns()
        If lvTransactions.Columns.Count >= 3 Then
            Dim totalWidth As Integer = lvTransactions.ClientSize.Width
            lvTransactions.Columns(0).Width = totalWidth * 0.15
            lvTransactions.Columns(1).Width = totalWidth * 0.5
            lvTransactions.Columns(2).Width = totalWidth * 0.35
        End If
        ResizeDetailsColumns()
    End Sub

    Private Sub ResizeDetailsColumns()
        If lvDetails.Columns.Count >= 4 Then
            Dim totalWidth As Integer = lvDetails.ClientSize.Width
            lvDetails.Columns(0).Width = totalWidth * 0.5
            lvDetails.Columns(1).Width = totalWidth * 0.15
            lvDetails.Columns(2).Width = totalWidth * 0.15
            lvDetails.Columns(3).Width = totalWidth * 0.2
        End If
    End Sub

    Private Sub uc_TransactionLog_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeColumns()
    End Sub

    Private Sub lvTransactions_VisibleChanged(sender As Object, e As EventArgs) Handles lvTransactions.VisibleChanged
        If Me.Visible Then
            RefreshTransactions()
            ResizeColumns()
        End If
    End Sub
End Class
