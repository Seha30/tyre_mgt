# S & N Tyre Center — Inventory & Service Management System

VB.NET WinForms desktop application for **ICT 222**, Sabaragamuwa University.

## Features

| Module | Form | UI Includes |
|--------|------|-------------|
| Login | `LoginFrm` | Branded split layout, validation |
| Dashboard | `Dashboard` | Stat cards, low-stock grid, quick actions |
| Customers | `AddCustomer` | CRUD, search, DataGridView |
| Products | `ProductMgtFrm` | Tyre/service fields, CRUD, search |
| Suppliers | `AddSupplierMgt` | CRUD, search |
| Staff | `StaffMgtFrm` | Users & roles |
| POS | `SalesPOS` | Catalog, cart, totals |
| Inventory | `InventoryMgtFrm` | Stock list, adjustments |
| Reports | `ReportsFrm` | Filters, export CSV |
| Settings | `Settings` | Shop profile |

## Setup

1. Install **Visual Studio 2022+** with .NET Framework 4.8 and **XAMPP** (MySQL).
2. Run database scripts in order:
   - `database/01_schema.sql`
   - `database/02_seed.sql`
3. Open `tyre_mgt.slnx` and restore NuGet packages.
4. Start XAMPP MySQL; database name: `inventory`.
5. Build and run (F5). Default login: `admin` / `admin123`.

## Validation

Rules are enforced in:

- **UI:** `ValidationHelper.vb` (shared checks before save)
- **Database:** `database/01_schema.sql` (CHECK constraints, triggers)

See `docs/UI_MOCKUPS.md` for screen layout descriptions for your report.

## Project structure

```
tyre_mgt/
├── database/          # SQL schema + seed data
├── docs/              # UI mockup descriptions
├── *Frm.vb            # Form logic
├── *Frm.Designer.vb   # Visual UI layout (Guna.UI2)
├── *CRUD.vb           # Data access modules
├── UiThemeHelper.vb   # Consistent colors/buttons
└── ValidationHelper.vb
```

## Tech stack

- VB.NET WinForms (.NET 4.8)
- Guna.UI2 WinForms
- MySQL (XAMPP / MariaDB)

## Author

H M S Thathsiluni — 22SSL6961
