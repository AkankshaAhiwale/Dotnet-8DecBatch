/*Constraints*/
/*Adding Check constraint*/
alter table Employee add check(Salary>5000)

/* Adding Unique constraint*/
alter table Employee add City nvarchar Unique


/*Adding default constraint*/
set identity_insert departments on;
alter table departments add constraint df_grade Default 'A' for Grade;
insert into Departments(Id, d_nm) values(next value for seq_2, 'Accounting');
insert into departments(id,d_nm,grade) values(next value for seq_1,'Finance',default);



/*Adding a new column to the existing table*/
alter table Departments add Grade nvarchar
alter table Employee add ReportingLocation nvarchar(50);

/* Altering the table to add not null constraint*/
alter table Departments alter column Grade nvarchar not null

/*Inserting  multiple values*/
insert into Employee values(next value for seq_2,'Ruchita',55000,'Vardha','Mumbai');
insert into Employee(Emp_id, Emp_name, Salary) values(next value for seq_1, 'Ketaki', 40000),(next value for seq_1, 'Ruchita', 40000);

set identity_insert Departments on

select * from Departments

delete from Departments where id=15;

/* Adding an extra column into the table*/
select * from Employee

delete from Employee;

alter table Employee add City nvarchar(50);

alter table Employee alter column City nvarchar(50) not NULL

update Employee SET City='Mumbai' where emp_id=13;

insert into Employee values(next value for seq_2,'AK',50000,'Pune','Mumbai'),(next value for seq_2,'BT',55000,'Jalgoan','Mumbai'),(next value for seq_2,'SA',60000,'Amravati','Mumbai');
insert into Employee values(next value for seq_2,'AK',50000,'Pune','Mumbai')

/* Counting the 2nd maximum salary*/
select max(salary) from Employee where salary<(select max(salary) from Employee);

/* Getting last two record*/
select top(2) Emp_id, Emp_name from Employee order by emp_id desc;
select * from Employee

alter table Employee alter column ReportingLocation nvarchar(50) not Null;

select * from [Employee Details];

/* To print the different values and eliminating the duplicate one*/
select distinct ReportingLocation from Employee;

/*Renaming the column name*/
alter table Employee RENAME ReportingLocation to [Reporting Location];
exec sp_rename 'Employee.City','Permanent Address';

/* To get the values of sequence*/
select next value for seq_2 as counter

/*Renaming the table*/
exec sp_rename 'Employee','Employee Details';






