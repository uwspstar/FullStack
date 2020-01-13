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
```
var groupedNumbers = from i in myArray                        
                      group i by (i % 2 == 0 ? "Even" : "Odd");
foreach (var groupNumber in groupedNumbers)    
{        
  Debug.WriteLine(groupNumber.Key + ": " + groupNumber.Sum());        
  foreach(var number in groupNumber)        
  {            
    Debug.WriteLine(number);        
  }    
}
```
