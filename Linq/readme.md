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
Convert ChangeFirstLetterCase() method to an extension method t
string result = strName.ChangeFirstLetterCase();
```



