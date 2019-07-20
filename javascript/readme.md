# STUDY NOTES

### Advanced JavaScript Concepts by Andrei Neagoie
https://www.udemy.com/advanced-javascript-concepts/
### Object-oriented Programming in JavaScript by Mosh Hamedani
https://www.udemy.com/javascript-object-oriented-programming/

### 06/02/2019
- Javascript Engine ( such as V8)
### 06/12/2019
- DOMContentLoaded
```
The DOMContentLoaded event fires when the initial HTML document has been completely loaded and parsed, without waiting for stylesheets, images, and subframes to finish loading.

window.addEventListener('DOMContentLoaded', (event) => {
    console.log('DOM fully loaded and parsed');
});

```
### Do not ever use eval!
- eval(string)  ```eval() is a function property of the global object.```
```
JavaScript has first-class functions, which means you can pass functions as arguments to other APIs, 
store them in variables and objects' properties, and so on. 
Many DOM APIs are designed with this in mind, so you can (and should) write:

// instead of setTimeout(" ... ", 1000) use:
setTimeout(function() { ... }, 1000); 

// instead of elt.setAttribute("onclick", "...") use:
elt.addEventListener('click', function() { ... } , false);
```
- Object.assign()
```
The Object.assign() method is used to copy the values of all enumerable own properties from one or more source objects to a target object. It will return the target object.

const target = { a: 1, b: 2 };
const source = { b: 4, c: 5 };

const returnedTarget = Object.assign(target, source);  // b overwrite

console.log(target);
// expected output: Object { a: 1, b: 4, c: 5 }

console.log(returnedTarget);
// expected output: Object { a: 1, b: 4, c: 5 }

```
- window.location.hash
```
Assume that the current URL is http://www.example.com/test.htm#part2:
var x = location.hash;
//The result of x will be:
#part2
```
### 06/26/2019
- factory vs constructor function.
- function declaration ( not ; ) ```hoisting```
- function expression ( has ; at the end) ```not hoisting, only can call after this declare```
- class declartion and class expression are NOT hoisting
- Static Methods and instance Methods
- this (https://www.udemy.com/javascript-object-oriented-programming/learn/lecture/10020626#overview)
- Private Members Using Symbols
- modules (AMD, commonJS, UMD, ES6 Modules)
### webpack
- https://www.udemy.com/javascript-object-oriented-programming/learn/lecture/10020730#overview

### 07/03/2019
```
// The simplest way to create an object is using an object literal 
const circle = { 
   radius: 1, 
   draw: function() {}
}; 
   
// To create multiple objects with the same structure 
//and behaviuor (methods), use a factory or a constructor. 

// Factory function 
function createCircle(radius) { 
   return {
      radius, 
      draw: function() {}
   } 
} 

// Constructor function 
function Circle(radius) { 
    this.radius = radius; 
    this.draw = function() {}
} 
    
// Every object has a "constructor" property which returns the function 
// that was used to construct or create that object. 

const x = {};
x.constructor; // returns Object() 
   
// In JavaScript, functions are objects. 
// They have properties and methods. 

Circle.name; 
Circle.length;
Circle.constructor; // returns Function()
Circle.call({}, 1); // to call the Circle function 
Circle.apply({}, [1]);

// Value types are copied by their value, 
// Value types in JavaScript are: String, Number, Boolean, Symbol, undefined and null
// reference types are copied by their reference. 
// Reference types are: Object, Function and Array 
   
// JavaScript objects are dynamic. You can add/remove properties: 
circle.location = {};
circle['location'] = {};
                      
delete circle.location; 
                      
// To enumerate the members in an object: 
for (let key in circle) console.log(key, circle[key]);

Object.keys(circle); 
                      
// To see if an object has a given property
if ('location' in circle)
                      
// Abstraction means hiding the complexity/details and showing only the essentials. 
// We can hide the details by using private members. 
// Replace "this" with "let". 

function Circle(radius) { 
   // Public member 
   this.radius = radius; 

   // Private member                       
   let defaultLocation = {};                      
}                       

// To define a getter/setter, use Object.defineProperty():

Object.defineProperty(this, 'defaultLocation', {
    get: function() { return defaultLocation; },
    set: function(value) { defaultLocation = value; }
});
```
### 07/04/2019
```
// Every object (except the root object) has a prototype (parent). 
// To get the prototype of an object:
Object.getPrototypeOf(obj);

// In Chrome, you can inspect "__proto__" property. But you should 
// not use that in the code. 

// To get the attributes of a property:
Object.getOwnPropertyDescriptor(obj, 'propertyName');

// To set the attributes for a property:
Object.defineProperty(obj, 'propertyName', {
    configurable: false,    // cannot be deleted
    writable: false,
    enumerable: false
});

// Constructors have a "prototype" property. It returns the object 
// that will be used as the prototype for objects created by the constructor. 
Object.prototype === Object.getPrototypeOf({})
Array.prototype === Object.getPrototypeOf([])

// All objects created with the same constructor will have the same prototype. 
// A single instance of this prototype will be stored in the memory. 
const x = {};
const y = {};
Object.getPrototypeOf(x) === Object.getPrototypeOf(y); // returns true 

// Any changes to the prototype will be immediately visible to all objects 
// referencing this prototype. 

// When dealing with large number of objects, it's better to put their
// methods on their prototype. This way, a single instance of the methods
// will be in the memory. 
Circle.prototype.draw = function () { }

// To get the own/instance properties:
Object.keys(obj);

// To get all the properties (own + prototype): 
for (let key in obj) { }
```
### 07/05/2019
```

// Module formats
//  - AMD / Asynchronous Module Definition (Browser)
//  - CommonJS (Node)
//  - UMD / Universal Module Definition (Browser + Node)
//  - ES6 Modules 

// CommonJS (Used in Node)
// Exporting 
module.exports.Cirlce = Circle; 
// Importing 
const Circle = require('./circle');

// ES6 Modules (Used in Browser)
// Exporting
export class Square {}
// Importing 
import {Square} from './square'; 

// We use Babel to transpile our modern JavaScript code 
// into code that browsers can understand (typically ES5). 

// We use Webpack to combine our JavaScript files into a
// bundle. 
```
### 07/20/2019
- Object Literals
- Factories
- factory function ( use return)
- construct function (use new )
