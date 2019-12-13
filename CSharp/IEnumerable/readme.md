# IEnumerable
- https://jeremybytes.blogspot.com/2012/05/next-please-closer-look-at-ienumerable.html

### IEnumerable<T> Interface
- only contains 1 method (well, technically two methods that do almost the same thing):
```
IEnumerator GetEnumerator()
IEnumerator<T> GetEnumerator()
```
### IEnumerator<T> interface
```
// Methods:
void Dispose()
bool MoveNext()
void Reset()

// Properties:
object Current
T Current
```
- we do not have to get an instance of the enumerator, nor do we have to deal with the "Current" object.  Instead, we just use the "foreach" loop. 
- Behind the scenes, the compiler will turn this into code similar to what we had above (calling GetEnumerator(), MoveNext(), etc.)
