### find how many time the word repeat inside a file
```
var keyword = Console.ReadLine() ?? "";
using (var sr = new StreamReader("")) {
    while (!sr.EndOfStream) {
        var line = sr.ReadLine();
        if (String.IsNullOrEmpty(line)) continue;
        if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0) {
            Console.WriteLine(line);
        }
    }
}
```
### gabage collection
### performance issue encount
### SOLID  
- https://itnext.io/solid-principles-explanation-and-examples-715b975dcad4
### Dependency Injection
- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.0
### Sigleton
- Why you should not use Singleton?
```
Stateless singletons: You don't need more than one instance of this class, 
because it has no state. But you could have many of them: 
It just does not matter. Because they have no state :) 
Stateful singletons: You must have exactly one instance of this class, 
because it represents some globally shared state.
```
