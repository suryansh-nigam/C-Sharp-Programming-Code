Question 1)Write a C# Program to  Check Vowel or Consonant using if-else.
Input:-
Enter a character: O
Output:-
O is a vowel.

Input:-
Enter an character: b
Output:-
b is a consonant.

=========================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is a vowel.");
            }
            else
            {
                Console.WriteLine(ch + " is not a vowel.");
            }

        }
    }
}


--------------------------------------------------------------------------

Question 2) Fibonacci Series
Question:
Print the first N Fibonacci numbers using a for loop.
Example:
Input: N=7
Output: 0 1 1 2 3 5 8

==================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Day6Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, next;
            Console.WriteLine("Enter the value of N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fibonacci Series:");
            
            for (int i = 1; i <= n; ++i)
            {
                Console.Write(a + " ");
                next = a + b;
                a = b;
                b = next;
            }


        }
    }
}


------------------------------------------------------------------------
Question 3) Print the Pattern in C#:-
*****
*****
*****
*****
*****
=====================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

------------------------------------------------------------------------

Question 4) Write a C# program to print all prime numbers between 1 and 50 using nested for loops.

A prime number is a number greater than 1 that has no divisors other than 1 and itself.

Output:-

Prime numbers between 1 and 50:
2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

============================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1 and 50 are:");

            for (int num = 2; num <= 50; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(num + " " );
                }
            }


        }
    }
}


------------------------------------------------------------------------

Question 5) Print the Pattern in C#:-
*
**
***
****
*****
=========================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern1
{
    internal class Pattern2
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

----------------------------------------------------------------------

Question 6) Write a C# program to print the following series 1,4,9,16,25.....N.

Input:-
Enter the value of N: 6
Output:-
Series:
1, 4, 9, 16, 25, 36
===================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                {
                Console.Write(i * i + ",");
            }


        }
    }
}

-------------------------------------------------------------------------
