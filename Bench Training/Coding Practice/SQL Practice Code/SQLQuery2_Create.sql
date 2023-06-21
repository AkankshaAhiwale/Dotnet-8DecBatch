create database DemoDB;

create table Employee1(
empId int Primary Key Identity Not Null

);

select * from Employee1;

insert into Employee1(empId) values(0);

insert into DemoDB.Employee1(empId, empName ) values(1,'AK','Analyst',30000);


drop table Employee1;

/*Sets the identity to On/Off */
set identity_insert Employee1 on;

/*Alter the table cols*/
Alter table Employee1 add empName nvarchar, empDesignation nvarchar , empSalary int ;

ALter table Employee1 alter column empName nvarchar NOT NULL;