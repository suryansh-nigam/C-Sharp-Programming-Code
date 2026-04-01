using System;
using System.Collections.Generic;


namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Console.WriteLine("---Prime Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //bool isPrime = true;

            //for (int i = 2; i <= Math.Sqrt(n); i++)
            //{
            //    if (n % i == 0)
            //    {
            //        isPrime = false;
            //        Console.WriteLine("It is not prime number ");
            //        break;
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine($" {n}, It is Prime Number");
            //    }


            //}


            ////---------------------------------------------------------------

            //Console.WriteLine("---Perfect Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //if (sum == n)
            //{
            //    Console.WriteLine($"{n} is perfect number");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} is not perfect number");

            //}

            ////---------------------------------------------------------------

            //Console.WriteLine("---Palindrome Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int originalvalue = n;
            //int rev = 0;

            //while (n > 0)
            //{
            //    int digit = n % 10;
            //    rev = rev * 10 + digit;
            //    n /= 10;

            //}
            //if (originalvalue == rev)
            //{
            //    Console.WriteLine($"{originalvalue} is Palindrome number");
            //}
            //else
            //{
            //    Console.WriteLine($"{originalvalue} is not Palindrome number");

            //}


            ////---------------------------------------------------------------

            //Console.WriteLine("---Reverse Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int rev = 0;

            //while (n != 0)
            //{
            //    int digit = n % 10;
            //    rev = rev * 10 + digit;
            //    n /= 10;
            //}

            //Console.WriteLine($"Reversed number is {rev}");

            ////---------------------------------------------------------------

            //Console.WriteLine("---Factorial  Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int f = 1;
            //for (int i = 2; i <= n; i++)
            //{
            //    f = f * i;
            //}
            //Console.WriteLine($"{n} Factorial is {f}");

            ////---------------------------------------------------------------

            //Console.WriteLine("---Armstrong Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int original = n;
            //while (n > 0)
            //{
            //    int digit = n % 10;
            //    sum += digit * digit * digit;
            //    n /= 10;
            //}
            //if (sum == original)
            //{
            //    Console.WriteLine($"{sum} is Armstrong Number");

            //}
            //else
            //{
            //    Console.WriteLine($"{sum} is not Armstrong Number");

            //}

            ////---------------------------------------------------------------

            //Console.WriteLine("---Fibanocci series----");

            //int a = 0; int b = 1;
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.Write(a + " " + b + " ");
            //for (int i = 2; i < n; i++)
            //{
            //    int c = a + b;
            //    Console.Write(c + " ");
            //    a = b;
            //    b = c;
            //}


            ////---------------------------------------------------------------

            //Console.WriteLine("---Reverse a string----");
            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //string rev = "";
            //foreach (char ch in str)
            //{
            //    rev = ch + rev;
            //}

            //Console.WriteLine($"Revesre string is {rev}");

            ////------------------------------------------------------------------
            //Console.WriteLine("---sum of digits of a Number----");
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //while (n > 0)
            //{
            //    int digit = n % 10;
            //    sum += digit;
            //    n /= 10;
            //}
            //Console.WriteLine(sum);


            ////-------------------------------------------------
            //Console.WriteLine("Sort an array");
            //int[] arr = { 2, 67, 8, 95, 34, 5, 3, 7, 9, 11 };
            //int temp = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for(int j = i+1; j < arr.Length; j++)
            //    {
            //        if(arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //-------------------------------------------------
            //Console.WriteLine("Merge two array");
            //int[] arr1 = { 1,2,3,4 };
            //int[] arr2 = { 5, 6, 7, 8 };

            //int[] merged = new int[arr1.Length + arr2.Length];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    merged[i] = arr1[i];
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    merged[arr1.Length + i] = arr2[i];
            //}
            //Console.Write("Merged Array : ");
            //foreach(int num in merged)
            //{
            //    Console.Write(num + " ");
            //}

            ////-------------------------------------------------
            //Console.WriteLine("Find largest element an array");
            //int[] arr = { 10, 45, 2, 99, 23 };

            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];

            //    }
            //}

            //Console.WriteLine("Largest element: " + max);

            //-------------------------------------------------
            //Console.WriteLine("remove duplicate element an array");
            //int[] arr = { 10, 45, 2, 99, 23, 23,45 };
            //HashSet<int> set = new HashSet<int>(arr);

            //foreach(int num in set)
            //{
            //    Console.Write(num + " ");
            //}

            //-------------------------------------------------
            //Console.WriteLine("Find missing num an array");
            //int[] arr = { 1,2,4,5};

            //int n = 5;
            //int totalSum = n * (n + 1) / 2;
            //int actualSum = 0;

            //foreach (int i in arr)
            //{
            //    actualSum += i;
            //}
            //int missing = totalSum - actualSum;
            //Console.WriteLine("Missing Number is : " + missing);

            //-------------------------------------------------
            //Console.WriteLine("Find second largest element an array");
            //int[] arr = { 10, 45, 2, 99, 23,20,666 };
            //int first = int.MinValue;
            //int second = int.MinValue;

            //foreach(int num in arr)
            //{
            //    if(num > first)
            //    {
            //        second = first;
            //        first = num;

            //    }else if(num > second && num != first)
            //    {
            //        second = num;
            //    }

            //}
            //Console.Write("Second Largest is :" + second);

        }
    }
}
