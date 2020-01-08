# Deferred execution vs Immediate execution
- http://csharp-video-tutorials.blogspot.com/2014/07/part-14-linq-query-deferred-execution.html
- LINQ operators can be broadly classified into 2 categories based on the behaviour of query execution
### Deferred or Lazy Operators
-  These query operators use deferred execution.```Examples - select, where, Take, Skip etc```
### Immediate or Greedy Operators 
- These query operators use immediate execution. ```Examples - count, average, min, max, ToList etc```
```
// Deferred or Lazy Operators, Examples - select, where, Take, Skip etc
// LINQ Query is only defined here and is not executed at this point
// If the query is executed at this point, the result should not display Tim
IEnumerable<Student> result = from student in listStudents
                              where student.TotalMarks == 800
                              select student;
```
```
// Immediate or Greedy Operators, Examples - count, average, min, max, ToList etc
// Since we are using ToList() which is a greedy operator
// the LINQ Query is executed immediately at this point
IEnumerable<Student> result = (from student in listStudents
                               where student.TotalMarks == 800
                               select student).ToList();
```
