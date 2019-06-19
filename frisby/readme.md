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

# Jest testing framework
- https://www.udemy.com/nodejs-master-class/
- https://www.rithmschool.com/courses/intermediate-node-express/api-tests-with-jest
### unit test -> integration test -> end-to-end
```
- We have 3 types of automated tests:
    - Unit tests: test a unit of an application without external resources (eg db) 
    - Integration tests: test the application with external resources.
    - Functional or end-to-end tests: test the application through its UI.
```
- unit test ```NOT talking external database```
- integration test ```talking external resource```
- end-to-end
### testing framework
- Jasmine
- mocha
- jest //facebook use to test react, you know jasmine, you know jest
###  test should neither be too specific or too general
### unit test
```
for unit test, you should NOT talking external database,
otherwize, you are doing integration test
```
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
- supertest 
```
to perform integration tests in our express application we'll be using a module called supertest
```
- log the output @package.json
```
"scripts": {
    "testfile": "timestamp=$(date \"+%c\"); jest --no-color 2>TestResults/TestResult_${timestamp}.txt",
    "test": "jest --watchAll"
  },
```
- array
```
expect(result).toEqual(expect.arrayContaining(['USD', 'AUD', 'EUR']));
```
- object
```
module.exports.getProduct = function (productId) {
    return {
        id: productId,
        price: 10,
        size: 10
    };
}
```
```
expect(result).toMatchObject({
    id: 1,
    price: 10
});
expect(result).toHaveProperty('size', 10);
expect(result).toHaveProperty('id', 1);
```
- exception
```
it('should throw if username is falsy', () => {
    // Null
    // undefined
    // NaN
    // ''
    // 0
    // false
    const args = [null, undefined, NaN, '', 0, false];
    args.forEach(arg => {
        expect(() => {
            test.registerUser(arg)
        }).toThrow();
    });
})
```
### Integration Tests
