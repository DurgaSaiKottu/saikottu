create database Sql_Assignment

 ---------Creating emp table---------
create table EMP                    
(Empno int primary key ,Ename varchar(50),job varchar(50),Mgr_id int ,Hiredate date ,Sal int ,Comm int,Deptno int references DEPT(Deptno))


--------Insert values into EMP Table-------
insert into EMP
values (7369, 'SMITH', 'CLERK', 7902, '17-DEC-80' , 800 ,null ,20),
	   (7499,'ALLEN','SALESMAN',7698, '20-FEB-81', 1600,300 ,30),
		(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500 , 30),
		(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975,null, 20),
		(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250,1400, 30),
		(7698, 'BLAKE','MANAGER',7839, '01-MAY-81', 2850 ,null,30),
		(7782, 'CLARK','MANAGER', 7839, '09-JUN-81', 2450 ,null, 10),
		(7788,'SCOTT','ANALYST', 7566 ,'19-APR-87',3000, null, 20),
		(7839, 'KING','PRESIDENT',null,'17-NOV-81',5000 ,null,10),
		(7844, 'TURNER','SALESMAN',7698, '08-SEP-81',1500, 0, 30),
		(7876, 'ADAMS', 'CLERK', 7788,'23-MAY-87', 1100,null, 20),
		(7900, 'JAMES', 'CLERK', 7698,'03-DEC-81',950,null, 30),
		(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81',3000,null, 20),
		(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82',1300,null, 10)
 
--Fetching Emp table---
select *from Emp 

--Description regarding emp table---
sp_help EMP                       
 
--Creating DEPT table----
create table DEPT                 
(Deptno int primary key,Dname varchar(50) not null,loc varchar(50))
 

-----Insert values into DEPT Table-----------
insert into DEPT                  
values (10,'ACCOUNTING','NEW YORK' ),
	   (20, 'RESEARCH', 'DALLAS' ),
	   (30, 'SALES', 'CHICAGO' ),
	   (40, 'OPERATIONS','BOSTON' )
 
--Fetching details of DEPT---
select * from DEPT
 --Describing DEPT table---
sp_help DEPT                   
 
                            
				Assignment-2   (QUERIES)
 
--1.Fetching employeee name starting with A------ 
select Ename from Emp where ename like 'A%'     
 

--2.Fetching employee name who dont have manager----
select Ename from EMP where Mgr_id is null  

--3.Fetching employee name,number,sal whose salary is between 1200 and 1400-----
select Ename,Empno,Sal                          
from EMP
where Sal between 1200 and 1400    
 

--4.Giving payrise of 10% and displaying them properly(using subQuery)---
select Sal,Sal*1.10 as Pay_raise                
from Emp
where Deptno=(select Deptno from Dept where Dname='Research')
 

--5.Fetching the count of clerk------
select count(*) as Clerk_Count                 
from EMP
where job='Clerk'
 

--6.Grouping based on job------
select job,avg(sal) as Avg_Salary ,count(*) as EMP_Count   
from EMP
Group by job;

--7.Fetching empnames with highest and lowest salary------
select Ename from EMP                         
where Sal=(select max(Sal) from EMP)
select ename from emp 
where sal=(select min(sal) from Emp)
 
--8.Fetching department name which doesnt have employees----
select d.Dname                                 
from dept d Left join EMP e 
on d.Deptno=e.Deptno
where e.Deptno IS NULL

--9.Fetching details who is analyst and sal >1200 as well as deptno is 20---- 
select * from emp                            
where job='Analyst' and sal>1200 and deptno=20
 
---10.Fetching salaries,employee names and total salary based on their departemnt using self join----
select e.Ename,e.Sal,e.Deptno,sum(e1.Sal) as Total_sal  
from emp e join emp e1
on e.Deptno=e1.Deptno
group by e.ename,e.sal,e.deptno
 
--11.Fetching sal of miller and smith using in opearator ----
select ename sal from emp                    
where ename in ('smith','miller')
 
--12.Fetching employee names whose names starts with A and M----
select ename from EMP                        
where Ename like 'A%' or  Ename like 'M%'
 
--13.Fetching annual salary of smith----
select ename,sal,sal*12 as Smith_Annual_sal   
from emp
where ename='Smith'
 
--14.Fetching Employee names and salaries whose salary is not in between 1500 and 2850-------
select ename,sal from emp                     
where sal not between 1500 and 2850
 
--15.Fetching managers who have more than 2 employees reporting to them ---
select mgr_id,count(*) as Emp_Count           
from emp group by mgr_id
having  count(*)>2
 
 

 