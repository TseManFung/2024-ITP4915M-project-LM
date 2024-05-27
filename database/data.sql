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
  (1, 18, '昆明市滇池路1310號雲南民族村東門'),
  (2, 19, 'China, CN 辽宁省 大连市 甘井子区'),
  (3, 20, '55WW+CX3, Changsha County, Changsha, Hunan, China, 410141'),
  (4, 21, 'P4JJ+P9J, Kaiyuan Rd, Licheng District, Jinan, Jinan, Shandong, China, 250101');

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
('000001', 'FY Ltd.', 1, '13912345678', 'fy@qq.com', '北京市朝陽區建國路100號1樓', '北京市朝陽區建國路100號1樓'),
('000002', 'Happy Ltd.', 1, '15898765432', 'happy@abc.com', '北京市海淀區西三旗街道1號', '北京市海淀區西三旗街道1號'),
('000003', 'IT Ltd.', 1, '13678901234', 'it@qq.com', '北京市昌平區回龍觀東大街2號', '北京市昌平區回龍觀東大街2號'),
('000004', 'SDP Ltd.', 1, '15056789012', 'sdp@qq.com', '北京市西城區西單北大街3號', '北京市西城區西單北大街3號'),
('000005', 'OOT Ltd.', 2, '13123456789', 'oot@qq.com', '上海市浦東新區東方明珠廣場', '香港中環皇后大道中1號'),
('000006', 'IMAD Ltd.', 4, '13123456759', 'imad@qq.com', '深圳市福田區華強北路5號', '廣州市天河區珠江新城華強路6號'),
('000007', 'ITE Ltd.', 6, '23020831', 'ite@qq.com', '香港中環皇后大道中1號', '廣州市天河區珠江新城華強路6號'),
('000008', 'DP Ltd.', 8, '90747203', 'dp@qq.com', '台北市信義區忠孝東路5段7號', '南京市鼓樓區中山北路8號'),
('000009', 'SSD Ltd.', 15, '69400737', 'ssd@qq.com', '廈門市思明區鼓浪屿路9號', '香港中環皇后大道中1號'),
('000010', 'OS Ltd.', 30, '31376030', 'os@qq.com', '貴陽市南明區廣場北路10號', '南京市鼓樓區中山北路8號');

/*Staff*/
INSERT INTO `Staff` (`StaffID`, `StaffName`, `SaleAreaID`, `DeptID`, `Position`, `PhoneNunber`, `Gender`)
VALUES 
(1,	'Andy', 1, 'wh001',	'storemen',	'13912345678', 'M'),
(2,	'李小明',2, 'wh002', 'storemen', '15898765432', 'M'),
(3,	'张三',3, 'wh003',	'storemen',	'13678901234',	'M'),
(4,	'苹',4, 'wh004', 'storemen', '15056789012',	'M'),
(5,	'ChanTomori', NULL, 'manag', 'manager', '13123456789', 'F'),
(6,	'WongTaki', 1, 'wh001', 'manager', '15816444441', 'F'),
(7,	'CheungSoyo',  NULL, 'Hdt', 'LM officer', '19076550', 'F'),
(8,	'陳大文', NULL, 'HdT', 'Accountant', '58436029', 'F'),
(9,	'ORana',  1, 'wh001', 'Warehouseclerk', '49164576', 'F'),
(10, 'AAA',  NULL, 'Hdt',	'Warehouseclerk', '50552739', 'F'),
(11, 'CCC',  1, 'wh001',	'manager',	'98931962',	'F'),
(12, 'DDD',  2, 'wh002', 'manager',	'23490946',	'F'),
(13, 'Sam',  3, 'wh003', 'manager',	'89774445',	'M'),
(14, 'Apple',  4, 'wh004', 'manager', '14564581', 'M'),
(15, 'ORana',  3, 'wh003', 'Warehouseclerk',	'16043681',	'F'),
(16, '孫培玲',  4, 'wh004',	'Warehouseclerk', '67468369',	'F'),
(17, '望醉冬',  2, 'wh002',	'delivery worker', '25624059','F'),
(18, '皇甫樂成',  3,'wh003', 'delivery worker', '82838532', 'F'),
(19, '山靜白', 4, 'wh004', 'delivery worker', '23023829', 'F'),
(20, '山小明',  1, 'wh001', 'Stock record clerk', '48193089', 'M'),
(100, 'storeman', 1, 'wh001', 'storeman', '98765432', 'M'),
(101, 'LMcleck', NULL, 'Hdt', 'LMcleck', '98765431', 'M'),
(102, 'accountant', NULL, 'Hdt', 'accountant', '98765430', 'M'),
(103, 'manager', 1, 'wh001', 'manager', '98765429', 'M'),
(104, 'delivery_worker', 1, 'wh001', 'delivery_worker', '98765428', 'M'),
(105, 'Warehousecleak', 1, 'wh001', 'Warehousecleak', '98765427', 'M'),
(106, 'stockrecord', 1, 'wh001', 'stockrecord', '98765426', 'M');

/*User*/
INSERT INTO `User` (`UserID`, `LoginName`, `Password`, `AccessLevel`, `DealerID`, `StaffID`)
VALUES 
(451561235, 'ATL', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 1),
(894874213, 'kirito', '!a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 2),
(123456789, 'cusidina', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 3),
(987654321, 'kemono114', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 4),
(159753456, 'idkABC', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 5),
(426879513, 'asuna', '!a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 6),
(741852963, 'HAha123', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 7),
(369258147, 'happyCat', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 8),
(789456123, 'wagananai', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 9),
(987412365, 'ho', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 10000, NULL, 10),
(754664656, 'zwYtJrViRPGcruemxwMd', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,11),
(784018973, 'cKCVYAvrPuwhRufZqnnH', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,12),
(813373290, 'ukdeZCKyEGPzanTMuiXC', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,13),
(842727607, 'DmozffipkaEvXUtxZfVV', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,14),
(872081924, 'zRmTpvAqEZhWaAZvWuQq', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,15),
(901436241, 'PHkVKmwcfiTfmGhBaVgg', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,16),
(930790558, 'iKXQbJKpydqVkDDFohbC', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,17),
(960144875, 'ianWsRYLjsJhgTPdiwgy', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,18),
(989499192, 'HJfXjJbUrEwcnMvnXjos', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,19),
(987414555, 'mHMVNDcyDQVtkXDqRDma', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',10000,NULL,20),
(1, 'storeman', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '400', NULL, 100),
(2, 'LMcleck', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '200', NULL, 101),
(3, 'accountant', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '300', NULL, 102),
(4, 'manager', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '100', NULL, 103),
(5, 'delivery_worker', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '700', NULL, 104),
(6, 'Warehousecleak', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '600', NULL, 105),
(7, 'stockrecord', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '500', NULL, 106),
(8, 'Dealer1', '0a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', '5000', '000001', NULL);

/*Spare*/
INSERT INTO `Spare` (`SpareID`, `CategoryLetter`, `SpareName`, `Price`, `Description`, `Weight`, `SupplierID`)
VALUES 
('A26130', 'A', 'WTF Aluminium alloy sheet', 68, NULL, 53, 104),
('B22978', 'B', 'Hole engine', 2248, NULL, 12.7, 106),
('C10435', 'C', 'Shiift Tail Light Assembly', 15.5, NULL, 58.2, 102),
('D75438', 'D', 'Tis Vehicle Car Recorder', 42.9, NULL, 63.5, 103),
('C91177', 'C', 'Porject Headlight Assembly', 65.2, NULL, 67.5, 109),
('D52143', 'D', 'IS In-vehicle mobile phone holder', 202, NULL, 32.5, 103),
('A48880', 'A', 'fire Stainless Steel Sheet', 17, NULL, 49.5, 102),
('D31172', 'D', 'DDD Vehicle Air Cleaner', 15.7, NULL, 34.7, 106),
('D62438', 'D', 'GGG Car USB Charger', 47.3, NULL, 44.8, 102),
('B25912', 'B', 'www cooling system', 47.87, NULL, 69.2, 106);

/*Stock*/
INSERT INTO `Stock` (`WarehouseID`, `SpareID`, `AutoRestork`, `quantity`)
VALUES 
(1,	'A26130',	TRUE,	1000),
(1,	'B22978',	TRUE,	1000),
(1,	'C10435',	FALSE,	1000),
(2,	'D75438',	FALSE,	1000),
(2,	'C91177',	TRUE,	1000),
(2,	'D52143',	TRUE,	1000),
(3,	'A48880',	TRUE,	1000),
(3,	'D31172',	TRUE,	90),
(4,	'D62438',	TRUE,	90),
(4,	'B25912',	TRUE,	90);

/*Order*/
INSERT INTO `Order` (`OrderSerial`, `DealerID`, `OrderDate`, `OrderNumberfromDealer`, `State`, `remark`)
VALUES
  ('202405240900000001', '000001', '2024-05-24 09:00:00', null, 'F', null),
  ('202405240901000002', '000002', '2024-05-24 09:01:00', null, 'F', null),
  ('202405240902000003', '000003', '2024-05-24 09:02:00', null, 'P', null),
  ('202405240903000004', '000004', '2024-05-24 09:03:00', null, 'P', null),
  ('202405240904000005', '000005', '2024-05-24 09:04:00', null, 'P', null),
  ('202405240905000006', '000006', '2024-05-24 09:05:00', null, 'P', null),
  ('202405240906000007', '000007', '2024-05-24 09:06:00', null, 'P', null),
  ('202405240907000008', '000008', '2024-05-24 09:07:00', null, 'W', null),
  ('202405240908000009', '000009', '2024-05-24 09:08:00', null, 'W', null),
  ('202405240909000010', '000010', '2024-05-24 09:09:00', null, 'W', null);

/*OrderItem*/
INSERT INTO `OrderItem` (`OrderSerial`, `ItemID`, `Quantity`, `PriceInOrder`)
VALUES
  ('202405240900000001', 'A26130', 10, 38.7),
  ('202405240901000002', 'B22978', 10, 58.54),
  ('202405240902000003', 'C10435', 10, 36.26),
  ('202405240902000003', 'D75438', 20, 70.64),
  ('202405240903000004', 'D75438', 10, 51.07),
  ('202405240904000005', 'C91177', 10, 27.13),
  ('202405240905000006', 'D52143', 10, 30.42),
  ('202405240906000007', 'A48880', 10, 54.21),
  ('202405240907000008', 'D31172', 100, 13.23),
  ('202405240908000009', 'D62438', 100, 57.28),
  ('202405240909000010', 'B25912', 100, 24.46);

/*OrderItemToFollow*/
INSERT INTO `OrderItemToFollow` (`OrderSerial`, `ItemID`, `Quantity`, `State`)
VALUES
  ('202405240907000008', 'D31172', 10, 'W'),
  ('202405240908000009', 'D62438', 10, 'W'),
  ('202405240909000010', 'B25912', 10, 'W');

/*Invoice*/
INSERT INTO `Invoice` (`InvoiceID`, `OrderSerial`, `DespatchForemanID`, `InvoiceDate`, `CompleteState`)
VALUES
  ('202405240000011', '202405240900000001', 6, '2024-05-24', 'C'),
  ('202405240000021', '202405240901000002', 6, '2024-05-24', 'C');
/*ActualQuantityDespatched*/

INSERT INTO `ActualQuantityDespatched` (`WarehouseID`, `InvoiceID`, `ItemID`, `Quantity`, `BundlesNumber`)
VALUES
  (1, '202405240000011', 'A26130', 10, 1),
  (1, '202405240000021', 'B22978', 10, 2);

/*ScrapItems*/
INSERT INTO `ScrapItems` (`ItemID`, `RecordTime`, `RecordStaffID`, `Quantity`, `Discrepancy`)
VALUES
  ('A26130', '2024-05-24 21:05', 20, 1, 'Tolerances for sheet metal can range from a few millimetres to tens of millimetres.'),
  ('B22978', '2024-05-24 21:05', 20, 2, 'Tolerances of components may be a few millimetres to tens of millimetres'),
  ('C10435', '2024-05-24 21:05', 20, 3, 'Tolerances for lighting fittings may be a few millimetres to a fraction of a millimetre');

/*RestockOrder*/
INSERT INTO `RestockOrder` (`RestockOrderID`, `WarehouseID`, `OrderDate`, `State`, `Remark`)
VALUES
  (123123, 3, '2024-05-24', null),
  (123789, 4, '2024-05-24', null),
  (123456, 4, '2024-05-24', null);

/*RestockItem*/
INSERT INTO `RestockItem` (`RestockOrderID`, `ItemID`, `Quantity`, `State`)
VALUES
  (123123, 'D31172', 1000, 'C'),
  (123789, 'D62438', 1000, 'C'),
  (123456, 'B25912', 1000, 'C');

/*Truck*/
INSERT INTO `Truck` (`TruckID`, `LicensePlate`, `SaleAreaID`)
VALUES
  (1, NULL, NULL),
  (2, NULL, NULL),
  (3, NULL, NULL),
  (4, NULL, NULL),
  (5, NULL, NULL),
  (6, NULL, NULL),
  (7, NULL, NULL),
  (8, NULL, NULL),
  (9, NULL, NULL),
  (10, NULL, NULL);

/*TruckInvoice*/
INSERT INTO `TruckInvoice` (`TruckID`, `InvoiceID`)
VALUES
  (1, '202405240000011'),
  (1, '202405240000021');


/*WarehouseStockLevel*/
INSERT INTO `WarehouseStockLevel` (`WarehouseID`, `SpareID`, `ROL`, `CSL`)
VALUES
  (1, 'A26130', 100, 120),
  (1, 'B22978', 100, 120),
  (1, 'C10435', 100, 120),
  (2, 'D75438', 100, 120),
  (2, 'C91177', 100, 120),
  (2, 'D52143', 100, 120),
  (3, 'A48880', 100, 120),
  (3, 'D31172', 100, 120),
  (4, 'D62438', 100, 120),
  (4, 'B25912', 100, 120);





























