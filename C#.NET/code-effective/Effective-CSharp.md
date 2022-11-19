# Effective C# 50 Specific Ways to Improve Your C# by Bill Wagner
### Item 1: Use Properties Instead of Accessible Data Members
- ```If you’re still creating public variables in your types, stop now.``` 
- ```If you’re still creating get and set methods by hand, stop now.```
- The .NET Framework assumes that you’ll use properties for your public data members. 
- In fact, ```the data binding classes in the .NET Framework support properties, not public data members.``` 
- This is true for all the data binding libraries: WPF, Windows Forms, Web Forms, and Silverlight. 
- ```Data binding ties a property of an object to a user interface control.```
- ```The data binding mechanism uses reflection to find a named property in a type:```
- Because properties are implemented with methods, ```adding multithreaded support is easier.```  
- ```Properties have all the language features of methods.``` Properties can be virtual:
- You can extend properties to be abstract and define properties as part of an interface definitio
- You can specify different accessibility modifiers to the get and set accessors in a property in C#.

```
public int this[int index]
{
  get => theValues[index];
  set => theValues[index] = value;
}
private int[] theValues = new int[100]
// accessing an indexer
int val = someObject[i];
```
- alll indexers are declared with the ```this``` keyword. you cannot name an indexer in C#

### Use Optional Parameters to Minimize Method Overloads
- Named parameters mean that in any API with default parameters, you need to specify only those parameters you intend to use. This approach is much simpler than working with multiple overloads.
