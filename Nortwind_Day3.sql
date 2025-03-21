-- 1. List all cities that have both Employees and Customers.
SELECT DISTINCT e.City
FROM Employees e
JOIN Customers c ON e.City = c.City;

-- 2(a). List all cities that have Customers but no Employee (Using a Subquery).
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (SELECT DISTINCT City FROM Employees);

-- 2(b). List all cities that have Customers but no Employee (Without Using a Subquery).
SELECT DISTINCT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL;

-- 3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) AS TotalQuantityOrdered
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName;

-- 4. List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City;

-- 5. List all Customer Cities that have at least two customers.
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2;

-- 6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2;

-- 7. List all Customers who have ordered products but have the ‘ship city’ different from their own customer city.
SELECT DISTINCT c.CustomerID, c.ContactName, c.City AS CustomerCity, o.ShipCity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity;

-- 8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 p.ProductName, AVG(od.UnitPrice) AS AvgPrice, c.City AS TopOrderingCity, SUM(od.Quantity) AS TotalQuantityOrdered
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductName, c.City
ORDER BY SUM(od.Quantity) DESC;

-- 9(a). List all cities that have never ordered something but we have employees there (Using a Subquery).
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (SELECT DISTINCT c.City FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID);

-- 9(b). List all cities that have never ordered something but we have employees there (Without Using a Subquery).
SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Customers c ON e.City = c.City
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL;

-- 10. List one city, if exists, that is the city from where the employee sold most orders and also the city with the highest total quantity of products ordered.
WITH EmployeeOrderCity AS (
    SELECT e.City AS EmployeeCity, e.EmployeeID, COUNT(o.OrderID) AS TotalOrders
    FROM Employees e JOIN Orders o ON e.EmployeeID = o.EmployeeID 
    GROUP BY e.City, e.EmployeeID
),
CityTotalProductQuantity AS (
    SELECT o.ShipCity AS City, SUM(od.Quantity) AS TotalQuantity
    FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY o.ShipCity
)
SELECT TOP 1 t.EmployeeCity, c.City, t.TotalOrders, c.TotalQuantity
FROM EmployeeOrderCity t
JOIN CityTotalProductQuantity c ON t.EmployeeCity = c.City
ORDER BY t.TotalOrders DESC, c.TotalQuantity DESC;



-- -- 11. How do you remove duplicate records from a table?
--By Using CTE (common table expression)
-- WITH CTE AS (
--     SELECT *, ROW_NUMBER() OVER (PARTITION BY column1, column2, column3 ORDER BY (SELECT NULL)) AS RowNum
--     FROM TableName
-- )
-- DELETE FROM CTE WHERE RowNum > 1;

--Example on Products Table for removing any duplicate records
WITH DuplicateRecords AS (
    SELECT 
        ProductID, ProductName, SupplierID, CategoryID, UnitPrice, 
        ROW_NUMBER() OVER (PARTITION BY ProductName, SupplierID, CategoryID ORDER BY ProductID) AS row_num
    FROM Products
)
DELETE FROM Products
WHERE ProductID IN (SELECT ProductID FROM DuplicateRecords WHERE row_num > 1);
