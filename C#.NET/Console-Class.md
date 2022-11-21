# Console Class

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0>

- Namespace: `System`

- Represents the standard input, output, and error streams for console applications. This class cannot be inherited.

## Console I/O Streams

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0#console-io-streams>

### three I/O streams

- By default, `Console.In`, `Console.Out`, and `Console.Error`

- When a console application starts, the operating system automatically associates three I/O streams with the console:  
  - standard input stream, default `System.IO.TextReader`
  - standard output stream, default `System.IO.TextWriter`
  - standard error output stream, default `System.IO.TextWriter`
