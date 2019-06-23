# unit test --> intergration test --> e2e test
- $> npm init --yes
- $> npm install jest --save-dev
```
"scripts": {
    "testfile": "timestamp=$(date \"+%Y%m%d%H%M%S\"); jest --coverage --verbose --no-color 2>TestResults/TestResult_${timestamp}.txt",
    "test": "jest --watchAll --verbose",
    "testcoverage": "jest --coverage --watchAll --verbose"
  },
```
- mkdir TestResults
- $ npm run test
- $ npm run testcoverage
- $ npm run testfile
- $ npm install config
- https://www.npmjs.com/package/config
```
"start": "node app.js",
"prod": "NODE_ENV=prod node app.js",
"qa": "NODE_ENV=qa node app.js",
```
- $ npm install express
- setup mongodb atlas
- https://jestjs.io/docs/en/mongodb
- $ npm install mongoose