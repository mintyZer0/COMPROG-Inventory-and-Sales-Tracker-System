Public Class InventorySystem
    ' Parallel Arrays (Max 100 items)
    Private productNames(99) As String
    Private productPrices(99) As Double
    Private productStocks(99) As Integer
    Private soldCounts(99) As Integer
    Private productCount As Integer = 0

    Public Function GetProductCount() As Integer
        Return productCount
    End Function

    Public Function GetLowStockCount() As Integer
        Dim lowStockCount As Integer = 0
        For i As Integer = 0 To productCount - 1
            If productStocks(i) < 5 Then
                lowStockCount += 1
            End If
        Next
        Return lowStockCount
    End Function

    Public Function GetTotalProductsSold() As Integer
        Dim totalSold As Integer = 0
        For i As Integer = 0 To productCount - 1
            totalSold += soldCounts(i)
        Next
        Return totalSold
    End Function

    Public Sub AddNewProduct(name As String, price As Double, initialStock As Integer)
        If productCount < 100 Then
            productNames(productCount) = name
            productPrices(productCount) = price
            productStocks(productCount) = initialStock
            soldCounts(productCount) = 0
            productCount += 1
        Else
            MsgBox("Inventory Full!")
        End If
    End Sub

    Public Sub RestockProduct(index As Integer, amount As Integer)
        If index >= 0 AndAlso index < productCount Then
            productStocks(index) += amount
        End If
    End Sub

    Public Sub ProcessSale(index As Integer, quantity As Integer)
        If index >= 0 AndAlso index < productCount Then
            If productStocks(index) >= quantity Then
                productStocks(index) -= quantity
                soldCounts(index) += quantity
            Else
                MsgBox("Insufficient Stock!")
            End If
        End If
    End Sub

    ' Functions for Revenue
    Public Function GetItemRevenue(index As Integer) As Double
        Return productPrices(index) * soldCounts(index)
    End Function

    Public Function GetTotalRevenue() As Double
        Dim total As Double = 0
        For i As Integer = 0 To productCount - 1
            total += GetItemRevenue(i)
        Next
        Return total
    End Function

End Class
