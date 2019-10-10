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
