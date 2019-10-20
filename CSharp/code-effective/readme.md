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
- C# has two different versions of constants: compile-time constants and runtime constants.
- Neither problem is a good one to have, but if you must pick one, a slower, correct program is better than a faster, broken program. For that reason, you should prefer runtime constants over compile-time constants. Compile-time constants are slightly faster, but far less flexible, than runtime constants.
