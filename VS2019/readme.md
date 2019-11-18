# VS2019

-  Ctrl+T to find anything in your solution
- https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio

### Visual Studio tips and tricks by Mads Kristensen
https://devblogs.microsoft.com/visualstudio/visual-studio-tips-and-tricks/ 



### Manage packages for the solution
- Managing packages for a solution is a convenient means to work with multiple projects simultaneously.
```
Select the Tools > NuGet Package Manager > Manage NuGet Packages for Solution... menu command, 
or right-click the solution and select Manage NuGet Packages...:
```
- Consolidate tab
```
Developers typically consider it bad practice to use different versions of the same NuGet package 
across different projects in the same solution. When you choose to manage packages for a solution, 
the Package Manager UI provides a Consolidate tab on which you can easily see 
where packages with distinct version numbers are used by different projects in the solution:
```
