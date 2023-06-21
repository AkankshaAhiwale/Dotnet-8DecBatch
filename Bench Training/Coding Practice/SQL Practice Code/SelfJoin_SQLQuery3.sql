insert into [Employee Details] values(next value for seq_1,'Shruti Agrawal','40000','Amravati','Mumbai',2),
(next value for seq_1,'Bhakti Takane','41000','Jalgaon','Mumbai',3),
(next value for seq_1,'Ketaki Patil','42000','Chupda','Mumbai',5),
(next value for seq_1,'Ruchita Umbarkar','43000','Varda','Mumbai',5),
(next value for seq_1,'Donald Sahu','45000','Devas','Mumbai',1)


select * from [Employee Details]

update [Employee Details] set [Manager Id]=15 where Emp_id=19;


select e.Emp_id, e.Emp_name, m.[Manager Id] as [Manager Name] from [Employee Details] e Join [Employee Details] m on e.Emp_id=m.[Manager Id];

SELECT e.Emp_id,e.Emp_name,manager.Emp_name as [Manager Name] FROM [Employee Details] e
JOIN [Employee Details] manager
ON e.[Manager Id] = manager.Emp_id;

select * from [Employee Details];
select * from Departments;
select * from [Employee Details] cross join Departments;


