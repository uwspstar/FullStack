# git cherry-pick

- <https://www.ruanyifeng.com/blog/2020/04/git-cherry-pick.html>

- `git cherry-pick` 命令的作用，就是将指定的提交（commit）应用于其他分支。
- 如果操作过程中发生代码冲突，`Cherry pick` 会停下来，让用户决定如何继续操作

## `git cherry-pick <commitHash>`

```txt
master和feature两个分支, 将提交f应用到master分支

    a - b - c   <Master>
         \
          d -  e - f <Feature>
```

- Steps :

```bash
git checkout master
git cherry-pick f
```

- 上面的操作完成以后，代码库就变成 master分支的末尾增加了一个提交f。

```txt
    a - b - c - f   Master
         \
          d - e - f Feature
```

## git cherry-pick命令的参数，不一定是提交的哈希值，分支名也是可以的，表示转移该分支的最新提交

- 将feature分支的最近一次提交，转移到当前分支
`git cherry-pick feature`
