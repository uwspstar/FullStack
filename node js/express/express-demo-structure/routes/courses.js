const express = require('express');
// const router = express();
const router = express.Router();

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


router.get('/', (req, res) => {
    // res.send([1, 2, 3]);
    // To read query string parameters (?sortBy=name)
    const sortBy = req.query.sortBy;
    res.send(courses);

});

router.get('/:id', (req, res) => {
    // res.send(req.params.id)
    const course = courses.find(c => c.id === parseInt(req.params.id));

    if (!course) {
        return res.status(404).send('The course with the given ID was not exist');
    }
    res.send(course);
});

router.post('/', (req, res) => {

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


router.put('/:id', (req, res) => {
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


router.delete('/:id', (req, res) => {
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

module.exports = router;