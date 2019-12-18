### the using statement can be changed to a method instead. 
- The following extension method named Use is an extension method for all classes implementing the ```IDiposable``` interface. 
- The using statement is used within the implementation to release the item after its use. 
```
public static class FunctionalExtensions {  
  public static void Use<T>(this T item, Action<T> action)    
  where T : IDisposable  
  {   using (item)    
      {      
        action(item);    
      }  
  } 
} 
```
```
class Resource : IDisposable 
{  
  public void Foo() => Console.WriteLine("Foo");
  private bool disposedValue = false; 
  protected virtual void Dispose(bool disposing)  
  {    
    if (!disposedValue)    
    {      
      if (disposing)      
      {        
        Console.WriteLine("release resource");      
      }      
      disposedValue = true;    
    }  
  }
  public void Dispose() => Dispose(true); 
} 
```
-  typical using statement block for accessing this Resource object would look: 
```
using (var r = new Resource()) 
{  
  r.Foo(); 
}
```
- With the Use method, accessing and disposing of the resource can be done in a single statement 
```
new Resource().Use(r => r.Foo()); 
```
