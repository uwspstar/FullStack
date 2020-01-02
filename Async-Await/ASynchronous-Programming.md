# async programming
- The core of async programming is the ```Task``` and ```Task<T>``` objects, which model asynchronous operations. 
- They are supported by the ```async``` and ```await``` keywords. 
- The model is fairly simple in most cases: For I/O-bound code, you await an operation which returns a Task or Task<T> inside of an async method. 
- For CPU-bound code, you await an operation which is started on a background thread with the Task.Run method. 

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
