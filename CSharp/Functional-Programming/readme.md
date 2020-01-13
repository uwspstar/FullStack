# Functional Programming in C#
- https://www.amazon.com/Professional-NET-Core-Christian-Nagel/dp/1119449278
-  The most important concepts of functional programming are based on two approaches: 
```avoiding state mutation``` and ```having functions as a firstclass concept```.
- With C#, some of the predefined types are immutable such as the string type. ```Methods that are used to change the string always return a new string.``` 
- What about collections? The methods used by LINQ don’t change a collection. Instead, methods such as ```Where``` and ```OrderBy``` return a ```new collection``` that is ```filtered``` and a ```new collection``` that is ordered. 
- On the other hand, the ```List<T> collection``` offers methods for ```sorting``` that are implemented in a ```mutable``` way; the ```original collection is sorted```. 
- For more immutability, .NET offers complete immutable collections in the namespace ```System.Collections.Immutable```. These collections don’t offer methods that change the collection. Instead, new collections are always returned
- https://www.youtube.com/watch?v=dfwBEIr5giY
- https://www.youtube.com/watch?v=s8ru33IIQzc&t=523s
- Going all in with Functional C#
https://edcharbeneau.com/csharp-functional-workshop-instructions/
- C# functional programming in-depth 
https://weblogs.asp.net/dixin/functional-csharp-fundamentals
- Writing Purely Functional Code in C# https://app.pluralsight.com/library/courses/writing-purely-functional-code-csharp/table-of-contents
-  ```Higher-order function``` is the function which receives another function as an argument, or returns another function as the result, or both. 
```
int GiveStars(Func<string, float> HotelRating);
Func<float> HotelRating (int desireRating);
Func<int> AnyHotelRating (Func<string, float> HotelRating);

```
- ```Pure function``` is the function which has no side effects and only returns the result. Its result only depends on argument values and will always be the same for the same argument values. That was easy. 
- ```Lazy evaluation``` means that the expression is not evaluated before its value is about to be used. 
- And ```pattern matching``` means to match structure of an object against predetermined patterns, so that we can proceed with evaluation only if it conforms to certain structure and values.
- ```Value type semantic```, for example, means that an object will always have the same value once it has been constructed and have some additional qualities. 
- ```referential transparency```, which says that an expression will always produce the same result once it has been evaluated. This lets us safely replace an entire expression with its value and all subsequent references to it.
- Since C# 6, you have been able to create an auto implemented read-only property with just a get accessor: 
```
public string FirstName { get; } 
```
-  C# allows creating auto-implemented properties just with a get accessor where the compiler creates a readonly field and a get accessor returning the value of this field. 
- Out of this, the compiler creates a ```read-only field``` that can be ```initialized only in the constructor``` and a property with a get accessor returning this field. 
### What’s the advantage of using immutable types?
```
Because it’s guaranteed no one can change an instance,
multiple threads can be used to access it concurrently without the need for synchronization. 
With immutable types, it’s also easier to create unit tests. 
```
- the NuGet package Newtonsoft.Json allows using immutable types for JSON serialization and deserialization. 
### understanding the ValueTuple type
-  ```ValueTuple``` is a struct
- ``` Tuple ``` is a class
- components in ValueTuple are public mutable fields
- Tuple exposes public read-only properties Item1, Item2
- ```ValueTuple``` is ```NOT``` a good choice for public API

### Don't bind consumers to a struct with public fields
### Examples of higher-order functions are methods defined for LINQ
- For example, the Where method receives a Func<TSource, bool> predicate: 
```
public static IEnumerable<TSource> Where(this IEnumerable<TSource> source,  Func<TSource, bool> predicate); 
```
### Pure Functions 
- Pure functions should be preferred if possible. 
- Of course, not all methods can be implemented as a pure function
- When creating a method to access external sources, you might think about splitting the method into two parts: a part that is pure with probably complex logic and a part that cannot be pure.
- Pure functions fulfill two requirements: 
```
Pure functions always return the same result for the same arguments that are passed. 
Pure functions don’t result in a side effect, such as changing state, or depend on external sources. 
```
### EXPRESSION-BODIED MEMBERS
### EXTENSION METHODS 
```
public static class FunctionalExtensions 
{  
  //...  
  public static Func<T1, TResult> Compose<T1, T2, TResult>(
    Func<T1, T2> f1, Func<T2, TResult> f2) => a => f2(f1(a)); 
} 
```
