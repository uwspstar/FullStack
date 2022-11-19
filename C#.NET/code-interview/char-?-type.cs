using System;
public class Program
{      
  public static void Main(string[] args)
    {
      char x = 'A';
      Console.WriteLine (x);
        int i = 0;
        Console.WriteLine (true  ? x : 0);
      Console.WriteLine (true  ? x : 'a');
      Console.WriteLine(false ? i : x); 
    }
}

/*

A
65
A
65
*/
