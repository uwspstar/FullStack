# xunit
- https://www.youtube.com/watch?v=ub3P8c87cwk
- https://app.pluralsight.com/library/courses/dotnet-core-testing-code-xunit-dotnet-getting-started

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
