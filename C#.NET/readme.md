# C# 101

## Reference

- <https://dotnettutorials.net/course/csharp-dot-net-tutorials/>
- <https://dotnet.microsoft.com/en-us/learn/csharp>
- <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions>
- <https://docs.microsoft.com/en-us/dotnet/csharp/walkthroughs>

## How Does Computer Work

![Computer Work](/Img/101_computer_work.png)

- `ALU (Arithmetic Logic Unit)`: ALU performs the basic logical and arithmetic operations. Arithmetic operations like addition, subtraction, multiplication, division, and modulus. Logical operations like comparing two numbers (such as >, <, >=, <=, etc.), logical AND, OR, NOT, etc. So, ALU has performed these basic operations.

- `CU (Control Unit)` : CU controls the other components like Input and output devices, main memory, hard disk, etc. The job of the control unit is to utilize other resources effectively.

- `Main Memory` : when computer run any program (Program Files), it will be brought into the main memory so that the CPU can execute it.

- `HDD` : A hard disk is a storage device for a computer (contains two types of files, i.e. data files and program files.)

- `INPUT` : Input devices are Keyboard, Mouse, etc.

- `OUTPUT` : Output devices are monitors, printers, etc.

- read more <https://dotnettutorials.net/lesson/how-computer-works-csharp/>

## The computer only understands the binary number system

- `Binary` Number System: {0,1}

- `Octal` Number System: {0,1,2,3,4,5,6,7}

- `Decimal` Number System: {0,1,2,3,4,5,6,7,8,9}

- `Hexadecimal` Number System: {0,1,2,3,4,5,6,7,8,9, A, B, C, D, E, F}

## How do we Convert Decimal Numbers to Binary Numbers?

- <https://www.cuemath.com/numbers/decimal-to-binary/>

## Programming Languages

- We need for a programming language in order to communicate with computers. A computer can understand only `machine code` or `binary code`.

- `Compiler` : Programs get converted by the Compiler and generate machine code. The compiler converts all these instructions into binary language or machine code.

- `Interface` : The interface means without having the background details we can perform our tasks. For example, the end-user understands the English language, then the end-user clicks on English, then all the instructions will come in English language and operations will be performed.

## Types of Computer Languages

- `Low-level Programming Language` : at a low level, we have two languages i.e.`Machine Language` and `Assembly language`
  
  - `Machine Language` : is the fundamental language (binary of 1’s and 0’s) for the system and it can be directly understandable without any translation.
  
  - `Assembly language` : is a programming language (Symbolic Language) but that is a low-level programming language. The assembly language contains some human-readable commands such as mov, add, mul, div, sub, etc. (a little easier to write and understand compare with `Machine Language`. Assembly code is not faster than machine code)

- `High-Level Programming Language` : Examples of High-Level Languages are C, C++, Java, Python, C#, Visual Basic, Visual C++, etc.

## Types of Software

- System Software
  - Operating System: DOS, WINDOWS, LINUX, UNIX

  - System Support: Compiler, Interpreter, Assembler

  - System Development: Linker, Loader, Editor

- Application Software

  - Application-Specific: MS OFFICE, Oracle

  - General Purpose Software

## How Computer Programs Works

![Translator](/Img/101_translator.png)

- read more <https://dotnettutorials.net/lesson/how-computer-programs-works-in-csharp/>

- `Translators` : are system software that converts programming language code into binary format. The translators are classified into three types:

  - `Compiler` : The compiler translates High-level code (Source code) to Machine code All at once. But its execution time is more and occupies the largest part of the memory. It is faster when compared to the interpreter as the entire translation happens in one go.

  - `Interpreter` :The interpreter translates each High-level instruction to machine code One by one. If an error occurs it will stop the compilation process.

  - `Assembler` : It is the system software that converts assembly language instructions into binary formats.

- `Compiler` and `interpreter` are both used to convert `high-level programs` to machine code. `Assembler` is used to convert `low-level` programs to machine code

| Compiler                                                          |      Interpreter                                                  |
|-------------------------------------------------------------------|:-----------------------------------------------------------------:|
| scans the whole program and generates machine code in one go      | scan each statement one by one                                    |
| takes time to analyze the program. But execution time is faster   | translation time is faster but overall execution time is slower.  |
| generates intermediate code called object code                    | MO object code                                                    |

- `loader` : is a program that loads the machine codes of a program into system memory.

- `locator` : is a program that assigns specific memory addresses for each machine code of a program that is to be loaded into system memory.

- `linker` : is a program that links smaller programs to form a single program.

## Different Types of Applications

- There are 2 types of applications:

  - `Standalone Applications` : the Application which is always dependent on an operating system is called a Standalone Application. Exp. All programming languages are standalone applications. That is the Installation of the application is mandatory on the machine.

  - `Web Applications`

## Operating System extensions

- Windows : .exe

- MAC OS : .DMG

- Linux : .RPM

## Platform-Dependent and Platform-Independent Language

- Using any `platform-dependent language`, we can develop only standalone applications. such as using C and C++ language, because these languages are platform-dependent languages.

- Using `platform-independent languages` we can develop both standalone applications and web applications. such as Java, C#, PHP, etc.

## Programming Methodologies

- `Monolithic Programming` : The entire program code is present in a single block without any division of code into functions.

- `Modular/ Procedural` : a particular set of code is present in the form of functions or modules that can be used wherever required.

- `Object-Oriented` : In OOPs, the code is written in the form of classes that contains different data members and member functions, the data, and their associated functions are grouped together. The objects can also be created by using class type.

## Pseudocode -> Algorithm -> Programs

## Flowchart

![Flowchart](/Img/101_flowchart.png)

## What is COM (Component Object Model)?

- `COM (Component Object Model)` is one of Microsoft Frameworks.

- Using `COM` Framework, we can develop Windows Applications and Web Applications.

- In earlier `COM`, VB is the programming language that is used to implement Windows applications and ASP is the technology used to implement web applications.
executed anywhere.

## Framework

- `Framework` is a collection of many small technologies integrated together to develop applications that can be

## .NET Framework

- read more <https://dotnettutorials.net/lesson/introduction-to-dot-net-framework/>
- read more <https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet-framework>

- `.NET` is a Free, Cross-Platform, Open-Source. (was called `.NET Core`) is Platform Independent.

- `.NET Framework` is Platform-Dependent

- `NET (Network Enabled Technology (Internet))`.

- In `.NET`, dot (.) refers to Object-Oriented, and NET refers to the internet. So, the complete `.NET` means through Object-Oriented we can implement internet-based applications.

- `NuGet` is a package manager built specifically for .NET that contains over 100,000 packages.

## What does the .NET Framework Provide

![Execution Flow](/Img/101_dot-net-framework-code-exceution-flow.png)

- read more <https://dotnettutorials.net/lesson/net-framework-architecture-and-components/>

- The `two major components` of the .NET Framework are the `Common Language Runtime (CLR)` and the `Base Class Library (BCL)`.

## Source Code -> Compiler -> CIL -> CLR -> Machine Code

- The .NET applications are written in C#, F#, or VB programming languages. The Source Code is compiled into an intermediate language code called `IL` or `MSIL` or `CIL (Common Intermediate Language)`. And the Compiled code is stored in assemblies with `.DLL` or `.EXE` file extension.

- When an application runs, the CLR takes the `Assembly (IL Code or MSIL Code, or CIL)` and uses the  `Just-in-Time compiler (JIT)` to convert the `MSIL` or `IL` code into machine code that can execute on the specific architecture of the computer it is running on.

![Code Flow](/Img/101_code_flow.png)

- The DOT NET Framework provides `two major components` as follows

  - `BCL (Base Class Libraries)`: Without `BCL` we can’t write any code in .NET. So, BCL is also known as the basic building block of .NET Programs. These are installed into the machine when we installed the .NET framework. `BCL` contains pre-defined classes and these classes are used for the purpose of application development. It provides a set of APIs and types for common functionality. It provides types for strings, dates, numbers, etc. The Class Library includes APIs for reading and writing files, connecting to databases, drawing, and more.

  - `CLR (Common Language Runtime)`: it is the `core component` under the .NET framework which is responsible for converting the `MSIL (Microsoft Intermediate Language)` code into `native code`. It is the execution engine that handles running applications. It provides services like thread management, garbage collection, type safety, exception handling, and more.

    - `JIT (ust-in-Time compiler)`: it is the component of `CLR` that is responsible for converting MSIL code into Native Code. Native code is code that is directly understandable by the operating system.

## In the .NET framework, the code is compiled twice

- read more <https://dotnettutorials.net/lesson/introduction-to-dot-net-framework/>
- read more <https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet-framework>

- `source code` to `MSIL` : In the 1st compilation, the `source code` is compiled by the respective language compiler and generates the intermediate code which is known as `MSIL` ( Microsoft Intermediate Language) or IL (Intermediate language code), or Managed Code.

- `MSIL` to `Native code` : In the 2nd compilation, `MSIL` is converted into `Native code` (native code means code specific to the Operating system so that the code is executed by the Operating System) and this is done by CLR.

- Always 1st compilation (`source code` to `MSIL`) is slow and 2nd compilation (`MSIL` is converted into `Native code`) is fast.

## Applications Developed using .NET Framework

- `WinForms`

- `ASP.NET`

- `ADO.NET`: This technology is used to develop applications to interact with databases such as Oracle or Microsoft SQL Server.

- `Entity Framework`: It is an ORM-based open-source framework

- `Parallel LINQ`: Parallel LINQ or PLINQ is a parallel implementation of LINQ to objects.

- `WCF (Windows Communication Foundation)`: It is a framework for building service-oriented applications. Using `WCF`, you can send data as asynchronous messages from one service endpoint to another.

## C# is Compiled and Interpreted

- We know a programming language is either compiled or interpreted. But C# combines both approaches.

- First C# compiler `CSC` translates source code into an intermediate language code known as `MSIL (Microsoft Intermediate Language)` or `CIL (Common Intermediate Language)` code. But these `MSIL` or `CIL` or `IL` codes are not machine instructions. So, in the second stage, these `MSIL` or `CIL`, or `IL` codes are interpreted by the C# `interpreter` (One Component of `CLR` called `JIT- Just in Time` Compiler). As a result, machine instructions will be generated which are directly executed by the machine. Hence, we are saying C# is both interpreted and compiled language.

## C# is Object-Oriented (A P I E)

- Abstraction (A)
- Polymorphism (P)
- Inheritance (I)
- Encapsulation (E)

## Basic Structure of C# Program

- read more <https://dotnettutorials.net/lesson/basic-structure-of-csharp-program/>

- `Using`: is a keyword. Using this keyword, we can refer to .NET `BCL` in C# Applications i.e. including the `BCL` namespaces as well as we can also include user-defined namespaces that we will discuss as we progress in this course

## C# keywords

- read more <https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/>

- C# Keywords are lowercase.

- Keywords are `predefined, reserved identifiers` that have special meanings to the compiler.

- Keywords can't be used as `identifiers` in your program unless they include `@ as a prefix`. For example, `@if` is a valid identifier, but if isn't because if is a keyword.

## Console Class

- read more <https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-7.0>

- read summary <https://github.com/uwspstar/FullStack/blob/master/C%23.NET/Console-Class.md>

<details>
  <summary>Summary : Console Class</summary>
    <p>The Console class is available in the System namespace.</p>
    <p> The console is an operating system window where users interact with the operating system or with a text-based console application by entering text input through the computer keyboard, and by reading text output from the computer terminal</p>
</details>

## static class

- The `static class` in C# contains only static members i.e. all the `Properties` and `Methods` available in the Console class are static. So, we can access all these members by using the Console class name i.e. we don’t require the Console class instance to access these members.

## gRPC on .NET

- read more <https://learn.microsoft.com/en-us/aspnet/core/grpc/?view=aspnetcore-7.0>

- read more <https://grpc.io/docs/languages/csharp/>

- read summary <https://github.com/uwspstar/FullStack/blob/master/C%23.NET/grpc.md>

## Extensions

- draw.io in vscode: <https://www.youtube.com/watch?v=AdrFG7sq1d4>
- markdown_tables: <https://www.tablesgenerator.com/markdown_tables>
- Download VisualStudio: <https://visualstudio.microsoft.com/downloads/>
- Download .NET Framework 4.8: <https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48>

- [X] Item1
- [ ] Item2
- [ ] Item3

## others

- markdownlint取消html标签警告 <https://blog.csdn.net/qq_44926567/article/details/109167394>
