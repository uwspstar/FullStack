# .NET Core
### What is ASP.NET Core and what are it's benefits
```
ASP.NET Core is a cross-platform, high-performance, open-source framework for building modern, 
cloud-based, Internet-connected applications.

ASP.NET Core is a redesign of ASP.NET 4.x. For this reason it was initially, called ASP.NET 5, 
but later renamed to ASP.NET Core 1.0.
```
### Dependency Injection 
```ASP.NET Core has built-in support for dependency injection.```

### Unified Programming Model for MVC and Web API 
```
With ASP.NET core, we use the same unified programming model to 
create MVC style web applications and ASP.NET Web API's. 
```
### Cross Platform
```
ASP.NET 4.x applications run only on windows platform, 
where as ASP.NET Core applications can be developed and run across different platforms 
like Windows, macOS, or Linux.
```
### Testability
```
With built-in dependency injection 
and the unified programming model for creating Web Applications and Web API's, 
unit testing ASP.NET Core applications is easy.
```
### Middleware ```Modular HTTP Request Pipeline``` 
```ASP.NET Core Provides Modularity with Middleware Components.``` 

### SDK
```
The .NET Core Runtime is already included in the SDK. 
So, if you have installed the SDK, there is no need to install .NET Core Runtime 
```
### Main() method and it is the ```entry point``` for that console application
```
an asp.net core application initially starts as a console application 
and the Main() method in Program.cs file is the entry point. 

public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
}
```
### CreateWebHostBuilder() ```calls CreateDefaultBuilder() static method```
```
- CreateWebHostBuilder() method returns an object that implements IWebHostBuilder. 
- On this object, Build() method is called 
which builds a web host that hosts our asp.net core web application.
- On the web host Run() method is called, 
which runs the web application and it begins listening for incoming HTTP requests.
- CreateWebHostBuilder() method calls CreateDefaultBuilder() static method of the WebHost class.
```
### CreateDefaultBuilder() sets up a web host with certain defaults
- Setting up the web server 
- Loading the host and application configuration from various configuration sources and 
- Configuring logging
```
CreateDefaultBuilder() method creates a web host with pre-configured defaults. 
CreateDefaultBuilder() method does several things to create a web host.
CreateDefaultBuilder() method sets up a web host with certain defaults.
```
### An ASP.NET core application can be hosted ```InProcess``` or ```OutOfProcess```.
### As part of setting up a web host, ```Startup``` class is also configured using the ```UseStartup()``` extension method of IWebHostBuilder class.
### Startup
- ConfigureServices() method ```configures services``` required by the application
- Configure() method sets up the application's ```request processing pipeline```
```
public class Startup
{
	//configures services
    public void ConfigureServices(IServiceCollection services)
    { }
    
	// processing pipeline
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
    }
}
```
### InProcess hosting in ASP.NET Core ```defaults to the in-process hosting```
```
To configure InProcess hosting, 
add <AspNetCoreHostingModel> element to the app's project file with a value of InProcess
<AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>

When we create a new ASP.NET Core project using one of the available project templates, 
the project defaults to the in-process hosting model for all IIS and IIS Express scenarios.

```
### UseIIS() method ```IIS worker process (w3wp.exe or iisexpress.exe)```
```
In case of InProcess hosting, CreateDefaultBuilder() method calls UseIIS() method 
and host the app inside of the IIS worker process (w3wp.exe or iisexpress.exe). 

From a performance standpoint, 
InProcess hosting delivers significantly higher request throughput than OutOfProcess hosting.

In the case of IIS, the process name that executes the app is w3wp 
and in the case of IIS Express it is iisexpress.
```
### To get the process name executing the app, use ```System.Diagnostics.Process.GetCurrentProcess().ProcessName```
###  the project from Visual Studio default uses ```IISExpress```. We do not IISExpress it for production 
```
IIS Express is a lightweight, self-contained version of IIS, 
optimized for application development. We do not use it for production. In production we use IIS.
We will discuss deploying ASP.NET Core applications on IIS in our upcoming videos.
```
### With out of process hosting There are 2 web servers - An internal web server ```Kestrel``` and an external web server ```IIS, Nginx or Apache```. 
### With InProcess hosting, there is only one web server i.e the IIS that hosts the asp.net core application. 
```we do not have the performance penalty of proxying requests between internal and external web server.```
### out of process hosting

### ASP NET Core dependency injection
- ASP NET Core dependency injection tutorial https://www.youtube.com/watch?v=BPGtVpu81ek
- AddSingleton vs AddScoped vs AddTransient https://www.youtube.com/watch?v=v6Nr7Zman_Y

### the project file does not contain any folder or file reference
```The File System determines what files and folders belong to the project.```

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
### Razor
```
public class Meal
{
    public string Name { get; set; }
    public double Calories { get; set; }
    public List<string> Ingredients { get; set; }
}
The following template for Razor view engine accepts a Meal as model. 
Fill in the blanks with the simplest variants so that correct properties are printed.

<html>
<body>
  <h1>Name: @Model.Name</h1>
  <p>Calories: @Model.Calories</p>
  <p>Ingredients:</p>
  <ul>
    @foreach (var ingredient in Model.Ingredients )
    {
        <li>@ingredient</li>
    }
  </ul>
</body>
</html>
```

### Add actions to the AddressController
```
@model Address

<!DOCTYPE html>
<html>
<head>
  <title>Create a new address</title>
</head>
<body>
  <form method="post" action="/user/address/save">
    <label asp-for="Street">Street:</label>
    <input type="text" asp-for="Street" />
    <label asp-for="City">City:</label>
    <input type="text" asp-for="City" />
    <input type="submit" value="Submit" />
  </form>
</body>
</html>

Add actions to the AddressController so that:

On requests to "user/address/create", the view above should be returned.
On submitting the form from the view above, 
AddressController should add the Address 
that was submitted into the AddressController.addresses field 
and then redirect to the "user/address/create" URL.
Actions should use attribute routing

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class AddressController : Controller
{
    public static List<Address> addresses = new List<Address>();
    
    [Route("user/address/create")]
    
    public IActionResult Create() {
       return View();
    }
    
    
    [Route("user/address/save")]
    
    public IActionResult Save(Address model) {
    
       addresses.Add(model);
    
       return Redirect("user/address/create");
    }
}

public class Address
{
	public string Street { get; set; }

	public string City { get; set; }
}
```
### avoid live node (infinite loop)
```
function appendChildren(decorateDivFunction) {
  var allDivs = document.getElementsByTagName("div");
  allDivs = [].slice.call(allDivs, 0); //avoid live node

  for (var i = 0; i < allDivs.length; i++) {
    var newDiv = document.createElement("div");
    decorateDivFunction(newDiv);
    allDivs[i].appendChild(newDiv);
  }
}

// Example case. 
document.body.innerHTML = `
<div id="a">
  <div id="b">
  </div>
</div>`;

//appendChildren(function(div) {});
console.log(document.body.innerHTML);
```
