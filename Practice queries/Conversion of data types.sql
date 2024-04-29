DECLARE @myvar as Decimal(5,2) = 3

SELECT @myvar

SELECT CONVERT(decimal(5,2),3)/2
go
SELECT CAST(3 as decimal(5,2))/2
go
SELECT CONVERT(decimal(5,2),1000) --This wont work
SELECT 3/2 
SELECT 3/2.0 

SELECT CONVERT(INT,12.345)+CONVERT(INT,12.7) 
SELECT CONVERT(INT,12.345+12.7) 
