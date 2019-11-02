# .NET Web API
- http://www.software-architects.com/content/images/blog/2015/09/RESTful%20Web%20API%20Design.pdf

### IHttpActionResult vs HttpResponseMessage
- https://www.youtube.com/watch?v=cNR7gDPJtQI

### Post vs Put
- https://www.youtube.com/watch?v=1xVK2m817Bw
### model binding
```
By default, model binding gets data in the form of key-value pairs 
from the following sources in an HTTP request:
```
- Form fields
- The request body (For controllers that have the [ApiController] attribute.)
- Route data
- Query string parameters
- Uploaded files

```
If the default behavior doesn't give the right results, 
you can use one of the following attributes to specify the source to use for any given target.
```
- [FromQuery] - Gets values from the query string.
- [FromRoute] - Gets values from route data.
- [FromForm] - Gets values from posted form fields.
- [FromBody] - Gets values from the request body.
- [FromHeader] - Gets values from HTTP headers.

### Routing
- Attribute Routing in ASP.NET Web API 2
https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
- Create a REST API with Attribute Routing in ASP.NET Web API 2
https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/create-a-rest-api-with-attribute-routing
### Unit Test
- Unit Testing Controllers in ASP.NET Web API 2
https://docs.microsoft.com/en-us/aspnet/web-api/overview/testing-and-debugging/unit-testing-controllers-in-web-api
### ASP NET Core dependency injection
- ASP NET Core dependency injection tutorial
https://www.youtube.com/watch?v=BPGtVpu81ek
- AddSingleton vs AddScoped vs AddTransient
https://www.youtube.com/watch?v=v6Nr7Zman_Y
