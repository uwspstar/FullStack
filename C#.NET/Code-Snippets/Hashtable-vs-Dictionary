# Hashtable vs Dictionary difference? by ChatGPT

## Recommended to use Dictionary over Hashtable

- In C#, both `Hashtable` and `Dictionary` are collection classes that store key-value pairs. However, there are some important differences between the two:

  - `Type safety`: `Dictionary` is a generic class and provides type safety, meaning that you can specify the types of keys and values it will store. On the other hand, `Hashtable is a non-generic class` and does not provide type safety.

  - `Performance`: `Dictionary` has a `faster performance` compared to `Hashtable` because it is implemented using a hash table with open addressing and resizing capabilities. `Hashtable` is implemented using an array of linked lists, which is slower than the hash table implementation used by Dictionary.

  - `Null keys`: Dictionary does not allow you to use null as a key, while Hashtable allows you to use null as a key.

  - `Exception handling`: Dictionary throws an `ArgumentNullException` when you try to add a `null` key, whereas Hashtable does not throw an exception and allows you to add a null key.

- Based on these differences, `it is generally recommended to use Dictionary over Hashtable` when you need to store key-value pairs in your application, because it provides better performance, type safety, and exception handling capabilities.

## Hashtable

- A Hashtable in C# is a collection of key-value pairs that are organized based on the hash code of the key. It is a part of the System.Collections namespace and is implemented using an array of linked lists. It provides a fast and efficient way to store and retrieve data based on keys.

- Here's an example of how to create and use a Hashtable in C#:

```csharp
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Hashtable
        Hashtable hashtable = new Hashtable();

        // Adding key-value pairs to the Hashtable
        hashtable.Add("Key1", "Value1");
        hashtable.Add("Key2", "Value2");
        hashtable.Add("Key3", "Value3");

        // Retrieving values from the Hashtable using keys
        Console.WriteLine(hashtable["Key1"]); // Output: Value1
        Console.WriteLine(hashtable["Key2"]); // Output: Value2
        Console.WriteLine(hashtable["Key3"]); // Output: Value3

        // Updating values in the Hashtable
        hashtable["Key1"] = "NewValue1";
        Console.WriteLine(hashtable["Key1"]); // Output: NewValue1

        // Removing a key-value pair from the Hashtable
        hashtable.Remove("Key2");

        // Checking if a key exists in the Hashtable
        if (hashtable.ContainsKey("Key2"))
        {
            Console.WriteLine("Key2 exists");
        }
        else
        {
            Console.WriteLine("Key2 does not exist"); // Output: Key2 does not exist
        }
    }
}
```

- In this example, we first create a Hashtable using the Hashtable class. We then add key-value pairs to the Hashtable using the Add method. To retrieve values from the Hashtable, we use the square bracket notation and pass the key as the index. We can also update values in the Hashtable using the square bracket notation and assign a new value to the key. We can remove a key-value pair from the Hashtable using the Remove method and check if a key exists in the Hashtable using the ContainsKey method.

## Dictionary

- A `Dictionary` in C# is a collection of key-value pairs that is implemented using a hash table with open addressing and resizing capabilities. It is a part of the System.Collections.Generic namespace and provides type safety, meaning that you can specify the types of keys and values it will store.

- Here's an example of how to create and use a Dictionary in C#:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Adding key-value pairs to the Dictionary
        dictionary.Add("Key1", 1);
        dictionary.Add("Key2", 2);
        dictionary.Add("Key3", 3);

        // Retrieving values from the Dictionary using keys
        Console.WriteLine(dictionary["Key1"]); // Output: 1
        Console.WriteLine(dictionary["Key2"]); // Output: 2
        Console.WriteLine(dictionary["Key3"]); // Output: 3

        // Updating values in the Dictionary
        dictionary["Key1"] = 4;
        Console.WriteLine(dictionary["Key1"]); // Output: 4

        // Removing a key-value pair from the Dictionary
        dictionary.Remove("Key2");

        // Checking if a key exists in the Dictionary
        if (dictionary.ContainsKey("Key2"))
        {
            Console.WriteLine("Key2 exists");
        }
        else
        {
            Console.WriteLine("Key2 does not exist"); // Output: Key2 does not exist
        }
    }
}
```

- In this example, we first create a Dictionary using the Dictionary class and specify the types of the keys and values as string and int respectively. We then add key-value pairs to the Dictionary using the Add method. To retrieve values from the Dictionary, we use the square bracket notation and pass the key as the index. We can also update values in the Dictionary using the square bracket notation and assign a new value to the key. We can remove a key-value pair from the Dictionary using the Remove method and check if a key exists in the Dictionary using the ContainsKey method.
