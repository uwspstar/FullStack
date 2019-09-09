# C#

### serialization
### ref & out parameters?

```
An argument passed as ref must be initialized before passing to the method 
whereas out parameter needs not to be initialized before passing to a method.
```

### public, static and void

### Can multiple catch blocks be executed?
```
No, Multiple catch blocks can't be executed. 
Once the proper catch code executed, 
the control is transferred to the finally block 
and then the code that follows the finally block gets executed.
```

### C# is managed code 
```
because Common language runtime can compile C# code to Intermediate language.
```
###  directcast and ctype
```
DirectCast is used to convert the type of an object 
that requires the run-time type to be the same as the specified type in DirectCast.

Ctype is used for conversion where the conversion is defined between the expression and the type.
```
### singleton design pattern in C#?

```
In singleton pattern, 
a class can only have one instance and provides access point to it globally.
 
Public sealed class Singleton
{
  Private static readonly Singleton _instance = new Singleton();
}
```

###  "throw" and "throw ex"
```
What is difference between the "throw" and "throw ex" in .NET?

"Throw" statement preserves original error stack 
whereas "throw ex" have the stack trace from their throw point. 
It is always advised to use "throw" 
because it provides more accurate error information.
```
### Class vs Structure
```
- classes are reference types allocated on the heap
- structures are value types allocated on the stack.

*** The main difference between structures and classes is that 
- structures implemented this semantic of copying by value 
- classes implement as a semantic of copying by a reference.
```

### Array vs ArrayList

### Abstract Class vs Interface
- Since multiple inheritance in C Sharp is deprecated
```
One by one the main mechanical difference is that 
an abstract class can have a default implementation
whereas an interface is just a bunch of member declarations.

A client couldn't do that with an abstract class instead of an interface.
Since multiple inheritance in C Sharp is deprecated.

```

### Implementing "Dispose" Pattern

### Encapsulation and Information Hiding

### Encapsulation in Practice

### What is Interning?

### Constant vs Readonly
```
Const variables are resolved at compile time while Read-Only are resolved in runtime.
```

### Lock vs Monitor

### How to Rethrow Exceptions

### StringBuilder vs String
- Why string builder works so fast.
```
- Strings are immutable
- When we mutate a string variable every time we get a new instance of type String 

- String builder represents mutable string so mutating its instance.
- There are no thousands of allocations of new String instances.
```
