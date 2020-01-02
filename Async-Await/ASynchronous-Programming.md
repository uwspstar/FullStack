# async programming
- The core of async programming is the ```Task``` and ```Task<T>``` objects, which model asynchronous operations. 
- They are supported by the ```async``` and ```await``` keywords. 
- The model is fairly simple in most cases: For I/O-bound code, you await an operation which returns a Task or Task<T> inside of an async method. 
- For CPU-bound code, you await an operation which is started on a background thread with the Task.Run method. 
