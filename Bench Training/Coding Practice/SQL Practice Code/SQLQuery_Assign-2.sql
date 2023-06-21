/* Assignment No : 2*/

select * from Customer where Country='Germany';

Select FirstName+' '+LastName as Full_Name from Customer;

select * from Customer where FaxNumber is Not NULL;

select * from Customer where FirstName like '_u%';

select * from OrderItem where UnitPrice>10.00 OR UnitPrice<20;

select * from suppliers where suppliername="Exotic Liquid";

select productId,avg(Quantity) from OrderDetails group by productId;

Select * from Employee where Manager_Name is NOT NULL;

insert into Employee values(01,'AK','80000');

select * from Employee;

Select * from Departments;



