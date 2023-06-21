/*--------Stored Procedure------
- Used to perform multiple operations on the database, which reduces the time
computational time.
Can be used to quickly perform the updation, create scripts, improve application performance
Features : 
- Can have input, output and input-output parameters.
- It may or may not return a value.
- Supports nested procedure calls.
- Enabling the reusability of the code.
- SET NoCount on : Tells teh server not to display the count of the affected rows*/

/* exec sp_helptext Procedure name: To check the existing stmts of the procedure.*/


/*Default Parameters : 
- When you create a parameter with a value, which means you do pass the value explicitly when executing the 
procedure.
- While executing if new value is passed, the default value is ignored.
*/


/*---------Parameters---------
- In : using which one can give parameter as input.
- Out : Porcedure will give data as output parameter.
- InOut : A procedure can have both input and output parameters as well. 
*/


/*create procedure Procedure1
AS
begin
select * from [Employee Details];
end
*/

--exec Procedure1;

exec sp_renamedb 'Sample Tables','Sample';


/*-- Procedure with Nocount statement. 
create procedure NoCountProcedure
as begin
set Nocount on
Select * from customer;
Select * from Orders;
Select * from salesman;
end;*/


-- Procedure with Nocount statement. 
create procedure NoCountProcedure
as begin
set Nocount on
Select * from customer;
Select * from Orders;
Select * from salesman;
end;



-- Command used to drop a Procedure.
--drop procedure NocountProcedure;


