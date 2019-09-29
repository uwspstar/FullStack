# .NET Core

### ASP NET Core dependency injection
- ASP NET Core dependency injection tutorial https://www.youtube.com/watch?v=BPGtVpu81ek
- AddSingleton vs AddScoped vs AddTransient https://www.youtube.com/watch?v=v6Nr7Zman_Y

### 1. Action Attributes ```CD```
```
a)If an action returns JSON data, it must be decorated with the JsonResult attribute.
b)There is a built-in attribute for defining view name.
c)The ValidateAntiForgeryToken attribute prevents CSRF attacks.
d)The ActionName attribute allows usage of a different action name than the method name.
```

### 2. Passing Data ```Ad```
Select all the methods that can be used to pass data from the controller to the view.
```
- By setting properties on the model that is passed to the view.
- By setting properties on the web controls that the view contains.
- By using the view's helper methods.
- By using ViewData dictionary.
```
