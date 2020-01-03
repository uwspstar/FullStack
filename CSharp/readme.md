# C#
- Secrets https://blog.submain.com/app-config-basics-best-practices/  (App.Config: Basics and Best Practices)
- https://www.youtube.com/watch?v=-9b8NRqjUFM
- C# Coding Conventions https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions
- C# Walkthroughs https://docs.microsoft.com/en-us/dotnet/csharp/walkthroughs

### Higher Order Function
### tuples
### dynamic
```
C# 4 introduces a new type, dynamic. The type is a static type, 
but an object of type dynamic bypasses static type checking.
no compiler error is reported. 
However, the error does not escape notice indefinitely. 
It is caught at run time and causes a run-time
```
### try/catch
- A try/catch block has some performance cost, so you'll only want to use them when you really need them
- Avoid using an empty catch block, like catch (Exception) {} , which does not take appropriate action to
expose or handle an error. An empty or non-informative catch block can hide exceptions and can make
your code more difficult to debug instead of easier.

### Properties Vs Fields In C#
```
Fields are normal variable members of a class. 
Properties are an abstraction to get and set their values.
Fields are normal variable members of a class. 
Generally, you should declare your fields as private, 
then use Properties to get and set their values.
```
### ++x and x++
```
++x i.e. pre-increment operator uses the principle ‘change-then-use’ 
while, x++ i.e. post-increment operator uses the principle ‘use-then-change’.
https://aws.amazon.com/certification/certification-prep/
// us JS as example
let arr = [ 0, 1, 2 ]
let k = 0;
arr[k++] = -1;
k = 1;
arr = [-1, 1, 2]
```
### Which statements are true for an int/Integer built in .NET data type? ```AC```
``` 
- It supports bitwise operators.
- On a 64bit system, it can contain the number 2^48.
- The ToString method can be used for formatting a numerical value.
- The expression a/b will return infinity if a has value 1 and b has value 0.
- It is unsigned by default and does not support negative values.
```
### Inheritance.NET OOP ```BCDF```
A class inherits a base class and it overrides a method from that base class. 
``` 
- The base class can be sealed in C# (NotInheritable in Visual Basic).
- The base class can be abstract in C# (MustInherit in Visual Basic).
- The method from the base class can be abstract in C# (MustOverride in Visual Basic).
- The method from the base class can be virtual in C# (Overridable in Visual Basic).
- The method from the base class does not need to have any modifier.
- The method from the base class can have only a protected modifier.
- The method in the overriding class must have the override (Overrides in Visual Basic). 
```
###  Crab Inheritance.NET OOP PUBLIC ```AD```
```
public class Crab 
{
    public virtual string PinchClaws()
    {
        return "clap clap";
    }
}

public class CoconutCrab : Crab
{
    public override string PinchClaws()
    {
        return "CLAP CLAP";
    }
}
 
- Calling PinchClaws() on an instance of CoconutCrab will return "CLAP CLAP".
- Calling PinchClaws() on an instance of Crab will return "CLAP CLAP".
- Casting an instance of CoconutCrab into Crab and then calling the PinchClaws method will return "clap clap".
- Casting an instance of Crab into CoconutCrab will throw an exception
```
### Parsing XML.NET CLASS LIBRARY PUBLIC ```BCD```
```
Which statements are true for the .NET technologies you can use to process XML data?
a. System.Xml.XmlReader.Create(Stream stream) builds an internal model that holds the whole XML file.
b. System.Xml.Linq.XElement can be used to modify the existing XML file.
c. Using System.Xml.Serialization.XmlSerializer can be used when the XML stream is expected to conform to a known XML schema.
d. System.Xml.Linq.XElement.Load(Stream stream) builds an internal model that holds the whole XML file.
e. Executing System.Xml.Linq.XElement.Load(Stream stream) is faster than executing System.Xml.XmlReader.Create(Stream stream).
```
###  is vs as ```is (return true or false) vs as (return obj)```
```
we use the "is" operator to check the object type. 
If two objects are of the same type, it returns true, else it returns false.

The "as" operator behaves in similar way as the "is" operator. 
The only difference is it returns the object 
if both are compatible to that type. Else it returns a null.

```
### partial classes
### Are Private Class -label Variables Inherited ?
```
Yes, but it is not accessible.
we generally know that they are inherited but not accessible.
```
### Nullable<>
```
Any data type can be declared nullable type with the help of operator "?". 
int? i = null;  
"var" is not compatible with nullable types. 
if you declare the following, you will get an error.

var? i = null;  // Error
```
### Throw Exception vs Throw
```
*** The best practice to use throw instead of throw(ex)

The basic difference is that the Throw exception overwrites the stack trace 
and this makes it hard to find the original code line number that has thrown the exception.

Throw basically retains the stack information and adds to the stack information in the exception that it is thrown.

Let us see what it means rather speaking so many words to better understand the differences. 
I am using a console application to easily test and see how the usage of the two differ in their functionality.

using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace TestingThrowExceptions {  
    class Program {  
        public void ExceptionMethod() {  
            throw new Exception("Original Exception occurred in ExceptionMethod");  
        }  
        static void Main(string[] args) {  
            Program p = new Program();  
            try {  
                p.ExceptionMethod();  
            } catch (Exception ex) {  
                throw ex;  
            }  
        }  
    }  
}  
Now run the code by pressing the F5 key of the keyboard and see what happens. 
It returns an exception and look at the stack trace:

So you can see in first image we have got full stack trace information 
where the actual exception called at line 22 and again rethrow at line 15
While in the another screenshot you can see there is only information about line 15. 
It does not show full stack trace.So when you use throw(ex) it will reset stack trace.

**** So it’s always best practice to use throw instead of throw(ex).
```
### Parsing XML. ```CDE```
```
- System.Xml.XmlReader.Create(Stream stream) builds an internal model that holds the whole XML file.
- System.Xml.Linq.XElement can be used to modify the existing XML file.
- Using System.Xml.Serialization.XmlSerializer can be used when the XML stream is expected to conform to a known XML schema.
- System.Xml.Linq.XElement.Load(Stream stream) builds an internal model that holds the whole XML file.
- Executing System.Xml.Linq.XElement.Load(Stream stream) is faster than executing System.Xml.XmlReader.Create(Stream stream).
```
### Recycling Bin.NET LINQ ```AD```
```
public class RecyclingBin
{
    protected List<string> recyclables = new List<string>();
    
    public void Add(string recyclable)
    {
        if (recyclable.Split(' ').Length > 1)
        {
            recyclables.Add(recyclable);
        }
    }
    
    public List<IGrouping<string, string>> SortRecyclables()
    {
        return recyclables.GroupBy(recyclable => recyclable.Split(' ').First()).ToList();
    }
}
 
- One of the groups returned from SortRecyclables will have "metal" as its key and will contain "metal bar" and "metal pipe".
- One of the groups returned from SortRecyclables will have "wire" as its key and will contain "copper wire".
- The List returned from SortRecyclables will not be evaluated in the SortRecyclables method.
- The Add method will add a new recyclable only if it contains a space.
```
### Method overloading vs override
```
we can use a method with the same name but different signatures. 
Object Pool is a container of objects that are ready for use. 
Whenever there is a request for a new object, the pool manager will take the request 
and it will be served by allocating an object from the pool.
```
### Object Pooling in .NET
```
Object Pooling in .NET allows objects to keep in the memory pool 
so the objects can be reused without recreating them.
```
### Access Modifiers ```6 different types of Access Modifiers```

- 1) public	There are no restrictions on accessing public members.
- 2) private	Access is limited to within the class definition. 
This is the *** default access modifier type *** if none is formally specified
- 3) protected	Access is limited to within the class definition and any class that ```inherits``` from the class
- 4) internal	Access is limited exclusively to classes defined within the ```current project assembly```
- 5) protected internal	Access is limited to the ``current assembly```  and types derived from the containing class. 
All members in current project and all members in derived class can access the variables.
- 6) private protected	Access is limited to the containing class or types derived 
from the containing class within the current assembly.

### IEnumerable<> ```IEnumerable<T>```
### IEnumerable and IQueryable
```
IEnumerable

Is the parent interface for all non-generic collections 
in System.Collections namespace like ArrayList, HastTable etc. t
hat can be enumerated. 
For the generic version of this interface as IEnumerable<T> 
which a parent interface of all generic collections class 
in System.Collections.Generic namespace like List<> and more. 

IQueryable

As per MSDN IQueryable interface is intended for implementation by *** query providers. *** 
It is only supposed to be implemented by providers that also implement IQueryable<T>. 
If the provider does not also implement IQueryable<T>, 
the standard query operators cannot be used on the provider's data source.

The IQueryable interface inherits the IEnumerable interface 
so that if it represents a query, the results of that query can be enumerated. 
Enumeration causes the expression tree associated with an IQueryable object to be executed. 
The definition of "executing an expression tree" is specific to a query provider. 
For example, it may involve translating the expression tree to an appropriate query language for the underlying data source. Queries that do not return enumerable results are executed when the Execute method is called.

```
### sealed classes ```the class cannot be inherited```
```
Sealed classes are used to restrict the inheritance feature of object oriented programming. 
Once a class is defined as a sealed class, the class cannot be inherited.

A sealed class, in C#, 
is a class that cannot be inherited by any class but can be instantiated. 
The design intent of a sealed class is to indicate that 
the class is specialized and there is no need to extend it to 
provide any additional functionality through inheritance to override its behavior

```
### example for polymorphism
- overloading
### virtual method ```created in the base class that can be overridden in the derived class```
```
A virtual method is a method that can be redefined in derived classes. 
A virtual method has an implementation in a base class as well as derived the class.
It is used when a method's basic functionality is the same 
but sometimes more functionality is needed in the derived class. 
A virtual method is created in the base class that can be overridden in the derived class. 
We create a virtual method in the base class using the virtual keyword 
and that method is overridden in the derived class using the override keyword.

When a method is declared as a virtual method in a base class 
then that method can be defined in a base class 
and it is optional for the derived class to override that method. 
The overriding method also provides more than one form for a method. 
Hence it is also an example for polymorphism.

When a method is declared as a virtual method in a base class 
and that method has the same definition in a derived class 
then there is no need to override it in the derived class. 
But when a virtual method has a different definition in the base class 
and the derived class then there is a need to override it in the derived class.

When a virtual method is invoked, 
the run-time type of the object is checked for an overriding member. 
The overriding member in the most derived class is called, 
which might be the original member, if no derived class has overridden the member.

Virtual Method

By default, methods are non-virtual. We can't override a non-virtual method.
*** We can't use the virtual modifier with the static, abstract, private or override modifiers.
```
### delegate vs events
```
A delegate is a solution for situations in which you want to pass methods around to other methods

An event is just a wrapper for a multicast delegate.
Adding a public event to a class is almost the same as adding a public multicast delegate field.

In both cases, subscriber objects can register for notifications, 
and in both cases the publisher object can send notifications to the subscribers. 

However, a public multicast delegate has the undesirable property 
that external objects can invoke the delegate, 
something we’d normally want to restrict to the publisher. 
Hence events – an event adds public methods to the containing class to add and remove receivers, 
but does not make the invocation mechanism public.
```
### using ```using Directive & Using Statement```
```
There are two ways to use the using keyword in C#. 

1) using Directive
Generally we use the using keyword to add namespaces in code-behind and class files. 
Then it makes available all the classes, interfaces and abstract classes 
and their methods and properties in the current page. 


2) Using Statement
This is another way to use the using keyword in C#. 
It plays a vital role in *** improving performance in Garbage Collection. *** 
```
### serialization

### ref & out parameters? ```ref must be initialized```

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
### struct vs class ```struct is value type on stack, class is reference type in heap```

- Struct
    ```
    The struct is value type in C# and it inherits from System.Value Type.
    Struct is usually used for smaller amounts of data.
    Struct can’t be inherited to other types.
    A structure can't be abstract.
    No need to create object by new keyword.
    Do not have permission to create any default constructor.
```
- Class
    ```
    The class is reference type in C# and it inherits from the System.Object Type.
    Classes are usually used for large amounts of data.
    Classes can be inherited to other class.
    A class can be abstract type.
    We can create a default constructor.
```
### Boxing vs Unboxing
- boxing ```The process of converting from a value type to a reference type is called boxing.```
- unboxing ```The process of converting from a reference type to a value type is called unboxing.```

### C# is managed code 
```
because Common language runtime can compile C# code to Intermediate language.
```
###  directcast and ctype
- DirectCast 
    ```
    DirectCast is used to convert the type of an object 
    that requires the run-time type to be the same as the specified type in DirectCast.
    ```
- Ctype
    ```
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
### Hashtable
    ```
    A Hashtable is a collection that stores (Keys, Values) pairs. 
    Here, the Keys are used to find the storage location 
    and is immutable and cannot have duplicate entries in a Hashtable
    ```
### LINQ
    ```
    LINQ stands for Language Integrated Query. 
    LINQ is a data querying methodology which provides querying capabilities to .NET languages 
    with a syntax similar to a SQL query
    ```
### anonymous Data in LINQ  ```(var)```
    ```
    var anonymousData = from pl in data    
        select new {    
            pl.FirstName, pl.LastName    
        }; 
    ```
### dispose vs finalize
- The finalize and dispose, both methods are used to free unmanaged resources. 
```
Finalize used to free unmanaged resources those are not in use 
like files, database connections in application domain and more, 
held by an object before that object is destroyed.

In the Internal process it is called by Garbage Collector 
and can’t called manual by user code or any service.
Finalize belongs to System.Object class.
Implement it when you have unmanaged resources in your code,
and make sure that these resources are freed when the Garbage collection happens.
Dispose

Dispose is also used to free unmanaged resources those are not in use 
like files, database connections in Application domain at any time.
Dispose explicitly it is called by manual user code.
If we need to dispose method so must implement that class by IDisposable interface.
It belongs to IDisposable interface.
Implement this when you are writing a custom class that will be used by other users.
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
### extension method 
```
An extension method is a special kind of static method, 
but they are called as if they were instance methods on the extended type
```
### Interface vs Abstract Class
```
A class can implement any number of interfaces but a subclass can at most use only one abstract class.
An abstract class can have non-abstract methods (concrete methods) 
while in case of interface all the methods has to be abstract.
An abstract class can declare or use any variables while an interface is not allowed to do so.
In an abstract class all data member or functions are private by default 
while in interface all are public, we can’t change them manually.
In an abstract class we need to use abstract keyword to declare abstract methods 
while in an interface we don’t need to use that.
An abstract class can’t be used for multiple inheritance while interface can be used as multiple inheritance.
An abstract class use constructor while in an interface we don’t have any type of constructor.
```
### enum
### Array vs ArrayList
```
ArrayList can have different type
```

### Abstract Class vs Interface
- Since multiple inheritance in C Sharp is deprecated
```
One by one the main mechanical difference is that 
an abstract class can have a default implementation
whereas an interface is just a bunch of member declarations.

A client couldn't do that with an abstract class instead of an interface.
Since multiple inheritance in C Sharp is deprecated.

```
### ref vs out ```ref with value, out not```

### this vs static method ```We can't use this in a static method```
```
We can't use this in a static method 
because the keyword 'this' returns a reference to the current instance of the class containing it. 
Static methods (or any static member) do not belong to a particular instance. 
```
### string vs StringBuilder
```
String

String is an immutable object. 
Immutable like when we create string object in code 
so we cannot modify or change that object in any operations 
like insert new value, replace or append any value with existing value in string object, 
when we have to do some operations to change string simply it will 
dispose the old value of string object 
and it will create new instance in memory for hold the new value in string object like,

It’s an immutable object that hold string value.
Performance wise string is slow because its’ create a new instance to override or change the previous value.
String belongs to System namespace.
StringBuilder

System.Text.Stringbuilder is mutable object 
which also hold the string value, 
mutable means once we create a System.Text.Stringbuilder object 
we can use this object for any operation like insert value in existing string 
with insert functions also replace or append without 
creating new instance of System.Text.Stringbuilder for every time 
so it’s use the previous object so it’s work fast as compare than System.String. 

StringBuilder is a mutable object.
Performance wise StringBuilder is very fast because it will use same instance of StringBuilder object to perform any operation like insert value in existing string.
StringBuilder belongs to System.Text.Stringbuilder namespace.
```
### What’s the difference between the Array.CopyTo() and Array.Clone()?
```
The Array.Clone() method creates a shallow copy of an array. 
A shallow copy of an Array copies only the elements of the Array, 
whether they are reference types or value types, 
but it does not copy the objects that the references refer to. 
The references in the new Array point to the same objects 
that the references in the original Array point to.

The CopyTo() static method of the Array class copies a section of an array to another array. 
The CopyTo method copies all the elements of an array to another one-dimension array.
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

### Attribute
```
An attributes is a declarative tag 
that is used to convey information about the behaviors of various elements
(classes, methods, assemblies, structures, enumerators, etc). 
it is access at compile time or run-time. 
Attributes are declare with a square brackets []
[Obsolete(“Don’t use Old method, please use New method”, true)]

//For example consider the bellow class. If we call the old method it will through error message.
public class myClass
{
    [Obsolete("Don't use Old method, please use New method", true)]

    public string Old() { return "Old"; }

    public string New() { return "New"; }

}

myClass omyClass = new myClass();

omyClass.Old();
```

### Why Attributes Are Used?
```
In a program the attributes are used for adding metadata, 
like compiler instruction or other information (comments, description, etc).
```
### The Types Of Attributes?

- the pre-defined attributes
- custom built attributes

### Pre-define attributes are three types:
 - AttributeUsage 
 - Conditional
 - Obsolete // This marks a program that some entity should not be used.

### Custom Attributes
```to store declarative information and can be retrieved at run-time.```

### Reflection
```
Reflection is a process 
by which a computer program can monitor and modify its own structure and behavior. 
It is a way to explore the structure of assemblies at run time 
(classes, resources, methods). 
Reflection is the capability to find out the information 
about objects, metadata, and application details (assemblies) at run-time. 

//We need to include System.Reflection namespace to perform reflections in C#. 

public class MyClass
{
    public virtual int Add(int numb1, int numb2)
    {                
        return numb1 + numb2;
    }
    public virtual int Subtract(int numb1, int numb2)
    {
        return numb1 - numb2;
    }
}

static void Main(string[] args)
{
    MyClass oMyClass = new MyClass();
    
    //Type information.
    Type oMyType = oMyClass.GetType();
    
    //Method information.
    MethodInfo oMyMethodInfo = oMyType.GetMethod("Subtract");
    
    Console.WriteLine("nType information:" + oMyType.FullName);
    Console.WriteLine("nMethod info:" + oMyMethodInfo.Name);            
    Console.Read();
}
```
### Why We Need Reflection In C#?
```
Reflections needed when we want to determine / inspect contents of an assembly. 
For example: at Visual Studio editor intelligence, 
when we type “.” (dot) before any object, it gives us all the members of the object. 
This is possible for Reflection.

Beside this we need reflection for the following purposes:

To view attribute information at run time
To view the structure of assemblies at run time (classes, resources, methods)
It allows dynamic/late binding to methods and properties
In serialization, it is used to serialize and de-serialize objects
In web service, it is used to create and consume SOAP messages and also to generate WSDL
Debugging tools can use reflection to examine the state of an object.
```
 
### Dynamic Keyword
```
The dynamic is a keyword
which was introduced in .NET 4.0. Computer programming languages
two types: strongly typed and dynamically typed. 

In strongly types all types checks are happened at compile time, 

*** in dynamic types all types of checks are happened at run time.

// For example consider the following code
dynamic x = "c#";
x++; // It will not provide error at compile time but will provide error at run time.

```
### constant vs readonly 
```
constant assign value at declarer and cannot change after assign
readonly assign value at runtime, and cannot change after assign
```

### When To Use Dynamic
```
The biggest practical use of the dynamic keyword is when we operate on MS Office.
```
### Reflection vs Dynamic?
```
Both Reflection and dynamic are used to operate on an object during run time. 
But they have some differences:

Dynamic uses reflection internally
Reflection can invoke both public and private members of an object. 

But dynamic can only invoke public members of an object
```
### Serialization vs De-serialization
```
When we want to transport an object through network 
then we need to convert the object into a stream of bytes. 
Serialization is a process to convert a complex objects into stream of bytes 
for storage (database, file, cache, etc) or transfer. 
Its main purpose is to save the state of an object.

De-serialization is the reverse process of 
creating an object from a stream of bytes to their original form.
```
### Types Of Serialization?
```
The types of Serializations are given bellow:

1  Binary Serialization
            In this process all the public, private, 
            read only members are serialized and convert into stream of bytes. 
            This is used when we want a complete conversion of our objects.
2  SOAP Serialization
           In this process only public members are converted into SOAP format. 
           This is used in web services.
3  XML Serialization
            In this process only public members are converted into XML. T
            his is a custom serialization. Required namespaces: System.Xml, System.Xml.Serialization.

```
### Serialization And Deserialization?

```
For example consider, we have a very complex object 
and we need XML format to show it on HTML page. 
Then we can create a XML file in the disk, 
writes all the necessary data on the XML file, 
and use it for the HTML page. 
But this is not good approach for large number of users. 
Extra space is required; 
anyone can see the XML file which creates security issue. 
We can overcome it by using XML serialization.
```
### Serialization?
```
Serialization is used in the following purposes:

To pass an object from on application to another
In SOAP based web services
To transfer data through cross platforms, cross devices

Serialization is used to save session state in ASP.NET applications, 
to copy objects to the clipboard in Windows Forms. 
It is also used to pass objects from one application domain to another. Web services uses serialization.
```
### Generics
```
the most powerful features introduced in C# 2.0. 
It is a type-safe data structure that allows us to write codes that works for any data types.

A generic class is a special kind of class that can handle any types of data. 
We specify the data types during the object creations of that class. 
It is declared with the bracket <>. 
For example consider the following Comparer class, 
which has a method that compare two value and returns as Boolean output.

Generic provides lot of advantages during programming. 
We should use generics for the following reasons:

It allows creating class, methods which are type-safe
It is faster. Because it reduce boxing/un-boxing
It increase the code performance
It helps to maximize code reuse, and type safety
```

### Collections
```
Sometimes we need to work with related objects for data storage and retrieval. 
There are two ways to work with related objects.
One is array and another one is collections. 
Arrays are most useful for creating and working with a fixed number of strongly-typed objects. 
Collections are enhancement of array which provides a more flexible way to work with groups of objects.

The Microsoft .NET framework provides specialized classes for data storage and retrieval. 
Collections are one of them. 
Collection is a data structure that holds data in different ways. 
Collections are two types. 
One is standard collections, which is found under System.Collections namespace 
and another one is generic collections, which is found under System.Collections.Generic namespace.
The generic collections are more flexible and preferable to work with data.

Some commonly used collections under System.Collections namespace are given bellow:

ArrayList
SortedList
Hashtable
Stack
Queue
BitArray
```
 
### Unsafe Code?

```
In order to maintain security and type safety, 
C# does not support pointer generally. 
But by using unsafe keyword we can define an unsafe context 
in which pointer can be used. 
The unsafe code or unmanaged code is a code block that uses a pointer variable. 
In the CLR, unsafe code is referred to as unverifiable code. 
In C#, the unsafe code is not necessarily dangerous. 
The CLR does not verify its safety. 
The CLR will only execute the unsafe code if it is within a fully trusted assembly. 
If we use unsafe code, it is our own responsibility to ensure 
that the code does not introduce security risks or pointer errors.

Some properties of unsafe codes are given bellow:

We can define Methods, types, and code blocks as unsafe
In some cases, unsafe code may increase the application’s performance by removing array bounds checks
Unsafe code is required in order to call native functions that require pointers
Using unsafe code brings security and stability risks
In order to compile unsafe code, the application must be compiled with /unsafe

an Unsafe Code Be Executed In Untrusted Environment?

Unsafe code cannot be executed in an un-trusted environment. 
For example, we cannot run unsafe code directly from the Internet.

For compiling unsafe code, 
we have to specify the /unsafe command-line switch with command-line compiler.

For example: 
to compile a program named “myClass.cs” containing unsafe code the command line command is:

csc /unsafe myClass.cs

In Visual Studio IDE at first we need to enable use of unsafe code in the project properties.

The steps are given bellow:

Open project properties
Click on the Build tab
Select the option “Allow unsafe code”
```
### Pointer

```
Pointer is a variable that stores the memory address of another variable. Pointers in C# have the same capabilities as in C or C++.

Some examples are given bellow:

int    *i    // pointer of an integer
float  *f    // pointer to a float
double *d    // pointer to a double
char   *ch   // pointer to a character
```

### How Can We Sort The Elements Of The Array In Descending Order
```
arr.Sort ().Reverse() Methods.
```
### Can We Store Multiple Data Types In System.array

```
No., but Arraylist can
```
 
### System.array.copyto() vs System.array.clone()
```
System.Array.CopyTo()-->
It require a destination array to be existed before 
and it must be capable to hold all the elements in the source array 
from the index that is specified to copy from the source array.

System.Array.Clone()-->
It does not require the destination array to be existed as it creates a new one from scratch.

*** These both are used as a shallow copy.
```
### String vs Stringbuilder
```
StringBuilder is more efficient than string.
String :- It is Immutable and resides within System Namespace.
StringBuilder:-It is mutable and resides System.Text Namespace.
```
### What Is Class Sortedlist Underneath
```
It is a Hash Table.
```

### What Is The .net Data Type That Allow The Retrieval Of Data By A Unique Key 

```
Hash Table
```

### Is Finally Block Get Executed If The Exception Is Not Occured ```Yes```

### Can Multiple Catch () Block Get Executed If The Exception Is Not Occured ?

```
No, Once the proper catch code fires off ,
the control is transferred to the finally block(if any),
and the whatever follows the finally block.
```

### Multicast Delegate 

```
The Multicast delegate is a delegate that points to and eventually fires off several methods.
```
### The Ways To Deploy An Assembly
```
An MSI Installer
A CAB archive
XCopy command
```

### What Is The Dll Hell Problem Solved In .net 

```
In .NET, Assembly versioning allows the application to specify
not only the library it needs to run ,
but also the version of the assembly.

```
### What Is A Satellite Assembly ?

```
When we write the code, 
a  multicultural or multilingual application in .NET 
and want to distribute the core application separately from the localized modules,
the localized assemblies that modify the core application ,that is known  as Satellite assembly.
```
How Do We Inherit From A Class In C# ?
```
we use a colon (:) and then the name of the base class.
```

### Does C# Support Multiple Inheritance ?
```
No, we use interface for this purpose.
```
### What Is The Top .net Class ? ```System.Object```

### How Does Method Overloading Different From Overriding ?

```
A method overloading simply involves having a method with the same name within the class. 
whereas in method overriding we can change method behaviour for a derived class.
```

### Can We Override Private Virtual Method ? ```No```

### Can We Declare The Override Method Static While The Original Method Is Non Static ? ```No.```
### What Is An Interface Class

```
This is an abstract class with public abstract methods , 
all of which must be implemented in the inherited classes.
```
### Can We Inherit Multiple Interfaces ? ```Yes.```

### Can We Allow Class To Be Inherited ,but Prevent The Method From Being Overridden ?

```
Yes, first create class as public and make it's method sealed.
```

### What Is Signature Used For Overloaded A Method ?
```
Use different data types
Use different number of parameters
Use different order of parameters
```
### An Interface vs Abstract Class ?
```
In an interface, all methods must be abstract but in abstract class some methods can be concrete.
In interface No accessibility modifiers are alloweded 
but in abstract class a accessibility modifier are alloweded.
```
### System.IO namespace
```
The System.IO namespace provides four classes that allow you to manipulate individual files, 
as well as interact with a machine directory structure. 
The Directory and File directly extends System.Object 
and supports the creation, copying, moving and deletion of files 
using various static methods. 
They only contain static methods and are never instantiated. 
The FileInfo and DirecotryInfo types are derived from the abstract class FileSystemInfo type 
and they are typically, employed for obtaining the full details of a file or directory 
because their members tend to return strongly typed objects. 
They implement roughly the same public methods as a Directory and a File 
but they are stateful and the members of these classes are not static.
```
### Reflection
```
Reflection is the process of runtime type discovery 
to inspect metadata, CIL code, late binding and self-generating code. 
At run time by using reflection, 
we can access the same "type" information as displayed 
by the ildasm utility at design time. 
The reflection is analogous to reverse engineering i
n which we can break an existing *.exe or *.dll assembly 
to explore defined significant contents information, 
including methods, fields, events and properties.

```
###  What are the differences between IEnumerable and IQueryable?
```
IQueryable interface is intended for implementation by query providers. 
It is only supposed to be implemented by providers that also implement IQueryable<T>. 
If the provider does not also implement IQueryable<T>, 
the standard query operators cannot be used on the provider's data source.
```
### REST vs RESTful
- REST is acronym for REpresentational State Transfer. It is architectural style
### Comparing SOAP vs REST APIs
- SOAP – Simple Object Access Protocol : defines a very strongly typed messaging framework which relies heavily on XML and schemas. 
- REST -REpresentational State Transfer : is an architectural style which makes use of existing and widely adopted technologies, specifically HTTP, and does not create any new standards.

### HTTP methods
- HTTP METHOD	CRUD	ENTIRE COLLECTION (E.G. /USERS)	SPECIFIC ITEM (E.G. /USERS/123)
- POST	```Create```	201 (Created), ‘Location’ header with link to /users/{id} containing new ID.	Avoid using POST on single resource
- GET	Read	200 (OK), list of users. Use pagination, sorting and filtering to navigate big lists.	200 (OK), single user. 404 (Not Found), if ID not found or invalid.
- PUT	```Update/Replace```	404 (Not Found), unless you want to update every resource in the entire collection of resource.	200 (OK) or 204 (No Content). Use 404 (Not Found), if ID not found or invalid.
- PATCH	```Partial Update/Modify```	404 (Not Found), unless you want to modify the collection itself.	200 (OK) or 204 (No Content). Use 404 (Not Found), if ID not found or invalid.
- DELETE	Delete	404 (Not Found), unless you want to delete the whole collection — use with caution.	200 (OK). 404 (Not Found), if ID not found or invalid.

