-- =============================================================================
-- S & N Tyre Center – Inventory & Service Management System
-- Database schema (MariaDB 10.4+ / MySQL 8+ via XAMPP)
-- =============================================================================
-- Run in phpMyAdmin or: mysql -u root < database/01_schema.sql
-- =============================================================================

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+05:30";
SET NAMES utf8mb4;

CREATE DATABASE IF NOT EXISTS `inventory`
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE `inventory`;

-- Drop in dependency order (safe re-run during development)
DROP TRIGGER IF EXISTS `trg_sale_items_before_insert`;
DROP TRIGGER IF EXISTS `trg_sale_items_after_insert`;
DROP TRIGGER IF EXISTS `trg_stock_adjustment_after_insert`;
DROP TABLE IF EXISTS `sale_items`;
DROP TABLE IF EXISTS `sales`;
DROP TABLE IF EXISTS `stock_adjustments`;
DROP TABLE IF EXISTS `items`;
DROP TABLE IF EXISTS `suppliers`;
DROP TABLE IF EXISTS `customers`;
DROP TABLE IF EXISTS `users`;
DROP TABLE IF EXISTS `roles`;
DROP TABLE IF EXISTS `shop_settings`;

-- -----------------------------------------------------------------------------
-- Roles & users (staff accounts)
-- -----------------------------------------------------------------------------
CREATE TABLE `roles` (
  `role_id`   TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
  `role_name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`role_id`),
  UNIQUE KEY `uk_roles_name` (`role_name`)
) ENGINE=InnoDB;

CREATE TABLE `users` (
  `user_id`       INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `username`      VARCHAR(50) NOT NULL,
  `password_hash` VARCHAR(255) NOT NULL COMMENT 'Plain for coursework demo; hash in production',
  `full_name`     VARCHAR(100) NOT NULL,
  `phone`         CHAR(10) DEFAULT NULL,
  `role_id`       TINYINT UNSIGNED NOT NULL,
  `is_active`     TINYINT(1) NOT NULL DEFAULT 1,
  `created_at`    DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `uk_users_username` (`username`),
  KEY `idx_users_role` (`role_id`),
  CONSTRAINT `fk_users_role`
    FOREIGN KEY (`role_id`) REFERENCES `roles` (`role_id`)
    ON UPDATE CASCADE,
  CONSTRAINT `chk_users_phone`
    CHECK (`phone` IS NULL OR `phone` REGEXP '^[0-9]{10}$'),
  CONSTRAINT `chk_users_active`
    CHECK (`is_active` IN (0, 1))
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Customers
-- -----------------------------------------------------------------------------
CREATE TABLE `customers` (
  `cus_id`          INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `cus_name`        VARCHAR(100) NOT NULL,
  `cus_phone`       CHAR(10) NOT NULL,
  `cus_email`       VARCHAR(150) DEFAULT NULL,
  `cus_address`     VARCHAR(400) NOT NULL,
  `price_category`  ENUM('Retail', 'Wholesale', 'Distributor') NOT NULL DEFAULT 'Retail',
  `is_active`       TINYINT(1) NOT NULL DEFAULT 1,
  `created_at`      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at`      DATETIME NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`cus_id`),
  UNIQUE KEY `uk_customers_phone` (`cus_phone`),
  KEY `idx_customers_name` (`cus_name`),
  KEY `idx_customers_category` (`price_category`),
  CONSTRAINT `chk_customers_phone`
    CHECK (`cus_phone` REGEXP '^[0-9]{10}$'),
  CONSTRAINT `chk_customers_email`
    CHECK (`cus_email` IS NULL OR `cus_email` REGEXP '^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$'),
  CONSTRAINT `chk_customers_active`
    CHECK (`is_active` IN (0, 1))
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Suppliers
-- -----------------------------------------------------------------------------
CREATE TABLE `suppliers` (
  `sup_id`      INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `sup_name`    VARCHAR(100) NOT NULL,
  `sup_company` VARCHAR(100) DEFAULT NULL,
  `sup_phone`   CHAR(10) NOT NULL,
  `sup_email`   VARCHAR(150) DEFAULT NULL,
  `sup_address` VARCHAR(400) DEFAULT NULL,
  `is_active`   TINYINT(1) NOT NULL DEFAULT 1,
  `created_at`  DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`sup_id`),
  UNIQUE KEY `uk_suppliers_phone` (`sup_phone`),
  CONSTRAINT `chk_suppliers_phone`
    CHECK (`sup_phone` REGEXP '^[0-9]{10}$'),
  CONSTRAINT `chk_suppliers_email`
    CHECK (`sup_email` IS NULL OR `sup_email` REGEXP '^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$'),
  CONSTRAINT `chk_suppliers_active`
    CHECK (`is_active` IN (0, 1))
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Items (tyres, tubes, services, accessories – single table)
-- -----------------------------------------------------------------------------
CREATE TABLE `items` (
  `item_id`        INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `item_code`      VARCHAR(30) NOT NULL,
  `item_name`      VARCHAR(150) NOT NULL,
  `item_type`      ENUM('Tyre', 'Tube', 'Service', 'Accessory') NOT NULL,
  `brand`          VARCHAR(50) DEFAULT NULL,
  `tyre_size`      VARCHAR(30) DEFAULT NULL COMMENT 'e.g. 195/65R15',
  `retail_price`   DECIMAL(12,2) NOT NULL,
  `wholesale_price` DECIMAL(12,2) NOT NULL DEFAULT 0.00,
  `cost_price`     DECIMAL(12,2) NOT NULL DEFAULT 0.00,
  `quantity`       INT NOT NULL DEFAULT 0,
  `reorder_level`  INT NOT NULL DEFAULT 5,
  `tracks_stock`   TINYINT(1) NOT NULL DEFAULT 1 COMMENT '0 = services (unlimited)',
  `sup_id`         INT UNSIGNED DEFAULT NULL,
  `is_active`      TINYINT(1) NOT NULL DEFAULT 1,
  `created_at`     DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at`     DATETIME NULL DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`item_id`),
  UNIQUE KEY `uk_items_code` (`item_code`),
  KEY `idx_items_type` (`item_type`),
  KEY `idx_items_brand_size` (`brand`, `tyre_size`),
  KEY `idx_items_low_stock` (`quantity`, `reorder_level`),
  CONSTRAINT `fk_items_supplier`
    FOREIGN KEY (`sup_id`) REFERENCES `suppliers` (`sup_id`)
    ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `chk_items_prices`
    CHECK (`retail_price` >= 0 AND `wholesale_price` >= 0 AND `cost_price` >= 0),
  CONSTRAINT `chk_items_quantity`
    CHECK (`quantity` >= 0),
  CONSTRAINT `chk_items_reorder`
    CHECK (`reorder_level` >= 0),
  CONSTRAINT `chk_items_wholesale_lte_retail`
    CHECK (`wholesale_price` <= `retail_price` OR `wholesale_price` = 0),
  CONSTRAINT `chk_items_active`
    CHECK (`is_active` IN (0, 1)),
  CONSTRAINT `chk_items_tracks_stock`
    CHECK (`tracks_stock` IN (0, 1)),
  CONSTRAINT `chk_items_service_no_stock`
    CHECK (
      (`item_type` <> 'Service') OR (`tracks_stock` = 0 AND `quantity` = 0)
    )
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Sales & line items
-- -----------------------------------------------------------------------------
CREATE TABLE `sales` (
  `sale_id`         INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `invoice_no`      VARCHAR(20) NOT NULL,
  `sale_date`       DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `cus_id`          INT UNSIGNED DEFAULT NULL,
  `user_id`         INT UNSIGNED NOT NULL,
  `subtotal`        DECIMAL(12,2) NOT NULL,
  `discount_amount` DECIMAL(12,2) NOT NULL DEFAULT 0.00,
  `discount_pct`    DECIMAL(5,2) NOT NULL DEFAULT 0.00,
  `total_amount`    DECIMAL(12,2) NOT NULL,
  `payment_method`  ENUM('Cash', 'Card', 'Bank Transfer', 'Credit') NOT NULL DEFAULT 'Cash',
  `notes`           VARCHAR(500) DEFAULT NULL,
  `status`          ENUM('Completed', 'Cancelled') NOT NULL DEFAULT 'Completed',
  PRIMARY KEY (`sale_id`),
  UNIQUE KEY `uk_sales_invoice` (`invoice_no`),
  KEY `idx_sales_date` (`sale_date`),
  KEY `idx_sales_customer` (`cus_id`),
  CONSTRAINT `fk_sales_customer`
    FOREIGN KEY (`cus_id`) REFERENCES `customers` (`cus_id`)
    ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_sales_user`
    FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
    ON UPDATE CASCADE,
  CONSTRAINT `chk_sales_amounts`
  CHECK (
    `subtotal` >= 0
    AND `discount_amount` >= 0
    AND `discount_pct` >= 0 AND `discount_pct` <= 100
    AND `total_amount` >= 0
    AND `total_amount` <= `subtotal`
  )
) ENGINE=InnoDB;

CREATE TABLE `sale_items` (
  `sale_item_id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `sale_id`      INT UNSIGNED NOT NULL,
  `item_id`      INT UNSIGNED NOT NULL,
  `qty`          INT NOT NULL,
  `unit_price`   DECIMAL(12,2) NOT NULL,
  `line_total`   DECIMAL(12,2) NOT NULL,
  PRIMARY KEY (`sale_item_id`),
  KEY `idx_sale_items_sale` (`sale_id`),
  KEY `idx_sale_items_item` (`item_id`),
  CONSTRAINT `fk_sale_items_sale`
    FOREIGN KEY (`sale_id`) REFERENCES `sales` (`sale_id`)
    ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_sale_items_item`
    FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`)
    ON UPDATE CASCADE,
  CONSTRAINT `chk_sale_items_qty`
    CHECK (`qty` > 0),
  CONSTRAINT `chk_sale_items_price`
    CHECK (`unit_price` >= 0 AND `line_total` >= 0),
  CONSTRAINT `chk_sale_items_line_math`
    CHECK (ABS(`line_total` - (`unit_price` * `qty`)) < 0.01)
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Stock adjustments (receive, damage, correction)
-- -----------------------------------------------------------------------------
CREATE TABLE `stock_adjustments` (
  `adj_id`     INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `item_id`    INT UNSIGNED NOT NULL,
  `adj_qty`    INT NOT NULL COMMENT 'Positive = in, negative = out',
  `reason`     ENUM('Purchase', 'Damage', 'Return', 'Correction', 'Other') NOT NULL,
  `remarks`    VARCHAR(300) DEFAULT NULL,
  `user_id`    INT UNSIGNED NOT NULL,
  `adj_date`   DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`adj_id`),
  KEY `idx_adj_item` (`item_id`),
  KEY `idx_adj_date` (`adj_date`),
  CONSTRAINT `fk_adj_item`
    FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`)
    ON UPDATE CASCADE,
  CONSTRAINT `fk_adj_user`
    FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
    ON UPDATE CASCADE,
  CONSTRAINT `chk_adj_qty_nonzero`
    CHECK (`adj_qty` <> 0)
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Shop settings (single row)
-- -----------------------------------------------------------------------------
CREATE TABLE `shop_settings` (
  `setting_id`    TINYINT UNSIGNED NOT NULL DEFAULT 1,
  `shop_name`     VARCHAR(150) NOT NULL DEFAULT 'S & N Tyre Center',
  `shop_address`  VARCHAR(400) NOT NULL DEFAULT 'Piliyandala, Sri Lanka',
  `shop_phone`    CHAR(10) NOT NULL DEFAULT '0110000000',
  `low_stock_default` INT NOT NULL DEFAULT 5,
  `invoice_prefix` VARCHAR(10) NOT NULL DEFAULT 'INV',
  PRIMARY KEY (`setting_id`),
  CONSTRAINT `chk_settings_single_row`
    CHECK (`setting_id` = 1),
  CONSTRAINT `chk_settings_phone`
    CHECK (`shop_phone` REGEXP '^[0-9]{10}$')
) ENGINE=InnoDB;

-- -----------------------------------------------------------------------------
-- Views
-- -----------------------------------------------------------------------------
CREATE OR REPLACE VIEW `v_low_stock_items` AS
SELECT
  i.`item_id`, i.`item_code`, i.`item_name`, i.`item_type`,
  i.`brand`, i.`tyre_size`, i.`quantity`, i.`reorder_level`,
  (i.`reorder_level` - i.`quantity`) AS `units_below_level`
FROM `items` i
WHERE i.`tracks_stock` = 1
  AND i.`is_active` = 1
  AND i.`quantity` <= i.`reorder_level`;

CREATE OR REPLACE VIEW `v_daily_sales_summary` AS
SELECT
  DATE(`sale_date`) AS `sale_day`,
  COUNT(*) AS `invoice_count`,
  SUM(`total_amount`) AS `revenue`
FROM `sales`
WHERE `status` = 'Completed'
GROUP BY DATE(`sale_date`);

-- -----------------------------------------------------------------------------
-- Triggers – stock integrity
-- -----------------------------------------------------------------------------

DELIMITER $$

-- Block sale when insufficient stock (stock-tracked items only)
CREATE TRIGGER `trg_sale_items_before_insert`
BEFORE INSERT ON `sale_items`
FOR EACH ROW
BEGIN
  DECLARE v_tracks TINYINT;
  DECLARE v_qty INT;
  DECLARE v_name VARCHAR(150);

  SELECT `tracks_stock`, `quantity`, `item_name`
  INTO v_tracks, v_qty, v_name
  FROM `items`
  WHERE `item_id` = NEW.`item_id`
  FOR UPDATE;

  IF v_tracks = 1 AND NEW.`qty` > v_qty THEN
    SIGNAL SQLSTATE '45000'
      SET MESSAGE_TEXT = 'Insufficient stock for this item';
  END IF;
END$$

-- Auto-reduce stock after sale line inserted
CREATE TRIGGER `trg_sale_items_after_insert`
AFTER INSERT ON `sale_items`
FOR EACH ROW
BEGIN
  UPDATE `items`
  SET `quantity` = `quantity` - NEW.`qty`,
      `updated_at` = CURRENT_TIMESTAMP
  WHERE `item_id` = NEW.`item_id`
    AND `tracks_stock` = 1;
END$$

-- Apply adjustment to item quantity; prevent negative stock
CREATE TRIGGER `trg_stock_adjustment_after_insert`
AFTER INSERT ON `stock_adjustments`
FOR EACH ROW
BEGIN
  DECLARE v_new_qty INT;

  SELECT `quantity` + NEW.`adj_qty`
  INTO v_new_qty
  FROM `items`
  WHERE `item_id` = NEW.`item_id`;

  IF v_new_qty < 0 THEN
    SIGNAL SQLSTATE '45000'
      SET MESSAGE_TEXT = 'Adjustment would make stock negative';
  END IF;

  UPDATE `items`
  SET `quantity` = v_new_qty,
      `updated_at` = CURRENT_TIMESTAMP
  WHERE `item_id` = NEW.`item_id`
    AND `tracks_stock` = 1;
END$$

DELIMITER ;
