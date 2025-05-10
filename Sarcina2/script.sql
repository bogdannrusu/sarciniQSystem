CREATE DATABASE Sarcina2;
USE Sarcina2;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100)
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

CREATE TABLE ProductCategoryLink (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Inserare produse
INSERT INTO Products (ProductID, ProductName) VALUES
(1, 'Laptop Dell'),
(2, 'Smartphone Samsung'),
(3, 'Monitor LG'),
(4, 'Mouse Logitech'),        -- Acest produs nu are categorie
(5, 'Tastatură mecanică');

-- Inserare categorii
INSERT INTO Categories (CategoryID, CategoryName) VALUES
(1, 'Electronice'),
(2, 'Computere'),
(3, 'Accesorii');

-- Legături între produse și categorii
INSERT INTO ProductCategoryLink (ProductID, CategoryID) VALUES
(1, 1),  -- Laptop Dell - Electronice
(1, 2),  -- Laptop Dell - Computere
(2, 1),  -- Smartphone - Electronice
(3, 1),  -- Monitor - Electronice
(3, 2),  -- Monitor - Computere
(4, 3),  -- Mouse Logitech - Accesorii
(5, 2),  -- Tastatură - Computere
(5, 3);  -- Tastatură - Accesorii


SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategoryLink pcl ON p.ProductID = pcl.ProductID
LEFT JOIN 
    Categories c ON pcl.CategoryID = c.CategoryID;
