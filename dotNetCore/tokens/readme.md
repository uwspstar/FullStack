# How asp.net core generates and validates tokens
- https://csharp-video-tutorials.blogspot.com/2019/10/how-tokens-are-generated-and-validated.html

- GenerateUserTokenAsync() has 3 parameters.
```
The user the token will be for
The token provider which will actually generate the token
The token purpose - For example, password reset or email confirmation. Token generated for a given purpose must be used only for that purpose. For example, an email confirmation token cannot be used to reset a password.
```
