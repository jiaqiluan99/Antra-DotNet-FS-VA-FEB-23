// See https://aka.ms/new-console-template for more information
using System;
using Assignment03;

//Working with methods
//1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
//reverse the contents of it.
ReverseArray q1 = new ReverseArray();
q1.run();

//2. Your mission, should you choose to accept it, is to create a method called Fibonacci, which
//takes in a number and returns that number of the Fibonacci sequence.
FibonacciSequence q2 = new FibonacciSequence();
q2.run();

//Designing and Building Classes using object-oriented principles
//1. Write a program that that demonstrates use of four basic principles of
//object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
///Polymorphism/.
//2. Use /Abstraction/ to define different classes for each person type such as Student
//and Instructor. These classes should have behavior for that type of person.
//3. Use /Encapsulation/ to keep many details private in each class.
//4.Use / Inheritance / by leveraging the implementation already created in the Person
//class to save code in Student and Instructor classes.
//5. Use /Polymorphism/ to create virtual methods that derived classes could override to
//create specific behavior such as salary calculations.
//6.Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
//IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
//person specific methods). IStudentService, IInstructorService should inherit from
//IPersonService.
/*****************************************************************************
Created two interfaces: ICourseService and IDepartmentService
Created one abstract class: Person
Created four derived classes: Student and Instructor derived from Person,
                              Course derived from ICourseService,
                              and Department derived from IDepartmentService
*****************************************************************************/

//7.Try creating the two classes below, and make a simple program to work with them, as
//described below
PlayBalls.run();


