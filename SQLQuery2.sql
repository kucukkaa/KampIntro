SELECT city şehir, companyname şirketadı from customers

select * from customers where city = 'London'

select * from products where categoryId = 1 or CategoryID = 3

select * from products where categoryId = 1 and UnitPrice > 10

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice asc --ascending(artan) defult değer budur yazmaya gerek yok

select * from Products order by UnitPrice desc -- descending(azalan) 

select * from Products where CategoryID = 1 order by UnitPrice desc

select count (*) from Products

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*) <10


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from products inner join Categories on Products.CategoryID =Categories.CategoryID

--dto - date transformation object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null