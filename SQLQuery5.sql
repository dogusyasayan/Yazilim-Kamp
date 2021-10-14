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

Select * from Products order by CategoryID,ProductName

