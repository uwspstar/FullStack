# C#.NET 11 new features (by ChatGPT)

- C# 11 is the latest version of the C# programming language and it includes several new features and improvements. Here is a list of some of the main new features in C# 11:

## Records: A new feature that allows you to create immutable classes with automatically generated properties, constructors, and equality comparison methods

- Records is a new feature introduced in C# 11 that allows developers to create immutable classes with automatically generated properties, constructors, and equality comparison methods.

- To create a record class, you use the `record` keyword before the class definition. For example:

```c#
record Person {
   public string FirstName { get; init; }
   public string LastName { get; init; }
   public int Age { get; init; }
}
```

- In this example, `Person` is a record class with three properties: `FirstName`, `LastName`, and `Age`. The `init` keyword is used to indicate that the properties are immutable and can only be set during object initialization.

- When you create an instance of a record class, you can use the automatically generated constructor to initialize the properties. For example:

```c#
var person = new Person { FirstName = "John", LastName = "Doe", Age = 30 };
```

- Records also have an automatically generated `Equals` method and `GetHashCode` method, which compares the values of all the properties in the class and determines if two instances are equal.

- You can also use the `with` keyword to create a new instance of a record class with modified values. For example:

```c#
var person2 = person with { Age = 35 };
````s

- This creates a new instance of `person` class with the age value updated to 35.

- You can also use the `copy` keyword to create a new instance of the record class with the same values as the original instance. For example:

```C#
var person3 = person.copy();
```

- In summary, the "Records" feature in C# 11 allows developers to create immutable classes with automatically generated properties, constructors, and equality comparison methods.It provides a simple and convenient way to create classes that are intended to be used as data holders.

- Note that this feature is only available in C# 9.0 and later.

## Init-only properties: A new feature that allows you to define properties that can only be set during object initialization

## Top-level statements: A new feature that allows you to use statements outside of a class or method, which can make it easier to write short scripts and one-liners

## Target-typed new expressions: A new feature that allows you to create an instance of a class without specifying the type when the type can be inferred from the context

## Improved pattern matching: A new feature that allows you to match on the shape of an object rather than its type, and also allows you to use patterns to bind values to variables

## Improved switch expressions: A new feature that allows you to use switch expressions as a concise and readable alternative to if-else chains

## Improved interpolated verbatim strings: A new feature that allows you to include expressions within verbatim strings without the need to escape characters

## Improved async streams: A new feature that allows you to use the "await" keyword with "foreach" to iterate over asynchronous streams

## Improved target-typed null coalescing: A new feature that allows you to perform null coalescing operations without specifying the type

## Improved stackalloc in nested expressions: A new feature that allows you to use "stackalloc" inside nested expressions

## Improved improved support for stackalloc for Span`<T>`: A new feature that allows you to use the "stackalloc" keyword to create arrays on the stack, which can be more efficient than creating them on the heap

- These are some of the new features in C# 11, but there are other improvements as well. Some of the new features are focused on improving the developer's productivity, readability and making the code more concise.
