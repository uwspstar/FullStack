const axios = require('axios');

// Testing Simple Promis async data
module.exports.fetchUser = () =>
    axios.get('https://jsonplaceholder.typicode.com/users/1')
    .then(res => res.data)
    .catch(err => console.log('Error !', err));