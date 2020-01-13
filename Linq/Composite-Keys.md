# Composite Keys 
- A composite key contains multiple properties that you need for the purpose of a join. 
- To accomplish this, you create two anonymous types with the same properties and compare the anonymous types
```
var employeeByState = from e in employees                            
                      join h in hometowns                            
                      on 
                      new { City = e.City, State = e.State } 
                      equals                                
                      new { City = h.City, State = h.State }                            
                      select new { e.LastName, h.CityCode };
 
```
