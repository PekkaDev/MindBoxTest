-- CREATE DATABASE TestDb

-- GO

-- USE TestDb

-- CREATE TABLE Products
-- (
--     Id INT PRIMARY KEY,
--     Name NVARCHAR(100)
-- )

-- CREATE TABLE Categories
-- (
--     Id INT PRIMARY KEY,
--     Name NVARCHAR(100)
-- )

-- CREATE TABLE Products_Categories
-- (
--     ProductId INT REFERENCES Products(Id),
--     CategoryId INT REFERENCES Categories(Id)
--     PRIMARY KEY(ProductId, CategoryId)
-- )

-- GO

SELECT 
    p.Name as ProductName,
    c.Name as CategoryName
FROM Products p 
LEFT JOIN Products_Categories pc
    ON p.Id = pc.ProductId
LEFT JOIN Categories c
    ON pc.CategoryId = c.Id
