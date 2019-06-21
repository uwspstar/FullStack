# MongoDB
- MongoDB is an document database. It stores data in JSON like documents.
- https://www.mongodb.com/download-center/community
### Install 
- https://docs.mongodb.com/manual/tutorial/install-mongodb-on-os-x/
- https://www.udemy.com/nodejs-the-complete-guide/learn/lecture/11942756#overview
- https://docs.mongodb.com/manual/tutorial/atlas-free-tier-setup/
- local mongoodb 
  - https://www.udemy.com/mongodb-the-complete-developers-guide/learn/lecture/11739120#overview
  - https://www.udemy.com/the-complete-developers-guide-to-mongodb/learn/lecture/6035408#overview
  ```
  On macOS and Linux, MongoDB by default uses /data/db as the storage path. 
  It also assumes a similar path (C:\data\db) on  Windows when NOT using the MongoDB service 
  (i.e. when manually executing the mongod command).
  You can always change the path by running:
  mongod --dbpath "my/new/path" 
  (on Windows, use backslashes + the drive name => mongod --dbpath "C:\my\path").
  ```
- on cloud
  - https://www.udemy.com/nodejs-the-complete-guide/learn/lecture/11942756#overview
### GUI Client tool 
- Robo 3T / Robomongo
  - https://robomongo.org/
### express / body-parser/ mongodb / mongoose
- Promises
- $> npm install express --save
- $> npm install body-parser --save
- $> npm install mongodb --save
- $> npm install mongoose
### CRUD Operations
- Connecting to MongoDB
```
const mongoose = require(‘mongoose’); 
mongoose.connect(‘mongodb://localhost/playground')
.then(() => console.log(‘Connected...’))
.catch(err => console.error(‘Connection failed...’));

```
- To store objects in MongoDB, we need to define a Mongoose schema first.
- Supported types are: 
```
  String, 
  Number, 
  Date, 
  Buffer (for storing binary data), 
  Boolean and ObjectID.
```
```
// Defining a schema
const courseSchema = new mongoose.Schema({ 
  name: String,
  price: Number 
});

// Using a SchemaType object
const courseSchema = new mongoos  e.Schema({ 
  isPublished: { type: Boolean, default: false }
});
```
