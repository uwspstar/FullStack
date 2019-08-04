

# VSCODE shortcuts
- windows
https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf
- macos
https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf
- The guide to Visual Studio Code shortcuts, higher productivity and 30 of my favourite shortcuts you need to learn
 by lampewebdev
https://dev.to/lampewebdev/the-guide-to-visual-studio-code-shortcuts-higher-productivity-and-30-of-my-favourite-shortcuts-you-need-to-learn-mb3
# git ssh & sourcetree
- $> ssh-keygen -t rsa -b 4096 -C "uwspstar@gmail.com"
```Generating public/private rsa key pair.```
- Enter file in which to save the key (/Users/xingwang/.ssh/id_rsa): 
```just enter, use default```
- Enter passphrase (empty for no passphrase): ```just enter, use default```
- Enter same passphrase again: 
```just enter, use default```
```
Your identification has been saved in /Users/xingwang/.ssh/id_rsa.
Your public key has been saved in /Users/xingwang/.ssh/id_rsa.pub.
```
- $> pbcopy < ~/.ssh/id_rsa.pub
```
copy the pub key to github 
```
### default port
```
*** 20: File Transfer Protocol (FTP) Data Transfer
*** 21: File Transfer Protocol (FTP) Command Control
*** 22: Secure Shell (SSH) Secure Login
23: Telnet remote login service, unencrypted text messages
*** 25: Simple Mail Transfer Protocol (SMTP) E-mail routing
*** 53: Domain Name System (DNS) service
*** 80: Hypertext Transfer Protocol (HTTP) used in the World Wide Web
110: Post Office Protocol (POP3)
119: Network News Transfer Protocol (NNTP)
123: Network Time Protocol (NTP)
143: Internet Message Access Protocol (IMAP) Management of digital mail
161: Simple Network Management Protocol (SNMP)
194: Internet Relay Chat (IRC)
*** 443: HTTP Secure (HTTPS) HTTP over TLS/SSL
```
# Azure / Web Jobs
# React
# Jest / test framework
# MongoDB

### Frisby
# Parcel / boundle tool 
# Webpack
# Docker
https://www.udemy.com/docker-and-kubernetes-the-complete-guide/

# Azure Storage 
https://www.edureka.co/blog/azure-storage-tutorial/

# Microservices architecture style
- Microservices architecture style(https://docs.microsoft.com/en-us/azure/architecture/guide/architecture-styles/microservices)
![Microservices](/Img/microservices-logical.svg)

### API document
- swagger
- $>npm install -g swagger 
- http://convertjson.com/yaml-to-json.htm

### Consider this architecture style for:

- Large applications that require a high release velocity.
- Complex applications that need to be highly scalable.
- Applications with rich domains or many subdomains.
- An organization that consists of small development teams.

# JWT
- JWT: The Complete Guide to JSON Web Tokens https://blog.angular-university.io/angular-jwt/
- Angular Security - Authentication With JSON Web Tokens (JWT): The Complete Guide https://blog.angular-university.io/angular-jwt-authentication/
# CI/CD
- Top 8 Continuous Integration Tools (https://code-maze.com/top-8-continuous-integration-tools/)
- CI CD Pipeline: Learn How to Setup a CI CD Pipeline From Scratch
(https://medium.com/edureka/ci-cd-pipeline-5508227b19ca)
- CI/CD pipeline using Docker and Jenkins. Step by step 
(https://syndicode.com/2019/04/05/ci-cd-pipeline-using-docker-and-jenkins-step-by-step/)
- Continuous Integration, Delivery, Deployment

# Media Queries
- [Media Queries](https://css-tricks.com/snippets/css/media-queries-for-standard-devices/)

# Full Stack Developer
![Full Stack Developer](/Img/fullstack0.JPG)
- [internet History https://www.vox.com/a/internet-maps](https://www.vox.com/a/internet-maps)

# Node.js
- [Node notes](https://github.com/uwspstar/node/blob/master/readme.md)
 
# JS code snippet 
- [My code snippet https://repl.it/@uwspstar/ScalyInferiorCoordinates](https://repl.it/@uwspstar/ScalyInferiorCoordinates)

# color convert rgb
https://www.colorhexa.com/3f3151

# Image File Formats

- [https://99designs.com/blog/tips/image-file-types/](https://99designs.com/blog/tips/image-file-types/)

- [https://pageweight.imgix.com/](https://pageweight.imgix.com/)

- [https://www.sitepoint.com/gif-png-jpg-which-one-to-use/](https://www.sitepoint.com/gif-png-jpg-which-one-to-use/)


  - If you want transparency : use a PNG 
  - if you want animations : use a GIF 
  - if you want colorful detailed images : use a JPEG
  - if you want simple icons, logos, and illustrations : use a SVGs.
  - Reduce PNG with TinyPNG
  - Reduce JPG with JPEG-optimizer
  - Try to choose simple illustrations over highly detailed photos
  - Always lower JPEG image quality (30~60%)
  - Resize image based on size it will be displayed
  - Display different sized images for different backgrounds.
  - Use CDNs like imigx
  - Remove image metadata
  
```
you can convert SVG into Base64 encoding, and that works as the Data URI 

HTML 
<img alt="" src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDo etc">
<img src='data:image/svg+xml;utf8,<svg ... > ... </svg>'>

CSS
.bg {
  background: url('data:image/svg+xml;utf8,<svg ...> ... </svg>');
}
```

# NETWORK
- #### tracert / traceroute

Open up the Terminal (Mac), or Command Prompt (Windows) and run traceroute on any website you want. 
Keep in mind that on windows you will have to run tracert instead of traceroute

run:  tracert -4 google.com  //which forces IPv4 hops

![tracert](/Img/tracert.JPG)

- #### ping / telnet

```
ping <IP Address>
  
Telnet <IP Address> 13531
```
- #### [explain shell commad https://explainshell.com/](https://explainshell.com/)

# Communication Protocols
![communications-protocol](/Img/communications-protocol.png)

# SSH
![create ssh](/Img/ssh1.JPG)
- SourceTree
Tool --> Greate or import SSHkey --> generate key
--> user / .ssh folder save id_rsa.pub as public key
--> user / .ssh folder save id_rsa  as private key
--> copy the public key set the SSH Public Keys
- HTTPS vs SSH
>The “S,” then, provides an additional protocol for security; in fact HTTPS actually stands for HTTP over SSL (Secure Socket Layer). The most basic understanding of SSH (Secure Shell) is that you are remotely logging into another computer.
- SSL vs SSH
>SSL & SSH, both are public key cryptography tunneling protocols and aims to secure confidential data. SSL Secure Socket Layer is a certificate for protecting data on the net, SSH, Secure Shell, is a network application used to transfer or share data with a remote computer.
```
SSH {user}@{host}
```
- Windows:
```
Use PuTTY: https://mediatemple.net/community/products/dv/204404604/using-ssh-in-putty-
Windows 10: https://www.howtogeek.com/336775/how-to-enable-and-use-windows-10s-built-in-ssh-commands/
Extra: 
1. https://www.ssh.com/ssh/putty/windows/
2. https://www.memset.com/docs/server-security/secure-communication-ssh/using-ssh-windows/
```
- Linux:
```
You should be able to use the ssh  command already, but in case you can't:
https://www.makeuseof.com/tag/beginners-guide-setting-ssh-linux-testing-setup/
```
- Symmetric vs. Asymmetric
>Symmetric vs. Asymmetric Systems. Recall that there are two basic types of encryption: symmetric algorithms: (also called “secret key”) use the same key for both encryption and decryption; asymmetric algorithms: (also called “public key”) use different keys for encryption and decryption.
 
1. [Asymmetric Encryption](https://www.youtube.com/watch?v=NmM9HA2MQGI)
2. [Asymmetric Encryption](https://www.youtube.com/watch?v=Yjrfm_oRO0w)
3. [Asymmetric Encryption](https://www.youtube.com/watch?v=vsXMMT2CqqE&t=)
4. [Asymmetric Encryption](https://www.youtube.com/watch?v=NF1pwjL9-DE)
 
 - [Setup-ssh-for-github https://github.com/antonykidis/Setup-ssh-for-github/blob/master/Setup-ssh-on-github.pdf](https://github.com/antonykidis/Setup-ssh-for-github/blob/master/Setup-ssh-on-github.pdf)

# Devices Matrics 
https://material.io/tools/devices/

# JADE
# Angular Testing
# User Agent 
- Change the Browser User Agent in Chrome, Safari, & Firefox
http://osxdaily.com/2013/01/16/change-user-agent-chrome-safari-firefox/
- What is difference between Axios and Fetch?
https://stackoverflow.com/questions/40844297/what-is-difference-between-axios-and-fetch
