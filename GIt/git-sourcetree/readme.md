# Source Tree

- git rebase using sourcetree <https://stackoverflow.com/questions/39928132/git-rebase-using-sourcetree>
- Using Visual Studio as diff/merge tool in Git and SourceTree <https://blog.dudak.me/2016/using-visual-studio-as-diffmerge-tool-in-sourcetree/>
- winmerge <https://community.atlassian.com/t5/Sourcetree-questions/Can-t-launch-external-merge-tool-WinMerge-on-Windows/qaq-p/315156>

```git
Tools->Options->Diff
    External Diff Tool: Custom
        Diff Command: C:\Program Files (x86)\WinMerge\WinMergeU.exe
        Arguments: $LOCAL $REMOTE
    External Merge Tool: Custom 
        Merge Command: C:\Program Files (x86)\WinMerge\WinMergeU.exe
        Arguments: /w1 $LOCAL $REMOTE $MERGED
```
