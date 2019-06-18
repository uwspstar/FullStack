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
When you do this, you should see that your package.json consists of two sets of dependencies: dependencies and devDependencies.
```
### Status Code
- 200 - OK
- 201 - "Created" (POST)
- 400 - "Bad Request" ( Perhaps missing required parameters)
- 401 - "Unauthorized" (Missing authentication)
- 403 - "Forbidden" (authenticated, but lacking required privileges)
- 404 - "No Found"

# Jest testing framework
- https://www.udemy.com/nodejs-master-class/
- https://www.rithmschool.com/courses/intermediate-node-express/api-tests-with-jest
### unit test -> integration test -> end-to-end
- unit test 
- integration test 
- end-to-end
### testing framework
- Jasmine
- mocha
- jest //facebook use to test react, you know jasmine, you know jest
### unit test
- make sure all the excution pass test
- string test
```
const test = require("../src/string");

describe('string', () => {

    // toBe
    it('should return Hi name', () => {
        const result = test.string('Xing');
        expect(result).toBe('Hi, Xing')
    });

    // toContain
    it('should return Hi name', () => {
        const result = test.string('Xing');
        expect(result).toContain('Xing')
    });

    // toMatch
    it('should return Hi name', () => {
        const result = test.string('Xing');
        expect(result).toMatch(/Xing/);
    });
});
```
