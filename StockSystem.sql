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
INSERT INTO Company (CompanyName) VALUES ('pran')
 