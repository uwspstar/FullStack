# JADE
- $> sudo npm install jade -g
```// indtall jade with npm```
- $> jade index.jade 
``` // build jade, will generate html file```
- $> jade --client --no-debug index.jade 
```// create a js file```
- comment
```
//- will not see me
// can see me
```
- Variable
```
- myVariable = "myNameIsXing"
            
p Hello #{myVariable}

 - website = "http://deallp.com"

a(href="#{website}")

p 123 * 123  = #{123 * 123}

- myArray = ['elm1', 'elm2']
ul
  li#myArray_item: a(href="#{website}") #{myArray[0]}
  li#myArray_item: a(href="#{website}") #{myArray[1]}
                
- mystring ='asdfasdfjasdfas;dfj;'

p= mystring

// based on the browser
 - someInfo = "<i>Verygood</i>"
p= {someInfo}
p={someInfo}
p = {someInfo}
p != {someInfo}
p !{someInfo}   // right
            
```
- if/else  / unless
```
- date = new Date()
- hour = date.getHours()

- if ((hour >= 6) && (hour <= 17)) {
    h3 Day Time
- } else {
    h3 Night Time
- }

- age = 18

if((age >= 16) && (age < 18))
    h3 student
else if age >= 18
    h3 Vote
else 
    h3 wait
    
unless age >= 16
    h3 You'll drive at 16
else
    h3 You can Drive
```
- expession
```
- dayTime =(((hour >= 6) && (hour <= 17)) ? 'Day Time' : 'Night Time')

h3 #{dayTime}
```
- p 
```
p.
    <b>abced asfalsd</b> fasdfdsgsdf gdsfgsd fgdsf gsdf gblaba 
    
p
    |<i>blabal asfalsd</i> fasdfdsgsdf 

- mystring ='asdfasdfjasdfas;dfj;'

p= mystring

```
- id
```
#2nd_myid.
    sfgsdfg blabalasf alsdfas 
```
- class
```
.2nd_myclass.
    sfgsdfg blabalasf alsdfas 
```
```
p(id="myid", class="myclass1, myclass2").
    fasdfdsgsdf gdsfgsd fgdsf gsdf gblaba lasfalsdfasd.
```
- ul li
```
  ul
    li#list_item 
        a(href='#') sfalsd
    li#list_item 
        a(href='#') ccccc asfalsd

  ul
    li#list_item: a(href='#') sfalsd
    li#list_item: a(href='#') dddddd
```

### index.jade
```
doctype

html

    include ./head.jade

    body

        div
            p first paragraph
            
            p
                |<i>blabal asfalsd</i> fasdfdsgsdf gdsfgsd fgdsf gsdf gblaba lasfalsdfasdfd
                sgsdfgdsfgsdfgdsfgsdfgblabalasfa
                lsdfasdfdsgsdfgdsfgsdfgdsfgsd
                fgblabalasfalsdfasdfdsgsdfgdsfgsdfgdsfgsdfg
                br
                |sfgsdfg blabalasf alsdfas dfdsgsdfgdsfgsdfgdsfgsdfg
            p.
                <b>abced asfalsd</b> fasdfdsgsdf gdsfgsd fgdsf gsdf gblaba 

            #2nd_myid.
                sfgsdfg blabalasf alsdfas 

            .2nd_myclass.
                sfgsdfg blabalasf alsdfas 

            ul
                li#list_item 
                    a(href='#') sfalsd
                li#list_item 
                    a(href='#') ccccc asfalsd
            
            ul
                li#list_item: a(href='#') sfalsd
                li#list_item: a(href='#') dddddd
                    
            p(id="myid", class="myclass1, myclass2").
                fasdfdsgsdf gdsfgsd fgdsf gsdf gblaba lasfalsdfasd.

            //- will not see me
            // can see me
               
            - myVariable = "myNameIsXing"
            
            p Hello #{myVariable}
            
            p 123 * 123  = #{123 * 123}

            - website = "http://deallp.com"

            a(href="#{website}")

            - myArray = ['elm1', 'elm2']

            ul
                li#myArray_item: span myArrayelm[0] is :  
                    a(href="#{website}") #{myArray[0]}
                li#myArray_item: span myArrayelm[1] is :  
                    a(href="#{website}") #{myArray[1]}

            - mystring = 'asdfk;safja;sdfhjasdf'

            p= mystring

            - myObject = {"type" : "text", "name" : "fName"}

            span First Name
            input(type=myObject.type, name=myObject.name)

```
