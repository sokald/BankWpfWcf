-- create databese
--CREATE DATABASE Bank2

--create table for account
CREATE TABLE dbo.Account
(
	NrAccount decimal(26) IDENTITY (10000000000000000000000000,1) NOT NULL,
	FirstName varchar(40) NOT NULL,
	LastName varchar(40) NOT NULL,
	City varchar(80) NOT NULL,
	Street varchar(80) NOT NULL,
	NrHouse varchar(50) NOT NULL,
	PostCode varchar(5) NOT NULL,
	AccountBalance money NOT NULL
);
GO

-- insert data in to table Account
--insert into Account(FirstName,LastName,City,Street,NrHouse,PostCode,AccountBalance) values(1,1,1,1,1,1,1)

-- Primary Key
--PK
ALTER TABLE dbo.Account
ADD CONSTRAINT PK_Account
PRIMARY KEY (NrAccount);
GO

-- show table with account
SELECT *
FROM dbo.Account

---------------------------
-- create table to list of transaction
CREATE TABLE dbo.TableTransaction
(
	IdTransaction int IDENTITY NOT NULL,
	NrAccount decimal(26) NOT NULL,
	Amount money NOT NULL,
	DateTransaction date NOT NULL
);
GO

-- insert data in to table Account
insert into TableTransaction(NrAccount,Amount,DateTransaction) values(10000000000000000000000000,1,'10.10.2001')


SELECT * FROM dbo.Account WHERE dbo.Account.NrAccount = 10000000000000000000000003

--Primary Key in table TableTransaction
--PK
ALTER TABLE dbo.TableTransaction
ADD CONSTRAINT PK_Transaction
PRIMARY KEY (IdTransaction);
GO

-- foreign key in table TableTransaction
ALTER TABLE dbo.TableTransaction
ADD CONSTRAINT FK_Transaction_Account
FOREIGN KEY (NrAccount)
REFERENCES dbo.Account(NrAccount);
GO

-- show table TableTransaction
SELECT *
FROM dbo.TableTransaction

--pokazanie histoirii transakcji
Select * from dbo.TableTransaction where NrAccount=100000000;
