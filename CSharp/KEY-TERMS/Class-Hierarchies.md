###  Inheritance 
- Use the ```base``` keyword to make a constructor invoke a parent class constructor as in the following code:
```
public class Employee : Person 
{    
  public Employee(string firstName, string lastName) : base(firstName, lastName)    
  {        
    ...    
  } 
}
``` 
-  Use the ```this``` keyword to make a constructor invoke another constructor in the same class as in the following code:
```
public class Person 
{    
  public string FirstName { get; set; }    
  public string LastName { get; set; }
  public Person(string firstName)    
  {        
    FirstName = firstName;    
  }
  public Person(string firstName, string lastName) : this(firstName)    
  {        
    LastName = lastName;    
  } 
}
