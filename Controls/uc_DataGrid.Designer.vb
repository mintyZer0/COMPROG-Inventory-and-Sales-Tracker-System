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
        lchIndex = New ColumnHeader()
        lchName = New ColumnHeader()
        lchPrice = New ColumnHeader()
        lchQuantity = New ColumnHeader()
        SuspendLayout()
        ' 
        ' DataGrid
        ' 
        DataGrid.AutoSizeTable = False
        DataGrid.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGrid.BorderStyle = BorderStyle.None
        DataGrid.Columns.AddRange(New ColumnHeader() {lchIndex, lchName, lchPrice, lchQuantity})
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
        ' lchIndex
        ' 
        lchIndex.Text = "Index"
        lchIndex.Width = 100
        ' 
        ' lchName
        ' 
        lchName.Text = "Name"
        lchName.TextAlign = HorizontalAlignment.Center
        lchName.Width = 100
        ' 
        ' lchPrice
        ' 
        lchPrice.Text = "Price"
        lchPrice.TextAlign = HorizontalAlignment.Center
        lchPrice.Width = 100
        ' 
        ' lchQuantity
        ' 
        lchQuantity.Text = "Quantity"
        lchQuantity.TextAlign = HorizontalAlignment.Center
        lchQuantity.Width = 100
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
    Friend WithEvents lchName As ColumnHeader
    Friend WithEvents lchIndex As ColumnHeader
    Friend WithEvents lchPrice As ColumnHeader
    Friend WithEvents lchQuantity As ColumnHeader

End Class
