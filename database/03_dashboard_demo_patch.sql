-- Run this if you already imported the database before dashboard demo data was added.
-- Safe to run once; skip if you re-import 01_schema.sql + 02_seed.sql from scratch.

USE `inventory`;

UPDATE `items` SET `quantity` = 3  WHERE `item_code` = 'TYR-205-55-16';
UPDATE `items` SET `quantity` = 15 WHERE `item_code` = 'ACC-VALVE';

INSERT INTO `sales` (
  `invoice_no`, `sale_date`, `cus_id`, `user_id`,
  `subtotal`, `discount_amount`, `discount_pct`, `total_amount`,
  `payment_method`, `status`
)
SELECT 'INV-0001', CONCAT(CURDATE(), ' 10:30:00'), 1, 3, 37000.00, 0.00, 0.00, 37000.00, 'Cash', 'Completed'
WHERE NOT EXISTS (SELECT 1 FROM `sales` WHERE `invoice_no` = 'INV-0001');

INSERT INTO `sales` (
  `invoice_no`, `sale_date`, `cus_id`, `user_id`,
  `subtotal`, `discount_amount`, `discount_pct`, `total_amount`,
  `payment_method`, `status`
)
SELECT 'INV-0002', CONCAT(CURDATE(), ' 14:15:00'), 2, 3, 24500.00, 0.00, 0.00, 24500.00, 'Card', 'Completed'
WHERE NOT EXISTS (SELECT 1 FROM `sales` WHERE `invoice_no` = 'INV-0002');

INSERT INTO `sale_items` (`sale_id`, `item_id`, `qty`, `unit_price`, `line_total`)
SELECT s.`sale_id`, i.`item_id`, 2, 18500.00, 37000.00
FROM `sales` s
JOIN `items` i ON i.`item_code` = 'TYR-195-65-15'
WHERE s.`invoice_no` = 'INV-0001'
  AND NOT EXISTS (SELECT 1 FROM `sale_items` si WHERE si.`sale_id` = s.`sale_id`);

INSERT INTO `sale_items` (`sale_id`, `item_id`, `qty`, `unit_price`, `line_total`)
SELECT s.`sale_id`, i.`item_id`, 1, 24500.00, 24500.00
FROM `sales` s
JOIN `items` i ON i.`item_code` = 'TYR-205-55-16'
WHERE s.`invoice_no` = 'INV-0002'
  AND NOT EXISTS (SELECT 1 FROM `sale_items` si WHERE si.`sale_id` = s.`sale_id`);
