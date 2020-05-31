# xunit
- https://www.youtube.com/watch?v=ub3P8c87cwk
- https://app.pluralsight.com/library/courses/dotnet-core-testing-code-xunit-dotnet-getting-started
- https://xunit.github.io/


### Creating the test project
- $ mkdir <your-project.Tests>
- $ cd <your-project.Tests>
- $ dotnet new xunit
- $ dotnet add referce <your-will-test-project.csproj>
- $ dotnet sln add <your-project.Tests>
- $ dotnet test

### xunit installation
- NuGet install xunit package
- NuGet install xunit.runner.visualstudio package



### dotnet add referce
- https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-reference
- https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-reference#examples

### dotnet add sln
- https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln#examples




### internal function
```
// AssemblyInfo.cs
[assembly: InternalsVisibleTo("GameEngine.Tests")]
internal int CalculateHealthIncrease()
{
  var rnd = new Random();
  return rnd.Next(1, 101);
}
```
### Arrange, Act, Assert (AAA) 
### Fact & Theory
```
public class PlayerCharacterShould
{
  [Fact]
  public void IncreaseHealthAfterSleeping()
  {
    PlayerCharacter sut = new PlayerCharacter();
    sut.Sleep();
    Assert.InRange(sut.Health, 101, 200);
  }
  [Fact]
  public void AnotherTest() {...}
  [Theory]
  public void ADataDrivenTest() {...}
}
```
