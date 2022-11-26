# Curl in Scripts

- Curl: 全称CommandLine URL 或 CommandLine Uniform Resource Locator，顾名思义，curl命令是在命令行方式下工作，利用URL的语法进行数据的传输或者文件的传输。

## Reference

- <https://www.ruanyifeng.com/blog/2011/09/curl.html>
- <https://blog.csdn.net/deliciousion/article/details/78062521>
- <https://www.cnblogs.com/duhuo/p/5695256.html>
- 3 Hour Bash Tutorial <https://linuxhint.com/3hr_bash_tutorial/>
- <https://curl.se/docs/httpscripting.html>
- <https://catonmat.net/cookbooks/curl>

## man curl

## Most common

### `-v` 选项，`--verbose`，指定该选项后，可以跟踪URL的连接信息。我们可以根据这个选项看看curl是怎么工作的

```bash
curl -v www.google.com
```

### `-i` 选项，`--include`，把回应的头信息包含在内，跟-v大同小异，是-v的子集。`-I`（大写i）选项，`--head`，只显示返回的头信息，与-v大同小异，是-v的子集

```bash
curl -i www.google.com
curl -I www.google.com
```

### `-u` 选项，带用户验证的连接。可以访问或获取带用户验证的URL

```bash
curl -u username:password ftp://127.0.0.1/hello.txt
curl -u username ftp://127.0.0.1/hello.txt
curl -u username:password https://127.0.0.1/
```

## basic command

Command                              |NOTEs
-------------------------------------|--------------------------------------------------------------------------
`-A/--user-agent <string>`           |设置用户代理发送给服务器
`-b/--cookie <name=string/file>`     |cookie字符串或文件读取位置
`-c/--cookie-jar <file>`             |操作结束后把cookie写入到这个文件中
`-C/--continue-at <offset>`          |断点续转
`-D/--dump-header <file>`            |把header信息写入到该文件中
`-e/--referer`                       |来源网址
`-f/--fail`                          |连接失败时不显示http错误
`-o/--output`                        |把输出写到该文件中
`-O/--remote-name`                   |把输出写到该文件中，保留远程文件的文件名
`-r/--range <range>`                 |检索来自HTTP/1.1或FTP服务器字节范围
`-s/--silent`                        |静音模式。不输出任何东西
`-T/--upload-file <file>`            |上传文件
`-u/--user <user[:password]>`        |设置服务器的用户和密码
`-v 选项，--verbose`                  |指定该选项后，可以跟踪URL的连接信息。我们可以根据这个选项看看curl是怎么工作的。
`-w/--write-out [format]`            |什么输出完成后
`-x/--proxy <host[:port]>`           |在给定的端口上使用HTTP代理
`-#/--progress-bar`                  |进度条显示当前的传送状态

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

- 查看网页源码,

```bash
curl www.google.com
```

- 如果要把这个网页保存下来，可以使用`-o`参数，这就相当于使用wget命令了。

```bash
curl -o [文件名] www.google.com
```

- 有的网址是自动跳转的。使用`-L`参数，curl就会跳转到新的网址。

```bash
curl -L www.google.com
```

- `-i`参数可以显示http response的头信息，连同网页代码一起。`-I`参数则是只显示http response的头信息。

```bash
curl -i www.google.com

curl -I www.google.com
```

- `-v`参数可以显示一次http通信的整个过程，包括端口连接和http request头信息。

```bash
curl -v www.google.com
```

- 如果你觉得上面的信息还不够，那么下面的命令可以查看更详细的通信过程。运行后，请打开output.txt文件查看

```bash
curl --trace output.txt www.google.com

```

- 发送表单信息有GET和POST两种方法。GET方法相对简单，只要把数据附在网址后面就行。

```bash
curl example.com/form.cgi?data=xxx
```

- POST方法必须把数据和网址分开，curl就要用到--data参数。

```bash
curl -X POST --data "data=xxx" example.com/form.cgi
```

- 如果你的数据没有经过表单编码，还可以让curl为你编码，参数是`--data-urlencode`。

```bash
curl -X POST--data-urlencode "date=April 1" example.com/form.cgi
```

- HTTP verb, curl默认的HTTP动词是GET，使用`-X`参数可以支持其他动词

```bash
curl -X POST www.example.com

curl -X DELETE www.example.com
```

- 文件上传

```bash
curl --form upload=@localfilename --form press=OK [URL]
```

- Referer字段, 有时你需要在http request头信息中，提供一个referer字段，表示你是从哪里跳转过来的。

```bash
curl --referer http://www.example.com http://www.example.com
```

- User Agent字段 这个字段是用来表示客户端的设备信息。服务器有时会根据这个字段，针对不同设备，返回不同格式的网页，比如手机版和桌面版。 iPhone4的User Agent是

```bash
curl --user-agent "[User Agent]" [URL]
```

- 使用`--cookie`参数，可以让curl发送cookie

```bash
curl --cookie "name=xxx" www.example.com
```

- 至于具体的cookie的值，可以从http response头信息的`Set-Cookie`字段中得到。
- `-c cookie-file`可以保存服务器返回的cookie到文件，`-b cookie-file`可以使用这个文件作为cookie信息，进行后续的请求。

```bash
curl -c cookies http://example.com
curl -b cookies http://example.com
```

- 有时需要在http request之中，自行增加一个头信息。`--header`参数就可以起到这个作用。

```bash
curl --header "Content-Type:application/json" http://example.com
```

- HTTP认证

```bash
curl --user name:password example.com
```

```bash
```
