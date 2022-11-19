# C# debug

### Threads
```
1. Debug -> Windows -> Threads
2. Naming Threads
3. Freeze and Thaw
4. Conditional debugging
```
- https://www.youtube.com/watch?v=QCPt9aOcd98
- How to debug C# threads https://www.youtube.com/watch?v=2_nV7xMvTqg
- alwaye give your thread name, such as 
  ```
  Thread one - new Thread(MyMethod);
  one.Name - "Thread-One";
  ...
  ```
- breakpoint -> condition ->System.Threading.Thread.CurrentThread.Nmae ==" one"
 
### validate application input
- manage data integrity
- use ```Parse```, ```TryParse```, and ```Convert```
- use regular expressions
- validate JSON and XML

### perfor symmetric and asymmetricencryption

### manage assembiles

### debug and application

### implement diagnostics in an appication

