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
