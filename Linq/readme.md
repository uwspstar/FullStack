# Linq
- http://csharp-video-tutorials.blogspot.com/2014/07/linq-tutorial.html

- LINQ stands for Language Integrated Query. LINQ enables us to query any type of data store (SQL Server, XML documents, Objects in memory etc).
- LINQ provider is a component between the LINQ query and the actual data source
```
GridView1.DataSource = from student in dataContext.Students
                       where student.Gender == "Male"
                       select student;
```
