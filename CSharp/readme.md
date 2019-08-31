# C#

### Class vs Structure
```
- classes are reference types allocated on the heap
- structures are value types allocated on the stack.

*** The main difference between structures and classes is that 
- structures implemented this semantic of copying by value 
- classes implement as a semantic of copying by a reference.
```

### Array vs ArrayList

### Abstract Class vs Interface


### Implementing "Dispose" Pattern

### Encapsulation and Information Hiding

### Encapsulation in Practice

### What is Interning?

### Constant vs Readonly

### Lock vs Monitor

### How to Rethrow Exceptions

### StringBuilder vs String
- Why string builder works so fast.
```
- Strings are immutable
- When we mutate a string variable every time we get a new instance of type String 

- String builder represents mutable string so mutating its instance.
- There are no thousands of allocations of new String instances.
```
