/* Cross join : Joins any 2 tables, returns the result in such a format that each
row of one table is joined with the other table.*/ 

select * from [Employee Details];
select * from Departments;

select sum([No of Employee]), [Manager id] from [Employee Details], Departments where [Manager Id]=19;
