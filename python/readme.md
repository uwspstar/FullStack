# Python 
https://docs.python.org/3.7/tutorial/index.html

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

### Effective Python: 59 Specific Ways to Write Better Python (Effective Software Development Series)
https://www.amazon.com/Effective-Python-Specific-Software-Development/dp/0134034287

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
- if name == "abc": // NOT if(name =="abc" ):
- style  //care for the line space // 
- >indentation is 4 space
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
