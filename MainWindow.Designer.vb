<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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
        tbMainWindow = New MaterialSkin.Controls.MaterialTabControl()
        tpDashboard = New TabPage()
        Dashboard1 = New uc_Dashboard()
        tpManageInventory = New TabPage()
        Uc_ManageInventory1 = New uc_ManageInventory()
        tpPointOfSale = New TabPage()
        Uc_pOfSales1 = New uc_POfSales()
        tpReports = New TabPage()
        Uc_Reports = New uc_Reports()
        dwrSidebar = New MaterialSkin.Controls.MaterialDrawer()
        tbMainWindow.SuspendLayout()
        tpDashboard.SuspendLayout()
        tpManageInventory.SuspendLayout()
        tpPointOfSale.SuspendLayout()
        tpReports.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbMainWindow
        ' 
        tbMainWindow.Controls.Add(tpDashboard)
        tbMainWindow.Controls.Add(tpManageInventory)
        tbMainWindow.Controls.Add(tpPointOfSale)
        tbMainWindow.Controls.Add(tpReports)
        tbMainWindow.Depth = 0
        tbMainWindow.Dock = DockStyle.Fill
        tbMainWindow.ImeMode = ImeMode.Disable
        tbMainWindow.Location = New Point(154, 64)
        tbMainWindow.MouseState = MaterialSkin.MouseState.HOVER
        tbMainWindow.Multiline = True
        tbMainWindow.Name = "tbMainWindow"
        tbMainWindow.SelectedIndex = 0
        tbMainWindow.Size = New Size(755, 500)
        tbMainWindow.TabIndex = 4
        ' 
        ' tpDashboard
        ' 
        tpDashboard.Controls.Add(Dashboard1)
        tpDashboard.Location = New Point(4, 24)
        tpDashboard.Name = "tpDashboard"
        tpDashboard.Padding = New Padding(3)
        tpDashboard.Size = New Size(768, 490)
        tpDashboard.TabIndex = 0
        tpDashboard.Text = "Dashboard"
        tpDashboard.UseVisualStyleBackColor = True
        ' 
        ' Dashboard1
        ' 
        Dashboard1.BackColor = Color.White
        Dashboard1.Dock = DockStyle.Fill
        Dashboard1.Location = New Point(3, 3)
        Dashboard1.Name = "Dashboard1"
        Dashboard1.Size = New Size(762, 484)
        Dashboard1.TabIndex = 0
        ' 
        ' tpManageInventory
        ' 
        tpManageInventory.Controls.Add(Uc_ManageInventory1)
        tpManageInventory.Location = New Point(4, 24)
        tpManageInventory.Name = "tpManageInventory"
        tpManageInventory.Padding = New Padding(3)
        tpManageInventory.Size = New Size(768, 490)
        tpManageInventory.TabIndex = 1
        tpManageInventory.Text = "Inventory"
        tpManageInventory.UseVisualStyleBackColor = True
        ' 
        ' Uc_ManageInventory1
        ' 
        Uc_ManageInventory1.Dock = DockStyle.Fill
        Uc_ManageInventory1.Location = New Point(3, 3)
        Uc_ManageInventory1.Name = "Uc_ManageInventory1"
        Uc_ManageInventory1.Size = New Size(762, 484)
        Uc_ManageInventory1.TabIndex = 0
        ' 
        ' tpPointOfSale
        ' 
        tpPointOfSale.Controls.Add(Uc_pOfSales1)
        tpPointOfSale.Location = New Point(4, 24)
        tpPointOfSale.Name = "tpPointOfSale"
        tpPointOfSale.Padding = New Padding(3)
        tpPointOfSale.Size = New Size(768, 490)
        tpPointOfSale.TabIndex = 2
        tpPointOfSale.Text = "POS"
        tpPointOfSale.UseVisualStyleBackColor = True
        ' 
        ' Uc_pOfSales1
        ' 
        Uc_pOfSales1.Dock = DockStyle.Fill
        Uc_pOfSales1.Location = New Point(3, 3)
        Uc_pOfSales1.Name = "Uc_pOfSales1"
        Uc_pOfSales1.Size = New Size(762, 484)
        Uc_pOfSales1.TabIndex = 0
        ' 
        ' tpReports
        ' 
        tpReports.Controls.Add(Uc_Reports)
        tpReports.Location = New Point(4, 24)
        tpReports.Name = "tpReports"
        tpReports.Padding = New Padding(3)
        tpReports.Size = New Size(747, 472)
        tpReports.TabIndex = 3
        tpReports.Text = "Reports"
        tpReports.UseVisualStyleBackColor = True
        ' 
        ' Uc_Reports
        ' 
        Uc_Reports.Dock = DockStyle.Fill
        Uc_Reports.Location = New Point(3, 3)
        Uc_Reports.Name = "Uc_Reports"
        Uc_Reports.Size = New Size(741, 466)
        Uc_Reports.TabIndex = 0
        ' 
        ' dwrSidebar
        ' 
        dwrSidebar.AutoHide = False
        dwrSidebar.AutoShow = False
        dwrSidebar.BackgroundWithAccent = False
        dwrSidebar.BaseTabControl = tbMainWindow
        dwrSidebar.Depth = 0
        dwrSidebar.Dock = DockStyle.Left
        dwrSidebar.HighlightWithAccent = True
        dwrSidebar.IndicatorWidth = 0
        dwrSidebar.IsOpen = True
        dwrSidebar.Location = New Point(3, 64)
        dwrSidebar.MouseState = MaterialSkin.MouseState.HOVER
        dwrSidebar.Name = "dwrSidebar"
        dwrSidebar.ShowIconsWhenHidden = True
        dwrSidebar.Size = New Size(151, 500)
        dwrSidebar.TabIndex = 3
        dwrSidebar.Text = "MaterialDrawer1"
        dwrSidebar.UseColors = False
        ' 
        ' MainWindow
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(912, 567)
        Controls.Add(tbMainWindow)
        Controls.Add(dwrSidebar)
        MinimumSize = New Size(912, 567)
        Name = "MainWindow"
        Text = "Dashboard"
        tbMainWindow.ResumeLayout(False)
        tpDashboard.ResumeLayout(False)
        tpManageInventory.ResumeLayout(False)
        tpPointOfSale.ResumeLayout(False)
        tpReports.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents tbMainWindow As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tpDashboard As TabPage
    Friend WithEvents tpManageInventory As TabPage
    Friend WithEvents tpPointOfSale As TabPage
    Friend WithEvents tpReports As TabPage
    Friend WithEvents dwrSidebar As MaterialSkin.Controls.MaterialDrawer
    Friend WithEvents Dashboard1 As uc_Dashboard
    Friend WithEvents Uc_ManageInventory1 As uc_ManageInventory
    Friend WithEvents Uc_pOfSales1 As uc_POfSales
    Friend WithEvents Uc_Reports As uc_Reports
End Class
