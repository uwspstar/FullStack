### Resource Management 
### IDisposable
- If a class contains no managed resources and no unmanaged resources, it doesn’t need to implement ```IDisposable``` or have a destructor. 
- If the class has only managed resources, it should implement IDisposable but it doesn’t need a destructor. (When the destructor executes, you can’t be sure managed objects still exist, so you can’t call their Dispose methods anyway.)
-  If the class has only unmanaged resources, it needs to implement IDisposable and it needs a destructor in case the program doesn’t call Dispose. 
