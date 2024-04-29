select P.ProductID, P.Name, S.Name as SubcategoryName
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml auto

<P ProductID="706" Name="HL Road Frame - Red, 58">
  <S SubcategoryName="Road Frames" />
</P>
<P ProductID="707" Name="Sport-100 Helmet, Red">
  <S SubcategoryName="Helmets" />
</P>
<P ProductID="708" Name="Sport-100 Helmet, Black">
  <S SubcategoryName="Helmets" />
</P>
<P ProductID="709" Name="Mountain Bike Socks, M">
  <S SubcategoryName="Socks" />
</P>
select P.ProductID, P.Name, S.Name as SubcategoryName
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml auto, elements
<P>
  <ProductID>706</ProductID>
  <Name>HL Road Frame - Red, 58</Name>
  <S>
    <SubcategoryName>Road Frames</SubcategoryName>
  </S>
</P>
<P>
  <ProductID>707</ProductID>
  <Name>Sport-100 Helmet, Red</Name>
  <S>
    <SubcategoryName>Helmets</SubcategoryName>
  </S>
</P>
<P>
  <ProductID>708</ProductID>
  <Name>Sport-100 Helmet, Black</Name>
  <S>
    <SubcategoryName>Helmets</SubcategoryName>
  </S>
</P>
<P>
  <ProductID>709</ProductID>
  <Name>Mountain Bike Socks, M</Name>
  <S>
    <SubcategoryName>Socks</SubcategoryName>
  </S>
</P>
EXPLICIT

select 1 as Tag, NULL as Parent
     , P.ProductID as [Product!1!ProductID]
     , P.Name as [Product!1!ProductName]
	 , S.Name as [Product!1!SubcategoryName]
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml explicit

<Product ProductID="706" ProductName="HL Road Frame - Red, 58" SubcategoryName="Road Frames" />
<Product ProductID="707" ProductName="Sport-100 Helmet, Red" SubcategoryName="Helmets" />
<Product ProductID="708" ProductName="Sport-100 Helmet, Black" SubcategoryName="Helmets" />
<Product ProductID="709" ProductName="Mountain Bike Socks, M" SubcategoryName="Socks" />
PATH
select P.ProductID, P.Name, S.Name as SubcategoryName
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml path
<row>
  <ProductID>706</ProductID>
  <Name>HL Road Frame - Red, 58</Name>
  <SubcategoryName>Road Frames</SubcategoryName>
</row>
<row>
  <ProductID>707</ProductID>
  <Name>Sport-100 Helmet, Red</Name>
  <SubcategoryName>Helmets</SubcategoryName>
</row>
<row>
  <ProductID>708</ProductID>
  <Name>Sport-100 Helmet, Black</Name>
  <SubcategoryName>Helmets</SubcategoryName>
</row>
<row>
  <ProductID>709</ProductID>
  <Name>Mountain Bike Socks, M</Name>
  <SubcategoryName>Socks</SubcategoryName>
</row>
select P.ProductID, P.Name, S.Name as SubcategoryName
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml path('Products')
<Products>
  <ProductID>706</ProductID>
  <Name>HL Road Frame - Red, 58</Name>
  <SubcategoryName>Road Frames</SubcategoryName>
</Products>
<Products>
  <ProductID>707</ProductID>
  <Name>Sport-100 Helmet, Red</Name>
  <SubcategoryName>Helmets</SubcategoryName>
</Products>
<Products>
  <ProductID>708</ProductID>
  <Name>Sport-100 Helmet, Black</Name>
  <SubcategoryName>Helmets</SubcategoryName>
</Products>
<Products>
  <ProductID>709</ProductID>
  <Name>Mountain Bike Socks, M</Name>
  <SubcategoryName>Socks</SubcategoryName>
</Products>
select P.ProductID as '@ProductID', P.Name, S.Name as SubcategoryName
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml path('Products')
<Products ProductID="706">
  <Name>HL Road Frame - Red, 58</Name>
  <SubcategoryName>Road Frames</SubcategoryName>
</Products>
<Products ProductID="707">
  <Name>Sport-100 Helmet, Red</Name>
  <SubcategoryName>Helmets</SubcategoryName>
</Products>
<Products ProductID="708">
  <Name>Sport-100 Helmet, Black</Name>
  <SubcategoryName>Helmets</SubcategoryName>
</Products>
<Products ProductID="709">
  <Name>Mountain Bike Socks, M</Name>
  <SubcategoryName>Socks</SubcategoryName>
</Products>
select P.ProductID as '@ProductID', P.Name as '@ProductName', S.Name as SubcategoryName
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml path('Products')
--@ = attribute, otherwise it is an element.
<Products ProductID="706" ProductName="HL Road Frame - Red, 58">
  <SubcategoryName>Road Frames</SubcategoryName>
</Products>
<Products ProductID="707" ProductName="Sport-100 Helmet, Red">
  <SubcategoryName>Helmets</SubcategoryName>
</Products>
<Products ProductID="708" ProductName="Sport-100 Helmet, Black">
  <SubcategoryName>Helmets</SubcategoryName>
</Products>
<Products ProductID="709" ProductName="Mountain Bike Socks, M">
  <SubcategoryName>Socks</SubcategoryName>
</Products>
select P.ProductID as '@ProductID', P.Name as '@ProductName'
, S.Name as 'Subcategory/SubcategoryName'
from [Production].[Product] as P
left join [Production].[ProductSubcategory] as S
on P.ProductSubcategoryID = S.ProductSubcategoryID
where P.ProductID between 700 and 709
for xml path('Products')

<Products ProductID="706" ProductName="HL Road Frame - Red, 58">
  <Subcategory>
    <SubcategoryName>Road Frames</SubcategoryName>
  </Subcategory>
</Products>
<Products ProductID="707" ProductName="Sport-100 Helmet, Red">
  <Subcategory>
    <SubcategoryName>Helmets</SubcategoryName>
  </Subcategory>
</Products>
<Products ProductID="708" ProductName="Sport-100 Helmet, Black">
  <Subcategory>
    <SubcategoryName>Helmets</SubcategoryName>
  </Subcategory>
</Products>
<Products ProductID="709" ProductName="Mountain Bike Socks, M">
  <Subcategory>
    <SubcategoryName>Socks</SubcategoryName>
  </Subcategory>
</Products>
Query and FLWOR
declare @x xml  
set @x='<Shopping ShopperName="Phillip Burton" >  
<ShoppingTrip ShoppingTripID="L1" >  
  <Item Cost="5">Bananas</Item>  
  <Item Cost="4">Apples</Item>  
  <Item Cost="3">Cherries</Item>  
</ShoppingTrip>  
<ShoppingTrip ShoppingTripID="L2" >  
  <Item>Emeralds</Item>  
  <Item>Diamonds</Item>  
  <Item>Furniture</Item>  
</ShoppingTrip>  
</Shopping>'  
SELECT @x.query('  
   for $Item in /Shopping/ShoppingTrip/Item  
   return $Item
')  

<Item Cost="5">Bananas</Item><Item Cost="4">Apples</Item><Item Cost="3">Cherries</Item><Item>Emeralds</Item><Item>Diamonds</Item><Item>Furniture</Item>

SELECT @x.query('  
   for $Item in /Shopping/ShoppingTrip/Item  
   return string($Item)  
')  

Bananas Apples Cherries Emeralds Diamonds Furniture

SELECT @x.query('  
   for $Item in /Shopping/ShoppingTrip/Item  
   return concat(string($Item),";")  
')  
Bananas; Apples; Cherries; Emeralds; Diamonds; Furniture;
SELECT @x.query('  
   for $Item in /Shopping/ShoppingTrip[1]/Item  
   order by $Item/@Cost
   return concat(string($Item),";")
')  
Bananas; Cherries; Apples;
SELECT @x.query('  
   for $Item in /Shopping/ShoppingTrip[1]/Item  
   let $Cost := $Item/@Cost
   where $Cost = 4
   order by $Cost
   return concat(string($Item),";")
')
Apples;
