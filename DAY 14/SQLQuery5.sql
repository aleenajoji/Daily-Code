CREATE TABLE Perso (
    ID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Age int,
    City varchar(255) DEFAULT 'Sandnes',
    CONSTRAINT CHK_Person CHECK (Age>=18 AND City='Sandnes')
	
);
alter table Perso RENAME COLUMN City TO Address ;


DROP TABLE Perso;