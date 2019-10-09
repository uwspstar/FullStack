# Caching in C# .NET
- Caching idea : When performing a heavy operation, we will save the result in our cache container. The next time that we need that result, we will pull it from the cache container, instead of performing the heavy operation again.
- Caching works great for data that changes infrequently.
- NO using Caching if the Data constantly changes,
