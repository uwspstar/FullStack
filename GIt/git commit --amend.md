# git commit --amend

- `git commit --amend` to modify 上一次的commit message的描述有误

- Steps

```bash
`git log -n 2` 
`git commit --amend`
键入：`i`，此时进入了输入模式
修改
`Esc` 键退出编辑模式
键入 `:wq` 回车退出并保存修改
```
