const Joi = require('joi'); // Return class use Uppercase
const logger = require('./middleware/logger');
const courses = require('./routes/courses');
const home = require('./routes/home');
const config = require('config');
const morgan = require('morgan');
const express = require('express');
const app = express();

// Configuration :  all configs under the config folder
console.log(`Application Name: ${config.get('name')}`);
console.log(`Mail Server: ${config.get('mail.host')}`);
console.log(`Mail Password: ${config.get('mail.password')}`);


// Evn
console.log(`NODE_ENV: ${process.env.NODE_ENV}`);
console.log(`app: ${app.get('env')}`);

if (app.get('env') === 'development') {
    app.use(morgan('tiny'));
    console.log('Morgan enable...');
}


// app use express.json() middleware
// middleware is in order
app.use(express.json());
app.use(express.urlencoded({
    extended: true
}));
app.use(express.static('public'));

// app.use((req, res, next) => {
//     console.log('Logging...');
//     next();
// })
app.use(logger);

app.use((req, res, next) => {
    console.log('Authentication...');
    next();
});

app.use('/', home);
app.use('/api/courses', courses);

const port = process.env.PORT || 3000;
app.listen(port, () => {
    console.dir(`
        Listening port $ {
            port
        }...`)
})