# C#
### ++x and x++
```
++x i.e. pre-increment operator uses the principle ‘change-then-use’ 
while, x++ i.e. post-increment operator uses the principle ‘use-then-change’.
```

### delegate vs events
```
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
### struct vs class
```
Struct

The struct is value type in C# and it inherits from System.Value Type.
Struct is usually used for smaller amounts of data.
Struct can’t be inherited to other types.
A structure can't be abstract.
No need to create object by new keyword.
Do not have permission to create any default constructor.

Class

The class is reference type in C# and it inherits from the System.Object Type.
Classes are usually used for large amounts of data.
Classes can be inherited to other class.
A class can be abstract type.
We can create a default constructor.
```
### Boxing vs Unboxing
```
The process of converting from a value type to a reference type is called boxing.
The process of converting from a reference type to a value type is called unboxing.

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
### When To Use Dynamic

Answer :

The biggest practical use of the dynamic keyword is when we operate on MS Office.


 
Question 9. What Is The Difference Between Reflection And Dynamic?

Answer :

Both Reflection and dynamic are used to operate on an object during run time. But they have some differences:

Dynamic uses reflection internally
Reflection can invoke both public and private members of an object. But dynamic can only invoke public members of an object
C & Data Structures Interview Questions
Question 10. What Is Serialization?

Answer :

When we want to transport an object through network then we need to convert the object into a stream of bytes. Serialization is a process to convert a complex objects into stream of bytes for storage (database, file, cache, etc) or transfer. Its main purpose is to save the state of an object.

De-serialization is the reverse process of creating an object from a stream of bytes to their original form.

ASP.NET Tutorial
Question 11. What Are The Types Of Serialization?

Answer :

The types of Serializations are given bellow:

1  Binary Serialization
            In this process all the public, private, read only members are serialized and convert into stream of bytes. This is used when we want a complete conversion of our objects.
2  SOAP Serialization
           In this process only public members are converted into SOAP format. This is used in web services.
3  XML Serialization
            In this process only public members are converted into XML. This is a custom serialization. Required namespaces: System.Xml, System.Xml.Serialization.

Windows Presentation Foundation(WPF) Interview Questions
Question 12. Why Serialization And Deserialization?

Answer :

For example consider, we have a very complex object and we need XML format to show it on HTML page. Then we can create a XML file in the disk, writes all the necessary data on the XML file, and use it for the HTML page. But this is not good approach for large number of users. Extra space is required; anyone can see the XML file which creates security issue. We can overcome it by using XML serialization.


 
C#. NET Interview Questions
Question 13. When To Use Serialization?

Answer :

Serialization is used in the following purposes:

To pass an object from on application to another
In SOAP based web services
To transfer data through cross platforms, cross devices
Windows Presentation Foundation(WPF) Tutorial
Question 14. Give Examples Where Serialization Is Used?

Answer :

Serialization is used to save session state in ASP.NET applications, to copy objects to the clipboard in Windows Forms. It is also used to pass objects from one application domain to another. Web services uses serialization.


 
Question 15. What Is Generics?

Answer :

Generics are the most powerful features introduced in C# 2.0. It is a type-safe data structure that allows us to write codes that works for any data types.

Windows Communication Foundation (WCF) Interview Questions
Question 16. What Is A Generic Class?

Answer :

A generic class is a special kind of class that can handle any types of data. We specify the data types during the object creations of that class. It is declared with the bracket <>. For example consider the following Comparer class, which has a method that compare two value and returns as Boolean output.

public class Comparer

{

    public bool Compare(Unknown t1, Unknown t2)

  {  

         if (t1.Equals(t2))

      {

            return true;

        }

        else

        {

            return false;

        }

    }

}

Comparer oComparerInt = new Comparer();

Console.WriteLine(oComparerInt.Compare(10, 10));

Comparer oComparerStr = new Comparer();

Console.WriteLine(oComparerStr.Compare("jdhsjhds", "10"));


 
Windows Communication Foundation (WCF) Tutorial
Question 17. Why We Should Use Generics?

Answer :

Generic provides lot of advantages during programming. We should use generics for the following reasons:

It allows creating class, methods which are type-safe
It is faster. Because it reduce boxing/un-boxing
It increase the code performance
It helps to maximize code reuse, and type safety
C and C++ Interview Questions
Question 18. What Is Collections In C#?

Answer :

Sometimes we need to work with related objects for data storage and retrieval. There are two ways to work with related objects. One is array and another one is collections. Arrays are most useful for creating and working with a fixed number of strongly-typed objects. Collections are enhancement of array which provides a more flexible way to work with groups of objects.

The Microsoft .NET framework provides specialized classes for data storage and retrieval. Collections are one of them. Collection is a data structure that holds data in different ways. Collections are two types. One is standard collections, which is found under System.Collections namespace and another one is generic collections, which is found under System.Collections.Generic namespace.The generic collections are more flexible and preferable to work with data.

Some commonly used collections under System.Collections namespace are given bellow:

ArrayList
SortedList
Hashtable
Stack
Queue
BitArray

 
C Interview Questions
Question 19. What Is Unsafe Code?

Answer :

In order to maintain security and type safety, C# does not support pointer generally. But by using unsafe keyword we can define an unsafe context in which pointer can be used. The unsafe code or unmanaged code is a code block that uses a pointer variable. In the CLR, unsafe code is referred to as unverifiable code. In C#, the unsafe code is not necessarily dangerous. The CLR does not verify its safety. The CLR will only execute the unsafe code if it is within a fully trusted assembly. If we use unsafe code, it is our own responsibility to ensure that the code does not introduce security risks or pointer errors.

Question 20. What Are The Properties Of Unsafe Code?

Answer :

Some properties of unsafe codes are given bellow:

We can define Methods, types, and code blocks as unsafe
In some cases, unsafe code may increase the application’s performance by removing array bounds checks
Unsafe code is required in order to call native functions that require pointers
Using unsafe code brings security and stability risks
In order to compile unsafe code, the application must be compiled with /unsafe

 
C# OOPS Interview Questions
Question 21. Can Unsafe Code Be Executed In Untrusted Environment?

Answer :

Unsafe code cannot be executed in an un-trusted environment. For example, we cannot run unsafe code directly from the Internet.

Question 22. How To Compile Unsafe Code?

Answer :

For compiling unsafe code, we have to specify the /unsafe command-line switch with command-line compiler.

For example: to compile a program named “myClass.cs” containing unsafe code the command line command is:

csc /unsafe myClass.cs

In Visual Studio IDE at first we need to enable use of unsafe code in the project properties.

The steps are given bellow:

Open project properties
Click on the Build tab
Select the option “Allow unsafe code”

 
Question 23. What Is Pointer?

Answer :

Pointer is a variable that stores the memory address of another variable. Pointers in C# have the same capabilities as in C or C++.

Some examples are given bellow:

int    *i    // pointer of an integer
float  *f    // pointer to a float
double *d    // pointer to a double
char   *ch   // pointer to a character
C# Developer Multi Threading Interview Questions
Question 24. Should I Use Unsafe Code In C#?

Answer :

In C#, pointer is really used and Microsoft disengaged to use it. But there are some situations that require pointer. We can use pointer if required at our own risk. Some sonorous are given bellow:

To deal with existing structures on disk
Some advanced COM or Platform Invoke scenarios that involve pointer
To performance critical codes

 
ASP.NET Interview Questions
Question 25. How Can We Sort The Elements Of The Array In Descending Order ?

Answer :

For This,First we call the Sort () method and then call Reverse() Methods.

Question 26. Can We Store Multiple Data Types In System.array ?

Answer :

No.


 
Question 27. What Is The Difference Between The System.array.copyto() And System.array.clone() ?

Answer :

System.Array.CopyTo()-->It require a destination array to be existed before and it must be capable to hold all the elements in the source array from the index that is specified to copy from the source array.

System.Array.Clone()-->It does not require the destination array to be existed as it creates a new one from scratch.

Note-These both are used as a shallow copy.

C & Data Structures Interview Questions
Question 28. What Is Difference Between String And Stringbuilder ?

Answer :

StringBuilder is more efficient than string.

String :- It is Immutable and resides within System Namespace.

StringBuilder:-It is mutable and resides System.Text Namespace.

Question 29. What Is Class Sortedlist Underneath?

Answer :

It is a Hash Table.

Question 30. What Is The .net Data Type That Allow The Retrieval Of Data By A Unique Key ?

Answer :

Hash Table

Question 31. Is Finally Block Get Executed If The Exception Is Not Occured ?

Answer :

Yes.

Question 32. Can Multiple Catch () Block Get Executed If The Exception Is Not Occured ?

Answer :

No,Once the proper catch code fires off ,the control is transferred to the finally block(if any),and the whatever follows the finally block.

Question 33. What Is Multicast Delegate ?

Answer :

The Multicast delegate is a delegate that points to and eventually fires off several methods.

Windows Presentation Foundation(WPF) Interview Questions
Question 34. What Are The Ways To Deploy An Assembly ?

Answer :

An MSI Installer
A CAB archive
XCopy command
Question 35. What Is The Dll Hell Problem Solved In .net ?

Answer :

In .NET, Assembly versioning allows the application to specify not only the library it needs to run ,but also the version of the assembly.

Question 36. What Is A Satellite Assembly ?

Answer :

When we write the code, a  multicultural or multilingual application in .NET and want to distribute the core application separately from the localized modules,the localized assemblies that modify the core application ,that is known  as Satellite assembly.

Windows Communication Foundation (WCF) Interview Questions
Question 37. How Do We Inherit From A Class In C# ?

Answer :

In c#, we use a colon (:) and then the name of the base class.

Question 38. Does C# Support Multiple Inheritance ?

Answer :

No, we use interface for this purpose.

Question 39. Are Private Class -label Variables Inherited ?

Answer :

Yes, but it is not accessible.we generally know that they are inherited but not accessible.

Question 40. What Is The Implicit Name Of The Parameter That Gets Passed Into Class "set" Method ?

Answer :

Value and it's datatype(it depends whatever variable we are changing).

C and C++ Interview Questions
Question 41. What Is The Top .net Class ?

Answer :

System.Object

Question 42. How Does Method Overloading Different From Overriding ?

Answer :

A method overloading simply involves having a method with the same name within the class. whereas in method overriding we can change method behaviour for a derived class.

C# OOPS Interview Questions
Question 43. Can We Override Private Virtual Method ?

Answer :

No.

Question 44. Can We Declare The Override Method Static While The Original Method Is Non Static ?

Answer :

No.

Question 45. Can We Prevent My Class From Being Inherited And Becoming A Base Class From The Other Classes ?

Answer :

Yes.

Question 46. What Is An Interface Class ?

Answer :

This is an abstract class with public abstract methods , all of which must be implemented in the inherited classes.

Question 47. Can We Inherit Multiple Interfaces ?

Answer :

Yes.

Question 48. Can We Allow Class To Be Inherited ,but Prevent The Method From Being Overridden ?

Answer :

Yes, first create class as public and make it's method sealed.

Question 49. What Is Signature Used For Overloaded A Method ?

Answer :

Use different data types
Use different number of parameters
Use different order of parameters
Question 50. What Is The Difference Between An Interface And Abstract Class ?

Answer :

In an interface, all methods must be abstract but in abstract class some methods can be concrete.In interface No accessibility modifiers are alloweded but in abstract class a accessibility modifier are alloweded.
