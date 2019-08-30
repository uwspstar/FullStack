# Python 

### sort() vs sorted()
```
The syntax of sort() method is:
list.sort(key=..., reverse=...)

Alternatively, you can also use Python's in-built function sorted() for the same purpose.
sorted(list, key=..., reverse=...)

Note: Simplest difference between sort() and sorted() is: 
sort() doesn't return any value while, sorted() returns an iterable list.
```
### Class Inheritance
```
class Person( object ):     
  
        # __init__ is known as the constructor          
        def __init__(self, name, idnumber):    
                self.name = name 
                self.idnumber = idnumber 
        def display(self): 
                print(self.name) 
                print(self.idnumber) 
  
# child class 
class Employee( Person ):            
        def __init__(self, name, idnumber, salary, post): 
                self.salary = salary 
                self.post = post 
  
                # invoking the __init__ of the parent class  
                Person.__init__(self, name, idnumber)  
  
                  
# creation of an object variable or an instance 
a = Person('Rahul', 886012)     
  
# calling a function of the class Person using its instance 
a.display()  
```
- sum()
- mean() # average 
```
import statistics 
  
# list of positive integer numbers 
data1 = [1, 3, 4, 5, 7, 9, 2] 
  
x = statistics.mean(data1) 
  
# Printing the mean 
print("Mean is :", x)
```
```
# None, True, False
# list(), tuple(), dict(), set()

some_list = [-1, 3, 5, -9]
some_dict = dict(x=1,y=3)
print(some_list)

# get only for dict
# print(some_list.get(10, 0)) # list' object has no attribute 'get'
print(some_dict.get("x", 0)) 
# list' object has no attribute 'get', key has to be a string


# enumerate
# for idx, value in enumerate(some_list):
#     print(idx, value)

# reverse()
# This method does not return any value but reverse the given object from the list.
# so print(some_list.reverse()) not working
print(some_list.reverse()) 
# some_list.reverse()
print(some_list)

# min
print(min(some_list))

# string
x = 'bug' * 3
print (x) # prints ‘bugbugbug'

# List
x = [8, 5] * 3
print (x) # prints [8, 5, 8, 5, 8, 5]

# sorting
# – Returns a new list of items in sorted order – Does not change the original list
# String
x = 'bug'
print (sorted(x)) # prints ['b', 'g', 'u']

x = 'bug'
print (x.reverse()) # ERROR 'str' object has no attribute 'reverse'
print (x.sort()) # ERROR 'str' object has no attribute 'sort'
 
#  List
x = ['pig', 'cow', 'horse']
print (sorted(x)) # prints ['cow', 'horse', 'pig']

```
### resouce
https://docs.python.org/3.7/tutorial/index.html

### FAQ (Must Read, help a lot !!!)
https://docs.python.org/3/faq/programming.html#id1

### Learn Python by Building a Blockchain & Cryptocurrency by Maximilian Schwarzmüller
https://www.udemy.com/learn-python-by-building-a-blockchain-cryptocurrency

### The Modern Python 3 Bootcamp by Colt Steele
https://www.udemy.com/the-modern-python3-bootcamp/

### Python Exercises with Solutions | pynative
https://pynative.com/python-exercises-with-solutions/

### 100+ Python challenging programming exercises
https://github.com/zhiwehu/Python-programming-exercises

### Python 3 Cheat Sheet by Mosh Hamedani
https://programmingwithmosh.com/python/python-3-cheat-sheet/

### Python Tutorial for Beginners [Full Course] 2019 by Mosh Hamedani
https://www.youtube.com/watch?v=_uQrJ0TkZlc&t=4025s

### Effective Python: 59 Specific Ways to Write Better Python (Effective Software Development Series)
https://www.amazon.com/Effective-Python-Specific-Software-Development/dp/0134034287

# Python command
### Use exit() or Ctrl-D (i.e. EOF) to exit
- exit()

### 05/19/2019
- This is especially important on macOS, where you already got Python 2.7 pre-installed. 
To NOT use that, run **python3**  instead of python .

- install vscode 
https://www.udemy.com/learn-python-by-building-a-blockchain-cryptocurrency/learn/v4/t/lecture/10030512?start=0

- "-"*30 . // print line wiht 30 -
- 1 - 0.9 = 0.09999999999998
- str = 'I \'M cool'
- *** //multiple line
- \n //new line
``` 
x = int(1)   # x will be 1
y = int(2.8) # y will be 2
z = int("3") # z will be 3
``` 
```
x = float(1)     # x will be 1.0
y = float(2.8)   # y will be 2.8
z = float("3")   # z will be 3.0
w = float("4.2") # w will be 4.2
```
```
x = str("s1") # x will be 's1'
y = str(2)    # y will be '2'
z = str(3.0)  # z will be '3.0'
```
- blockchain[-1] // get the last one

### 05/20/2019
- https://hackr.io/tutorials/learn-python
- Python 3.7.3 documentation https://docs.python.org/3/
- Unlike strings, which are immutable, lists are a mutable type, i.e. it is possible to change their content:
```
>>> cubes = [1, 8, 27, 65, 125]  # something's wrong here
>>> 4 ** 3  # the cube of 4 is 64, not 65!
64
>>> cubes[3] = 64  # replace the wrong value
>>> cubes
[1, 8, 27, 64, 125]
```
- 2 ** 7  # 2 to the power of 7 # 128
- String literals can span multiple lines. One way is using triple-quotes: """...""" or '''...'''. 
- word[2:5]  # characters from position 2 (included) to 5 (excluded)
- Note how the start is always included, and the end always excluded. 
This makes sure that s[:i] + s[i:] is always equal to s:
- the length of word[1:3] is 2
```
word = 'python'
>>> word[:2]   # character from the beginning to position 2 (excluded)
'Py'
>>> word[4:]   # characters from position 4 (included) to the end
'on'
>>> word[-2:]  # characters from the second-last (included) to the end
'on'
```
- len(s)
```
All slice operations return a new list containing the requested elements. 
This means that the following slice returns a new (shallow) copy of the list:

>>> squares[:]
[1, 4, 9, 16, 25]
```
### 05/21/2019
- PEB 8 - Style Guide: https://www.python.org/dev/peps/pep-0008/ 
- Example Google Style Python Docstrings 
https://sphinxcontrib-napoleon.readthedocs.io/en/latest/example_google.html
- input()  # only get str, need to use int(str) for number 
- 17 // 3  # floor division discards the fractional part 5
- print(int(29) // 10) # 2
- print(int(int(29) / 10)) # 2
- print(str(int_num) +  str2) # print((int_num) +  str2) has problem
### 05/23/2019

- for block in blockchain:
- while True:
- ** expentiation # 2**3 = 8 
- 49 ** 0.5 = 7.0
- 10 % 3 = 1
- // interger divison # 3 // 2 =1
- PEMDAS

### 05/24/2019
- https://pynative.com/python-exercises-with-solutions/
- https://programmingwithmosh.com/python/python-3-cheat-sheet/
- boolena True # NOT true
- F-string # f"abc {x} cde"

### 05/25/2019
- Pylint tool
- $ python3 —version
```
import sys
print(sys.version_info)
print(sys.version)
```
- Python Enhancement Proposal #8, otherwise known as PEP 8
- if name == "abc": // NOT if(name =="abc" ):
- style  //care for the line space // 
- >indentation is 4 space
- Use spaces instead of tabs for indentation.
- Lines should be 79 characters in length or less
- In a file, functions and classes should be separated by two blank lines.
- In a class, methods should be separated by one blank line.
- Don’t put spaces around list indexes, function calls, or keyword argument
assignments.
- Put one—and only one—space before and after variable assignments.
- Functions, variables, and attributes should be in lowercase_underscore
format.
- Protected instance attributes should be in _leading_underscore format.
- Private instance attributes should be in __double_leading_underscore
format.
- Classes and exceptions should be in CapitalizedWord format
- Module-level constants should be in ALL_CAPS format
- Instance methods in classes should use self as the name of the first parameter
(which refers to the object).
- Class methods should use cls as the name of the first parameter (which refers to
the class).
- Don’t check for empty values (like [] or '') by checking the length (if
len(somelist) == 0).
- Avoid single-line if statements, for and while loops, and except compound
statements.
- Always put import statements at the top of a file.
```
print("hello world")
print("input your name")
name = input()


def display_name(name):
    if name == "a":
        print(f"name is :{name}")
    elif name == "x":
        print(f"name is : xx {name}")
    else:
        print(f"name is :{name} not a")


display_name(name)
```
- In Python 3, there are two types that represent sequences of characters: bytes and str.
- Instances of bytes contain raw 8-bit values. 
- Instances of str contain Unicode
- There are many ways to represent Unicode characters as binary data (raw 8-bit values).
The most common encoding is UTF-8.
- In Python 3, you’ll need one method that takes a str or bytes and always returns a
str.
```
def to_str(bytes_or_str):
    if isinstance(bytes_or_str, bytes):
        value = bytes_or_str.decode(‘utf-8’)
    else:
        value = bytes_or_str
    return value # Instance of str
```
- You’ll need another method that takes a str or bytes and always returns a bytes.
```
def to_str(bytes_or_str):
    if isinstance(bytes_or_str, bytes):
        value = bytes_or_str.decode(‘utf-8’)
    else:
        value = bytes_or_str
    return value # Instance of str
```
- In Python 3, bytes and str instances are never equivalent—
not even the empty string
- In Python 3, bytes contains sequences of 8-bit values, str contains sequences of
Unicode characters. bytes and str instances can’t be used together with operators
(like > or +).

```
a = [‘a’, ‘b’, ‘c’, ‘d’, ‘e’, ‘f’, ‘g’, ‘h’]
print(‘First four:’, a[:4])
print(‘Last four: ‘, a[-4:])
print(‘Middle two:’, a[3:-3])
>>>
First four: [‘a’, ‘b’, ‘c’, ‘d’]
Last four: [‘e’, ‘f’, ‘g’, ‘h’]
Middle two: [‘d’, ‘e’]

```
- When slicing from the start of a list, you should leave out the zero index to reduce visual
noise.
```assert a[:5] == a[0:5]```
- the expression somelist[-0:] will result in a copy of the original list.
- The result of slicing a list is a whole new list. References to the objects from the original
list are maintained. Modifying the result of slicing won’t affect the original list.
- Don’t supply 0 for the start index or the length of the
sequence for the end index.
- ```somelist[start:end:stride]```
- ::2 means select every second item starting at the beginning. Trickier, ::-2
means select every second item starting at the end and moving backwards.
```
a[2::2] # [‘c’, ‘e’, ‘g’]
a[-2::-2] # [‘g’, ‘e’, ‘c’, ‘a’]
a[-2:2:-2] # [‘g’, ‘e’]
a[2:2:-2] # []
```
### 05/26/2019
```
x = 1
x is 1  # True
x is 0  # False
print(f"x is 1 : {x is 1}")
print(f"x is 0 : {x is 0}")
```
```
a = -1
not a  
# this expression  false Negative numbers are just like regular numbers, 
so not (True) is false
```
``` *** -1 which is a nonzero value *** ```
```
x = 0
y = -1
x or y and x - 1 == y and y + 1 == x

# Here it is broken down: x or y # truthy because y is -1 
which is a nonzero value; 
x - 1 == y # true because x - 1 is -1, 
and -1 == -1; x or y
and x - 1 == y # true because both sides of the AND are truthy; 
y + 1 == x # truthy because -1 + 1 does in fact equal zero; 
x or y and x - 1 == y and y + 1 == x 
# also truthy because both sides of the second AND are truthy
```
- ```"is" vs "==" ```    # "==" only check value, "is" check location
```
a = 1
b = 1
a == b # True
a is b # True

x = [1, 2, 3]
y = [1, 2, 3]
x == y # True
x is y # False

z = y
z == y # True
z is y # True

```
### 05/27/2019
- else: # NOT else  , do not forget : after else

### 05/28/2019
- str.strip() # remove white space
- len(str) # length
- split
```
a = "Hello, World!"
print(a.split(",")) # returns ['Hello', ' World!']
```
- Python Membership Operators
- x in y # Returns True if a sequence with the specified value is present in the object
- x not in y
- Python Bitwise Operators
- https://www.tutorialspoint.com/python/bitwise_operators_example.htm
```
Operator	Name	Description
-------------------------------------------------
& 	AND	Sets each bit to 1 if both bits are 1
|	OR	Sets each bit to 1 if one of two bits is 1
^	XOR	Sets each bit to 1 if only one of two bits is 1
~ 	NOT	Inverts all the bits
<<	Zero fill left shift	Shift left by pushing zeros in from the right and let the leftmost bits fall off
>>	Signed right shift	Shift right by pushing copies of the leftmost bit in from the left, and let the rightmost bits fall off
```
### 05/30/2019
- range(3) #[0,1,2]
- for num in range(3): 
- 'list' object cannot be interpreted as an integer
- loop with index
```
colors = ["red", "green", "blue", "purple"]
i = 0
while i < len(colors):
    print(colors[i])
    i += 1
    

colors = ["red", "green", "blue", "purple"]
for i in range(len(colors)):
    print(colors[i])

```
- remove vs. del vs. pop
```
Yes, remove removes the first matching value, not a specific index:

>>> a = [0, 2, 3, 2]
>>> a.remove(2)
>>> a
[0, 3, 2]
del removes the item at a specific index:

>>> a = [3, 2, 2, 1]
>>> del a[1]
>>> a
[3, 2, 1]
and pop removes the item at a specific index and returns it.

>>> a = [4, 3, 5]
>>> a.pop(1)
3
>>> a
[4, 5]
```
- remove val in list
```
while val in nums:
        nums.remove(val)
```
### 06/03/2019
- while boolenExpression:
- https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf
- https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf
- ⌘/
```
⌘/ Toggle line comment
⇧⌥A Toggle block comment
```
### 06/09/2019
- datastructures
https://docs.python.org/3.7/tutorial/datastructures.html
- Lists 
```
squares = [1, 4, 9, 16, 25]
print(f"squares : {squares}")  # [1, 4, 9, 16, 25]
print(f"squares[0] : {squares[0]}")  # 1
print(f"squares[-1] : {squares[-1]}")  # 25
print(f"squares[-3:] : {squares[-3:]}")  # [9, 16,5]
print(f"squares[:] : {squares[:]}")  # [1, 4, 9, 16, 25]
concatenation = squares + [36, 49, 64, 81, 100]
# [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]
print(f"squares + [36, 49, 64, 81, 100] : {concatenation}")
# Unlike strings, which are immutable,
# lists are a mutable type, i.e.
# it is possible to change their content:
cubes = [1, 8, 27, 65, 125]
cubes[3] = 64
print(f"cubes : {cubes}")
cubes.append(216)
print(f"cubes.append(216) : {cubes}")
cubes.append(7**3)  # 7**3 = 7^3
print(f"cubes.append(7**3) : {cubes}")
cubes[2:5] = ['C', 'D', 'E']  # replace some values
print(f"cubes[2:5] = ['C', 'D', 'E']: {cubes}")  # list not type
cubes[2:5] = []  # remove
print(f"cubes[2:5] = [] : {cubes}")  # list not type
cubes[:] = []  # remove
print(f"cubes[:] = [] : {cubes}")  # list not type
letters = ['a', 'b', 'c', 'd']
print(f"len(letters) : {len(letters)}")
a = ['a', 'b', 'c']
n = [1, 2, 3]
x = [a, n]
print(f"x : {x}")  # [['a', 'b', 'c'], [1, 2, 3]]
print(f"x[0] : {x[0]}")  # ['a', 'b', 'c']
print(f"x[0][1] : {x[0][1]}")  # b
```
```
Unlike strings, which are immutable, lists are a mutable type, i.e. it is possible to change their content
```
- 2 ** 7  # 2 to the power of 7
- Built-in Types
https://docs.python.org/3.7/library/stdtypes.html#string-methods
### 06/10/2019
- Boolean Operations — and, or, not
- Numeric Types — int, float, complex
- i += 1 # NOT i =+ 1 , python does not have =+
```
for num in range(1, 6):
    print("\U0001f600" * num)
```
- while # Don't forget to add the + before the = sign 
```
times = 1
while times < 6:
    print("\U0001f600" * times)
    times += 1 #  without this line, it will print forever, 
```
```
Don't forget to add the + before the = sign when incrementing!
```
```
for num in range(1, 6):
    count = 1
    smileys = ""
    while count <= num:
        smileys += "\U0001f600"
        count += 1
    print(smileys)
```
### 07/18/2019
- lower case

### 08/17/2019
- number, boolean, string
- use "_" underscore for name ``` user_name = "xing"````
- put sapce between "=" ``` user_name = "xing"````
### Debug on Mac with VScode
- "fn" touch bar "F9"   --> break line
- "fn" touch bar "F5"   --> run

### string
```
for x in "Python_String":
    print(f"🥳 : { x }")
```
- len("string length")
- string in 0 index in python 
``` 
"python_string"[0] # "p"
"python_string"[-1] # "g"
"python_string"[0:3] # "pyt" index 3 is NOT include
"python_string"[0:]  # whole string
"python_string"[:3]  # "pyt"
```
```
- \\
- \n
- \"
- \'
```
``` f"{first_name} - {last_name}" ```
```
"python_string".upper()
"python_string".lower()
"python string".title() # "Python String"
" python string ".strip() # remove white space
" python string ".lstrip()
" python string ".rstrip()
"python string ".find("str") # return index
"python string ".replace("str","ttt")
print(g in "python string") # return boolean
```
- find vs in 
```
test_string = "python string"
print(test_string.find("str")) # return index, no found, return "-1"
print("g" in test_string) # return boolean
print("g" not in test_string) # return boolean
```
```
x = input("x: "
print(type(x))
bool(x)
int(x)
str(x)
float(x)
```
### list
https://docs.python.org/3.7/tutorial/datastructures.html#more-on-lists
- lists are a mutable type
- list(range(5)) # [0, 1, 2, 3, 4]
- list.sort(key=None, reverse=False)
- insert, remove or sort that only modify the list have no return value printed 
- zip
```


matrix = [
    [1, 2, 3, 4],
    [5, 6, 7, 8],
    [9, 10, 11, 12],
]

>>> list(zip(*matrix))
# [(1, 5, 9), (2, 6, 10), (3, 7, 11), (4, 8, 12)]

print(list(zip("abcd", *matrix)))
# [('a', 1, 5, 9), ('b', 2, 6, 10), ('c', 3, 7, 11), ('d', 4, 8, 12)]
```
```
insert, remove or sort return the default None. 
This is a design principle for all mutable data structures in Python.
```
```
Unlike strings, which are immutable, lists are a mutable type, i.e. it is possible to change their content:
```

# Sequence Types — list, tuple, range
https://docs.python.org/3/library/stdtypes.html#typesseq

### Falsy value
```
# ""
# 0
# None
```

- message = "over" if number > 30 else "opps" # one line code replace if elif
### loop
- for
- count += 1 # NOT count++ syntax error
```
for x in range(5):
    for y in range(4):
        print(f"({x},{y})")
 
for x in [1, 2, 3, 4]:
    print(f"🥳 : { x }")
    
    
count = 0
for num in range(1, 10):
    if num % 2 == 0:
        count += 1 # NOT count++ snytax error
        print(f"num {num} is even numbers")
print(f"there are {count} even numbers")


words = ["this", "hello is pyton3", "goooooog 🦊"]
for w in words[:]:  # Loop over a slice copy of the entire list.
    if len(w) > 6:
        words.insert(0, w)
print(words)
        
```
- the else clause belongs to the for loop, not the if statement.
```
for n in range(2, 10):
    for x in range(2, n):
        if n % x == 0:
            print(n, 'equals', x, '*', n//x)
            break
    else:
        # loop fell through without finding a factor
        print(n, 'is a prime number')
```
- while
```
number = 100
while number > 0:
    print(number)
    number //= 2
    
while True:
    command = input("> ").lower()
    if command == "quit":
        break
    else:
        print(f"{command} is not right")
```
- multiple assignment
```
# Fibonacci series:
# the sum of two elements defines the next
a, b = 0, 1 # multiple assignment
while a < 10:
    print(a)
    # print(b)
    a, b = b, a+b # multiple assignment

a = 0
b = 1
while a < 10:
    sum = a + b
    print(a)
    a = b
    b = sum
```
### function
- param vs arguments
```
def greet(frist_name, last_name) # param

greet("Xing", "Wang") # arguments
```
- *xargs
```
def get_numbers(*numbers):
    value = 1
    for num in numbers:
        value *= num
    return value


print(get_numbers(1, 2, 3, 4))
```
- ** xxargs # as a dictonary
```
def get_user(**user):
    print(user)


get_user(id=1, first_name="xing", age=30)
```
- map
```
map(function, iterables)

def myfunc(a, b):
  return a + b

x = map(myfunc, ('apple', 'banana', 'cherry'), ('orange', 'lemon', 'pineapple'))
# ['appleorange', 'bananalemon', 'cherrypineapple']
```
### math
```
import random
import math
number = random.randint(25, 50)
a = 100
print(number + a)
print(math.floor(math.pi))
print(math.pi)
print(math.ceil(math.e))
print(math.e)
```
### type
- print(type(5))  # <class 'int'>
- print(type(range(5)))  # <class 'range'>
