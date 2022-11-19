# C# 101

## Reference

- <https://dotnettutorials.net/course/csharp-dot-net-tutorials/>
- <https://dotnet.microsoft.com/en-us/learn/csharp>
- <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions>
- <https://docs.microsoft.com/en-us/dotnet/csharp/walkthroughs>

## How Does Computer Work

![Full Stack Developer](/Img/101_computer_work.png)

- `ALU` : Arithmetic Logic Unit: ALU performs the basic logical and arithmetic operations. Arithmetic operations like addition, subtraction, multiplication, division, and modulus. Logical operations like comparing two numbers (such as >, <, >=, <=, etc.), logical AND, OR, NOT, etc. So, ALU has performed these basic operations.
- `CU` : Control Unit: Control unit controls the other components like Input and output devices, main memory, hard disk, etc. The job of the control unit is to utilize other resources effectively.
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

### How do we Convert Decimal Numbers to Binary Numbers?

- <https://www.cuemath.com/numbers/decimal-to-binary/>

## Programming Languages

- We need for a programming language in order to communicate with computers. A computer can understand only `machine code` or `binary code`.
- `Compiler` : Programs get converted by the Compiler and generate machine code. The compiler converts all these instructions into binary language or machine code.
- `Interface` : The interface means without having the background details we can perform our tasks. For example, the end-user understands the English language, then the end-user clicks on English, then all the instructions will come in English language and operations will be performed.

### Types of Computer Languages

- `Low-level Programming Language` : at a low level, we have two languages i.e.
 `Machine Language` and `Assembly language`
  - `Machine Language` : is the fundamental language (binary of 1’s and 0’s) for the system and it can be directly understandable without any translation.
  - `Assembly language` : is a programming language (Symbolic Language) but that is a low-level programming language. The assembly language contains some human-readable commands such as mov, add, mul, div, sub, etc. (a little easier to write and understand compare with `Machine Language`. Assembly code is not faster than machine code)
- `High-Level Programming Language` : Examples of High-Level Languages are C, C++, Java, Python, C#, Visual Basic, Visual C++, etc.

### Types of Software

- System Software
  - Operating System: DOS, WINDOWS, LINUX, UNIX
  - System Support: Compiler, Interpreter, Assembler
  - System Development: Linker, Loader, Editor
- Application Software
  - Application-Specific: MS OFFICE, Oracle
  - General Purpose Software

### How Computer Programs Works

![Full Stack Developer](/Img/101_translator.png)

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

### Extensions

- draw.io in vscode <https://www.youtube.com/watch?v=AdrFG7sq1d4>
- markdown_tables <https://www.tablesgenerator.com/markdown_tables>
