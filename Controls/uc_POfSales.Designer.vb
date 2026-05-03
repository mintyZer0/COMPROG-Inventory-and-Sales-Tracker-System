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
        pos_DataGrid = New uc_DataGrid()
        btnCalculate = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        lblPOSTotal = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        crdCurrentOrder = New MaterialSkin.Controls.MaterialCard()
        lvCurrentOrder = New MaterialSkin.Controls.MaterialListView()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard1.SuspendLayout()
        crdCurrentOrder.SuspendLayout()
        SuspendLayout()
        ' 
        ' pos_DataGrid
        ' 
        pos_DataGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pos_DataGrid.ImeMode = ImeMode.NoControl
        pos_DataGrid.Location = New Point(17, 8)
        pos_DataGrid.Name = "pos_DataGrid"
        pos_DataGrid.Size = New Size(416, 397)
        pos_DataGrid.TabIndex = 0
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCalculate.AutoSize = False
        btnCalculate.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnCalculate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnCalculate.Depth = 0
        btnCalculate.HighEmphasis = True
        btnCalculate.Icon = Nothing
        btnCalculate.Location = New Point(89, 370)
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
        MaterialLabel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        MaterialLabel2.AutoSize = True
        MaterialLabel2.BackColor = Color.White
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        MaterialLabel2.Location = New Point(96, 335)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(86, 29)
        MaterialLabel2.TabIndex = 4
        MaterialLabel2.Text = "Total: ₱"
        ' 
        ' lblPOSTotal
        ' 
        lblPOSTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblPOSTotal.AutoSize = True
        lblPOSTotal.BackColor = Color.White
        lblPOSTotal.Depth = 0
        lblPOSTotal.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblPOSTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        lblPOSTotal.Location = New Point(188, 335)
        lblPOSTotal.MouseState = MaterialSkin.MouseState.HOVER
        lblPOSTotal.Name = "lblPOSTotal"
        lblPOSTotal.Size = New Size(46, 29)
        lblPOSTotal.TabIndex = 5
        lblPOSTotal.Text = "0.00"
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(pos_DataGrid)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(14, 14)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(450, 425)
        MaterialCard1.TabIndex = 6
        ' 
        ' crdCurrentOrder
        ' 
        crdCurrentOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        crdCurrentOrder.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        crdCurrentOrder.Controls.Add(lvCurrentOrder)
        crdCurrentOrder.Controls.Add(MaterialLabel1)
        crdCurrentOrder.Controls.Add(btnCalculate)
        crdCurrentOrder.Controls.Add(MaterialLabel2)
        crdCurrentOrder.Controls.Add(lblPOSTotal)
        crdCurrentOrder.Depth = 0
        crdCurrentOrder.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        crdCurrentOrder.Location = New Point(476, 14)
        crdCurrentOrder.Margin = New Padding(14)
        crdCurrentOrder.MouseState = MaterialSkin.MouseState.HOVER
        crdCurrentOrder.Name = "crdCurrentOrder"
        crdCurrentOrder.Padding = New Padding(14)
        crdCurrentOrder.Size = New Size(335, 425)
        crdCurrentOrder.TabIndex = 7
        ' 
        ' lvCurrentOrder
        ' 
        lvCurrentOrder.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvCurrentOrder.AutoSizeTable = False
        lvCurrentOrder.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lvCurrentOrder.BorderStyle = BorderStyle.None
        lvCurrentOrder.Depth = 0
        lvCurrentOrder.FullRowSelect = True
        lvCurrentOrder.Location = New Point(18, 51)
        lvCurrentOrder.MinimumSize = New Size(200, 100)
        lvCurrentOrder.MouseLocation = New Point(-1, -1)
        lvCurrentOrder.MouseState = MaterialSkin.MouseState.OUT
        lvCurrentOrder.Name = "lvCurrentOrder"
        lvCurrentOrder.OwnerDraw = True
        lvCurrentOrder.Size = New Size(297, 276)
        lvCurrentOrder.TabIndex = 1
        lvCurrentOrder.UseCompatibleStateImageBehavior = False
        lvCurrentOrder.View = View.Details
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel1.Location = New Point(66, 8)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(206, 41)
        MaterialLabel1.TabIndex = 7
        MaterialLabel1.Text = "Current Order"
        ' 
        ' uc_POfSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard1)
        Controls.Add(crdCurrentOrder)
        MinimumSize = New Size(825, 471)
        Name = "uc_POfSales"
        Size = New Size(825, 471)
        MaterialCard1.ResumeLayout(False)
        crdCurrentOrder.ResumeLayout(False)
        crdCurrentOrder.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pos_DataGrid As uc_DataGrid
    Friend WithEvents btnCalculate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPOSTotal As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents crdCurrentOrder As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lvCurrentOrder As MaterialSkin.Controls.MaterialListView

End Class
