### 05/17/2019
- **Docker and Kubernetes: The Complete Guide** https://www.udemy.com/docker-and-kubernetes-the-complete-guide/ by **Stephen Grider**
- Docker image // single file with all dependencies and configs to run the program
- Docker container // instance of the image to run the program
- Docker client (Docker cli) // commands just a portal, nothing related the docker imgs and containers
- Docker server (Docker daemon) // create img ,run container
- install Docker on mac https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436624?start=1
- **install Docker which install a linux VM on the top of mac/windows , the linux kernal is running inside linux VM**
> ![PC work](/Img/docker005.png)
- $> Docker version
> ![PC work](/Img/docker004.png)
- https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436632?start=15


### 05/20/2019
### $> Docker run hello-world
```
1) Docker server check the image cache first before pull from free service Docker Hub.
2) After pulling the image, it's saved image cache first.
3) The Docker server take the single image to memory to create a container of it, 
and run a signle programe on it.
```
```
To generate this message, Docker took the following steps: 
** grab the image, create a container, and run it **

 1. The Docker client contacted the Docker daemon.
 2. The Docker daemon pulled the "hello-world" image from the Docker Hub.
    (amd64) (Docker server check the image cache first before pull from free service Docker Hub.
    after pull the image, it's saved image cache first)
 3. The Docker daemon created a new container from that image which runs the
    executable that produces the output you are currently reading.
 4. The Docker daemon streamed that output to the Docker client, which sent it
    to your terminal.

For more examples and ideas, visit: https://docs.docker.com/get-started/
 ```
- screen shot from 
https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436632?start=15
> ![PC work](/Img/docker001.png)
- **Namespacing & control groups only for linux system ( not windows, not macOS )**
> ![PC work](/Img/docker002.png)

### Docker Client
- $> docker run busybox echo hi there
- $> docker run busybox ls
- $> docker ps
- $> docker ps --help
- $> docker ps --all
- **Docker run =  Docker Create + Docker start**
```
$> docker create hello-world
f809ebae37de9b573b8abd387cdfdb8a242009add35aa0e7bd306b9db9e1e207
$> docker start -a f809ebae37de9b573b8abd387cdfdb8a242009add35aa0e7bd306b9db9e1e207
$> docker start f809ebae37de9b573b8abd387cdfdb8a242009add35aa0e7bd306b9db9e1e207
f809ebae37de9b573b8abd387cdfdb8a242009add35aa0e7bd306b9db9e1e207

//-a means to watch and return the result to user screen
```
- $> docker system prune
- $> docker logs f809ebae37de9b573b8abd387cdfdb8a242009add35aa0e7bd306b9db9e1e207
- $> docker stop <id> // give 10 second to finish and stop
- $> docker kill <id> // stop now
- open another window $> docker ps
- $> docker run redis
- $> docker exec -it 9d758c1f656c redis-cli // important to use **-it = -i -t**
- -t make format nice with intellengence 
 ```
 open another window to run $> docker ps 

 $> docker exec -it 9d758c1f656c redis-cli
127.0.0.1:6379> 
$>ctrl + C  //exit
 ```
 
- $> docker exec -it 2b6d1d3b9761 sh // **sh** run the command inside container, good for debug
```
$> docker exec -it 2b6d1d3b9761 sh 
$> #
$> # cd /
$> # ls
$> bin  boot  data  dev  etc  home  lib  lib64  media  mnt  opt  proc  root  run  sbin  srv  sys  tmp  usr  var
$> # cd ~
```
- **ctrl + c NOT WORKING, try ctrl + D, or command + D**
