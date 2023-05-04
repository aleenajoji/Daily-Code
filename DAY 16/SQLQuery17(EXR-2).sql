Create table CLIENT_MASTER (CLIENTNO varchar(6) Check(CLIENTNO LIKE 'c%') primary key, NAME varchar(20) NOT NULL,



ADDRESS1 varchar(30),ADDRESS2 varchar(30), CITY varchar(15), PINCODE numeric (8), STATE varchar(15),BALDUE numeric (10,2));

Create table PRODUCT_MASTER( PRODUCTNO varchar(6) Check (PRODUCTNO LIKE 'p%') primary key,DESCRIPTION varchar(15) NOT NULL,

PROFITPERC numeric(4,2) NOT NULL, UNITMEASURE varchar(10) NOT NULL, QTYONHAND numeric(8) NOT NULL,REORDERLVL numeric(8) NOT NULL,

SELLPRICE numeric (8,2) NOT NULL ,CONSTRAINT CHK1 CHECK(SELLPRICE<>0),

COSTPRICE numeric(8,2) NOT NULL,CONSTRAINT CHK2 CHECK(COSTPRICE<>0));

create table SALESMAN_MASTER(SALESMANNO varchar(6) Check(SALESMANNO LIKE 'S%') primary key,SALESMANNAME varchar(20) NOT NULL,

ADDRESS1 varchar(30)NOT NULL,ADDRESS2 varchar(30),CITY varchar(20),PINCODE numeric(8), STATE varchar(20),

SALAMT numeric(8,2) NOT NULL,CONSTRAINT CHK3 CHECK(SALAMT<>0),TGTTOGET numeric (6,2) NOT NULL,

YTDSALES NUMERIC NOT NULL,REMARKS varchar(60));

Create table SALES_ORDER(ORDERNO varchar(6) check(ORDERNO LIKE 'O%') primary key,

CLIENTNO VARCHAR(6) ,FOREIGN KEY (CLIENTNO) REFERENCES CLIENT_MASTER (CLIENTNO) ,ORDERDATE date,

DELYADDR varchar(25),SALESMANNO varchar(6),FOREIGN KEY(SALESMANNO) REFERENCES SALESMAN_MASTER(SALESMANNO)

,DELYTYPE CHAR(1),CONSTRAINT CHK4 Check(DELYTYPE ='P'OR DELYTYPE='F'),

BILLEDYN CHAR(1),CONSTRAINT CHK5 Check(BILLEDYN ='Y'OR BILLEDYN='N')

,DELYDATE DATE,

ORDERSTATUS VARCHAR(10),

CONSTRAINT CHK6 CHECK(ORDERSTATUS ='BACKORDER'OR ORDERSTATUS='CANCELLED'OR ORDERSTATUS='IN PROCESS'OR ORDERSTATUS='FULFILLED'));

CREATE TABLE SALES_ORDER_DETAILS(ORDERNO VARCHAR(6),FOREIGN KEY (ORDERNO) REFERENCES SALES_ORDER(ORDERNO),

PRODUCTNO VARCHAR(6),FOREIGN KEY (PRODUCTNO) REFERENCES PRODUCT_MASTER(PRODUCTNO),

QTYORDERED NUMERIC(8),QTYDISP NUMERIC(8),PRODUCTRATE NUMERIC(10,2),PRIMARY KEY(ORDERNO,PRODUCTNO));

--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)

--VALUES ('C00001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 15000);

--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)

--values('c00002','mary','lucknow',400055,'UP',12000);

--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)

--values('c00005','surya','Srilanka',400055,'UP',12000);

--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)

--values('c00006','sree','california',400055,'UP',12000);

--SELECT * FROM CLIENT_MASTER;

--INSERT INTO Product_Master VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250);

--INSERT INTO Product_Master VALUES ('P00008', 'T-Shirts', 5, '1.44drive', 200, 50, 350, 250);

--INSERT INTO Product_Master VALUES ('P00002', 'T-Shirts', 6, 'Piece', 200, 50, 3500, 250);

--SELECT * FROM product_MASTER;

--INSERT INTO Salesman_Master VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good');

--select * from salesman_master;

--INSERT INTO Sales_Order(OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)

--VALUES('O19001', '12-june-02', 'C00001', 'F', 'N', 'S00001', '20-july-02', 'IN PROCESS');

--INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525);

--1

--select name from client_master;

--2

--select * from client_master where city='mumbai';

--3

--select * from product_master where sellprice between 2000 and 5000;

--4

--select name,city,state from client_master where state<> 'Maharashtra';

--5

--select * from client_master where clientno='C00001' or clientno= 'c00002' ;

--6

--update product_master set sellprice=1500.50 where unitmeasure='1.44drive';

--7

--delete from client_master where clientno='c00005';

--8

--select * from Client_master where city like'_a%';

--9

--select count(description) from product_master where (sellprice >=1500);

--10

--select qtyordered,qtydisp from sales_order_details;

--1

--ALTER TABLE CLIENT_MASTER ADD PRIMARY KEY(CLIENT_NO);

--2

--ALTER TABLE CLIENT_MASTER

--ADD PHONE_NO NUMERIC(10);

--3

--ALTER TABLE PRODUCT_MASTER ALTER COLUMN DESCRIPTION VARCHAR(15) NOT NULL;

--ALTER TABLE PRODUCT_MASTER ALTER COLUMN PROFITPERC NUMERIC(4,2) NOT NULL;

--ALTER TABLE PRODUCT_MASTER ALTER COLUMN SELLPRICE NUMERIC(8,2) NOT NULL;

--ALTER TABLE PRODUCT_MASTER ALTER COLUMN COSTPRICE NUMERIC(8,2) NOT NULL;

--4

--ALTER TABLE [CLIENT_MASTER]

--ALTER COLUMN [NAME] VARCHAR(60)

--5

--ALTER TABLE CLIENT_MASTER

--DROP COLUMN PINCODE;

--SELECT * FROM CLIENT_MASTER;

--select * from sales_order;

SELECT pm.PRODUCTNO, pm.DESCRIPTION

FROM CLIENT_MASTER cm

JOIN SALES_ORDER so ON so.CLIENTNO = cm.CLIENTNO

JOIN SALES_ORDER_DETAILS sod ON sod.ORDERNO = so.ORDERNO

JOIN PRODUCT_MASTER pm ON pm.PRODUCTNO = sod.PRODUCTNO

WHERE cm.NAME = 'Ivan Bayross';

SELECT sod.PRODUCTNO, pm.DESCRIPTION, sod.QTYDISP

FROM SALES_ORDER so

JOIN SALES_ORDER_DETAILS sod ON sod.ORDERNO = so.ORDERNO

JOIN PRODUCT_MASTER pm ON pm.PRODUCTNO = sod.PRODUCTNO

WHERE MONTH(so.DELYDATE) = MONTH(GETDATE()) AND YEAR(so.DELYDATE) = YEAR(GETDATE());

SELECT sod.PRODUCTNO, pm.DESCRIPTION

FROM SALES_ORDER_DETAILS sod

JOIN PRODUCT_MASTER pm ON pm.PRODUCTNO = sod.PRODUCTNO

GROUP BY sod.PRODUCTNO, pm.DESCRIPTION

HAVING SUM(sod.QTYDISP) >= 100;

SELECT cm.NAME

FROM CLIENT_MASTER cm

JOIN SALES_ORDER so ON so.CLIENTNO = cm.CLIENTNO

JOIN SALES_ORDER_DETAILS sod ON sod.ORDERNO = so.ORDERNO

JOIN PRODUCT_MASTER pm ON pm.PRODUCTNO = sod.PRODUCTNO

WHERE pm.DESCRIPTION = 'Trousers';

SELECT sod.PRODUCTNO, pm.DESCRIPTION, so.ORDERNO, so.ORDERDATE

FROM CLIENT_MASTER cm

JOIN SALES_ORDER so ON so.CLIENTNO = cm.CLIENTNO

JOIN SALES_ORDER_DETAILS sod ON sod.ORDERNO = so.ORDERNO

JOIN PRODUCT_MASTER pm ON pm.PRODUCTNO = sod.PRODUCTNO

WHERE pm.DESCRIPTION = 'Pull Overs' AND sod.QTYORDERED < 5;

SELECT PM.*

FROM PRODUCT_MASTER PM

LEFT JOIN SALES_ORDER_DETAILS SOD ON PM.PRODUCTNO = SOD.PRODUCTNO

WHERE SOD.PRODUCTNO IS NULL;

SELECT CM.NAME, CM.ADDRESS1, CM.ADDRESS2, CM.CITY, CM.STATE

FROM CLIENT_MASTER CM

JOIN SALES_ORDER SO ON CM.CLIENTNO = SO.CLIENTNO

WHERE SO.ORDERNO = '019001';

SELECT DISTINCT CM.*

FROM CLIENT_MASTER CM

JOIN SALES_ORDER SO ON CM.CLIENTNO = SO.CLIENTNO

WHERE SO.ORDERDATE < '2002-05-01';

--1. Display system date as Saturday, February 11, 2012

--2. Display Balance Due from Client master as $99,999.99

--3. Display message as 'Salesman Aman sold goods of 50 while given target was 100.

--4. Display your Age in Years

SELECT DATENAME(weekday,'2012-02-11')+','+

DATENAME(MONTH,'2012-02-11')+''+

CAST(DATEPART(day,'2012-02-11') AS VARCHAR(2))+','+

CAST (DATEPART(year,'2012-02-11') as varchar(4))AS SYSTEM_DATE;

SELECT BALDUE from CLIENT_MASTER WHERE BALDUE =$99999.99;

SELECT 'Salesman Aman sold goods of 50 while given target was 100' AS message;

SELECT DATEDIFF(year,'1999-10-02',GETDATE()) AS age_in_years;









