Use AdventureWorks2019
GO

--1. How many products can you find in the Production.Product table?
-- 504
SELECT COUNT(*) AS CountedProducts
FROM Production.Product

--2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
-- 295
SELECT COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

--4. How many products that do not have a product subcategory.
-- 209
SELECT COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
GROUP BY ProductID

--6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT ProductID, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf

--11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL and Class IS NOT NULL
GROUP BY Color, Class

--12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion AS c INNER JOIN Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode

--13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion AS c INNER JOIN Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name in ('Germany', 'Canada')

-- Using Northwnd Database: (Use aliases for all the Joins)
Use Northwind
GO

--14. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductName
FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID LEFT JOIN Products AS p ON od.ProductID = p.ProductID
WHERE YEAR(o.OrderDate)+25 >= YEAR(GETDATE())

--15. List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS TotalSold
FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID
WHERE o.ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode
ORDER BY TotalSold DESC

--16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS TotalSold
FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID
WHERE o.ShipPostalCode IS NOT NULL AND YEAR(o.OrderDate)+25 >= YEAR(GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY TotalSold DESC

--17. List all city names and number of customers in that city.    
SELECT City, COUNT(*) AS NumCustomers
FROM Customers
GROUP BY City

--18. List city names which have more than 2 customers, and number of customers in that city
SELECT City, COUNT(*) AS NumCustomers
FROM Customers
GROUP BY City
HAVING COUNT(*) > 2

--19. List the names of customers who placed orders after 1/1/98 with order date.
SELECT DISTINCT c.ContactName, o.OrderDate
FROM Orders AS o LEFT JOIN Customers AS c ON o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01'

--20. List the names of all customers with most recent order dates
SELECT c.ContactName, MAX(o.OrderDate) AS MostRecent
FROM Orders AS o LEFT JOIN Customers AS c ON o.CustomerID = c.CustomerID
GROUP BY c.ContactName

--21. Display the names of all customers  along with the  count of products they bought
SELECT c.ContactName, SUM(od.Quantity) AS ProdCount
FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID LEFT JOIN Customers AS c ON o.CustomerID = c.CustomerID
GROUP BY c.ContactName

--22. Display the customer ids who bought more than 100 Products with count of products.
SELECT o.CustomerID, SUM(od.Quantity) AS ProdCount
FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID
GROUP BY o.CustomerID
HAVING SUM(od.Quantity) > 100

--23. List all of the possible ways that suppliers can ship their products. Display the results as below
SELECT DISTINCT su.CompanyName AS 'Supplier Company Name', sh.CompanyName AS 'Shipping Company Name'
FROM Suppliers AS su LEFT JOIN Products AS p ON su.SupplierID = p.SupplierID
                        LEFT JOIN [Order Details] AS od ON p.ProductID = od.ProductID
                        LEFT JOIN Orders AS o ON od.OrderID = o.OrderID
                        LEFT JOIN Shippers AS sh ON o.ShipVia = sh.ShipperID

--24. Display the products order each day. Show Order date and Product Name.
SELECT o.OrderDate, p.ProductName
FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID LEFT JOIN Products AS p ON od.ProductID = p.ProductID

--25. Displays pairs of employees who have the same job title.
SELECT e1.Title, e1.FirstName+' '+e1.LastName AS Employee1, e2.FirstName+' '+e2.LastName AS Employee2
FROM Employees e1 LEFT JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID < e2.EmployeeID

--26. Display all the Managers who have more than 2 employees reporting to them.
WITH EmployeeCTE
AS(
    SELECT e1.FirstName+' '+e1.LastName AS Manager
    FROM Employees e1 LEFT JOIN Employees e2 ON e1.EmployeeID = e2.ReportsTo
)
SELECT Manager
FROM EmployeeCTE
GROUP BY Manager
HAVING COUNT(*) > 2

--27. Display the customers and suppliers by city. The results should have the following columns
SELECT City, CompanyName AS Name, ContactName, 'Customer' AS TYPE
FROM Customers
UNION
SELECT City, CompanyName AS Name, ContactName, 'Supplier' AS TYPE
FROM Suppliers
