###  Inheritance 
- Use the base keyword to make a constructor invoke a parent class constructor as in the following code:
```
public class Employee : Person 
{    
  public Employee(string firstName, string lastName)  : base(firstName, lastName)    
  {        
    ...    
  } 
}
``` 
