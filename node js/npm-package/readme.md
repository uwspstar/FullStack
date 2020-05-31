# nodemon
- https://github.com/remy/nodemon#nodemon
```
nodemon ./server.js localhost 8080
```
- Running non-node scripts

```
nodemon --exec "python -v" ./app.py
```
- By default nodemon monitors the current working directory. If you want to take control of that option, use the --watch option to add specific paths:
```
nodemon --watch app --watch libs app/server.js
```
