select p.ProductName, sum(od.UnitPrice*od.Quantity) from Products p inner join [Order Details] od on  p.ProductID = od.ProductID group by p.ProductName

select * from [Order Details] where ProductID = 14