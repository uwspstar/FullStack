# Docker 从入门到实践
- https://vuepress.mirror.docker-practice.com/introduction/what/

- Docker and Kubernetes: The Complete Guide** https://www.udemy.com/docker-and-kubernetes-the-complete-guide/ by Stephen Grider

# Docker
- Docker 官方文档：https://docs.docker.com/
- Docker Hub：https://hub.docker.com
- Docker 的源代码仓库：https://github.com/moby/moby

# Docker image
- `Docker image` // single file with all dependencies and configs to run the program

- 因为镜像包含操作系统完整的 root 文件系统，其体积往往是庞大的，因此在 Docker 设计时，就充分利用 Union FS (opens new window)的技术，将其设计为分层存储的架构。
- 所以严格来说，镜像并非是像一个 ISO 那样的打包文件，镜像只是一个虚拟的概念，其实际体现并非由一个文件组成，而是由一组文件系统组成，或者说，由多层文件系统联合组成。

# Docker container
- `Docker container` // instance of the image to run the program

- 镜像（Image）和容器（Container）的关系，就像是面向对象程序设计中的 类 和 实例 一样，镜像是静态的定义，容器是镜像运行时的实体。容器可以被创建、启动、停止、删除、暂停等。

- 容器的实质是进程，但与直接在宿主执行的进程不同，容器进程运行于属于自己的独立的 命名空间 (opens new window)

- 因此容器可以拥有自己的 root 文件系统、自己的网络配置、自己的进程空间，甚至自己的用户 ID 空间

- 镜像使用的是分层存储，容器也是如此

- 容器存储层的生存周期和容器一样，容器消亡时，容器存储层也随之消亡。因此，任何保存于容器存储层的信息都会随容器删除而丢失

- 按照 `Docker 最佳实践的要求`，容器不应该向其存储层内写入任何数据，容器存储层要保持无状态化。所有的文件写入操作，都应该使用 数据卷（`Volume`）、或者 绑定宿主目录，在这些位置的读写会跳过容器存储层，直接对宿主（或网络存储）发生读写，其性能和稳定性更高。

- An image is an executable package that includes everything needed
- A container is launched by running an image. 

# Docker Registry

- `Docker Registry`
   - Docker Registry 公开服务
   - 私有 Docker Registry

- 一个 `Docker Registry` 中可以包含多个 仓库（`Repository`）；每个仓库可以包含多个 标签（`Tag`）；每个标签对应一个镜像。

通常，一个仓库会包含同一个软件不同版本的镜像，而标签就常用于对应该软件的各个版本。我们可以通过 <仓库名>:<标签> 的格式来指定具体是这个软件哪个版本的镜像。如果不给出标签，将以 latest 作为默认标签。

# 使用 Docker 镜像
- 从 Docker 镜像仓库获取镜像的命令是 docker pull
```
$ docker pull [选项] [Docker Registry 地址[:端口号]/]仓库名[:标签]
```
- 下载也是一层层的去下载，并非单一文件。
- 对于 Docker Hub，如果不给出用户名，则默认为 library，也就是官方镜像

- Docker Hub 中显示的体积是压缩后的体积。在镜像下载和上传过程中镜像是保持着压缩状态的，因此 Docker Hub 所显示的大小是网络传输中更关心的流量大小。而 docker image ls 显示的是镜像下载到本地后，展开的大小，准确说，是展开后的各层所占空间的总和，因为镜像到本地后，查看空间的时候，更关心的是本地磁盘空间占用的大小。

- 由于 Docker 使用 Union FS，相同的层只需要保存一份即可，因此实际镜像硬盘占用空间很可能要比这个列表镜像大小的总和要小的多。


- 通过 `docker system df` 命令来便捷的查看镜像、容器、数据卷所占用的空间
```
$ docker system df
```
- 无标签镜像也被称为 虚悬镜像(dangling image) ，可以用下面的命令专门显示这类镜像：

```
$ docker image ls -f dangling=true
```

- 镜像为基础启动并运行一个容器
```
$ docker run -it --rm ubuntu:18.04 bash
root@e7009c6ce357:/# cat /etc/os-release
```

- `-it`：这是两个参数，一个是 -i：交互式操作，一个是 -t 终端。
我们这里打算进入 bash 执行一些命令并查看返回结果，因此我们需要交互式终端。

- `--rm`：这个参数是说容器退出后随之将其删除。默认情况下，为了排障需求，退出的容器并不会立即删除，除非手动 docker rm。我们这里只是随便执行个命令，看看结果，不需要排障和保留结果，因此使用 --rm 可以避免浪费空间。

- `ubuntu:18.04`：这是指用 ubuntu:18.04 镜像为基础来启动容器。

- `bash`：放在镜像名后的是 命令，这里我们希望有个交互式 Shell，因此用的是 bash。

- 进入容器后，我们可以在 Shell 下操作，执行任何所需的命令。这里，我们执行了 `cat /etc/os-release`，这是 Linux 常用的查看当前系统版本的命令

- 列出已经下载下来的镜像，可以使用 `docker image ls`
```
$ docker image ls
```
- 为了加速镜像构建、重复利用资源，Docker 会利用 中间层镜像。所以在使用一段时间后，可能会看到一些依赖的中间层镜像。

- 默认的 docker image ls 列表中只会显示顶层镜像，如果希望显示包括中间层镜像在内的所有镜像的话，需要加 `-a` 参数。
```
$ docker image ls -a
```
- list 在 mongo:3.2 之后since建立的镜像 and before 建立的镜像
```
$ docker image ls -f since=mongo:3.2
$ docker image ls -f before=mongo:3.2
```
- 所有的镜像的 ID 列出来
```
$ docker image ls -q
```
- `--filter` 配合 `-q` 产生出指定范围的 ID 列表，然后送给另一个 docker 命令作为参数，从而针对这组实体成批的进行某种操作的做法在 Docker 命令行使用过程中非常常见 (Go 的模板语法)

```
$ docker image ls --format "{{.ID}}: {{.Repository}}"
5f515359c7f8: redis
05a60462f8ba: nginx
fe9198c04d62: mongo
```
- 或者打算以表格等距显示，并且有标题行，和默认一样，不过自己定义列：

```
$ docker image ls --format "table {{.ID}}\t{{.Repository}}\t{{.Tag}}"
IMAGE ID            REPOSITORY          TAG
5f515359c7f8        redis               latest
05a60462f8ba        nginx               latest
fe9198c04d62        mongo               3.2
```
- 如果要删除本地的镜像，可以使用 docker image rm 命令，其格式为：

```
$ docker image rm [选项] <镜像1> [<镜像2> ...]
```
- 其中，<镜像> 可以是 镜像短 ID、镜像长 ID、镜像名 或者 镜像摘要。
- 镜像的唯一标识是其 ID 和摘要，而一个镜像可以有多个标签
- 更精确的是使用 镜像摘要 删除镜像。
```
$ docker image ls --digests
$ docker image rm node@sha256:b4f0e0bdeb578043c1ea6862f0d40cc4afe32a4a582f3be235a3b164422be228
Untagged: node@sha256:b4f0e0bdeb578043c1ea6862f0d40cc4afe32a4a582f3be235a3b164422be228
```
- `Untagged` 和 `Deleted`
- 因此当我们使用上面命令删除镜像的时候，实际上是在要求删除某个标签的镜像。所以首先需要做的是将满足我们要求的所有镜像标签都取消，这就是我们看到的 Untagged 的信息。
- 因为一个镜像可以对应多个标签，因此当我们删除了所指定的标签后，可能还有别的标签指向了这个镜像，如果是这种情况，那么 Delete 行为就不会发生。所以并非所有的 docker image rm 都会产生删除镜像的行为，有可能仅仅是取消了某个标签而已。
- 当该镜像所有的标签都被取消了，该镜像很可能会失去了存在的意义，因此会触发删除行为

- 像其它可以承接多个实体的命令一样，可以使用 `docker image ls -q` 来配合使用 `docker image rm`，这样可以成批的删除希望删除的镜像。
```
$ docker image rm $(docker image ls -q redis)
```
```
$ docker image rm $(docker image ls -q -f before=mongo:3.2)
```
# 利用 commit 理解镜像构成
- 不要使用 `docker commit` 定制镜像，定制镜像应该使用 `Dockerfile` 来完成。
- Docker 提供了一个 `docker commit` 命令，可以将容器的存储层保存下来成为镜像。换句话说，就是在原有镜像的基础上，再叠加上容器的存储层，并构成新的镜像。以后我们运行这个新镜像的时候，就会拥有原有容器最后的文件变化。

- docker commit 的语法格式为：
```
$ docker commit [选项] <容器ID或容器名> [<仓库名>[:<标签>]]
```
```
$ docker commit \
    --author "Tao Wang <twang2218@gmail.com>" \
    --message "修改了默认网页" \
    webserver \
    nginx:v2
```
- 其中 `--author` 是指定修改的作者，而 `--message` 则是记录本次修改的内容
- 用 docker history 具体查看镜像内的历史记录
```
$ docker history nginx:v2
```
# 慎用 docker commit
- 由于命令的执行，还有很多文件被改动或添加了。会有大量的无关内容被添加进来，将会导致镜像极为臃肿.
- 生成的镜像也被称为 黑箱镜像，换句话说，就是除了制作镜像的人知道执行过什么命令、怎么生成的镜像，别人根本无从得知

# 使用 Dockerfile 定制镜像
- `FROM` 指定基础镜像 : FROM 就是指定 基础镜像，因此一个 Dockerfile 中 FROM 是必备的指令，并且必须是`第一条指令`。
- Docker 还存在一个特殊的镜像，名为 `scratch`。这个镜像是虚拟的概念，并不实际存在，它表示一个空白的镜像。
# RUN 执行命令 (其格式有两种)
- shell 格式：RUN <命令>
```
RUN echo '<h1>Hello, Docker!</h1>' > /usr/share/nginx/html/index.html
```
- exec 格式：RUN ["可执行文件", "参数1", "参数2"]，这更像是函数调用中的格式。
- 很多初学 Docker 的人`常犯的一个错误`, such as 像 Shell 脚本一样把每个命令对应一个 RUN。
- Union FS 是有最大层数限制的，比如 AUFS，曾经是最大不得超过 42 层，现在是不得超过 127 层

- bad example
```
FROM debian:stretch

RUN apt-get update
RUN apt-get install -y gcc libc6-dev make wget
RUN wget -O redis.tar.gz "http://download.redis.io/releases/redis-5.0.3.tar.gz"
RUN mkdir -p /usr/src/redis
RUN tar -xzf redis.tar.gz -C /usr/src/redis --strip-components=1
RUN make -C /usr/src/redis
RUN make -C /usr/src/redis install
```
- `Dockerfile` `正确的写法`应该是这样 good example : 
```
FROM debian:stretch

RUN set -x; buildDeps='gcc libc6-dev make wget' \
    && apt-get update \
    && apt-get install -y $buildDeps \
    && wget -O redis.tar.gz "http://download.redis.io/releases/redis-5.0.3.tar.gz" \
    && mkdir -p /usr/src/redis \
    && tar -xzf redis.tar.gz -C /usr/src/redis --strip-components=1 \
    && make -C /usr/src/redis \
    && make -C /usr/src/redis install \
    && rm -rf /var/lib/apt/lists/* \
    && rm redis.tar.gz \
    && rm -r /usr/src/redis \
    && apt-get purge -y --auto-remove $buildDeps
```
- 首先，之前所有的命令只有一个目的，就是编译、安装 redis 可执行文件。因此没有必要建立很多层，这只是一层的事情。因此，这里没有使用很多个 RUN 一一对应不同的命令，而是仅仅使用一个 RUN 指令，并使用 && 将各个所需命令串联起来。将之前的 7 层，简化为了 1 层。
- 在撰写 Dockerfile 的时候，要经常提醒自己，这并`不是在写 Shell 脚本，而是在定义每一层该如何构建`。
- 为了格式化还进行了换行。Dockerfile 支持 Shell 类的行尾添加 \ 的命令换行方式，以及行首 # 进行注释的格式。良好的格式，比如换行、缩进、注释等，会让维护、排障更为容易，这是一个比较好的习惯。

- 使用了 docker build 命令进行镜像构建。其格式为：
```
docker build [选项] <上下文路径/URL/->
```
# 镜像构建上下文（Context）
- 当我们进行镜像构建的时候，并非所有定制都会通过 RUN 指令完成，经常会需要将一些本地文件复制进镜像，比如通过 COPY 指令、ADD 指令等。而 docker build 命令构建镜像，其实并非在本地构建，而是在服务端，也就是 Docker 引擎中构建的。
-那么可以用 `.gitignore` 一样的语法写一个 `.dockerignore`，该文件是用于剔除不需要作为上下文传递给 Docker 引擎的


# 操作 Docker 容器
- 新建并启动 所需要的命令主要为 docker run。
```
$ docker run ubuntu:18.04 /bin/echo 'Hello world'
Hello world
```
- 下面的命令则启动一个 bash 终端，允许用户进行交互。其中，`-t` 选项让Docker分配一个伪终端（pseudo-tty）并绑定到容器的标准输入上， `-i` 则让容器的标准输入保持打开
```
$ docker run -t -i ubuntu:18.04 /bin/bash
root@af8bae53bdd3:/#
```

- docker run 创建容器时，Docker 在后台运行的标准操作包括：
   - 检查本地是否存在指定的镜像，不存在就从 registry 下载
   - 利用镜像创建并启动一个容器
   - 分配一个文件系统，并在只读的镜像层外面挂载一层可读写层
   - 从宿主主机配置的网桥接口中桥接一个虚拟接口到容器中去
   - 从地址池配置一个 ip 地址给容器
   - 执行用户指定的应用程序
   - 执行完毕后容器被终止

- 可以利用 `docker container start` 命令，直接将一个已经终止（exited）的容器启动运行。
- 更多的时候，需要让 Docker 在后台运行而不是直接把执行命令的结果输出在当前宿主机下。此时，可以通过添加 -d 参数来实现。
- 容器是否会长久运行，是和 docker run 指定的命令有关，和 -d 参数无关
- 要获取容器的输出信息，可以通过 docker container logs 命令。
```
$ docker container logs [container ID or NAMES]
```
- 可以使用 `docker container stop` 来终止一个运行中的容器。
- 终止状态的容器可以用 `docker container ls -a` 命令看到
- `docker container restart` 命令会将一个运行态的容器终止，然后再重新启动它。
- 在使用 -d 参数时，容器启动后会进入后台。
- 某些时候需要进入容器进行操作，包括使用 `docker attach` 命令或 `docker exec` 命令，
- 推荐大家使用 `docker exec` 命令 (exit，不会导致容器的停止)


# Docker client
- `Docker client` (Docker cli) // commands just a portal, nothing related the docker images and containers

# Docker server
- `Docker server` (Docker daemon) // create img ,run container

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
and run a single program on it.
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
- Create a Docker file
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
  ** login       Log in to a Docker registry
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
  *** rmi         Remove one or more images
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
- $>docker exec -it b98293d46ff9 sh  // sh is a shell , -t is tag
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
create tempary container, output tempary img, the img cached in your local machine. 
Next time, run same command ( same order), will get the same img from cache
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
- $>docker run -p 5000:8080 uwspstar/simpleweb 
```
the port number inside application is listening 8080, box in a container, 
the 5000 is local to mapping to 8080
```
- $>docker run -it uwspstar/simpleweb sh  // NOT -t

### 05/29/2019
```
# Specify a base img
FROM node:alpine

# Install some dependencies
COPY ./ ./
RUN npm install

# Default command
CMD ["npm","start"]
```

### 05/30/2019
### Minimizing Cache Busting and Rebuilds
- cache package.json step
- COPY <from> <to>
```
// Copy current location package.json file to container current location
COPY ./package.json ./
```
- we do not need to run the $>RUN npm install if ./package.json file NOT change, save time
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
- step 2/5 and 3/5 now, using cache
```
Sending build context to Docker daemon  4.096kB
Step 1/5 : FROM node:alpine
 ---> 91acf04599c4
Step 2/5 : COPY ./package.json ./
 ---> Using cache
 ---> 06261e89a1ab
Step 3/5 : RUN npm install
 ---> Using cache
 ---> d1c2c46dc888
Step 4/5 : COPY ./ ./
 ---> b90f522ffa04
Step 5/5 : CMD ["npm","start"]
 ---> Running in 9ceb0adc5bcb
Removing intermediate container 9ceb0adc5bcb
 ---> 89a7ae89b730
Successfully built 89a7ae89b730
Successfully tagged uwspstar/simpleweb:latest
```
- Redis  // same as tiny databse inside memory
```
- $>docker info
- $>docker rmi a4195c3fb018 //remove docker image
- $>docker rm ms4195c3fb018  //remove container
```
- A Docker Cheat Sheet
https://www.digitalocean.com/community/tutorials/how-to-remove-docker-images-containers-and-volumes#a-docker-cheat-sheet
- $>docker-compose ``` // Define and run multi-container applications with Docker.```
```
Commands:
  build              Build or rebuild services
  bundle             Generate a Docker bundle from the Compose file
  config             Validate and view the Compose file
  create             Create services
  down               Stop and remove containers, networks, images, and volumes
  events             Receive real time events from containers
  exec               Execute a command in a running container
  help               Get help on a command
  images             List images
  kill               Kill containers
  logs               View output from containers
  pause              Pause services
  port               Print the public port for a port binding
  ps                 List containers
  pull               Pull service images
  push               Push service images
  restart            Restart services
  rm                 Remove stopped containers
  run                Run a one-off command
  scale              Set number of containers for a service
  start              Start services
  stop               Stop services
  top                Display the running processes
  unpause            Unpause services
  up                 Create and start containers
  version            Show the Docker-Compose version information
```

### 06/01/2019
- docker-compose.yml
```
I want to create docker-compose.yml
1) redis-server container
   - make it using the redis image
2) node-app container
   - make is using the Dockerfile in the current director
   - map port 4040 to 8081
   4040 local port
   8018 port in docker container
   keyword services means container

```
- networking with Docker Compose
https://stackoverflow.com/questions/19234831/where-are-docker-images-stored-on-the-host-machine
- docker run myimage // = docker-compose up
- docker build . + docker run myimage // = docker-compose up --build
- $>docker-compose up
```
Creating network "visits_default" with the default driver
Pulling redis-server (redis:)...
latest: Pulling from library/redis
743f2d6c1f65: Pull complete
171658c5966d: Pull complete
fbef10bd7a65: Pull complete
0b0b11956c72: Pull complete
09dbd716637e: Pull complete
d09046fd4481: Pull complete
Building node-app  420B/420BB
Step 1/6 : FROM node:alpine
 ---> 91acf04599c4
Step 2/6 : WORKDIR "/app"
 ---> Using cache
 ---> f7dddb2e1111
Step 3/6 : COPY package.json .
 ---> fe434746c563
Step 4/6 : RUN npm install
 ---> Running in 48ec3f0415a8
npm notice created a lockfile as package-lock.json. You should commit this file.
npm WARN app No description
npm WARN app No repository field.
npm WARN app No license field.

added 54 packages from 41 contributors and audited 130 packages in 2.989s
found 0 vulnerabilities

Removing intermediate container 48ec3f0415a8
 ---> a97dcd71a599
Step 5/6 : COPY . .
 ---> 8b10c602b602
Step 6/6 : CMD ["npm", "start"]
 ---> Running in a3da79c6ddab
Removing intermediate container a3da79c6ddab
 ---> 2818c9e17382
Successfully built 2818c9e17382
Successfully tagged visits_node-app:latest
WARNING: Image for service node-app was built because it did not already exist. To rebuild this image you must use `docker-compose build` or `docker-compose up --build`.
Creating visits_node-app_1     ... done
Creating visits_redis-server_1 ... done
Attaching to visits_redis-server_1, visits_node-app_1
redis-server_1  | 1:C 01 Jun 2019 10:32:31.035 # oO0OoO0OoO0Oo Redis is starting oO0OoO0OoO0Oo
redis-server_1  | 1:C 01 Jun 2019 10:32:31.035 # Redis version=5.0.5, bits=64, commit=00000000, modified=0, pid=1, just started
redis-server_1  | 1:C 01 Jun 2019 10:32:31.035 # Warning: no config file specified, using the default config. In order to specify a config file use redis-server /path/to/redis.conf
redis-server_1  | 1:M 01 Jun 2019 10:32:31.037 * Running mode=standalone, port=6379.
redis-server_1  | 1:M 01 Jun 2019 10:32:31.037 # WARNING: The TCP backlog setting of 511 cannot be enforced because /proc/sys/net/core/somaxconn is set to the lower value of 128.
redis-server_1  | 1:M 01 Jun 2019 10:32:31.037 # Server initialized
redis-server_1  | 1:M 01 Jun 2019 10:32:31.037 # WARNING you have Transparent Huge Pages (THP) support enabled in your kernel. This will create latency and memory usage issues with Redis. To fix this issue run the command 'echo never > /sys/kernel/mm/transparent_hugepage/enabled' as root, and add it to your /etc/rc.local in order to retain the setting after a reboot. Redis must be restarted after THP is disabled.
redis-server_1  | 1:M 01 Jun 2019 10:32:31.037 * Ready to accept connections
node-app_1      | 
node-app_1      | > @ start /app
node-app_1      | > node index.js
node-app_1      | 
node-app_1      | Listening on port 8081
```
- port=6379 // redis TCP
- $>docker-compose up -d
- $>docker-compose down
- Top 10 Docker CLI commands you can’t live without by ryanwhocodes
https://medium.com/the-code-review/top-10-docker-commands-you-cant-live-without-54fb6377f481
```
1) $>docker ps 
2) $>docker pull
3) $>docker build
4) $>docker run
5) $>docker log
6) $>docker volume ls
7) $>docker rm
8) $>docker rmi
9) $>docker stop
10 $>docker-compose up -d // start up all my containers 
    - $>docker kill $(docker ps -q) //  - kill all running containers with 
    - $>docker rm $(docker ps -a -q) // delete all stopped containers with 
    - $>docker rmi $(docker images -q) //delete all images with 
```
- ```-q, --quiet          Only display IDs```
```
A container is launched by running an image. 
An image is an executable package that includes everything needed
to run an application–the code, a runtime, libraries, environment variables, and configuration files.
A container is a runtime instance of an image–what the image 
becomes in memory when executed (that is, an image with state, or a user process). 
You can see a list of your running containers with the command, docker ps, 
just as you would in Linux. — from Docker Concepts
```
- Automatic Container Restarts
https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/lecture/11437008#overview

### 06/02/2019
- npm run start
- npm run test
- npm run build
- $>docker build -f Dockerfile.dev .   
``` 
-f mean the specified file
```
- COPY with docker but with exclusion 
https://stackoverflow.com/questions/43747776/copy-with-docker-but-with-exclusion
- .dockerignore file
```
before :
Sending build context to Docker daemon  153.3MB

after :
Sending build context to Docker daemon  1.066MB
```
- WORKDIR
```
You can think of WORKDIR like a cd inside the container 
(it affects commands that come later in the Dockerfile, like the RUN command). 
```
### CMD ["npm", "run", "start"] // NOT space, need to use ","
- $>docker run -p 4000:3000 99ae0f84099b
```
-p 4000:3000
mapping localhost 4000 to container port 3000
```

### reference container with Bookmarking Volumes
https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/lecture/11437068#overview
