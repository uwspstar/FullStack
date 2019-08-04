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
