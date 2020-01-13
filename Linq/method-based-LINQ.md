# method-based LINQ 
- Method-based queries are actually extension methods found in the System.Linq namespace
- These methods extend any variable that implements the IEnumerable<T> or IQueryable<T> interface.
- Method-based queries take a lambda expression as a parameter
### Filtering 
```
int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = myArray.Where(i => i % 2 == 0);
```
### Ordering 
```
var evenNumbers = myArray.Where(i => i % 2 == 0).OrderByDescending(i => i);
var orderedHometowns = hometowns.OrderBy(h => h.State).ThenBy(h => h.City);
```
### Projection 
```
var lastNames = people.Select(p => p.LastName);
var names = people.Select(p => new { p.FirstName, p.LastName });
var names = people.Select(p => new { First = p.FirstName, Last = p.LastName });
 var employeeByState = employees
                  .SelectMany(
                    e => states
                      .Where(s => e.StateId == s.StateId)
                      .Select(s => new { e.LastName, s.StateName })
                  );
```
### Joining 
```
var employeeByState = employees.Join(states,                                          
  e => e.StateId,                                          
  s => s.StateId, (e, s) => new { e.LastName, s.StateName });
 
```
### Outer Join
```
var employeeByState = employees.GroupJoin(states,            
                      e => e.StateId,            
                      s => s.StateId,            
                      (e, employeeGroup) => 
                        employeeGroup.Select(s => new                 
                        {                     
                          LastName = e.LastName, StateName = s.StateName                 
                        })
                        .DefaultIfEmpty(new                     
                        {                         
                          LastName = e.LastName,StateName = ""                     
                        })).SelectMany(employeeGroup => employeeGroup);
 
```
### Composite Keys 
```
 var employeeByState = employees.Join(hometowns,                                       
                       e => new { City = e.City, State = e.State },                                       
                       h => new { City = h.City, State = h.State },                                       
                       (e, h) => new { e.LastName, h.CityCode });
 
 ```
