# Console Class

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0>

- read more <https://dotnettutorials.net/lesson/console-class-methods-properties-csharp/>

- Namespace: `System`

- Represents the standard input, output, and error streams for console applications. This class cannot be inherited.

- The Console class supports `UTF-8` encoding with the `UTF8Encoding` class.

- The `static class` in C# contains only static members i.e. all the Properties and Methods available in the Console class are static. So, we can access all these members by using the Console class name i.e. we don’t require the Console class instance to access these members.

## Console I/O Streams

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0#console-io-streams>

## Three I/O Streams

- By default, `Console.In`, `Console.Out`, and `Console.Error` (But, To redirect the standard input, standard output, or standard error stream, call the `Console.SetIn`, `Console.SetOut`, or `Console.SetError`)

- When a console application starts, the operating system automatically associates three I/O streams with the console:  
  - standard input stream, default `System.IO.TextReader`
  - standard output stream, default `System.IO.TextWriter`
  - standard error output stream, default `System.IO.TextWriter`
  - `Console.ReadLine`, `Console.WriteLine`, the data is followed by the default line termination string, which can be found at `Environment.NewLine`.

## console window

- The console window is another attribute of the console; it is not the console itself, which is an operating system window.

- The `screen buffer` is viewed through a rectangular region called the console window. If the screen buffer is larger than the console window, the console automatically displays scroll bars so the console window can be repositioned over the screen buffer area.

- To display Unicode characters to the console. you set the OutputEncoding property to either `UTF8Encoding` or `UnicodeEncoding`. (`UTF-32` encoding is not supported. The only supported Unicode encodings are `UTF-8` and `UTF-16`)

```c#
static void Main(string[] args)
{
    //Beep Sound
    Console.Beep();

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Title = "Understanding Console Class";
    Console.WriteLine("Background Color: Blue", "Foreground Color: White", "Title: Understanding Console Class");
    
    // do not close window
    Console.ReadKey();
}
```

## ReadLine() vs Read()

- `Read()`: read a single character from the keyboard and returns its ASCII value. The Datatype should be int as it returns the ASCII value.
- `ReadLine()`: DataType is going to be a string.

```c#
static void Main(string[] args)
{
    Console.WriteLine("Enter two Numbers:"); 
    int num1 = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine($"The num1 is: {num1}");
    Console.ReadKey();
}
```

## ReadKey()

- The `ReadKey` method waits, that is, blocks on the `thread` issuing the ReadKey method, until a character or function key is pressed.

- This method reads a single character from the keyboard and returns that character information like what key has been entered, and what its corresponding ASCII value is. The Datatype should be ConsoleKeyInfo which contains the entered key information

- read more <https://dotnettutorials.net/lesson/console-class-methods-properties-csharp/>

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-7.0#system-console-readkey>

```c#
public static void Main()
{
  ConsoleKeyInfo key1 = Console.ReadKey();
        Console.WriteLine($"\nEntered Key: {key1.Key} KeyChar:{key1.KeyChar} ASCII:{(int)key1.KeyChar}");

  ConsoleKeyInfo cki;
  // Prevent example from ending if CTL+C is pressed.
  Console.TreatControlCAsInput = true;

  Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
  Console.WriteLine("Press the Escape (Esc) key to quit: \n");
  do
  {
      cki = Console.ReadKey();
      Console.Write(" --- You pressed ");
      if((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
      if((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
      if((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
      Console.WriteLine(cki.Key.ToString());
    } while (cki.Key != ConsoleKey.Escape);
}
```
