 --From the following tables, write a SQL query to find all orders executed by the salesperson 
 --and ordered by the customer whose grade is greater than or equal to 200. Compute purch_amt*commission as “Commission”. 
 --Return customer name, commission as “Commission%” and Commission.


create procedure procedure2
As
begin
select cust_name,grade as Grade, commission as [Commission %], purch_amt*commission as Commission 
from customer, orders, salesman where Orders.customer_id=customer.customer_id 
and Orders.salesman_id=salesman.salesman_id and grade>=200;
end

exec procedure2;




exec sp_helptext procedure2;

exec sp_helptext procedure1;

exec sp_help

