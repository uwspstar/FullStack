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
