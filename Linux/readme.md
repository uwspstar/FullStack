# Linux
```
Mac OS X is a Unix OS and its command line is 99.9% the same as any Linux distribution. 
Both are using bash as default shell .
*** UNIX is to DOS as Linux is to Windows
```

- Terminals, Commands and Shells
https://www.udemy.com/linux-mastery/learn/lecture/8226844#overview

### $PATH 
- command name need to be on the shell's search PATH
```
How Shell knows what program you want to run ?
it search for that program on Shell's $PATH 
which is just a list of folders that contain these programs.
```
```
- echo $PATH
- which cal  // show where is cal to run
```
### command
- https://www.youtube.com/watch?v=j6vKLJxAKfw&list=PL-osiE80TeTvGhHkpvfmKWOiIPF8UVy6c
- https://www.commandlinux.com/
- command (case sensitive) --> options --> inputs
- commandName options inputs
- "-" short option "--" long name option 
```
- date -u
- date --univeral
- chain the command, -abcd same as -a -b -c -d
- cal -A 1 -B 1 // one month early, one month after
```

```
- pwd //Print Working Directory.
- ls
- ls -a
- ls -l
- cd // change directory
- one dot is current directory, two dots is parent directory
```
```
"control" + "option" + "T" -> open terminal
"control" + "D" -> close terminal
- echo hello
- cal
- cal -y
- cal 2019
- date
- clear
- "control" + "L"
- arrow key "up" and "down" for history
- history
- history -c; history -w;  // clear history and write the changes
- !1
- !2
```
### Linux Manual
- Using the Linux Manual
https://www.udemy.com/linux-mastery/learn/lecture/8264124#overview
- 8 Sections
```
Section 1: User Commands
Section 2: System Calls
Section 3: C Library Functions
Section 4: Devices and Special Files
Section 5: File Formats and Conventions
Section 6: Games
Section 7: Miscellanea
Section 8: System Administration tools and Daemons
```
- man -k  ```// serach manual``` 
- man ls  ```IF "man" not working, use "help", such as, "help cd"```
- help cd ```IF "help" not working, use "man", such as, "man ls"```
```
- man -k which
- which -a cal date echo
- man -l "list directory"  // including the "...word..."
- ls -l
- ls -lh // same as " - ls -l --human-readable"
```
- anything in [...] is option
- anything in <...> is mandatory
- anything with "|" is OR option

### VirtualBox
- Download VirtualBox on Mac
https://www.virtualbox.org/wiki/Downloads
```
*** Check this first ***
- Open up System Preferences
- Click on theSecurity & Privacy icon
- Make sure Allow apps downloaded from: App store and identified developers is checked 
(click "allow" )
```
### Ubuntu
- Install Ubuntu in Mac with Virtual Box
https://www.youtube.com/watch?v=4SbTXqPk_1Y
- "command" + "space" to find the virtualbox
- "app store" search "the unarchiver" and download it

### CentOS 7
- Download CentOS 7 – Gnome Desktop VDI – 
https://www.linuxtrainingacademy.com/vdi/
```
Login and Password Information for the Image:

Username: adminuser
Password: adminuser
Root Password: adminuser
```
- download CentOS
http://isoredirect.centos.org/centos/7/isos/x86_64/CentOS-7-x86_64-DVD-1810.iso

- Install windows 10/7 on mac using virtualbox
https://medium.com/oceanize-geeks/install-windows-10-7-on-mac-using-virtualbox-109be82b6037

### Download Windows 10 ISO
Download Windows 10 ISO from this link: https://www.microsoft.com/en-us/software-download/windows10ISO
