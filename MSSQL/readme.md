# SQL Server
- SQL vs NoSQL or MySQL vs MongoDB https://www.youtube.com/watch?v=ZS_kXvOeQ5Y
### SQL Server Temp Table vs Table Variable Performance Testing
- https://www.mssqltips.com/sqlservertip/2825/sql-server-temp-table-vs-table-variable-performance-testing/
- https://www.sqlshack.com/when-to-use-temporary-tables-vs-table-variables/
- https://www.mssqltips.com/sqlservertip/1556/differences-between-sql-server-temporary-tables-and-table-variables/
- Temporary tables act like physical tables in many ways. You can create indexes and statistics on temporary tables. 
- Temporary tables are created in tempdb. 
- Even though the tables are instantiated in tempdb, they are backed by physical disk and are even logged into the transaction log. 
- the scope of any particular temporary table is the session in which it is created; meaning it is only visible to the current user.
