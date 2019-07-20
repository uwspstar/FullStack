# Webpack 2
- Webpack 2: The Complete Developer's Guide by Stephen Grider
https://www.udemy.com/webpack-2-the-complete-developers-guide/learn/lecture/6308308#overview
```
The purpose of webpack is :
to take our big collection of tiny little javascript modules and merge them all into one big javascript file 
while also ensuring that each module is executed in the correct order.
```
- $>npm init --yes

```
In the world of JavaScript modules,
each module - or each file that we create - has its own separate scope.
That is, code that we want to add or access inside of one file.
```
- exports NOT export
- CommonJs (require , module.exports)
- AMD (require, define)
- ES2015 (import, export)

- $>npm install --save-dev webpack
- webpack.config.js
https://www.udemy.com/webpack-2-the-complete-developers-guide/learn/lecture/6296226#overview
```
// there's these two minimum properties that we have to define inside of this config object right here.
1. entry
2. output 

const path = require('path');
const config = {
    entry: './src/index.js',
    output: {
        path: path.resolve(__dirname, 'build'),
        filename: 'bundle.js'
    }
}

module.exports = config;
```
```
when you install a module globally, you can only have one version of a module installed at a time.
```
- command run at 'webpack' : out of all globlelly installed modules, find the one called webpack and run it
- command run at 'npm run build' : Run the copy of 'webpacl' stored in the 'node_modules' directory
-$> open index.html
- Babel : turn ES2015 code into ES5 code
```
Babel : 
- babel-loader : teaches bable how to work with webpack
- babel-core : knows how to take in code, parse it, and generate some output files
- babel-preset-environment or env : ruleset for telling babel exactly what pieces of ES2015/6/7 syntax to look for, and how to turn it into ES5 code
```
```
we're going to ensure that Webpack only tries to apply
Babel to Javascript files inside of our project.
We're not going to allow Babel to get applied to CSS files, or images, or HTML docs,
anything else like that.
```
- Webpack : Link up JS module together

