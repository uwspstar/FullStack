# Data Structures
- https://docs.python.org/3/tutorial/datastructures.html#tuples-and-sequences
- https://docs.python.org/3.7/tutorial/datastructures.html#more-on-lists

```
You can use the tuple() function to return a tuple version of the value passed to it 
and similarly the list() function to convert to a list:

a_tuple = (1,2,3,4,5,6,7,8,9,10)
b_list = [1,2,3,4,5]

print(tuple(b_list))
print(list(a_tuple))
```
### Dictionaries 
- dictionary as a set of key: value pairs, 
```with the requirement that the keys are unique (within one dictionary). ```
- A pair of braces creates an empty dictionary: {}.
- dictionaries are indexed by keys
- keys can be any immutable type; strings and numbers can always be keys
- Tuples can be used as keys if they contain only strings, numbers, or tuples;
- https://medium.com/python-pandemonium/python-dictionaries-45cacc2b76aa
```
*** if a tuple contains any mutable object either directly or indirectly, 
it cannot be used as a key. ***
```
-  can’t use lists as keys
```
since lists can be modified in place using index assignments, 
slice assignments, or methods like append() and extend()
```
-  delete a key:value pair with del. 
- The dict() constructor builds dictionaries directly from sequences of key-value pairs:
```
>>> dict([('sape', 4139), ('guido', 4127), ('jack', 4098)])
{'sape': 4139, 'guido': 4127, 'jack': 4098}
```
```
>>> {x: x**2 for x in (2, 4, 6)}
{2: 4, 4: 16, 6: 36}
```
```
>>> dict(sape=4139, guido=4127, jack=4098)
{'sape': 4139, 'guido': 4127, 'jack': 4098}
```
### set
- A set is an unordered collection with no duplicate elements
- *** Note: to create an empty set you have to use set(), not {}; ***

```
Curly braces or the set() function can be used to create sets.
- a = set('abracadabra') # {'a', 'r', 'b', 'c', 'd'}
- basket = {'apple', 'orange', 'apple', 'pear', 'orange', 'banana'}
```
```
>>> a = set('abracadabra') # unique letters in a {'a', 'r', 'b', 'c', 'd'}
>>> b = set('alacazam')   

>>> a - b   # letters in a but not in b {'r', 'd', 'b'}
>>> a | b   # letters in a or b or both {'a', 'c', 'r', 'd', 'b', 'm', 'z', 'l'}
>>> a & b   # letters in both a and b {'a', 'c'}
>>> a ^ b   # letters in a or b but not both {'r', 'd', 'b', 'm', 'z', 'l'}

>>> a = {x for x in 'abracadabra' if x not in 'abc'} # {'r', 'd'}
```

### Lists
```
- slices are quite useful when making copies of lists
- list comprehension is used everywhere 
when iterating over lists, strings, ranges and even more data types!
- nested lists are essential for building more complex data structures 
like matrices, game boards and mazes
- swapping is quite useful when shuffling or sorting
```
- [bool(val) for val in [0, [], '']] # [False, False, False]
```
numbers = [1, 2, 3, 4, 5, 6]
evens = [num for num in numbers if num % 2 == 0]
odds = [num for num in numbers if num % 2 != 0]

[num*2 if num % 2 == 0 else num/2 for num in numbers] # [0.5, 4, 1.5, 8, 2.5, 12]
```
- nested list
```
nested_list = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
[[print(val) for val in l] for l in nested_list]
```
- how to write a nest list
```
nested_list = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]

[[] for list in nested_list] # step 1
[[for x in list] for list in nested_list] # step 2
```
- print(string[::-1]) # reverse a string
- a[len(a):] = [x]
- list.append(x) # stack
- pop([i])  # stack
- string.strip() # remove white space
- insert, remove or sort that only modify the list have no return value printed
- [1] * num_one + [2] * num_two + [3] * num_three
```
they return the default None. 
This is a design principle for all mutable data structures in Python.
```
- Using Lists as Stacks
```
- (“last-in, first-out”)
To add an item to the top of the stack, use append(). 
To retrieve an item from the top of the stack, use pop() without an explicit index.
```
```
>>> stack = [3, 4, 5]
>>> stack.append(6) # stack [3, 4, 5, 6]
>>> stack.pop() # stack [3, 4, 5]
```

- Using Lists as Queues
```
- (“first-in, first-out”)
however, lists are not efficient for this purpose. 
While appends and pops from the end of list are fast, 
doing inserts or pops from the beginning of a list is slow 
(because all of the other elements have to be shifted by one).

*** To implement a queue, use collections.deque
```
```
- collections.deque # use collections.deque

>>> from collections import deque
>>> queue = deque(["Xing", "John", "Michael"])
>>> queue.append("Terry")           # Terry arrives
>>> queue.append("Graham")          # Graham arrives
>>> queue.popleft()                 # The first to arrive now leaves
'Xing'
>>> queue.popleft()                 # The second to arrive now leaves
'John'
>>> queue                           # Remaining queue in order of arrival
deque(['Michael', 'Terry', 'Graham'])

```
```
>>> [(x, y) for x in [1,2,3] for y in [3,1,4] if x != y]
[(1, 3), (1, 4), (2, 3), (2, 1), (2, 4), (3, 1), (3, 4)]


>>> vec = [[1,2,3], [4,5,6], [7,8,9]]
>>> [num for elem in vec for num in elem]
[1, 2, 3, 4, 5, 6, 7, 8, 9]
```
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
### Tuples and Sequences

- A tuple consists of a number of values separated by commas, for instance:
```
Though tuples may seem similar to lists, 
they are often used in different situations and for different purposes. 
Tuples are immutable, 
and usually contain a heterogeneous sequence of elements that are accessed via unpacking 
(see later in this section) or indexing (or even by attribute in the case of namedtuples). 
Lists are mutable, 
and their elements are usually homogeneous and are accessed by iterating over the list.
```
```
>>> empty = ()
>>> singleton = 'hello',    # <-- note trailing comma
>>> len(empty)
0
>>> len(singleton)
1
>>> singleton
('hello',)
```
- ```>>> x, y, z = t```

### class
```
class Person:
  def __init__(self, fname, lname):
    self.firstname = fname
    self.lastname = lname

  def printname(self):
    print(self.firstname, self.lastname)
 ```
