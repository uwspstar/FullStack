# Jest
- Jest 
```
Jest is a new trending popular testing framework recommended by Facebook. 
It comes with everything you need to write automated tests.
```
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
### unit test ```3 simple steps: (A, A , A)```
```
for unit test, you should NOT talking external database,
otherwize, you are doing integration test
```
```
develop a unit test 3 simple steps: (A, A , A)
- Arrange – setup the testing objects and prepare the prerequisites for your test.
- Act – perform the actual work of the test.
- Assert – verify the result.
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
  
...
or 

"scripts": {
    "testfile": "timestamp=$(date \"+%Y%m%d%H%M%S\"); jest --no-color 2>TestResults/TestResult_${timestamp}.txt",
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
- Tests should not be too general nor too specific. 
```
If they’re too general, they don’t give you much confidence that your code works. 
If they’re too specific, they become fragile and can break easily. 
```
- Mocking 
```
Mocking is replacing a real implementation of a function with a fake or mock function. 
It allows us to isolate our application code from its external resources.
```
- Popular Jest matcher functions:
```
// Equality
expect(...).toBe(); 
expect(...).toEqual();
// Truthiness
expect(...).toBeDefined(); 
expect(...).toBeNull(); 
expect(...).toBeTruthy();
expect(...).toBeFalsy();
// Numbers
expect(...).toBeGreaterThan(); 
expect(...).toBeGreaterThanOrEqual(); 
expect(...).toBeLessThan(); 
expect(...).toBeLessThanOrEqual();
// Strings
expect(...).toMatch(/regularExp/);
// Arrays
expect(...).toContain();
// Objects
expect(...).toBe(); 
// check for the equality of object references 
expect(...).toEqual(); 
// check for the equality of properties 
expect(...).toMatchObject();
// Exceptions
expect(() => { someCode }).toThrow();
```
- mock
```
//jest.fn().mockReturnValue(1);
//jest.fn().mockResolvedValue(1);
//jest.fn().mockRejectedValue(new Error('...'));
```
- async test
```
test('the data is peanut butter', done => {
  function callback(data) {
    expect(data).toBe('peanut butter');
    done();
  }

  fetchData(callback);
});
If done() is never called, the test will fail, which is what you want to happen.
```
### Integration Tests
