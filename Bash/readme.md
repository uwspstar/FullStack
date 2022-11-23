# Bash 101

## Reference

- The Linux Command Handbook <https://www.freecodecamp.org/news/the-linux-commands-handbook/>

- 3 Hour Bash Tutorial <https://linuxhint.com/3hr_bash_tutorial/>

- Shell 编程快速入门 <https://www.runoob.com/w3cnote/shell-quick-start.html>

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

## Loops
