 CREATE TABLE Customer (
    PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    
    City varchar(255)
);
insert into Customer values(1,'gatha','sree','ktm'),(2,'hari','kr','tvm'),
(3,'nabi','h','ekm'),(4,'zalda','sah','delhi'),(5,'anu','s','goa'),(7,'blessy','saha','delhi');

select LastName from  Customer where city='delhi'order by FirstName desc;

