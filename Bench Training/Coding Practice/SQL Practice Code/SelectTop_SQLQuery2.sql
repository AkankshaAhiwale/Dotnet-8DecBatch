/* Top is used with order by clause.
1. Select Top : */

select top 3 emp_name from [employee details] where emp_name='AK' order by emp_name;

/*2. Select Top percent :*/
select top 1 percent emp_name from [employee details] order by emp_name;

select top 2 * from [Employee Details] where salary=(select max(salary) from [Employee Details]);

select * from [employee details];
select * from [Employee Details] where Salary=(select max(salary) from [Employee Details] where Salary<(select max(salary) from [Employee Details])) order by Emp_name desc;

select top 1 * from (select top 2 * from [Employee Details] order by Salary desc) as E order by Salary;

select * from [Employee Details] where salary>(select avg(Salary) from [Employee Details]);

alter table [Employee Details] alter column	Salary int not null;

exec sp_rename '[Employee Details].Manager name','Manager Id';


alter table [Employee Details] drop constraint [CK__Employee__Salary__04E4BC85];

delete from [Employee Details];

Alter table [Employee Details] add [Manager Name] nvarchar(50) not Null;


exec sp_rename 'Author','Authors';

select * from Authors;

