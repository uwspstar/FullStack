# FAQ
https://docs.python.org/3/faq/programming.html#faq-multidimensional-list

- using a module is also the basis for implementing the Singleton design pattern.

### Day 1 🐸
```
>>> x = 10
>>> def foo():
...     print(x)
...     x += 1
results in an UnboundLocalError:
```
```
This is because when you make an assignment to a variable in a scope, 
that variable becomes local to that scope and shadows any similarly named variable in the outer scope.
```
- Why am I getting an UnboundLocalError when the variable has a value?
https://docs.python.org/3/faq/programming.html#id8

### Day 2 🙈
- Why do lambdas defined in a loop with different values all return the same result?
Assume you use a for loop to define a few different lambdas (or even plain functions), e.g.:

- print(squares[i]())  # print lambdas

```
>>> print(squares) # print lambdas
>>>
[<function <lambda> at 0x7f0fa26e65f0>, <function <lambda> at 0x7f0fa26e6680>, <function <lambda> at 0x7f0fa26e6710>, <function <lambda> at 0x7f0fa26e67a0>, <function<lambda> at 0x7f0fa26e6830>]

```
```
>>> squares = []
>>> for x in range(5):
...     squares.append(lambda: x**2)
This gives you a list that contains 5 lambdas that calculate x**2. 
You might expect that, when called, they would return, 
respectively, 0, 1, 4, 9, and 16.
However, when you actually try you will see that they all return 16:

>>> squares[2]()
16
>>> squares[4]()
16

This happens because x is not local to the lambdas, 
but is defined in the outer scope, 
and it is accessed when the lambda is called — not when it is defined. 
At the end of the loop, the value of x is 4, 
so all the functions now return 4**2, i.e. 16. 
You can also verify this by changing the value of x and see how the results of the lambdas change:
```

### Day 3 🐷
- Why are default values shared between objects?
```
For example, don’t write:

>>>def foo(mydict={}):
    ...
    
but:

>>>def foo(mydict=None):
    if mydict is None:
        mydict = {}  # create a new dict for local namespace
        

By definition, immutable objects such as numbers, strings, tuples, and None, are safe from change. 
Changes to mutable objects such as dictionaries, lists, and class instances can lead to confusion.

Because of this feature, 
it is good programming practice to not use mutable objects as default values. 
Instead, use None as the default value and inside the function,
check if the parameter is None and create a new list/dictionary/whatever if it is. 
```
- What is the difference between arguments and parameters?
```
Parameters are defined by the names that appear in a function definition, whereas arguments are the values actually passed to a function when calling it. Parameters define what types of arguments a function can accept. For example, given the function definition:

def func(foo, bar=None, **kwargs):
    pass
foo, bar and kwargs are parameters of func. However, when calling func, for example:

func(42, bar=314, extra=somevar)
the values 42, 314, and somevar are arguments.
```
```
If we have a mutable object (list, dict, set, etc.), 
we can use some specific operations to mutate it 
and all the variables that refer to it will see the change.

If we have an immutable object (str, int, tuple, etc.), 
all the variables that refer to it will always see the same value, 
but operations that transform that value into a new value always return a new object.
```
