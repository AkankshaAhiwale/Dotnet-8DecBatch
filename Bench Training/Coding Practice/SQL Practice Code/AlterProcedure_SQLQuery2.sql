---Modify the existing procedure 
alter procedure MultipleTables_Procedure
as 
begin
select * from customer;
select * from Orders;
select * from salesman;
end

exec MultipleTables_Procedure;

exec sp_rename 'Procedure2','MultipleTables_Procedure';



