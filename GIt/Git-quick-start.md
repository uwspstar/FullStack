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
