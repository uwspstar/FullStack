# Unit Test
- if you think the "unit" is class, then only test public method, otherwize, test private method also
- https://www.youtube.com/watch?v=Krj3-h198KQ
- ExcludeFromCodeCoverage
- Test method requirements
  ```
  A test method must meet the following requirements:
  1) It's decorated with the [TestMethod] attribute.
  2) It returns void.
  3) It cannot have parameters.
  ```
 - 7 popular unit tests naming conventions by Ajitesh Kumar
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
- [I recommand to use] "Should_ExpectedBehavior_When_StateUnderTest", I use it for both backend and frontend test
