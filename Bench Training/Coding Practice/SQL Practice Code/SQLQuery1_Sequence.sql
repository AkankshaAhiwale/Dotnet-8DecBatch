insert into Customer(customerId,customerName,customerAddress,Email,Phone) values(01,'Shruti','Amravati','shruti@gmail.com',98038);

insert into Customer(customerId,customerName,customerAddress,Email,Phone) values(02,'Ketu','Amravati','ketu@gmail.com','1234567890');

set identity_insert Customer on;

select * from Customer;

ALTER TABLE Customer
ALTER COLUMN Addr nvarchar(50);

/*ALTER TABLE Customer RENAME COLUMN old_name TO new_name;*/

EXEC sp_RENAME 'Customer.Address', 'customerAddress', 'COLUMN'

/*Creating sequence*/
create sequence seq_2
start with 10
increment by 1
minvalue 10
maxvalue 30
cycle;

/* Displaying the integer value of sequence*/
SELECT NEXT VALUE FOR seq_1 AS Counter;

/*Inserting multiple values into the sequence*/
insert into Student values(next value for seq_1,'Bhakti','Jalgoan');
insert into Student values(next value for seq_1,'Bhakti','Jalgoan'),(next value for seq_1,'Bhakti','Jalgoan');

select * from Student;
delete from Student;

/* Updating the value of the primary key using sequence*/
update Student set Sid=next value for seq_2;

/*Creating a foreign key*/
create table Book(book_id int Primary key Identity Not Null,
bookName nvarchar(50) Not Null,
Price int Not Null,
publishYear int Not NUll,
author_id int references Authors);

select * from Book;
set identity_insert Book on;

insert into Book(book_id,bookName,Price,publishYear,author_id) values(next value for seq_1,'ABC','200','2001',4);

delete from Book

select * from Authors;

create sequence s1
start with 0
increment by 1
maxvalue 10
cycle;

create table college(
college_id int primary key identity not null,
college_name nvarchar(100) not null,
college_address nvarchar(100) not null,
college_grade nvarchar(10) not null);

set identity_insert college on;

insert into college(college_id, college_name, college_address, college_grade) values(01,'SPMM','Baramati','A+');
insert into college(college_id, college_name, college_address, college_grade) values(next value for s1,'SPMM','Baramati','A+');

select * from College

select * from Employee;


select Emp_name as [Employee Name] from [Employee Details];

Create table Sample1(
id int primary key not null,
age int check(age>18) not null);

insert into Sample1 values(01,19);

select * from Sample1;

delete from Sample1;

drop table Sample1;

Select * from [Employee Details];




