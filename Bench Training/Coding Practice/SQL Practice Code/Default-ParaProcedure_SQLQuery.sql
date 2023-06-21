create procedure Default_ParamProcedure
(@cid int=3004)
as 
begin
select * from customer where customer_id=@cid;
end;

exec MultipleTables_Procedure;

exec Default_ParamProcedure 3005;
