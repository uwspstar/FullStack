### Basic
- In general use, controllers are called via a URL, they execute your custom code, and they return a view
- usually return the appropriate ActionResult, which handles things such as HTTP status codes, calling the View templating system, and so on.
- input parameter embed it directly within the URL itself
- ASP.NET MVC’s default routing convention is to treat the segment of a URL after the action method name as a parameter named ID.
-  a controller class was that it inherits from System.Web.Mvc.Controller. 
-  controllers are really at the heart. Every request goes through a controller, whereas some will not need to make use of models and views.
- We’re using the HttpUtility.HtmlEncode utility method to sanitize the user input. This prevents users from injecting JavaScript code or HTML markup into our view
- M odels: Classes that represent the data of the application and that use validation logic to enforce business rules for that data.
- V iews: Template files that your application uses to dynamically generate HTML responses.
- C ontrollers: Classes that handle incoming browser requests, retrieve model data, and then specify view templates that return a response to the browser.
- HttpUtility.HtmlEncode to protect the application from malicious input (namely JavaScript).
- In ASP.NET MVC applications, it's more typical to pass in parameters as route data (like we did with ID above) than passing them as query strings.
- A view template should never perform business logic or interact with a database directly.
- ViewBag is a dynamic object, which means you can put whatever you want in to it
- the view model approach to passing data is generally much preferred over the view bag approach
-  ViewBag is useful when you want to pass information not related to the view model and you don’t want to create a view model just to pass the information.
- get in the habit of checking that Add Unit Tests box for every project you create.

### Code
-  You could supply a different view name, as follows:
```
public ActionResult Index() {   return View("NotIndex"); }
```

- You can use the tilde syntax to provide the full path to the view, as follows:
```
public ActionResult Index() {   return View("~/Views/Example/Index.cshtml"); }

When using the tilde syntax, you must supply the file extension of the view 
because this bypasses the view engine’s internal lookup mechanism for fi nding views


```
-  strongly typed views allow you to set a model type for a view. 
```
@using MvcMusicStore.Models 
@model IEnumerable<Album>

An even better approach for namespaces, which you’ll end up using often in views, 
is to declare the namespace in the web.config fi le within the Views directory.

<system.web.webPages.razor> 
… 
<pages pageBaseType="System.Web.Mvc.WebViewPage">   
  <namespaces>     
    <add namespace="System.Web.Mvc" />     
    <add namespace="System.Web.Mvc.Ajax" />     
    <add namespace="System.Web.Mvc.Html" />     
    <add namespace="System.Web.Routing" />
    <add namespace="MvcMusicStore.Models" />   
  </namespaces> 
</pages> 
</system.web.webPages.razor>

```

### VIEWDATA AND VIEWBAG
```
One obvious difference is that ViewBag works only when the key you’re accessing is a valid C# identifi er. 
For example, if you place a value in ViewData["Key With Spaces"], 
you can’t access that value using ViewBag because the code won’t compile.

Another key issue to consider is that you cannot pass in dynamic values as parameters to extension methods. 
The C# compiler must know the real type of every parameter at compile time 
in order to choose the correct extension method.

If any parameter is dynamic, compilation will fail. 
For example, this code will always fail: @Html.TextBox("name", ViewBag.Name). 
To work around this, either use ViewData["Name"] 
or cast the value to a specifi c type: (string)ViewBag.Name.

```
- ViewDataDictionary is a specialized dictionary class, not just a generic Dictionary. One reason for this is that it has an additional Model property that allows for a specifi c model object to be available to the view. 
-  A common application of this technique is using the ViewBag to provide form options for a dropdown. 
- One easy approach to displaying extra data that isn’t a part of your view’s main model is to simply stick that data in the ViewBag
- One recommended approach is to write a custom view model class. You can think of a view model as a model that exists just to supply information for a view
```
public class ShoppingCartViewModel 
{  
  public IEnumerable<Product> Products { get; set; }   
  public decimal CartTotal { get; set; }  
  public string Message { get; set; } 
}

```
