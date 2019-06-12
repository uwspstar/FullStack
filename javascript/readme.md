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

