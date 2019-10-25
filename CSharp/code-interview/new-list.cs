/*
There is no List, there is a generic class named List<T>, 
requires a type parameter.
You can't create a generic list without specifying the type parameter.
*/

using System;
using System.Collections.Generic;
public class Program
    {
        public static void Main(string[] args)
        {
            var actions = new List();
            for (int i = 0; i < 4; i++) actions.Add(() => Console.WriteLine(i));
            foreach (var action in actions)
                action();
        }
    }
    
   //  Using the generic type `System.Collections.Generic.List<T>' requires `1' type argument(s)


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

   //  Using the generic type `System.Collections.Generic.List<T>' requires `1' type argument(s)
