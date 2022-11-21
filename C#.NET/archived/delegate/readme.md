
- # delegate
- The .NET Framework defines two built-in delegate types that you can use in many cases: Action and Func. 
- The following code shows the declarations for Action and Func delegates that take two parameters:
```
public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2) 
public delegate TResult Func<in T1, in T2, out TResult> (T1 arg1, T2 arg2)
```
