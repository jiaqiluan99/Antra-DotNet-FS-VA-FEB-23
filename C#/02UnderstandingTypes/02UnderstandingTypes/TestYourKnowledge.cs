/*
Understanding Data Types
Test your Knowledge
1. What type would you choose for the following “numbers”?
    A person’s telephone number
        String

    A person’s height
        ushort or float

    A person’s age
        ushort

    A person’s gender (Male, Female, Prefer Not To Answer)
        String

    A person’s salary
        decimal

    A book’s ISBN
        String

    A book’s price
        decimal

    A book’s shipping weight
        uint or float

    A country’s population
        uint or ulong

    The number of stars in the universe
        StringBuilder

    The number of employees in each of the small or medium businesses in the
    United Kingdom (up to about 50,000 employees per business)
        Array of ushort

2.What are the difference between value type and reference type variables? What is
boxing and unboxing?
    Value type is stored in stack holding the actual value, created by struct or enum, and cannot hold null value unless specified to do so.
    Reference type is stored in heap with the address stored in the stack, created by class, interface, delegate, or array, and can hold null.
    Boxing is to convert a value type into an object or interface and unboxing is the reverse process of doing so.

3. What is meant by the terms managed resource and unmanaged resource in .NET
    Managed resource are the pure .Net codes managed by CLR, and unmanaged are the ones that are not.

4. Whats the purpose of Garbage Collector in .NET?
    Manage the heap in order to reduce memory related bugs and helps provide security.

Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0?
    A divide by zero exception would be thrown.

2. What happens when you divide a double variable by 0?
    Result in ∞.

3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
    Compiler error saying that cannot directly convert long to int.

4. What is the difference between x = y++; and x = ++y;?
    In both cases, y would increase by one, but in the former, x will become the original y and in the latter, x will become the resulting y.

5. What is the difference between break, continue, and return when used inside a loop
statement?
    break: breaks out of the current loop but keep going with the current method
    continue: jumps to the next iteration of the loop and keeps going
    return: returns the value and finishes the method

6. What are the three parts of a for statement and which of them are required?
    Statement 1 executes one time before the loop starts.
    Statement 2 states the condition for the loop.
    Statement 3 is executed every iteration of the loop.
    All of them are optional.

7. What is the difference between the = and == operators?
    a = b sets a's value equal to b's.
    a == b returns a boolean telling whether their value are the same.
    
8. Does the following statement compile? for ( ; true; ) ;
    Yes, just a infinite loop.

9. What does the underscore _ represent in a switch expression?
    The underscore (_) character replaces the default keyword to signify that it should match anything if reached. 

10. What interface must an object implement to be enumerated over by using the foreach
statement?
    IEnumerable<T>





*/