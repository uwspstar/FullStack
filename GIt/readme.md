# Git
- Understanding Git - Paolo Perrotta https://www.youtube.com/watch?v=nHkLxts9Mu4
- How Git Works By Paolo Perrotta https://app.pluralsight.com/library/courses/how-git-works/table-of-contents
- Git MERGE vs REBASE https://www.youtube.com/watch?v=CRlGDDprdOQ
- Introduction to Git cherry-pick https://www.youtube.com/watch?v=-ndmel-4wsk
- https://www.themoderncoder.com/a-better-git-workflow-with-rebase/ 
- https://www.youtube.com/watch?v=f1wnYdLEpgI
- https://www.youtube.com/watch?v=_OZVJpLHUaI&list=PL55RiY5tL51poFMpbva1IqfO-pylwSNsN
- Commamd tool for windows https://cmder.net/

- ```DO NOT REBASE COMMITS THAT EXISTS OUTSIDE YOUR REPO``` https://git-scm.com/book/en/v2/Git-Branching-Rebasing 
### Git object
- blob
- tree
- commit
- tag

### Git vs Github
- Git is the most popular "version control system" - a tool to keep track of file changes over time. 
- GitHub is an online service that hosts git repositories for developers.
### Git
- ```Repository``` :  the location where your code history is stored
- ```Branch``` "Folder" within the repository containing commits
- ```Commits``` Different stages of your code inside a branch
- ```download``` : https://git-scm.com/downloads
### Bash
- Shell Environment
- Command Line Interpreter
  - Default on most version of Linux & Mac OS
- Bourne Again Shell

### Git command
```
$ git init
```
- create git repo for the currect fold
```
$ git status
```
- check the current status
```
$ git add .
```
- add last file to stage
```
$ git add filename
```
- git add . means to add all files
 
```
$ git commit -m "another test"
```
- commit the change with the comment , ready for push
```
$ git log
```
- show the commit info , ```(HEAD -> master)``` means the latest change







### 5 steps by Scolt
http://python.slides.com/colt/web-scraping#/30

- 1a. Initialize a local repository on your computer
```$>git init```
- OR
- 1b. Clone (download) an online repository onto your computer
```$>git clone https://github.com/<your_github_handle>/<your_repo>.git```

- 2. Change (create, edit, move, remove) files on your computer
```$>echo "just putting text in this file" >> README.md```

- 3. Stage the files to be committed
```$>git add .```

- 4. Commit the files to a new version
```$>git commit -m "my first commit"```

- 5. Push changes to the online repository
```$>git push origin master```

- http://python.slides.com/colt/web-scraping#/31  by Scolt
```
- Initializing a Git Repository
Once git is installed, any directory on your computer can be turned into a repository 
by typing "git init" inside the folder.

Initialized empty Git repository in /Users/Colt/test/.git

$> git init 
This command creates a "hidden" .git folder in the directory 
which is where your versions are stored.
```
```
- Staging Files
One you have created some files in your repository, 
you can add them to the stage by typing "git add" 
followed by the filename or parent directory of the files to add all of them.
$> git add

Staging a file takes a snapshot of it at a point in time, 
which will prepare it for a new commit (the next version of the repo).
```

```
- Committing
Use the command "git commit" to save a new version of the repository. Use the "-m" (message) argument followed by a short description to explain the new version.
$> git commit -m "added monty python"

The new commit stores the snapshot in the .git folder. 
Every commit gets indexed with an auto-generated unique hash so git can find it easily later.
```

```
- Remotes
So far, all of the changes we're making are affecting our local .git folder only. 
Our changes are thus only on our machine.
We can add a remote origin by making a GitHub repository and typing the command "git remote add origin" like so:

$>git remote add origin https://github.com/<your_github_handle>/<your_repo_name>.git
Pushing
```

```
- Pushing

After you've set up a remote origin, use the command "git push" 
to publish your changes to your online GitHub repository.
$>git push

Pushing synchronizes the local and remote repositories. 
Sometimes you will have to "git pull" first to bring your local repo up-to-date before pushing.
$>git pull
```







 
 
