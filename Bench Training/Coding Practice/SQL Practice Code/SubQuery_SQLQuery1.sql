--Q. From the following tables, write a SQL query to find all the orders issued by the salesman 'James Hoog'. 
--Return ord_no, purch_amt, ord_date, customer_id and salesman_id.
select * from orders where salesman_id=(select salesman_id from salesman where sname=' James Hoog');
select * from orders;