USE Sql_Assignment


--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

--   a) HRA as 10% of Salary
--   b) DA as 20% of Salary
--   c) PF as 8% of Salary
--   d) IT as 5% of Salary
--   e) Deductions as sum of PF and IT
--   f) Gross Salary as sum of Salary, HRA, DA
--   g) Net Salary as Gross Salary - Deductions

Select*From EMP

create or alter proc PaySlip(@EmpId int)
as
begin
declare @Ename varchar(20),@Sal int
declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @Deduction float
declare @Gross_Salary float
declare @Net_Salary float
select @Ename=EName,@Sal=Sal from EMP where EmpNo=@EmpId
set @HRA=@sal*0.10
set @DA=@sal*0.20
set @PF=@sal*0.08
set @IT=@sal*0.05
set @Deduction=@PF+@IT
set @Gross_Salary=@sal+@HRA+@DA
set @Net_Salary=@Gross_Salary-@Deduction
print 'Payslip for Employee : ' +@Ename
print 'Basic Salary : '+cast(@Sal as varchar(10))
print 'HRA : ' +cast(@HRA as varchar(10))
print 'DA : ' +cast(@DA as varchar(10))
print 'PF : ' +cast(@PF as varchar(10))
print 'IT : ' +cast(@IT as varchar(10))
print 'Deduction : ' +cast(@Deduction as varchar(10))
print 'Gross salary : ' +cast(@Gross_Salary as varchar(10))
print 'Net salary : ' +cast(@Net_Salary as varchar(10))
end


EXEC PaySlip 7499
 
 
--2.
CREATE TABLE Holidays(
holiday_date DATE PRIMARY KEY,
holiday_name VARCHAR(30)
)
 
INSERT INTO Holidays VALUES
('2025-01-01', 'New Year'),
('2025-01-26', 'Republic Day'),
('2025-05-01', 'May Day'),
('2025-08-15', 'Independence Day'),
('2025-12-25', 'Christmas')
 
 use Sql_Assignment
 select * from Holidays



CREATE or alter TRIGGER RestrictManipulationOnHolidays
ON Emp
for insert,update,delete
as
BEGIN
    DECLARE @holiday_name VARCHAR(20);
	declare @current_date date = cast(getdate() as date)
    SELECT @holiday_name =holiday_name
    FROM Holidays
    WHERE holiday_date = @current_date;
    IF @holiday_name IS NOT NULL
	    begin
        raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
		     rollback transaction
    END 
END

update Emp set Sal=1000 where EmpNo=7788
select * from emp