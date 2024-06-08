use test;
CREATE TABLE `Dealer` (
  `DealerID` int PRIMARY KEY AUTO_INCREMENT,
  `DealerName` varchar(255) NOT NULL,
  `SaleAreaID` int NOT NULL,
  `ContantNumber` varchar(20) UNIQUE NOT NULL,
  `email` varchar(255) NOT NULL,
  `OfficeAddress` varchar(255) NOT NULL,
  `DeliveryAddress` varchar(255)
);

CREATE TABLE `SaleArea` (
  `AreaID` int PRIMARY KEY AUTO_INCREMENT,
  `Location` varchar(255) NOT NULL,
  `remark` varchar(255)
);

CREATE TABLE `Staff` (
  `StaffID` int PRIMARY KEY AUTO_INCREMENT,
  `StaffName` varchar(255),
  `SaleAreaID` int,
  `DeptID` varchar(5),
  `Position` varchar(255) NOT NULL COMMENT '下拉表單',
  `PhoneNunber` varchar(20) UNIQUE NOT NULL,
  `Gender` ENUM ('F', 'M') NOT NULL
);

CREATE TABLE `Department` (
  `DeptID` varchar(5) PRIMARY KEY,
  `DeptEmail` varchar(255) NOT NULL,
  `DeptName` varchar(255) NOT NULL,
  `WarehouseID` int
);

CREATE TABLE `User` (
  `UserID` int PRIMARY KEY AUTO_INCREMENT,
  `LoginName` varchar(248) UNIQUE NOT NULL,
  `Password` char(65) NOT NULL COMMENT 'the first char is the state of the account(such as ! mean bock)the next 64 char is sha256',
  `AccessLevel` int NOT NULL DEFAULT 10000 COMMENT '0 has the highest permission',
  `DealerID` int COMMENT 'if it is null, mean this user is a staff of Dealer',
  `StaffID` int
);

CREATE TABLE `Cart` (
  `UserID` int,
  `SpareID` char(6),
  `Qty` int,
  PRIMARY KEY (`UserID`, `SpareID`)
);

CREATE TABLE `Category` (
  `CategoryLetter` ENUM ('A', 'B', 'C', 'D') PRIMARY KEY COMMENT 'only can be A-D',
  `Type` ENUM ('Sheet Metal', 'Major Assemblies', 'Light Components', 'Accessories') NOT NULL COMMENT 'only can be Sheet Metal, Major Assemblies, Light Components and Accessories'
);

CREATE TABLE `Supplier` (
  `SupplierID` int PRIMARY KEY AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `ContantNumber` varchar(20) UNIQUE NOT NULL,
  `email` varchar(255) NOT NULL
);

CREATE TABLE `Spare` (
  `SpareID` char(6) PRIMARY KEY COMMENT 'CategoryLetter+5-digit number
Sometime it name part no.',
  `CategoryLetter` ENUM ('A', 'B', 'C', 'D'),
  `SpareName` varchar(255) NOT NULL,
  `Price` DECIMAL(20,2) NOT NULL,
  `Description` varchar(255) DEFAULT 'none',
  `Weight` float NOT NULL COMMENT 'unit is g',
  `SupplierID` int NOT NULL
);

CREATE TABLE `Stock` (
  `SpareID` char(6) PRIMARY KEY ,
  `quantity` int NOT NULL COMMENT 'Total Stock of all warehouse'
);

CREATE TABLE `ActualStock` (
  `WarehouseID` int,
  `SpareID` char(6),
  `quantity` int NOT NULL,
  `AutoRestork` bool NOT NULL DEFAULT true,
  PRIMARY KEY (`WarehouseID`, `SpareID`)
);

CREATE TABLE `Order` (
  `OrderSerial` char(20) PRIMARY KEY COMMENT 'Format: YYYYMMDD-hhmm-Dealer.DealerID',
  `DealerID` int NOT NULL,
  `OrderDate` datetime NOT NULL DEFAULT (now()) COMMENT 'it can not use timestamp',
  `OrderNumberfromDealer` varchar(255),
  `State` char(1) NOT NULL COMMENT 'use a char to record the state(F = this order is finished, W = Waiting to finished, etc...)',
  `remark` varchar(255)
);

CREATE TABLE `OrderItem` (
  `OrderSerial` char(20),
  `ItemID` char(6),
  `Quantity` int NOT NULL DEFAULT 1,
  `PriceInOrder` DECIMAL(20,2) NOT NULL COMMENT '防止改價，令報表出錯',
  PRIMARY KEY (`OrderSerial`, `ItemID`)
);

CREATE TABLE `OrderItemToFollow` (
  `OrderSerial` char(20),
  `ItemID` char(6),
  `Quantity` int NOT NULL DEFAULT 1,
  `State` char(1) NOT NULL COMMENT 'use a char to record the state(D = Dnoe, W = Wait, etc...)',
  PRIMARY KEY (`OrderSerial`, `ItemID`)
);

CREATE TABLE `ActualQuantityDespatched` (
  `WarehouseID` int,
  `InvoiceID` char(15),
  `ItemID` char(6),
  `Quantity` int NOT NULL DEFAULT 1,
  `BundlesNumber` int NOT NULL DEFAULT 0,
  PRIMARY KEY (`WarehouseID`, `InvoiceID`, `ItemID`)
);

CREATE TABLE `ScrapItems` (
  `ItemID` char(6),
  `RecordTime` datetime NOT NULL,
  `RecordStaffID` int NOT NULL,
  `Quantity` int NOT NULL DEFAULT 1,
  `Discrepancy` varchar(255) NOT NULL,
  PRIMARY KEY (`ItemID`, `RecordTime`)
);

CREATE TABLE `RestockOrder` (
  `RestockOrderID` int PRIMARY KEY AUTO_INCREMENT,
  `WarehouseID` int,
  `OrderDate` date NOT NULL,
  `Remark` varchar(255)
);

CREATE TABLE `RestockItem` (
  `RestockOrderID` int,
  `ItemID` char(6),
  `Quantity` int NOT NULL DEFAULT 1,
  `State` char(1) NOT NULL,
  PRIMARY KEY (`RestockOrderID`, `ItemID`)
);

CREATE TABLE `Invoice` (
  `InvoiceID` char(15) PRIMARY KEY COMMENT 'YYYYMMDD+DealerID+SerialNo.(1-9)',
  `OrderSerial` char(20) NOT NULL,
  `DespatchForemanID` int,
  `InvoiceDate` date NOT NULL,
  `CompleteState` char(1) NOT NULL DEFAULT 'C'
);

CREATE TABLE `Signture` (
  `InvoiceID` char(15) PRIMARY KEY,
  `Name` varchar(255) NOT NULL,
  `SigntureDate` datetime NOT NULL,
  `Sign` longtext NOT NULL
);

CREATE TABLE `Truck` (
  `TruckID` int PRIMARY KEY AUTO_INCREMENT,
  `SaleAreaID` int,
  `LicensePlate` varchar(255)
);

CREATE TABLE `TruckInvoice` (
  `TruckID` int,
  `InvoiceID` char(15),
  PRIMARY KEY (`TruckID`, `InvoiceID`)
);

CREATE TABLE `Warehouse` (
  `WarehouseID` int PRIMARY KEY AUTO_INCREMENT,
  `SaleAreaID` int NOT NULL,
  `Location` varchar(255) NOT NULL
);

CREATE TABLE `WarehouseStockLevel` (
  `WarehouseID` int,
  `SpareID` char(6),
  `ROL` int NOT NULL DEFAULT 0,
  `DL` int NOT NULL DEFAULT 0,
  `CSL` int NOT NULL DEFAULT (ROL*1.2) COMMENT '如果短期內多次到達ROL, 則CSL會變大',
  PRIMARY KEY (`WarehouseID`, `SpareID`)
);

ALTER TABLE `ActualStock` ADD FOREIGN KEY (`WarehouseID`) REFERENCES `Warehouse` (`WarehouseID`);

ALTER TABLE `ActualStock` ADD FOREIGN KEY (`SpareID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `Signture` ADD FOREIGN KEY (`InvoiceID`) REFERENCES `Invoice` (`InvoiceID`);

ALTER TABLE `Cart` ADD FOREIGN KEY (`UserID`) REFERENCES `User` (`UserID`);

ALTER TABLE `Cart` ADD FOREIGN KEY (`SpareID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `Dealer` ADD FOREIGN KEY (`SaleAreaID`) REFERENCES `SaleArea` (`AreaID`);

ALTER TABLE `Staff` ADD FOREIGN KEY (`SaleAreaID`) REFERENCES `SaleArea` (`AreaID`);

ALTER TABLE `Staff` ADD FOREIGN KEY (`DeptID`) REFERENCES `Department` (`DeptID`);

ALTER TABLE `Department` ADD FOREIGN KEY (`WarehouseID`) REFERENCES `Warehouse` (`WarehouseID`);

ALTER TABLE `User` ADD FOREIGN KEY (`DealerID`) REFERENCES `Dealer` (`DealerID`);

ALTER TABLE `User` ADD FOREIGN KEY (`StaffID`) REFERENCES `Staff` (`StaffID`);

ALTER TABLE `Spare` ADD FOREIGN KEY (`CategoryLetter`) REFERENCES `Category` (`CategoryLetter`);

ALTER TABLE `Spare` ADD FOREIGN KEY (`SupplierID`) REFERENCES `Supplier` (`SupplierID`);

ALTER TABLE `Stock` ADD FOREIGN KEY (`SpareID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `Order` ADD FOREIGN KEY (`DealerID`) REFERENCES `Dealer` (`DealerID`);

ALTER TABLE `OrderItem` ADD FOREIGN KEY (`OrderSerial`) REFERENCES `Order` (`OrderSerial`);

ALTER TABLE `OrderItem` ADD FOREIGN KEY (`ItemID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `OrderItemToFollow` ADD FOREIGN KEY (`OrderSerial`) REFERENCES `Order` (`OrderSerial`);

ALTER TABLE `OrderItemToFollow` ADD FOREIGN KEY (`ItemID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `ActualQuantityDespatched` ADD FOREIGN KEY (`WarehouseID`) REFERENCES `Warehouse` (`WarehouseID`);

ALTER TABLE `ActualQuantityDespatched` ADD FOREIGN KEY (`InvoiceID`) REFERENCES `Invoice` (`InvoiceID`);

ALTER TABLE `ActualQuantityDespatched` ADD FOREIGN KEY (`ItemID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `ScrapItems` ADD FOREIGN KEY (`ItemID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `ScrapItems` ADD FOREIGN KEY (`RecordStaffID`) REFERENCES `Staff` (`StaffID`);

ALTER TABLE `RestockOrder` ADD FOREIGN KEY (`WarehouseID`) REFERENCES `Warehouse` (`WarehouseID`);

ALTER TABLE `RestockItem` ADD FOREIGN KEY (`RestockOrderID`) REFERENCES `RestockOrder` (`RestockOrderID`);

ALTER TABLE `RestockItem` ADD FOREIGN KEY (`ItemID`) REFERENCES `Spare` (`SpareID`);

ALTER TABLE `Invoice` ADD FOREIGN KEY (`OrderSerial`) REFERENCES `Order` (`OrderSerial`);

ALTER TABLE `Invoice` ADD FOREIGN KEY (`DespatchForemanID`) REFERENCES `Staff` (`StaffID`);

ALTER TABLE `Truck` ADD FOREIGN KEY (`SaleAreaID`) REFERENCES `SaleArea` (`AreaID`);

ALTER TABLE `TruckInvoice` ADD FOREIGN KEY (`TruckID`) REFERENCES `Truck` (`TruckID`);

ALTER TABLE `TruckInvoice` ADD FOREIGN KEY (`InvoiceID`) REFERENCES `Invoice` (`InvoiceID`);

ALTER TABLE `Warehouse` ADD FOREIGN KEY (`SaleAreaID`) REFERENCES `SaleArea` (`AreaID`);

ALTER TABLE `WarehouseStockLevel` ADD FOREIGN KEY (`WarehouseID`) REFERENCES `Warehouse` (`WarehouseID`);

ALTER TABLE `WarehouseStockLevel` ADD FOREIGN KEY (`SpareID`) REFERENCES `Spare` (`SpareID`);
