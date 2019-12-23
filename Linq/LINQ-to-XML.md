# LINQ to XML
- http://csharp-video-tutorials.blogspot.com/2014/08/linq-to-xml-tutorial.html

### Functional Construction?
- As far as LINQ to XML is concerned there is a technical term called Functional Construction
- ```Functional construction``` is the ability to create an XML tree in a single statement.
- http://csharp-video-tutorials.blogspot.com/2014/08/part-1-linq-to-xml.html
### XML document are present in System.Xml.Linq namespace
### XML Document use XDocument class
### XML Declaration use XDeclaration class
```
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
```
### XML Comment use XComment class
```
<!--Creating an XML Tree using LINQ to XML-->
```
### XML Element use XElement class
```
<TotalMarks>800</TotalMarks>
```
### XML Attribute use XAttribute class
```
<Student Id="102">  //id
```
### Demo
```
using System.Xml.Linq;

namespace Demo
{
    class Program
    {
        public static void Main()
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("Creating an XML Tree using LINQ to XML"),

                new XElement("Students",

                    new XElement("Student", new XAttribute("Id", 101),
                        new XElement("Name", "Mark"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 800)),

                    new XElement("Student", new XAttribute("Id", 102),
                        new XElement("Name", "Rosy"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", 900)),

                    new XElement("Student", new XAttribute("Id", 103),
                        new XElement("Name", "Pam"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", 850)),

                    new XElement("Student", new XAttribute("Id", 104),
                        new XElement("Name", "John"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 950))));

            xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
        }
    }
}
```
### Creating an XML document using in-memory collection of objects
- http://csharp-video-tutorials.blogspot.com/2014/08/part-2-creating-xml-document-using-in.html
- Once the data is retrieved from the database, the application may store the data in in-memory data structures like arrays, list, queue etc.
```
public static void Main()
{
    XDocument xmlDocument = new XDocument(
        new XDeclaration("1.0", "utf-8", "yes"),

        new XComment("Creating an XML Tree using LINQ to XML"),

        new XElement("Students",

            from student in Student.GetAllStudents()
            select new XElement("Student", new XAttribute("Id", student.Id),
                        new XElement("Name", student.Name),
                        new XElement("Gender", student.Gender),
                        new XElement("TotalMarks", student.TotalMarks))
                    ));

    xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
}
```        
### Querying xml document
```
IEnumerable<string> names = from student in XDocument
               .Load(@"C:\Demo\Demo\Data.xml")
               .Descendants("Student")
              where (int)student.Element("TotalMarks") > 800
              orderby (int)student.Element("TotalMarks") descending
              select student.Element("Name").Value;

foreach (string name in names)
{
    Console.WriteLine(name);
}
```
```
IEnumerable<string> names = from student in XDocument
              .Load(@"C:\Demo\Demo\Data.xml")
              .Element("Students")
              .Elements("Student")
      where (int)student.Element("TotalMarks") > 800
      orderby (int)student.Element("TotalMarks") descending
      select student.Element("Name").Value;
```                                                     
