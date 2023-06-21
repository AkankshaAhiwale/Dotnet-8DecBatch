/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Aname]
      ,[address]
      ,[phone]
  FROM [Sample].[dbo].[Authors]

  delete from Authors where id=2;
