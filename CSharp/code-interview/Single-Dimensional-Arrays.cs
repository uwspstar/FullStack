//Single-Dimensional Arrays
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
/*
SomeType[] array4 = new SomeType[10];

The result of this statement depends on whether SomeType is a value type or a reference type. 
If it is a value type, 
the statement creates an array of 10 elements, 
each of which has the type SomeType. 

If SomeType is a reference type, 
the statement creates an array of 10 elements, 
each of which is initialized to a null reference.

*/
using System;
public class Program
    {
       static void arrayMethod(int[] a)
    {
        int[] b = new int[5];
        a = b;
    }
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            arrayMethod(arr);
            Console.WriteLine(arr.Length);
        }
    }
    
    
 // 10
