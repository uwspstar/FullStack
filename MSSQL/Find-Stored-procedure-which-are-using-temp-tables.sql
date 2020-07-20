--Find Stored procedure which are using temp tables

SELECT [schema] = s.name, 
      [procedure] = p.name 
FROM sys.procedures AS p
INNER JOIN sys.schemas AS s ON p.[schema_id] = s.[schema_id]
WHERE OBJECT_DEFINITION(p.[object_id]) LIKE N'%#<tmpTablName>%';
