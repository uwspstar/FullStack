# Unit Test
- Unit Testing for C# Developers https://www.udemy.com/course/unit-testing-csharp/learn/lecture/8997466#overview
- if you think the "unit" is class, then only test public method, otherwize, test private method also. However, test private method may against SOLID priciple (S)
### Automation Test
- Unit
```
Test a unit of the application 
without its external dependencies such as files, databases, message queues, web services and so on.
```
- Intergration
```
An integration test, tests a class or a component with its external dependencies.
So, it tests the integration of your application code with these concrete dependencies like files, databases and so on.
```
- End to End
### Basic
- each test should have a single responsibility, and should ideally be less than ten lines of code. 
- each test should not have any logic. So you should not have any conditional statements, loops and other kinds of logic in your tests. NO IF ... ESLE...FOREACH ...
- tests methods should not call each other
- if you have a simple C# class that is mainly a property bag, you should not test these properties
- you want to separate unit and integration tests, because unit test execute fast, integration tests take longer. 
- run unit tests frequently as we're writing code, and run integration tests just before committing our code to the repository 
- the plural name here. This indicates that this class has multiple tests. 
- So if you have a class called reservation, you should have a class called reservation tests.
- should be trustworthy

### practice
- Testing Strings
- Testing Arrays and Collections
- 

### How many test ?
- Often, the number of tests is equal to or greater than the number of execution paths. 

### name convention
- The name of the method on our test is [MethodName] _```[scenario testing]``` _ ```[expected behavior]```. With this convention,
- [I recommand to use] "Should_ExpectedBehavior_When_StateUnderTest", I use it for both backend and frontend test

### How to test private method How to unit test private methods using VSTS unit test?
https://www.youtube.com/watch?v=Vq6Gcs9LrPQ
- https://www.youtube.com/watch?v=Krj3-h198KQ
### ExcludeFromCodeCoverage

### Test method requirements
  ```
  A test method must meet the following requirements:
  1) It's decorated with the [TestMethod] attribute.
  2) It returns void.
  3) It cannot have parameters.
  ```
### 7 Popular unit tests naming conventions by Ajitesh Kumar
 https://dzone.com/articles/7-popular-unit-test-naming
  ```
  1) MethodName_StateUnderTest_ExpectedBehavior
  2) MethodName_ExpectedBehavior_StateUnderTest
  3) test[Feature being tested] 
    such as
      - testIsNotAnAdultIfAgeLessThan18
      - testFailToWithdrawMoneyIfAccountIsInvalid
      - testStudentIsNotAdmittedIfMandatoryFieldsAreMissing
   
  4) Feature to be tested
  5) Should_ExpectedBehavior_When_StateUnderTest  [I recommand to use]
      such as
      - Should_ThrowException_When_AgeLessThan18
      - Should_FailToWithdrawMoney_ForInvalidAccount
      - Should_FailToAdmit_IfMandatoryFieldsAreMissing
  6) When_StateUnderTest_Expect_ExpectedBehavior
  7) Given_Preconditions_When_StateUnderTest_Then_ExpectedBehavior
   ```
### [I recommand to use] "Should_ExpectedBehavior_When_StateUnderTest", I use it for both backend and frontend test
