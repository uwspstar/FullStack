# NPM Most popular NPM package
- NPM Crash Course https://www.youtube.com/watch?v=jHDhaSSKmB0

### validator
- This library validates and sanitizes strings only
- ```$ npm install validator```
- https://www.npmjs.com/package/validator
- isJWT(str)
- isEmail(str [, options])

### nodemon
- nodemon is a tool that helps develop node.js based applications by automatically restarting the node application when file changes in the directory are detected.
- ```$ npm install --save-dev nodemon```
- https://www.npmjs.com/package/nodemon

### express 
- http://expressjs.com/
- https://www.npmjs.com/package/express
- ```$ npm install express```
```
const express = require('express')
const app = express()
 
app.get('/', function (req, res) {
  res.send('Hello World')
})
 

app.listen(3000)
```
