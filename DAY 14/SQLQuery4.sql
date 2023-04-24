CREATE TABLE Persons (
    ID int NOT NULL PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
     Age int 
);
drop table Persons;

insert into Persons values(1,'gatha','sree',20),(2,'hari','kr',40),
(3,'nabi','h',90),(4,'zalda','sah',9),(5,'anu','s',18),(7,'blessy','saha',100);

SELECT * FROM Persons
WHERE LastName LIKE 'a%';

SELECT * FROM Persons
WHERE LastName LIKE '__a_';

UPDATE Persons
SET LastName='Juan' where ID=4;