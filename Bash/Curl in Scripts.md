# Curl in Scripts

## Reference

- <https://www.ruanyifeng.com/blog/2011/09/curl.html>
- 3 Hour Bash Tutorial <https://linuxhint.com/3hr_bash_tutorial/>

## curl 是常用的命令行工具，用来请求 Web 服务器。它的名字就是客户端（client）的 URL 工具的意思

- install

```bash
sudo apt install curl
```

```bash
#! /bin/bash
url="http://www.ovh.net/files/1Mb.dat"
curl ${url} -O
# ‘-O’ indicated that it will inherit its file name from its source.
curl ${url} -o NewFileDownload
# ‘-o’ flag and after that write the new file name
curl -I ${url}
# ‘-I’ before the url of the file.
```

- <https://www.ruanyifeng.com/blog/2011/09/curl.html>

```bash
# 查看网页源码,
$ curl www.google.com
```

```bash
#  如果要把这个网页保存下来，可以使用`-o`参数，这就相当于使用wget命令了。
$ curl -o [文件名] www.google.com
```

```bash
# 有的网址是自动跳转的。使用`-L`参数，curl就会跳转到新的网址。
$ curl -L www.google.com
```

```bash
# `-i`参数可以显示http response的头信息，连同网页代码一起。
$ curl -i www.google.com
# `-I`参数则是只显示http response的头信息。
$ curl -I www.google.com
```

```bash
# `-v`参数可以显示一次http通信的整个过程，包括端口连接和http request头信息。
$ curl -v www.google.com
```

```bash
# 如果你觉得上面的信息还不够，那么下面的命令可以查看更详细的通信过程。运行后，请打开output.txt文件查看
$ curl --trace output.txt www.google.com

```

## 发送表单信息

- 发送表单信息有GET和POST两种方法。GET方法相对简单，只要把数据附在网址后面就行。
