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
- Dart API documentation
https://api.dart.dev/stable/2.4.1/index.html
