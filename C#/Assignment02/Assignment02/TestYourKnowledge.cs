/*
1. When to use String vs. StringBuilder in C# ?
    Only use StringBuilder when you want tomodify a string, otherwise use String.

2. What is the base class for all arrays in C#?
    The Array class is the base class for all the arrays in C#.

3. How do you sort an array in C#?
    Use Array.sort() method.

4. What property of an array object can be used to get the total number of elements in an array?
    Length

5. Can you store multiple data types in System.Array?
    Yes

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
    CopyTo():   copies the source array to desitination array, copying from the given index of the new array to the end of the array,
                is slightly slower, and does not need typecasting.
    Clone():    copies the array and returns the new object, always copies all content of the array, is slightly faster,
                needs to typecast the result to the original array datatype. 


*/