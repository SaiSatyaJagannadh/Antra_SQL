-- Query 1: Retrieve ProductID, Name, Color, and ListPrice from Production.Product with no filter
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product;

-- Query 2: Exclude rows where ListPrice is 0
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice > 0;

-- Query 3: Retrieve rows where Color is NULL
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NULL;

-- Query 4: Retrieve rows where Color is NOT NULL
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL;

-- Query 5: Retrieve rows where Color is NOT NULL and ListPrice is greater than zero
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0;

-- Query 6: Concatenate Name and Color, excluding rows where Color is NULL
SELECT CONCAT(Name, ' - ', Color) AS ProductDetails
FROM Production.Product
WHERE Color IS NOT NULL;

-- Query 7: Retrieve specific result set
SELECT Name, Color
FROM Production.Product
WHERE (Name = 'LL Crankarm' AND Color = 'Black')
   OR (Name = 'ML Crankarm' AND Color = 'Black')
   OR (Name = 'HL Crankarm' AND Color = 'Black')
   OR (Name = 'Chainring Bolts' AND Color = 'Silver')
   OR (Name = 'Chainring Nut' AND Color = 'Silver')
   OR (Name = 'Chainring' AND Color = 'Black');

-- Query 8: Retrieve ProductID and Name where ProductID is between 400 and 500
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500;

-- Query 9: Retrieve ProductID, Name, and Color restricted to colors Black and Blue
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black', 'Blue');

-- Query 10: Retrieve products where Name starts with 'S'
SELECT ProductID, Name
FROM Production.Product
WHERE Name LIKE 'S%';

-- Query 11: Retrieve Name and ListPrice ordered by Name
SELECT Name, ListPrice
FROM Production.Product
WHERE Name IN ('Seat Lug', 'Seat Post', 'Seat Stays', 'Seat Tube', 
               'Short-Sleeve Classic Jersey, L', 'Short-Sleeve Classic Jersey, M')
ORDER BY Name;

-- Query 12: Retrieve Name and ListPrice where Name starts with 'A' or 'S', ordered by Name
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
AND Name IN ('Adjustable Race', 'All-Purpose Bike Stand', 'AWC Logo Cap', 
             'Seat Lug', 'Seat Post')
ORDER BY Name;


-- Query 13: Retrieve rows where Name starts with 'SPO' but the next character is not 'K'
SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO%' AND Name NOT LIKE 'SPOK%'
ORDER BY Name;

-- Query 14: Retrieve unique colors from Production.Product ordered in descending manner
SELECT DISTINCT Color
FROM Production.Product
ORDER BY Color DESC;
