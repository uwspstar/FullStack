### Tuples with LINQ
```
static void UsingAnonymousTypes() 
{  
  var racerNamesAndStarts = Formula1.GetChampions()    
  .Where(r => r.Country == "Italy")    
  .OrderByDescending(r => r.Wins)    
  .Select(r => new    {      r.LastName,      r.Starts    });

  foreach (var r in racerNamesAndStarts)  
  {    
    Console.WriteLine($"{r.LastName}, starts: {r.Starts}");  
  } 
} 
```
- ``` Changing the curly brackets to parentheses creates a tuple``` with the fields LastName and Starts
```
static void UsingTuples() {  var racerNamesAndStarts = Formula1.GetChampions()    .Where(r => r.Country == "Italy")    .OrderByDescending(r => r.Wins)    .Select(r =>     (      r.LastName,      r.Starts));
  foreach (var r in racerNamesAndStarts)  {    Console.WriteLine($"{r.LastName}, starts: {r.Starts}");  } }
```
- Tuples can have a performance advantage
```
With anonymous types, a class is created, 
and thus instances of this class are allocated on the heap and need to be collected from the garbage collector. 
By comparison, tuples are value types and stored on the stack. 
Tuples can have a performance advantage.
```
