- Node.js: The Complete Guide to Build RESTful APIs (2018) by Mash
https://www.udemy.com/nodejs-master-class

### CRUD example

```
const Joi = require('joi'); // Return class use Uppercase
const express = require('express');
const app = express();

// app use express.json() middleware
app.use(express.json());

// console.log([1, 2]);
// console.dir([1, 2]);
// console.log(JSON.stringify(o));
const courses = [{
        id: 1,
        name: 'class 1'
    },
    {
        id: 2,
        name: 'class 1'
    }
];

app.get('/', (req, res) => {
    res.send('Hello world');
});

app.get('/api/courses', (req, res) => {
    // res.send([1, 2, 3]);
    // To read query string parameters (?sortBy=name)
    const sortBy = req.query.sortBy;
    res.send(courses);

});

app.get('/api/courses/:id', (req, res) => {
    // res.send(req.params.id)
    const course = courses.find(c => c.id === parseInt(req.params.id));

    if (!course) {
        return res.status(404).send('The course with the given ID was not exist');
    }
    res.send(course);
});

app.post('/api/courses', (req, res) => {

    const schema = {
        name: Joi.string().min(3).required()
    }

    const result = Joi.validate(req.body, schema);
    // console.dir(result);

    if (result.error) {
        //400 Bad Request
        // res.status(400).send(result.error);
        res.status(400).send(result.error.details[0].message);
        return;
    }

    // if (!req.body.name || req.body.name.length < 3) {
    //     //400 Bad Request
    //     res.status(400).send('Name need min 3 length');
    //     return;
    // }

    const course = {
        id: courses.length + 1,
        name: req.body.name
    }
    courses.push(course);
    res.send(courses);
});


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
});


app.delete('/api/courses/:id', (req, res) => {
    // If course not found, return 404, otherwise delete it
    const course = courses.find(c => c.id === parseInt(req.params.id));
    if (!course) {
        res.status(404).send('The course with the given ID was not exist');
        return;
    }

    const index = course.indexOf(course);
    course.splice(index, 1);

    res.status(200).send(course);

});

function validateCourse(course) {
    const schema = {
        name: Joi.string().min(3).required()
    };
    return Joi.validate(course, schema);
};


const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.dir(`Listening port ${port} ...`)
})
```

### middleware
- A middleware function is a function that takes a request object and either
terminates the request/response cycle or passes control to another middleware
function.
- Express has a few built-in middleware functions:
- json(): to parse the body of requests with a JSON payload
- urlencoded(): to parse the body of requests with URL-encoded payload
- static(): to serve static files
- You can create custom middleware for cross-cutting concerns, such as logging,
authentication, etc.
```
// Custom middleware (applied on all routes)
app.use(function(req, res, next)) {
 // …
 next();
}
// Custom middleware (applied on routes starting with /api/admin)
app.use(‘/api/admin’, function(req, res, next)) {
 // …
 next();
}
```
