# Join
```
var employeeByState = from e in employees                          
                      join s in states                            
                      on e.StateId equals s.StateId                        
                      select new { e.LastName, s.StateName };
```
# Outer Join
```
var employeeByState = from e in employees                      
                      join s in states                        
                      on e.StateId equals s.StateId into employeeGroup                      
                      from item in employeeGroup.DefaultIfEmpty
                      ( 
                       new State {StateId = 0, StateName = ""}
                      )                    
                      select new { e.LastName, item.StateName };

```
