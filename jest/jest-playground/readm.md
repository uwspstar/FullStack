# unit test --> intergration test --> e2e test
# node project init
$> npm init --yes
# install jest framework
$> npm install jest --save-dev
# Update package.json Scripts
"scripts": { ...
    "testfile": "timestamp=$(date \"+%Y%m%d%H%M%S\"); jest --coverage --verbose --no-color 2>TestResults/TestResult_${timestamp}.txt",
    "test": "jest --watchAll --verbose",
    "testcoverage": "jest --coverage --watchAll --verbose"
... },
# create test folder test/unit & test/intergration
$> mkdir test
# create test result folder
$> mkdir TestResults
# test
$> npm run test
$> npm run testcoverage
$> npm run testfile
# install config
$> npm install config
- https://www.npmjs.com/package/config
$> mkdir config
# Update package.json Scripts
"scripts": { ...
"start": "node app.js",
"prod": "NODE_ENV=prod node app.js",
"qa": "NODE_ENV=qa node app.js",
...
  },
# install axios
$> npm install axios
# install express 
$> npm install express
# config setup mongodb atlas
https://jestjs.io/docs/en/mongodb
- $ npm install express
- setup mongodb atlas
- https://jestjs.io/docs/en/mongodb
- $ npm install mongoose
