### Interfaces 
- By convention, interface names begin with I as in IComparable.
- A class can inherit from at most one parent class but can implement any number of interfaces. 
### IComparable
- An IComparable class provides a CompareTo method that determines the order of objects. 
### IComparer
- An IComparer class provides a Compare method that compares two objects and determines their ordering. 
### ICloneable 
- An ICloneable class provides a Clone method that returns a copy of an object.
### IEnumerable
- An IEnumerable class provides a GetEnumerator method that returns an IEnumerator object that has MoveNext and Reset methods for moving through a list of objects.
### yield
- A method can use the yield return statement to add objects to an IEnumerator result. 


###  Inheritance 
- A constructor can invoke at most one base class constructor or one same class constructor
- If a parent class has constructors, a child class’s constructors must invoke them directly or indirectly
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
