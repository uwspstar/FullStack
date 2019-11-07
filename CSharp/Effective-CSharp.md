# Effective C# 50 Specific Ways to Improve Your C# by Bill Wagner
### Item 1: Use Properties Instead of Accessible Data Members
- The .NET Framework assumes that you’ll use properties for your public data members. 
- In fact, the data binding classes in the .NET Framework support properties, not public data members. 
- This is true for all the data binding libraries: WPF, Windows Forms, Web Forms, and Silverlight. 
- Data binding ties a property of an object to a user interface control.
- The data binding mechanism uses reflection to find a named property in a type:
  
