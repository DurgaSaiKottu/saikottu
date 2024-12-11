use Assessment

--Create a Function to calculate the course duration for the above relation by receiving start date and end date as input.


CREATE TABLE Course_Details (C_id VARCHAR(30), C_Name VARCHAR(100),Start_Date DATE, End_Date DATE, Fee INT);

INSERT INTO Course_Details (C_id, C_Name, Start_Date, End_date, Fee)
VALUES
   ('DN003', 'DotNet', '2018-02-01', '2018-02-28', 15000),
   ('DV004', 'Data Visualization', '2018-03-01', '2018-04-15', 15000),
   ('JA002', 'AdvancedJava', '2018-01-02', '2018-01-20', 10000),
   ('JC001', 'CoreJava', '2018-01-02', '2018-01-12', 3000);
 
 SELECT * FROM  Course_Details


   --1.Create a Function to calculate the course duration for the above relation by receiving start date and end date as input.

CREATE FUNCTION CalculateCourseDuration( @Start_Date DATE,@End_Date DATE)
RETURNS INT
BEGIN
   DECLARE @Duration INT;
   SET @Duration = DATEDIFF(DAY,@Start_Date,@End_Date);
   RETURN @Duration;
END

select dbo.CalculateCourseDuration(Start_date,End_date) as Duration from  Course_Details



--2.Create a trigger to display the Course Name and Start date of the course


CREATE TABLE T_Coursedetails(
C_Name VARCHAR(30),
Start_date DATE)
 
CREATE TRIGGER InsertionTrigger ON Course_Details
AFTER INSERT AS
BEGIN
INSERT INTO T_Coursedetails(C_Name, Start_date)
SELECT C_Name, Start_date FROM inserted 
END
 
INSERT INTO Course_Details VALUES
('DA006','Big_Data','2024-04-12','2020-05-05',18000)
 
SELECT * FROM  T_Coursedetails


---3.Write a stored Procedure that inserts records in the ProductsDetails table

 CREATE TABLE ProductsDetails(
ProductID INT IDENTITY(1,1),
ProductName VARCHAR(20),
Price INT,
DiscountedPrice as (Price*0.90)
)
CREATE or Alter PROCEDURE ProdDetailsInsertion @ProductName VARCHAR(25), 
@Price INT, @ProductID INT OUTPUT as
BEGIN
INSERT INTO ProductsDetails(ProductName, Price) VALUES(@ProductName,@Price)
SET @ProductID = SCOPE_IDENTITY()
END
DECLARE @NewProductID INT
EXEC ProdDetailsInsertion 
@ProductName = 'Laptop',
@Price = 20000,
@ProductID = @NewProductID OUTPUT
 
 SELECT @NewProductID as ProductID
SELECT * FROM ProductsDetails