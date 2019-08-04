# Image File Formats

- [https://99designs.com/blog/tips/image-file-types/](https://99designs.com/blog/tips/image-file-types/)

- [https://pageweight.imgix.com/](https://pageweight.imgix.com/)

- [https://www.sitepoint.com/gif-png-jpg-which-one-to-use/](https://www.sitepoint.com/gif-png-jpg-which-one-to-use/)


  - If you want transparency : use a PNG 
  - if you want animations : use a GIF 
  - if you want colorful detailed images : use a JPEG
  - if you want simple icons, logos, and illustrations : use a SVGs.
  - Reduce PNG with TinyPNG
  - Reduce JPG with JPEG-optimizer
  - Try to choose simple illustrations over highly detailed photos
  - Always lower JPEG image quality (30~60%)
  - Resize image based on size it will be displayed
  - Display different sized images for different backgrounds.
  - Use CDNs like imigx
  - Remove image metadata
  
```
you can convert SVG into Base64 encoding, and that works as the Data URI 

HTML 
<img alt="" src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDo etc">
<img src='data:image/svg+xml;utf8,<svg ... > ... </svg>'>

CSS
.bg {
  background: url('data:image/svg+xml;utf8,<svg ...> ... </svg>');
}
```
