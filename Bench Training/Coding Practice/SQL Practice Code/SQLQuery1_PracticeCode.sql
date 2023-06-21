/*Use distinct to retrive the unique values*/
select distinct([[Reporting Location]]]) from [Employee Details];


/*Creating database*/
create database PracticeCode1;

/*Creating table*/
create table Customer(
customerId int Primary Key Identity Not NULL,
customerName nvarchar(50) Not NULL,
Address nvarchar(50) Not NULL,
Email nvarchar(50)Not NULL,
Phone int Not NULL);

/*Display the table data*/
Select * from Customer;

/* Displaying all the databases*/	
exec sp_databases;

/*Displaying the tables of specific database.*/
exec sp_tables;


