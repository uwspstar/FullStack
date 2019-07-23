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
### a scene, a camera, and a renderer. 
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
- setInterval(function,interval)
```
The problem with this function is that it doesn't take into account 
what is happening in the browser. 
If you were browsing another tab, 
this function would still be fired every couple of milliseconds. 
Besides that, the setInterval() method isn't synchronized with the redrawing of the screen. 
This could lead to higher CPU usage and bad performance.
```
- requestAnimationFrame()
- In the Three.js project, you created a scene to which you added the objects (a geometry together with a material) that you wanted to render
```
- The materials that you used defined what the objects looked like. 
Each material reacted in a different way to light sources
- Rendering shadows is expensive and needs to be turned on for the renderer, 
for each object, and for each light
- You can do easy animations by just changing the position 
and the rotation properties of the objects in the scene
- Statistics and custom controls can be easily added with the two helper libraries 
and a couple of lines of JavaScript
```
### Creating a scene
- Camera
- Lights
- Objects
