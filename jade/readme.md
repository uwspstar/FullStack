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

```


- p 
```
p.
    <b>abced asfalsd</b> fasdfdsgsdf gdsfgsd fgdsf gsdf gblaba 
    
p
    |<i>blabal asfalsd</i> fasdfdsgsdf 
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
