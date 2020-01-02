# async programming
- The core of async programming is the ```Task``` and ```Task<T>``` objects, which model asynchronous operations. 
- They are supported by the ```async``` and ```await``` keywords. 
- The model is fairly simple in most cases: For I/O-bound code, you await an operation which returns a Task or Task<T> inside of an async method. 
- For CPU-bound code, you await an operation which is started on a background thread with the Task.Run method. 
  
- On the C# side of things, the compiler transforms your code into a state machine which keeps track of things like ```yielding``` execution when an await is reached and resuming execution when a background job has finished. 
### Recognize CPU-Bound and I/O-Bound Work
```Here are two questions you should ask before you write any code: ```
- 1. Will your code be "waiting" for something, such as data from a database? If your answer is "yes", then your work is I/O-bound. 
- 2. Will your code be performing a very expensive computation? If you answered "yes", then your work is CPU-bound. 

### I/O-bound
- If the work you have is I/O-bound, use async and await ```without``` Task.Run . 
- You should ```NOT``` use the ```Task Parallel``` Library. The reason for this is outlined in the Async in Depth article.

### CPU-bound 
- If the work you have is CPU-bound and you care about responsiveness, use async and await but spawn the work off on another thread with Task.Run . 
- If the work is appropriate for concurrency and parallelism, you should also consider using the Task Parallel Library.

### I/O-Bound Example: Downloading data from a web service 
```
private readonly HttpClient _httpClient = new HttpClient();
downloadButton.Clicked += async (o, e) => 
{    
  // This line will yield control to the UI as the request    
  // from the web service is happening.    
  //    
  // The UI thread is now free to perform other work.    
  var stringData = await _httpClient.GetStringAsync(URL);    
  DoSomethingWithData(stringData); 
};

```
### CPU-bound Example: Performing a Calculation for a Game 
```
private DamageResult CalculateDamageDone() 
{    
  // Code omitted:    
  //    
  // Does an expensive calculation and returns    
  // the result of that calculation. 
}
calculateButton.Clicked += async (o, e) => {    
  // This line will yield control to the UI while CalculateDamageDone()    
  // performs its work.  The UI thread is free to perform other work.    
  var damageResult = await Task.Run(() => CalculateDamageDone());    
  DisplayDamage(damageResult); 
};

```
