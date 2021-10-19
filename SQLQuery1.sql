Select * from Customers
Select ContactName , CompanyName , City from Customers
--Alianz kullanımı / Takma ad
Select ContactName Adi, CompanyName SirketAdi , City Sehir from Customers
--Şehri London olanları getir anlamında kullanılır,
Select * from Customers where City ='London'
--case insensitive / büyük küçük harf duyarsız,
--categoryId 1-3 olanları getir, //YA DA 
Select * from Products where CategoryID='1' or CategoryID=3
--And "VE" anlamı tasır,
Select * from Products where CategoryID=1 and UnitPrice>=10
--order by "sıralamak" amacı ile kullanılır
Select * from Products order by CategoryID,ProductName

Select * from Products order by UnitPrice asc -- ascending (artan-asc)  // descending (düşen-desc)
Select * from Products order by UnitPrice desc -- descending (düşen-desc) 
--Data sayısını saydırıyoruz (COUNT)
Select count (*) from Products --77 Adet data(Product) vardır.
--CategoryId = 2 olanların adedini ver.
Select count (*)Adet from Products where CategoryID=2 

Select categoryID ,count(*) adet from Products group by CategoryID

Select categoryID ,count(*) adet from Products where UnitPrice>20
group by CategoryID having count(*)<10
 --Yukarıda ki having eğer anlamını gelir.Categorisi 10 adetten az olanları ekrana getir.

 Select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
 from Products inner join Categories
 on Products.CategoryID=Categories.CategoryID
 --inner join 2 data eşleşen var ise getirir yok ise getirmez
 --DTO Data Transformation object

 Select * from Customers c left join Orders o 
 on c.CustomerID=o.CustomerID
 where o.CustomerID is null
