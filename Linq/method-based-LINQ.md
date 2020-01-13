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
### Grouping 
```
var employeesByState = employees.GroupBy(e => e.State); 
```
### Aggregate Functions 
```
int count = myArray.Where(i => i % 2 == 0).Count();
int count = evenNumbers.Count();
double average = myArray.Where(i => i % 2 == 0).Average();
int sum = myArray.Where(i => i % 2 == 0).Sum();
int min = myArray.Where(i => i % 2 == 0).Min();
int max = myArray.Where(i => i % 2 == 0).Max();
int first = myArray.Where(i => i % 2 == 0).First();
int last = myArray.Where(i => i % 2 == 0).Last();

```

### Concatenation 
```
var combinedEmployees = employees.Concat(employees2);
var combinedEmployees = employees
                    .Select(e => new { Name = e.LastName })
                    .Concat(people.Select(p => new { Name = p.LastName }));
 
```
### Skip and Take 
```
var newEmployees = employees.Skip(1);
var newEmployees = employees.Skip(20).Take(10);
```
### Distinct
```
var distinctArray = myArray.Distinct();
```







