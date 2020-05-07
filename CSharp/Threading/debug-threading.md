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
