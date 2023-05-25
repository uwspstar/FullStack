# display the JSON schema in Swagger
- To display the JSON schema in Swagger, you can use the Swagger UI tool, which provides a user-friendly interface for exploring and interacting with APIs documented using the OpenAPI Specification (OAS).

## Here are the steps to display the schema in Swagger using Swagger UI:

- Install Swagger UI in your project. You can use a package manager like npm or yarn to install it:
```bash
npm install swagger-ui-dist
```


- Create an HTML file (e.g., swagger.html) in your project and add the following code:
```html
<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <title>Swagger UI</title>
  <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/swagger-ui/4.2.0/swagger-ui.min.css">
</head>
<body>
  <div id="swagger-ui"></div>

  <script src="https://cdnjs.cloudflare.com/ajax/libs/swagger-ui/4.2.0/swagger-ui-bundle.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/swagger-ui/4.2.0/swagger-ui-standalone-preset.min.js"></script>
  <script>
    window.onload = function() {
      const spec = {
        "openapi": "3.0.0",
        "info": {
          "title": "Your API Documentation",
          "version": "1.0.0"
        },
        "paths": {},
        "components": {
          "schemas": {
            "YourSchema": {
              "$schema": "http://json-schema.org/draft-07/schema#",
              "type": "object",
              "properties": {
                "id": {
                  "type": "integer"
                },
                "guid": {
                  "type": "string",
                  "pattern": "^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$"
                },
                "context": {
                  "type": "string"
                }
              },
              "required": ["id", "guid", "context"]
            }
          }
        }
      };

      const ui = SwaggerUIBundle({
        spec: spec,
        dom_id: '#swagger-ui',
        deepLinking: true,
        presets: [SwaggerUIBundle.presets.apis],
        plugins: [SwaggerUIBundle.plugins.DownloadUrl],
        layout: "StandaloneLayout"
      });
    };
  </script>
</body>
</html>
```

- Customize the HTML file as needed. Update the title and version in the spec object to match your API documentation details. You can also modify the YourSchema section with your actual schema definition.

- Open the swagger.html file in a web browser, and you should see the Swagger UI interface with your schema displayed.

- Note that in this example, the schema is directly embedded in the HTML file. If you have a more complex API specification with multiple endpoints and schemas, you might want to consider using the full OpenAPI Specification (OAS) file (in JSON or YAML format) and providing the URL to that file in the spec configuration instead.

- Remember to serve the `swagger.html` file through a web server or by running it locally using a tool like http-server to ensure the necessary resources are loaded correctly.

- This is a basic example to get you started. Swagger UI provides various customization options and features that you can explore further in the official Swagger UI documentation (https://swagger.io/tools/swagger-ui/).
