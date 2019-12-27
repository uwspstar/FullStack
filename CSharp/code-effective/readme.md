# SUMMARY 
- https://www.amazon.com/More-Effective-Specific-Software-Development/dp/0672337886/
- https://www.amazon.com/gp/product/B074RJT99M/
###  Limit Type Scope by Using Anonymous Types
- Anonymous types are compiler generated immutable reference types
-  you can and must use ```object initializer``` syntax when you construct an instance of an anonymous type.
- Anonymous types are immutable types that support object initializer syntax.
-  You’ve told the compiler that this new type is an immutable type and that it has two public read-only properties surrounding two backing fields (X, Y). 
```
var aPoint = new { X = 5, Y = 67 }; 
//  You’ve indicated that you need a new internal sealed class.
```
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
- The obvious ```drawback``` of using anonymous types is that you don’t know the name of the type. 
- Because you don’t name the type, you can’t use an anonymous type as a parameter to a method or as its return value. 
```
static T Transform<T>(T element, Func<T, T> transformFunc) 
{    
	return transformFunc(element); 
}
var aPoint = new { X = 5, Y = 67 }; 
var anotherPoint = Transform(aPoint, (p) =>    new { X = p.X * 2, Y = p.Y * 2 }); 
```
- The anonymous type can store results from the first phase of an algorithm and pass those interim results into the second phase. 
- Using generic methods and lambdas means that you can define any necessary transformations on those anonymous types within the scope of the method where the anonymous type is defined. 
- for two anonymous types to be considered the same, the property names and types must match, and the properties must be in the same order. 

### Prefer Immutability for Value Types
- Don’t blindly create get and set accessors for every property in your type.
- Your first choice for types that store data should be immutable
- ```System.Collections.Immutable``` namespac
- This is easy using the ImmutableList collection type
```
public struct PhoneList 
{    
	private readonly ImmutableList<Phone> phones;    
	public PhoneList(Phone[] ph)    
	{        
		phones = ph.ToImmutableList();    
	}    
	public IEnumerable<Phone> Phones => phones; 
} 
```
- You can also create factory methods to initialize the structure
- Factories make it easier to create common values.
- But you do need to watch for any fields in an immutable type that are mutable reference types
- you can create a mutable companion class for those instances in which multistep operations are necessary to fully construct an immutable type. The .NET string class follows this strategy
- You use the StringBuilder class to create a string using multiple operations. After performing all the operations necessary to build the string, you retrieve the immutable string from the StringBuilder.
- When you implement your constructors for these types, you need to make a defensive copy of that mutable type. 
- Array is a mutable type. One alternative would be to use the ```ImmutableArray``` class
- To create an immutable type, you need to ensure that there are no holes that would allow clients to change your internal stat
- Immutable types are inherently thread safe: Multiple readers can access the same contents
- Immutable types work better in hash-based collections
- Immutable types are simple: After they are created, they are constant
- validate the parameters used to construct the object, you know that it is in a valid state from that point forward.
- In practice, it is very difficult to make every type immutableThat’s why this recommendation is for both atomic and immutable value types

### Prefer Implicit Properties for Mutable Data
- You cannot use implicit properties on types that are decorated with the Serializable attribute.
- you are making binary-compatible changes to your class, and your validation will be in only one location. 
```
 public string LastName    {        
	 get => lastName;        
	 private set        {            
		 if (string.IsNullOrEmpty(value))                
			 throw new ArgumentException(                    
			 "Last name cannot be null or empty");            
		 lastName = value;        
	 }    
 } 
 ```

### Use Properties Instead of Accessible Data Members
- If you had used public data members, you’re stuck looking for every bit of code that sets a customer’s name and fixing it there.
- Because properties are implemented with methods, adding multithreaded support is easier. 
- You can enhance the implementation of the get and set accessors to provide synchronized access to the data
- all indexers are declared with the this keyword

```
public int this[int x, int y]
{
  get { return ComputeValue(x, y); }
}
```
- You can extend properties to be abstract and define properties as part of an interface definition, using similar syntax to implicit properties
```
public interface INameValuePair<T> {    
	string Name { get; }    
	T Value { get; set; } 
} 
```
- You cannot name an indexer in C#. Therefore, every different indexer in a type must have distinct parameter lists to avoid ambiguity.
- property access generates different Microsoft Intermediate Language (MSIL) instructions than a data access. properties and data members are source compatible, they are not binary compatible
-  C# treats binary assemblies as first-class citizens.
- Properties are methods that can be viewed from the calling code like data.
- Property accessors also have performance expectations for your users
- Whenever you expose data in your type’s public or protected interfaces, use properties. 
- Use an indexer for sequences or dictionaries. 
- All data mem- bers should be private, without exception. 

### Prefer readonly to const
- you should prefer runtime constants over compile-time constants. 
- You declare runtime constants with the readonly keyword. Compile-time constants are declared with the const keyword:
- C# has two different versions of constants: compile-time constants and runtime constants.
  ```
  // Compile time constant:
  public const int Millennium = 2000;
  // Runtime constant:
  public static readonly int ThisYear = 2004;
  ```
- Neither problem is a good one to have, but if you must pick one, a slower, correct program is better than a faster, broken program. 
- For that reason, you should prefer runtime constants over compile-time constants. 
- Compile-time constants are slightly faster, but far less flexible, than runtime constants.
- Reserve the compile-time constants for when performance is critical and the value of the constant will never change between releases.
- Compile-time constants can also be declared inside methods. 
- Read-only constants cannot be declared with method scope.
- A compile-time constant is replaced with the value of that constant in your object code
- Runtime constants are evaluated at runtime.
- Compile-time constants can be used only for prim- itive types (built-in integral and floating-point types), enums, or strings. 
- Compile-time constants are limited to numbers and strings.
```
// Does not compile, use readonly instead:
private const DateTime classCreation = new DateTime(2000, 1, 1, 0, 0, 0);
```
- runtime constants can be any type , You must initialize them in a constructor, or you can use an initializer.
	
### Prefer the is or as Operators to Casts
- If you’re about to convert a type using as, the is check is simply not necessary.
- The ```is``` operator should be used ```only``` when you cannot convert the type using ```as```. Otherwise, it’s simply redundant
- ```Strong typing``` means you expect the compiler to find type mis-matches in your code.
- ```Strong typing``` means your applications do not need to perform as much type checking at runtime.
- two choices: Use the as operator or force the compiler to bend to your will using a cast
- You can test a conversion with is and then use as or casts to convert it.
- The correct choice is to use the as operator whenever you can because it is safer than blindly casting and is more efficient at runtime.
- the ```cast``` version must ```check null``` in addition to catching excep- tions. 
- ```null``` can be converted to any reference type using a ```cast```, but the ```as``` operator returns null when used on a null reference.
- Casting a long to a short can ```lose information```.  
- Remember that user-defined conversion operators operate only on the compile-time type of an object, not on the runtime type. - The as operator does not work on value types. This statement won’t compile: because ints are value types and can never be null.
```
object o = Factory.GetValue();
int i = o as int; // Does not compile.
```
- You’re stuck using the cast syntax. It’s actually a boxing/unboxing conversion     	
### Use Conditional Attributes Instead of #if
- The Conditional attribute can be applied only to entire methods.   
```
[Conditional("DEBUG"), Conditional("TRACE")]
private void CheckState()
{
// same code as above
#if ( VAR1 && VAR2 )
#define BOTH
#endif
}
```
### Distinguish Between Value Types and Reference Types
- You cannot create object hierarchies of value types. 
- All value types are automatically sealed. 
- value types are stored inline in an object, whereas reference types are not. Each variable of a reference type holds a reference, and the storage requires extra allocation
- Value types store values, and reference types define behavior
- objects are created on the heap
-  Value types are not polymorphic. They are better suited to storing the data that your application manipulates.
-  Reference types can be polymorphic and should be used to define the behavior of your application
- C++, in which you define all types as value types and can create references to them
- Java, in which everything is a reference type 
- The documentation for .NET recommends that you consider the size of a type as a determining factor between value types and reference types.

### Ensure That 0 Is a Valid State for Value Types
-  Never create an enum that does not include 0 as a valid choice. When you create your own values for an enum, make sure that 0 is one of them
- enums that use the Flags attribute should always set the None value to 0: 
```
[Flags] public enum Styles 
{   
	None = 0,    
	Flat = 1,    
	Sunken = 2,    
	Raised = 4, 
} 
```
- 0 values cause serious problems with bitflags. 
- If you use Flags, ensure that 0 is valid and that it means “the absence of all flags.” 
```
Styles flag = Styles.Sunken; 
if ((flag & Styles.Flat) != 0) // Never true if Flat == 0.    DoFlatThings(); 
```
###  Ensure That Properties Behave Like Data



















- You cannot name an indexer in C#. Therefore, every different indexer in a type must have distinct parameter lists to avoid ambiguity.
