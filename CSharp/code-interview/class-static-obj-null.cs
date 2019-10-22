// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members

// Static methods can be overloaded but not overridden, 
// because they belong to the class, and not to any instance of the class.

// A non-static class can contain static methods, fields, properties, or events. 
// The static member is callable on a class even when no instance of the class has been created. 
// The static member is always accessed by the class name, not the instance name.
// Only one copy of a static member exists, regardless of how many instances of the class are created. 

// Static methods and properties cannot access non-static fields and events in their containing type, 
// and they cannot access an instance variable of any object unless it is explicitly passed in a method parameter.
/*
It is more typical to declare a non-static class with some static members, 
than to declare an entire class as static. 

Two common uses of static fields are to keep a count of the number of objects that have been instantiated, 
or to store a value that must be shared among all instances.

Although a field cannot be declared as static const, 
a const field is essentially static in its behavior. 
It belongs to the type, not to instances of the type. 
Therefore, const fields can be accessed by using the same ClassName.MemberName notation 
that is used for static fields. 
No object instance is required.

*/


using System;
public class Program
{
    public static void Main(string[] args)
    {
        Program obj = null;
        Console.WriteLine(Program.print());
    }
    private static String print()
    {
        return "Hi, I am a Tech-savvy!!";
    }
}

/*
main.cs(6,21): warning CS0219: The variable `obj' is assigned but its value is never used
Compilation succeeded - 1 warning(s)
*/
// Hi, I am a Tech-savvy!!
/*
The null keyword is a literal that represents a null reference, 
one that does not refer to any object. 
null is the default value of reference-type variables.

*/
