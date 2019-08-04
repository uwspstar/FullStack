# git ssh & sourcetree
- $> ssh-keygen -t rsa -b 4096 -C "uwspstar@gmail.com"
```Generating public/private rsa key pair.```
- Enter file in which to save the key (/Users/xingwang/.ssh/id_rsa): 
```just enter, use default```
- Enter passphrase (empty for no passphrase): ```just enter, use default```
- Enter same passphrase again: 
```just enter, use default```

- windows
```
Your identification has been saved in /Users/xingwang/.ssh/id_rsa.
Your public key has been saved in /Users/xingwang/.ssh/id_rsa.pub.
```
- $> pbcopy < ~/.ssh/id_rsa.pub
```
copy the pub key to github 
```
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
