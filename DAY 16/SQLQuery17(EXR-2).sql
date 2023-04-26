CREATE TABLE CLIENT_MASTER (

  CLIENTNO VARCHAR(6) PRIMARY KEY CHECK (CLIENTNO LIKE 'C%'),

  NAME VARCHAR(20) NOT NULL,

  ADDRESS1 VARCHAR(30),

  ADDRESS2 VARCHAR(30),

  CITY VARCHAR(15),

  PINCODE NUMERIC(8),

  STATE VARCHAR(15),

  BALDUE NUMERIC(10, 2)

);

CREATE TABLE PRODUCT_MASTER (

  PRODUCTNO VARCHAR(6) PRIMARY KEY CHECK (PRODUCTNO LIKE 'P%'),

  DESCRIPTION VARCHAR(15) NOT NULL,

  PROFITPERC NUMERIC(4, 2) NOT NULL,

  UNITMEASURE VARCHAR(10) NOT NULL,

  QTYONHAND NUMERIC(8) NOT NULL,

  REORDERLVL NUMERIC(8) NOT NULL,

  SELLPRICE NUMERIC(8, 2) NOT NULL CHECK (SELLPRICE <> 0),

  COSTPRICE NUMERIC(8, 2) NOT NULL CHECK (COSTPRICE <> 0)

);

CREATE TABLE SALESMAN_MASTER (

  SALESMANNO VARCHAR(6) PRIMARY KEY CHECK (SALESMANNO LIKE 'S%'),

  SALESMANNAME VARCHAR(20) NOT NULL,

  ADDRESS1 VARCHAR(30) NOT NULL,

  ADDRESS2 VARCHAR(30),

  CITY VARCHAR(20),

  PINCODE NUMERIC(8),

  STATE VARCHAR(20),

  SALAMT NUMERIC(8, 2) NOT NULL CHECK (SALAMT <> 0),

  TGTTOGET NUMERIC(6, 2) NOT NULL,

  YTDSALES NUMERIC(6, 2) NOT NULL,

  REMARKS VARCHAR(60)

);

CREATE TABLE SALES_ORDER (

  ORDERNO VARCHAR(6) PRIMARY KEY CHECK (ORDERNO LIKE 'O%'),

  CLIENTNO VARCHAR(6) REFERENCES CLIENT_MASTER(CLIENTNO),

  ORDERDATE DATE,

  DELYADDR VARCHAR(25),

  SALESMANNO VARCHAR(6) REFERENCES SALESMAN_MASTER(SALESMANNO),

  DELYTYPE CHAR(1) CHECK (DELYTYPE IN ('P', 'F')),

  BILLEDYN CHAR(1) CHECK (BILLEDYN IN ('Y', 'N')),

  DELYDATE DATE,

  ORDERSTATUS VARCHAR(10) CHECK (ORDERSTATUS IN ('In Process', 'Fulfilled', 'Backorder', 'Cancelled'))

);

CREATE TABLE SALES_ORDER_DETAILS (

  ORDERNO VARCHAR(6) REFERENCES SALES_ORDER(ORDERNO),

  PRODUCTNO VARCHAR(6) REFERENCES PRODUCT_MASTER(PRODUCTNO),

  QTYORDERED NUMERIC(8),

  QTYDISP NUMERIC(8),

  PRODUCTRATE NUMERIC(10, 2),

  PRIMARY KEY (ORDERNO, PRODUCTNO)

);


INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)

VALUES ('C00001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 15000);

INSERT INTO Product_Master (ProductNo, Description, ProfitPerc, UnitMeasure, QtyOnHand, ReorderLvl, SellPrice, CostPrice)

VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250);

INSERT INTO Salesman_Master (SalesmanNo, SalesmanName, Address1, City, PinCode, State, SalAmt, TgtToGet, YtdSales, Remarks)

VALUES ('S00001', 'Aman', 'A/14', 'Worli', 400002, 'Maharashtra', 3000, 100, 50, 'Good');



INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

VALUES ('O19001', '2002-06-12', 'C00001', 'F', 'N', 'S00001', '2002-07-20', 'In Process');

INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate)

VALUES ('O19001', 'P00001', 4, 4, 525);



SELECT Name FROM Client_Master;

SELECT * FROM Client_Master WHERE City = 'Mumbai';

SELECT * FROM Product_Master WHERE SellPrice > 2000 AND SellPrice < 5000;

SELECT Name, City, State FROM Client_Master WHERE State != 'Maharashtra';

SELECT * FROM Client_Master WHERE ClientNo IN ('C00001', 'C00002');

UPDATE Product_Master SET SellPrice = 1150.50 WHERE Name = '1.44 drive';

DELETE FROM Client_Master WHERE ClientNo = 'C00005';

SELECT * FROM Client_Master WHERE SUBSTRING(City, 2, 1) = 'a';

SELECT COUNT(*) FROM Product_Master WHERE SellPrice >= 1500;

SELECT QtyOrdered, QtyDisp, (QtyOrdered - QtyDisp) AS balancedqty FROM Sales_Order_Details;

ALTER TABLE client_master ADD PRIMARY KEY (client_no);

ALTER TABLE client_master ADD phone_no VARCHAR(20);

ALTER TABLE product_master

ALTER COLUMN description varchar(255) NOT NULL,

ALTER COLUMN profit_percent decimal(5,2) NOT NULL,

ALTER COLUMN sellprice decimal(10,2) NOT NULL,

ALTER COLUMN costprice decimal(10,2) NOT NULL;



ALTER TABLE client_master ALTER COLUMN name varchar(60);

ALTER TABLE table_name DROP COLUMN pincode;













