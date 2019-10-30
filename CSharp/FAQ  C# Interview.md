# FAQ C# Interview
### Parameter Binding in ASP.NET Web API
- https://docs.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api

### design a facebook, and post comments api with user and pagenation
- such as API URL - /api/v1/comments/{id}/{pageNumber}/{pageSize}
- such as API URL - http://localhost:#####/api/comments/12345?&pageNumber=1&pageSize=5

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
- https://www.youtube.com/watch?v=01C8selSVCY&t=454s
### Sigleton
- Why you should not use Singleton?
```
Stateless singletons: You don't need more than one instance of this class, 
because it has no state. But you could have many of them: 
It just does not matter. Because they have no state :) 
Stateful singletons: You must have exactly one instance of this class, 
because it represents some globally shared state.
```
- a thread-safe which is a crucial requirement when implementing a Singleton pattern.
- https://www.davidtanzer.net/david's%20blog/2016/03/14/6-reasons-why-you-should-avoid-singletons.html
### MicroService
### RESTful API Design 

### POST vs PUT vs PATCH
- http ```post``` method is like a ```INSERT query``` in SQL which ```always creates``` a new record in database.
- http put method is like a MERGE query in SQL which inserts or updates a record depending upon whether the given record exists.
- http patch method is like a UPDATE query in SQL which sets or updates selected columns only and not the whole row.

- https://blog.fullstacktraining.com/restful-api-design-post-vs-put-vs-patch/
- https://www.quora.com/What-is-the-difference-between-PUT-POST-and-PATCH-for-RESTful-APIs
- what happens when we do a ```PUT``` against a resource that does not exist. In this case the resource is going to ```be created```. 
- HTTP.PUT method is used to CREATE or UPDATE a resource.
- The HTTP Verbs POST, GET, PUT, PATCH and DELETE are synonymous with the operations on a Database i.e. CREATE, READ, UPDATE./REPLACE, UPDATE/MODIFY and DELETE.
```
*** POST
A HTTP.POST method always creates a new resource on the server. 
Its a non-idempotent request i.e. if user hits same requests 2 times 
it would create another new resource if there is no constraint.

http post method is like a INSERT query in SQL 
which always creates a new record in database.

Example: Use POST method to save new user, 
order etc where backend server decides the resource id for new resource.

*** PUT
In HTTP.PUT method the resource is 
first identified from the URL and if it exists then it is updated 
otherwise a new resource is created.
When the target resource exists it overwrites that resource with a complete new body. 
That is HTTP.PUT method is used to CREATE or UPDATE a resource.

http put method is like a MERGE query in SQL which inserts or updates a record depending upon 
whether the given record exists.

PUT request is idempotent i.e. hitting the same requests twice would update the existing recording
(No new record created). 
In PUT method the resource id is decided by the client and provided in the request url.

Example: Use PUT method to update existing user or order.

PATCH
A HTTP.PATCH method is used for partial modifications to a resource i.e. delta updates.

http patch method is like a UPDATE query in SQL which sets or updates selected columns only and not the whole row.

Example: You could use PATCH method to update order status.

PATCH /api/users/40450236/order/10234557

Request Body: {status: 'Delivered'}
```
### Can we use Put instead of post?
```
The HTTP methods POST and PUT aren't the HTTP equivalent of the CRUD's create and update. ...
It's quite possible, valid and even preferred in some occasions, 
to use PUT to create resources, 
or use POST to update resources. 
Use PUT when you can update a resource completely through a specific resource.
```

- Please note that when calling HTTP ```PATCH ```on a resource that ```doesn't exist with a payload```, the resource ```should not be created```. The request ```should fail```. This is significantly different from how ```PUT``` works.
