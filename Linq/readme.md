# LINQ
- http://csharp-video-tutorials.blogspot.com/2014/07/linq-tutorial.html
- https://vslapp.files.wordpress.com/2011/11/linq-cheatsheet.pdf

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
- ```OrderBy``` or ```OrderByDescending``` work fine when we want to sort a collection just ```by one value``` or expression. 

- If want to ```sort by more than one value``` or expression, that's when we use ```ThenBy``` or ```ThenByDescending``` along with OrderBy or OrderByDescending.

- ```OrderBy``` or ```OrderByDescending``` performs the ```primary sort```. 
- ```ThenBy``` or ```ThenByDescending``` is used for ```adding secondary sort```. 
- Secondary Sort operators (ThenBy or ThenByDescending ) can be used more than once in the same LINQ query.
```
// Example 1: 
// a) Sorts Students first by TotalMarks in ascending order(Primary Sort) 
// b) The 4 Students with TotalMarks of 800, 
will then be sorted by Name in ascending order (First Secondary Sort)
// c) The 2 Students with Name of John, 
will then be sorted by StudentID in ascending order (Second Secondary Sort)

IEnumerable<Student> result = Student.GetAllStudetns()
.OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenBy(s => s.StudentID);


IEnumerable<Student> result = from student in Student.GetAllStudetns()
                              orderby student.TotalMarks, student.Name, student.StudentID
                              select student;
                              
// Example 3: Reverses the items in the collection.
IEnumerable<Student> result = students.Reverse();
```
### Partitioning Operators
- Take method returns a specified number of elements from the start of the collection. The number of items to return is specified using the count parameter this method expects.
```
IEnumerable<string> result = countries.Take(3);

IEnumerable<string> result = (from country in countries
                           select country).Take(3);
                                                   
```
- Skip method skips a specified number of elements in a collection and then returns the remaining elements. The number of items to skip is specified using the count parameter this method expects. 
```
IEnumerable<string> result = countries.Skip(3);
```
- For the same argument value, the Skip method returns all of the items that the Take method would not return.
 
- TakeWhile method returns elements from a collection as long as the given condition specified by the predicate is true. 
```
IEnumerable<string> result = countries.TakeWhile(s => s.Length > 2);
```
- SkipWhile method skips elements in a collection as long as the given condition specified by the predicate is true, and then returns the remaining elements.
```
IEnumerable<string> result = countries.SkipWhile(s => s.Length > 2);
```
### Implementing paging using Skip and Take
- http://csharp-video-tutorials.blogspot.com/2014/07/part-13-implement-paging-using-skip-and.html
```
IEnumerable<Student> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize);
 ```
### Deferred execution vs Immediate execution
- http://csharp-video-tutorials.blogspot.com/2014/07/part-14-linq-query-deferred-execution.html
- LINQ operators can be broadly classified into 2 categories based on the behaviour of query execution
```
1. Deferred or Lazy Operators -  These query operators use deferred execution.
Examples - select, where, Take, Skip etc

2. Immediate or Greedy Operators - These query operators use immediate execution. 
Examples - count, average, min, max, ToList etc
```
- ```Deferred or Lazy Operators```, Examples - ```select```, ```where```, ```Take```, ```Skip``` etc
```
 // LINQ Query is only defined here and is not executed at this point
// If the query is executed at this point, the result should not display Tim
IEnumerable<Student> result = from student in listStudents
                              where student.TotalMarks == 800
                              select student;
                                          
```
- ```Immediate or Greedy Operators```, Examples - ```count```, ```average```, ```min```, ```max```, ```ToList``` etc
```
// Since we are using ToList() which is a greedy operator
// the LINQ Query is executed immediately at this point
IEnumerable<Student> result = (from student in listStudents
                               where student.TotalMarks == 800
                               select student).ToList();
```
### Conversion Operators in LINQ 
### ToList
```
List<int> result = numbers.ToList();
```
### ToArray
```
List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

string[] result = (from country in countries
                   orderby country ascending
                   select country).ToArray();
```
                              
- ToDictionary : Keys in the dictionary must be unique. 
```
Unhandled Exception: System.ArgumentException: An item with the same key has already been added.
```
```
Dictionary<int, string> result = listStudents.ToDictionary(x => x.StudentID, x => x.Name);

ToDictionary() that takes 2 parameters 
a) keySelector - A function to extract a key from each element
b) elementSelector - A function to produce a result element from each element in the

overloaded of ToDictionary() that takes 1 parameter
a) keySelector - A function to extract a key from each element

Dictionary<int, Student> result = listStudents.ToDictionary(x => x.StudentID);

```
### ToLookup
- Just like a dictionary, 
- a Lookup is a collection of key/value pairs. A dictionary cannot contain keys with identical values, where as a Lookup can.

```
// Group employees by JobTitle
var employeesByJobTitle = listEmployees.ToLookup(x => x.JobTitle);

Console.WriteLine("Employees Grouped By JobTitle");
foreach (var kvp in employeesByJobTitle)
{
    Console.WriteLine(kvp.Key);
    // Lookup employees by JobTitle
    foreach (var item in employeesByJobTitle[kvp.Key])
    {
        Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
    }
}

```
### Cast 
- attempts to convert all of the items within an existing collection to another type and return them in a new collection.
```
ArrayList list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add(3);

// The following item causes an exception
// list.Add("ABC");
            
IEnumerable<int> result = list.Cast<int>();
```
### OfType
- return only elements of the specified type. The other type elements are simply ignored and excluded from the result set.
```
ArrayList list = new ArrayList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add("4");
list.Add("ABC");

IEnumerable<int> result = list.OfType<int>();
```
### When to use Cast over OfType and vice versa?
- We would generally use Cast when the following 2 conditions are met
```
- 1. We want to cast all the items in the collection &
- 2. We know for sure the collection contains only elements of the specified type
```
- If we want to filter the elements and return only the ones of the specified type, then we would use OfType.

### AsQueryable : 
- There are 2 overloaded versions of this method. 
```
One overloaded version converts System.Collections.IEnumerable to System.Linq.IQueryable

The other overloaded version converts a generic System.Collections.Generic.IEnumerable<T> 
to a generic System.Linq.IQueryable<T>
```
- The main use of AsQueryable operator is unit testing to mock a queryable data source using an in-memory data source. 

###  AsEnumerable 
- use AsEnumerable operator to move query processing to the client side
```
1. The "inside part" that is the query before AsEnumerable operator is executed as Linq-to-SQL
2. The "ouside part" that is the query after AsEnumerable operator is executed as Linq-to-Objects
```
- http://csharp-video-tutorials.blogspot.com/2014/07/part-17-asenumerable-and-asqueryable-in.html
```
var result = dbContext.Employees.AsEnumerable()
                      .Where(x => x.Gender == "Male")
                      .OrderByDescending(x => x.Salary).Take(5);
```
### GroupBy
- GroupBy creates and returns a sequence of IGrouping<K,V>
- This operator takes a flat sequence of items, organize that sequence into groups (IGrouping<K,V>) based on a specific key and return groups of sequences. 
```
var employeeGroup = from employee in Employee.GetAllEmployees()
                    group employee by employee.Department;

foreach (var group in employeeGroup)
{
    Console.WriteLine("{0} - {1}", group.Key, group.Count());
}
```
```
var employeeGroup = from employee in Employee.GetAllEmployees()
                  group employee by employee.Department into eGroup
                  orderby eGroup.Key
                  select new
                  {
                       Key = eGroup.Key,
                       Employees = eGroup.OrderBy(x => x.Name)
                  };
```                                     
### Group by multiple keys
```
var employeeGroups = Employee.GetAllEmployees()
                .GroupBy(x => new { x.Department, x.Gender })
                .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                .Select(g => new
                {
                    Dept = g.Key.Department,
                    Gender = g.Key.Gender,
                    Employees = g.OrderBy(x => x.Name)
                });
```
```
var employeeGroups = from employee in Employee.GetAllEmployees()
                    group employee by new
                    {
                         employee.Department,
                         employee.Gender
                    } into eGroup
                    orderby eGroup.Key.Department ascending, 
                                  eGroup.Key.Gender ascending
                    select new
                    {
                         Dept = eGroup.Key.Department,
                         Gender = eGroup.Key.Gender,
                         Employees = eGroup.OrderBy(x => x.Name)
                    };
```
### Element Operators
### First
- If the sequence does not contain any elements or if no element in the sequence satisfies the condition then an InvalidOperationException is thrown.

### FirstOrDefault
- This is very similar to First, except that this method does ```not throw an exception```
```
int result = numbers.First();
int result = numbers.FirstOrDefault(x => x % 2 == 100);
```
### Last 
- Very similar to First, except it returns the last element of the sequence.
### LastOrDefault
- Very similar to FirstOrDefault, except it returns the last element of the sequence
### ElementAt 
- Returns an element at a specified index. 
- If the sequence is empty or if the provided index value is out of range, then an ArgumentOutOfRangeException is thrown.
### ElementAtOrDefault
- Similar to ElementAt except that this method does not throw an exception, 
- if the sequence is empty or if the provided index value is out of range. Instead, a default value of the type that is expected is returned.
```
int result = numbers.ElementAt(0);
```
### Single
- Single() method throws an exception if the sequence is empty or has more than one element.
### SingleOrDefault
- Very similar to Single(), except this method does not throw an exception when the sequence is empty or when no element in the sequence satisfies the given condition.
```
int result = numbers.Single();
int result = numbers.SingleOrDefault(x => x % 2 == 0);
```
### DefaultIfEmpty
- If the sequence on which this method is called is not empty, then the values of the original sequence are returned.
```
IEnumerable<int> result = numbers.DefaultIfEmpty();
// Since the sequence is empty, a sequence containing the specified default value (10) is returned.
IEnumerable<int> result = numbers.DefaultIfEmpty(10);
```
### Group Join
- GroupBy creates and returns a sequence of IGrouping<K,V>
```
var employeeGroup = from employee in Employee.GetAllEmployees()
                    group employee by employee.Department;

Console.WriteLine("{0} - {1}", group.Key, group.Count());
```
```
foreach (var group in employeeGroup)
{
    Console.WriteLine("{0} - {1}", group.Key, group.Count());
    Console.WriteLine("----------");
    foreach (var employee in group)
    {
        Console.WriteLine(employee.Name + "\t" + employee.Department);
    }
    Console.WriteLine(); Console.WriteLine();
}
```
```
var employeeGroup = from employee in Employee.GetAllEmployees()
                  group employee by employee.Department into eGroup
                  orderby eGroup.Key
                  select new
                  {
                       Key = eGroup.Key,
                       Employees = eGroup.OrderBy(x => x.Name)
                  };

```
### Group by multiple keys in linq
```
var employeeGroups = Employee.GetAllEmployees()
                    .GroupBy(x => new { x.Department, x.Gender })
                    .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                    .Select(g => new
                    {
                        Dept = g.Key.Department,
                        Gender = g.Key.Gender,
                        Employees = g.OrderBy(x => x.Name)
                    });

foreach(var group in employeeGroups)
{
    Console.WriteLine("{0} department {1} employees count = {2}",
        group.Dept, group.Gender, group.Employees.Count());
    Console.WriteLine("--------------------------------------------");
    foreach (var employee in group.Employees)
    {
        Console.WriteLine(employee.Name + "\t" + employee.Gender
            + "\t" + employee.Department);
    }
    Console.WriteLine(); Console.WriteLine();
}
```
```
var employeeGroups = from employee in Employee.GetAllEmployees()
                    group employee by new
                    {
                         employee.Department,
                         employee.Gender
                    } into eGroup
                    orderby eGroup.Key.Department ascending, 
                                  eGroup.Key.Gender ascending
                    select new
                    {
                         Dept = eGroup.Key.Department,
                         Gender = eGroup.Key.Gender,
                         Employees = eGroup.OrderBy(x => x.Name)
                    };
 ```                                       
### Element Operators in LINQ

### First
- If the sequence does not contain any elements, then First() method throws an InvalidOperationException.
```
int result = numbers.First();
int result = numbers.First(x => x % 2 == 0);
```
### FirstOrDefault
- This is very similar to First, except that this method does not throw an exception when there are no elements in the sequence or when no element satisfies the condition specified by the predicate. Instead, a default value of the type that is expected is returned. For reference types the default is NULL and for value types the default depends on the actual type expected.
```
int result = numbers.FirstOrDefault(x => x % 2 == 100);
```
### Last 
- Very similar to First, except it returns the last element of the sequence
### LastOrDefault
- Very similar to FirstOrDefault, except it returns the last element of the sequence.

### ElementAt
- Returns an element at a specified index. If the sequence is empty or if the provided index value is out of range, then an ArgumentOutOfRangeException is thrown.
```
int result = numbers.ElementAt(1);
```
### ElementAtOrDefault
- Similar to ElementAt except that this method does not throw an exception, if the sequence is empty or if the provided index value is out of range. Instead, a default value of the type that is expected is returned.

### Single
- There are 2 overloaded versions of this method. The first overloaded version that does not have any parameters returns the only element of the sequence.
- Single() method throws an exception if the sequence is empty or has more than one element.
```
int result = numbers.Single();
```
- The second overloaded version of the Single() method is used to find the only element in a sequence that satisfies a given condition. 
### SingleOrDefault
- Very similar to Single(), except this method does not throw an exception when the sequence is empty or when no element in the sequence satisfies the given condition. Just like Single(), this method will still throw an exception, if more than one element in the sequence satisfies the given condition.
```
int result = numbers.SingleOrDefault(x => x % 2 == 0);
```
```
An exception will be thrown if any of the following is true
a) If the sequence does not contain any elements OR
b) If no element in the sequence satisfies the condition OR
c) If more than one element in the sequence satisfies the condition
```
### DefaultIfEmpty
- If the sequence on which this method is called is not empty, then the values of the original sequence are returned.
- If the sequence is empty, then DefaultIfEmpty() returns a sequence with the default value of the expected type.
- The other overloaded version with a parameter allows us to specify a default value.
```
IEnumerable<int> result = numbers.DefaultIfEmpty();
IEnumerable<int> result = numbers.DefaultIfEmpty(10);
```
### Group Join in LINQ
### Group Join
```
var employeesByDepartment = Department.GetAllDepartments()
                       .GroupJoin(Employee.GetAllEmployees(),
                         d => d.ID,
                         e => e.DepartmentID,
                         (department, employees) => new
                         {
                             Department = department,
                             Employees = employees
                         });

foreach (var department in employeesByDepartment)
{
    Console.WriteLine(department.Department.Name);
    foreach (var employee in department.Employees)
    {
        Console.WriteLine(" " + employee.Name);
    }
    Console.WriteLine();
}
```
```
var employeesByDepartment = from d in Department.GetAllDepartments()
                       join e in Employee.GetAllEmployees()
                       on d.ID equals e.DepartmentID into eGroup
                       select new
                       {
                          Department = d,
                          Employees = eGroup
                       };
 ```                                                      
### Inner Join
```
var result = Employee.GetAllEmployees().Join(Department.GetAllDepartments(),
            e => e.DepartmentID,
            d => d.ID, (employee, department) => new
            {
                EmployeeName = employee.Name,
                DepartmentName = department.Name
            });
foreach (var employee in result)
{
    Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
}
```
```
var result = from e in Employee.GetAllEmployees()
            join d in Department.GetAllDepartments()
            on e.DepartmentID equals d.ID
            select new
            {
                EmployeeName = e.Name,
                DepartmentName = d.Name
            };

foreach (var employee in result)
{
    Console.WriteLine(employee.EmployeeName + "\t" + employee.DepartmentName);
}
```
### Difference between group join and inner join in linq
- Join is similar to INNER JOIN in SQL and GroupJoin is similar to OUTER JOIN in SQL
- http://csharp-video-tutorials.blogspot.com/2014/08/part-23-difference-between-group-join.html
```
var result = from e in Employee.GetAllEmployees()
            join d in Department.GetAllDepartments()
            on e.DepartmentID equals d.ID
            select new { e, d };
            
var result = Employee.GetAllEmployees()
             .Join(Department.GetAllDepartments(),
              e => e.DepartmentID,
              d => d.ID, (employee, department) => new
              {
                   e = employee,
                   d = department
              });
                    
```
```
var result = from d in Department.GetAllDepartments()
            join e in Employee.GetAllEmployees()
            on d.ID equals e.DepartmentID into eGroup
            select new
            {
               Department = d,
               Employees = eGroup
            };
        
var result = Department.GetAllDepartments()
            .GroupJoin(Employee.GetAllEmployees(),
             d => d.ID,
             e => e.DepartmentID,
             (department, employees) => new
             {
                  Department = department,
                  Employees = employees
             });
                                         
```
### Left Outer Join
- To implement Left Outer Join, with extension method syntax we use the GroupJoin() method along with SelectMany() and DefaultIfEmpty() methods.
- LEFT OUTER JOIN all the matching elements + all the non matching elements from the left collection are included in the result set.
```
var result = from e in Employee.GetAllEmployees()
            join d in Department.GetAllDepartments()
            on e.DepartmentID equals d.ID into eGroup
            from d in eGroup.DefaultIfEmpty()
            select new
            {
                 EmployeeName = e.Name,
                 DepartmentName = d == null ? "No Department" : d.Name
            };
            
var result = Employee.GetAllEmployees()
        .GroupJoin(Department.GetAllDepartments(),
                e => e.DepartmentID,
                d => d.ID,
                (emp, depts) => new { emp, depts })
        .SelectMany(z => z.depts.DefaultIfEmpty(),
                (a, b) => new
                {
                        EmployeeName = a.emp.Name,
                        DepartmentName = b == null ? "No Department" : b.Name
                });
```                    
### Cross Join
- The on keyword that specfies the JOIN KEY is not required.
- Cross join produces a cartesian product i.e when we cross join two sequences, every element in the first collection is combined with every element in the second collection.
- To implement Cross Join using extension method syntax, we could either use SelectMany() method or Join() method
```
var result = from e in Employee.GetAllEmployees()
            from d in Department.GetAllDepartments()
            select new { e, d };

var result = from d in Department.GetAllDepartments()
            from e in Employee.GetAllEmployees()
            select new { e, d };

var result = Employee.GetAllEmployees()
            .SelectMany(e => Department.GetAllDepartments(), (e, d) => new { e, d });

var result = Employee.GetAllEmployees()
             .Join(Department.GetAllDepartments(),
                       e => true,
                       d => true,
                       (e, d) => new { e, d });

```
### Set operators in LINQ
### Distinct
- Notice that in the output we don't get unique employees. This is because, the default comparer is being used which will just check for object references being equal and not the individual property values.
```
var result = countries.Distinct();
var result = countries.Distinct(StringComparer.OrdinalIgnoreCase);
```
- Using the overloaded version of Distinct() method to which we can pass a custom class that implements IEqualityComparer
```
//  Create a custom class that implements IEqualityComparer<T> and implement Equals() and GetHashCode() methods

public class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee x, Employee y)
    {
        return x.ID == y.ID && x.Name == y.Name;
    }

    public int GetHashCode(Employee obj)
    {
        return obj.ID.GetHashCode() ^ obj.Name.GetHashCode();
    }
}
```
- http://csharp-video-tutorials.blogspot.com/2014/08/part-26-set-operators-in-linq.html
### Union
- Union combines two collections into one collection while removing the duplicate elements
```
int[] numbers1 = { 1, 2, 3, 4, 5 };
int[] numbers2 = { 1, 3, 6, 7, 8 };

var result = numbers1.Union(numbers2);
```
- When comparing elements, just like Distinct() method, Union(), Intersect() and Except() methods work in a slightly different manner with complex types like Employee, Customer etc. 

### Intersect
- Intersect() returns the common elements between the 2 collections.
```
var result = numbers1.Intersect(numbers2);
```
### Except
- Except() returns the elements that are present in the first collection but not in the second collection.
```
var result = numbers1.Except(numbers2);
```
### Generation Operators in LINQ

### Range
- Range operator generates a sequence of integers within a specified range. This method has 2 integer parameters. The start parameter specifies the integer to start with and the count parameter specifies the number of sequential integers to generate.
```
var evenNumbers = Enumerable.Range(1, 10).Where(x => x % 2 == 0);
```
### Repeat
- Repeat operator is used to generate a sequence that contains one repeated value.
```
var result = Enumerable.Repeat("Hello", 5);
```
### Empty
- Empty operator returns an empty sequence of the specified type.
```
Enumerable.Empty<int>() // Returns an empty IEnumerable<int>
Enumerable.Empty<string>() // Returns an empty IEnumerable<string>
```
- ```NULL-COALESCING operator```
```
IEnumerable<int> result = GetIntegerSequence() ?? Enumerable.Empty<int>();
```
### Concat vs Union operators
-  concatenate both the integer sequences (numbers1 & numbers2) into one integer sequence. Notice that the duplicate elements ARE ```NOT REMOVED.```
- union operator also combines the 2 integer sequences (numbers1 & numbers2) into one integer sequence, but notice that the duplicate elements ARE ```REMOVED.```

```
int[] numbers1 = { 1, 2, 3 };
int[] numbers2 = { 1, 4, 5 };

var result = numbers1.Concat(numbers2);
var result = numbers1.Union(numbers2);
```
### SequenceEqual() 
- SequenceEqual method is used to determine whether two sequences are equal. 
- This method returns true if the sequences are equal otherwise false. 
- default comparison is ```case sensitive.```
- return false : the data is not present in the same ```order```
```
string[] countries1 = { "USA", "India", "UK" };
string[] countries2 = { "USA", "India", "UK" };

var result = countries1.SequenceEqual(countries2);
```
- ```case-insensitive```
```
var result = countries1.SequenceEqual(countries2, StringComparer.OrdinalIgnoreCase);
var result = countries1.OrderBy(c => c).SequenceEqual(countries2.OrderBy(c => c));
```
- When comparing ```complex types``` (reference type), the default comparer will only check if the object references are equal. So, in this case SequenceEqual() returns false.
```
To solve the problem in Example 6, there are 3 ways
    1. Use the other overloaded version of SequenceEqual() method 
        to which we can pass a custom class that implements IEqualityComparer
    2. Override Equals() and GetHashCode() methods in Employee class
    3. Project the properties into a new anonymous type, which overrides Equals() 
        and GetHashCode() methods
```
### Quantifiers
### All
- All() method returns true if all the elements in a sequence satisfy a given condition, otherwise false.
```
var result = numbers.All(x => x < 10);
```
### Any
- There are 2 overloaded versions of Any() method. 
- The version without any parameters checks if the sequence contains at least one element. 
- The other version with a predicate parameter checks if the sequence contains at least one element that satisfies a given condition.
```
int[] numbers = { 1, 2, 3, 4, 5 };

var result = numbers.Any();
var result = numbers.Any(x => x > 10);
```
### Contains
- There are 2 overloaded versions of the Contains() method. 
- One of the overloaded version checks if the sequence contains a specified element using the default equality comparer. 
- The other overloaded version checks if the sequence contains a specified element using an alternate equality comparer.
```
int[] numbers = { 1, 2, 3, 4, 5 };
var result = numbers.Contains(3);

string[] countries = { "USA", "INDIA", "UK" };
var result = countries.Contains("india", StringComparer.OrdinalIgnoreCase);
```
- When comparing complex types like Employee, Customer etc, the default comparer will only check if the object references are equal, and not the individual property values of the objects that are being compared.
```
To solve the problem in Example 6, there are 3 ways
1. Use the other overloaded version of Contains() method 
    to which we can pass a custom class that implements IEqualityComparer
2. Override Equals() and GetHashCode() methods in Employee class
3. Project the properties into a new anonymous type, 
    which overrides Equals() and GetHashCode() methods
```












