use Sql_Assignment

select *from EMP

select * from DEPT

----1.Retrieve a list of MANAGERS

select *
from EMP
where job = 'Manager'


--2.Find out the names and salaries of all employees earning more than 1000 per month

select Ename,Sal
from EMP
where Sal > 1000

---3.Display the names and salaries of all employees except JAMES

select Ename,Sal
from EMP
where Ename!= 'james'

--4.Find out the details of employees whose names begin with ‘S’

select *
from EMP
where Ename like 's%'

--5.Find out the names of all employees that have ‘A’ anywhere in their name

select Ename
from EMP
where Ename like '%a%'

--6.Find out the names of all employees that have ‘L’ as their third character in their name

select Ename
from EMP
where Ename like '__L%'

--7.Compute daily salary of JONES

select Sal,Sal/30 as 'Daily_Salary'
from EMP
where Ename like 'jones'

--8.Calculate the total monthly salary of all employees

select sum(Sal) as Total_Monthly_Salary
from EMP

--9.Print the average annual salary

select avg(Sal*12) as annual_salary
from EMP

--10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30

select Ename,job,Sal,Deptno
from EMP
where job!='salesman' and Deptno = 30

--11.List unique departments of the EMP table

select distinct (Deptno) as unique_departments
from EMP

--12.List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
--Label the columns Employee and Monthly Salary respectively.

select Ename as Employee,
Sal as monthly_salary
from EMP
where Sal > 1500 and (deptno =10 or deptno = 30)

--13.Display the name, job, and salary of all the employees whose job is MANAGER or
--ANALYST and their salary is not equal to 1000, 3000, or 5000

select Ename,job,Sal
from EMP
where (job = 'analyst' or job = 'manager') and Sal not in (1000,3000,5000)

--14.Display the name, salary and commission for all employees whose commission
--amount is greater than their salary increased by 10%

select Ename,Sal,Comm
from EMP
where Comm > sal*0.1

--15.Display the name of all employees who have two Ls in their name and are in
--department 30 or their manager is 7782

select Ename
from EMP
where Ename like '%ll%' and Deptno = 30 or mgr_id = 7782

--16.Display the names of employees with experience of over 30 years and under 40 yrs.
--Count the total number of employees

select  Ename ,count(Ename) as number_of_employees  
from EMP
where datediff(year,hiredate,getdate())  between 30 and 40
group by Ename

--17.Retrieve the names of departments in ascending order and their employees in
--descending order

select d.Dname,e.Ename
from EMP e,Dept d
where e.Deptno = d.Deptno
order by d.Dname asc, e.Ename desc

--18.Find out experience of MILLER

select datediff(year,hiredate,getdate()) as employee_Experience
from EMP
where Ename = 'miller'
