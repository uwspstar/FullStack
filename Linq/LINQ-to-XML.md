# LINQ to XML
- http://csharp-video-tutorials.blogspot.com/2014/08/linq-to-xml-tutorial.html

### Functional Construction?
- As far as LINQ to XML is concerned there is a technical term called Functional Construction
- ```Functional construction``` is the ability to create an XML tree in a single statement.
- http://csharp-video-tutorials.blogspot.com/2014/08/part-1-linq-to-xml.html

### XML validation against XSD
- http://csharp-video-tutorials.blogspot.com/2014/09/part-8-xml-validation-against-xsd.html
- An ```XSD``` ( XML Schema Definition Language) file defines the structure of the XML file, i.e which elements in which order, how many times, with which attributes, how they are nested, etc. Without an XSD, an XML file is a relatively free set of elements and attributes. 
```
using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;

...
public static void Main()
{
    XmlSchemaSet schema = new XmlSchemaSet();
    schema.Add("", @"C:\Demo\Demo\Student.xsd");

    XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");
    bool validationErrors = false;

    xmlDocument.Validate(schema, (s, e) =>
    {
        Console.WriteLine(e.Message);
        validationErrors = true;
    });

    if (validationErrors)
    {
        Console.WriteLine("Validation failed");
    }
    else
    {
        Console.WriteLine("Validation succeeded");
    }
}

```
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
### Modifying xml document 
- http://csharp-video-tutorials.blogspot.com/2014/08/part-4-modifying-xml-document-using.html
### Inserting or Adding new xml elements to the xml document
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

xmlDocument.Element("Students").Add(
        new XElement("Student", new XAttribute("Id", 105),
            new XElement("Name", "Todd"),
            new XElement("Gender", "Male"),
            new XElement("TotalMarks", 980)
            ));

xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
```
- add the xml element as the first element use AddFirst() method.
- AddBeforeSelf() or AddAfterSelf()
- To disable formatting the XML document use SaveOptions.DisableFormatting
```
xmlDocument.Save(@"C:\Demo\Demo\Data.xml", SaveOptions.DisableFormatting);
```
### Updating xml elements in the xml document
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

xmlDocument.Element("Students")
            .Elements("Student")
            .Where(x => x.Attribute("Id").Value == "106").FirstOrDefault()
            .SetElementValue("TotalMarks", 999);

xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
```
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

xmlDocument.Element("Students")
    .Elements("Student")
    .Where(x => x.Attribute("Id").Value == "106")
    .Select(x => x.Element("TotalMarks")).FirstOrDefault().SetValue(999);

xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
```
### Updating xml comments in the xml document
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

xmlDocument.Nodes().OfType<XComment>().FirstOrDefault().Value = "Comment Updated";

xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
```
### Deleting existing xml elements from the xml document
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

xmlDocument.Root.Elements().Where(x => x.Attribute("Id").Value == "106").Remove();

xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
```
- Deleting root node "Students"
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

xmlDocument.Root.Elements().Remove();

xmlDocument.Save(@"C:\Demo\Demo\Data.xml");
```
- Deleting xml comments from the xml document
```
xmlDocument.Nodes().OfType<XComment>().Remove();
```
### Transforming XML to CSV 
- http://csharp-video-tutorials.blogspot.com/2014/08/part-5-transforming-xml-to-csv-using.html
### CSV format
```
StringBuilder sb = new StringBuilder();
string delimiter = ",";

XDocument.Load(@"C:\Demo\Demo\Data.xml").Descendants("Student")
         .ToList().ForEach(element => sb.Append(
        element.Attribute("Country").Value + delimiter +
        element.Element("Name").Value + delimiter +
        element.Element("Gender").Value + delimiter +
        element.Element("TotalMarks").Value + "\r\n"));

StreamWriter sw = new StreamWriter(@"C:\Demo\Demo\Result.csv");
sw.WriteLine(sb.ToString());
sw.Close();
```
### HTML format
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

XDocument result = new XDocument
    (new XElement("table", new XAttribute("border", 1),
            new XElement("thead",
                new XElement("tr",
                new XElement("th", "Country"),
                new XElement("th", "Name"),
                new XElement("th", "Gender"),
                new XElement("th", "TotalMarks"))),
            new XElement("tbody",
                from student in xmlDocument.Descendants("Student")
                select new XElement("tr",
                new XElement("td", student.Attribute("Country").Value),
                new XElement("td", student.Element("Name").Value),
                new XElement("td", student.Element("Gender").Value),
                new XElement("td", student.Element("TotalMarks").Value)))));

result.Save(@"C:\Demo\Demo\Result.htm");
```
### Different XML format
```
XDocument xmlDocument = XDocument.Load(@"C:\Demo\Demo\Data.xml");

XDocument result = new XDocument(
        new XElement("Students",
            new XElement("USA",
                from s in xmlDocument.Descendants("Student")
                where s.Attribute("Country").Value == "USA"
                select new XElement("Student",
                new XElement("Name", s.Element("Name").Value),
                new XElement("Gender", s.Element("Gender").Value),
                new XElement("TotalMarks", s.Element("TotalMarks").Value))),
            new XElement("India",
                from s in xmlDocument.Descendants("Student")
                where s.Attribute("Country").Value == "India"
                select new XElement("Student",
                new XElement("Name", s.Element("Name").Value),
                new XElement("Gender", s.Element("Gender").Value),
                new XElement("TotalMarks", s.Element("TotalMarks").Value)))));

result.Save(@"C:\Demo\Demo\Result.xml");
```
