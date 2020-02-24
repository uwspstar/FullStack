### command line
- https://alligator.io/workflow/command-line-creating-files-directories/
- https://bencane.com/2013/05/13/removing-files-and-directories-with-rm-and-rmdir/

### Tool 
https://cmder.net/

### bash command in windows
- pwd : present working directory  ( C:\  = \c\ )
- dir = ls
- ls -l  
- cd
- ~  : current user root directory
```
// current working directory (C:\ =  \c\)
$ pwd

// dir = ls
// more detail of the list files
$ ls -l

// change directory
$ cd video

// back to current user root directory
$ cd ~

// with space using \space
λ cd my\ documents/

// back to 3 levels  ../ is one level
λ cd ../../../

//is commad valiad, is valid showing the location
λ which ls
/usr/bin/ls

// echo $PATH : show path on console
λ echo $PATH

// cat show file full content
λ cat index.html

// less show file with less content  enter "q" to quit
λ less index.html

// touch to create a new file
λ touch demo.txt

// mv change file name 
λ mv demo.txt demo1.txt

//Creating a Directory .vscode
λ mkdir newfolder
$ mkdir .vscode

// rmdir : remove directory
λ rmdir newfolder/
//rmdir: failed to remove 'newfolder/': Directory not empty

// rm command with the -r and -f options will recursively and by force delete everything you specify
// used with great caution.
// rm remove folder, -r : recursive, -f : force 
λ rm -r -f newfolder/
// = λ rm -rf newfolder/

// clear screen
λ clear

// exit : exit console
λ exit

// remove file .gitignore
$ rm .gitignore
$ rm -f .gitignore

//Creating File .gitignore
$ touch README.md

// To remove all files & subdirectories from a directory, use the below given command.
$ rm -rf directoryname

// create file .gitignore
//wirte text ".vscode/*" to .gitignore
$ echo ".vscode/*" > .gitignore
```
