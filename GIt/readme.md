# Git

### Git vs Github
- Git is the most popular "version control system" - a tool to keep track of file changes over time. 
- GitHub is an online service that hosts git repositories for developers.

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







 
 
