/* Assignment No 3*/

Select * from Customer;


Select * from Customer,Order_table where Phone='030-0074321';

Select * from Products, Categories where CategoryName='Seafood';

Select * from Customers, Orders where City is Not 'London'; 

Select * from OrderDetails where ProductID=(Select ProductID from Products where ProductName='Chais');

