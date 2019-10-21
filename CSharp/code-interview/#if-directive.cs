/*
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-if

You can use the operators == (equality) and != (inequality) only to test for true or false. 
True means the symbol is defined. 
The statement #if DEBUG has the same meaning as #if (DEBUG == true). 
You can use the operators && (and), || (or), 
and ! (not) to evaluate whether multiple symbols have been defined. 
You can also group symbols and operators with parentheses.
*/
using System;
public class Program
    {
        public static void Main(string[] args)
        {
        #if (!pi)
                    Console.WriteLine("i");
        #else 
                    Console.WriteLine("PI undefined");
        #endif
            Console.WriteLine("ok");
            Console.ReadLine();
        }
    }
 
// i
// ok
