
#【尚硅谷】Docker与微服务实战（2022版)

- https://www.youtube.com/watch?v=Cmy2afG_XOE

# Client/Server

# 架构中主要的模块有: 
- DockerC1ient: Docker Client是与 Docker Daemon建立通信的最佳途径。用户通过 Docker Client发起容器的管理请求，请求最终发往 DockerDaemon。

- DockerDaemon: Docker Daemon 作为 Docker架构中的主体部分，首先具备服务端的功能，有能力接收 Docker Client发起的请求;其次具备 Docker Client请求的处理能力。 Docker Daemon 内部所 有的任务均由 Engine 来完成，且每一项工作都以一个 Job 的形式存在。

- Docker Registry : 从 Docker Registry 中下载镜 像，并通过镜像管理驱动 graphdriver将下载的镜像存储在 graph 中
- Graph、 
- Driver、 
- libcontainer
- Docker Container

# 用户通过 Docker Client发起容器的管理请求，请求最终发往 DockerDaemon
# 每一项工作都以一个 Job 的形式存在

# Docker Client
- 可以通过以下三种方式和 Docker Daemon建立通信，分别为: 
    - tcp:// host:port、 
    - unix://path_to_socket
    - fd://socketfd。

# Docker Daemon 
- 是 Docker架构中一个常驻在后台的系统进程。所谓的"运行 Docker", 即代表运行 Docker Daemon。总之， 
- DockerDaemon 的作用主要有以下两方面:
    - 接收并处理 DockerClient发送的请求。
    - 管理所有的 Docker容器。