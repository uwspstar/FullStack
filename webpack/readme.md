# Webpack 2
- Webpack 2: The Complete Developer's Guide by Stephen Grider
https://www.udemy.com/webpack-2-the-complete-developers-guide/learn/lecture/6308308#overview
```
The purpose of webpack is :
to take our big collection of tiny little javascript modules 
and merge them all into one big javascript file 
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

- $>npm i -D webpack webpack-cli
```
- package.json

"devDependencies": {
    "webpack": "^4.36.1",
    "webpack-cli": "^3.3.6"
  }
```
- webpack.config.js . (manully add it)
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
- package.json
```
"scripts": {
    "build": "webpack"
  }
  
NOTE : make sure use double quote ""
```
- install VSCODE "Live Server" extension Ritwick Dey
- add index.html 
```
<script src="build/bundle.js"></script>
```
- $>npm run build
-$> open index.html
``` 
or use VSCODE Live Server
```
```
when you install a module globally, you can only have one version of a module installed at a time.
```
- command run at 'webpack' : out of all globlelly installed modules, find the one called webpack and run it
- command run at 'npm run build' : Run the copy of 'webpack' stored in the 'node_modules' directory


- Babel : turn ES2015 code into ES5 code
```
Babel : 
- babel-loader : teaches bable how to work with webpack
- babel-core : knows how to take in code, parse it, and generate some output files
- babel-preset-environment or env : ruleset for telling babel exactly what pieces of ES2015/6/7 
syntax to look for, and how to turn it into ES5 code
```
- $>npm install --save-dev babel-loader babel-core babel-preset-env
```
Update
As of babel 7, install the dependency via the following command instead
$>npm remove babel-cli
$>npm install --save-dev @babel/cli @babel/core @babel/preset-env
//$>npm install --save-dev @babel/core @babel/preset-env
```
```
- package.json
"devDependencies": {
    "babel-core": "^6.26.3",
    "babel-loader": "^8.0.6",
    "babel-preset-env": "^1.7.0",
    "webpack": "^4.36.1",
    "webpack-cli": "^3.3.6"
  }
```
- only apply Babel to Javascript files 
```
we're going to ensure that Webpack only tries to apply
Babel to Javascript files inside of our project.
We're not going to allow Babel to get applied to CSS files, or images, or HTML docs,
anything else like that.
```
- Webpack : Link up JS module together
- .babelrc
```
{
  "presets": ["babel-preset-env", "react"]
}
```
```
{ "presets": ["@babel/preset-env"] }
(and install that package if you haven't already).

In your .babelrc you are still referencing the package babel-preset-env 
(which is for 6.x), you want to reference @babel/preset-env instead (which is for 7.x).
```
- image.src = "http://lorempixel.com/400/440"
- put your JS at the bottom of the page so the DOM
```
Your code is loaded before the DOM is ready, so the selectors can't find those elements on the page.
You can put your JS at the bottom of the pageso the DOM is fully loaded 
before the code is run and in turn your div element is available to the selector.
``` 
- $>npm install --save-dev style-loader css-loader
- $>npm install --save-dev mini-css-extract-plugin
https://github.com/webpack-contrib/mini-css-extract-plugin
- mini-css-extract-plugin
```
webpack.config.js
- const ExtractTextPlugin = require('extract-text-webpack-plugin');

new ExtractTextPlugin and we're going to pass an argument of style.css 
This line right here tells the extract text library to find any files 
that were transformed by its loader earlier up inside of here.
So anything that this loader caught is going to get grabbed by this plugin right here 
and then saves into a file called style.css.
If we have multiple CSS files inside of our project,
they will all be combined and stuffed into a single style.css file.
```
