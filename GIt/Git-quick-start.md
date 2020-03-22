# Git Quick Start
### Create the branch on your local and switch to the new branch
```
Before creating a new branch, pull the lastest from master

$ git branch master

$ git pull
```
### Push the branch on origin
```
$ git push origin [name_of_your_new_branch]
```
### see all hidden branchs
```
$ git branch -a
```
### Add a new remote for your branch :
```
$ git remote add [name_of_your_remote] [name_of_your_new_branch]
```
### Push changes from your commit into your branch :
```
$ git push [name_of_your_new_remote] [url]
```
### Update your branch when the original branch updated :
```
$ git fetch [name_of_your_remote]
```
### merge into current changes
```
$ git merge [name_of_your_merge_branch]
```
### Delete a branch on your local filesystem :
```
$ git branch -d [name_of_your_new_branch]
To force the deletion of local branch on your filesystem :

$ git branch -D [name_of_your_new_branch]
```
### Basic
- check version
```
$ git --version
```
- set config values
```
$ git config --global user.name "xing wang"
$ git config --global user.email "uwspstar@gmail.com"
$ git config --list
```
- need help
```
$ git help <verb>
$ git <verb> --help
```
- view remote repo
```
$ git remote -v
$ git branch -a
```
- init a respository 
```
$ git init
```
- clone a remote repo
```
$ git clone <url> <where to clone>
$ git clone ../remote_repo.git .
$ git clone https://github.com/uwspstar/side-project.git .
```
- before first commit
```
$ git status
```

- Add gitignore file
```
$ touch .gitignore
```
- add files to staging
```
$ git add .
$ git status
```
- commit changes
```
$ git diff
$ git status
$ git add .
$ git commit -m "message"
```
- remove file from staging
```
$ git reset
$ git status
```
- push changes
```
$ git pull origin master
$ git push origin master
```
- log
```
$ git log
$ git reflog
```
- branch
```
$ git branch <mybranch>
$ git checkout <mybranch>
```
- push branch to remote
```
$ git push -u origin <mybranch>
$ git branch -a
```

- merge a branch
```
$ git checkout master
$ git pull origin master
$ git branch --merged
$ git merge <mybranch>
```
- delete a branch
```
$ git branch --merged
$ git branch -d <mybranch>
$ git branch -a
$ git push origin --delete <mybranch>
```
