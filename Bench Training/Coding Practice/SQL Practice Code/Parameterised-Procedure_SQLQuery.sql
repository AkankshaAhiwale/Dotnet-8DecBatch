



create procedure procedure3
(@cid int)
as 
begin
select * from customer where customer_id=@cid;
end;

exec Parameterised_Procedure 3001;

exec sp_rename 'Procedure3','Parameterised_Procedure';


exec MultipleTables_Procedure;
