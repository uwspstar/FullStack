// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
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
