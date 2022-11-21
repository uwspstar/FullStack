# Console Class

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0>

- Namespace: `System`

- Represents the standard input, output, and error streams for console applications. This class cannot be inherited.

## Console I/O Streams

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0#console-io-streams>

## Three I/O Streams

- By default, `Console.In`, `Console.Out`, and `Console.Error` (But, To redirect the standard input, standard output, or standard error stream, call the `Console.SetIn`, `Console.SetOut`, or `Console.SetError`)

- When a console application starts, the operating system automatically associates three I/O streams with the console:  
  - standard input stream, default `System.IO.TextReader`
  - standard output stream, default `System.IO.TextWriter`
  - standard error output stream, default `System.IO.TextWriter`
  - `Console.ReadLine`, `Console.WriteLine`, the data is followed by the default line termination string, which can be found at `Environment.NewLine`.
