# Dashboard Redesign: Four Corners Grid Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Redesign the dashboard to replace simple counters with detailed lists in a balanced 2x2 grid, maximizing use of existing `InventorySystem` functions.

**Architecture:** Update `uc_Dashboard.Designer.vb` to remove old counter cards and add new `MaterialCard` containers for "Least Sold", "Low Stock" (ListView), and "Out of Stock" lists. Update `uc_Dashboard.vb` to populate these new components using existing and slightly extended `InventorySystem` logic.

**Tech Stack:** VB.NET, WinForms, MaterialSkin 2

---

### Task 1: Update Designer to Remove Old Cards and Add New Grid Structure

**Files:**
- Modify: `Controls\uc_Dashboard.Designer.vb`

- [ ] **Step 1: Remove `MaterialCard1` (Low Stock Counter) and `MaterialCard6` (Out of Stock Counter)**
Remove their initialization, layout settings, and controls collection additions.

- [ ] **Step 2: Declare new controls**
```vb
Friend WithEvents MaterialCard_LeastSold As MaterialSkin.Controls.MaterialCard
Friend WithEvents lblTextLeastSold As MaterialSkin.Controls.MaterialLabel
Friend WithEvents lbLeastSelling As MaterialSkin.Controls.MaterialListBox
Friend WithEvents pnlLeastSold As Panel

Friend WithEvents MaterialCard_LowStock As MaterialSkin.Controls.MaterialCard
Friend WithEvents lblTextLowStock_New As MaterialSkin.Controls.MaterialLabel
Friend WithEvents lvLowStock As MaterialSkin.Controls.MaterialListView
Friend WithEvents colLowStockName As ColumnHeader
Friend WithEvents colLowStockQty As ColumnHeader
Friend WithEvents pnlLowStock_New As Panel

Friend WithEvents MaterialCard_OutOfStock As MaterialSkin.Controls.MaterialCard
Friend WithEvents lblTextOutOfStock_New As MaterialSkin.Controls.MaterialLabel
Friend WithEvents lbOutOfStock As MaterialSkin.Controls.MaterialListBox
Friend WithEvents pnlOutOfStock_New As Panel
```

- [ ] **Step 3: Initialize and configure the 2x2 grid layout**
Adjust `MaterialCard7` (Most Sold) to Top-Left. 
Position `MaterialCard_LeastSold` at Top-Right.
Position `MaterialCard_LowStock` at Bottom-Left.
Position `MaterialCard_OutOfStock` at Bottom-Right.
Ensure consistent sizes (e.g., 235x233 or similar balanced size).

- [ ] **Step 4: Commit UI changes**
```bash
git add Controls/uc_Dashboard.Designer.vb
git commit -m "feat(ui): update dashboard designer with new 2x2 grid structure"
```

---

### Task 2: Update Code-Behind for Data Binding

**Files:**
- Modify: `Controls\uc_Dashboard.vb`

- [ ] **Step 1: Update `ApplyPaint` to include new panels**
```vb
Private Sub ApplyPaint()
    ' Existing...
    If pnlLeastSold IsNot Nothing Then pnlLeastSold.BackColor = Color.FromArgb(255, 193, 7) ' Same as Most Sold or different?
    If pnlLowStock_New IsNot Nothing Then pnlLowStock_New.BackColor = Color.FromArgb(174, 78, 78)
    If pnlOutOfStock_New IsNot Nothing Then pnlOutOfStock_New.BackColor = Color.FromArgb(244, 67, 54)
End Sub
```

- [ ] **Step 2: Implement `RefreshLeastSold`, `RefreshLowStock`, and `RefreshOutOfStock`**
Use `Database.GetBestSellingIndices()` for Least Sold (it currently sorts by sold count, so we can reverse or iterate differently).
Iterate `Database.GetProductCount()` and use `Database.IsLowStock(i)` for Low Stock.
Iterate `Database.GetProductCount()` and check `Database.GetProductStock(i) = 0` for Out of Stock.

- [ ] **Step 3: Update `SetValues` to remove references to deleted labels and refresh new lists**
```vb
Private Sub RefreshDashboardLists()
    lbHighestSelling.Items.Clear()
    lbLeastSelling.Items.Clear()
    lbOutOfStock.Items.Clear()
    lvLowStock.Items.Clear()

    Dim indices As Integer() = Database.GetBestSellingIndices()
    ' Most Sold (Top 5 or all sorted desc)
    ' Least Sold (All sorted asc)
    
    For i As Integer = 0 To Database.GetProductCount() - 1
        ' Logic to populate lists...
    Next
End Sub
```

- [ ] **Step 4: Commit implementation**
```bash
git add Controls/uc_Dashboard.vb
git commit -m "feat(logic): implement data binding for new dashboard lists"
```

---

### Task 3: Final Alignment and Metric Row Cleanup

**Files:**
- Modify: `Controls\uc_Dashboard.Designer.vb`

- [ ] **Step 1: Align Metric Cards (Revenue, Products Sold, etc.)**
Move `MaterialCard2`, `MaterialCard3`, `MaterialCard4`, `MaterialCard5` to a consistent row or sidebar area.

- [ ] **Step 2: Verify overall appearance**
Ensure no overlapping controls and proper anchoring.

- [ ] **Step 3: Commit final layout**
```bash
git add Controls/uc_Dashboard.Designer.vb
git commit -m "style: final alignment of dashboard metric cards"
```
