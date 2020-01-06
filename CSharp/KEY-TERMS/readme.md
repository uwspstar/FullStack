
### Conversion Basics 
- Implicit conversion doesn’t use a cast operator.
- Explicit conversion uses a cast operator.
- You can cast arrays of references but be aware that the new array refers to the same array and not a new one
### is and as Operators 
- Use the is operator to determine if a variable is compatible with a certain type.
- Use the as operator to convert an object into a compatible type (or null if the object isn’t compatible with the type). 
- The as operator is particularly useful if you know an object’s type, for example in an event handler. 
