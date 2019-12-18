# Professional ASP.NET MVC 5 1st Edition
- by Jon Galloway  (Author), Brad Wilson (Author), K. Scott Allen (Author), David Matson (Author)
- https://www.amazon.com/Professional-ASP-NET-MVC-Jon-Galloway/dp/1118794753/

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
- Encoding by default helps you to avoid cross-site scripting attacks (XSS). 
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
- ```Html.BeginForm``` 
- ```Html.ValidationSummary``` - displays an unordered list of all validation errors in the ModelState dictionary. 
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
- ```Html.ValidationSummary``` - displays an unordered list of all validation errors in the ModelState dictionary. 
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
- ```Html.TextBox and Html.TextArea```
```
@Html.TextBox("Title", Model.Title)
<input id="Title" name="Title" type="text"      value="For Those About To Rock We Salute You" />

@Html.TextArea("text", "hello <br/> world")
<textarea cols="20" id="text" name="text" rows="2">hello &lt;br /&gt; world </textarea>

@Html.TextArea("text", "hello <br /> world", 10, 80, null)
<textarea cols="80" id="text" name="text" rows="10">hello &lt;br /&gt; world </textarea>
```
- ```Html.Label```
```
Html.Label(“GenreId”) 
<label for="GenreId">Genre</label>
```
- ```Html.DropDownList and Html.ListBox```  
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
- ```Html.ValidationMessag``` 
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
- Notice that the strongly typed helpers have the same names as the previous helpers you’ve been using, but with a ```For suffi x```.
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
- Helpers do more than just look up data inside ViewData; they also take advantage of available model metadata
- The helper asks the runtime whether any model metadata is available for GenreId, and the runtime provides information from the DisplayName attribute decorating
```
@Html.Label("GenreId")
<label for="GenreId">Genre</label>

[DisplayName("Genre")] 
public int GenreId    { get; set; }
```

### Templated Helpers
- The ```templated helpers``` in ASP.NET MVC build HTML using metadata and a template.
- The metadata includes information about a model value (its name and type), as well as model metadata (added through data annotations or a custom provider).
- The templated helpers are ```Html.Display``` and ```Html.Editor```,
```
the Html.TextBoxFor helper renders the following HTML for an album’s Title property:
<input id="Title" name="Title" type="text"      value="For Those About To Rock We Salute You" />

Instead of using Html.TextBoxFor, you can switch to using the following code:
@Html.EditorFor(m => m.Title

[Required(ErrorMessage = "An Album Title is required")] 
[StringLength(160)] 
[DataType(DataType.MultilineText)] 
public string   Title      { get; set; }

<textarea class="text-box multi-line" id="Title" name="Title">   Let There Be Rock </textarea>

Because you asked for an editor in the generic sense, the EditorFor helper looked at the metadata 
and determined that the best HTML element to use was the textarea element
```
- The DisplayForModel and EditorForModel helpers build the HTML for an entire model object

### Helpers and ModelState
- ```ModelState``` is a byproduct of model binding and holds all validation errors detected during model binding. 
- Model state also holds the raw values the user submits to update a model.
- Helpers used to render form fi elds automatically look up their current value in the ModelState dictionary. 
- The helpers use the name expression as a key into the ModelState dictionary. 
- If an attempted value exists in ModelState, the helper uses the value from ModelState ```instead of``` a value in view data.
- The ModelState lookup allows bad values to preserve themselves after model binding fails

### OTHER INPUT HELPERS
- ```Html.Hidden```
```
@Html.Hidden("wizardStep", "1")
<input id="wizardStep" name="wizardStep" type="hidden" value="1" />
@Html.HiddenFor(m => m.WizardStep)
```
- ```Html.Password```
```
@Html.Password("UserPassword")
<input id="UserPassword" name="UserPassword" type="password" value="" />
@Html.PasswordFor(m => m.UserPassword)

```
- ```Html.RadioButton```
```
@Html.RadioButton("color", "red") 
@Html.RadioButton("color", "blue", true) 
@Html.RadioButton("color", "green")


<input id="color" name="color" type="radio" value="red" /> 
<input checked="checked" id="color" name="color" type="radio" value="blue" /> 
<input id="color" name="color" type="radio" value="green" />

@Html.RadioButtonFor(m => m.GenreId, "1") Rock 
@Html.RadioButtonFor(m => m.GenreId, "2") Jazz 
@Html.RadioButtonFor(m => m.GenreId, "3") Pop
```
- ```Html.CheckBox```
- You are probably wondering why the helper renders a hidden input in addition to the checkbox input. 
- The helper renders two inputs because the HTML specifi cation indicates that a browser will submit a value for a checkbox only when the checkbox is on (selected). 
```
@Html.CheckBox("IsDiscounted")

<input id="IsDiscounted" name="IsDiscounted" type="checkbox" value="true" /> 
<input name="IsDiscounted" type="hidden" value="false" />
```
### RENDERING HELPERS
- Rendering helpers produce links to other resources inside an application, 
- and can also enable you to build those reusable pieces of UI known as partial views
- Notice that you specify the controller name without the Controller suffi x. You never specify the controller’s type name.
- ```Html.ActionLink``` and ```Html.RouteLink ```
```
@Html.ActionLink("Link Text", "AnotherAction")
<a href="/Home/AnotherAction">LinkText</a>
@Html.ActionLink("Link Text", "Index", "ShoppingCart")

@Html.ActionLink("Edit link text", "Edit", "StoreManager", new {id=10720}, null)
```
- The RouteLink helper follows the same pattern as the ActionLink helper, but also accepts a route name and does not have arguments for controller name and action name. 
```
@Html.RouteLink("Link Text", new {action="AnotherAction"})
```
### URL Helpers
- The URL helpers are similar to the HTML ActionLink and RouteLink helpers, 
- but instead of returning HTML they build URLs and return the URLs as strings. 
- There are three helpers:```Action```, ```Content```, ```RouteUrl```
- ```Url.Action```
```
<span> 
@Url.Action("Browse", "Store", new { genre = "Jazz" }, null)       
</span>

<span>           
/Store/Browse?genre=Jazz       
</span>
```
- ```Url.Content```
- Using a tilde as the fi rst character in the parameter you pass to the Content helper lets the helper generate the proper URL no matter where your application is deployed 
- (think of the tilde as representing the application root directory). 
- In ASP.NET MVC 5, which uses Razor version 3, the tilde character is resolved automatically 
- when it appears in the src attribute for script, style, and img elements.  
```
<script src="@Url.Content("~/Scripts/jquery-1.10.2.min.js")"       
type="text/javascript">
</script

<script src="~/Scripts/jquery-1.5.1.min.js" type="text/javascript"></script>

```
###  ```Html.Partial``` and ```Html.RenderPartial```
- In general, you should ```prefer Partial``` to RenderPartial because Partial is more convenient
- The Partial helper renders a partial view into a string.
- Partial has four overloads
```
public void Partial(string partialViewName); 
public void Partial(string partialViewName, object model); 
public void Partial(string partialViewName, ViewDataDictionary viewData); 
public void Partial(string partialViewName, object model, ViewDataDictionary viewData);
```
- The RenderPartial helper is similar to Partial, but RenderPartial writes directly to the response output stream instead of returning a string.
- For this reason, you must place RenderPartial inside a code block instead of a code expression. 
```
@Html.Partial("AlbumDisplay")

@{Html.RenderPartial("AlbumDisplay "); } 

```
### Html.Action and Html.RenderAction 
- the difference between Action and RenderAction is that RenderAction writes directly to the response (which can bring a slight effi ciency gain). 
- Action and RenderAction are similar to the Partial and RenderPartial helpers
- The Partial helper typically helps a view render a portion of a view’s model using view markup in a separate file.
- Action, on the other hand, executes a separate controller action and displays the results. 
- Action offers more fl exibility and reuse because the controller action can build a different model and make use of a separate controller context.
```
public class MyController : Controller {  
public ActionResult Index() {   
return View();  
}

[ChildActionOnly]  
public ActionResult Menu() {    
var menu = GetMenuFromSomewhere();    
return PartialView(menu);  
} 
}

The Menu action builds a menu model and returns a partial view with just the menu:
@model Menu <ul> 
@foreach (var item in Model.MenuItem) {  
<li>@item.Text</li> 
} 
</ul>

In your Index.cshtml view, you can now call into the Menu action to display the menu:

<html> 
<head><title>Index with Menu</title></head> 
<body>   
@Html.Action("Menu")   
<h1>Welcome to the Index View</h1> 
</body> 
</html>
```
- Notice that the Menu action is marked with a ```ChildActionOnlyAttribute```. 
- ```The attribute prevents the runtime from invoking the action directly via a URL```. 
- Instead, only a call to Action or RenderAction can invoke a child action. 
- The ChildActionOnlyAttribute isn’t required, but is generally ```recommended``` for child actions.

### Passing Values to RenderAction
```
// M-odle
public class MenuOptions {   
public int Width { get; set; }   
public int Height { get; set; } 
} 

// C-onstroller
[ChildActionOnly] 
public ActionResult Menu(MenuOptions options) {   
return PartialView(options); 
}

// V-iew
@Html.Action("Menu", new {   
options = new MenuOptions { Width=400, Height=500 } 
})

```
- Another thing to note is that RenderAction honors the ActionName attribute when calling an action name.
```
// you’ll need to make sure to use CoolMenu as the action name and not Menu when calling RenderAction:

[ChildActionOnly] 
[ActionName("CoolMenu")] 
public ActionResult Menu(MenuOptions options) {   
return PartialView(options); 
}
```
### Data Annotations and Validation
- Using data annotations for validation
- Creating your own validation logic
- Using model metadata annotations
- When you talk about validation in an MVC design pattern context, you are primarily ```focusing on validating model value```
- MVC validation features can help you validate model values. 
- The validation features are extensible
-  a declarative style of validation using attributes known as ```data annotations```.
### ANNOTATING ORDERS FOR VALIDATION
- The problem is that customers can leave nearly the entire form blank and click the Submit Order button at the bottom of the form.
- You’ll fi x this problem using data annotations.
### Using Validation Annotations 
- Attribute-based validation ensures that your client- and server-side validation rules are kept in sync, because they’re declared in only one place.   
- Data annotations are attributes you can find in the ```System.ComponentModel.DataAnnotations``` namespace
- These attributes provide ```server-side``` validation, and the framework also supports ```client-side``` validation when you use one of the attributes on a model property. 
- This client-server synchronized validation is a pretty big deal—enforcing the same rules in JavaScript and on the server is important. 
- ```Required```
```
[Required] 
public string FirstName { get; set; }
```
- Like all the built-in validation attributes, the ```Required``` attribute delivers both server-side and clientside validation logic 
- although internally, it is another, different component in the MVC framework that delivers the client-side validation logic for the attribute through a validation adapter design
- However, even if customers do not have JavaScript enabled in their browser, the validation logic will catch an empty name property on the server, and they’ll see the exact same error message. 

- ```StringLength```
```
[Required] 
[StringLength(160)]
public string FirstName { get; set; }

// MinimumLength is an optional, named parameter you can use to specify the minimum length for a string.
[Required] 
[StringLength(160, MinimumLength=3)] 
public string FirstName { get; set; }

```
- ```RegularExpression```
- Regular expressions are an effi cient and terse means to enforce the shape and contents of a string value.
```
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")] public string Email { get; set; }
```
- ```Range```
```
[Range(35,44)] 
public int Age { get; set;}

// The Range attribute can work with integers and doubles, 
and another overloaded version of the constructor takes a Type parameter 
and two strings (which can allow you to add a range to date and decimal properties, for example).

[Range(typeof(decimal), "0.00", "49.99")] 
public decimal Price { get; set; }

```
- ```Compare```
```
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")] 
public string Email { get; set; }

[Compare("Email")] 
public string EmailConfirm { get; set; }

```
- ```Remote```
- Remote only exists because data annotations are extensible
- The ASP.NET MVC framework adds an additional Remote validation attribute. 
- This attribute is in the ```System.Web.Mvc``` namespace
- The Remote attribute enables you to perform ```client-side``` validation with a ```server callback```.
```
[Remote("CheckUserName", "Account")] 
public string UserName { get; set; }
// With the Remote attribute you can send the UserName value to the server, 
// and compare the value against the values in the database.
```
- Inside the attribute you can set the name of the action, and the name of the controller the client code should call. 
- The client code will send the value the user entered for the UserName property automatically, and an overload of the attribute constructor allows you to specify additional fields to send to the server.
```
public JsonResult CheckUserName(string username) {   
var result = Membership.FindUsersByName(username).Count == 0;   
return Json(result, JsonRequestBehavior.AllowGet); 
}
// The controller action will take a parameter with the name of the property to validate 
// and return a true or false wrapped in JavaScript Object Notation (JSON).

```
### Custom Error Messages and Localization
```
[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",                   
ErrorMessage="Email doesn't look like a valid email address.")] 
public string Email { get; set; }
```
- ErrorMessage is the name of the parameter in every validation attribute.
```
[Required(ErrorMessage="Your last name is required")] 
[StringLength(160, ErrorMessage="Your last name is too long")] 
public string LastName { get; set; }
```
- The custom error message can also have a single format item in the string. 
```
[Required(ErrorMessage="Your {0} is required.")] 
[StringLength(160, ErrorMessage="{0} is too long.")]
public string LastName { get; set; }

```
- In applications built for international markets, the ```hard-coded error messages``` are a ```bad idea```. 
- Fortunately, all the validation attributes also allow you to specify a resource type and a resource name for localized error messages:
```
[Required(ErrorMessageResourceType=typeof(ErrorMessages),         
ErrorMessageResourceName="LastNameRequired")] 

[StringLength(160, ErrorMessageResourceType = typeof(ErrorMessages),
ErrorMessageResourceName = "LastNameTooLong")] 
public string LastName { get; set; }

```
- The preceding code assumes you have a resource file in the project named ErrorMessages.resx with the appropriate entries inside (LastNameRequired and LastNameTooLong). 
-  For ASP.NET to use localized resource files, you must have the UICulture property of the current thread set to the proper culture
- https://docs.microsoft.com/en-us/previous-versions/bz9tc508(v=vs.140)?redirectedfrom=MSDN

### Looking Behind the Annotation Curtain Looking Behind the Annotation Curtain
- The validation features of ASP.NET MVC are part of a coordinated system involving model binders, model metadata, model validators, and model state
### Validation and Model Binding
- By default, the ASP.NET MVC framework executes validation logic during model binding. 
```
[HttpPost] public ActionResult Create(Album album) {   
// the album parameter was created via model binding   
// .. 
}

[HttpPost] public ActionResult Edit(int id, FormCollection collection) {   
var album = storeDB.Albums.Find(id);   
if(TryUpdateModel(album))   {      // ...   } 
}

```
- After the model binder is fi nished updating the model properties with new values, the model binder uses the current model metadata and ultimately obtains all the validators for the model.
- The MVC runtime provides a validator to work with data annotations (the DataAnnotationsModelValidator). 
- This model validator can fi nd all the validation attributes and execute the validation logic inside. 
- The model binder catches all the failed validation rules and places them into model state.

### Validation and Model State
-  If any errors exist in model state, ModelState.IsValid returns false.
```
ModelState.IsValid == false 
ModelState.IsValidField("LastName") == false 
ModelState["LastName"].Errors.Count > 0

var lastNameErrorMessage = ModelState["LastName"].Errors[0].ErrorMessage;

@Html.ValidationMessageFor(m => m.LastName)

```
### Controller Actions and Validation Errors 
```
[HttpPost] public ActionResult AddressAndPayment(Order newOrder) {   
if (ModelState.IsValid)   {                    
    newOrder.Username = User.Identity.Name;       
    newOrder.OrderDate = DateTime.Now;
    storeDB.Orders.Add(newOrder);       
    storeDB.SaveChanges();
    // Process the order       
    var cart = ShoppingCart.GetCart(this);       
    cart.CreateOrder(newOrder); 

    return RedirectToAction("Complete", new { id = newOrder.OrderId });   
  }   
  // Invalid -- redisplay with errors   
  return View(newOrder);      
}
```
-  You could also implement the action using an explicit call to UpdateModel or TryUpdateModel.
```
[HttpPost] public ActionResult AddressAndPayment(FormCollection collection) {   
var newOrder = new Order();   
UpdateModel(newOrder);  

if (ModelState.IsValid)   {                    
  newOrder.Username = User.Identity.Name;       
  newOrder.OrderDate = DateTime.Now;       
  storeDB.Orders.Add(newOrder);       
  storeDB.SaveChanges();
  // Process the order       
  var cart = ShoppingCart.GetCart(this);       
  art.CreateOrder(newOrder);                   
  return RedirectToAction("Complete", new { id = newOrder.OrderId });   
 }   
// Invalid -- redisplay with errors   
return View(newOrder);     
}

[HttpPost] public ActionResult AddressAndPayment(FormCollection collection) {   
var newOrder = new Order();   
if(TryUpdateModel(newOrder)) {                    
  newOrder.Username = User.Identity.Name;       
  newOrder.OrderDate = DateTime.Now;       
  storeDB.Orders.Add(newOrder);       
  storeDB.SaveChanges();
  // Process the order       
  var cart = ShoppingCart.GetCart(this);       
  art.CreateOrder(newOrder);                   
  return RedirectToAction("Complete", new { id = newOrder.OrderId });   
 }   
// Invalid -- redisplay with errors   
return View(newOrder);     
}

```
### CUSTOM VALIDATION LOGIC
- Packaging validation logic into a custom data annotation
- Packaging validation logic into a model object itself
- All the validation annotations (such as Required and Range) ultimately derive from the ValidationAttribute base class.
- The base class is abstract and lives in the System .ComponentModel.DataAnnotations namespace
- Your validation logic will also live in a class deriving from ValidationAttribute:
```
using System.ComponentModel.DataAnnotations;
namespace MvcMusicStore.Infrastructure {   
public class MaxWordsAttribute : ValidationAttribute   
{ ...  } 
}
```
- To implement the validation logic, you need to override one of the IsValid methods provided by the base class.
-  Overriding the IsValid version taking a ValidationContext parameter provides more information to use inside the IsValid method 
- (the ValidationContext parameter gives you access to the model type, model object instance, and friendly display name of the property you are validating, among other pieces of information).
```
public class MaxWordsAttribute : ValidationAttribute {    
public MaxWordsAttribute(int maxWords)   {       
  _maxWords = maxWords;   
} 
protected override ValidationResult IsValid (object value, ValidationContext validationContext)   {   
  if (value != null) {           
    var valueAsString = value.ToString();           
    if (valueAsString.Split(' ').Length > _maxWords) {               
      return new ValidationResult("Too many words!");           
    }       
  }
  return ValidationResult.Success;   
} 
}
```
- The problem with the last block of code is the hard-coded error message
```
public class MaxWordsAttribute : ValidationAttribute {    
public MaxWordsAttribute(int maxWords) :base("{0} has too many words.") 
{       
  _maxWords = maxWords;   
} 
protected override ValidationResult IsValid (object value, ValidationContext validationContext)   {   
  if (value != null) {           
    var valueAsString = value.ToString();           
    if (valueAsString.Split(' ').Length > _maxWords) { 
      var errorMessage = FormatErrorMessage(validationContext.DisplayName);
      return new ValidationResult(errorMessage);           
    }       
  }
  return ValidationResult.Success;   
} 
}
```
### IValidatableObject
- A model object can announce this capability by implementing the IValidatableObject interface. 
- The method the MVC runtime calls to perform validation is named Validate instead of IsValid
- more important, the return type and parameters are different.
- The return type for Validate is an IEnumerable<ValidationResult> instead of a single ValidationResult
- No value parameter is passed to Validate because you are inside an instance method of the model and can refer to the property values directly.
- the code uses the C# yield return syntax to build the enumerable return value
```
public class Order : IValidatableObject {   
public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)   {       
    if (LastName != null && LastName.Split(' ').Length > 10)       {           
      yield return new ValidationResult("The last name has too many words!", new []{"LastName"});       
    }   
}   
// rest of Order implementation and properties  // 
}
```

### Display
```
[Required]     
[StringLength(160, MinimumLength=3)] 
[Display(Name="First Name"),  Order=15001] 
public string FirstName { get; set; }
```
### ScaffoldColumn
- The ScaffoldColumn attribute hides a property from HTML helpers such as EditorForModel and DisplayForModel:
```
[ScaffoldColumn(false)]       
public string Username { get; set; }
```
### DisplayFormat
- The ApplyFormatInEditMode parameter is false by default
- One reason ApplyFormatInEditMode is false by default is because the MVC model binder might not like to parse a value formatted for display.
```
[DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:c}")] 
public decimal Total { get; set; }

```
### ReadOnly
- the EditorForModel helper will still display an enabled input for the property, so only the model binder respects the ReadOnly attribute
```
[ReadOnly(true)]            
public decimal Total { get; set; }
```
### DataType  
- The DataType attribute enables you to provide the runtime with information about the specifi c purpose of a property.
```
[Required] 
[DataType(DataType.Password)] 
[Display(Name="Password")] 
public string Password { get; set; }
```
### UIHint 
- The UIHint attribute gives the ASP.NET MVC runtime the name of a template to use when rendering output with the templated helpers (such as DisplayFor and EditorFor).

### HiddenInput 
- Hidden inputs are a great way to keep information in a form so the browser will send the data back to the server, but the user won’t be able to see or edit the data  
- The HiddenInput attribute lives in the System.Web.Mvc namespace and tells the runtime to render an input element with a type of hidden. 

### Membership, Authorization, and Security
- Requiring login with the Authorize Attribute   
- Requiring role membership using the Authorize Attribute 
- Using security vectors in a web application
- Coding defensively
### Never, ever trust any data your users give you. Ever
- ASP.NET MVC doesn’t have as many automatic protections as ASP.NET Web Forms does to secure your page against malicious users.  
- Any time you render data that originated as user input, encode it.  
- Think about what portions of your site should be available for anonymous access, and require authentication on the others.   
- Don’t try to sanitize your users’ HTML input yourself (using regular expressions or some other method)—you’ll lose.  
- Use HTTP-only cookies when you don’t need to access cookies via client-side script (which is most of the time).
- Remember that external input isn’t just obvious form fields; 
- it includes URL query string values, hidden form fi elds, Ajax requests, results of external web services you’re using, and more
- Consider using the AntiXSS encoder (a component of the Microsoft Web Protection Library, which is now distributed with ASP.NET 4.5 and higher).

### USING THE AUTHORIZE ATTRIBUTE TO REQUIRE LOGIN
- using the Authorize action fi lter on a controller, on specific actions within a controller, or even globally for the entire application
- ```authentication``` is verifying that users are who they say they are, using some form of login mechanism (username/password, OpenID, OAuth and so on— something that says “this is who I am”).
- ```Authorization``` is verifying that they can do what they want to do with respect to your site. This is usually achieved using some type of role-based or claim-based system.
- ```Without any parameters```, the Authorize attribute just requires that the user is logged in to the site in any capacity—in other words, it just ```forbids anonymous access```
```
[Authorize]       
public ActionResult Buy(int id) {           
var album = GetAlbums().Single(a => a.AlbumId == id);
//Charge the user and ship the album!!!           
return View(album);       
}
```
### USING URL AUTHORIZATION
- A good approach to security is to always put the security check as close as possible 
- This way, no matter how the user got to the resource, there will always be a security check
- In this case, you don’t want to rely on routing and URL authorization to secure a controller; 
- you really want to secure the controller itself. The AuthorizeAttribute serves this purpose
-  With ```ASP.NET Web Forms``` (NOT MVC), you can secure a directory on your site by locking it down in the ```web.config```:
```
<location path= "Admin" allowOverride="false"> 
<system.web>  
  <authorization>    
    <allow roles= "Administrator" />    
    <deny users="?" />  
  </authorization> 
</system.web> 
</location>
```
- ```With MVC``` that approach ```won’t work``` so well for two reasons
- Requests no longer map to physical directories
- There may be more than one way to route to the same controller
### How AuthorizeAttribute Works with Forms Authentication and the AccountController 
- The ASP.NET MVC template with Individual User Accounts authentication includes an AccountController that implements support for both local accounts and external accounts managed by OpenID and OAuth authentication
- The AuthorizeAttribute is an authorization fi lter, which means that it executes before the associated controller action.
- The AuthorizeAttribute performs its main work in the OnAuthorization method, which is a standard method defi ned in the IAuthorizationFilter interface. 
- If the user fails authorization, an HttpUnauthorizedResult action result is returned, which produces an HTTP 401 (Unauthorized) status code.
- A ```401``` status code is an entirely accurate response to an unauthorized request, but it’s not entirely friendly. 
- Most websites don’t return a raw HTTP ```401``` response for the browser to handle. 
- Instead, they commonly use an HTTP ```302``` to redirect the user to the login page in order to authenticate a user with rights to view the original page
```
IPrincipal user = httpContext.User; 
if (!user.Identity.IsAuthenticated) {       
return false; 
}
if (_usersSplit.Length > 0 &&  !_usersSplit.Contains(user.Identity.Name, StringComparer.OrdinalIgnoreCase)) {
return false; 
}
if (_rolesSplit.Length > 0 && !_rolesSplit.Any(user.IsInRole)) {       
return false; 
}
return true;

```
-  When you’re using cookie-based authentication (the default for an ASP.NET MVC application using the individual user accounts such as username / password or OAuth login), ASP.NET MVC handles the response conversion from a 401 to a 302 redirect for you automatically.
- In ASP.NET MVC 5, the 401 to 302 redirection process is handled by OWIN (Open Web Interface for .NET) middleware components
- Cookie-based authentication is handled by the CookieAuthenticationHandler (found in the Microsoft. Owin.Cookies namespace).
- http://brockallen.com/2013/08/07/owin-authentication-middleware-architecture/
```
In previous versions of ASP.NET MVC, 
this redirection is handled by the FormsAuthenticationModule OnLeave method, 
which instead redirects to the application login page defi ned in the application’s web.config, 
as shown here:
<authentication mode="Forms"> 
<forms loginUrl="~/Account/LogOn" timeout="2880" /> 
</authentication>
This redirection address includes a return URL, 
so after completing login successfully, 
the Account LogOn action redirects to the originally requested page.
```
- The AuthorizeAttribute is a standard authorization attribute, implementing IAuthorizeFilter. You can create your own authorization fi lters.
### Windows Authentication
-  Windows Authentication option, authentication is effectively handled outside of the application by the web browser, Windows, and IIS. 
- Startup.Auth.cs is not included in the project, and no authentication middleware is confi gured.
-  To confi gure Windows Authentication, this template includes the following line in ```web .config```:
```
<authentication mode="Windows" />
```
### Securing Entire Controllers 
```
[Authorize] public class CheckoutController : Controller
```
### Securing Your Entire Application Using a Global Authorization Filter 
- requiring authorization by default and making exceptions in the few places where anonymous access is allowed
- configuring the AuthorizeAttribute as a global filter and allowing anonymous access to specific controllers or methods using the AllowAnonymous attribute is a good idea
- To register the AuthorizeAttribute as a global fi lter, add it to the global fi lters collection in the RegisterGlobalFilters method, located in \App_Start\FilterConfig.cs:
```
public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
filters.Add(new System.Web.Mvc.AuthorizeAttribute());    
filters.Add(new HandleErrorAttribute()); 
}
```
- GLOBAL AUTHORIZATION IS GLOBAL ONLY TO MVC
- Keep in mind that a global fi lter applies only to MVC controller actions. It doesn’t secure Web Forms, static content, or other ASP.NET handlers.
- MVC 4 added a new AllowAnonymous attribute. 
- You can place AllowAnonymous on any methods (or entire controllers) to opt out of authorization as desired.
```
// // GET: /Account/Login 
[AllowAnonymous] 
public ActionResult Login(string returnUrl) {
ViewBag.ReturnUrl = returnUrl;       
return View(); 
}

// This way, even if you register the AuthorizeAttribute as a global filter, users can access the login actions.
```
### USING AUTHORIZEATTRIBUTE TO REQUIRE ROLE MEMBERSHIP
- AuthorizeAttribute allows you to specify both roles and users, as shown here:
```
[Authorize(Roles="Administrator")] 
public class StoreManagerController : Controller
// This restricts access to the StoreManagerController to users who belong to the Administrator role. 
```
- the Roles parameter can take more than one role. You can pass in a comma-delimited list:
```
[Authorize(Roles="Administrator,SuperAdmin")] 
public class TopSecretController:Controller
```
- You can also authorize by a list of users:
```
[Authorize(Users="Jon,Phil,Scott,Brad,David")] 
public class TopSecretController:Controller
```
- And you can combine them, as well:
```
[Authorize(Roles="UsersNamedScott", Users="Jon,Phil,Brad,David")] 
public class TopSecretController:Controller
```
- Managing your permissions based on roles instead of users is generally considered a better idea, 
```
for several reasons:

- Users can come and go, and a specifi c user is likely to require (or lose) permissions over time. 
- Managing role membership is generally easier than managing user membership.
- Role-based management enables you to have different access lists across deployment environments.
```
- When you’re creating role groups, consider using privileged-based role groups
```
For example, 
roles named CanAdjustCompensation and CanEditAlbums are more granular 
and ultimately more manageable than overly generic groups like Administrator 
followed by the inevitable SuperAdmin and the equally inevitable SuperSuperAdmin.
```
- ASP.NET has supported claims-based authorization since .NET 4.5, although it’s not surfaced by AuthorizeAttribute. 

### the difference between roles and claims
- This means that roles are really a specifi c case of claims, because membership in a role is just one simple claim.
- Role membership is a simple Boolean—a user either is a member of the role or not. 
- A claim can contain a value, not just a simple Boolean. 
- This means that users’ claims might include their username, their corporate division, the groups or level of other users they are allowed to administer, and so on.
- So with claims, you wouldn’t need a bunch of roles to manage the extent of compensation adjustment powers (CanAdjustCompensationForEmployees, CanAdjustCompensationForManagers, and so on).
- A single claim token can hold rich information about exactly which employees you rule.

### EXTENDING USER IDENTITY
- t http://asp.net/identity

### Storing additional user proﬁ le data 
-  adding properties to your ApplicationUser class (found in /Models/IdentityModels.cs). 
```
public class ApplicationUser : IdentityUser 
{   
public string Address { get; set; }   
public string TwitterHandle { get; set; } 
}

```

### Persistance control 
- http://www.asp.net/identity/overview/extensibility/overview-of-custom-storage-providers-for-aspnet-identity.

### Managing users and roles
-  http://azure.microsoft.com/en-us/documentation/articles/web-sites-dotnet-deploy-aspnet-mvc-app-membership-oauth-sql-database/.

### EXTERNAL LOGIN VIA OAUTH AND OPENID
- Maintaining a local database of usernames and secret passwords is a large security liability.
- Website registration is annoying
- OAuth and OpenID are open standards for authentication
- NOTE Technically, the OAuth protocol was designed for authorization, but in general use it’s frequently used for authentication.
- These protocols allow your users to log in to your site using their existing accounts on other trusted sites (called providers), such as Google, Twitter, Microsoft, and others. 

### Registering External Login Provider
- Authorization providers are confi gured in App_Start\Startup.Auth.cs
- http://go.microsoft.com/fwlink/?LinkId=301864

### Conﬁguring OpenID Providers
- OAuth is not really designed for authentication; it was designed for resource sharing between sites. 
- However, it was more widely adopted by providers (Twitter, Facebook, Microsoft Account, and so on) than OpenID, and implementing sites and users followed. 
- The example code to implement Google provider support is already included in Startup.Auth.cs, 
```
public partial class Startup {       
public void ConfigureAuth(IAppBuilder app)       {             
// Use a cookie to temporarily store information about              
// a user logging in with a third party login provider                         
  app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
  app.UseGoogleAuthentication();       
} 
}

```
### Conﬁ guring OAuth Providers
- the MVC 5 OAuth middleware does not depend on an external OAuth implementation.
-  http://go.microsoft.com/fwlink/?LinkId=301864
- Facebook authentication using the following call in Startup.Auth.cs:
```
public partial class Startup {       
public void ConfigureAuth(IAppBuilder app) {             
  // Use a cookie to temporarily store information about              
  // a user logging in with a third party login provider                            
  app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);
  app.UseFacebookAuthentication(                
    appId: "123456789012",                
    appSecret: "abcdefabcdefdecafbad");       
} 
}

```
### Security Implications of External Logins 
### Trusted External Login Providers
### Requiring SSL for Login
- The callback from an external provider to your site contains security tokens that allow access to your site and contain user information. 
- To enforce HTTPS for this callback, applications that support external logins should require HTTPS for access to the AccountController’s Login GET method using the RequireHttps attribute:
```
// // GET: /Account/Login
[RequireHttps] 
[AllowAnonymous] 
public ActionResult Login(string returnUrl) {
ViewBag.ReturnUrl = returnUrl;
return View();
}
```
- Additionally, using HTTPS with Google authentication is important. 
- Google reports a user who logs in once via HTTP and later via HTTPS as two different people. 

### UNDERSTANDING THE SECURITY VECTORS IN A WEB APPLICATION
- ```Every bit of output on your pages should be HTML encoded or HTML attribute encoded. ```

### Threat: Cross-Site Scripting
- cross-site scripting (XSS). 
- XSS can be carried out in one of two ways:
```
by a user entering nasty script commands into a website that accepts unsanitized user input 
or by user input being directly displayed on a page
```
-  ```unsanitized``` user input or by user input being directly displayed on a page. 
- The first example is called ```passive injection```- whereby a user enters nastiness into a textbox, for example, and that script gets saved into a database and redisplayed later. 
- The second is called ```active injection``` and involves a user entering nastiness into an input, which is immediately displayed onscreen
- No validation is in place to tell you that the URL you’ve entered is invalid!
- A cross-site request forgery (CSRF, pronounced C-surf, also known by the acronym XSRF) 
-  you would probably do something like this: Even when you hover over the name in the post, you won’t see the injected script tag
```
"></a><script src="http://srizbitrojan.evil.example.com"></script> <a href="
```
- Active Injection 
```
Active XSS injection involves a user sending in malicious information that is immediately shown on the page 
and is not stored in the database.
```
### Preventing XSS 
- HTML Encode All Content : Most of the time, you can avoid XSS by using simple HTML encoding
- ASP.NET 4 HTML Encoding
```
<% Html.Encode(Model.FirstName) %>
can replace  shorter:
<%: Model.FirstName %>
```
- The Razor view engine HTML encodes output by default, so a model property displayed using:
```@Model.FirstName```

- If you are absolutely certain that the data has already been sanitized or comes only from a trusted source (such as yourself), you can use an HTML helper to output the data verbatim:
```@Html.Raw(Model.HtmlContent) ```
-  Not all server controls protect against XSS (for example, Labels and Literals), 

### Html.AttributeEncode and Url.Encode 
- This replaces reserved characters in the URL with other characters (" " with %20, for example).
```
<a href="<%=Url.Action(AuthorUrl)%>"><%=AuthorUrl%></a>
<a href="<%=Url.Action("index","home",new {name=ViewData["name"]})%>">Go home</a>

You can avoid this by using encoding with Url. Encode or Html.AttributeEncode:
<a href="<%=Url.Action("index","home",new {name=Html.AttributeEncode(ViewData["name"])})%>">Click here</a>
or:
<a href="<%=Url.Encode(Url.Action("index","home", new {name=ViewData["name"]}))%>">Click here</a>

```
- Never, ever trust any data that your user can somehow touch or use

### JavaScript Encoding 
- HTML encoding, not JavaScript encoding
- That means that the hacker could take advantage of hex escape codes to put in any JavaScript code he or she wanted. 
-  The narrow solution is to use the ```Ajax .JavaScriptStringEncode helper``` function to encode strings that are used in JavaScript, exactly as you would use Html.Encode for HTML strings.
-  A more thorough solution is to use the ```AntiXSS library```.
### Using AntiXSS as the Default Encoder for ASP.NET
- AntiXSS uses a whitelist of allowed characters, whereas ASP.NET’s default implementation uses a limited blacklist of disallowed characters.
- The AntiXSS library is focused on preventing security vulnerabilities in your applications, whereas ASP.NET encoding is primarily focused on preventing display problems due to “broken” HTML.
- The AntiXSS encoder portion of the Microsoft Web Protection Library (WPL) is included with .NET 4.5 and higher. 
- Just need to make a one-line addition to the httpRuntime section of your web.config:
```
<httpRuntime ... 
encoderType="System.Web.Security.AntiXss.AntiXssEncoder,System.Web,  
Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
```
- With that in place, any time you call Html.Encode or use an <%:%> HTML Encoding Code Block, the AntiXSS library encodes the text, which takes care of both HTML and JavaScript encoding.
- The portions of the AntiXSS library included in .NET 4.5 are
```
- HtmlEncode, HtmlFormUrlEncode, and HtmlAttributeEncode 
- XmlAttributeEncode and XmlEncode 
- UrlEncode and UrlPathEncode
- CssEncod 
```
-  @using statement to bring in the AntiXSS encoder namespace, and then you can use the Encoder.JavaScriptEncode helper function.
```
@using Microsoft.Security.Application 
...
@section scripts {    
@if(ViewBag.UserName != null) {    
  <script type="text/javascript">        
    $(function () {                
      var msg = 'Welcome, @Encoder.JavaScriptEncode(                    
      ViewBag.UserName, false)!';          
      $("#welcome-message").html(msg).hide().show('slow');        
    });    
  </script>    
} 
}
```
### Threat: Cross-Site Request Forgery
- A cross-site request forgery (CSRF, pronounced C-surf, also known by the acronym XSRF)
- XSS plus a confused deputy
-  ```deputy``` is your browser, and it’s being tricked into misusing its authority in representing you to a remote website. 
-  [ValidateAntiForgeryToken]
- the session cookie information is what keeps you from logging in for every page request! The browser has to remember something!
```
"OMG you're right! How weird!
<img src =" http://widelyusedbank.example.com?function=transfer
&amount=1000&toaccountnumber= 23234554333&from=checking" />.

```
### Preventing CSRF Attacks 
### Token Veriﬁ cation 
- The simplest way to do this is to embed a hidden input into each form request that contains a unique value. You can do this with the HTML Helpers by including this in every form:
```
<form action="/account/register" method="post"> 
@Html.AntiForgeryToken() … 
</form>

Html.AntiForgeryToken outputs an encrypted value as a hidden input:
<input type="hidden" value="012837udny31w90hjhf7u">

This value matches another value that is stored as a session cookie in the user’s browser. 
When the form is posted, these values are matched using an ActionFilter:

[ValidateAntiforgeryToken] 
public ActionResult Register(…)

This handles most CSRF attacks — but not all of them. 
```
### Idempotent GETs 
-  If an operation is idempotent, it can be executed multiple times without changing the result. 
-  In general, a good general rule is that you can prevent a whole class of CSRF attacks by only changing things in your DB or on your site by using POST. 
- This means registration, logout, login, and so forth. At the very least, this limits the confused deputy attacks somewhat.

### HttpReferrer Validation 
- HttpReferrer validation is handled using an ActionFilter, wherein you check to see whether the client that posted the form values was indeed your site:
```
public class IsPostedFromThisSiteAttribute : AuthorizeAttribute {   
public override void OnAuthorize(AuthorizationContext filterContext)   {       
  if (filterContext.HttpContext != null)       {           
      if (filterContext.HttpContext.Request.UrlReferrer == null)               
        throw new System.Web.HttpException("Invalid submission");
      if (filterContext.HttpContext.Request.UrlReferrer.Host !="mysite.com")                   
        throw new System.Web.HttpException("This form wasn't submitted from this site!");       
   }   
 } 
}

```
- You can then use this fi lter on the Register method, as follows:
```
[IsPostedFromThisSite] public ActionResult Register(…
```
### Threat: Cookie Stealing

- Cookies are one of the things that make the Web usable, as most sites use cookies to identify users after login
- Websites use cookies to store information between page requests or browsing sessions

### There are two types of cookies:
- Session cookies: Stored in the browser’s memory and are transmitted via the header during every request
- Persistent cookies: Stored in actual text fi les on your computer’s hard drive and are transmitted the same way.
- The main difference is that session cookies are forgotten when your session ends—persistent cookies are not, and a site will remember you the next time you come along.
### Preventing Cookie Theft with HttpOnl
You can stop script access to all cookies in your site by adding a simple flag: ```HttpOnly```. You can set this flag in the ```web.config```, as follows:
```
<httpCookies domain="" httpOnlyCookies="true" requireSSL="false" />
```
You can also set it individually for each cookie you write:
```
Response.Cookies["MyCookie"].Value="Remembering you…"; 
Response.Cookies["MyCookie].HttpOnly=true
```
### Threat: Over-Posting 
- An over-posting attack exploits a feature that is common to many web frameworks that are based on the MVC architectural pattern.
-  In March 2012, this exact attack was used in a widely publicized attack on the GitHub.com site, exploiting the mass assignment feature Ruby on Rails
- The model binder has no idea what fi elds you’ve included on your form and will happily set the Approved property to true.

### Preventing Over-Posting with the Bind Attribut
- The simplest way to prevent an over-posting attack is to use the BindAttribute to explicitly control which properties you want the Model Binder to bind to.
- You can place BindAttribute either on the Model class or in the controller action parameter. 
-  You can use either a whitelist approach (discussed previously), which specifi es all the fi elds you’ll allow binding to [Bind(Include="Name, Comment")], or you can just exclude fi elds you don’t want to be bound to using a blacklist approach [Bind(Exclude="ReviewID, ProductID, Product, Approved"]. 
- Generally using a ```whitelist is a lot safer```, because making sure you just list the properties you want bound is easier than enumerating all the properties you don’t want bound
- the best—way to deal with over-posting is to avoid binding directly to the data model. using a ```ViewModel```
```
public class ReviewViewModel { 
public string Name { get; set; } 
public string Comment { get; set; } 
}
```
- http://bradwilson.typepad.com/ blog/2010/01/input-validation-vs-model-validation-in-aspnet-mvc. html.
### Threat: Open Redirection 
- Any web application that redirects to a URL that is specifi ed via the request, such as the query string or form data, can potentially be tampered with to redirect users to an external, malicious URL. This tampering is called an ```open redirection attack```.
-  you must verify that the redirection URL hasn’t been tampered with
-  ReturnUrl query string parameter is not validated, an attacker can modify it to inject any URL address into the parameter to conduct an open redirection attack. 
```
/Account/LogOn?ReturnUrl=%2fAccount%2fChangePassword%2f
```
### Looking at the Vulnerable Code in the AccountController LogOn Action 
- MVC 5 Login action
```
return RedirectToLocal(returnUrl);
```
### Taking Additional Actions When an Open Redirect Attempt Is Detected 
-  You may want to take additional actions when an open redirect is detected.
```
private ActionResult RedirectToLocal(string returnUrl) {  
if (Url.IsLocalUrl(returnUrl))  {    
  return Redirect(returnUrl);  }  
else  {     
  // Actions on for detected open redirect go here.     
  string message = string.Format("Open redirect to to {0} detected.", returnUrl);     
  ErrorSignal.FromCurrentContext().Raise(new System.Security.SecurityException(message));     
  return RedirectToAction("SecurityWarning", "Home");  
} 
}

```
### PROPER ERROR REPORTING AND THE STACK TRACE
- There are ```three possible settings for the customErrors mode```:
- ```On``` is the safest for production servers, because it always hides error messages. 
- ```RemoteOnly``` shows generic errors to most users, but exposes the full error messages to users with server access. 
- The most vulnerable setting is ```Off```, which exposes detailed error messages to anyone who visits your website.

### Using Conﬁ guration Transforms 
- recommend you use web.config transforms to manage the customErrors setting based on the build confi guration
```
<system.web>
<compilation xdt:Transform="RemoveAttributes(debug)" /> 
<customErrors defaultRedirect="GenericError.htm"       
mode="RemoteOnly" xdt:Transform="Replace">       
  <error statusCode="500" redirect="InternalError.htm"/>     
</customErrors>
</system.web>
```
### Using Retail Deployment Conﬁ guration in Production
```
<system.web>  
<deployment retail="true" /> 
</system.web>

Setting deployment / retail to true does a few things:
➤ customErrors mode is set to On (the most secure setting) 
➤ Trace output is disabled 
➤ Debug is disabled

```
### Using a Dedicated Error Logging System
- http://code.google.com/p/ elmah/
### SECURITY RECAP AND HELPFUL RESOURCES
- Table 7-1 (PAGE 209)
- http://msdn.microsoft.com/en-us/security/default.aspx
- http://www.wrox.com/WileyCDA/WroxTitle/Beginning-ASP-NET-Security.productCd-0470743654.html

### Ajax
### The jQuery Function
- is aliased to the $ sign (because $ requires less typing and is a legal function name in JavaScript)
```
$(function () {
 $("#album-list img").mouseover(function () {
     $(this).animate({ height: '+=25', width: '+=25' })
            .animate({ height: '-=25', width: '-=25' });
 });
})
```
- The first line of code invokes the jQuery function ($) and passes an anonymous JavaScript function as the first parameter
- the this keyword (this points to the element where the event occurred). 
```
When you pass a function as the first parameter, 
jQuery assumes you are providing a function to execute 
as soon as the browser is finished building a document object model (DOM) 
from HTML supplied by the server—that is, 
the code will run after the HTML page is done loading from the server.
```
### jQuery Selector
- EXAMPLE MEANING
```
$("#header") Find the element with an id of "header"
$(".editor-label") Find all elements with a class name of ".editor-label"
$("div") Find all <div> elements
$("#header div") Find all <div> elements that are descendants of the element with an id of "header"
$("#header > div") Find all <div> elements that are children of the element with an id of "header"
$("a:even") Find evenly numbered anchor tags
```
### jQuery Events
- NOTE The jQuery on method (and the corresponding off method, to unsubscribe from an event) was added in jQuery 1.7 to provide a unifi ed API for event binding. 
- The on method replaces the previous bind, live, and delegate methods; in fact, if you look at the source code you can see that the bind, live, and delegate methods just pass the call to on. 
- method chaining
- jQuery shortcuts

### Using jQuery
- The core jQuery library is the fi le named jquery-<version>.js
-  a jQuery script reference is included in the footer of the site layout (/Views/Shared/_Layout.cshtml), 
```
<script src="~/Scripts/jquery-1.10.2.js"></script>
```
- Razor view engine will resolve the ~ operator to the root of the current website
- the type attribute as text/javascript isn’t needed in HTML 5.
- in ```/Views/Shared/_Layout.cshtml``` as shown in the following code:
```
@Scripts.Render("~/bundles/jquery")
```
- NOTE The previous call renders the predefi ned "jquery" script bundle from /App_Start/BundleConfig.cs.
```
public static void RegisterBundles(BundleCollection bundles) 
{
bundles.Add(new ScriptBundle("~/bundles/jquery").Include( 
"~/Scripts/jquery-{version}.js"));
//Other bundles removed for brevity... 
}
```
### Visual Studio shows IntelliSense based on method names and any inline triple-slash comments included in scripts.
### scripts
- _references.js is just a list of JavaScript libraries in your project, written out using triple-slash (///) comments. 
- http://madskristensen.net/post/ the-story-behind-_referencesjs.
- .min.js fi les. Each contains a minimized version of another script fi le. JavaScript minimization is the process of shrinking a JavaScript fi le by removing comments, thus shortening variable names, and other processes that reduce the fi le size. 
- Respond.js is a tiny JavaScript library, included because it’s required by Bootstrap. It’s what’s known as a polyfi ll: a JavaScript library that adds support for newer browser standards to older browsers.
- Modernizr.js is a JavaScript library that helps you build modern applications by modernizing older browsers.  For example, one important job of Modernizr is to enable the new HTML 5 elements (such as header, nav, and menu) on browsers that don’t natively support HTML 5 elements (like Internet Explorer 6). 

### AJAX HELPERS
- NOTE The Ajax functionality of the Ajax helpers will not work without a reference to the ```jquery.unobtrusive-ajax.js``` script. 
- ```If you’re having trouble with the Ajax helpers, this is the fi rst thing you should check.```
- Ajax helpers also create forms and links that point to controller actions, but they behave asynchronously. 
- When using these helpers, you don’t need to write any script code to make the asynchrony work.
- Behind the scenes, these Ajax helpers depend on the unobtrusive MVC extensions for jQuery. 
```
@section Scripts {    
<script src="~/Scripts/App/MusicScripts.js"></script>    
<script src="~/Scripts/jquery.unobtrusive-ajax.min.js"> 
</script> }
```
### Ajax ActionLinks
- Ajax helpers are available through the Ajax property inside a Razor view. 
- Like HTML helpers, most of the methods on this property are extension methods (except for the AjaxHelper type).
- The ActionLink method of the Ajax property creates an anchor tag with asynchronous 
behavior.
```
<div id="dailydeal">    
 @Ajax.ActionLink("Click here to see today's special!",        
 "DailyDeal",        
 null,        
 new AjaxOptions        
 {            
   UpdateTargetId = "dailydeal",            
   InsertionMode = InsertionMode.Replace,            
   HttpMethod = "GET"        },        
   new {@class = "btn btn-primary"}
 ) 
</div>

//To have a response available, you’ll need a DailyDeal action on the HomeController:

public ActionResult DailyDeal() {            
  var album = GetDailyDeal();
  return PartialView("_DailyDeal", album);        
}
// Select an album and discount it by 50%        
private Album GetDailyDeal() 
{            
var album = storeDB.Albums                
.OrderBy(a => System.Guid.NewGuid())                
.First();
album.Price *= 0.5m;            
return album;        
}
//new Guids are generated in semi-random order, ordering by NewGuid essentially shuffl es them
```
- The target action for an Ajax action link can return plain text or HTML. In this case, you’ll return HTML by rendering a partial view. 
- Just because you can use Ajax links doesn’t mean you should use them everywhere. 
### HTML 5 Attributes 
- most of these attributes have a prefi x of data- (we say they are data dash attributes).
```
$(function () {       
$("a[data-ajax]=true"). 
// do something   
});
```
### Ajax Forms - asynchronous forms
```
<div class="panel panel-default">    
<div class="panel-heading">Artist search</div>
<div class="panel-body">       
 @using (Ajax.BeginForm("ArtistSearch", "Home", 
 new AjaxOptions           
 {               
   InsertionMode = InsertionMode.Replace,               
   HttpMethod = "GET",               
   OnFailure = "searchFailed",               
   LoadingElementId = "ajax-loader",               
   UpdateTargetId = "searchresults",           
 }))        
 {            
   <input type="text" name="q" />            
   <input type="submit" value="search" />            
   <img id="ajax-loader" 
     src="@Url.Content("~/Images/ajax-loader.gif")" 
     style="display:none" />        
 }        
 <div id="searchresults"></div>    
</div>
</div>
```
```
function searchFailed() {   
$("#searchresults").html("Sorry, there was a problem with the search."); 
}
```
-  Notice you’ve specifi ed a LoadingElementId as part of the options
- The client framework automatically shows this element when an asynchronous request is in progress.  
- You typically put an animated spinner inside this element to let the user know some work is in progress in the background.  
- When the client receives the response, the unobtrusive scripts place the content into the DOM. In this example, you replace an element with the id of searchresults.
- query the database and render a partial view
```
public ActionResult ArtistSearch(string q) 
{   
var artists = GetArtists(q);
return PartialView(artists); 
}

private List<Artist> GetArtists(string searchString) 
{   
return storeDB.Artists       
.Where(a => a.Name.Contains(searchString))       
.ToList(); 
}

```
### CLIENT VALIDATION
- Client-side validation relies on the jQuery Validation plugin.
- The data annotations make these properties required, and also put in some restrictions on the length
- Client validation for data annotation attributes is on by default with the MVC framework
- The model binder in ASP.NET MVC performs server-side validation against these properties when it sets their values. 
- These built-in attributes also trigger client-side validation
```
[Required(ErrorMessage = "An Album Title is required")] 
[StringLength(160)] 
public string  Title { get; set; }
```
### jQuery Validation
-  jQuery Validation plugin (jquery.validate) exists in the Scripts folder
-  If you want client-side validation, you’ll need a reference to the jqueryval bundle to the applicable views
- For example, the last few lines of /Views/Account/Login.cshtml are as follows:
```
@section Scripts {    
@Scripts.Render("~/bundles/jqueryval") 
}
```
- the bundle will include both jquery.validate.js and jquery.validate.unobtrusive.js—everything you need for unobtrusive validation based on jQuery Validation.
- Looking in ```/App_Start/BundleConfig.cs```, we can see that this bundle includes all scripts matching the pattern ```~/Scripts/jquery.validate*.```
```
bundles.Add(new ScriptBundle("~/bundles/jqueryval")
.Include( "~/Scripts/jquery.validate*"));
```
- By default, unobtrusive JavaScript and client-side validation are enabled. 
- root-level web.config fi le in a new application, you’ll see the following appSettings confi guration section:
```
<appSettings>   
 <add key="ClientValidationEnabled" value="true"/>   
 <add key="UnobtrusiveJavaScriptEnabled" value="true"/> 
</appSettings>
```
- The jqueryval bundle references two scripts
```
- The first reference is to the minifi ed jQuery Validation plugin
- The second reference is to Microsoft’s unobtrusive adapter for jQuery Validation
```
- The TextBoxFor helper is the key. The helper builds out inputs for a model based on metadata. 
```@Html.TextBoxFor(model => model.Price)```
### Custom Validation 
```
public class MaxWordsAttribute : ValidationAttribute   
public MaxWordsAttribute(int maxWords) 
...
protected override ValidationResult IsValid(
...

[Required(ErrorMessage = "An Album Title is required")] 
[StringLength(160)] [MaxWords(10)] 
public string   Title { get; set; }

```
### IClientValidatable
- The IClientValidatable interface defi nes a single method: GetClientValidationRules. 
```
public class MaxWordsAttribute : ValidationAttribute,  IClientValidatable 
...
public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
ModelMetadata metadata, ControllerContext context) 
...
```
- Inside of CustomValidators.js, adding two additional references will give you all the IntelliSense you need. Alternatively, you could add these references to _references.js.
```
/// <reference path="jquery.validate.js" /> 
/// <reference path="jquery.validate.unobtrusive.js" />
```
### jQuery UI
- jQuery UI is a jQuery plugin that includes both effects and widgets.
-  NuGet package (Install-Package jQuery.UI.Combined)
```
@Scripts.Render("~/bundles/jquery") @Scripts.Render("~/bundles/bootstrap")       
<script src="~/Scripts/jquery-ui-1.10.3.min.js">
</script> @RenderSection("scripts", required: false
```
- create a version-independent bundle in ```/App_Start/BundleConfig.cs:```
```
bundles.Add(new ScriptBundle("~/bundles/jqueryui")
.Include( "~/Scripts/jquery-ui-{version}.js"));
```
### Autocomplete with jQuery UI 
```
<input type="text" name="q"         
data-autocomplete-source="@Url.Action("QuickSearch", "Home")" />
```

### Building the Data Sourc
```
public ActionResult QuickSearch(string term) 
{   
var artists = GetArtists(term).Select(a => new {value = a.Name});   
return Json(artists, JsonRequestBehavior.AllowGet); 
} 
private List<Artist> GetArtists(string searchString) 
{   
return storeDB.Artists       
  .Where(a => a.Name.Contains(searchString))       
  .ToList(); 
}
```
### JSON HIJACKING
- By default, the ASP.NET MVC framework does not allow you to respond to an HTTP GET request with a JSON payload. 
- If you need to send JSON in response to a GET, using ```JsonRequestBehavior.AllowGet``` as the second parameter to the Json method.
### jQuery.ajax for Maximum Flexibility 
### Bootstrap Plugins 
### IMPROVING AJAX PERFORMANCE
- http://msdn.microsoft.com/en-us/library/bg182326.aspx
### Using Content Delivery Networks 
-  script source URL starts with two slashes, omitting the usual http: or https: when you’re requesting scripts from a CDN so your references will work regardless of whether your page uses HTTP or HTTPS
```
<script src="//ajax.aspnetcdn.com/ajax/jQuery/jquery-1.10.2.min.js"       type="text/javascript"></script>
```
### Script Optimizations 
### Bundling and Miniﬁ cation
```
@Scripts.Render("~/bundles/jquery") 
@Styles.Render("~/Content/css")
```
### Routing
-  a ```URI``` just ```identifies a resource```, but a ```URL``` also tells you ```how to get it```
- ```URL``` itself, ```Uniform Resource Locator```
- ```URI``` generally stands for ```Uniform Resource Identifi er```
-  A URI is a string that identifies a resource. All URLs are technically URIs
-  guidelines for high-quality URLs
```
➤ A domain name that is easy to remember and easy to spell
➤ Short URLs
➤ Easy-to-type URLs
➤ URLs that refl ect the site structure
➤ URLs that are hackable to allow users to move to higher levels of the information architecture by hacking off the end of the URL
➤ Persistent URLs, which don’t change
```
### Comparing Routing to URL Rewriting 
- The key difference is that URL rewriting is focused on mapping one URL to another URL
### Routing Approaches 
- traditional routing
- attribute routing
### Route URLs 
- in ```Global.asax.cs```,  ```Application_Start``` method contains a call to the ```RegisterRoutes``` method.
- ```RegisterRoutes``` method is the central control point for your routes and is located in the ```~/App_Start/RouteConfig.cs```
- more than one URL for your action
```
[Route("")] 
[Route("home")] 
[Route("home/index")] 
public ActionResult Index() {    
  return View(); 
}
// your home page to be accessible through the URLs /, /home, and /home/index. 
```
### Route Values
- route parameter:
```
[Route("person/{id}")] 
public ActionResult Details(int id) 
{    
  // Do some work    
  return View(); 
}
```
- ```RouteValueDictionary``` accessible via the ```RequestContext```
### Controller Routes
- When you defi ne a route on the controller class, you can use a ```special route parameter``` named ```action```, and it serves as a placeholder for any action name
```
[Route("home/{action}")] 
public class HomeController : Controller 
{    
  public ActionResult Index()    
  {        
    return View();    
  }
  public ActionResult About()    
  {        
    return View();    
  }
}
```
- When you specify a route attribute at the action level, you’re overriding anything specified at the controller level
-  a URI just identifi es a resource, but a URL also tells you how to get it.
 - The key difference is that URL rewriting is focused on mapping one URL to another URL
 - Another key difference is that Routing also helps generate URLs using the same mapping rules that it uses to match incoming URLs. 
 ### RoutePrefix:
```
[RoutePrefix("home")] 
[Route("{action}")] 
public class HomeController : Controller
```
- The prefi x is just a default, and you can escape from it if necessary.
- To do that, just begin the route template with ~/, and the route prefi x will be ignored. 
```
[RoutePrefix("home")] 
[Route("{action}")]
public class HomeController : Controller 
{    
  [Route("~/")]    
  [Route("")] // You can shorten this to [Route] if you prefer.    
  [Route("index")]   
  public ActionResult Index()    {        return View();    }
}
 
 ```

 
