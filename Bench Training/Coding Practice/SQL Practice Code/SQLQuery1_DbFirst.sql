create database CaseDBFirst;

create table Employee_DbFirst(
empId int Not Null Primary key Identity,
empName nvarchar(50) Not Null,
empDesignation nvarchar(50) Not NUll,
empSalary int not null);

drop table Employee_DbFirst;

select * from Employee_DbFirst;

