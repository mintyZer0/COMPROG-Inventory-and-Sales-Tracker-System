# Inventory and Sales Tracker System

A robust point-of-sale and inventory management system built with VB.NET and MaterialSkin 2.

## Key Features

### 📦 Inventory Management
- **Smart Product Management**: Add, edit, and delete products with automatic UI updates.
- **Bulk Import**: Quickly set up your inventory using CSV or Excel files.
- **Smart Merge**: Importing automatically updates existing items by name or adds new ones.

### 💰 Point of Sale (POS)
- **Fast Checkout**: Integrated search and quantity selection.
- **Stock Validation**: Prevents sales that exceed current stock.
- **Live Updates**: Dashboard and reports update immediately after every sale.

### 📜 Transaction History
- **Audit Log**: A dedicated history tab with a master-detail view.
- **Snapshots**: Records the exact name and price at the time of sale, making history immune to future inventory changes or sorting.

### 📊 Advanced Reporting
- **Dynamic Filtering**: Filter sales by All Time, This Week, This Month, This Year, or a Custom Date Range.
- **Activity Focused**: Automatically hides products with zero sales in the selected period.
- **Last Sold Data**: Tracks the most recent sale date for every item in your inventory.

### 📤 Professional Exports
- **Excel (.xlsx)**: Generates formatted spreadsheets with **live formulas** for automated totals.
- **PDF**: Clean, high-quality reports generated via built-in system tools.
- **CSV/HTML**: Standard formats for data analysis and web viewing.

---

## Data Import Specifications

To import product data successfully, ensure your files follow these rules:

### File Formats
- **CSV (.csv)**: Plain text comma-separated values.
- **Excel (.xlsx)**: Standard Excel workbook (First Sheet).

### Column Structure
The system expects data in the first 3 columns of the file:

| Column | Data Type | Description |
| :--- | :--- | :--- |
| **A (1)** | String | **Product Name** (Unique Identifier) |
| **B (2)** | Double | **Unit Price** (e.g., 1200.50) |
| **C (3)** | Integer | **Stock Quantity** (e.g., 50) |

### Important Rules
1. **Header Row**: The first row of your file is always skipped (assumed to be titles).
2. **Smart Merge**: If the product name already exists in the system, its price and stock will be **updated**. If it's new, it will be **added**.
3. **CSV Quoting**: If a product name contains a comma, wrap the name in double quotes: `"USB-C Cable, 2m"`.
4. **Capacity**: The system currently supports a maximum of **100 products**.

---

## Technical Stack
- **Language**: VB.NET
- **Framework**: .NET 10.0 (Windows)
- **UI Library**: MaterialSkin 2
- **Interop**: Late-Bound Microsoft Excel Object Library
