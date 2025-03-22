# 🎯 Dependency Injection Example in C#

## Welcome to the Dependency Injection Example project!
This project demonstrates how to use Constructor Injection in C# with interfaces, 
making the code more modular, testable, and maintainable. 🚀


## An example was created using
Dependency Injection among the classes given below.

- Classes:

TeacherClass

Properties:

FirstName: string

LastName: string

Methods:

GetInfo(): A method that returns the teacher's name and surname.

ClassRoom Class

Properties:

Teacher: An object of the Teacher type

Methods:

GetTeacherInfo(): A method that returns the teacher's information. It is enough to call GetInfo() in the Teacher.

- Task:

Teacher and Classroom classes were written.

An instance of the Teacher class was passed as a parameter to the constructor of the ClassRoom class. (Constructor Injection)

A Classroom object was created using the methods of both classes and the teacher's information was printed on the screen.

- NOTE: Dependency Injection means giving the dependencies that a class needs from outside. This provides a more flexible structure by reducing the dependencies between classes.

- ADDITION: A Base Interface named ITeacher was created for the Teacher class

## 🛠️ Technologies Used

- C# (.NET)

- Object-Oriented Programming (OOP)

- Dependency Injection (DI)

- Interface-based Design
