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
