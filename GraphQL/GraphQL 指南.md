# GraphQL 指南
- [A Step-by-Step Guide to GraphQL](https://codebitwave.com/graphql-101-a-step-by-step-guide-to-graphql/)
## 介绍

### 什么是GraphQL？

GraphQL是一种**API查询语言**，以及用于实现这些查询的运行时。它于2012年由Facebook内部开发，并于2015年公开发布。GraphQL提供了一种更高效、强大且灵活的替代方案，取代了传统的REST API。

### 为什么使用GraphQL？

- **效率**：只获取你需要的数据，不多也不少。
- **灵活性**：可以在一个请求中从多个数据源获取数据。
- **自描述性**：API自带文档，易于理解和使用。

### 与REST的比较

| REST                                            | GraphQL                                   |
|-------------------------------------------------|-------------------------------------------|
| 不同数据需求使用多个端点                         | 单一端点处理所有查询                       |
| 数据获取过多或过少                              | 精确获取请求的数据                         |
| 通过新端点进行版本控制                          | 无需版本控制，通过模式进化                 |

**提示**：如果你在API中遇到了数据获取过多或过少的问题，GraphQL可以成为一种非常有效的解决方案。

## 核心概念

### 模式（Schema）

**模式**是任何GraphQL服务器的核心，用于定义数据的类型和关系。

```graphql
type Query {
  book(id: ID!): Book
}

type Book {
  id: ID!
  title: String!
  author: Author!
}

type Author {
  id: ID!
  name: String!
  books: [Book!]!
}
```

### 类型

- **标量类型**：`Int`、`Float`、`String`、`Boolean`、`ID`
- **对象类型**：自定义类型，如`Book`和`Author`
- **枚举类型**：一组预定义的常量
- **列表类型**：另一种类型的数组，例如`[Book!]!`

### 查询（Queries）

查询是客户端请求数据的方式。

```graphql
query {
  book(id: "1") {
    title
    author {
      name
    }
  }
}
```

### 变更（Mutations）

变更用于修改服务器端数据。

```graphql
mutation {
  addBook(title: "New Book", authorId: "2") {
    id
    title
  }
}
```

### 订阅（Subscriptions）

订阅允许客户端接收实时更新。

```graphql
subscription {
  bookAdded {
    id
    title
  }
}
```

**警告**：订阅功能需要客户端和服务器都支持WebSocket。

## 设置GraphQL服务器

### 先决条件

- JavaScript和Node.js的基础知识
- 在你的机器上安装了Node.js
- 代码编辑器（如VS Code）

### 步骤1：初始化项目

```bash
mkdir graphql-tutorial
cd graphql-tutorial
npm init -y
```

### 步骤2：安装依赖

```bash
npm install express express-graphql graphql
```

### 步骤3：设置服务器

创建`index.js`文件：

```javascript
const express = require('express');
const { graphqlHTTP } = require('express-graphql');
const schema = require('./schema');

const app = express();

app.use('/graphql', graphqlHTTP({
  schema,
  graphiql: true, // 启用GraphiQL UI
}));

app.listen(4000, () => console.log('服务器运行在4000端口'));
```

### 步骤4：定义模式

创建`schema.js`文件：

```javascript
const { GraphQLSchema, GraphQLObjectType, GraphQLString } = require('graphql');

const RootQuery = new GraphQLObjectType({
  name: 'Query',
  fields: {
    hello: {
      type: GraphQLString,
      resolve() {
        return 'Hello, World!';
      },
    },
  },
});

module.exports = new GraphQLSchema({
  query: RootQuery,
});
```

### 步骤5：运行服务器

```bash
node index.js
```

在浏览器中打开 [http://localhost:4000/graphql](http://localhost:4000/graphql)，并运行以下查询：

```graphql
{
  hello
}
```

**接下来该做什么？**

现在你已经运行了一个基本的服务器，你可以开始添加更多的类型、查询和变更。

## 编写查询

### 基本查询结构

查询由请求的字段组成。

```graphql
{
  fieldName
}
```

### 字段和参数

字段可以接受参数来过滤或修改数据。

```graphql
{
  book(id: "1") {
    title
    author {
      name
    }
  }
}
```

### 别名

别名允许你重命名字段的结果。

```graphql
{
  firstBook: book(id: "1") {
    title
  }
  secondBook: book(id: "2") {
    title
  }
}
```

### 片段（Fragments）

片段允许你重复使用查询的一部分。

```graphql
{
  book(id: "1") {
    ...BookDetails
  }
}

fragment BookDetails on Book {
  title
  author {
    name
  }
}
```

**提示**：使用片段保持查询的DRY原则（Don't Repeat Yourself）。

## 变更（Mutations）

### 创建数据

```graphql
mutation {
  addBook(title: "GraphQL Guide", authorId: "1") {
    id
    title
  }
}
```

### 更新数据

```graphql
mutation {
  updateBook(id: "1", title: "Updated Title") {
    id
    title
  }
}
```

### 删除数据

```graphql
mutation {
  deleteBook(id: "1") {
    id
  }
}
```

**警告**：在变更中验证用户输入，以防止安全漏洞。

## 高级主题

### 订阅（Subscriptions）

实现订阅需要设置一个WebSocket服务器。

```javascript
const { GraphQLServer, PubSub } = require('graphql-yoga');

const pubsub = new PubSub();

const typeDefs = `
  type Subscription {
    bookAdded: Book
  }
`;

const resolvers = {
  Subscription: {
    bookAdded: {
      subscribe: () => pubsub.asyncIterator(['BOOK_ADDED']),
    },
  },
};
```

### 指令（Directives）

指令用于修改查询的执行方式。

```graphql
{
  book(id: "1") {
    title
    author @include(if: $includeAuthor) {
      name
    }
  }
}
```

### 分页（Pagination）

使用`first`、`last`、`before`和`after`等参数实现分页。

```graphql
{
  books(first: 10, after: "cursor") {
    edges {
      node {
        title
      }
    }
    pageInfo {
      endCursor
      hasNextPage
    }
  }
}
```

### 错误处理

在解析器中优雅地处理错误。

```javascript
resolve(parent, args) {
  try {
    // 你的逻辑
  } catch (error) {
    throw new Error('发生了错误');
  }
}
```

**提示**：使用`graphql-errors`包来更好地格式化错误。

## 提示和最佳实践

### 设计模式

- **用图思考**：以图的形式建模数据，专注于实体及其关系。
- **命名约定**：使用清晰一致的类型和字段命名。
- **避免过度嵌套**：深层嵌套的查询可能导致性能问题。

### 性能考虑

- **批处理和缓存**：使用像DataLoader这样的工具批处理和缓存数据库请求。
- **查询复杂性分析**：限制查询的深度或复杂性以防止滥用。

### 安全考虑

- **验证**：在变更中验证输入，防止注入攻击。
- **授权**：实现适当的身份验证和授权机制。
- **速率限制**：通过限制请求数量保护服务器免受DDoS攻击。

**警告**：在模式中暴露过多信息可能会带来安全风险。谨慎选择包含的字段。

## 总结

### 回顾

- **GraphQL**提供了一个灵活且高效的REST替代方案。
- **模式（Schema）**定义了数据的结构。
- **查询和变更**用于获取和修改数据。
- **订阅**允许接收实时更新。

### 进一步资源

- [GraphQL 官方文档](https://graphql.org/learn/)
- [Apollo GraphQL](https://www.apollographql.com/docs/)
- [GraphQL Playground](https://github.com/prisma-labs/graphql-playground)

**为什么你应该继续学习？**

GraphQL因其高效性和灵活性正在迅速成为API开发的标准。掌握GraphQL可以显著提升你的开发技能。

**提示**：通过使用GraphQL构建一个小项目来巩固你的理解。

---

# Step-by-Step Guide to GraphQL with Examples
# GraphQL教程的详细步骤与示例

---

## Step 11: Connecting to a Database
## 第十一步：连接数据库

**English**

To make your GraphQL server more dynamic, you can connect it to a database. For this example, we'll use an in-memory array as a mock database.

First, let's define a data structure:

```javascript
const users = [
  { id: 1, name: 'Alice', age: 30 },
  { id: 2, name: 'Bob', age: 25 },
];
```

Modify your schema to include a `User` type and queries to fetch users:

```javascript
const schema = buildSchema(`
  type User {
    id: Int
    name: String
    age: Int
  }

  type Query {
    getUser(id: Int!): User
    getUsers: [User]
  }
`);
```

Update the root resolver:

```javascript
const root = {
  getUser: ({ id }) => {
    return users.find(user => user.id === id);
  },
  getUsers: () => {
    return users;
  },
};
```

**中文**

为了让您的GraphQL服务器更加动态，您可以将其连接到数据库。在此示例中，我们将使用内存数组作为模拟数据库。

首先，定义一个数据结构：

```javascript
const users = [
  { id: 1, name: 'Alice', age: 30 },
  { id: 2, name: 'Bob', age: 25 },
];
```

修改您的schema以包含`User`类型和用于获取用户的查询：

```javascript
const schema = buildSchema(`
  type User {
    id: Int
    name: String
    age: Int
  }

  type Query {
    getUser(id: Int!): User
    getUsers: [User]
  }
`);
```

更新root resolver：

```javascript
const root = {
  getUser: ({ id }) => {
    return users.find(user => user.id === id);
  },
  getUsers: () => {
    return users;
  },
};
```

---

## Step 12: Testing Database Queries
## 第十二步：测试数据库查询

**English**

Restart your server and try the following queries in GraphiQL:

1. **Get All Users**

   ```graphql
   {
     getUsers {
       id
       name
       age
     }
   }
   ```

2. **Get a Single User**

   ```graphql
   {
     getUser(id: 1) {
       name
       age
     }
   }
   ```

**中文**

重新启动服务器并在GraphiQL中尝试以下查询：

1. **获取所有用户**

   ```graphql
   {
     getUsers {
       id
       name
       age
     }
   }
   ```

2. **获取单个用户**

   ```graphql
   {
     getUser(id: 1) {
       name
       age
     }
   }
   ```

---

## Step 13: Adding Database Mutations
## 第十三步：添加数据库变更

**English**

Let's add a mutation to create a new user:

Modify your schema:

```javascript
const schema = buildSchema(`
  type User {
    id: Int
    name: String
    age: Int
  }

  type Query {
    getUser(id: Int!): User
    getUsers: [User]
  }

  type Mutation {
    createUser(name: String!, age: Int!): User
  }
`);
```

Update the root resolver:

```javascript
const root = {
  // Previous resolvers...

  createUser: ({ name, age }) => {
    const id = users.length + 1;
    const newUser = { id, name, age };
    users.push(newUser);
    return newUser;
  },
};
```

**中文**

我们来添加一个mutation来创建新用户：

修改您的schema：

```javascript
const schema = buildSchema(`
  type User {
    id: Int
    name: String
    age: Int
  }

  type Query {
    getUser(id: Int!): User
    getUsers: [User]
  }

  type Mutation {
    createUser(name: String!, age: Int!): User
  }
`);
```

更新root resolver：

```javascript
const root = {
  // 之前的resolver...

  createUser: ({ name, age }) => {
    const id = users.length + 1;
    const newUser = { id, name, age };
    users.push(newUser);
    return newUser;
  },
};
```

---

## Step 14: Testing the Create User Mutation
## 第十四步：测试创建用户的Mutation

**English**

In GraphiQL, execute the following mutation:

```graphql
mutation {
  createUser(name: "Charlie", age: 28) {
    id
    name
    age
  }
}
```

Then, query all users to see the updated list:

```graphql
{
  getUsers {
    id
    name
    age
  }
}
```

**中文**

在GraphiQL中，执行以下mutation：

```graphql
mutation {
  createUser(name: "Charlie", age: 28) {
    id
    name
    age
  }
}
```

然后，查询所有用户以查看更新的列表：

```graphql
{
  getUsers {
    id
    name
    age
  }
}
```

---

## Step 15: Connecting to a Real Database (Optional)
## 第十五步：连接到真实数据库（可选）

**English**

For a production application, you would connect your GraphQL server to a real database like MongoDB or PostgreSQL. Here's how you can connect to MongoDB using Mongoose:

1. **Install Mongoose:**

   ```bash
   npm install mongoose
   ```

2. **Connect to MongoDB:**

   Add the following code to your `index.js`:

   ```javascript
   const mongoose = require('mongoose');

   mongoose.connect('mongodb://localhost:27017/graphqltutorial', { useNewUrlParser: true, useUnifiedTopology: true });

   const UserSchema = new mongoose.Schema({
     name: String,
     age: Number,
   });

   const UserModel = mongoose.model('User', UserSchema);
   ```

3. **Update Resolvers to Use Mongoose:**

   ```javascript
   const root = {
     getUser: async ({ id }) => {
       return await UserModel.findById(id);
     },
     getUsers: async () => {
       return await UserModel.find();
     },
     createUser: async ({ name, age }) => {
       const user = new UserModel({ name, age });
       return await user.save();
     },
   };
   ```

**中文**

对于生产环境的应用程序，您将您的GraphQL服务器连接到诸如MongoDB或PostgreSQL等真实数据库。以下是如何使用Mongoose连接到MongoDB：

1. **安装Mongoose：**

   ```bash
   npm install mongoose
   ```

2. **连接到MongoDB：**

   在您的`index.js`中添加以下代码：

   ```javascript
   const mongoose = require('mongoose');

   mongoose.connect('mongodb://localhost:27017/graphqltutorial', { useNewUrlParser: true, useUnifiedTopology: true });

   const UserSchema = new mongoose.Schema({
     name: String,
     age: Number,
   });

   const UserModel = mongoose.model('User', UserSchema);
   ```

3. **更新Resolvers以使用Mongoose：**

   ```javascript
   const root = {
     getUser: async ({ id }) => {
       return await UserModel.findById(id);
     },
     getUsers: async () => {
       return await UserModel.find();
     },
     createUser: async ({ name, age }) => {
       const user = new UserModel({ name, age });
       return await user.save();
     },
   };
   ```

---

## Step 16: Implementing Authentication
## 第十六步：实现身份验证

**English**

To secure your GraphQL API, you might need to implement authentication. One common method is using JSON Web Tokens (JWT).

1. **Install JWT Libraries:**

   ```bash
   npm install jsonwebtoken express-jwt
   ```

2. **Add Middleware for Authentication:**

   ```javascript
   const jwt = require('express-jwt');

   app.use(
     jwt({
       secret: 'your_secret_key',
       algorithms: ['HS256'],
       credentialsRequired: false,
     })
   );
   ```

3. **Modify Resolvers to Check Authentication:**

   ```javascript
   const root = {
     getUser: async ({ id }, context) => {
       if (!context.user) {
         throw new Error('Unauthorized');
       }
       return await UserModel.findById(id);
     },
     // Other resolvers...
   };
   ```

**中文**

为了保护您的GraphQL API，您可能需要实现身份验证。一个常见的方法是使用JSON Web Tokens（JWT）。

1. **安装JWT库：**

   ```bash
   npm install jsonwebtoken express-jwt
   ```

2. **添加用于身份验证的中间件：**

   ```javascript
   const jwt = require('express-jwt');

   app.use(
     jwt({
       secret: 'your_secret_key',
       algorithms: ['HS256'],
       credentialsRequired: false,
     })
   );
   ```

3. **修改Resolvers以检查身份验证：**

   ```javascript
   const root = {
     getUser: async ({ id }, context) => {
       if (!context.user) {
         throw new Error('未授权');
       }
       return await UserModel.findById(id);
     },
     // 其他resolvers...
   };
   ```

---

## Step 17: Handling Errors
## 第十七步：处理错误

**English**

GraphQL allows you to return meaningful errors to the client. You can throw errors in your resolvers:

```javascript
const root = {
  getUser: async ({ id }) => {
    const user = await UserModel.findById(id);
    if (!user) {
      throw new Error('User not found');
    }
    return user;
  },
  // Other resolvers...
};
```

**中文**

GraphQL允许您向客户端返回有意义的错误。您可以在resolvers中抛出错误：

```javascript
const root = {
  getUser: async ({ id }) => {
    const user = await UserModel.findById(id);
    if (!user) {
      throw new Error('用户未找到');
    }
    return user;
  },
  // 其他resolvers...
};
```

---

## Step 18: Using GraphQL Variables
## 第十八步：使用GraphQL变量

**English**

When sending queries from a client application, you can use variables to make your queries dynamic.

Example query using variables:

```graphql
query GetUser($userId: Int!) {
  getUser(id: $userId) {
    name
    age
  }
}
```

Variables:

```json
{
  "userId": 1
}
```

**中文**

从客户端应用程序发送查询时，您可以使用变量使查询动态化。

使用变量的查询示例：

```graphql
query GetUser($userId: Int!) {
  getUser(id: $userId) {
    name
    age
  }
}
```

变量：

```json
{
  "userId": 1
}
```

---

## Step 19: Fragments and Aliases
## 第十九步：片段和别名

**English**

**Fragments** allow you to reuse parts of your GraphQL queries.

Example:

```graphql
{
  user1: getUser(id: 1) {
    ...userFields
  }
  user2: getUser(id: 2) {
    ...userFields
  }
}

fragment userFields on User {
  name
  age
}
```

**中文**

**片段**允许您重用GraphQL查询的一部分。

示例：

```graphql
{
  user1: getUser(id: 1) {
    ...userFields
  }
  user2: getUser(id: 2) {
    ...userFields
  }
}

fragment userFields on User {
  name
  age
}
```

---

## Step 20: Subscriptions for Real-time Data
## 第二十步：使用订阅获取实时数据

**English**

GraphQL Subscriptions allow you to receive real-time updates. Implementing subscriptions requires using WebSockets.

1. **Install Subscription Libraries:**

   ```bash
   npm install subscriptions-transport-ws graphql-subscriptions
   ```

2. **Set Up a Subscription Server:**

   This involves more advanced setup and is often done using Apollo Server.

**中文**

GraphQL订阅允许您接收实时更新。实现订阅需要使用WebSockets。

1. **安装订阅库：**

   ```bash
   npm install subscriptions-transport-ws graphql-subscriptions
   ```

2. **设置订阅服务器：**

   这涉及更高级的设置，通常使用Apollo Server完成。

---

## Conclusion
## 总结

**English**

You've now learned how to:

- Connect your GraphQL server to a database
- Implement authentication and error handling
- Use advanced GraphQL features like variables and fragments
- Explore real-time data with subscriptions

From here, you can build complex and efficient APIs that meet your application's needs.

**中文**

您现在已经学会了：

- 将您的GraphQL服务器连接到数据库
- 实现身份验证和错误处理
- 使用高级GraphQL功能，如变量和片段
- 使用订阅探索实时数据

从这里开始，您可以构建满足您应用程序需求的复杂且高效的API。

---

## Additional Resources
## 其他资源

- **English**
  - [GraphQL Best Practices](https://graphql.org/learn/best-practices/)
  - [GraphQL Security](https://www.apollographql.com/docs/apollo-server/security/)

- **中文**
  - [GraphQL最佳实践](https://graphql.cn/learn/best-practices/)
  - [GraphQL安全性](https://www.apollographql.com/docs/apollo-server/security/)
