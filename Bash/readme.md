# Bash 101

## Reference

- 3 Hour Bash Tutorial <https://linuxhint.com/3hr_bash_tutorial/>
- The Linux Command Handbook <https://www.freecodecamp.org/news/the-linux-commands-handbook/>
- curl 的用法指南<https://www.ruanyifeng.com/blog/2019/09/curl-reference.html>
- 《Linux就该这么学》 <https://www.linuxprobe.com/>
- <https://www.youtube.com/playlist?list=PLaMM3KFoB3JFtZctaR8HDaKQz9hqQQC92>

## Curl in Scripts

- <https://github.com/uwspstar/FullStack/blob/master/Bash/Curl-in-Scripts.md>

## Basic Commands

NO.     |Command                            |NOTEs
--------|-----------------------------------|--------------------------------------------------------------------------
1       |mkdir my_folder                    |to create a folder `my_folder`
2       |cd my_folder                       |navigate inside the folder `my_folder`
3       |touch hello.sh                     |to create a file hello.sh
5       |#! /bin/bash                       |add `#! /bin/bash` inside hello.sh on top
6       |chmod +x hello.sh                  |to make this script hello.sh file executable permission
7       |echo “hello world” > file.txt      |to capture the output from the shell to a file.txt
8       |cat > file.txt                     |to whatever you will write in this shell will be stored in the file.txt, come out of this process by pressing `CTRL+D`.
9       |cat >> file.txt                    |to capture the output from the shell and append to file.txt
10      |# this is comment                  |to comment single line with `#`
11      |:' this is comment'                |to comment multiple lines with `:'comments lines'`
12      |test.sh Untitled\ Document\ 1      |treat as one input `Untitled Document 1`
13      |test.sh Untitled Document 1        |treat as 3 input `Untitled` , `Document`,  `1`
14      |ls -al 1>file1.txt 2>file2.txt     |`1` represents the standard output and `2` represents the standard error
15      |c=$st1$st2                         |Concatenation, `echo $c`
16      |${st1^}                            |lowercase, `echo ${st1^}`
17      |${st2^^}                           |uppercase, `echo ${st2^^}`
18      |${st1^l}                           |for capitalizing the first letter, `echo ${st1^l}`
19      |$((  n1 + n2 ))                    |plus
20      |car=('BMW' 'TOYOTA' 'HONDA')       |array

## Debugging Bash Scripts

- put the `-x` flag

```bash
bash -x ./test.sh
```

```bash
#! /bin/bash -x
echo "enter filename to substitute using sed"
read fileName
if [[ -f $fileName ]]
then
     sed 's/Linux/Unix/g' $fileName
   
else
    echo "$fileName doesn't exist"
fi
```

- Write down the command `set -x` at the starting point of the debugging and for ending it simply write `set +x`.

```bash
#! /bin/bash
set -x
echo "enter filename to substitute using sed"
read fileName
set +x
if [[ -f $fileName ]]
then
     sed 's/Linux/Unix/g' $fileName
   
else
    echo "$fileName doesn't exist"
fi
```

## Conditional Statements

```bash
#! /bin/bash

count=10
if [ $count -eq 10 ]
then
    echo "the condition is true"
fi
```

```bash
#! /bin/bash

count=10
if [ $count -eq 9 ]
then
    echo "the condition is true"
 else
    echo "the condition is false"
fi
```

```bash
#! /bin/bash

count=10
if (( $count > 9 ))
then
    echo "the condition is true"
 else
    echo "the condition is false"
fi
```

```bash
#! /bin/bash

count=10
if (( $count > 9 ))
 then
    echo "the first condition is true"
 elif (( $count <= 9 ))
 then
    echo "then second condition is true"
 else
    echo "the condition is false"
fi
```

- make sure to have space after `[` and before `]`
- `if [ $count -eq 10 ]` is a condition that checks whether the value of the count variable is equals to 10 or not.

```bash
#! /bin/bash

age=10
if [ "$age" -gt 18 ] && [ "$age" -lt 40 ]
then
    echo "age is correct"
else
    echo "age is not correct"
fi
```

```bash
#! /bin/bash

age=30
if [ "$age" -gt 18 -o "$age" -lt 40 ]
then
    echo "age is correct"
else
    echo "age is not correct"
fi
```

## grep

```bash
#! /bin/bash
echo "enter a filename to search text from"
read fileName
if [[ -f $fileName ]]
then
    echo "enter the text to search"
    read grepvar
    grep $grepvar $fileName
else
    echo "$fileName doesn't exist"
fi
```

- `-i` not case sensitive
- `-n` line number
- `-c` words count
- `-v` without the words

```bash
grep -i -n -c -v $grepvar $fileName
```

## Loops

- `while` loop

```bash
#! /bin/bash

number=1
while [ $number -lt 10 ]
do
    echo "$number"
    number=$(( number+1 ))
done
```

- `until` loop

```bash
#! /bin/bash

number=1
until [ $number -ge 10 ]
do
    echo "$number"
    number=$(( number+1 ))
done
```

- `for` loop

```bash
#! /bin/bash
 for (( i=0; i<5; i++ ))

 do
    echo $i
 done
 ```

## Break and continue statement

```bash
#! /bin/bash

 for (( i=0; i<=10; i++ ))
 do
    if [ $i -gt 5 ]
    then
    break
    fi
    echo $i
 done
```

```bash
#! /bin/bash

 for (( i=0; i<=10; i++ ))
 do
    if [ $i -eq 3 ] || [  $i -eq 7 ]
    then
    continue
    fi
    echo $i
 done
 ```

## Script input (STDIN)

```bash
#! /bin/bash
 echo $1 $2 $3
 ```

- $1 $2 $3 is 3 script file parameters

```bash
#! /bin/bash
 echo $0 $1 $2 $3
 ```

- $0 will print the script name

```bash
#! /bin/bash

 args=("$@") #you can also specify the array size here
 # echo ${args[0]} ${args[1]} ${args[2]}
echo $@   #prints all the array elements
echo $#   #print the array size
 ```

- $@ unlimited input
- $# array size

## Reading file using stdin

```bash
#! /bin/bash

while read line
do
    echo "$line"   
done < "${1:-/dev/stdin}"
```

## Script output (STDOUT, STDERR)

- `ls -al 1>file1.txt 2>file2.txt`, 1 represents the standard output and 2 represents the standard error

```bash
#! /bin/bash

ls -al 1>file1.txt 2>file2.txt
```

- use a single file for storing standard output and standard output

```bash
#! /bin/bash

ls -al >file1.txt 2>&1
# ls -al >&file1.txt
```

## send output from one to another (pipe | )

```bash
#! /bin/bash

MESSAGE="Hello LinuxHint Audience"
export MESSAGE
./secondScript.sh
```

- This script will export the value stored in the `MESSAGE` variable which is essential “Hello LinuxHint Audience” to ‘secondScript.sh’.

```bash
#! /bin/bash

echo "the message from helloScript is: $MESSAGE"
```

```bash
chmod +x ./secondScript.sh
```

## Strings processing

```bash
#! /bin/bash
echo "enter Ist string"
read st1
echo "enter 2nd string"
read st2

if [ "$st1" == "$st2" ]
then
    echo "strings match"
else
    echo "strings don't match"
fi

if [ "$st1" \ "$st2" ]
then
    echo "Second string $st2 is smaller than $st1"
else
    echo "strings are equal"   
fi

c=$st1$st2 #Concatenation
echo $c

echo ${st1^} #for lowercase
echo ${st2^^} #for uppercase
echo ${st1^l} #for capitalizing the first letter
```

## math

```bash
#! /bin/bash
n1=20
n2=4

echo $(( n1 + n2 ))
echo $(( n1 - n2 ))
echo $(( n1 * n2 ))
echo $(( n1 / n2 ))
echo $(( n1 % n2 ))
```

## Converting hexadecimal into decimal

```bash
#! /bin/bash

echo "Enter Hex number of your choice"
read Hex
echo -n "The decimal value of $Hex is : "
echo "obase=10; ibase=16; $Hex" | bc
```

## Declare (read only) command

```bash
#! /bin/bash
declare -r pwdfile=/etc/passwd
echo $pwdfile
```

## Arrays

```bash
#! /bin/bash
#! /bin/bash
car=('BMW' 'TOYOTA' 'HONDA')
echo "${car[@]}"
echo "printing value using index"
echo "${car[0]}"
echo "${car[1]}"
echo "${car[2]}"
echo "printing the indexes"
echo "${!car[@]}"
echo "printing number of values"
echo "${#car[@]}"
```

```bash
#! /bin/bash
car=('BMW' 'TOYOTA' 'HONDA' 'ROVER')
unset car[2] # delete an array element
car[2]='MERCEDES' # store any other value
echo "${car[@]}"
echo "printing  the indexes"
echo "${!car[@]}"
echo "printing number of values"
echo "${#car[@]}"
```

## function

```bash
#! /bin/bash
function funcPrint()
{
    echo $1 $2 $3 $4
}
funcPrint Hi This is func
```

## Files and Directories

- create files and directories

```bash
#! /bin/bash
mkdir -p Directory2
```

- how to check the existence of these files and directories using a scrip

```bash
#! /bin/bash

echo "enter directory name to check"
read direct

if [ -d "$direct" ]
then
    echo "$direct exists"
else
    echo "$direct doesn't exist"
fi


echo "enter file name to check"
read fileName

if [ -f "$fileName" ]
then
    echo "$fileName exists"
else
    echo "$fileName doesn't exist"
fi

```

- reading text from the files line by line and append text in the files and last thing

```bash
#! /bin/bash

echo "enter file name in which you want to append text"
read fileName

if [ -f "$fileName" ]
then
    echo "enter the text you want to append"
    read fileText
    echo "$fileText" >> $fileName
else
    echo "$fileName doesn't exist"
fi

echo "enter file name from which you want to read"
read fileName

if [ -f "$fileName" ]
then
    while IFS= read -r line
    do
        echo "$line"
    done < $fileName
else
    echo "$fileName doesn't exist"
fi

```

- how to delete a file

```bash
echo "enter file name from which you want to delete"
read fileName

if [ -f "$fileName" ]
then
    rm $fileName
else
    echo "$fileName doesn't exist"
fi
```

## Sending email via script

- install ssmtp

```bash
sudo apt install ssmtp
```

- edit the configuration file

```bash
$ gedit /etc/ssmtp/ssmtp.conf
# or $ sudo -H gedit /etc/ssmtp/ssmtp.conf
```

- inside config file

```text
root=test@gmail.com
mailhub=smtp.gmail.com:587
AuthUser=test@gmail.com
AuthPass= (here you can give the password of your email)
UseSTARTTLS=yes
```

- create a script

```bash
#! /bin/bash
ssmtp test@gmail.com
```

- sent email

```bash
$ ./helloScript.sh
To:test@gmail.com
From:test@gmail.com
Cc:test@gmail.com
Subject:test@gmail.com
This is body
```

## Professional Menus

```bash
#! /bin/bash
select car in BMW MERCEDES TESLA ROVER TOYOTA
do
    case $car in
    BMW)
    echo "BMW SELECTED";;
    MERCEDES)
    echo "MERCEDES SELECTED";;
    TESLA)
    echo "TESLA SELECTED";;
    ROVER)
    echo "ROVER SELECTED";;
    TOYOTA)
    echo "TOYOTA SELECTED";;
    *)
    echo "ERROR! Please select between 1 to 5";;
    esac
done
```

```bash
#! /bin/bash
echo "press any key to continue"
while [ true ]
do
    read -t 3 -n 1
if [ $? = 0 ]
then
    echo "you have terminated the script"
    exit;
else
    echo "waiting for you to press the key Sir"
fi
done
```

## Wait for filesystem using inotify

- inotify is a Linux kernel subsystem that acts to extend filesystems to notice changes to the filesystem and report those changes to applications.

```bash
sudo apt install inotify-tools
```

```bash
#! /bin/bash
mkdir -p temp/NewFolder
inotifywait -m temp/NewFolder
```

## sed

- The sed command stands for stream editor, performs editing operations on text coming from standard input or a file. sed edits line-by-line and in a non-interactive way.

```bash
#! /bin/bash
echo "enter filename to substitute using sed"
read fileName
if [[ -f $fileName ]]
then
    cat test.txt | sed 's/i/I/'
   
else
    echo "$fileName doesn't exist"
fi
```

```bash
#! /bin/bash
echo "enter filename to substitute using sed"
read fileName
if [[ -f $fileName ]]
then
     sed 's/Linux/Unix/g' $fileName
   
else
    echo "$fileName doesn't exist"
fi
```
