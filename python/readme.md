# Python 
https://docs.python.org/3.7/tutorial/index.html

### Learn Python by Building a Blockchain & Cryptocurrency by Maximilian Schwarzmüller
https://www.udemy.com/learn-python-by-building-a-blockchain-cryptocurrency

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
- 2 ** 7  # 2 to the power of 7 //128
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
