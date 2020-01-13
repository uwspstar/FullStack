# Grouping 
```
var employeesByState = from e in employees                          
                      group e by e.State;
foreach (var employeeGroup in employeesByState)     
{        
  Debug.WriteLine(employeeGroup.Key + ": " + employeeGroup.Count());
  foreach (var employee in employeeGroup)        
  {            
    Debug.WriteLine(employee.LastName + ", " + employee.State);        
  }    
} 
```
