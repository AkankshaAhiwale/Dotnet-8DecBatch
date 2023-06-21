/*Offset : Used to skip the number of rows.*/
set identity_insert departments on;


insert into departments(id,d_nm,grade,[NO of Employee]) values(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20),(next value for seq_2,'Accounts','A',20)

delete from Departments

select * from departments
select ID from departments order by id offset 5 rows; /*Skipping the initial 5 rows*/
select ID from departments order by id offset 0 rows FETCH next 3 rows only;
/* Where offset is used to mention the initial value or skip the initial rows and fetch next is used to fetch only the specifed range of rows*/
/* In SQL it can only be used with order by clause.*/