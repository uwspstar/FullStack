-- find table infor by field name


SELECT Table_Name, Column_Name, *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_CATALOG = '<DB_NAME>'
AND COLUMN_NAME LIKE '%<FieldsName>%'
 
SELECT      c.name  AS 'ColumnName'
            ,t.name AS 'TableName'
            ,*
FROM        sys.columns c
JOIN        sys.tables  t   ON c.object_id = t.object_id
WHERE       c.name LIKE '%<FieldsName>%'
ORDER BY    TableName, ColumnName
