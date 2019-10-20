- https://www.amazon.com/More-Effective-Specific-Software-Development/dp/0672337886/

### Use Properties Instead of Accessible Data Members
- If you had used public data members, you’re stuck looking for every bit of code that sets a customer’s name and fixing it there.
- Because properties are implemented with methods, adding multithreaded support is easier. 
- You can enhance the implementation of the get and set accessors to provide synchronized access to the data
- all indexers are declared with the this keyword
```
public int this[int x, int y]
{
  get { return ComputeValue(x, y); }
}
```
