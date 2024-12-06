USE Sql_Assignment



------1.Write a T-SQL Program to find the factorial of a given number.
 
create function dbo.Factorial (@number int)
returns bigint
as
begin
    declare @result bigint
    set @result = 1
    while @number > 1
    begin
        set @result = @result * @number
        set @number = @number - 1
    end
    return @result
end


select dbo.Factorial(5) as Factorial


--2.Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number.
 
create or alter procedure multiplication @num int ,@upto int
As
begin
	declare @l int =1
	declare @res int
	begin 
		while @l<=@upto
		begin
			set @res=@num*@l
			print cast(@num as varchar) +' X '+ cast(@l as varchar)+ ' = ' +cast(@res as varchar)
			set @l=@l+1
			end
	end
end
 
exec multiplication @num=7,@upto=8

 
--3. Create a function to calculate the status of the student. If student score >=50 then pass, else fail. Display the data neatly
 
 
create table student(Sid int primary key,Sname varchar(20))
insert into student 
values(1,'jack'),(2,'rithvik'),(3,'jaspreeth'),(4,'praveen'),(5,'bisa'),(6,'suraj')
create table marks(mid int primary key,sid int references Student(sid),Score int)
insert into marks 
values(1,1,23),(2,6,95),(3,4,98),(4,2,17),(5,3,53),(6,5,13)
 
 
create function statusofstudent(@marks int)
returns varchar(10)
as
begin
	declare @status varchar(10)
	if @marks>=50
		set @status='pass'
	else
		set @status='fail'
	return @status
end


select s.Sid,s.Sname,m.Score,  dbo.statusofstudent(m.Score) as Status
from Student s
JOIN 
Marks m ON s.Sid = m.Sid
ORDER BY
s.Sid