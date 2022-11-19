// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
// A collection is a class, so you must declare an instance of the class 
// before you can add elements to that collection.

using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var arr = new List { 20, 40, 35, 85, 70 };
        var collection = new Collection(arr);
        arr.Add(60);
        arr.Sort();
        Console.WriteLine(String.Join(",", collection));
    }


// Create a list of strings.
var salmons = new List<string>();
salmons.Add("chinook");
salmons.Add("coho");
salmons.Add("pink");
salmons.Add("sockeye");

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye

// Create a list of strings by using a
// collection initializer.
var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye


var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Remove odd numbers.
for (var index = numbers.Count - 1; index >= 0; index--)
{
    if (numbers[index] % 2 == 1)
    {
        // Remove the element by specifying
        // the zero-based index in the list.
        numbers.RemoveAt(index);
    }
}

// Iterate through the list.
// A lambda expression is placed in the ForEach method
// of the List(T) object.
numbers.ForEach(
    number => Console.Write(number + " "));
// Output: 0 2 4 6 8
