# SUMMARY https://www.amazon.com/More-Effective-Specific-Software-Development/dp/0672337886/

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



- You cannot name an indexer in C#. Therefore, every different indexer in a type must have distinct parameter lists to avoid ambiguity.
