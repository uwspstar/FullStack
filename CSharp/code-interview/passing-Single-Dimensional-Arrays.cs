//Single-Dimensional Arrays
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays
/*
int[] array3;
array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
//array3 = {1, 3, 5, 7, 9};   // Error


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

//value type vs reference type

using System;
public class Program
{
    static void arrayMethod(int[] a)
    {
      foreach(var x1 in a) 
      {
        Console.WriteLine("x1 = " + x1);
      }
        
      int[] b = new int[5] {1,1,1,1,1};
      a = b;
      foreach(var y in b) 
      {
        Console.WriteLine("y = " + y);
      }
        
      Console.WriteLine("a.Length = " + a.Length);
        
      foreach(var x in a) 
      {
        Console.WriteLine("x = " + x);
      }
    }
    public static void Main(string[] args)
    {
        int[] arr = new int[10];
        // [0,0,0,0,0,0,0,0,0,0]
        foreach(var a in arr) 
        {
          Console.WriteLine("arr = " + a);
        }
        
        arrayMethod(arr);
        
        Console.WriteLine(arr.Length);
        
        foreach(var a in arr) 
        {
          Console.WriteLine("arr2 = " + a);
        }
    }
}

/*

arr = 0
arr = 0
arr = 0
arr = 0
arr = 0
arr = 0
arr = 0
arr = 0
arr = 0
arr = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
x1 = 0
y = 1
y = 1
y = 1
y = 1
y = 1
a.Length = 5
x = 1
x = 1
x = 1
x = 1
x = 1
10
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
arr2 = 0
*/
