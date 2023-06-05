#  The difference between how routing works in an Angular application vs how it is handled by a server
## Issue:
- For some reason, with my Angular app deployed to Azure, if I directly enter https://xflash.azurewebsites.net/report into the browser, it doesn't work. However, if I first go to https://xflash.azurewebsites.net and then click the button to route to https://xflash.azurewebsites.net/report, it works. It seems to be an issue related to Angular routing.
- This issue is most likely happening because of the difference between how routing works in an Angular application vs how it is handled by a server.

- Angular uses client-side routing. When you navigate in your app, Angular changes the URL in the browser and then decides what view to present based on that URL. It doesn't involve the server, hence everything works as you expect when you are within the app.

- But when you refresh the page or directly put a URL into the browser, the browser makes a request to the server for that specific URL. Now, Azure (or any server, generally) doesn't know about your Angular routes; it just tries to find a file at the location specified by the URL. When it can't find one, it returns a 404.

- To solve this problem, you need to setup your server such that all routes fall back to your index.html. This is the file that bootstraps your Angular app. When your app loads, Angular's router can take the current URL and navigate to the appropriate route.
- In Azure, you can achieve this by adding a web.config file at the root of your site folder (i.e., where your index.html is located). Here's an example of what it should look like:

```xml
<?xml version="1.0"?>
<configuration>
    <system.webServer>
        <rewrite>
            <rules>
                <rule name="Angular Routes" stopProcessing="true">
                    <match url=".*" />
                    <conditions logicalGrouping="MatchAll">
                        <add input="{REQUEST_FILENAME}" matchType="IsFile" negate="true" />
                        <add input="{REQUEST_FILENAME}" matchType="IsDirectory" negate="true" />
                    </conditions>
                    <action type="Rewrite" url="/" />
                </rule>
            </rules>
        </rewrite>
    </system.webServer>
</configuration>
```

- This file sets up a URL rewrite rule using IIS's rewrite module. When a request comes in that does not match an existing file or directory, it will rewrite the URL to /, loading index.html and allowing your Angular routing to take over.

- After you've added the web.config file, you should redeploy your application to Azure.

- This should resolve the issue you're facing. Remember to always include the web.config file with these settings whenever you're deploying an Angular application to a server.

## Can I add the web.config in my angular src folder to let ng build copy it to dist folder?

- Yes, you can add the web.config file to your src folder. However, Angular's build process doesn't automatically copy non-asset files from src to dist folder. You have to configure it manually.

- To include the web.config file in the build output, you can add it to the assets array in the Angular project's angular.json file.

- Here is how you can do it:

- Open angular.json in your project root.
- Find the projects > architect > build > options > assets array in the JSON structure. It might look something like this:
```js
"assets": [
  "src/favicon.ico",
  "src/assets"
],
```

- Add a new string to the array pointing to src/web.config. Afterwards, it should look something like this:
```js
"assets": [
  "src/favicon.ico",
  "src/assets",
  "src/web.config"
],
```

- Save and close angular.json.
- Now, when you run ng build, Angular CLI will copy the web.config file to the output directory (dist). When you deploy your app to Azure, include this web.config in your deployment.
