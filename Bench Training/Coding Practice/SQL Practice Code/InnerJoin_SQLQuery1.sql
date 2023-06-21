select 3 from [Employee Details];
select * from salesman;
select * from Customer;
select * from Orders;


create database JoinDB;

create table salesman(
 salesman_id int primary key not null identity,
  name nvarchar(50) not null,
  city nvarchar(50) not null,
  commission int not null);

create table customer(
customer_id int PRIMARY KEY NOT NULL identity,
  cust_name nvarchar(50) not null,
  city nvarchar(50),
  grade int not null, 
  sid int FOREIGN KEY REFERENCES salesman(salesman_id));

  set identity_insert salesman off;
  set identity_insert customer on;

  alter table salesman alter column commission float not null;
  


  insert INTO salesman(salesman_id,Sname,city,commission) VALUES(5001,' James Hoog',' New York ',0.15);
  
  insert INTO salesman(salesman_id,Sname,city,commission) VALUES
  (5001,' James Hoog',' New York ',0.15),
  (5002 ,' Nail Knite ',' Paris',0.13),
  (5005 ,' Pit Alex ',' London ',0.11),
  (5006,' Mc Lyon','Paris',0.14),
  (5007,' Paul Adam',' Rome',0.13),
  (5003,'Lauson Hen','San Jose',0.12);
  
  insert into customer(customer_id,cust_name,city,grade,sid)  VALUES
  (3002,'Nick Rimando',' New York',100,5001),
        (3007,'Brad Davis',' New York',200,5001),
        (3005,'Graham Zusi',' California',200,        5002),
        (3008 ,' Julian Green','London',300,5002),
		(3004 ,'Fabian Johnson',' Paris', 300, 5006),
		(3009 ,' Geoff Cameron','Berlin', 100,5003),
        (3003 ,' Jozy Altidor',' Moscow ',  200,         5007),
        (3001 , 'Brad Guzan',' London',100,      5005);

	delete from salesman;



/* Q. From the following tables write a SQL query to find the salesperson 
and customer who reside in the same city. Return Salesman, cust_name and city. */

exec sp_rename 'Salesman.name','Sname';

select * from salesman;
select * from customer;
select salesman_id,Sname,  cust_name, salesman.city as [Saleman City], customer.city
as [Customer City] from salesman inner join customer on 
salesman.city=customer.city;


