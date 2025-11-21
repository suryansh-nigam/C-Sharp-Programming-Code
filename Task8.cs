Question 1)Write a C# program that defines a static method without any parameters named "Square".

This method should:

Prompt the user to enter an integer,

Calculate the square of that number,

And display the result.

In the Main() method, call the static method using the class name (Program.Square()).

Input:-
Enter a number: 5

output:-
Square: 25

===========================================================================
using System;

class Program
{
    static void Square()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        int square = num * num;
        Console.WriteLine("Square: " + square);
    }

    static void Main()
    {
        Program.Square(); 
    }
}

-----------------------------------------------------------------------------------------------------------------------

Question 2)Write a C# program that defines a class named MathHelper with a static method Factorial(int number) that returns the factorial of a given number.

In the Main() method of the MathHelper class:

Prompt the user to enter an integer.

Call the static method Factorial() from the MathHelper class.

Print the factorial result.

Input:-
Enter a number: 5

Output:-
Factorial of 5 is: 120
=====================================================
using System;

class MathHelper
{
    public static int Factorial(int n)
    {
       int f = 1;
        for (int i = 1; i <= n; i++)
        {
            f *= i;
        }
        return f;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

      int result = Factorial(num);

        Console.WriteLine("Factorial of " + num + " is: " + result);
    }
}

------------------------------------------------------------------------------------------------------------

Question 3)Write a C# program that defines a class named TimeHelper containing a static method GetCurrentTime() which returns the current system time in HH:mm:ss format.

In the Main() method of the TimeHelper class:

Call the static method GetCurrentTime() using the class name.

Display the returned current time on the console.

Output:-
Current Time: 14:35:27

==========================================================
using System;

class TimeHelper
{
    static string CurrentTime()
    {
        return DateTime.Now.ToString("HH:mm:ss");
    }

    static void Main()
    {
        string time = CurrentTime();
        Console.WriteLine("Current Time: " + time);
    }
}

-------------------------------------------------------------------------------------------------------------

Question 4) Create a C# program with a class named MathUtilities that contains four static methods:

Add(int a, int b) – returns the sum of two integers.

Subtract(int a, int b) – returns the difference between two integers.

Multiply(int a, int b) – returns the product of two integers.

Divide(int a, int b) – returns the result of dividing the first integer by the second as a double.

In the Main() method:

Prompt the user to input two numbers.

Call each static method from the MathUtilities class using those numbers.

Display the results of all four operations.

Input:-
Enter first number: 10
Enter second number: 5

Output:-
Results:
Addition: 15
Subtraction: 5
Multiplication: 50
Division: 2

===========================================
using System;

class MathUtilities
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Results:");
        Console.WriteLine("Addition: " + Add(n1, n2));
        Console.WriteLine("Subtraction: " + Subtract(n1, n2));
        Console.WriteLine("Multiplication: " + Multiply(n1, n2));
        Console.WriteLine("Division: " + Divide(n1, n2));
    }
}


