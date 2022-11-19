# Anonymous Types
###  Limit Type Scope by Using Anonymous Types
- Anonymous types are compiler generated ```immutable reference types```
- Anonymous types are immutable types that support object initializer syntax. 
- you can and must use ```object initializer``` syntax when you construct an instance of an anonymous type.
- Anonymous types are immutable types that support object initializer syntax.
- Whenever you create the same anonymous type, the compiler reuses the same anonymous type as before. 
- You would get the same anonymous type only by ensuring that all properties are declared in the ```same order``` every time you declare an object that is meant to represent the same concept.
```
var aPoint = new { X = 5, Y = 67 }; 
//  You’ve indicated that you need a new internal sealed class.
```
- You’ve told the compiler several things : 
- You’ve indicated that you need a new ```internal sealed class```. 
- You’ve told the compiler that this new type is an ```immutable``` type and that it has two public ```read-only``` properties surrounding two backing fields (X, Y). 
- You’ve told the compiler to write something like this for you: 
- Instead of writing this by hand, I’d rather let the compiler write it for me.
```
internal sealed class AnonymousMumbleMumble 
{    
	private readonly int x;
	public int X    
	{        
		get => x;    
	}    
	private readonly int y;    
	public int Y    
	{        
		get => y;    
	}    
	public AnonymousMumbleMumble(int xParm, int yParm)    
	{        
		x = xParm;        
		y = yParm;    
	}    // And free implementations of ==, and GetHashCode() elided. 
} 
```
- The obvious ```drawback``` of using anonymous types is that you ```don’t know``` the ```name of the type```. 
- Because you don’t name the type, you ```can’t``` use an anonymous type as a ```parameter``` to a ```method``` or as its return value. 
```
static T Transform<T>(T element, Func<T, T> transformFunc) 
{    
	return transformFunc(element); 
}
var aPoint = new { X = 5, Y = 67 }; 
var anotherPoint = Transform(aPoint, (p) =>    new { X = p.X * 2, Y = p.Y * 2 }); 
```
-  you can and must use object initializer syntax when you construct an instance of an anonymous type. 
```
// For example, suppose you have this call: 
var aPoint = new { X = 5, Y = 67 }; 
// It is translated by the compiler into this: 
AnonymousMumbleMumble aPoint = new AnonymousMumbleMumble(5, 67); 
```
- The only way you can create an immutable type that supports object initializer syntax is to use an anonymous type. 
- Hand-coded types do not get the same compiler magic. 

- The anonymous type can store results from the first phase of an algorithm and pass those interim results into the second phase. 
- Using generic methods and lambdas means that you can define any necessary transformations on those anonymous types within the scope of the method where the anonymous type is defined. 
- for two anonymous types to be considered the same, the property names and types must match, and the properties must be in the same order. 
```
var query = from c in customers            
	group c by new { c.SalesRep, c.ZipCode };
```
### Tuples and anonymous
- Tuples are similar in that they are lightweight types that you define by creating instances. 
- Tuples are distinct from anonymous types in that they are ```mutable``` value types with public fields. 
- Tuples are preferred for method return types and method parameters because they following structural typing
- Anonymous types are better for composite keys in collections because they are immutable.
- Tuples have all the advantages associated with value types; 
- anonymous types have all the advantages associated with reference types 
