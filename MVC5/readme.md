
-  a controller class was that it inherits from System.Web.Mvc.Controller. 
-  controllers are really at the heart. Every request goes through a controller, whereas some will not need to make use of models and views.

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
