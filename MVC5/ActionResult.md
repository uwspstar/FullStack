# ActionResult

- BadRequest: Returns an HTTP 400 (“Bad Request”). Optionally includes either a message or an automatically formatted error class based on validation errors in a ModelStateDictionary. 
- Conflict: Returns an HTTP 409 (“Confl ict”). 
- Content: Returns content (similar to the behavior of an action method that returns a raw object). Content format is automatically negotiated, or optionally the developer can specify the media type formatter and/or the content type of the response. The developer chooses which HTTP status code the response uses. 
- Created: Returns an HTTP 201 (“Created”). The Location header is set to the provided URL location. 
- CreatedAtRoute: Returns an HTTP 201 (“Created”). The Location header is set to the URL that is constructed based on the provided route name and route values. 
- InternalServerError: Returns an HTTP 500 (“Internal Server Error”). Optionally includes content derived from the provided exception. 
- Json: Returns an HTTP 200 (“OK”), with the provided content formatted as JSON. Optionally formats the content with the provided serializer settings and/or character encoding. 
- NotFound: Returns an HTTP 404 (“Not Found”). 
- Ok: Returns an HTTP 200 (“OK”). Optionally includes content whose format is automatically negotiated (to specify the exact format, use the Content method instead). 
- Redirect: Returns an HTTP 302 (“Found”). The Location header is set to the provided URL location. 
- RedirectToRoute: Returns an HTTP 302 (“Found”). The Location header is set to the URL that is constructed based on the provided route name and route values. 
- ResponseMessage: Returns the provided HttpResponseMessage. 
- StatusCode: Returns a response with the provided HTTP status code (and an empty response body). 
- Unauthorized: Returns an HTTP 401 (“Unauthorized”). The authentication header is set to the provided authentication header values.
