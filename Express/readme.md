# Express
- https://www.npmjs.com/package/express
### Fetch API  
- https://developers.google.com/web/updates/2015/03/introduction-to-fetch
- https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API
```
fetch('http://localhost:3000/weather?address=austin')
 .then((response) => { response.json()
 .then((data) => { 

  if (data.error) { console.log(data.error) 

  } else { console.log(data.location) console.log(data.forecast) 

 } 
}) 
```
### query string
- http://expressjs.com/en/5x/api.html#req.query

### Serving up a Static Directory with Path
- https://nodejs.org/dist/latest-v11.x/docs/api/path.html
```
const path = require('path')
const express = require('express')
const app = express()
const publicDirectoryPath = path.join(__dirname, '../public')
app.use(express.static(publicDirectoryPath))
app.get('/weather', (req, res) => {
res.send({
  forecast: 'It is snowing',
  location: 'Philadelphia'
})
})
app.listen(3000, () => {console.log('Server is up on port 3000.')
})
```

### basic
```
// Build a web server
const express = require(‘express’); 
const app = express();

// Creating a course
app.post('/api/courses', (req, res) => {
  // Create the course and return the course object
  res.send(course);
});

// Getting all the courses
app.get('/api/courses', (req, res) => {
  // To read query string parameters (?sortBy=name)
  const sortBy = req.query.sortBy;
  // Return the courses
  res.send(courses);
});

// Getting a single course
app.get('/api/courses/:id', (req, res) => { const courseId = req.params.id; 
  // Lookup the course
  // If not found, return 404
  res.status(404).send('Course not found.');
  // Else, return the course object
  res.send(course); 
});

// Updating a course
app.put('/api/courses/:id', (req, res) => { 
  // If course not found, return 404, otherwise update it
  // and return the updated object. 
});

// Deleting a course
app.delete('/api/courses/:id', (req, res) => {
  // If course not found, return 404, otherwise delete it
  // and return the deleted object.
});

// Listen on port 3000
app.listen(3000, () => console.log('Listening...'));

- We use Nodemon to watch for changes in files and automatically restart the node process.
- We can use environment variables to store various settings for an application. 
- To read an environment variable, we use process.env.
// Reading the port from an environment variable
const port = process.env.PORT || 3000;
app.listen(port);
```
