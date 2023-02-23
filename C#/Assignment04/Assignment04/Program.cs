// See https://aka.ms/new-console-template for more information

using System;
using Assignment04;


//Practice working with Generics
/*
1. Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
    1. int Count()
    2. T Pop()
    3. Void Push()
*/
//Test Cases
Console.WriteLine("MyStack Test Cases");
MyStack<int> ms = new MyStack<int>();
Console.WriteLine($"Count: {ms.Count()}");
ms.Push(1);
ms.Push(2);
ms.Push(3);
ms.Push(4);
ms.Push(5);
ms.Push(6);
Console.WriteLine($"Count: {ms.Count()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Count: {ms.Count()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Count: {ms.Count()}");
Console.WriteLine($"Removed: {ms.Pop()}");
Console.WriteLine($"Count: {ms.Count()}");

/*
2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
    1. void Add (T element)
    2. T Remove (int index)
    3. bool Contains (T element)
    4. void Clear ()
    5. void InsertAt (T element, int index)
    6. void DeleteAt (int index)
    7. T Find (int index)
*/
//Test Cases
Console.WriteLine("MyList Test Cases");
MyList<int> ml = new MyList<int>();
Console.WriteLine($"Count: {ml.Count()}");
ml.Add(1);
Console.WriteLine($"Count: {ml.Count()}");
ml.Add(2);
ml.Add(3);
ml.Add(4);
ml.Add(5);
ml.Add(6);
ml.Add(7);
ml.Add(8);
ml.Add(9);
ml.Add(10);
ml.Add(11);
ml.Add(12);
Console.WriteLine($"Count: {ml.Count()}");
ml.InsertAt(13, 12);
Console.WriteLine($"Count: {ml.Count()}");
ml.InsertAt(0, 0);
Console.WriteLine($"Count: {ml.Count()}");
ml.InsertAt(99, 6);
Console.WriteLine($"Count: {ml.Count()}");
Console.WriteLine(ml.Contains(99));
Console.WriteLine(ml.Find(6));
ml.DeleteAt(0);
Console.WriteLine($"Count: {ml.Count()}");
Console.WriteLine(ml.Remove(13));
Console.WriteLine(ml.Remove(5));
Console.WriteLine(ml.Remove(0));
ml.Clear();
Console.WriteLine($"Count: {ml.Count()}");

/*
3. Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
    1. void Add(T item)
    2. void Remove(T item)
    3. Void Save()
    4. IEnumerable<T> GetAll()
    5. T GetById(int id)
*/

//GenericRepository Class and IRepository<T> Interface








