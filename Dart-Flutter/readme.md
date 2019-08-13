# Dart and Flutter
- Dart and Flutter: The Complete Developer's Guide by Stephen Grider
https://www.udemy.com/dart-and-flutter-the-complete-developers-guide/
- Dart :  program language
- Flutter : Mobile UI framework
- React Native vs Flutter - Which to Learn?
https://www.youtube.com/watch?v=tSyXb0sHBoE&t=107s
### Tool
- dartpad
https://dartpad.dartlang.org/

### cheatsheet
https://dart.dev/codelabs/dart-cheatsheet
```
void main() {
  var name = getName();
  print('my name is $name');
  print('my name is ${name}');
  print('my name is ${name.length}');
}

String getName() {
  return 'Xing';
}
```
```
void main() {
 
  var person =  new Person('xing');
  person.gerName();
  
}
class Person {
  String firstName;
  Person(this.firstName);
  
  gerName() {
    print(firstName);
  }
}
```
```
int meaningOfLife = 42;
double valueOfPi  = 3.141592;
bool visible      = true;
```
- value type lower case
- A String is immutable
- A Set is an unordered collection of unique objects.
- A Map is an unordered collection of key-value pairs. 
- A Uri object represents a uniform resource identifier
```
Uri dartlang = Uri.parse('http://dartlang.org/');
```
### documentation
- Dart API documentation
https://api.dart.dev/stable/2.4.1/index.html
- dart core
https://api.dart.dev/stable/2.4.1/dart-core/dart-core-library.html

### flutter 
- install flutter sdk for Mac
https://flutter.dev/docs/get-started/install/macos
-  Editing the PATH Variable
https://www.udemy.com/dart-and-flutter-the-complete-developers-guide/learn/lecture/10874516#overview
- install flutter sdk for PC
https://www.udemy.com/dart-and-flutter-the-complete-developers-guide/learn/lecture/10863188#overview
