const config = require('config');
const express = require('express');
// const mongoose = require('mongoose');

const {
    connectionString,
    dbName
} = config.get('dbConfig');


const app = express();

app.get('/', function (req, res) {
    res.send('Hello World!');
});

console.log('dbName: ' + dbName);
console.log('process.env.NODE_ENV', process.env.NODE_ENV);

const port = process.env.NODE_ENV.PORT || 3000;

app.listen(port, () => {
    console.log(`listening...${port}`);
});