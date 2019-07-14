# react
### Complete React Developer in 2019 (w/ Redux, Hooks, GraphQL) by Andrei Neagoie
- https://www.udemy.com/complete-react-developer-zero-to-mastery/

```
1. decide on components
2. decide the state and where it lives
3. what changes should we make when the state changes
```
### SSH
- Connecting With SSH To Github
- https://www.udemy.com/complete-react-developer-zero-to-mastery/learn/lecture/15359990#overview
- https://help.github.com/en/enterprise/2.15/user/articles/generating-a-new-ssh-key-and-adding-it-to-the-ssh-agent

### npm vs. yarn
```
// Install dependencies from package.json: 
npm install == yarn

// Install a package and add to package.json: 
npm install package --save == yarn add package

// Install a devDependency to package.json: 
npm install package --save-dev == yarn add package --dev

// Remove a dependency from package.json: 
npm uninstall package --save == yarn remove package

// Upgrade a package to its latest version: 
npm update --save == yarn upgrade

// Install a package globally: 
npm install package -g == yarn global add package

```
- Create React App https://reactjs.org/docs/create-a-new-react-app.html#create-react-app
- promise https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise
- jsonplaceholder https://jsonplaceholder.typicode.com/users
- whatis_json https://www.w3schools.com/whatis/whatis_json.asp
- search box
```
<input type='search' placeholder='search ...' 
onChange={e=> console.log(e.target.value)}
/>

<input type='search' placeholder='search ...' 
onChange={e=> this.setState({searchFiled : e.target.value },console.log(this.state))}
/>

```
- js, everything is not in the 6 types are object
```
6 types are , number, string, boolean, null, undefine, symble

```
- map()
- filter()
- includes()
- Handling Events https://reactjs.org/docs/handling-events.html
- preventDefault()
- Class Methods and Arrow Functions
https://www.udemy.com/complete-react-developer-zero-to-mastery/learn/lecture/14870617#overview
- bind() https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_objects/Function/bind
- render()
- componentDidMount()
- React and ReactDOM https://www.udemy.com/complete-react-developer-zero-to-mastery/learn/lecture/14915222#overview
- Virtual DOM https://www.udemy.com/complete-react-developer-zero-to-mastery/learn/lecture/15082734#overview
- Asynchronous setState
- React Lifecycle Methods
http://projects.wojtekmaj.pl/react-lifecycle-methods-diagram/

### E-Commerce project
```
$> npx create-react-app e-commerce

```
### CSS and SCSS files
- cubic-bezier() https://www.w3schools.com/cssref/func_cubic-bezier.asp
- routing https://www.udemy.com/complete-react-developer-zero-to-mastery/learn/lecture/15113848#overview
- Manipulating the browser history https://developer.mozilla.org/en-US/docs/Web/API/History_API
### Redux 
### Hooks
### GraphQL
### ContextAPI
### Stripe
### Firebase
