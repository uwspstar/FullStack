### 05/17/2019
- **Docker and Kubernetes: The Complete Guide** https://www.udemy.com/docker-and-kubernetes-the-complete-guide/ by **Stephen Grider**
- Docker image // single file with all dependencies and configs to run the program
- Docker container // instance of the image to run the program
- Docker client (Docker cli) // commands just a portal, nothing related the docker imgs and containers
- Docker server (Docker daemon) // create img ,run container
- install Docker on mac https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436624?start=1
- **install Docker which install a linux VM on the top of mac/windows , the linux kernal is running inside linux VM**
- kernel 核心，要点；[计] 内核
- daemon  守护进程；后台程序
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
- $> docker exec -it 9d758c1f656c redis-cli 
```
 // important to use **-it = -i -t**
 -t make format nice with intellengence 
```
```
 open another window to run $> docker ps 

 $> docker exec -it 9d758c1f656c redis-cli
127.0.0.1:6379> 
$>ctrl + C  //exit
```
 
- $> docker exec -it 2b6d1d3b9761 sh // **sh** run the command inside container, good for debug
sh just another command shell, same as bach, powershell, etc
```
$> docker exec -it 2b6d1d3b9761 sh 
$> #
$> # cd /
$> # ls
$> bin  boot  data  dev  etc  home  lib  lib64  media  
mnt  opt  proc  root  run  sbin  srv  sys  tmp  usr  var
$> # cd ~
```
- **"Ctrl + C" NOT WORKING, try "Ctrl + D", or "exit", or "command + D"**

### Building Custom Images Through Docker Server
- Docker File --> Docker Client --> Docker Server --> use img
- Creat a Docker file
```
1) Specify a base img
2) run some command to install additional programs
3) Specify a command to run when container startup
```
>  ![PC work](/Img/docker006.png)

### 05/21/2019
- The Build Process in Detail 
https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436706?start=30
- Making Real Projects with Docker
https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436944?start=0

### 05/26/2019
- kernel 核心，要点；[计] 内核
- daemon  守护进程；后台程序
- docker version
- login user id // NOT email
- docker run hello-world  
- ```docker run =  docker create <img> + docker start <container>```
- Create container : copy the FS snapshot into container
- Start container : run the start up command in the created container

```
\\ First time , you will see "Status: Downloaded newer image for hello-world:latest"

Docker took the following steps:
 1. The Docker client contacted the Docker daemon. (CLI and daemon)
 2. The Docker daemon pulled the "hello-world" image from the Docker Hub.
    (amd64)
 3. The Docker daemon created a new container from that image which runs the
    executable that produces the output you are currently reading.
 4. The Docker daemon streamed that output to the Docker client, which sent it
    to your terminal.
```
- Docker image include 1. File System (FS) 2. Start Up Command ( suck as echo hellp )
>Docker server check the image cache first before pull from free service Docker Hub. After pull the image, it's saved image cache first. First time , you will see "Status: Downloaded newer image for hello-world:latest"
- $>docker run busybox echo hi // docker run <img> <command> 
- $>docker run busybox ls // the list folders belong to the container
>Docker can run the img command, because of the command (such as. exe) inside the img somewhere
- $>docker run busybox ping google.com
- $>docker ps
- $>docker ps --all
- $>docker --help 
```
\\same as $>docker --help 
$>docker
```
- $>docker create hello-world
- $>docker start -a 11e3f7da0c3b26c  
```
// -a means sent the output from running contain to your screen
```
>when start a container, we can restart again, but we cannot override the startup command
- $docker system prune  // very usefull, clearn up you pc when you no longer use the container
```
WARNING! This will remove:
        - all stopped containers
        - all networks not used by at least one container
        - all dangling images
        - all dangling build cache // the img cached which download form Docker Hub
```
- $>docker logs 587608fee71c //NOT log . 
>try run docker --help to see all command


### Manipulating Containers with the Docker Client
- $>docker

### all command lowercase
```
Commands:
  attach      Attach local standard input, output, and error streams to a running container
  ** build       Build an image from a Dockerfile
  commit      Create a new image from a container's changes
  cp          Copy files/folders between a container and the local filesystem
  ** create      Create a new container
  ** diff        Inspect changes to files or directories on a container's filesystem
  events      Get real time events from the server
  *** exec        Run a command in a running container
  export      Export a container's filesystem as a tar archive
  ** history     Show the history of an image
  ** images      List images
  import      Import the contents from a tarball to create a filesystem image
  info        Display system-wide information
  inspect     Return low-level information on Docker objects
  ** kill        Kill one or more running containers
  load        Load an image from a tar archive or STDIN
  login       Log in to a Docker registry
  logout      Log out from a Docker registry
  ** logs        Fetch the logs of a container
  pause       Pause all processes within one or more containers
  port        List port mappings or a specific mapping for the container
  ** ps          List containers
  pull        Pull an image or a repository from a registry
  push        Push an image or a repository to a registry
  *** rename      Rename a container
  *** restart     Restart one or more containers
  *** rm          Remove one or more containers
  rmi         Remove one or more images
  ** run         Run a command in a new container
  save        Save one or more images to a tar archive (streamed to STDOUT by default)
  ** search      Search the Docker Hub for images
  *** start       Start one or more stopped containers
  ** stats       Display a live stream of container(s) resource usage statistics
  ** stop        Stop one or more running containers
  tag         Create a tag TARGET_IMAGE that refers to SOURCE_IMAGE
  top         Display the running processes of a container
  unpause     Unpause all processes within one or more containers
  update      Update configuration of one or more containers
  version     Show the Docker version information
  wait        Block until one or more containers stop, then print their exit codes
  ```
 - $>docker system --help
 ```
 Commands:
  df          Show docker disk usage
  events      Get real time events from the server
  info        Display system-wide information
  prune       Remove unused data
```
- $>docker system df
- docker create <img> <command> // cannot override the commad at docker start, docker start only start defult command
 
### 05/27/2019
- $>docker kill 2e611b8ecd1d
- $>docker ps --all
- $>docker system prune

- Executing Commands in Running Containers ``` docker exec -it <containerid> <command> ```
- $>docker exec -it b98293d46ff9 redis-cli
- -it means input command to the container
- -it means -i -t // -i attach the command to container, -t output nice format to screen
- Getting a Command Prompt in a Container ```$>docker exec -it b98293d46ff9 sh ```
```
- $>docker exec -it b98293d46ff9 sh  // sh is a shell
# redis-cli
127.0.0.1:6379> ^C
# cd ~/
# ls
```
- $>docker run -it busybox sh 
```
/ # touch newFoldreName     // create newFoldre
```
### Building Custom Images Through Docker Server
- Docker File -> Docker Client -> Docker Server -> Usable Img
```
1) Specify a base img
2) Run some command to install additional program
3) Run a specify command to run a container startup
```
- $>docker build .  ``` NEED .```
```
Sending build context to Docker daemon  2.048kB
Step 1/3 : FROM alpine
 ---> 055936d39205
Step 2/3 : RUN apk add --update redis
 ---> Running in 7e88b7cdadd9
fetch http://dl-cdn.alpinelinux.org/alpine/v3.9/main/x86_64/APKINDEX.tar.gz
fetch http://dl-cdn.alpinelinux.org/alpine/v3.9/community/x86_64/APKINDEX.tar.gz
(1/1) Installing redis (4.0.12-r0)
Executing redis-4.0.12-r0.pre-install
Executing redis-4.0.12-r0.post-install
Executing busybox-1.29.3-r10.trigger
OK: 7 MiB in 15 packages
Removing intermediate container 7e88b7cdadd9
 ---> 8186cf679ef8
Step 3/3 : CMD ["redis-server"]
 ---> Running in d8795562fa54
Removing intermediate container d8795562fa54
 ---> 3a2bb2a40e74
Successfully built 3a2bb2a40e74
```
### 05/28/2019
- https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/lecture/11436706#overview
```
create tempary container, output tempary img, the img cached in your local machine. Next time,
run same command ( same order), will get the same img from cache
```
- try to change the commad order as less as possible, so docker can use the pre build image from cache
- alpine just a OS
- apk just apach package
- https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/lecture/11436708#overview
### all docker command need to be lowercase
- all docker command need to be lowercase ( include inside dockerfile, not include key, such FROM. CMD, etc)
- node img https://hub.docker.com/_/node
- $>docker build .
- $>docker build -t uwspstar/simpleweb:latest .
### Container Port Mapping
- $>docker run -p 8080:8080 uwspstar/simpleweb
- $>docker run -p 5000:8080 uwspstar/simpleweb  
>$>docker run -p 5000:8080 uwspstar/simpleweb 
>
>the port number inside application is listening 8080, box in a container, the 5000 is local to mapping to 8080
- $>docker run -it uwspstar/simpleweb sh  // NOT -t

### 05/30/2019
### Minimizing Cache Busting and Rebuilds

```
# Specify a base img
FROM node:alpine

# Install some dependencies
COPY ./package.json ./
RUN npm install
COPY ./ ./

# Default command
CMD ["npm","start"]
```
