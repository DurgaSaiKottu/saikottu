
 ---1.Write a query to display your birthday( day of week)


 DECLARE @Birthday DATE = '2003-01-29'; 
SELECT @Birthday AS 'Birthday',
DATENAME(WEEKDAY, @Birthday) AS 'Day of Week';




--2.	Write a query to display your age in days

DECLARE @birthdate DATE = '2003-01-29';  
SELECT DATEDIFF(DAY, @birthdate, GETDATE()) AS Age_Indays;


--3.	Write a query to display all employees information those who joined before 5 years in the current month

select * from emp
where year(getdate()) - year(hiredate) > 5
  AND month(hiredate) = month(getdate());


  --4.	Create table Employee with empno, ename, sal, doj columns or use and perform the following operations in a single transaction
	--a. First insert 3 rows 
	--b. Update the second row sal with 15% increment  
      --  c. Delete first row.
--After completing above all actions, recall the deleted row without losing increment of second row.

USE Assessment
CREATE TABLE Employee1 (
   empno INT PRIMARY KEY,
   ename VARCHAR(50),
   sal INT,
   doj DATE
)


Begin transaction                                                                               
insert into Employee1
values(1,'sai',5000,'2000-11-16'),
       (2,'hari',6300,'2002-03-13'),
	   (3,'Tarun',7000,'2009-10-20')
	
 
update Employee1
set sal=sal+(sal*0.15)
where empno=2
 
delete from  Employee1
where empno=1

commit
 
 --5.      Create a user defined function calculate Bonus for all employees of a  given dept using 	following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

 create Function Calculate_Bonus
(
  @deptno int,
  @sal decimal(18,2)
  )
  returns decimal(18,2)
  as 
  begin
  declare @Bonus float;
  if  @deptno=10
     set  @bonus=@sal*0.15;
  else if @deptno=20
     set @bonus=@sal*0.20;
  else
       set @bonus=@sal*0.05;
  return @bonus;
  end;
  select * from EMP













 use Sql_Assignment

 ---6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)
 
create procedure  Sal_update      
  as
  begin
    update EMP
    set sal=sal+500
	where deptno=(select deptno from dept where dname='SALES') and sal<1500
  end

  Exec Sal_update
  select *from EMP
