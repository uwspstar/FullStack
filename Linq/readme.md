# Linq
- http://csharp-video-tutorials.blogspot.com/2014/07/linq-tutorial.html

- LINQ stands for Language Integrated Query. LINQ enables us to query any type of data store (SQL Server, XML documents, Objects in memory etc).
- LINQ provider is a component between the LINQ query and the actual data source
```
//LINQ query using Lambda Expressions.
IEnumerable<Student> students = Student.GetAllStudents()
    .Where(student => student.Gender == "Male");

//LINQ query using using SQL like query expressions
IEnumerable<Student> students = from student in Student.GetAllStudents()
                                where student.Gender == "Male"
                                select student;
```
### Using Lambda Expressions.

### Using SQL like query expressions
- LINQ queries written using SQL like query expressions are translated into their lambda expressions before they are compiled. 
- The Standard Query Operators are implemented as ```extension``` methods on ```IEnumerable<T> interface```.
```
GridView1.DataSource = from student in dataContext.Students
                       where student.Gender == "Male"
                       select student;
```
- Since List<T> implements IEnumerable<T>, the LINQ Standard Query Operators will be available

### Extension methods 
- Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
- Extension methods are a special kind of ```static method```, but they are called as if they were instance methods on the extended type.
- LINQ's standard query operators (select, where etc ) are implemented in Enumerable class as extension methods on the IEnumerable<T> interface.
```
List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
IEnumerable<int> EvenNumbers = Numbers.Where(n => n % 2 == 0);
```
- Where() method not belonging to List<T> class, we are still able to use it as though it belong to List<T> class. 
- This is possible because Where() method is implemented as extension method in IEnumerable<T> interface and List<T> implements IEnumerable<T> interface

### How to implement extension methods
```
public class StringHelper
{
    public static string ChangeFirstLetterCase(string inputString)
    {
        return inputString;
    }

}

Instead we have to call it as shown below.
string result = StringHelper.ChangeFirstLetterCase(strName);

Convert ChangeFirstLetterCase() method to an extension method
string result = strName.ChangeFirstLetterCase();

To convert ChangeFirstLetterCase() method to an extension method, make the following 2 changes
1. Make StringHelper static class
2. The type the method extends should be passed as a first parameter with this keyword preceeding it.


public static class StringHelper
{
    public static string ChangeFirstLetterCase(this string inputString)
    {
        return inputString;
    }
}

```
- Since all LINQ extension methods are defined in Enumerable class, the syntax will be as shown below.
```
List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0); 
```

 
### LINQ Aggregate
```
int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int smallestNumber = Numbers.Min();
int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();
int largestNumber = Numbers.Max();
int largestEvenNumber = Numbers.Where(n => n % 2 == 0).Max();
int sumOfAllNumbers = Numbers.Sum();
int sumOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Sum();
int countOfAllNumbers = Numbers.Count();
int countOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Count();
double averageOfAllNumbers = Numbers.Average();
double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();

```
### How Aggregate() function works?
```
string[] countries = { "India", "US", "UK", "Canada", "Australia" };
string result = countries.Aggregate((a, b) => a + ", " + b);

Step 1. First "India" is concatenated with "US" to produce result "India, US"

Step 2. Result in Step 1 is then concatenated with "UK" to produce result "India, US, UK"

Step 3: Result in Step 2 is then concatenated with "Canada" to produce result "India, US, UK, Canada"

This goes on until the last element in the array 
to produce the final single string "India, US, UK, Canada, Australia"
```
- One of the overloaded version of Aggregate() function has a Seed parameter. 
```
If we pass 10 as the value for Seed parameter
int result = Numbers.Aggregate(10, (a, b) => a * b);

Step 1: Multiply (10X2) to produce result 20
Step 2: Result (20) in Step 1 is then multiplied with 3 (20X3) to produce result 60
Step 3: Result (60) in Step 2 is then multiplied with 4 (60X4) to produce result 240
Step 4: Result (240) in Step 3 is then multiplied with 5 (240X5) to produce final result 1200
```
### WHERE

- The WHERE standard query operator belong to Restriction Operators category in LINQ.
- 2 overloaded versions of WHERE extension method in Enumerable class

```
public static IEnumerable<TSource> Where<TSource>(
    this IEnumerable<TSource> source,
    Func<TSource, bool> predicate);

public static IEnumerable<TSource> Where<TSource>(
    this IEnumerable<TSource> source,
    Func<TSource, int, bool> predicate);

```

### Predicate?

- A predicate is a function to test each element for a condition
```
IEnumerable<int> evenNumbers = numbers.Where(num => num % 2 == 0);

can be rewritten as shown below

Func<int, bool> predicate = i => i % 2 == 0;
IEnumerable<int> evenNumbers = numbers.Where(predicate);
```
 
### SelectMany
```
IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects);
IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects).Distinct();

IEnumerable<string> allSubjects = from student in Student.GetAllStudetns()
                                from subject in student.Subjects
                                select subject;
                  
IEnumerable<string> allSubjects = (from student in Student.GetAllStudetns()
                                 from subject in student.Subjects
                                 select subject)
                                 .Distinct();
```
```
var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) =>
    new { StudentName = student.Name, Subject = subject });

foreach (var v in result)
{
    Console.WriteLine(v.StudentName + " - " + v.Subject);
}


var result = from student in Student.GetAllStudetns()
                    from subject in student.Subjects
                    select new { StudnetName = student.Name, Subject = subject };

foreach (var v in result)
{
    Console.WriteLine(v.StudnetName + " - " + v.Subject);
}

```
### Select vs SelectMany 
- in this example, the Select() method returns List of List<string>
```
IEnumerable<List<string>> result = Student.GetAllStudetns().Select(s => s.Subjects);
foreach (List<string> stringList in result)
{
    foreach (string str in stringList)
    {
        Console.WriteLine(str);
    }
}
```
- SelectMany() on the other hand, flattens queries that return lists of lists into a single list. So in this case to print all the subjects we have to use just one foreach loop.
```
IEnumerable<string> result = Student.GetAllStudetns().SelectMany(s => s.Subjects);
foreach (string str in result)
{
    Console.WriteLine(str);
}
```
### OrderBy, OrderByDescending, ThenBy, and ThenByDescending
- OrderBy, OrderByDescending, ThenBy, and ThenByDescending can be used to sort data. Reverse method simply reverses the items in a given collection.    
```
// Example 1: Sort Students by Name in ascending order
IEnumerable<Student> result = Student.GetAllStudents().OrderBy(s => s.Name);

// Example 2: Rewrite Example 1 using SQL like syntax
IEnumerable<Student> result = from student in Student.GetAllStudents()
                              orderby student.Name
                              select student;

// Example 3: Sort Students by Name in descending order
IEnumerable<Student> result = Student.GetAllStudents().OrderByDescending(s => s.Name);

// Example 4: Rewrite Example 3 using SQL like syntax
IEnumerable<Student> result = from student in Student.GetAllStudents()
                              orderby student.Name descending
                              select student;
```
