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
### When to use multiple threads
- You use multiple threads to ```increase the responsiveness``` of your application and to ```take advantage``` of a multiprocessor or multi-core system to ```increase the application's throughput```.

### Processes vs threads
- A ```process``` is an executing program. An operating system uses processes to separate the applications that are being
executed. 
- A ```thread``` is the basic unit to which an operating system allocates processor time. 
- Each thread has a scheduling priority and maintains a set of structures the system uses to save the thread context when the thread's
execution is paused.
- The thread context includes all the information the thread needs to seamlessly resume execution, including the thread's set of CPU registers and stack. 
- Multiple threads can run in the context of a process. 
- All threads of a process share its virtual address space. 
- A thread can execute any part of the program code, including parts currently being executed by another thread.

### application domains
- The .NET Framework provides a way to isolate applications within a process with the use of application domains.

### Application domains are not available on .NET Core.

### primary thread vs worker threads
- By default, a .NET program is started with a single thread, often called the ```primary thread```. 
- However, it can create additional threads to execute code in parallel or concurrently with the primary thread. These threads are often called ```worker threads```.

### How to use multithreading in .NET
- Starting with the .NET Framework 4, the recommended way to utilize multithreading is to use ```Task Parallel Library```
(TPL) and ```Parallel LINQ``` (PLINQ).

### ThreadPool
- Both TPL and PLINQ rely on the ThreadPool threads. The ```System.Threading.ThreadPool``` class provides a .NET application with a pool of worker threads.
