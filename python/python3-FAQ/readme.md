# FAQ
https://docs.python.org/3/faq/programming.html#faq-multidimensional-list

- using a module is also the basis for implementing the Singleton design pattern.

### Day 1
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

- Why do lambdas defined in a loop with different values all return the same result?
Assume you use a for loop to define a few different lambdas (or even plain functions), e.g.:

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
