### Return a query from a method 
- Query objects are composable, meaning that you can return a query from a method
- . The advantage of returning query objects from methods is that they can be further composed or modified. 
- Therefore any return value or out parameter of a method that returns a query must also have that type. 
- If a method materializes a query into a concrete List<T> or Array type, it is considered to be returning the query results instead of the query itself. 
- A query variable that is returned from a method can still be composed or modified.
