using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        string[] strings = { "abc", "def", "ghi" };
        var actions = new List();
        foreach (string str in strings)
          actions.Add(() => { Console.WriteLine(str); });

        foreach (var action in actions)
          action();
    }
}

//error CS0305: Using the generic type `System.Collections.Generic.List<T>' requires `1' type argument(s)
//Compilation failed: 1 error(s), 0 warnings
