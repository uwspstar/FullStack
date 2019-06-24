//const db = require('./db');
const axios = require('axios');

// Testing numbers 
module.exports.getAbsNumber = function (number) {
    if (number > 0) return number;
    if (number < 0) return -number;
    return 0;
}

// Testing strings 
module.exports.reversString = function (str) {
    if (str.length < 2) return str;
    return str.split('').reverse().join('');
}

// Testing arrays 
module.exports.getColor = function () {
    return ['blue', 'red', 'white'];
}

// Testing objects 
module.exports.getProduct = function (productId) {
    return {
        id: productId,
        price: 10
    };
}

// Testing exceptions 
module.exports.getException = function (username) {

    if (!username) throw new Error('Username is required.');

    return {
        id: new Date().getTime(),
        username: username
    }
}

// Testing exceptions 
module.exports.registerUser = function (username) {
    if (!username) throw new Error('Username is required.');

    return {
        id: new Date().getTime(),
        username: username
    }
}


// Testing Simple Promis 
module.exports.fetchUser = () =>
    axios.get('https://jsonplaceholder.typicode.com/users/1')
    .then(res => res.data)
    .catch(err => console.log('Error !', err));


// // Mock functions 
// module.exports.applyDiscount = function (order) {
//     const customer = db.getCustomerSync(order.customerId);

//     if (customer.points > 10)
//         order.totalPrice *= 0.9;
// }

// // Mock functions 
// module.exports.notifyCustomer = function (order) {
//     const customer = db.getCustomerSync(order.customerId);

//     mail.send(customer.email, 'Your order was placed successfully.');
// }