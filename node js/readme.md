# Node JS
- Node JS: Advanced Concepts by Stephen Grider
https://www.udemy.com/advanced-node-for-developers
- Node.js: The Complete Guide to Build RESTful APIs (2018) by Mosh Hamedani
https://www.udemy.com/nodejs-master-class
- The Complete Node.js Developer Course (3rd Edition) by Andrew Mead
https://www.udemy.com/the-complete-nodejs-developer-course-2
- Learn and Understand NodeJS by Anthony Alicea
https://www.udemy.com/understand-nodejs/learn/lecture/3485580#overview
- https://nodejs.org/dist/latest-v10.x/docs/api/
- Node.js Everywhere with Environment Variables! by John Papa
https://medium.com/the-node-js-collection/making-your-node-js-work-everywhere-with-environment-variables-2da8cdf6e786
- Working with Environment Variables in Node.js BY DOMINIK KUNDEL
https://www.twilio.com/blog/2017/08/working-with-environment-variables-in-node-js.html
- Here’s how you can actually use Node environment variables by Burke Holland
https://www.freecodecamp.org/news/heres-how-you-can-actually-use-node-environment-variables-8fdf98f53a0a/

### $>npm init --yes
- package.json file
```
package.json file.
o To do this, type ‘npm init’ and press enter
o This will prompt a wizard like function where we begin creating our package file,
where the command line will ask you a series of step-by-step questions
▪ The first question will be to provide the package name (leave this as default)
and press enter
▪ Version number – leave this as the default value and press enter        
▪ Description – This can be whatever you want it to be.
▪ Entry Point – By default this is set as index.js (use the default value and press enter). 
The entry point is where our project will start when it runs (e.g. the code will initiate index.js on the first step).
▪ TestCommand–Leave this as blank and pressenter
▪ Git Repository – we are not going to be using one, so leave this as blank and
press enter
▪ Keywords – leave this as default and press enter (You would use keywords
that are relevant to your module and that you would expect people to use
while searching for a module like yours)
▪ Author – enter your name and press enter
▪ License – leave this as default and press enter (you can use this field to enter
a license type e.g. you do not want your project to be used for commercial
uses, for example).
▪ Finally, you will be asked to review your entries and to confirm they are
correct. Type ‘yes’ and press enter.
▪ The package.json file will have now been created in the background and you
will be brought to a new line in GitBash/ iTerm2 as shown:
```
### 06/03/2019
- Node has 50% js and 50% C++
- https://github.com/nodejs/node
- process.binding() // bind C++ code to js
- OS scheduler decide which thread should be processed
- Event loop
### Fetch vs axios
https://www.udemy.com/react-redux/learn/lecture/12531294#overview
### 06/04/2019
### Express
```
$>mkdir express-demo
$>cd express-demo
$>npm init --yes
$>npm i express
...
$>node index.js
```
- https://expressjs.com/en/4x/api.html#req
- const port = process.env.PORT || 3000
- $>export PORT=5000
- $>nodemon index.js
```req.url is not a native Express property, it is inherited from Node’s http module.```
- In a middleware function, req.originalUrl is a combination of req.baseUrl and req.path
```
app.use('/admin', function (req, res, next) { // GET 'http://www.example.com/admin/new'
  console.dir(req.originalUrl) // '/admin/new'
  console.dir(req.baseUrl) // '/admin'
  console.dir(req.path) // '/new'
  next()
})
```
### nodemon
- $>sudo npm i -g nodemon
https://www.udemy.com/nodejs-master-class/learn/lecture/9991632#overview
### Node.js doesn't support ES6 imports yet.
- console.log(JSON.stringify(o));
- console.dir vs console.log
https://stackoverflow.com/questions/11954152/whats-the-difference-between-console-dir-and-console-log
- req.param.id
- req.query
- $>node index.js
```
use query string param for anything that is optional
```
- parseInt(req.param.id)
- app.use(express.json()); //NOT app.use(express.json);
- req.status(400).send('bad input') // after error, DO NOT FORGET "return;"
### joi 
- $>npm i joi@version // input validation
- put
```
app.put('/api/courses/:id', (req, res) => {
    // Look up the course
    // If not existing, return 404 
    const course = courses.find(c => c.id === parseInt(req.params.id));
    if (!course) {
        res.status(404).send('The course with the given ID was not exist');
        return;
    }

    // Validate
    // If invalid, return 400 - Bad request
    const schema = {
        name: Joi.string().min(3).required()
    }

    const result = Joi.validate(req.body, schema);
    if (result.error) {
        res.status(400).send(result.error.details[0].message);
        return;
    }

    // Update course
    // Return the updated course
    course.name = req.body.name;
    res.send(course);
})
```
- filter(function() { ... } ) vs find(function() { ... } )
```
filter runs till the end of the array, and invokes its callback on every item; 
in contrast to find which stops after having found one. 
When the callback throws an exception on one of these additionally iterated elements, the outcome is different.
find() returns children of the match elements for the given selector, 
filter() looks at the matched elements and returns the ones that also match the given selector.
```
- Filter vs Map vs Reduce vs Foreach
https://codeburst.io/array-methods-explained-filter-vs-map-vs-reduce-vs-foreach-ea3127c6d319
- ```filter does not update the existing array it will return a new filtered array every time.```
- ```Map generate a new array based on your existing array.```
- ```The map method allows items in an array to be manipulated to the user’s preference```
- Filter vs Map :  filter with condition, such as boolen, map with manipulated, such as Math.sqr()
- Filter vs Map all return a new array.  forEach, return same array

### 06/06/2019
- A middleware function is a function that takes a request object and either
terminates the request/response cycle or passes control to another middleware
function.
- Express has a few built-in middleware functions:
- json(): to parse the body of requests with a JSON payload
- urlencoded(): to parse the body of requests with URL-encoded payload
- static(): to serve static files
- You can create custom middleware for cross-cutting concerns, such as logging,
authentication, etc

### 06/07/2009
- console.log(`NODE_ENV: ${process.env.NODE_ENV}`);
- console.log(`app: ${app.get('env')}`);  // app: development is default
### morgan
- $>npm install morgan
```
// morgan is HTTP request logger.	express.logger
if (app.get('env') === 'development') {
    app.use(morgan('tiny'));
}
```
- $>export NODE_ENV=production
### config
- https://www.npmjs.com/package/config
- $>npm install config
- $>export app_password=unset
```
// Configuration :  all configs under the config folder
console.log(`Application Name: ${config.get('name')}`);
console.log(`Mail server: ${config.get('mail.host')}`);
```
```DO NOT store the password in the config, avoid everyone can see after code checked in repository```
- custom-environment-variables.json
```
//To enable custom environment variables, 
//create a configuration file, config/custom-environment-variables.json
//app_password is the variable input form node console
//$>export app_passowrd=1234
//$>export app_password=unset
{
    "mail": {
        "password": "app_password"
    }
}
...
console.log(`Mail Password: ${config.get('mail.password')}`);
```
### debug
- $>npm install debug
- https://www.udemy.com/nodejs-master-class/learn/lecture/9991972#overview

### Templating Engines
- https://www.udemy.com/nodejs-master-class/learn/lecture/9991974#overview

### Database Integration
- https://expressjs.com/en/guide/database-integration.html
```
Cassandra
*** Couchbase
*** CouchDB
LevelDB
*** MySQL
*** MongoDB
Neo4j
*** Oracle
*** PostgreSQL
*** Redis
*** SQL Server
SQLite
ElasticSearch
```
### Router
- app.get('/api/courses',router); // NOT app.get('api/courses',router);
### bcrypt
- $>npm i bcrypt
- To hash passwords, use bcrypt:
```
// Hashing passwords
const salt = await bcrypt.genSalt(10);
const hashed = await bcrypt.hash(‘1234’, salt);
// Validating passwords
const isValid = await bcrypt.compare(‘1234’, hashed);
```
- JSON Web Token (JWT)
- $>npm install jsonwebtoken
- Storing Secrets in Environment Variables
https://www.udemy.com/nodejs-master-class/learn/lecture/9993496#overview
- ```401 Unauthorized 403 fobidden```
- use try{...} catch {...} for async function
- use ,then().catch() for promis
### validator.js
- $>npm i validator
```
const validator = require('validator')
console.log(validator.isURL('https/mead.io')) // Print: true
```
### chalk.js
- $>npm i chalk
- A globally installed module is not added as a dependency to your project. 
```
You can use npm modules from outside of your scripts by installing them globally. Globally
installed modules are designed to be used from the terminal and provide you with new
commands you can run. In this lesson, you’ll learn how to install and work with global
modules.
```
### nodemon
- npm install -g nodemon@1.18.5
```
A globally installed module is not added as a dependency to your project. 
That means you won’t see it listed in package.json or package-lock.json. 
You also won’t find its code in node_modules. 
Globally installed modules are located in a special directory in your
machine which is created and managed by npm.
```
### 06/07/2019
- process.argv
```
// print process.argv
process.argv.forEach((val, index) => {
  console.log(`${index}: ${val}`);
});
```
### yargs
- $>npm install yargs

### Storing Data with JSON
- JSON.stringify
- JSON.parse
```
JSON looks similar to a JavaScript object, but there are some differences. 
The most obvious is that all properties are wrapped in double-quotes.
{"name":"Gunther","planet":"Earth","age":54}

JSON.stringify converts a JavaScript object into a JSON
string, while JSON.parse converts a JSON string into a JavaScript object.
```
```
const book = {
 title: 'Ego is the Enemy',
 author: 'Ryan Holiday'
}
// Covert JavaScript object into JSON string
const bookJSON = JSON.stringify(book)
// Covert JSON string into object
const bookObject = JSON.parse(bookJSON)
console.log(bookObject.title) // Print: Ego is the Enemy
```
- Arrow Functions // ES6
```
(param1 = defaultValue1, param2, …, paramN = defaultValueN) => { statements }

// Destructuring within the parameter list is also supported
var f = ([a, b] = [1, 2], {x: c} = {x: a + b}) => a + b + c;
f(); // 6
```
```Arrow functions don’t bind their own this value. ```
- https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions
```
var elements = [
  'Hydrogen',
  'Helium',
  'Lithium',
  'Beryllium'
];

elements.map(({ length :lengthFooBArX }) => lengthFooBArX); // [8, 6, 7, 9]
// In this case, because we only need the length property, we can use destructuring parameter:
// Notice that the `length` corresponds to the property we want to get whereas the
// obviously non-special `lengthFooBArX` is just the name of a variable which can be changed
// to any valid variable name you want

elements.map(({ length }) => length); // [8, 6, 7, 9]
// This destructuring parameter assignment can also be written as seen below. However, note that in
// this example we are not assigning `length` value to the made up property. Instead, the literal name
// itself of the variable `length` is used as the property we want to retrieve from the object.

```
- arr.find() 
```
// The find() method returns the value of the first element in the array 
// that satisfies the provided testing function. Otherwise undefined is returned.
const user = users.find((user) => user.name === 'George Hudson')

 // callback is invoked with three arguments: 
 the value of the element, the index of the element, and the Array object being traversed
```
### 06/08/2019
### debug
- $>node inspect app.js // hit 2 times ctrl + c quit
- $>restart
- chrome://inspect //in the Chrome browser.
```
console.log('Thing one)
debugger // Debug tools will pause here until your click play again
console.log('Thing two)
```
### Asynchronous
- Call Stack, Callback Queue, and Event Loop
https://www.udemy.com/the-complete-nodejs-developer-course-2/learn/lecture/13728912#overview
```
We can actually do other stuff inside of the call stack, so JavaScript itself is a single threaded programming
language.

You can do one thing at a time and the call stack enforces that we can only have one function on the
top of the call stack that is the thing we're doing.
There's no way to execute two things at the same time.

Now that doesn't mean no JSA is completely single threaded the code you run is indeed still single threaded
but node uses other threads in C++ behind the scenes to manage your events.
```
- callback queue
```
The job of the callback queue is simple.
Its job is to maintain a list of all of the callback functions that are ready to get executed.
So when a given event is done in this case when the zero second timer is complete that callback function
the function we defined right here that's gonna get added on to the callback Q which is just a standard
line you get in at the end of the line and you work your way towards the front the front item is the
one that will get executed first.

So right here since there are no items in the list the callback gets added right up front.
So we have this callback and it's ready to get executed but before it can be executed it needs to be
added onto the call stack.That's where functions go to run.
```
- event loop```our function doesn't run right away. The event loop needs to wait for the call stack to be empty.```
```
Now this is where the event loop comes into play the event loop looks at two things 
1)it looks at the call stack 
2) and it looks at the callback Q If the call stack is empty it's going to run items from the
callback.

Q So at this point the event loop says I know you got added to the callback queue but the call stack
is not empty so I can't execute you.

And this is why our function doesn't run right away. The event loop needs to wait for the call stack to be empty.
So at this point Maine actually continues to run the next thing we see is that line eleven of our program

```
### 06/09/2019
### request
```
const request = require('request')
const url = 'https://api.darksky.net/forecast/9d1465c6f3bb7a6c71944bdd8548d026/37.8267,- 122.4233'
request({ url: url }, (error, response) => {
    // Parse the response body from JSON string into JavaScript object
    const data = JSON.parse(response.body)
    // Will print the current temperature to the console
    console.log(data.currently.temperature)
})
```
- $>npm i request
- darksky.net
- mapbox.com
- JSON Formatter //Chrome extension for printing JSON  chrome://chrome/extensions/
### 06/10/2019
- node use globle instead of using window (js)
- in node, every file is module
### class ChildClass extends ParentClass { ... }
```
class Square extends Polygon {
  constructor(length) {
    // Here, it calls the parent class' constructor with lengths
    // provided for the Polygon's width and height
    super(length, length);
    // Note: In derived classes, super() must be called before you
    // can use 'this'. Leaving this out will cause a reference error.
    this.name = 'Square';
  }

  get area() {
    return this.height * this.width;
  }
}
```
```
class myDate extends Date {
  constructor() {
    super();
  }

  getFormattedDate() {
    var months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    return this.getDate() + '-' + months[this.getMonth()] + '-' + this.getFullYear();
  }
}
```
### NGINX
- NodeJS and NGINX 
https://www.udemy.com/all-about-nodejs/learn/lecture/2050748#overview
```
not efficient for high traffic instances.
It's already running on a single thread and solving static assets for the slows down things unnecessarily.

Another important reason is that there is no caching so every time there is a request all static assets
have to be served again and again all of this makes up for a very slow server.

What we need to do is to create a little server instance that is tasked with solving and caching static
assets.

Additionally we should also deploy a load balancer to distribute user traffic over a number of Naude
```
### 06/11/2019
- Arrow functions don’t bind their own this value. 
- $> node inspect app.js //debug
```
The request library json option. Set json to true and request will automatically parse the JSON into a JavaScript object for you.

const request = require('request')
const url = 'https://api.darksky.net/forecast/9d1465c6f3bb7a6c71944bdd8548d026/37.8267,- 122.4233'
request({ url: url, json: true }, (error, response) => {
    console.log(response.body.daily.data[0].summary + ' It is currently ' +
response.body.currently.temperature + ' degrees out. There is a ' +
response.body.currently.precipProbability + '% chance of rain.')
})
```
- The callback function you pass to expects an error and response argument
be provided
- A callback function is a function that’s passed as an argument to another function

### 06/12/2019
- Linux sh command https://www.computerhope.com/unix/ush.htm
- https://www.youtube.com/watch?v=AO0jzD1hpXc
```
$> clear
$> pwd
$> cd ..
$> cd
$> cd ~
xing@xwang-mbp.local:/Users/xing/play/mobile-redemption
$> cd ~

xing@xwang-mbp.local:/Users/xing
$> pwd
/Users/xing

$> ls
$> cd <folder>
absolute path / : start from root /
relative path / : start from current
```
- document.createElement
```
var newDiv = document.createElement("div"); 
When called on an HTML document, createElement() converts tagName to lower case before creating the element
```
- Element.setAttribute()
```
var b = document.querySelector("button"); 

b.setAttribute("name", "helloButton");
b.setAttribute("disabled", "");
```
- Object.keys(obj) 
``` 
In ES5, if the argument to this method is not an object (a primitive), then it will cause a TypeError. In ES2015, a non-object argument will be coerced to an object.
Object.keys('foo');
// TypeError: "foo" is not an object (ES5 code)

Object.keys('foo');
// ["0", "1", "2"]                   (ES2015 code)
```

```
// simple array
var arr = ['a', 'b', 'c'];
console.log(Object.keys(arr)); // console: ['0', '1', '2']

// array like object
var obj = { 0: 'a', 1: 'b', 2: 'c' };
console.log(Object.keys(obj)); // console: ['0', '1', '2']

// array like object with random key ordering
var anObj = { 100: 'a', 2: 'b', 7: 'c' };
console.log(Object.keys(anObj)); // console: ['2', '7', '100']

// getFoo is a property which isn't enumerable
var myObj = Object.create({}, {
  getFoo: {
    value: function () { return this.foo; }
  } 
});
myObj.foo = 1;
console.log(Object.keys(myObj)); // console: ['foo']
```
- https://stackoverflow.com/questions/10599933/convert-long-number-into-abbreviated-string-in-javascript-with-a-special-shortn
- addEventListener()
- removeEventListener()
```
document.getElementById("myBtn").addEventListener("click", displayDate);

The first parameter is the type of the event (like "click" or "mousedown").

The second parameter is the function we want to call when the event occurs.

The third parameter is a boolean value specifying whether to use event bubbling or event capturing. This parameter is optional.

Note that you don't use the "on" prefix for the event; use "click" instead of "onclick".
```
### 06/14/2019
- Module 
```
a reusable block of code whose existence does not accidentally impact other code
```
- commonjs module
```
an agreed upon standard for how code modules should be structured
```
- First-class functions vs. Function Expressions
```
First-Class Functions :  everything you can do with other types, you can do with Functions. You can use functions like strings, numbers, etc. (i.e. pass them around,
set variables equal to them, put them in arrays, and more)

function logGreeting(fn) {
  fn();
}


An Expresssion:
A block of code that results in a value.
Function expressions are possible in javascript becasue functions are first-class

var greeting = function() {
}
```
- pass function as variable
``` 
fucntion greet() {
  console.log('greet...');
}

function logGreeting(fn) {
  fn();
}

logGreeting(greet);
````
- require()
```
require, it's a function. What you pass to the function, the argument,
the parameter is a string, and the string contains the location or the name of the module that you wish to import or that is used
```
- module.exports = {} //object
- object ```an object is nothing but a collection of name/value pairs.```
```
javascript objects are names that connected to values,but the values might be other lists of names and values.
Another way to think about it is that an object sits in memory
and points at other objects or other values.
You might have primitive values like numbers and strings,
objects, which are other collections of name/value pairs,
and remember that functions, are actually special types of objects.So the value might be a function.

When a function is attached to an object, we call it a method, and really these, you might think of as pointing to a particular spot or address in memory where these different properties, these different methods, that is to say,
these different values attached to names on the object live. 
````
- object literal.
```
take a sequence of name/value pairs, separate them by commas,
and surround them with a curly brace, and that's a very quick way to create a Javascript object
```
- prototypal inheritance and function constructors
```
inheritance.
That's when one object, one collection of name value pairs, gets access to the properties and methods,that is, other name value pairs, of another object.

So an object has properties and methods, values and functions attached to it.
And your object gets access to the properties and methods of that other object.
It inherits those other properties and methods.
However, the way JavaScript implements the idea of inheritance is a bit different
than other programming languages, major programming languages out there.
But also very powerful because of its simplicity. It implements what's called prototypal inheritance.
```
### 06/20/2019
- node does not have windows but use global
- global.console.log();
- So always use asynchronous methods.
- callback
```
all asynchronous methods take a function as their last argument. 
Node will call this function when that asynchronous operation completes. 
We call this function a callback.
```
### logger
- https://www.npmjs.com/package/winston
### Security
- Nodejs Application Security by Jay Desai
https://blog.usejournal.com/nodejs-application-security-80d5150a0366
- https://expressjs.com/en/advanced/best-practice-security.html
