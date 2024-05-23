use test;

/*SaleArea*/
INSERT INTO `SaleArea` (`AreaID`, `Location`, `remark`)
VALUES 
(1, 'Beijing', NULL),
(2, 'Shanghai', NULL),
(3, 'Guangzhou', NULL),
(4, 'Shenzhen', NULL),
(5, 'Tianjin', NULL),
(6, 'Hong Kong', NULL),
(7, 'Macau', NULL),
(8, 'Taipei', NULL),
(9, 'Nanjing', NULL),
(10, 'Qingdao', NULL),
(11, 'Hangzhou', NULL),
(12, 'Wuhan', NULL),
(13, 'Chengdu', NULL),
(14, 'Chongqing', NULL),
(15, 'Xiamen', NULL),
(16, 'Xi''an', NULL),
(17, 'Zhengzhou', NULL),
(18, 'Kunming', NULL),
(19, 'Dalian', NULL),
(20, 'Changsha', NULL),
(21, 'Jinan', NULL),
(22, 'Lanzhou', NULL),
(23, 'Zhuhai', NULL),
(24, 'Nanning', NULL),
(25, 'Harbin', NULL),
(26, 'Haikou', NULL),
(27, 'Shijiazhuang', NULL),
(28, 'Hefei', NULL),
(29, 'Changchun', NULL),
(30, 'Guiyang', NULL);

/*Warehouse*/
INSERT INTO `Warehouse` (`WarehouseID`, `SaleAreaID`, `Location`)
VALUES
(1, 18, 'Kunming'),
(2, 19, 'Dalian'),
(3, 20, 'Changsha'),
(4, 21, 'Jinan');

/*Department*/
INSERT INTO `Department` (`DeptID`, `DeptEmail`, `DeptName`, `WarehouseID`)
VALUES 
('manag', 'manager@legendmotor.com', 'Manager', NULL),
('sale', 'sales@legendmotor.com', 'Sales', NULL),
('makt', 'marketing@legendmotor.com', 'Marketing', NULL),
('hr', 'hr@legendmotor.com', 'Human Resources', NULL),
('fina', 'finance@legendmotor.com', 'Finance', NULL),
('it', 'it@legendmotor.com', 'IT', NULL),
('proc', 'procurement@legendmotor.com', 'Procurement', NULL),
('prod', 'production@legendmotor.com', 'Production', NULL),
('qa', 'quality@legendmotor.com', 'Quality Assurance', NULL),
('logi', 'logistics@legendmotor.com', 'Logistics', NULL),
('cs', 'service@legendmotor.com', 'Customer Service', NULL),
('wh001', 'warehouse001@legendmotor.com', 'Warehouse1', 1),
('wh002', 'warehouse002@legendmotor.com', 'Warehouse2', 2),
('wh003', 'warehouse003@legendmotor.com', 'Warehouse3', 3),
('wh004', 'warehouse004@legendmotor.com', 'Warehouse4', 4),
('Hdt', 'Headquarters@legendmotor.com', 'Headquarters', NULL);


/*Supplier*/
INSERT INTO `Supplier` (`SupplierID`, `Name`, `Address`, `ContantNumber`, `email`)
VALUES 
(100, 'SB company', '北京市朝阳区建国门外大街19号', '13987654301', 'sb@163.com'),
(101, 'GG company', '上海市浦东新区世纪大道8号', '15876543215', 'gg@qq.com'),
(102, 'OK company', '广东省深圳市罗湖区深南东路9号', '13654321098', 'ok@sina.com'),
(103, 'Movement Ltd.', '江苏省南京市鼓楼区汉口路6号', '15098765432', 'movement@sohu.com'),
(104, 'FK company', '浙江省杭州市西湖区文二西路4号', '13319896445', 'fk@aliyun.com'),
(105, 'OMG company', '四川省成都市锦江区人民中路20号', '13765432109', 'omg@foxmail.com'),
(106, 'Killer company', '湖南省长沙市岳麓区麓山南路19号', '15987654321', 'killer@qq.com'),
(107, 'nsml Ltd.', '河北省石家庄市裕华区裕华路7号', '13876543210', 'nsml@foxmail.com'),
(108, 'The Great company', '山东省青岛市市南区香港中路2号', '13543210987', 'thegreat@qq.com'),
(109, 'Translation company', '辽宁省大连市中山区人民广场1号', '15120197213', 'translation@qq.com');

/*Category*/
INSERT INTO `Category` (`CategoryLetter`, `Type`)
VALUES 
('A', 'Sheet Metal'),
('B', 'Major Assemblies'),
('C', 'Light Components'),
('D', 'Accessories');

/*Delear*/
INSERT INTO `Dealer` (`DealerID`, `DealerName`, `SaleAreaID`, `ContantNumber`, `email`, `OfficeAddress`, `DeliveryAddress`)
VALUES 
('000001', 'FY Ltd.', 1, '13111111110', 'fy@qq.com', '北京市朝陽區建國路100號1樓', '北京市朝陽區建國路100號1樓'),
('000002', 'Happy Ltd.', 1, '13111111111', 'happy@abc.com', '北京市海淀區西三旗街道1號', '北京市海淀區西三旗街道1號'),
('000003', 'IT Ltd.', 1, '13111111112', 'it@qq.com', '北京市昌平區回龍觀東大街2號', '北京市昌平區回龍觀東大街2號'),
('000004', 'SDP Ltd.', 1, '13111111113', 'sdp@qq.com', '北京市西城區西單北大街3號', '北京市西城區西單北大街3號'),
('000005', 'OOT Ltd.', 2, '13111111114', 'oot@qq.com', '上海市浦東新區東方明珠廣場', '香港中環皇后大道中1號'),
('000006', 'IMAD Ltd.', 4, '13111111115', 'imad@qq.com', '深圳市福田區華強北路5號', '廣州市天河區珠江新城華強路6號'),
('000007', 'ITE Ltd.', 6, '66666666', 'ite@qq.com', '香港中環皇后大道中1號', '廣州市天河區珠江新城華強路6號'),
('000008', 'DP Ltd.', 8, '13111111117', 'dp@qq.com', '台北市信義區忠孝東路5段7號', '南京市鼓樓區中山北路8號'),
('000009', 'SSD Ltd.', 15, '13111111118', 'ssd@qq.com', '廈門市思明區鼓浪屿路9號', '香港中環皇后大道中1號'),
('000010', 'OS Ltd.', 30, '13111111119', 'os@qq.com', '貴陽市南明區廣場北路10號', '南京市鼓樓區中山北路8號');

/*Staff*/
INSERT INTO `Staff` (`StaffID`, `StaffName`, `SaleAreaID`, `DeptID`, `Position`, `PhoneNunber`, `Gender`)
VALUES 
(1,	'Andy', 1, 18, 'wh001',	'storemen',	'13912345678', 'M'),
(2,	'李小明', 2, 19, 'wh002', 'storemen', '15898765432', 'M'),
(3,	'张三', 3, 20, 'wh003',	'storemen',	'13678901234',	'M'),
(4,	'苹', 4, 21, 'wh004', 'storemen', '15056789012',	'M'),
(5,	'ChanTomori', 1, 18, 'manag', 'manager', '13123456789', 'F'),
(6,	'WongTaki', 1, 18, 'wh001', 'delivery worker', '15816444441', 'F'),
(7,	'CheungSoyo', 2, 19, 'sale', 'LM officer', '19076550', 'F'),
(8,	'AuAnon', 4, 21, 'wh004', 'Storemen', '58436029', 'F'),
(9,	'陳大文', 4, 21, 'D0004', 'Accountant', '51493950', 'M'),
(10, 'ORana', 1, 18, 'wh001', 'Warehouseclerk',	'49164576',	'F'),
(11, 'AAA', 2, 19, 'wh002',	'Warehouseclerk', '50552739', 'F'),
(12, 'CCC', 1, 18, 'wh001',	'manager',	'98931962',	'M'),
(13, 'DDD', 2, 19, 'wh002', 'manager',	'23490946',	'F'),
(14, 'Sam', 3, 20, 'wh003', 'manager',	'89774445',	'M'),
(15, 'Apple', 4, 21, 'wh004', 'manager', '14564581', 'M'),
(16, 'ORana', 3, 20, 'wh003', 'Warehouseclerk',	'16043681',	'F'),
(17, '孫培玲', 4, 21, 'wh004',	'Warehouseclerk', '67468369',	'F'),
(18, '望醉冬', 2, 19, 'wh002',	'delivery worker', '15816444441',	'F'),
(19, '皇甫樂成', 3, 20,	'wh003', 'delivery worker', '15816444441', 'F'),
(20, '山靜白', 4, 21, 'wh004', 'delivery worker', '15816444441', 'F');


/*User*/
INSERT INTO `User` (`UserID`, `LoginName`, `Password`, `AccessLevel`, `DealerID`, `StaffID`)
VALUES 
(451561235, 'ATL', '0625895fc35fb2c9369b79ebde04732e80092f17a3922a67d892e33edab60618a', 300, '000001', NULL),
(894874213, 'kirito', '072832b58ffe173f2af8c7fb22cdb6e435f9b46734632416741a728c77ce57cdf', 300, '000002', NULL),
(123456789, 'cusidina', '0025cdf51fb9524752eb3db667029ccece6cd2f69bd866e95b3665bf63328b973', 300, '000005', NULL),
(987654321, 'kemono114', '!ea344b4943b025a75b2ade908b13adcfda77e2e89a42bb1f81b48232ee0a8c72', 300, '000006', NULL),
(159753456, 'idkABC', '031f66325fd1605b099729dd640a0e4b59288df81c446e1815b1b212225aa5b15', 300, '000008', NULL),
(426879513, 'asuna', '!7c58f352844615a5a0dfb37e586c1afca8da219b480196fcda7cdc1b070dc427', 400, NULL, 80),
(741852963, 'HAha123', '0234af95dfee7c0d505db92d419fd9338b20bfaa001d0c1f7c9d0f2b8e28480a2', 400, NULL, 86),
(369258147, 'happyCat', '0283e02af52d66ec50a9e7e20c75680652759bbb21aac9f5aab465dae80547984', 200, NULL, 18),
(789456123, 'wagananai', '0f0d3fe219039edf27a582767abe7ea9d0f557c046a650a50a3b1172238a9e947', 0, NULL, 16),
(987412365, 'ho', '0e7d8cfa6cb57754fc6e7c56700af4447cb05efafa1d7dc9080a740e298d967c1', 400, NULL, 10);

/*Spare*/
INSERT INTO `Spare` (`SpareID`, `CategoryLetter`, `SpareName`, `Price`, `Description`, `Weight`, `SupplierID`)
VALUES 
('A26130', 'A', 'WTF Aluminium alloy sheet', 68, NULL, 1, 104),
('B22978', 'B', 'Hole engine', 2248, NULL, 500, 106),
('C10435', 'C', 'Shiift Tail Light Assembly', 155, NULL, 838, 102),
('D75438', 'D', 'Tis Vehicle Car Recorder', 429, NULL, 32, 103),
('C91177', 'C', 'Porject Headlight Assembly', 652, NULL, 389, 109),
('D52143', 'D', 'IS In-vehicle mobile phone holder', 202, NULL, 31, 103),
('A48880', 'A', 'fire Stainless Steel Sheet', 17, NULL, 0.01, 102),
('D31172', 'D', 'DDD Vehicle Air Cleaner', 157, NULL, 15, 106),
('D62438', 'D', 'GGG Car USB Charger', 473, NULL, 20, 102),
('B25912', 'B', 'www cooling system', 4787, NULL, 397, 106);



/*Stock*/
INSERT INTO `Stock` (`WarehouseID`, `SpareID`, `AutoRestork`, `quantity`)
VALUES 
(1, 'A26130', TRUE, 100),
(1, 'C91177', TRUE, 1000),
(1, 'D62438', FALSE, 1010),
(2, 'B22978', FALSE, 10),
(2, 'B25912', TRUE, 1014),
(2, 'D52143', TRUE, 101),
(3, 'A48880', TRUE, 100),
(3, 'C10435', TRUE, 100),
(4, 'D31172', TRUE, 0),
(4, 'D75438', TRUE, 1000);

/*Order*/
INSERT INTO `Order` (`OrderSerial`, `DealerID`, `OrderDate`, `OrderNumberfromDealer`, `State`, `remark`)
VALUES 
('202404110343000001', '000001', '2024-05-23 13:22:00', NULL, 'C', NULL),
('202404110343000001', '000001', '2024-05-23 13:22:00', NULL, 'C', NULL),
('202404110343000005', '000005', '2024-05-23 13:22:00', NULL, 'P', NULL),
('202404110343000004', '000004', '2024-05-23 13:22:00', NULL, 'P', NULL),
('202404120343000009', '000009', '2024-05-23 13:22:00', NULL, 'W', NULL),
('202404120343000007', '000007', '2024-05-23 13:22:00', NULL, 'W', NULL),
('202404120345000010', '000010', '2024-05-23 13:22:00', NULL, 'U', NULL),
('202404120345000002', '000002', '2024-05-23 13:22:00', NULL, 'T', NULL),
('202404140345000003', '000003', '2024-05-23 13:22:00', NULL, 'W', NULL),
('202404140345000004', '000004', '2024-05-23 13:22:00', NULL, 'F', NULL);

/*OrderItem*/
INSERT INTO `OrderItem` (`OrderSerial`, `ItemID`, `Quantity`, `PriceInOrder`)
VALUES 
('202404110343000001', 'A26130', 10, 640.00),
('202404110343000001', 'B22978', 100, 682900.00),
('202404110343000005', 'C10435', 100, 11300.00),
('202404110343000004', 'D75438', 1000, 159000.00),
('202404120343000009', 'C91177', 100, 128700.00),
('202404120343000007', 'D52143', 100, 164000.00),
('202404120345000010', 'A48880', 10, 620.00),
('202404120345000002', 'D31172', 10, 2390.00),
('202404140345000003', 'D62438', 10, 4350.00),
('202404140345000004', 'B25912', 10, 23310.00);

/*OrderItemToFollow*/
INSERT INTO `OrderItemToFollow` (`OrderSerial`, `ItemID`, `Quantity`, `State`)
VALUES 
('202404110343000001', 'A26130', 10, 'W'),
('202404110343000001', 'B22978', 100, 'W'),
('202404110343000005', 'C10435', 100, 'W'),
('202404110343000004', 'D75438', 1000, 'W'),
('202404120343000009', 'C91177', 100, 'W'),
('202404120343000007', 'D52143', 100, 'D'),
('202404120345000010', 'A48880', 10, 'W'),
('202404120345000002', 'D31172', 10, 'W'),
('202404140345000003', 'D62438', 10, 'W'),
('202404140345000004', 'B25912', 10, 'W');

/*ActualQuantityDespatched*/
INSERT INTO `ActualQuantityDespatched` (`WarehouseID`, `InvoiceID`, `ItemID`, `Quantity`, `BundlesNumber`)
VALUES
(1, '202404110000011', 'A26130', 1, 0),
(2, '202404110000012', 'B22978', 2, 0),
(3, '202404110000053', 'C10435', 3, 0),
(4, '202404110000044', 'D75438', 4, 0),
(2, '202404110000095', 'C91177', 5, 0),
(1, '202404110000076', 'D52143', 6, 0),
(3, '202404110000107', 'A48880', 7, 0),
(4, '202404110000028', 'D31172', 8, 0),
(1, '202404110000039', 'D62438', 9, 0),
(2, '202404110000049', 'B25912', 10, 0);

/*ScrapItems*/
INSERT INTO `ScrapItems` (`ItemID`, `RecordTime`, `RecordStaffID`, `Quantity`, `Discrepancy`)
VALUES
('A26130', '2024-05-23 13:54:00', 1, 2, 'Tolerances for sheet metal can range from a few millimetres to tens of millimetres.'),
('B22978', '2024-05-23 13:54:00', 5, 4, 'Tolerances of components may be a few millimetres to tens of millimetres'),
('C10435', '2024-05-23 13:54:00', 14, 1, 'Tolerances for lighting fittings may be a few millimetres to a fraction of a millimetre'),
('D75438', '2024-05-23 13:54:00', 24, 5, 'Tolerances for fittings are usually in the range of a few millimetres to a few centimetres'),
('C91177', '2024-05-23 13:54:00', 30, 2, 'Tolerances for lighting fittings may be a few millimetres to a fraction of a millimetre'),
('D52143', '2024-05-23 13:54:00', 33, 1, 'Tolerances for fittings are usually in the range of a few millimetres to a few centimetres'),
('A48880', '2024-05-23 13:54:00', 35, 4, 'Tolerances for sheet metal can range from a few millimetres to tens of millimetres.'),
('D31172', '2024-05-23 13:54:00', 40, 5, 'Tolerances for fittings are usually in the range of a few millimetres to a few centimetres'),
('D62438', '2024-05-23 13:54:00', 43, 6, 'Tolerances for fittings are usually in the range of a few millimetres to a few centimetres'),
('B25912', '2024-05-23 13:54:00', 51, 1, 'Tolerances of components may be a few millimetres to tens of millimetres');

/*RestockOrder*/
INSERT INTO `RestockOrder` (`RestockOrderID`, `WarehouseID`, `OrderDate`, `State`, `Remark`)
VALUES
(1, 1, '2024-05-23', 'C', NULL),
(2, 2, '2024-05-23', 'W', NULL),
(3, 3, '2024-05-23', 'C', NULL),
(4, 4, '2024-05-23', 'C', NULL),
(1, 1, '2024-05-23', 'C', NULL),
(2, 2, '2024-05-23', 'C', NULL),
(2, 2, '2024-05-23', 'C', NULL),
(3, 3, '2024-05-23', 'W', NULL),
(4, 4, '2024-05-23', 'W', NULL),
(1, 1, '2024-05-23', 'W', NULL);

/*RestockItem*/
INSERT INTO `RestockItem` (`RestockOrderID`, `ItemID`, `Quantity`)
VALUES
(1, 'A26130', 90),
(2, 'B22978', 18),
(3, 'C10435', 77),
(4, 'D75438', 7),
(1, 'C91177', 54),
(2, 'D52143', 71),
(3, 'A48880', 60),
(4, 'D31172', 72),
(1, 'D62438', 6),
(2, 'B25912', 50);

/*Invoice*/
INSERT INTO `Invoice` (`InvoiceID`, `OrderSerial`, `DespatchForemanID`, `InvoiceDate`, `CompleteState`)
VALUES
('202404110000011', '202404110343000001', 1, '2024-05-23 13:40', 'W'),
('202404110000012', '202404110343000001', 7, '2024-05-23 13:40', 'W'),
('202404110000053', '202404110343000005', 14, '2024-05-23 13:40', 'W'),
('202404110000044', '202404110343000004', 21, '2024-05-23 13:40', 'W'),
('202404110000095', '202404120343000009', 22, '2024-05-23 13:40', 'W'),
('202404110000076', '202404120343000007', 25, '2024-05-23 13:40', 'W'),
('202404110000107', '202404120345000010', 31, '2024-05-23 13:40', 'W'),
('202404110000028', '202404120345000002', 39, '2024-05-23 13:40', 'W'),
('202404110000039', '202404140345000003', 43, '2024-05-23 13:40', 'W'),
('202404110000049', '202404140345000004', 44, '2024-05-23 13:40', 'W');
/*Truck*/
INSERT INTO `Truck` (`TruckID`, `SaleAreaID`, `LicensePlate`)
VALUES
(1, 2, NULL),
(2, 7, NULL),
(3, 6, NULL),
(4, 12, NULL),
(5, 11, NULL),
(6, 25, NULL),
(7, 10, NULL),
(8, 8, NULL),
(9, 22, NULL),
(10, 12, NULL);

/*TruckInvoice*/
INSERT INTO `TruckInvoice` (`TruckID`, `InvoiceID`)
VALUES
(8, '20240411000001'),
(9, '20240411000001'),
(10, '20240411000005'),
(11, '20240411000004'),
(12, '20240411000009'),
(13, '20240411000007'),
(14, '20240411000010'),
(15, '20240411000002'),
(16, '20240411000003'),
(17, '20240411000004');


/*WarehouseStockLevel*/
INSERT INTO `WarehouseStockLevel` (`WarehouseID`, `SpareID`, `ROL`, `CSL`)
VALUES 
(1, 'A26130', 80, 96),
(2, 'B22978', 100, 120),
(3, 'C10435', 100, 120),
(4, 'D75438', 100, 120),
(1, 'C91177', 100, 120),
(1, 'D62438', 100, 120),
(2, 'B25912', 100, 120),
(2, 'D52143', 10, 100),
(3, 'A48880', 100, 120),
(4, 'D31172', 100, 120),
(4, 'D75438', 100, 120);















