# Grouping 
- In this sample there isn’t a select clause. 
- This is because a group clause returns an IGrouping<TKey, TElement> collection. 
- This object is a collection that contains a property for the key that the sequence is grouped by. 
- There are ```two foreach loops``` in this sample. 
- the IGrouping collection and writes the Key property and the Count of elements for the State to the Output window. 
- The inner foreach loop writes the elements that make up the group to the Output window.
- You can use a select clause when grouping sequences, but you must include an into clause in your group clause. 
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
- You can add logic in your group by clause to group by anything
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
- You can use a select clause when grouping sequences, but you must include an into clause in your group clause. 
```
var groupedNumbers = from i in myArray                        
                    group i by (i % 2 == 0 ? "Even" : "Odd") into g                       
                    select new { Key = g.Key, SumOfNumbers = g.Sum() };
 
```
