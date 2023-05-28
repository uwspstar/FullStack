# Set up and run the Flask "Hello World" example:

## Step 1: Install Flask
- First, make sure you have Python and pip (Python package installer) installed on your system. Then, open your terminal or command prompt and run the following command to install Flask:

```py
pip install flask
```

## Step 2: Create a Python file
- Create a new Python file using a text editor or an integrated development environment (IDE) of your choice. Let's name it app.py. In this file, we'll write a simple Flask application.

```py
from flask import Flask

app = Flask(__name__)

@app.route('/')
def hello():
    return 'Hello, World!'

if __name__ == '__main__':
    app.run()
```
- In the above code, we import the Flask class from the flask module. We create a Flask application instance named app. Then, using the @app.route decorator, we define a route for the root URL (/) and associate it with the hello() function, which simply returns the "Hello, World!" string.

## Step 3: Run the application
- Open your terminal or command prompt, navigate to the directory where app.py is located, and run the following command:

```py
python app.py
```
- The Flask development server will start running, and you'll see output similar to:

- Running on http://127.0.0.1:5000/ (Press CTRL+C to quit)
- This means the server is now listening for requests locally at http://127.0.0.1:5000/.

## Step 4: Access the application
- Open your web browser and enter http://localhost:5000/ or http://127.0.0.1:5000/ in the address bar. You should see the "Hello, World!" message displayed in your browser.

- That's it! You have successfully created and run a Flask "Hello World" application.

- Flask is a versatile web framework and offers a wide range of features for building web applications. You can add more routes, handle different HTTP methods, work with templates, interact with databases, and much more. 
- This example provides a basic starting point, and you can explore Flask's documentation to learn more about its capabilities.
