Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices

Public Class InventorySystem
    ' Parallel Arrays (Max 100 items)
    Private productNames(99) As String
    Private productPrices(99) As Double
    Private productStocks(99) As Integer
    Private soldCounts(99) As Integer
    Private productCount As Integer = 0

    Public Function GetProductName(prodNameIndex As Integer) As String
        Return productNames(prodNameIndex)
    End Function

    Public Function GetProductPrice(prodPriceIndex As Integer) As Double
        Return productPrices(prodPriceIndex)
    End Function
    Public Function GetProductStock(prodStockIndex As Integer) As Integer
        Return productStocks(prodStockIndex)
    End Function

    Public Function GetSoldCount(soldCountIndex As Integer) As Integer
        Return soldCounts(soldCountIndex)
    End Function

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

    Public Function GetBestSellingItem() As String
        Dim bestSellerIndex As Integer = 0
        For i As Integer = 1 To productCount - 1
            If soldCounts(i) > soldCounts(bestSellerIndex) Then
                bestSellerIndex = i
            End If
        Next
        Return productNames(bestSellerIndex)
    End Function

    Public Function GetBestSellingIndices() As Integer()
        Dim indices(productCount - 1) As Integer

        For i As Integer = 0 To productCount - 1
            indices(i) = i
        Next

        For i As Integer = 0 To productCount - 2
            For j As Integer = 0 To productCount - 2 - i
                If soldCounts(j) > soldCounts(j + 1) Then
                    Dim temp = indices(j + 1)
                    indices(j + 1) = indices(j)
                    indices(j) = temp
                End If
            Next
        Next
        Return indices
    End Function

    Public Function IsLowStock(index As Integer) As Boolean
        Return productStocks(index) < 5
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

    Public Sub UpdateProduct(index As Integer, newProdName As String, newPrice As Double, newStock As Integer)
        If index >= 0 AndAlso index < productCount AndAlso newProdName <> "" AndAlso newPrice > 0 AndAlso newStock >= 0 Then
            productNames(index) = newProdName
            productPrices(index) = newPrice
            productStocks(index) = newStock
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

    Public Function GetTotalInventoryValue() As Double
        Dim totalValue As Double = 0
        For i As Integer = 0 To productCount - 1
            totalValue += productPrices(i) * productStocks(i)
        Next
        Return totalValue
    End Function

    Public Function GetOutOfStockCount() As Integer
        Dim count As Integer = 0
        For i As Integer = 0 To productCount - 1
            If productStocks(i) = 0 Then
                count += 1
            End If
        Next
        Return count
    End Function

    'Sort Algo
    'babol sort 
    Public Sub Sort(columnIndex As Integer, ascend As Boolean)
        Dim swapped As Boolean
        For i As Integer = 0 To productCount - 2
            swapped = False

            For j As Integer = 0 To productCount - 2 - i
                Dim swapperToggle = False

                Select Case columnIndex
                    Case 1
                        If ascend Then
                            If productNames(j).CompareTo(productNames(j + 1)) > 0 Then
                                swapperToggle = True
                            End If
                        Else
                            If productNames(j).CompareTo(productNames(j + 1)) < 0 Then
                                swapperToggle = True
                            End If
                        End If
                    Case 2
                        If ascend Then
                            If productPrices(j) > productPrices(j + 1) Then
                                swapperToggle = True
                            End If
                        Else
                            If productPrices(j) < productPrices(j + 1) Then
                                swapperToggle = True
                            End If
                        End If
                    Case 3
                        If ascend Then
                            If productStocks(j) > productStocks(j + 1) Then
                                swapperToggle = True
                            End If
                        Else
                            If productStocks(j) < productStocks(j + 1) Then
                                swapperToggle = True
                            End If
                        End If

                End Select
                If swapperToggle Then
                    SwapAll(j, j + 1)
                    swapped = True
                End If
            Next
            If Not swapped Then
                Exit For
            End If
        Next
    End Sub
    Public Sub SwapAll(firstIndex As Integer, secondIndex As Integer)
        'Swap names
        Dim tempName = productNames(firstIndex)
        productNames(firstIndex) = productNames(secondIndex)
        productNames(secondIndex) = tempName

        'Swap Prices
        Dim tempPrice = productPrices(firstIndex)
        productPrices(firstIndex) = productPrices(secondIndex)
        productPrices(secondIndex) = tempPrice

        'Swap Stock Quantity
        Dim tempQty = productStocks(firstIndex)
        productStocks(firstIndex) = productStocks(secondIndex)
        productStocks(secondIndex) = tempQty

        'Swap Sold Count
        Dim tempSold = soldCounts(firstIndex)
        soldCounts(firstIndex) = soldCounts(secondIndex)
        soldCounts(secondIndex) = tempSold
    End Sub

End Class
