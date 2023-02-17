--All scenarios are based on Database NORTHWND.
USE Northwind
GO

--1. List all cities that have both Employees and Customers.
SELECT DISTINCT City
FROM Employees 
WHERE City in (
    SELECT DISTINCT City 
    FROM Customers
)

--2. List all cities that have Customers but no Employee.
/*
    a.      Use sub-query
    b.      Do not use sub-query
*/
--2a
SELECT DISTINCT City
FROM Customers 
WHERE City NOT IN (
    SELECT DISTINCT City 
    FROM Employees
)

--2b
SELECT DISTINCT c.City
FROM Customers AS c LEFT JOIN Employees AS e ON c.City = e.City
WHERE e.EmployeeID IS NULL

--3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, ISNULL(tq.TotalQuantity, 0) AS Total_Quantity
FROM Products AS p LEFT JOIN (
    SELECT ProductID, SUM(Quantity) AS TotalQuantity
    FROM [Order Details] AS od
    GROUP BY ProductID
    ) AS tq ON p.ProductID = tq.ProductID

--4. List all Customer Cities and total products ordered by that city.
SELECT c.City, ISNULL(SUM(ood.Quantity), 0) AS Total_Products
FROM Customers AS c LEFT JOIN (
    SELECT o.CustomerID, od.Quantity
    FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID
    ) AS ood ON c.CustomerID = ood.CustomerID
GROUP BY c.City

--5. List all Customer Cities that have at least two customers.
/*
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(*)>1 
*/
--5a. Use union
SELECT c1.City
FROM Customers c1, Customers c2
WHERE c1.City = c2.City AND c1.CustomerID > c2.CustomerID
UNION
SELECT c1.City
FROM Customers c1, Customers c2
WHERE c1.City = c2.City AND c1.CustomerID > c2.CustomerID

--5b. Use sub-query and no union
SELECT DISTINCT City
FROM Customers c1
WHERE City in (SELECT City
        FROM Customers c2
        WHERE c1.City = c2.City AND c2.CustomerID > c1.CustomerID)


--6. List all Customer Cities that have ordered at least two different kinds of products.
WITH temp
AS(
    SELECT DISTINCT c.City, od.ProductID
    FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
                        LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
)
SELECT City
FROM temp
GROUP BY City
HAVING COUNT(ProductID) > 1


--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.ContactName
FROM Customers AS c LEFT JOIN Orders AS o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
WITH Temp
AS(
    SELECT od.ProductID, od.UnitPrice AS Price, od.Quantity, c.City
    FROM [Order Details] od LEFT JOIN Orders o ON od.OrderID = o.OrderID
                            LEFT JOIN Customers c ON o.CustomerID = c.CustomerID
)
SELECT TOP 5 ProductID, AVG(Price) AS AvgPrice, (SELECT TOP 1 City 
                                                    FROM Temp t2 
                                                    WHERE t1.ProductID = t2.ProductID
                                                    GROUP BY City
                                                    ORDER BY SUM(Quantity) DESC) AS City
FROM Temp t1
GROUP BY ProductID
ORDER BY SUM(Quantity) DESC

--9. List all cities that have never ordered something but we have employees there.
--9a. Use sub-query
SELECT DISTINCT City
FROM Employees
WHERE City NOT IN (
    SELECT DISTINCT City 
    FROM Customers
)

--9b. Do not use sub-query
SELECT e.City
FROM Employees e LEFT JOIN Customers c ON e.City = c.City
WHERE CustomerID IS NULL

--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT mo.City
FROM (
    --Most orders
    SELECT TOP 1 c.City
    FROM Orders o LEFT JOIN Customers c ON o.CustomerID = c.CustomerID
    GROUP BY c.City
    ORDER BY COUNT(o.OrderID) DESC
) AS mo INNER JOIN (
    --Highest Quantity
    SELECT TOP 1 c.City
    FROM Customers AS c LEFT JOIN (
        SELECT o.CustomerID, od.Quantity
        FROM Orders AS o LEFT JOIN [Order Details] AS od ON o.OrderID = od.OrderID
        ) AS ood ON c.CustomerID = ood.CustomerID
    GROUP BY c.City
    ORDER BY SUM(ood.Quantity) DESC
) AS mq ON mo.City = mq.City

--11. How do you remove the duplicates record of a table?
--I can have the table UNION itself. 
--I can also use rank to find the duplicates and use DELETE to remoce those rows.
