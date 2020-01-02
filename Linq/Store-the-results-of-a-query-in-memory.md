### Store the results of a query in memory
- Queries are executed lazily, as each subsequent item in the result is requested. 
- When you use foreach to iterate the results, items are returned as accessed
- To evaluate a query and store its results without executing a foreach loop, just call one of the following methods on the query variable
```
ToList 
ToArray 
ToDictionary 
ToLookup
```
```
IEnumerable<int> queryFactorsOfFour =  from num in numbers            
                                      where num % 4 == 0            
                                      select num;
// Store the results in a new variable        
// without executing a foreach loop.        
List<int> factorsofFourList = queryFactorsOfFour.ToList();
// Iterate the list just to prove it holds data.        
Console.WriteLine(factorsofFourList[2]);        
factorsofFourList[2] = 0;        
Console.WriteLine(factorsofFourList[2]);

```
