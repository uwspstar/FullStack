# Git Quick Start

## Create the branch on your local and switch to the new branch

```bash
# Before creating a new branch, pull the latest from master

$ git branch <master_branch_name>

$ git pull
```

## Push the branch on origin

```bash
git push origin <name_of_your_new_branch>
```

## see all hidden branches

```bash
git branch -a
```

## Add a new remote for your branch

```bash
git remote add [name_of_your_remote] [name_of_your_new_branch]
```

## Push changes from your commit into your branch

```bash
git push [name_of_your_new_remote] [url]
```

## Update your branch when the original branch updated

```bash
git fetch [name_of_your_remote]
```

## merge into current changes

```bash
git merge [name_of_your_merge_branch]
```

## Delete a branch on your local filesystem

```bash
$ git branch -d [name_of_your_new_branch]

# To force the deletion of local branch on your filesystem :
$ git branch -D [name_of_your_new_branch]
```

## Basic

- check version

```bash
git --version
```

- set config values

```bash
git config --global user.name "xing wang"
git config --global user.email "uwspstar@gmail.com"
git config --list
```

- need help

```bash
git help <verb>
git <verb> --help
```

- view remote repo

```bash
git remote -v
git branch -a
```

- init a repository

```bash
git init
```

- clone a remote repo

```bash
git clone <url> <where to clone>
git clone ../remote_repo.git .
git clone https://github.com/uwspstar/side-project.git .
```

- before first commit

```bash
git status
```

- Add gitignore file

```bash
touch .gitignore
```

- add files to staging

```bash
git add .
git status
```

- commit changes

```bash
git diff
git status
git add .
git commit -m "message"
```

- remove file from staging

```bash
git reset
git status
```

- push changes

```bash
git pull origin master
git push origin master
```

- log

```bash
git log
git reflog
```

- branch

```bash
git branch <mybranch>
git checkout <mybranch>
```

- push branch to remote

```bash
git push -u origin <mybranch>
git branch -a
```

- merge a branch

```bash
git checkout master
git pull origin master
git branch --merged
git merge <mybranch>
```

- delete a branch

```bash
git branch --merged
git branch -d <mybranch>
git branch -a
git push origin --delete <mybranch>
```

### Fixing Common Mistakes and Undoing Bad Commits

- Undo the file changes

```bash
git diff
git checkout <filename>
```

- Fix bad commit message before push to remote

```bash
git commit --amend -m “new commit message”
```

- Include the file in the last commit before push to remote

```bash
$ touch .gitignore
$ git add .gitignore
$ git commit
 
// without changes, type : and type wq save changes exit
:wq
```

- Move you commit to different branch

```bash
$ git log
$ git checkout  <branchname>
$ git cheery-pick <hash>
$ git log
# Cheery-pick does not delete the branch
```

- Git reset

```bash
$ git checkout master
$ git log
$ git reset --soft <hash>
# soft : keep the changes files in staging
 
$ git reset <hash>
# default, keep the file in working directory
 
$ git reset –hard <hash>
# remove the files from staging and working directory
 
$ git clean -df
# clean untracked files
 
$ git reflog
# show the work flow all the command

$ git checkout <hash>
# detached head

$ git branch <new_branchname>
```

- Really need to modify your changes which other people have pulled already

```bash
$ git revert <hash>
# not delete old, add new on the top

$ git diff <hash1> <hash2>
```

## git cherry pick

## git rebase

```bash
git log -n 2
git rebase -i  HEAD~2
```

## git use notepad++ as default open tool
