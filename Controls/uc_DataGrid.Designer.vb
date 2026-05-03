<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_DataGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGrid = New MaterialSkin.Controls.MaterialListView()
        colIndex = New ColumnHeader()
        colName = New ColumnHeader()
        colPrice = New ColumnHeader()
        colQuantity = New ColumnHeader()
        SuspendLayout()
        ' 
        ' DataGrid
        ' 
        DataGrid.AutoSizeTable = False
        DataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGrid.BorderStyle = BorderStyle.None
        DataGrid.Columns.AddRange(New ColumnHeader() {colIndex, colName, colPrice, colQuantity})
        DataGrid.Depth = 0
        DataGrid.Dock = DockStyle.Fill
        DataGrid.FullRowSelect = True
        DataGrid.Location = New Point(0, 0)
        DataGrid.MinimumSize = New Size(200, 100)
        DataGrid.MouseLocation = New Point(-1, -1)
        DataGrid.MouseState = MaterialSkin.MouseState.OUT
        DataGrid.Name = "DataGrid"
        DataGrid.OwnerDraw = True
        DataGrid.Size = New Size(764, 461)
        DataGrid.TabIndex = 0
        DataGrid.UseCompatibleStateImageBehavior = False
        DataGrid.View = View.Details
        ' 
        ' colIndex
        ' 
        colIndex.Text = "Index"
        colIndex.Width = 100
        ' 
        ' colName
        ' 
        colName.Text = "Name"
        colName.TextAlign = HorizontalAlignment.Center
        colName.Width = 100
        ' 
        ' colPrice
        ' 
        colPrice.Text = "Price"
        colPrice.TextAlign = HorizontalAlignment.Center
        colPrice.Width = 100
        ' 
        ' colQuantity
        ' 
        colQuantity.Text = "Quantity"
        colQuantity.TextAlign = HorizontalAlignment.Center
        colQuantity.Width = 100
        ' 
        ' uc_DataGrid
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGrid)
        Name = "uc_DataGrid"
        Size = New Size(764, 461)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGrid As MaterialSkin.Controls.MaterialListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colIndex As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colQuantity As ColumnHeader

End Class
