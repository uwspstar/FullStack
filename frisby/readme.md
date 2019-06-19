# Frisby API testing framework
- straightforwad API test cases with response code verification
- Verify the response Object ( Actural data) with expected data with ease
- verify the response that it has correct properties, values, and types
- can be use to extent the assertions and customize it
- promise based easy to Use
- using Jasmine style assertion syntax,a nd use Jest to run the test
### install Jest
- $>npm install --save-dev jest
- mkdir -p __tests__/api
- create file test_spec.js
- Run $> jest
```
Since we are using testing libraries, these are not dependencies that will be using in production. 
we want to make sure to run npm install --save-dev rather than npm install, 
so that we do save them to our package.json, but do not install them in production. 
When you do this, you should see that your package.json consists of 
two sets of dependencies: dependencies and devDependencies.
```
### Status Code
- 200 - OK
- 201 - "Created" (POST)
- 400 - "Bad Request" ( Perhaps missing required parameters)
- 401 - "Unauthorized" (Missing authentication)
- 403 - "Forbidden" (authenticated, but lacking required privileges)
- 404 - "No Found"


