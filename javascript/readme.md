# STUDY NOTES

### Advanced JavaScript Concepts by Andrei Neagoie
https://www.udemy.com/advanced-javascript-concepts/

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
