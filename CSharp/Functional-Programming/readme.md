# Functional Programming in C#
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
### understanding the ValueTuple type
-  ```ValueTuple``` is a struct
- ``` Tuple ``` is a class
- components in ValueTuple are public mutable fields
- Tuple exposes public read-only properties Item1, Item2
- ```ValueTuple``` is ```NOT``` a good choice for public API
### Don't bind consumers to a struct with public fields
