# Data Types

- read more <https://dotnettutorials.net/lesson/data-types-in-csharp/https://dotnettutorials.net/lesson/data-types-in-csharp/>

- `Value types`: read more <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types>

- `Reference types`: read more <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types>

- `Pointer Data Types`

- read summary <https://github.com/uwspstar/FullStack/blob/master/C%23.NET/Data-Types.md>

- Because of the limited use of data types, we lose in terms of optimization and performance.

## How Data is Represented in a Computer?

<table>
  <tr>
    <td width="300">
      <img src ="https://github.com/uwspstar/FullStack/blob/master/Img/101_Data_is_Represented.png" alt="Data_is_Represented" width="100%"/>
    </td>
    <td valign="top">
      <ul>
        <li>computer can only understand binary numbers i.e. 0’s and 1’s. So, the letter A is represented in the computer as 8 bits i.e. 01000001 (65 is the ASCII Value is A and hence the decimal number 65 is converted to its binary equivalent binary representation which is 01000001).</li>
        <li>the 0’s and 1’s are called `bits`.</li>
        <li>o store any data on the computer we need this 8-bit format. And this complete 8-bit is called a `Byte`.</li>
        <li>then, to convert binary to decimal format, and internally the computer will map the decimal format to byte format (binary format), and then by using the byte we can represent the data. So, you can observe the byte representation of decimal number 65 is 01000001.</li>
      </ul>
    </td>
  </tr>
</table>

## Value types

- all these data types is going to be a `struct`. And `struct` is a value type in C#

- A value type can be one of the two following kinds:
  - a `structure type`, which encapsulates data and related functionality
  - an `enumeration type`, which is defined by a set of named constants and represents a choice or a combination of choices

## Data types are something that gives information about

- Size of the memory location.
- The Range of data that can be stored inside that memory location
- Possible Legal Operations that can be performed on that memory location.
W- hat Types of Results come out from an expression when these types are used inside that expression?
