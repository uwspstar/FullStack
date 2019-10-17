# Dependency Injection
- ASP.NET Core dependency injection tutorial 
- https://csharp-video-tutorials.blogspot.com/2019/02/aspnet-core-dependency-injection.html
- https://www.youtube.com/watch?v=BPGtVpu81ek
- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.0#service-lifetimes
### Transient
- Transient lifetime services (AddTransient) are created each time they're requested from the service container. This lifetime works best for ```lightweight, stateless services```.

### Scoped
- Scoped lifetime services (AddScoped) are created once ```per client request (connection)```.
  ```
  Warning

  When using a scoped service in a middleware, inject the service into the Invoke or InvokeAsync method. 
  Don't inject via constructor injection because it forces the service to behave like a singleton. 
  For more information, see Write custom ASP.NET Core middleware.
  ```

### Singleton

- Singleton lifetime services (AddSingleton) are created the first time they're requested (or when Startup.ConfigureServices is run and an instance is specified with the ```service registration```). 
- ```Every subsequent request uses the same instance```. If the app requires singleton behavior, allowing the service container to manage the service's lifetime is recommended. Don't implement the singleton design pattern and provide user code to manage the object's lifetime in the class.
  ```
  Warning

  It's dangerous to resolve a scoped service from a singleton. 
  It may cause the service to have incorrect state when processing subsequent requests.
  ```
# AddSingleton vs AddScoped vs AddTransient

### AddSingleton() 
- As the name implies, AddSingleton() method creates a Singleton service. A Singleton service is created when it is first requested. This same instance is then used by all the subsequent requests. So in general, a Singleton service is created only one time per application and that single instance is used throughout the application life time.

### AddTransient() 
- This method creates a Transient service. A new instance of a Transient service is created each time it is requested. 

### AddScoped() 
- This method creates a Scoped service. A new instance of a Scoped service is created once per request within the scope. For example, in a web application it creates 1 instance per each http request but uses the same instance in the other calls within that same web request.

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();
    services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
}
```
