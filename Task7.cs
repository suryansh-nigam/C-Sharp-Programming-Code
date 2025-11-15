Question 1 — Print First N Multiples of a Number


using System;

class Multiples
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter N (how many multiples to print): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nFirst {n} multiples of {x}:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(x * i + " ");
        }
    }
}


------------------------------------------------------------------------------------------------------

Question 2 — Print Pattern




*****
****
***
**
*



using System;

class Pattern
{
    static void Main()
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


-------------------------------------------------------------------------------------------------------------------

Question 3 — Palindrome Numbers Between 1 to 1000


using System;

class PalindromeNumbers
{
    static void Main()
    {
        Console.WriteLine("Palindrome numbers between 1 and 1000:");

        for (int num = 1; num <= 1000; num++)
        {
            int original = num;
            int reverse = 0;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                reverse = reverse * 10 + digit;
                temp = temp / 10;
            }

            if (original == reverse)
            {
                Console.Write(original + " ");
            }
        }
    }
}

