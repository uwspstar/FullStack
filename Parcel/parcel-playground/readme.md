
- $>npm init -y
- $>npm install parcel-bundler
- https://ritwickdey.github.io/vscode-live-server/
- if we use live server, may need to user dist/index.html
```<script src="./scripts.bcf3243b.js"></script>```
- Server running at http://localhost:1234 
- $>npm install sass
- may need to updat the script and css path inside the index.html

- package.json
```
"scripts": {
    "dev": "parcel src/index.html",
    "prod": "parcel build src/index.html --out-dir prod"
  },
```
- https://parceljs.org/getting_started.html