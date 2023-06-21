/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Eid]
      ,[Ename]
      ,[Salary]
      ,[Designation]
      ,[Location]
  FROM [Database1].[dbo].[Emp1]

insert into [Employee Details] values(next value for seq_1,'Rajdeep Kekar',50000,'Goa','Mumbai',16);

insert into [Employee Details] values(next value for seq_1,'Anubhav Srivastava',50000,'Bhopal','Bangalore',20);

Update [Employee Details] set [Permanent Address]='Dewas' where Emp_id=19;
Update [Employee Details] set [Permanent Address]='Vardha' where Emp_id=18;
Update [Employee Details] set [Permanent Address]='Chopda' where Emp_id=17;

select * from [Employee Details];


/*And Operator*/
select * from [Employee Details] where [Manager id]=16 and [[Reporting Location]]]='Mumbai';
  
/*Or Operator*/
Select * from [Employee Details] where [[Reporting Location]]]!= 'Mumbai';

/*Not Operator*/
Select * from [Employee Details] where not [[Reporting Location]]]='Mumbai';

/*Like Operator
Where underscore(_) represents single character 
and % represents multiple characters*/
select * from [Employee Details] where [Permanent Address] like '___a%';
select * from [Employee Details] where Emp_name like '_a%';

/*Where the [] is used to mention the initial letter of a word*/
select * from [Employee Details] where Emp_name like '[kds]%';

/*Using not(with keyword and operator as well) with like operator*/
select * from [Employee Details] where Emp_name like '[^kds]%';
select * from [Employee Details] where Emp_name not like '[kds]%';

/*Providing the range with a start and an end value*/
select * from [Employee Details] where [[Reporting Location]]] like 'm%i'


/*In Operator :  Acts as an alternative for multiple OR*/
select * from [Employee Details] where [[Reporting Location]]]='Mumbai' or [Permanent Address]='Goa';
select * from [Employee Details] where [Permanent Address] in ('Dewas','Goa','Jalgaon');

/* In with not operator*/
select * from [Employee Details] where [[Reporting Location]]] not in ('Mumbai');

/* Between operator : Used to specify the range and display the data accordingly*/
select * from [Employee Details] where Emp_id between 17 and 19;

/* Between operator using not*/
select * from [Employee Details] where Emp_id not between 16 and 18 order by Emp_id desc;

select top 2 Emp_name from [Employee Details] order by Emp_name;

select Emp_id, Emp_name, max(salary) from [Employee Details] where salary>(select max(Salary) from [Employee Details]);










