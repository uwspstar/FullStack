### The multiple from clauses 
- The multiple from clauses  produce a ```SelectMany```, which creates a single sequence from combining each element in the first sequence with each element in the second sequence.
- in the query syntax 
```

var startingDeck = from s in Suits()
                   from r in Ranks()
                   select new { Suit = s, Rank = r };
             
foreach(var card in startingDeck)
{
    Console.WriteLine(card);
}
            
```
- The above query written in query syntax can be written in method syntax as:
```
var startingDeck2 = Suits()
                .SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));
```
```
static IEnumerable<string> Ranks()
{
    yield return "two"; yield return "three"; yield return "four"; 
    yield return "five"; yield return "six"; yield return "seven"; 
    yield return "eight"; yield return "nine"; yield return "ten"; 
    yield return "jack"; yield return "queen"; yield return "king";
    yield return "ace";
}

static IEnumerable<string> Suits()
{
    yield return "clubs"; 
    yield return "diamonds"; 
    yield return "hearts"; 
    yield return "spades";
}
```
