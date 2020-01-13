# Linq anonymous type
```
Now suppose that you needed to return the FirstName and LastName properties. 
The following query creates an anonymous type that contains just a FirstName and LastName property. 
An anonymous type is an object with read-only properties that is not explicitly declared.

var names = from p in people          
  select new { p.FirstName, p.LastName };
foreach (var name in names) 
{    
  Debug.WriteLine(name.FirstName + ", " + name.LastName); 
}
  
var names = from p in people          
  select new { First = p.FirstName, Last = p.LastName };
foreach (var name in names) 
{    
  Debug.WriteLine(name.First + ", " + name.Last); 
}
  
```
