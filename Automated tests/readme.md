#Automated tests
- automated test are the most important part of any CI/CD pipeline. 
- Test automation and Continuous Integration & Deployment (CI-CD) by Ravello Community
https://blogs.oracle.com/ravello/continuous-integration-deployment-test-automation



- Unit tests. This 
```
is the suite that is run first, often by developers themselves 
before they add their changes to the repository. 
Unit tests normally test individual classes or functions. 
When those classes or functions need access to external resources, 
those resources are often faked as "mocks" or "stubs".
```
- Integration tests. 
```
This is the next level up from unit tests. 
Integration tests make sure that the modules that comprise an application work properly with each other. 
Ideally integration tests are run in environments that are similar to the production environment. 
For example, you'd want to make sure that if your application uses a database that the same database is available 
in your integration environment.
````
- System tests. 
```
Should test the entire system in an environment as close as possible to the real production environment.
```
