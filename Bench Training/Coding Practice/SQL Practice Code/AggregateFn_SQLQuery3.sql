/*Aggregate Functions*/

/*Maximum*/
select max(salary) as [Maximum Salary] from [Employee Details];

/*Minimum*/
select min(salary) as [Minimum Salary] from [Employee Details];

/*Calculating the total number of employee using count*/
select count(emp_id) as [Total Employees] from [Employee Details];
select count(distinct [manager id]) as [Total count] from [Employee Details];


/*Calculating average salary*/
select avg(salary) as [Average Salary] from [Employee Details];

/*Calculating the sumation*/
select sum(Salary) from [Employee Details] group by salary;

/*Finding the 2 max salary*/
select top 2 * from [Employee Details] where salary=(select max(salary) from [Employee Details] where salary<(select max(salary) from [Employee Details]));
select * from [Employee Details]
