# Design Patterns

- Gang of four

```text
The four authors of the book famously know as Gang of four are the ones 
who brought the concepts of design patterns in their book “Elements of reusable Object-Oriented software”
```

## 3 types Design Patterns

- Creational design patterns
  - Singleton
  - Factory
  - Abstract Factory
- Structural design patterns
  - Adapter
  - Facade
  - Bridge
- Behavioural design patterns
  - Chain of Responsibility
  - Command and Interpreter
  
### Singleton

 ```text
 Singleton design pattern is used when we need to ensure that only one object of a particular class is Instantiated. 
 That single instance created is responsible to coordinate actions across the application.
 
 As part of the Implementation guidelines we need to ensure 
 that only one instance of the class exists by declaring all constructors of the class to be private.  
 Also, to control the singleton access we need to provide a static property 
 that returns a single instance of the object.
 ```

```text
private static Singleton instance = null;

public static Singleton GetInstance
{
  get
  {
      if (instance == null)
          instance = new Singleton();
      return instance;
  }
}
```
