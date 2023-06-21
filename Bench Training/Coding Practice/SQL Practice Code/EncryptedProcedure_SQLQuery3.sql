-- Creating an encrypted procedure.
-- Without nocount.
alter procedure EncryptedProcedure
with Encryption
as begin
insert into [Employee Details] values(22,'Dev',50000,'Nashik','Mumbai',20);
end;

create procedure EncryptedProcedure
with Encryption
as begin
set nocount on
insert into [Employee Details] values(22,'Dev',50000,'Nashik','Mumbai',20);
end;

select * from [Employee Details];
drop procedure EncryptedProcedure1;


exec EncryptedProcedure;
