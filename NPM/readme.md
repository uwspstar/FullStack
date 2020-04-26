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
### mongodb
- https://www.npmjs.com/package/mongodb
- ```$ npm install mongodb```
```
const MongoClient = require('mongodb').MongoClient;

const assert = require('assert');

// Connection URL
const url = 'mongodb://localhost:27017';

// Database Name
const dbName = 'myproject';

// Use connect method to connect to the server
MongoClient.connect(url, function(err, client) {
  assert.equal(null, err);
  console.log("Connected successfully to server");
  const db = client.db(dbName);
  client.close();

});
```
### mongoose
- ```$ npm i mongoose```
```
const mongoose = require('mongoose') 

mongoose.connect('mongodb://127.0.0.1:27017/task-manager-api', { useNewUrlParser: true,useCreateIndex: true 

}) 
```

		
	
	
		
			
				
					




				

			

		


		
	
	
		
