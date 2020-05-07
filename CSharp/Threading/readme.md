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
- Starting with the .NET Framework 4, multithreaded programming is greatly simplified with the
```System.Threading.Tasks.Parallel``` and ```System.Threading.Tasks.Task``` classes, ```Parallel LINQ (PLINQ)```, new concurrent collection classes in the ```System.Collections.Concurrent``` namespace, and a new programming model that is based on the concept of
tasks rather than threads.

### Processes vs threadis
- A ```process``` is an executing program. An operating system uses processes to separate the applications that are being
executed. 
- A ```thread``` is the basic unit to which an operating system allocates processor time. 
- Each thread has a scheduling priority and maintains a set of structures the system uses to save the thread context when the thread's
execution is paused.
- The thread context includes all the information the thread needs to seamlessly resume execution, including the thread's set of CPU registers and stack. 
- Multiple threads can run in the context of a process. 
- All threads of a process share its virtual address space. 
- A thread can execute any part of the program code, including parts currently being executed by another thread.
### The .NET Framework provides a way to isolate applications within a process with the use of application domains.
### Application domains are not available on .NET Core.
