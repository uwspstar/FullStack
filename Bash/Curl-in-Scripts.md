# Curl in Scripts

## Reference

- <https://www.ruanyifeng.com/blog/2011/09/curl.html>
- 3 Hour Bash Tutorial <https://linuxhint.com/3hr_bash_tutorial/>
- <https://curl.se/docs/httpscripting.html>
- <https://catonmat.net/cookbooks/curl>

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
