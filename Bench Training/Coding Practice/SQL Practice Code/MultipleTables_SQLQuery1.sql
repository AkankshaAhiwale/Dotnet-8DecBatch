--Querying on Multple tables.
select * from customer;
select * from salesman;
select * from Orders;


--From the following tables, write a SQL query to find those salespeople who generated orders 
--for their customers but are not located in the same city. 
--Return ord_no, cust_name, customer_id (orders table), salesman_id (orders table).  		
select ord_no, cust_name, orders.customer_id, orders.salesman_id from Orders, customer, salesman 
where customer.city!=salesman.city and orders.customer_id=customer.customer_id and Orders.salesman_id=salesman.salesman_id;


--From the following tables, write a SQL query to find the salespeople and customers who live in the same city. 
--Return customer name, salesperson name and salesperson city.
select cust_name, sname, salesman.city from customer, salesman where customer.city=salesman.city;

--From the following tables, write a SQL query to locate all the customers and the salesperson who works for them. 
--Return customer name, and salesperson name.  
select cust_name, Sname from customer, salesman where customer.sid=salesman.salesman_id;
select * from customer;
select * from salesman;

--From the following tables, write a SQL query to locate the orders made by customers. 
--Return order number, customer name.  
select ord_no, cust_name from customer, Orders where Orders.customer_id=customer.customer_id;


 --From the following table, write a SQL query to find those customers who are served by a salesperson and 
 --the salesperson earns commission in the range of 12% to 14% (Begin and end values are included.). 
 --Return cust_name AS "Customer", city AS "City". 
 select Cust_name as Customer, customer.city as City, Sname as [Salesman Name], commission as Commission from customer, 
 salesman where salesman.salesman_id=customer.sid and commission between 0.12 and 0.14;

 --From the following tables, write a SQL query to find all orders executed by the salesperson 
 --and ordered by the customer whose grade is greater than or equal to 200. Compute purch_amt*commission as “Commission”. 
 --Return customer name, commission as “Commission%” and Commission.
select Cust_name, Commission as [Commission %],purch_amt*commission as Commission 
from salesman,orders, customer where orders.salesman_id=salesman.salesman_id and 
Orders.customer_id=customer.customer_id and grade<=200;


