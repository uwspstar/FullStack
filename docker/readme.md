### 05/20/2019
- **Docker and Kubernetes: The Complete Guide** https://www.udemy.com/docker-and-kubernetes-the-complete-guide/ by **Stephen Grider**
- Docker image // single file with all dependencies and configs to run the program
- Docker container // instance of the image to run the program
- Docker client (Docker cli) // commands just a portal, nothing related the docker imgs and containers
- Docker server (Docker daemon) // create img ,run container
- install Docker on mac https://www.udemy.com/docker-and-kubernetes-the-complete-guide/learn/v4/t/lecture/11436624?start=1
- > run> Docker version
- > run> Docker run hello-world
- Docker server check the image cache first before pull from free service Docker Hub. after pull the image, it's saved image cache first
```
To generate this message, Docker took the following steps:

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
