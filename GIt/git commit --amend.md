# git commit --amend

- <https://zhuanlan.zhihu.com/p/100243017>

- `git commit --amend` to modify 上一次的commit message的描述有误. 记录会被覆盖，但是commit id会变成新的. 本质上就是生成了新的commit，替代了上一次commit的位置 (only modify commit info, if you want to modify commit files changes, you can use  `git reset HEAD <file>`)

- `git commit --amend` Steps

```bash
`git log -n 2` 
`git commit --amend`
键入：`i`，此时进入了输入模式
修改
`Esc` 键退出编辑模式
键入 `:wq` 回车退出并保存修改
```
