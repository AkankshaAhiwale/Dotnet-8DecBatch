/* DDL Commands : Create, Drop, Rename, Alter, Truncate.*/


/*Renaming table and the databases*/
exec sp_renamedb 'Sample','Sample Tables';

select * from sys.tables;

SELECT * FROM sys.master_files;

SELECT 
    *
FROM
    information_schema.tables;