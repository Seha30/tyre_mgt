# UI Mockup Descriptions — S & N Tyre Center

Visual style across all modules:
- **Primary:** Orange `#FF8000`
- **Panels:** Peach `#FFE0C0` group boxes on light gray `#F8F9FA` background
- **Sidebar:** Dark `#1E1E1E` with orange menu buttons
- **Font:** Segoe UI Semibold labels, Segoe UI inputs

---

## 1. Login Form (`LoginFrm`)

```
┌─────────────────────────────────────────────────────────────┐
│ DARK PANEL (left 45%)     │  WHITE CARD (right)             │
│                           │                                 │
│  S & N Tyre Center        │   Staff Login                   │
│  (large orange title)     │                                 │
│                           │   Username [____________]       │
│  Inventory & Service      │   Password [____________]       │
│  Management               │                                 │
│  Piliyandala • Tyres...   │   [    Sign In (orange)    ]    │
│                           │   Demo: admin / admin123        │
└─────────────────────────────────────────────────────────────┘
```

---

## 2. Main Menu Shell (`MainMenu`)

```
┌──────────┬──────────────────────────────────────────────────┐
│ S&N Tyres│  Dashboard                    Welcome, admin     │
│──────────├──────────────────────────────────────────────────┤
│ Dashboard│                                                  │
│ Customer │         (child form fills this area)             │
│ Sales    │                                                  │
│ Product  │                                                  │
│ Supplier │                                                  │
│ Inventory│                                                  │
│ Staff    │                                                  │
│ Reports  │                                                  │
│ Settings │                                                  │
│ Logout   │                                                  │
└──────────┴──────────────────────────────────────────────────┘
```

---

## 3. Dashboard (`Dashboard`)

```
 Dashboard Overview
 ┌────────────┐ ┌────────────┐ ┌────────────┐ ┌────────────┐
 │ Customers  │ │ Products   │ │ Today Sales│ │ Low Stock  │
 │    12      │ │    45      │ │ Rs. 85,000 │ │     3      │
 └────────────┘ └────────────┘ └────────────┘ └────────────┘

 ┌─ Low Stock Alert ─────────────┐  ┌─ Quick Actions ────────┐
 │ [Refresh]                   │  │ [Open Sales POS]       │
 │ ┌─────────────────────────┐ │  │ [Manage Products]      │
 │ │ Code │ Product │ Qty... │ │  │ [View Reports]         │
 │ └─────────────────────────┘ │  └────────────────────────┘
 └─────────────────────────────┘
```

---

## 4. Customer Form (`AddCustomer`)

```
┌─ Customer Details (peach) ──────────────────────────────────┐
│ Name [____]  Phone [____]  Email [____]                    │
│ Address [________]  Price Category [Retail ▼]              │
│                    [Add] [Update] [Delete]                   │
└────────────────────────────────────────────────────────────┘
┌─ Customer History ─────────────────────────────────────────┐
│ Search [____________] [Search]                             │
│ ┌──────────────────────────────────────────────────────────┐│
│ │ ID │ Name │ Phone │ Email │ Address │ Category          ││
│ └──────────────────────────────────────────────────────────┘│
└────────────────────────────────────────────────────────────┘
```

---

## 5. Product Form (`ProductMgtFrm`)

```
 Product Management
┌─ Product / Service Details ──────────────────────────────────┐
│ Code │ Name │ Type▼ │ Brand │ Size │ Retail │ Wholesale │ Qty │
│ [Add] [Update] [Delete] [Clear]                              │
└────────────────────────────────────────────────────────────┘
┌─ Product List ─────────────────────────────────────────────┐
│ Search [________________] [Search]                           │
│ (DataGridView: all tyre/tube/service items)                  │
└────────────────────────────────────────────────────────────┘
```

---

## 6. Supplier Form (`AddSupplierMgt`)

Same CRUD layout as Customer: contact name, company, phone, email, address, action buttons, searchable grid below.

---

## 7. Staff Form (`StaffMgtFrm`)

```
┌─ Staff Account ──────────────────────────────────────────────┐
│ Username │ Full Name │ Password │ Phone │ Role▼ │ ☑ Active │
│ [Add Staff] [Update] [Clear]                                 │
└────────────────────────────────────────────────────────────┘
│ Grid: user_id, username, full_name, role, active           │
```

---

## 8. POS Form (`SalesPOS`)

```
 Sales Point of Sale
┌─ Product Catalog ────────┬─ Customer & Payment ─────────────┐
│ Search [____] [Search]   │ Customer [Walk-in ▼] Payment [Cash▼]│
│ ┌──────────────────────┐ ├─ Shopping Cart ────────────────────┤
│ │ tyres & services     │ │ Qty [1] [Add] [Remove]           │
│ └──────────────────────┘ │ ┌──────────────────────────────┐ │
│                          │ │ Item │ Qty │ Price │ Total    │ │
│                          │ └──────────────────────────────┘ │
│                          ├─ Payment Summary (dark panel) ───┤
│                          │ Subtotal │ Discount │ TOTAL       │
│                          │ [Clear Cart] [Complete Sale]     │
└──────────────────────────┴──────────────────────────────────┘
```

---

## 9. Inventory Form (`InventoryMgtFrm`)

```
┌─ Stock Adjustment ─────────────────────────────────────────┐
│ Reason▼ │ Qty +/- │ Remarks │ Selected: (row) │ [Apply]     │
└────────────────────────────────────────────────────────────┘
┌─ Current Stock Levels ───────────────────────────────────────┐
│ Search │ Refresh │ ☐ Show low stock only                     │
│ (grid: code, name, brand, size, qty, reorder)                │
└────────────────────────────────────────────────────────────┘
```

---

## 10. Reports Form (`ReportsFrm`)

```
┌─ Report Filters ───────────────────────────────────────────┐
│ Report [Daily Sales ▼]  From [date]  To [date]  [Generate] [Export CSV] │
└────────────────────────────────────────────────────────────┘
┌─ Report Output ──────────────────────────────────────────────┐
│ (DataGridView results)                                       │
│ Summary: —                                                   │
└────────────────────────────────────────────────────────────┘
```

---

## Screenshots for your report

1. Run the app → capture **Login** full window.
2. Login as `admin` / `admin123` → **Dashboard** with stat cards.
3. Open each sidebar item and capture one screen per module.
4. Highlight **validation messages** (empty field, invalid phone).
5. Include **POS cart** with at least one line item.

These images satisfy “system screenshots” requirements for ICT 222 documentation.
