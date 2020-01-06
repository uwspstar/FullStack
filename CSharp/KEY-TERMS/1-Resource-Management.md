### Resource Management 
### IDisposable
- If a class contains no managed resources and no unmanaged resources, it doesn’t need to implement ```IDisposable``` or have a destructor. 
- If the class has only managed resources, it should implement IDisposable but it doesn’t need a destructor. (When the destructor executes, you can’t be sure managed objects still exist, so you can’t call their Dispose methods anyway.)
-  If the class has only unmanaged resources, it needs to implement IDisposable and it needs a destructor in case the program doesn’t call Dispose. 
- The Dispose method must be safe to run more than once. You can achieve that by keeping track of whether it has been run before.
- The Dispose method should free managed and unmanaged resources.
- The destructor should free only unmanaged resources. (When the destructor executes, you can’t be sure managed objects still exist, so you can’t call their Dispose methods anyway.)
- After freeing resources, the Dispose method should call GC.SuppressFinalize to prevent the GC from running the object’s destructor and to keep the object out of the finalization queue.
### using
- The ```using``` statement lets a program automatically call an object’s Dispose method, so you can’t forget to do it. If you declare and initialize the object in the using statement, this also limits the object’s scope to the using block.
### garbage collection 
- The process of running the GC to reclaim memory that is no longer accessible to the program. 
### garbage collector (GC) 
- A process that executes periodically to reclaim memory that is no longer accessible to the program. 
