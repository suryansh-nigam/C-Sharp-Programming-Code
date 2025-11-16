Q - Fibonacci Series
------------------------------------------------------

using System;

class FibonacciExample
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        Console.Write("Fibonacci Series: " + a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
