<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_POfSales
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
        Dim MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
        pos_DataGrid = New uc_DataGrid()
        MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        btnCalculate = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        POS_Total = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        SuspendLayout()
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.Depth = 0
        MaterialLabel1.FlatStyle = FlatStyle.System
        MaterialLabel1.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel1.Location = New Point(378, 9)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(220, 33)
        MaterialLabel1.TabIndex = 3
        MaterialLabel1.Text = "Current Order"
        ' 
        ' pos_DataGrid
        ' 
        pos_DataGrid.ImeMode = ImeMode.NoControl
        pos_DataGrid.Location = New Point(-87, 0)
        pos_DataGrid.Name = "pos_DataGrid"
        pos_DataGrid.Size = New Size(404, 374)
        pos_DataGrid.TabIndex = 0
        ' 
        ' MaterialListView1
        ' 
        MaterialListView1.AutoSizeTable = False
        MaterialListView1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialListView1.BorderStyle = BorderStyle.None
        MaterialListView1.Depth = 0
        MaterialListView1.FullRowSelect = True
        MaterialListView1.Location = New Point(322, 51)
        MaterialListView1.MinimumSize = New Size(200, 100)
        MaterialListView1.MouseLocation = New Point(-1, -1)
        MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        MaterialListView1.Name = "MaterialListView1"
        MaterialListView1.OwnerDraw = True
        MaterialListView1.Size = New Size(317, 199)
        MaterialListView1.TabIndex = 1
        MaterialListView1.UseCompatibleStateImageBehavior = False
        MaterialListView1.View = View.Details
        ' 
        ' btnCalculate
        ' 
        btnCalculate.AutoSize = False
        btnCalculate.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCalculate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCalculate.Depth = 0
        btnCalculate.HighEmphasis = True
        btnCalculate.Icon = Nothing
        btnCalculate.Location = New Point(408, 301)
        btnCalculate.Margin = New Padding(4, 6, 4, 6)
        btnCalculate.MouseState = MaterialSkin.MouseState.HOVER
        btnCalculate.Name = "btnCalculate"
        btnCalculate.NoAccentTextColor = Color.Empty
        btnCalculate.Size = New Size(158, 36)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "Checkout"
        btnCalculate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnCalculate.UseAccentColor = False
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        MaterialLabel2.Location = New Point(408, 266)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(86, 29)
        MaterialLabel2.TabIndex = 4
        MaterialLabel2.Text = "Total: ₱"
        ' 
        ' POS_Total
        ' 
        POS_Total.AutoSize = True
        POS_Total.Depth = 0
        POS_Total.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        POS_Total.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        POS_Total.Location = New Point(495, 266)
        POS_Total.MouseState = MaterialSkin.MouseState.HOVER
        POS_Total.Name = "POS_Total"
        POS_Total.Size = New Size(46, 29)
        POS_Total.TabIndex = 5
        POS_Total.Text = "0.00"
        ' 
        ' uc_POfSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(POS_Total)
        Controls.Add(MaterialLabel2)
        Controls.Add(MaterialLabel1)
        Controls.Add(btnCalculate)
        Controls.Add(MaterialListView1)
        Controls.Add(pos_DataGrid)
        Name = "uc_POfSales"
        Size = New Size(643, 374)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pos_DataGrid As uc_DataGrid
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents btnCalculate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents POS_Total As MaterialSkin.Controls.MaterialLabel

End Class
