--From the following tables write a SQL query to find the salesperson 
--and customer who reside in the same city. Return Salesman, cust_name and city. 
exec MultipleTables_Procedure;
Select Sname, Cust_name, customer.city from Salesman Inner Join Customer 
where customer.city=salesman.city;

