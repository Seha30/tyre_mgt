-- =============================================================================
-- Sample data for development & demo (run after 01_schema.sql)
-- =============================================================================

USE `inventory`;

-- Roles
INSERT INTO `roles` (`role_id`, `role_name`) VALUES
(1, 'Admin'),
(2, 'Cashier'),
(3, 'Manager');

-- Users (passwords stored as plain text for coursework – see README)
INSERT INTO `users` (`user_id`, `username`, `password_hash`, `full_name`, `phone`, `role_id`, `is_active`) VALUES
(1, 'admin',   'admin123',   'System Administrator', '0770000001', 1, 1),
(2, 'manager', 'manager789', 'Shop Manager',         '0770000002', 3, 1),
(3, 'cashier', 'cash456',    'POS Cashier',          '0770000003', 2, 1);

-- Shop settings
INSERT INTO `shop_settings` (`setting_id`, `shop_name`, `shop_address`, `shop_phone`, `low_stock_default`, `invoice_prefix`) VALUES
(1, 'S & N Tyre Center', 'Piliyandala, Sri Lanka', '0112345678', 5, 'INV');

-- Customers
INSERT INTO `customers` (`cus_id`, `cus_name`, `cus_phone`, `cus_email`, `cus_address`, `price_category`) VALUES
(1, 'Nimal',   '0715226918', 'nimal566@gmail.com',  'Colombo',   'Wholesale'),
(2, 'Chamali', '0115266515', 'chamali@gmail.com',   'Colombo',   'Retail'),
(3, 'Chamath', '0759999999', 'chamath@gmail.com',   'Kalutara',  'Distributor');

-- Suppliers
INSERT INTO `suppliers` (`sup_id`, `sup_name`, `sup_company`, `sup_phone`, `sup_email`, `sup_address`) VALUES
(1, 'Kumara Perera', 'Ceat Lanka Distributors', '0771111111', 'ceat@supplier.lk', 'Colombo 10'),
(2, 'Sunil Fernando', 'Michelin Partner SL',    '0772222222', 'michelin@partner.lk', 'Negombo');

-- Items – tyres, tube, services
INSERT INTO `items` (
  `item_code`, `item_name`, `item_type`, `brand`, `tyre_size`,
  `retail_price`, `wholesale_price`, `cost_price`, `quantity`, `reorder_level`, `tracks_stock`, `sup_id`
) VALUES
('TYR-195-65-15', '195/65R15 Ceat Secura',  'Tyre',    'Ceat',     '195/65R15', 18500.00, 17200.00, 15000.00, 24, 5, 1, 1),
('TYR-205-55-16', '205/55R16 Michelin',     'Tyre',    'Michelin', '205/55R16', 24500.00, 22800.00, 20000.00, 12, 5, 1, 2),
('TUB-165-13',    '165/13 Tube',            'Tube',    'Generic',  '165/13',     1200.00,  1000.00,   800.00, 40, 10, 1, 1),
('SRV-ALIGN',     'Wheel Alignment',        'Service', NULL,       NULL,         3500.00,  3000.00,     0.00,  0,  0, 0, NULL),
('SRV-BALANCE',   'Wheel Balancing (per tyre)','Service',NULL,      NULL,          800.00,   700.00,     0.00,  0,  0, 0, NULL),
('SRV-RIM',       'Rim Setting',            'Service', NULL,       NULL,         1500.00,  1200.00,     0.00,  0,  0, 0, NULL),
('ACC-VALVE',     'Tubeless Valve',         'Accessory',NULL,      NULL,          250.00,   200.00,   120.00, 100, 20, 1, 1);
