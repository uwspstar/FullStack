# join
```
 var employeeByState = from e in employees                          
                       join s in states                            
                       on e.StateId equals s.StateId                        
                       select new { e.LastName, s.StateName };
 ```
