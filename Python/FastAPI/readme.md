# Init


- `pip install fastapi`
- `pip install uvicorn`

## How to Steps

- `FastAPI` automatically generates an interactive API documentation using Swagger UI. Here's an example that integrates Swagger UI with the "Hello, World!" FastAPI application:

```py
from fastapi import FastAPI

app = FastAPI()

@app.get("/")
def read_root():
    return {"Hello": "World"}
```

- To enable `Swagger UI`, you need to import the `APIRouter` and `get_swagger_ui_html` functions from `fastapi.openapi.docs` module. Then, you can create a separate route to serve the `Swagger UI` HTML page.

- Here's an updated version of the code that includes the Swagger UI integration:

```py
from fastapi import FastAPI
from fastapi.openapi.docs import get_swagger_ui_html
from fastapi.openapi.utils import get_openapi
from fastapi.routing import APIRouter

app = FastAPI()

@app.get("/")
def read_root():
    return {"Hello": "World"}

### Create a router for the Swagger UI
```

```py
router = APIRouter()

@router.get("/docs", include_in_schema=False)
async def swagger_ui_html():
    return get_swagger_ui_html(openapi_url="/openapi.json", title="API Docs")
```

### Include the router in the main app

`app.include_router(router)`

### Generate the OpenAPI schema

```py
def custom_openapi():
    if app.openapi_schema:
        return app.openapi_schema
    openapi_schema = get_openapi(
        title="API Docs",
        version="1.0.0",
        description="This is the API documentation generated with FastAPI and Swagger UI.",
        routes=app.routes,
    )
    app.openapi_schema = openapi_schema
    return app.openapi_schema

app.openapi = custom_openapi
```

- In this updated code, we create a separate router using `APIRouter()` to handle the Swagger UI route. We define a new route /docs that returns the Swagger UI HTML page. The include_in_schema=False argument ensures that the route is not included in the generated OpenAPI schema.

- To generate the OpenAPI schema, we define a `custom_openapi()`function that overrides the default behavior. It generates the schema using the `get_openapi()` function and includes a custom title, version, and description. The app.openapi property is then set to our custom function.

- After incorporating these changes, you can run the FastAPI application as before:

`$ uvicorn main:app --reload`

- Now, you can access the Swagger UI documentation by going to `http://localhost:8000/docs` in your browser. It will provide an interactive interface to explore the API routes and make requests.

- also can run

```text
npm cache clean --force
npm install
```

