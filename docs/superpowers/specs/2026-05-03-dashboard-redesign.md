# Dashboard Redesign: Four Corners Grid

## Overview
Redesign the dashboard to provide more detailed information at a glance by replacing simple counter cards with interactive lists.

## Goals
- Replace "Low Stock" and "Out of Stock" counter cards with detailed lists.
- Add a "Least Sold" list to complement the existing "Most Sold" list.
- Organize the dashboard into a clean 2x2 grid for performance and inventory metrics.

## Layout Changes
The dashboard (`uc_Dashboard`) will be reorganized into two main sections:

### 1. Performance & Inventory Grid (2x2)
- **Top-Left:** `lbHighestSelling` (ListBox) - "Most Sold" (Existing)
- **Top-Right:** `lbLeastSelling` (ListBox) - "Least Sold" (New)
- **Bottom-Left:** `lvLowStock` (ListView) - "Low Stock" (New)
    - Columns: "Product Name", "Current Stock"
- **Bottom-Right:** `lbOutOfStock` (ListBox) - "Out of Stock" (New)

### 2. Metrics Row
The remaining high-level metrics will be placed in a row at the top or side:
- Total Revenue
- Products Sold
- Inventory Count
- Inventory Value

### 3. Removals
- `MaterialCard1` (Low Stock Counter)
- `MaterialCard6` (Out of Stock Counter)

## Technical Specifications

### Data Requirements
- **Least Sold:** Products sorted by `Units Sold` ascending.
- **Out of Stock:** Products where `Current Stock == 0`.
- **Low Stock:** Products where `0 < Current Stock <= Threshold`.

### Components
- `MaterialCard` containers for each list.
- `MaterialListBox` for "Least Sold" and "Out of Stock".
- `MaterialListView` for "Low Stock".

## Success Criteria
- [ ] Most Sold and Least Sold lists are populated correctly.
- [ ] Low Stock list view shows Name and Stock for items below threshold.
- [ ] Out of Stock list box shows items with 0 stock.
- [ ] Old counter cards are removed.
- [ ] Layout is clean and balanced in a 2x2 grid.
