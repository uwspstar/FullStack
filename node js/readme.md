# Node JS
- Node JS: Advanced Concepts by Stephen Grider
https://www.udemy.com/advanced-node-for-developers
- Node.js: The Complete Guide to Build RESTful APIs (2018) by Mosh Hamedani
https://www.udemy.com/nodejs-master-class

### 06/03/2019
- Node has 50% js and 50% C++
- https://github.com/nodejs/node
- process.binding() // bind C++ code to js
- OS scheduler decide which thread should be processed
- Event loop

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
-
