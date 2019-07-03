create database StockSystem
use StockSystem

Create table Category
(
 CategoryId int IDENTITY (1,1) primary key,
 CategoryName varchar(100)
 )

INSERT INTO Category (CategoryName) VALUES ('Stationary')
INSERT INTO Category (CategoryName) VALUES ('Cosmetics')

select * from Category