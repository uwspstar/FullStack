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
### make sure add IP in white list
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
- model
```
Once we have a schema, we need to compile it into a model. A model is like a class. 
It’s a blueprint for creating objects:

// Creating a model
const Course = mongoose.model('Course', courseSchema);

```
```
// Saving a document
let course = new Course({ name: '...' }); 
course = await course.save();

// Querying documents
const courses = await Course
.find({ author: ‘Mosh’, isPublished: true }) .skip(10)
.limit(10)
.sort({ name: 1, price: -1 })
.select({ name: 1, price: 1 });

// Updating a document (query first)
const course = await Course.findById(id); 
if (!course) return;
course.set({ name: '...' });
course.save();

// Updating a document (update first)
const result = await Course.update({ _id: id }, {
  $set: { name: '...' }
});

// Updating a document (update first) and return it
const result = await Course.findByIdAndUpdate({ _id: id }, {
  $set: { name: ‘...’ }
}, { new: true });

// Removing a document
const result = await Course.deleteOne({ _id: id }); 
const result = await Course.deleteMany({ _id: id }); 
const course = await Course.findByIdAndRemove(id);
```
- Regular Expression
- https://www.w3schools.com/jsref/jsref_obj_regexp.asp
```
- /..string/, slash for representing a regular expression.
- ^, carrot character represent a string that starts with something.
- $, dollar sign, indicates the end of a string. 
- .*, dot star, in a regular expression means we can contains

characters, 
/^Xing/ means string start Xing
/Xing$/ means string end with Xing
/.*xing.*/ means contains with Xing

```
- Pagination
  - https://www.udemy.com/nodejs-master-class/learn/lecture/9992630#overview
- import data from file to local db
```
mongoimport --db mongo-exercises --collection courses --drop --file exercise-data.json --jsonArray
```
- two approaches. normalization (consistency) vs denormalization (performance)
```
One is using references which we call normalization, more like a traditional MSSQL
and the other approach is using embedded documents, which we call denormalization. 
```
- you need to do a tradeoff, between query performance, vs,consistency.
