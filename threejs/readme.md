# THREE Js
- https://threejsfundamentals.org/
- http://davidscottlyons.com/threejs-intro/#slide-0
- https://github.com/josdirksen/learning-threejs

```
display anything with three.js, we need three things: 
- scene
- renderer
- camera, 
so that we can render the scene with camera.
```

- There are a few different cameras in three.js. such as PerspectiveCamera.
- $>npm init --yes
- $>npm i three

- $>python -m SimpleHTTPServer
```Serving HTTP on 0.0.0.0 port 8000 ...```
```
OR
$> npm install -g http-server
$> http-server
Starting up http-server, serving ./ on port: 8080
Hit CTRL-C to stop the server

Alternatively you can also use the Simple HTTP Server option:

$> npm install -g simple-http-server
$> nserver
simple-http-server Now Serving: /Users/jos/git/Physijs at http://
localhost:8000/
```
- we defined a scene, a camera, and a renderer. 
- scene variable 
```is a container that is used to store and keep track of all the objects that we want to render. 
The sphere and the cube that we want to render will be added to this scene later on in the example. 
```
- camera variable
```
The camera variable defines what we'll see when we render the scene. 
```
- renderer object
```
The renderer is responsible for calculating what the scene will look like in the browser 
based on the camera angle.
We will create a WebGLRenderer object in this example that will use your graphics card to render the scene.
```
