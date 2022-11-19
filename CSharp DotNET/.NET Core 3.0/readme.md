# .NET Core 3.0 Preview 8.

- Some of the new features include the following:
- Default implementation for interface members
- Access modifiers - public, private, protected, internal
- abstract members
- static members

### Basic
- https://jeremybytes.blogspot.com/2019/09/interfaces-in-c-8-are-bit-of-mess.html
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods
- If I end up throwing a NotImplementedException as a default, then that doesn't accomplish anything other than moving compile-time errors to run-time errors.
- https://devblogs.microsoft.com/dotnet/default-implementations-in-interfaces/
```
interface ILogger
{
    void Log(LogLevel level, string message);
    void Log(Exception ex) => Log(LogLevel.Error, ex.ToString());
}
```
