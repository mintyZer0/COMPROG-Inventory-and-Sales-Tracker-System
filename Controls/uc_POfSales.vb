Imports System.Collections.Generic
Imports System.IO
Imports MaterialSkin

Public Class uc_POfSales
    Private selectedQuantities As New Dictionary(Of Integer, Integer)

    Private qtySpinner As New NumericUpDown()

    Private Sub uc_POfsales_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MaterialListView1.Columns.Count = 0 Then
            MaterialListView1.Columns.Add("Name", 120)
            MaterialListView1.Columns.Add("Price", 100)
            MaterialListView1.Columns.Add("Quantity", 50)
        End If

        qtySpinner.Visible = False
        qtySpinner.Minimum = 1
        qtySpinner.Maximum = 100
        Me.Controls.Add(qtySpinner)
        qtySpinner.BringToFront()

        AddHandler pos_DataGrid.DataGrid.SelectedIndexChanged, AddressOf UpdateOrderList
        AddHandler qtySpinner.ValueChanged, AddressOf qtySpinner_ValChange
        AddHandler qtySpinner.KeyDown, AddressOf qtySpinner_KeyDown
        AddHandler qtySpinner.Leave, AddressOf qtySpinner_Leave
    End Sub

    Private Sub CommitSpinnerValue()
        If qtySpinner.Visible AndAlso qtySpinner.Tag IsNot Nothing Then
            qtySpinner.Validate()

            Dim item = DirectCast(qtySpinner.Tag, ListViewItem)
            Dim prodIndex = CInt(item.Tag)

            selectedQuantities(prodIndex) = CInt(qtySpinner.Value)

            item.SubItems(2).Text = qtySpinner.Value.ToString()
            qtySpinner.Visible = False
        End If
    End Sub

    Private Sub QtySpinner_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CommitSpinnerValue()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub qtySpinner_Leave(sender As Object, e As EventArgs)
        CommitSpinnerValue()
    End Sub

    Private Sub UpdateOrderList(sender As Object, e As EventArgs)
        MaterialListView1.Items.Clear()
        qtySpinner.Visible = False

        For Each selectedItem As ListViewItem In pos_DataGrid.DataGrid.SelectedItems
            Dim index As Integer = CInt(selectedItem.Tag)

            If Not selectedQuantities.ContainsKey(index) Then
                selectedQuantities(index) = 1
            End If
            Dim orderRow As New ListViewItem(Database.GetProductName(index))
            orderRow.SubItems.Add("₱" & Database.GetProductPrice(index).ToString("F2"))
            orderRow.SubItems.Add(selectedQuantities(index).ToString)
            orderRow.Tag = index

            MaterialListView1.Items.Add(orderRow)
        Next
    End Sub

    Private Sub qtySpinner_ValChange(sender As Object, e As EventArgs)
        If qtySpinner.Visible AndAlso qtySpinner.Tag IsNot Nothing Then
            Dim item = DirectCast(qtySpinner.Tag, ListViewItem)
            Dim prodIndex = CInt(item.Tag)

            selectedQuantities(prodIndex) = CInt(qtySpinner.Value)
            item.SubItems(2).Text = qtySpinner.Value.ToString()
        End If
    End Sub

    Private Sub MaterialListView_MouseUp(sender As Object, e As MouseEventArgs) Handles MaterialListView1.MouseUp
        Dim item = MaterialListView1.GetItemAt(e.X, e.Y)

        If item IsNot Nothing Then
            Dim Rect = item.SubItems(2).Bounds

            qtySpinner.Bounds = New Rectangle(MaterialListView1.Left + Rect.X, MaterialListView1.Top + Rect.Y, Rect.Width, Rect.Height)
            qtySpinner.Value = Decimal.Parse(item.SubItems(2).Text)
            qtySpinner.Tag = item
            qtySpinner.Visible = True
            qtySpinner.Focus()
        Else
            qtySpinner.Visible = False
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Double = 0.0

        For Each item As ListViewItem In MaterialListView1.Items
            Dim index As Integer = CInt(item.Tag)
            Dim qty As Integer = 0

            If Integer.TryParse(item.SubItems(2).Text, qty) Then
                Dim price As Double = Database.GetProductPrice(index)
                total += (qty * price)
                Database.ProcessSale(index, qty)
            End If
        Next

        POS_Total.Text = total.ToString("F2")
        pos_DataGrid.RefreshList()

        Dim mainForm = DirectCast(Me.FindForm(), MainWindow)
        If mainForm IsNot Nothing Then
            mainForm.Uc_ManageInventory1.Refreshdata()
        End If
    End Sub
End Class
