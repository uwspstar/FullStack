# C#.NET 9.0 new features (by ChatGPT)

- C# 9.0 is the latest version of the C# programming language and it includes several new features and improvements. Here is a list of some of the main new features in C# 9.0:

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
```

- This creates a new instance of `person` class with the age value updated to 35.

- You can also use the `copy` keyword to create a new instance of the record class with the same values as the original instance. For example:

```C#
var person3 = person.copy();
```

- In summary, the "Records" feature in C# 11 allows developers to create immutable classes with automatically generated properties, constructors, and equality comparison methods.It provides a simple and convenient way to create classes that are intended to be used as data holders.

- Note that this feature is only available in C# 9.0 and later.

## Init-only properties: A new feature that allows you to define properties that can only be set during object initialization

- `Init-only` properties is a new feature introduced in C# 9 that allows developers to define properties that can only be set during object initialization. This means that once an object is created, the properties defined as init-only cannot be modified.

- To define an init-only property, you use the `init` accessor keyword in the property declaration. For example:

```c#
class Person {
    public string FirstName { get; init; }
    public string LastName { get; init; }
}
```

- In this example, the `FirstName` and `LastName` properties are defined as init-only.

- When you create an instance of a class with init-only properties, you can set the properties during object initialization. For example:

```c#
var person = new Person { FirstName = "John", LastName = "Doe" };
```

- However, once the object is created, you cannot modify the init-only properties. For example, the following statement will result in a compile-time error:

```c#
person.FirstName = "Jane"; // Compile-time error
```

- You can also use init-only properties in a struct, like this:

```c#
struct Point {
    public int X { get; init; }
    public int Y { get; init; }
}
```

- In summary, the "Init-only properties" feature in C# 9 allows developers to define properties that can only be set during object initialization, providing a way to make properties immutable after object creation, which can be useful for scenarios where immutability is desired. This feature is available in C# 9.0 and later, and it can be used with classes or structs.

## Top-level statements: A new feature that allows you to use statements outside of a class or method, which can make it easier to write short scripts and one-liners

- Top-level statements is a new feature introduced in C# 9 that allows developers to use statements outside of a class or method. This feature enables developers to write short scripts and one-liners, which can make it easier to perform simple tasks, such as printing a message or running calculations.

- To use top-level statements, you simply write the statement(s) outside of any class or method. For example, you can use the Console.WriteLine method to print a message:

```c#
Console.WriteLine("Hello, World!");
```

- You can also use top-level statements to perform calculations:

```c#
int x = 2;
int y = 3;
Console.WriteLine(x + y); // Output: 5
```

- You can also use top-level statements with the using statement to perform tasks that use resources, such as reading from a file:

```c#
using System.IO;
Console.WriteLine(File.ReadAllText("file.txt"));
```

- In summary, the "Top-level statements" feature in C# 9 allows developers to use statements outside of a class or method, which can make it easier to write short scripts and one-liners. This feature provides a simple and convenient way to perform simple tasks, such as printing a message or running calculations. It allows developers to write console application and scripts more easily. This feature is available in C# 9.0 and later.

## Target-typed new expressions: A new feature that allows you to create an instance of a class without specifying the type when the type can be inferred from the context

## Improved pattern matching: A new feature that allows you to match on the shape of an object rather than its type, and also allows you to use patterns to bind values to variables

## Improved switch expressions: A new feature that allows you to use switch expressions as a concise and readable alternative to if-else chains

## Improved interpolated verbatim strings: A new feature that allows you to include expressions within verbatim strings without the need to escape characters

## Improved async streams: A new feature that allows you to use the "await" keyword with "foreach" to iterate over asynchronous streams

## Improved target-typed null coalescing: A new feature that allows you to perform null coalescing operations without specifying the type

## Improved stackalloc in nested expressions: A new feature that allows you to use "stackalloc" inside nested expressions

## Improved improved support for stackalloc for Span`<T>`: A new feature that allows you to use the "stackalloc" keyword to create arrays on the stack, which can be more efficient than creating them on the heap

- These are some of the new features in C# 11, but there are other improvements as well. Some of the new features are focused on improving the developer's productivity, readability and making the code more concise.
