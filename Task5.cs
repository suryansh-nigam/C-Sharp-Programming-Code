Question 1)Write a C# program to find the largest of three numbers using if-else statements.
Input:-
Enter first number: 10  
Enter second number: 25  
Enter third number: 17

Output:-
The largest number is: 25
==============================================================
  using System;

class Q4{
static void Main(){

Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(n1>n2){
Console.WriteLine($"The largest num is:{n1} ");

}
else if(n2>n3){
Console.WriteLine($"The largest num is:{n2} ");

}else{
Console.WriteLine($"The largest num is:{n3} ");
}
}
}
----------------------------------------------------------------------------

Question 2)Write a C# program to give a week day by using Switch case.

Input:-
Enter a number (1 to 7): 3

Output:-
Wednesday

============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7):");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;


            }
        }
    }
}

-----------------------------------------------------------------------------

Question 3)Write a C# program to print numbers from 1 to 100 using a do-while loop.

Output:-
1
2
3
...
100
=============================================================================
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;

            } while (i != 100);
        }
    }
}

-----------------------------------------------------------------------------

Question 4)Write a C# program Sum of First N Natural Numbers using while loop

Input:-
Enter a number (N): 5
Output:-
Sum of first 5 natural numbers = 15
  =============================================================================================
  using System;
class Program
{
    static void Main()
    {
        int sum = 0, i = 1;

        Console.Write("Enter a number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        while (i <= n)
        {
            sum += i;
            i++;
        }
        Console.WriteLine($"Sum of first {n} natural numbers = {sum}");
    }
}


-----------------------------------------------------------------------------

Question 5)Write a C# program  Factorial of a Number using for loop.
Input:-
Enter a number to find factorial: 7
Output:-
Factorial of 7 is: 5040
  ==========================================================
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 1 ;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + f);
        }
    }
}


------------------------------------------------------------------------------

Question 6)Write a C# program to find Armstrong Number Check (for 3-digit numbers).
Input:-
Enter a number: 153
Output:-
153 is an Armstrong number.
  ==============================================================
  using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int n1 = num, sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }
        if (sum == n1)
            Console.WriteLine($"{n1} is an Armstrong number.");
        else
            Console.WriteLine($"{n1} is not an Armstrong number.");
    }
}


------------------------------------------------------------------------------

Question 7)Write a C# program to count the number of digits in an integer.
Input:-
Enter a number: 1234
Output:-
Number of digits in 1234 is: 4
  ===================================================================
  using System;
class Program
{
    static void Main()
    {
        int count = 0;
        
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;

        if (num == 0)
            count = 1;  
        while (temp != 0)
        {
            temp /= 10;
            count++;
        }
        Console.WriteLine($"Number of digits in {num} is: {count}");
    }
}

------------------------------------------------------------------------------

Question 8)Write a C# program to reverse a given number using a do-while loop.

Sample Input/OutPut :-

Input:  12345
Output: 54321
  ======================================================================
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int rev = 0, rem = 0;
            do {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            } while (n != 0);
            Console.WriteLine("Reversed Number is: " + rev);
        }
        
    }
}

------------------------------------------------------------------------------
