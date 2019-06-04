# Node JS: Advanced Concepts by Stephen Grider
https://www.udemy.com/advanced-node-for-developers

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
