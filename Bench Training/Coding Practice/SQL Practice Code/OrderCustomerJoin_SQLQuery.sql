exec sp_renamedb 'JoinDB','JoinsDB';

/* Single user : When setting a db to single user mode, it is not accessible by the 
another user.*/ 
ALTER DATABASE JoinsDB
SET SINGLE_USER WITH ROLLBACK IMMEDIATE

/* Multiuser : Accessible by the multiple users*/
ALTER DATABASE JoinsDB
SET MULTI_USER;


/*Contains FK as customer_id from customer and salesman_id from salesman*/
Create table Orders(
ord_no int primary key identity not null,
purch_amt float not null,
ord_date date not null,
customer_id int references customer(customer_id),
salesman_id int references salesman(salesman_id));


--Q. From the following tables write a SQL query to find those orders where the 
--order amount exists between 500 and 2000. Return ord_no, purch_amt, cust_name, city.

select ord_no, purch_amt,cust_name,Customer.city from Orders inner join customer on Orders.customer_id=customer.customer_id 
where purch_amt between 500 and 2000;

set identity_insert Orders on;

select * from customer;
select * from salesman;
select * from orders;



insert into Orders(ord_no,purch_amt,ord_date,customer_id,salesman_id) values
(70001  ,     150.5  ,     '2012-10-05'  ,3005  ,       5002),
(70009     ,  270.65    ,  '2012-09-10' , 3001   ,      5005),
(70002  ,     65.26  ,     '2012-10-05',  3002 ,        5001),
(70004  ,     110.5   ,    '2012-08-17',  3009        , 5003),
(70007  ,     948.5   ,    '2012-09-10' , 3005  ,       5002),
(70005  ,     2400.6 ,     '2012-07-27' , 3007   ,      5001),
(70008   ,    5760   ,     '2012-09-10',  3002    ,     5001),
(70010    ,   1983.43   ,  '2012-10-10' , 3004   ,      5006),
(70003   ,    2480.4    ,  '2012-10-10',  3009  ,       5003),
(70012  ,     250.45 ,     '2012-06-27' , 3008     ,    5002),
(70011  ,     75.29    ,   '2012-08-17',  3003   ,      5007),
(70013    ,   3045.6   ,   '2012-04-25' , 3002     ,    5001);

--Q. From the following tables write a SQL query to find the salesperson(s) and the customer(s) 
--he represents. Return Customer Name, city, Salesman, commission. 

--Q. From the following tables write a SQL query to find salespeople who received 
--commissions of more than 12 percent from the company. 
--Return Customer Name, customer city, Salesman, commission.
select cust_name, customer.city, Sname, commission from salesman inner join customer on 
salesman.salesman_id=customer.sid where commission>0.12;


--Q. From the following tables write a SQL query to find salespeople who received 
--commissions of more than 12 percent from the company where the salesman and customer city is not equal.. 
--Return Customer Name, customer city, Salesman, commission.
select cust_name, customer.city, Sname, commission from salesman inner join customer on 
salesman.salesman_id=customer.sid where commission>0.12 and salesman.city!=customer.city;


