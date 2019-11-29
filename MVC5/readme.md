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
- This gives you the benefi ts of a strongly typed view (including type checking, IntelliSense, and freedom from having to cast untyped ViewDataDictionary objects) 
```
public class ShoppingCartViewModel 
{  
  public IEnumerable<Product> Products { get; set; }   
  public decimal CartTotal { get; set; }  
  public string Message { get; set; } 
}

```
### HTML Encoding 
- Given that many cases exist where a view is used to display user input, such as a blog post comment or a product review, the potential always exists for cross-site script injection attacks (also known as XSS)
- The good news is that Razor expressions are automatically HTML encoded.
```
@{   string message = "<script>alert('haacked!');</script>"; } <span>@message</span>

This code does not result in an alert box popping up but instead renders the encoded HTML:

<span>&lt;script&gt;alert(&#39;haacked!&#39;);&lt;/script&gt;</span>

```
- However, in cases where you intend to show HTML markup, you can return an instance of System .Web.IHtmlString and Razor will not encode it. 
```
For example, 
all the view helpers discussed later in this section return instances of this interface 
because they want HTML to be rendered to the page.
You can also create an instance of HtmlString or use the Html.Raw convenience method:

@{   string message = "<strong>This is bold!</strong>"; } <span>@Html.Raw(message)</span>

This results in the message being displayed without HTML encoding:
<span><strong>This is bold!</strong></span>

```
### HTML Encoding  vs JavaScript string encoding

- This automatic HTML encoding is great for mitigating XSS vulnerabilities by encoding user input meant to be displayed as HTML, but it is not suffi cient for displaying user input within JavaScript. 
- When setting variables in JavaScript to values supplied by the user, using JavaScript string encoding and not just HTML encoding is important. Use the @Ajax.JavaScriptStringEncode to encode the input. 
```
Here’s the same code again using this method to better protect against XSS attacks:

<script type="text/javascript">   
$(function () {       
  var message = 'Hello @Ajax.JavaScriptStringEncode(ViewBag.Username)';       
  $("#message").html(message).show('slow');   
}); 
</script>
```
- Understanding the security implications of HTML and JavaScript encoding is very important. Incorrect encoding can put both your site and your users at risk.

### layout
- A layout may have multiple sections. For example, add a footer section to the previous layout, SiteLayout.cshtml:
```
<!DOCTYPE html> 
<html> 
<head><title>@ViewBag.Title</title></head> 
  <body>   
    <h1>@ViewBag.Title</h1>   
    <div id="main-content">@RenderBody()</div>   
    <footer>@RenderSection("Footer")</footer> 
  </body> 
</html>
```
- The @section syntax specifi es the contents for a section defined in the layout.
```
@section Footer {    This is the <strong>footer</strong>. }

Earlier, it was pointed out that, by default, 
a view must supply content for every defi ned section. 
So what happens when you want to add a new section to a layout? Will that break every view?

Fortunately, the RenderSection method has an overload that allows you to specify t
hat the section is not required. 
To mark the Footer section as optional you can pass in false for the required parameter:

<footer>@RenderSection("Footer", required: false)</footer>

But wouldn’t it be nicer 
if you could defi ne some default content if the section isn’t defined in the view? 
Well, here’s one way. It’s a bit verbose, but it works.

<footer>  
  @if (IsSectionDefined("Footer")) {       RenderSection("Footer");   }  
  else {       <span>This is the default footer.</span>   } 
</footer>

```
### PARTIAL VIEW
- The partial view itself looks much like a normal view, except it doesn’t specify a layout:
```<h2>@ViewBag.Message</h2>```
### model binding 
- If the input names match the property names, why can’t you write a generic piece of code that pushes values around based on a naming convention? This is exactly what the model binding feature of ASP.NET MVC provides.
- The model binder is a bit like a search-and-rescue dog.

### A WORD ON MODEL BINDING SECURITY
```
ASP.NET MVC 5 now includes a comment with warning about over-posting attacks 
as well as the Bind attribute that restricts the binding behavior:

// POST: /StoreManager/Edit/5 
// To protect from overposting attacks, please enable the 
// specific properties you want to bind to, for more details see 
// http://go.microsoft.com/fwlink/?LinkId=317598. 

[HttpPost] [ValidateAntiForgeryToken] public ActionResult Edit    
([Bind(      
Include="AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")]      
Album album)

```
- Model binding implicitly goes to work when you have an action parameter. 
- You can also explicitly invoke model binding using the UpdateModel and TryUpdateModel methods in your controller. 
- TryUpdateModel also invokes model binding, but doesn’t throw an exception
-  You can check model state any time after model binding occurs to see whether model binding succeeded:
```
[HttpPost] public ActionResult Edit() 
{   
  var album = new Album();   
  TryUpdateModel(album);   
  if (ModelState.IsValid)
  {       
    db.Entry(album).State = EntityState.Modified;       
    db.SaveChanges();       
    return RedirectToAction("Index");   
  }   
  else   
  {       
    ViewBag.GenreId = new SelectList(db.Genres, "GenreId",                                        
    "Name", album.GenreId);       
    ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId",                                        
    "Name", album.ArtistId);       
    return View(album);   
  } 
}

```
- to using the Bind attribute to restrict implicit model binding, you can also restrict binding when you use UpdateModel and TryUpdateModel. Both methods have an override allowing you to specify an includeProperties parameter. 
```
This parameter contains an array of property names you’re explicitly allowing to be bound, 
as shown in the following code:

UpdateModel(product, new[] { "Title", "Price", "AlbumArtUrl" });

Any additional properties are ignored.
```

### Forms and HTML Helpers
- A form is a container for input elements: buttons, checkboxes, text inputs, and more
-  two most important attributes of a form tag: the action and the method attributes
- The action attribute tells a web browser where to send the information, so naturally the action contains a URL
- The method attribute tells the browser whether to use an HTTP POST or HTTP GET when sending the information. 
```
 However, the default method value is “get,” so by default a form sends an HTTP GET request:
 
<form action="http://www.bing.com/search" method="get">   
  <input name="q" type="text" />   
  <input type="submit" value="Search!" /> 
</form>

 ```
 ###  GET or to POST
- When a user submits a form using an HTTP GET request, the browser takes the input names and values inside the form and puts them in the query string.  http://www.bing .com/search?q=love.
- You can also give the method attribute the value post, in which case the browser does not place the input values into the query string, but places them inside the body of the HTTP request instead. 
-  Unlike the POST request, you can bookmark the GET request because all the parameters are in the URL. You can use the URLs as hyperlinks in an e-mail or a web page and preserve all the form input values.
- Even more importantly, the GET verb is the right tool for the job because GET represents an idempotent, read-only operation.
- You can send a GET request to a server repeatedly with no ill effects, because a GET does not (or should not) change state on the server
-  A POST request generally modifi es state on the server, and repeating the request might produce undesirable effects 
- Many browsers help a user avoid repeating a POST request. 
- Web applications generally use GET requests for reads and POST requests for writes (which typically include updates, creates, and deletes)

### Search Form
```
<form action="/Home/Search" method="get">   
  <input type="text" name="q" />   
  <input type="submit" value="Search" /> 
</form>

public ActionResult Search(string q) 
{   var albums = storeDB.Albums                      
  .Include("Artist")                       
  .Where(a => a.Title.Contains(q))                       
  .Take(10);   
  return View(albums); 
}

Notice how the Search action expects to receive a string parameter named q. 
The MVC framework automatically fi nds this value in the query string,
when the name q is present, and also fi nds the value in posted form values 
if you made your search form issue a POST instead of a GET.


@using (Html.BeginForm("Search", "Home", FormMethod.Get)) 
{   
  <input type="text" name="q" />   
  <input type="submit" value="Search" /> 
}


```
### BeginForm  & GetVirtualPath
```
The BeginForm HTML helper asks the routing engine how to reach the Search action of the HomeController. 
Behind the scenes it uses the method named GetVirtualPath on the Routes property exposed by RouteTable
— that’s where your web application registered all its routes in global.asax. 
If you did all this without an HTML helper, you would have to write all the following code:

@{   
  var context = this.ViewContext.RequestContext;   
  var values = new RouteValueDictionary{       
  { "controller", "home" }, { "action", "index" }   };   
  var path = RouteTable.Routes.GetVirtualPath(context, values); 
 } 
<form action="@path.VirtualPath" method="get">   
<input type="text" name="q" />   
<input type="submit" value="Search2" />
</form>

The last example demonstrates the essence of HTML helpers. 
They don’t take away your control, 
but they do save you from writing lots of code.




```
### HTML HELPERS
- HTML helpers are methods you can invoke on the Html property of a view
- You also have access to URL helpers (via the Url property), and
- Ajax helpers (via the Ajax property). 
- All these helpers have the same goal: to make views easy to author
- behind the scenes the helper is coordinating with the routing engine to generate a proper URL, so the code is more resilient to changes in the application deployment location.
```
@{Html.BeginForm("Search", "Home", FormMethod.Get);}   
<input type="text" name="q" />   
<input type="submit" value="Search" /> 
@{Html.EndForm();}
```
- All the helpers that output model values will HTML encode the values before renderin
-  Encoding by default helps you to avoid cross-site scripting attacks (XSS). 
```
@Html.TextArea("text", "hello <br/> world")

<textarea cols="20" id="text" name="text" rows="2">  hello &lt;br /&gt; world </textarea>
```
- Nearly every HTML helper in the MVC framework includes an htmlAttributes parameter in one of its overloaded methods
- You’ll also fi nd an htmlAttributes parameter of type IDictionary<string, object> in a different overload
- You can see you’ve set target=" _blank" using the htmlAttributes parameter. 
```
@using (Html.BeginForm("Search", "Home", FormMethod.Get,       
  new { target = "_blank" ", @class="editForm",  data_validatable=true }))

Another problem is setting attributes with a dash in the name (like data-val). 
Dashes are not valid in C# property names, 
but all HTML helpers convert an underscore in a property name to a dash when rendering the HTML. 
 
<form action="/Home/Search" class="editForm" data-validatable="true"     method="get" target="_blank">
```
- Every Razor view inherits an Html property from its base class. 
- The Html property is of type System.Web.Mvc.HtmlHelper<T> where T is a generic type parameter representing the type of the model for the view (dynamic by default). 
  
### System.Web.Mvc.HtmlHelper<T>
  
-  The class provides a few instance methods you can invoke in a view, such as EnableClientValidation
- AntiForgeryToken is an instance method, 
- BeginForm is an extension method
- Extension methods are a wonderful approach to building HTML helpers for two reasons 
  -  First, extension methods in C# are available only when the namespace of the extension method is in scope
- All MVC’s extension methods for HtmlHelper live in the System.Web.Mvc.Html namespace 
-  If you don’t like the built-in extension methods, you can remove this namespace and build your own.
- Html.BeginForm 
- Html.ValidationSummary - displays an unordered list of all validation errors in the ModelState dictionary. 
```
  @using (Html.BeginForm()) {   
    @Html.ValidationSummary(excludePropertyErrors: true)   
    <fieldset>       
      <legend>Edit Album</legend>
         <p>           
           <input type="submit" value="Save" />       
        </p>   
    </fieldset> 
 }

```
- Html.ValidationSummary - displays an unordered list of all validation errors in the ModelState dictionary. 
```
Assume you have the following code somewhere in the controller action rendering the edit view:
ModelState.AddModelError("", "This is all wrong!"); 
ModelState.AddModelError("Title", "What a terrible name!");

<div class="validation-summary-errors">   
  <ul>       
    <li>This is all wrong!</li>   
  </ul> 
</div>

```
- Html.TextBox and Html.TextArea
```
@Html.TextBox("Title", Model.Title)
<input id="Title" name="Title" type="text"      value="For Those About To Rock We Salute You" />

@Html.TextArea("text", "hello <br/> world")
<textarea cols="20" id="text" name="text" rows="2">hello &lt;br /&gt; world </textarea>

@Html.TextArea("text", "hello <br /> world", 10, 80, null)
<textarea cols="80" id="text" name="text" rows="10">hello &lt;br /&gt; world </textarea>
```
- Html.Label
```
Html.Label(“GenreId”) 
<label for="GenreId">Genre</label>
```
- Html.DropDownList and Html.ListBox  
```
public ActionResult Edit(int id) {                                          
  var album = storeDB.Albums.Single(a => a.AlbumId == id);
   ViewBag.Genres = new SelectList(storeDB.Genres.OrderBy(g => g.Name),
                                    "GenreId", "Name", album.GenreId);   
    return View(album); 
}


public ActionResult Edit(int id) {                                          
  var album = storeDB.Albums.Single(a => a.AlbumId == id);
  ViewBag.Genres =       storeDB.Genres              
   .OrderBy(g => g.Name)              
   .AsEnumerable()              
   .Select(g => new SelectListItem { 
     Text = g.Name,                               
     Value = g.GenreId.ToString(),                               
     Selected = album.GenreId == g.GenreId                            
   });   
   return View(album); 
}
```
- Html.ValidationMessag 
```
[HttpPost] 
public ActionResult Edit(int id, FormCollection collection) {   
    var album = storeDB.Albums.Find(id);
    ModelState.AddModelError("Title", "What a terrible name!");
    return View(album); 
}


@Html.ValidationMessage("Title")

<span class="field-validation-error" 
  data-valmsg-for="Title"     
  data-valmsg-replace="true">What a terrible name! 
</span>

@Html.ValidationMessage("Title", "Something is wrong with your title")

<span class="field-validation-error" data-valmsg-for="Title"    data-valmsg-replace="false">
Something is wrong with your title

```
### Helpers, Models, and View Data  
- all values in the ViewBag object are also available through ViewData
```
public ActionResult Edit(int id) {   
  ViewBag.Price = 10.0;   
  return View(); 
}

@Html.TextBox("Price")
<input id="Price" name="Price" type="text" value="10" />


public ActionResult Edit(int id) {   
  ViewBag.Album = new Album {Price = 11);   
  return View(); 
}

@Html.TextBox("Album.Price")
<input id="Album_Price" name="Album.Price" type="text" value="11" />


@{   ViewBag.Title = "Edit - " + Model.Title; }

```

### Strongly Typed Helpers
- Notice that the strongly typed helpers have the same names as the previous helpers you’ve been using, but with a For suffi x.
```
@model MvcMusicStore.Models.Album

@using (Html.BeginForm()) {   @Html.ValidationSummary(excludePropertyErrors: true)   
<fieldset>       
  <legend>Edit Album</legend>       
  <p>           
    @Html.LabelFor(m => m.GenreId)                 
    @Html.DropDownListFor(m => m.GenreId, ViewBag.Genres as SelectList)       
  </p>                   
  <p>                               
    @Html.TextBoxFor(m => m.Title)                   
    @Html.ValidationMessageFor(m => m.Title)       
  </p>       
  <input type="submit" value="Save" />   
</fieldset> }


```
### Helpers and Model Metadata
