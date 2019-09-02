
# JWT-based Authentication
- Angular Security - Authentication With JSON Web Tokens (JWT): The Complete Guide by Angular University
https://blog.angular-university.io/angular-jwt-authentication/

### 1. JWT-based Authentication in a Nutshell
```
If JWTs are used for Authentication, they will contain at least 1) a user ID and 2) an expiration timestamp.
```
  - Bearer Token identifies the user that owns it, and defines a user session.
  - A bearer token is a signed temporary replacement for the username/password combination!
  - a separately hosted Login Page ```in our domain or in a third-party domain```
  - Sign-On solution
  ```
  hosted either in our domain or in a third-party domain. In an enterprise scenario, 
  the login page is often hosted on a separate server, 
  which is part of a company-wide Single Sign-On solution. 
  ```
  - third-party Authentication provider : 
  ```
  On the public Internet, the login page might also be:
    • hosted by a third-party Authentication provider such as Auth0
    • available directly in our single page application using a login screen route or a modal
  ```
### 2. Creating a JWT-based user Session
  - using node-jsonwebtoken
### 3. Sending a JWT back to the client
  - store a JWT Session Token?
  - Cookies vs Local Storage
### 4. Storing and using the JWT on the client side
  - Checking User Expiration
### 5. Sending The JWT back to the server on each request
  - build an Authentication HTTP Interceptor
### 6. Validating User Requests
 - Building a custom Express middleware for JWT validation
 - Configuring a JWT validation middleware using express-jwt
 - Validating JWT Signatures - RS256
### 7. JWKS (JSON Web Key Set) endpoints and key rotation
### RS256 vs HS256
