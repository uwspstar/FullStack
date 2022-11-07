# Linux
-- https://www.linuxprobe.com/basic-learning-00.html
```
Mac OS X is a Unix OS and its command line is 99.9% the same as any Linux distribution. 
Both are using bash as default shell .
*** UNIX is to DOS as Linux is to Windows
```
### basic
- *** the difference between an absolute file path and a relative file path? ***
```
  - An absolute file path starts at the root (/) folder 
  - A relative file path starts from the shell's current working directory
  - starts with a "." which means "the current folder".
```
- Navigate using these commands:
  - cd "change directory"
  - pwd "print working directory"
  - ls "list contents"
  - ls D* // open all D* folder
  - ls ?.txt // open file such as 1.txt a.txt, M.txt, etc , only match one
  - $> ls D?w* // math download foler D?w*
  - ls file[0123456789].txt // same as ls file[0-9].txt
  - ls file[A-Z].txt
  
- Remember these aliases:
  - / is root directory
  - ~ is home
  - . is current
  - .. is parent
- Manipulate files with:
  - "mkdir" create directories
  - "touch" create files
  - "mv" move and rename
  - "rm" to remove files, "-r" to remove directories

- absolute paths 
```
Files and directories have absolute paths based on the root, where each additional level down adds a " /".
The absolute path for "Xing" is:  /Users/Xing
```
- home directory
```
a special directory called "home", which is also known as "~". 
This is the default directory upon opening your terminal.
```
```
The dot "." stands for current directory, 
and dot-dot ".." stands for parent directory. 
This allows for relative navigation
```
- directory
```
- "mkdir" ("make directory") followed by the name of the new directory 
will create a new child directory inside the current directory.

- Removing Directories
Directories can also be deleted using the "rm" keyword, 
with the added option "-r" ("recursive"). 
You can also use "-f" ("force") to prevent warnings.

**** Warning: "rm -rf" is a dangerous command! 
Be extremely careful what folder you pass to it 
because you will never get it back ****
```
- file
```
$> file output.txt
```
```
- "touch" followed by the filename and file-type extension 
will create a new file of that type.

- renamed 
Files can be moved or renamed using the "mv" (" move") keyword, 
which takes two arguments: the source and the destination

- deleted
Files can be deleted using the "rm" ("remove") keyword.
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
### man & help
- man -k  ```// serach manual``` 
- man ls  ```// serach manual IF "man" not working, use "help", such as, "help cd"```
- help cd ```// serach manual IF "help" not working, use "man", such as, "man ls"```
```
- man -k which
- which -a cal date echo
- man -l "list directory"  // including the "...word..."
- ls -l
- ls -lh // same as " - ls -l --human-readable"
```
### cat 
- ( 0 is input, 1 is output, 2 is error)
- ">" is overwrite
- ">>" is append
```
$> cat 1>output.txt // cat > output.txt
$> cat 1>>output.txt // cat >> output.txt . // append text next line
$> cat -k bla 2>> error.txt
$> cat 1>> output.txt 2>> error.txt
$> cat > input.txt . // input from screen to input.txt
$> cat < input.txt  // dispay content to screen from input.txt
$> cat 0< input.txt 1>>output.txt 2>>error.txt
$> which open
$> open output.txt
$> rm output.txt

```
### cut
```
$> cut -f 2 -d " " output.txt
$> date | cut -f 4 -d " " 1>>output.txt
```
### tee
```
$> cal | tee -a output.txt | cut -f 2 -d " " 1>> output.txt
```
### xargs
```
$> date | xargs echo
$>date | xargs echo "hello Xing"  //hello Xing Sat Aug 17 18:06:57 CDT 2019
```
- anything in [...] is option
- anything in <...> is mandatory
- anything with "|" is OR option

- $> cat 1>output.txt
```
Every data stream not only has a name like standard outputs and imports on that 
but it also has a number associated with it.
- Standard Input is number zero
- Standard output is number one 
- Standard error is number two

```
### GREP
- global regular expression print by Srijan Kishore
https://www.howtoforge.com/tutorial/linux-grep-command/
```
grep 'word' filename
grep 'word' file1 file2 file3
grep 'string1 string2'  filename
cat otherfile | grep 'something'
command | grep 'something'
command option1 | grep 'data'
grep --color 'data' fileName
```
### command
- https://www.youtube.com/watch?v=j6vKLJxAKfw&list=PL-osiE80TeTvGhHkpvfmKWOiIPF8UVy6c
- https://www.commandlinux.com/
- command (case sensitive) --> options --> inputs
- commandName options inputs
- "-" short option "--" long name option 
```
$> date -u
$> date --univeral
- chain the command, -abcd same as -a -b -c -d
$> cal -A 1 -B 1 // one month early, one month after
```

```
$> pwd //Print Working Directory.
$> ls
$> ls -a
$> ls -l
$> cd  //-->change directory
$> cd /
$> cd . 
$> cd ..
- one dot is current directory, two dots is parent directory
```
```
"control" + "option" + "T" -> open terminal
"control" + "D" -> close terminal
$> echo hello
$> cal
$> cal -y
$> cal 2019
$> date
$> clear

```
### history
- $> history
```
- "control" + "L"
- arrow key "up" and "down" for history
$> history -c; history -w;  // clear history and write the changes
- !1
- !2
```
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
