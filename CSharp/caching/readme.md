# Caching in C# .NET
### Caching Idea
- When performing a heavy operation, we will save the result in our cache container. The next time that we need that result, we will pull it from the cache container, instead of performing the heavy operation again.
- Caching works great for data that changes infrequently.
- NO using Caching if the Data constantly changes,
### 3 Types ( In-process Cache, Persistant in-process Cache, and Distributed Cache)
- In-Memory Cache : 
```
implement cache in a single process. When the process dies, the cache dies with it. 
```
- Persistent in-process Cache :
```
save cache outside of process memory (in a file, or in a database)
```
- Distributed Cache
