# tSQLt 

- DATABASE UNIT TESTING FRAMEWORK FOR SQL SERVER
- https://tsqlt.org/
- https://app.pluralsight.com/library/courses/unit-testing-t-sql-tsqlt/table-of-contents
- https://www.sqlshack.com/sql-unit-testing-with-the-tsqlt-framework-for-beginners/


### tSQLt_Example
```
USE tSQLt_Example

SELECT * FROM tSQLt.TestClasses (NOLOCK)

EXEC tSQLt.RunAll

EXEC tSQLt.Run 'AcceleratorTests'

SELECT * FROM tSQLt.TestResult (NOLOCK)

SELECT * FROM tSQLt.info()
```

### Anatom of a test
```
-- Setup
	-- Isolate dependencies
	-- Insert test data
	-- Specify expected result
-- Run Object under test
	-- Call Stored procedure
-- Asserss Result 
	--	Does the actual result match the expected result?
```
### Runnign a test
```
	-- Start Transaction
	-- Run Setup Procedure (if any)
	-- Run Test
		-- Setup
		-- Run Object under test
		-- Assess Result
	-- Rollback transaction ( keeping results of test)
```
### Runnign all tests in a test class
```
-- Lookup the tests in the class, and for each test in the class:
	-- Start Transaction
	-- Run Setup Procedure (if any)
	-- Run Test
		-- Setup
		-- Run Object under test
		-- Assess Result
	-- Rollback transaction ( keeping results of test)
```
### Runnign all tests in a database
```
-- Lookup all the test classes (schemas marked as test classes) in the database
-- For each test class :
	-- Start Transaction
	-- Run Setup Procedure (if any)
	-- Run Test
		-- Setup
		-- Run Object under test
		-- Assess Result
	-- Rollback transaction ( keeping results of test)
 ```
