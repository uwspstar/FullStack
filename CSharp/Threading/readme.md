# Threading

- the code uses a try...finally block, the lock is released even if an exception is thrown within the body of a lock statement.
```
object __lockObj = x;
bool __lockWasTaken = false;
try
{
    System.Threading.Monitor.Enter(__lockObj, ref __lockWasTaken);
    // Your code...
}
finally
{
    if (__lockWasTaken) System.Threading.Monitor.Exit(__lockObj);
}
```

# Debug Threading
    ```
    1. Debug -> Windows -> Threads
    2. Naming Threads
    3. Freeze and Thaw
    4. Conditional debugging
    ```
- https://www.youtube.com/watch?v=QCPt9aOcd98
- How to debug C# threads https://www.youtube.com/watch?v=2_nV7xMvTqg
    ```
    alwaye give your thread name, such as
    Thread one - new Thread(MyMethod);
    one.Name - "Thread-One";
    ...
    ```
- breakpoint -> condition ->System.Threading.Thread.CurrentThread.Nmae ==" one"
