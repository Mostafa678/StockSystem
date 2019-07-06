create database StockSystem
use StockSystem

Create table Category
(
 CategoryID int IDENTITY (1,1) primary key,
 CategoryName varchar(100)
 )
 --drop table category
INSERT INTO Category (CategoryName) VALUES ('Stationary')
INSERT INTO Category (CategoryName) VALUES ('Cosmetics')

select * from Category


update category set CategoryName= 'asd' where CategoryId = 2


select * from Category where CategoryName= 'test'


Create table Company
(
 CompanyID int IDENTITY (1,1) primary key,
 CompanyName varchar(100)
 )
 --drop table  Company
 select * from Company

INSERT INTO Company (CompanyName) VALUES ('RFL')
INSERT INTO Company (CompanyName) VALUES ('PRAN')

select CategoryID from Category where CategoryName = 'Keyboard'
 
 CREATE TABLE Item(
ItemID int IDENTITY (1,1) PRIMARY KEY,
ItemName VARCHAR(100),
ItemReorder int,
CatID int FOREIGN KEY REFERENCES Category(CategoryID),
ComID  int FOREIGN KEY REFERENCES Company (CompanyID)
)
select * from Item
-- drop table Item
INSERT INTO Item (ItemName,ItemReorder,CatID,ComID) VALUES ('RFL',12,1,2)

use StockSystem
select * from Category
select * from Company
select * from item



SELECT i.ItemID,i.ItemName,i.ItemReorder,i.CatID, c.CategoryID,c.CategoryName AS Category  FROM Item AS i
LEFT JOIN Category AS c ON i.CatID = c.CategoryID



CREATE TABLE StockIn(
StockInID int IDENTITY (1,1) PRIMARY KEY,
CatID int FOREIGN KEY REFERENCES Category(CategoryID),
ComID  int FOREIGN KEY REFERENCES Company (CompanyID),
ItemID  int FOREIGN KEY REFERENCES Item (ItemID),
StockInQuantity int,
Date VARCHAR(100)
)

-- drop table StockIN

select * from StockIn
select * from item

select * from Item,Company where CompanyID=4


select * from Category
select * from Company
select * from Item

select i.CatID,i.ComID,CategoryName from Item as i,Category  where ComID = 4 and CategoryID=i.CatID

select CategoryName,CompanyName from Item as i,Category,Company  where i.ComID = 4 and CategoryID=i.CatID and CompanyID=i.ComID

select CategoryName from Item as i,Category  where  CategoryID=i.CatID and i.ComID = 4






