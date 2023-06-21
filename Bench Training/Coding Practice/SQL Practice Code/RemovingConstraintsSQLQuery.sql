/*Removing the constraints*/
/*Default*/
alter table departments alter column df_grade drop DEFAULT;

ALTER TABLE departments DROP CONSTRAINT df_grade;
/*Removing primary key*/
alter table departments drop constraint;

alter table departments add [NO of Employee] int;

delete from departments

alter table departments alter column [No of Employee] int not NULL;

alter table departments add check([No of Employee]>10);

set identity_insert departments on;

insert into departments(id,d_nm,Grade,[No of Employee]) values(next value for seq_1, 'ACCOUNTS','A',4);


select * from departments

select * from seq_1 as counter
