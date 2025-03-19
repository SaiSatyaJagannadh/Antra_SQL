-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(*) AS TotalProducts
FROM Production.Product;

-- 2. Retrieve the number of products included in a subcategory (excluding NULL in ProductSubcategoryID).
SELECT COUNT(*) AS ProductsInSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL;

-- 3. How many products reside in each subcategory?
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID
ORDER BY ProductSubcategoryID;

-- 4. How many products do not have a product subcategory?
SELECT COUNT(*) AS ProductsWithoutSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

-- 5. Sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS TotalQuantity
FROM Production.ProductInventory;

-- 6. Sum of products in the Production.ProductInventory table with LocationID = 40 and quantities less than 100.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

-- 7. Sum of products with shelf information, LocationID = 40, and quantities less than 100.
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100;

-- 8. Average quantity for products where LocationID = 10.
SELECT AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
WHERE LocationID = 10;

-- 9. Average quantity of products by shelf.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf;

-- 10. Average quantity of products by shelf, excluding rows with Shelf = 'N/A'.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf;

-- 11. Count of members and average list price grouped by Color and Class, excluding NULL values.
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class;

-- 12. List country and province names from Person.CountryRegion and Person.StateProvince.
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr
JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode;

-- 13. List country and province names, filtered by Germany and Canada.
SELECT cr.Name AS Country, sp.Name AS Province
FROM Person.CountryRegion cr
JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name IN ('Germany', 'Canada');