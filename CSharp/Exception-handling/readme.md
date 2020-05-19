# Exception handling 
- A ```using``` statement is equivalent to a try-catch-finally block with a finally section that disposes of the object. 
- The most-specific (most-derived) catch sections must come first in a try-catch-finally block.
- A try-catch-finally block must have at least one catch section or a finally section
- The finally section always executes no matter how the program leaves a try-catchfinally block. 
- If an exception is not handled, control moves up the call stack until either a try-catchfinally block handles it or the program crashes. 

### throw vs throw ex
- To rethrow the current exception, use the throw statement without passing it an exception object. 
- To rethrow the exception ex while resetting its stack trace, use throw ex.
 
### SqlException
- The SqlException class represents all SQL Server exceptions. 
- Properties such as Class and Message give additional information about the error. 

### OverflowExceptions
- By default, integer operations do not throw OverflowExceptions. 
- Use a checked block or the Advanced Build Settings dialog to make overflows throw this exception. 
- Floating point operations do not cause ```overflow```. Instead they set the result to ```PositiveInfinity```, ```NegativeInfinity```, or ```NaN```. 
- Use the floating point methods ```IsInfinity```, ```IsInfinity```,```IsInfinity```, and ```IsNaN``` to determine whether a result is one of these special values.

### ThreadAbortException ( .NET Exceptions – System.Threading.ThreadAbortException )
- https://airbrake.io/blog/dotnet-exception-handling/system-threading-threadabortexception
- http://www1.cs.columbia.edu/~lok/csharp/refdocs/System.Threading/types/ThreadAbortException.html
