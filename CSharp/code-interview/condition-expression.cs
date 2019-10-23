// condition-expression


using System;
public class Program
{      
  public static void Main(string[] args)
    {
      char x = 'A'; //char
      int i = 0;
      Console.WriteLine (x); //A
      Console.WriteLine (true  ? x : 0); //65
      Console.WriteLine(false ? i : x); //65

      char ch = 'a'; //char
      Console.WriteLine(true  ? ch : 0);		// 97
      Console.WriteLine(ch.ToString());		// a
      Console.WriteLine(Char.ToString('b'));	// b
    }
}
