<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_TransactionLog
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
        MaterialCard_Master = New MaterialSkin.Controls.MaterialCard()
        lvTransactions = New MaterialSkin.Controls.MaterialListView()
        colID = New ColumnHeader()
        colTime = New ColumnHeader()
        colTotal = New ColumnHeader()
        MaterialCard_Details = New MaterialSkin.Controls.MaterialCard()
        lblDetailsHeader = New MaterialSkin.Controls.MaterialLabel()
        lvDetails = New MaterialSkin.Controls.MaterialListView()
        colItem = New ColumnHeader()
        colQty = New ColumnHeader()
        colPrice = New ColumnHeader()
        colSubtotal = New ColumnHeader()
        MaterialCard_Master.SuspendLayout()
        MaterialCard_Details.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialCard_Master
        ' 
        MaterialCard_Master.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialCard_Master.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard_Master.Controls.Add(lvTransactions)
        MaterialCard_Master.Depth = 0
        MaterialCard_Master.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard_Master.Location = New Point(14, 14)
        MaterialCard_Master.Margin = New Padding(14)
        MaterialCard_Master.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard_Master.Name = "MaterialCard_Master"
        MaterialCard_Master.Padding = New Padding(14)
        MaterialCard_Master.Size = New Size(430, 443)
        MaterialCard_Master.TabIndex = 0
        ' 
        ' lvTransactions
        ' 
        lvTransactions.AutoSizeTable = False
        lvTransactions.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lvTransactions.BorderStyle = BorderStyle.None
        lvTransactions.Columns.AddRange(New ColumnHeader() {colID, colTime, colTotal})
        lvTransactions.Depth = 0
        lvTransactions.Dock = DockStyle.Fill
        lvTransactions.FullRowSelect = True
        lvTransactions.Location = New Point(14, 14)
        lvTransactions.MinimumSize = New Size(200, 100)
        lvTransactions.MouseLocation = New Point(-1, -1)
        lvTransactions.MouseState = MaterialSkin.MouseState.OUT
        lvTransactions.Name = "lvTransactions"
        lvTransactions.OwnerDraw = True
        lvTransactions.Size = New Size(402, 415)
        lvTransactions.TabIndex = 0
        lvTransactions.UseCompatibleStateImageBehavior = False
        lvTransactions.View = View.Details
        ' 
        ' colID
        ' 
        colID.Text = "ID"
        ' 
        ' colTime
        ' 
        colTime.Text = "Timestamp"
        colTime.Width = 200
        ' 
        ' colTotal
        ' 
        colTotal.Text = "Total Amount"
        colTotal.TextAlign = HorizontalAlignment.Right
        colTotal.Width = 150
        ' 
        ' MaterialCard_Details
        ' 
        MaterialCard_Details.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        MaterialCard_Details.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard_Details.Controls.Add(lblDetailsHeader)
        MaterialCard_Details.Controls.Add(lvDetails)
        MaterialCard_Details.Depth = 0
        MaterialCard_Details.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard_Details.Location = New Point(458, 14)
        MaterialCard_Details.Margin = New Padding(14)
        MaterialCard_Details.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard_Details.Name = "MaterialCard_Details"
        MaterialCard_Details.Padding = New Padding(14)
        MaterialCard_Details.Size = New Size(353, 443)
        MaterialCard_Details.TabIndex = 1
        ' 
        ' lblDetailsHeader
        ' 
        lblDetailsHeader.AutoSize = True
        lblDetailsHeader.Depth = 0
        lblDetailsHeader.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblDetailsHeader.Location = New Point(17, 14)
        lblDetailsHeader.MouseState = MaterialSkin.MouseState.HOVER
        lblDetailsHeader.Name = "lblDetailsHeader"
        lblDetailsHeader.Size = New Size(141, 19)
        lblDetailsHeader.TabIndex = 1
        lblDetailsHeader.Text = "Select a transaction"
        ' 
        ' lvDetails
        ' 
        lvDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvDetails.AutoSizeTable = False
        lvDetails.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        lvDetails.BorderStyle = BorderStyle.None
        lvDetails.Columns.AddRange(New ColumnHeader() {colItem, colQty, colPrice, colSubtotal})
        lvDetails.Depth = 0
        lvDetails.FullRowSelect = True
        lvDetails.Location = New Point(17, 46)
        lvDetails.MinimumSize = New Size(200, 100)
        lvDetails.MouseLocation = New Point(-1, -1)
        lvDetails.MouseState = MaterialSkin.MouseState.OUT
        lvDetails.Name = "lvDetails"
        lvDetails.OwnerDraw = True
        lvDetails.Size = New Size(319, 383)
        lvDetails.TabIndex = 0
        lvDetails.UseCompatibleStateImageBehavior = False
        lvDetails.View = View.Details
        ' 
        ' colItem
        ' 
        colItem.Text = "Item"
        colItem.Width = 100
        ' 
        ' colQty
        ' 
        colQty.Text = "Qty"
        colQty.Width = 50
        ' 
        ' colPrice
        ' 
        colPrice.Text = "Price"
        colPrice.Width = 70
        ' 
        ' colSubtotal
        ' 
        colSubtotal.Text = "Subtotal"
        colSubtotal.TextAlign = HorizontalAlignment.Right
        colSubtotal.Width = 70
        ' 
        ' uc_TransactionLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaterialCard_Details)
        Controls.Add(MaterialCard_Master)
        Name = "uc_TransactionLog"
        Size = New Size(825, 471)
        MaterialCard_Master.ResumeLayout(False)
        MaterialCard_Details.ResumeLayout(False)
        MaterialCard_Details.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialCard_Master As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lvTransactions As MaterialSkin.Controls.MaterialListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colTime As ColumnHeader
    Friend WithEvents colTotal As ColumnHeader
    Friend WithEvents MaterialCard_Details As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lvDetails As MaterialSkin.Controls.MaterialListView
    Friend WithEvents colItem As ColumnHeader
    Friend WithEvents colQty As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents colSubtotal As ColumnHeader
    Friend WithEvents lblDetailsHeader As MaterialSkin.Controls.MaterialLabel
End Class
