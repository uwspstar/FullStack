# D3
- https://github.com/d3/d3/wiki
- https://www.youtube.com/watch?v=_8V5o2UHG0E
- D3.js Data Visualization Fundamentals By Lars Verspohl pluralsight.com

### SVG - Scalable Vector Graphics.
- https://www.w3schools.com/graphics/svg_intro.asp
- SVG defines vector-based graphics in XML format.
- SVG is written in XML, all elements must be properly closed

### SVG Reference
- https://www.w3schools.com/graphics/svg_reference.asp

### SVG Shapes
- Rectangle <rect>
- Circle <circle>
- Ellipse <ellipse>
- Line <line>
- Polyline <polyline>
- Polygon <polygon>
- Path <path>
  
### SVG Path - <path>
- The <path> element is used to define a path.
```
M = moveto
L = lineto
H = horizontal lineto
V = vertical lineto
C = curveto
S = smooth curveto
Q = quadratic Bézier curve
T = smooth quadratic Bézier curveto
A = elliptical Arc
Z = closepath
```
### SVG Stroke Properties
```
stroke
stroke-width
stroke-linecap
stroke-dasharray
```
### SVG Filter Elements
- https://www.w3schools.com/graphics/svg_filters_intro.asp
### SVG Blur Effects
- https://www.w3schools.com/graphics/svg_fegaussianblur.asp
### SVG Drop Shadows
- https://www.w3schools.com/graphics/svg_feoffset.asp
### SVG Gradients - Linear
- https://www.w3schools.com/graphics/svg_grad_linear.asp
### SVG Gradients - Radial
- https://www.w3schools.com/graphics/svg_grad_radial.asp
### 

# Canvas
- https://www.w3schools.com/graphics/canvas_intro.asp
- The HTML <canvas> element is used to draw graphics on a web page.
- By default, the <canvas> element has no border and no content.
  
### Canvas Reference
- https://www.w3schools.com/graphics/canvas_reference.asp

### Draw on the Canvas With JavaScript
```
<script>
var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
ctx.fillStyle = "#FF0000";
ctx.fillRect(0, 0, 150, 75);
</script>
```
- The getContext() is a built-in HTML object
- grad = ctx.createRadialGradient(0,0,radius*0.95, 0,0,radius*1.05);


























