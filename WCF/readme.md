# WCF
- Windows Communication Foundation and is part of .NET 3.0
- Distributed application, is an application where parts of it run on 2 or more computers
- interoperable application : An application that can communicate with any other application that is built on any platform and using any programming language is called as an interoperable application. Web services are interoperable, where as .NET remoting services are not.

- Why should we use WCF?

```
Let's take this scenario
We have 2 clients and we need to implement a service a for them. 
1. The first client is using a Java application to interact with our service, 
so for interoperability this client wants messages to be in XML format and the protocol to be HTTP.
2. The second client uses .NET, 
so for better performance this client wants messages formatted in binary over TCP protocol.
 
To support the above 2 client requirements, 
we would configure 2 end points. 
In the endpoint configuration we can specify the protocols and message formats that we want to use.
```
