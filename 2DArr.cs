1.Write a C# program to read the elements from user in 2d array and print those elements.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Array elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}



2.write a C# program to print the sum of 2d array.

1st array
1 2
3 4

2nd array
1 2
3 4

Output array
2 4
6 8

using System;

class Program
{
    static void Main()
    {
        int[,] arr1 = { {1, 2}, {3, 4} };
        int[,] arr2 = { {1, 2}, {3, 4} };
        int rows = 2, cols = 2;

        int[,] sum = new int[rows, cols];

        // Add arrays
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum[i, j] = arr1[i, j] + arr2[i, j];
            }
        }

        // Print result
        Console.WriteLine("Sum of arrays:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}



3.Write a C# program to print the sum of right diagonal in an 2 dimensional array and user has to enter size of array and elements in that array.
eg:
size: 3 3
elements
1 2 4
4 5 6
7 8 9
output as:
16

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array (n n): ");
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);

        int[,] arr = new int[n, n];

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = int.Parse(row[j]);
            }
        }

        // Calculate right diagonal sum
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i, n - 1 - i];
        }

        Console.WriteLine("Sum of right diagonal: " + sum);
    }
}


4.Write a C# program to print the sum of left diagonal in an 2 dimensional array and user has to enter size of array and elements in that array.
eg:
size: 3 3
elements
1 2 4
4 5 6
7 8 9
output as-:
15

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array (n n): ");
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);

        int[,] arr = new int[n, n];

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = int.Parse(row[j]);
            }
        }

        // Calculate left diagonal sum
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i, i];
        }

        Console.WriteLine("Sum of left diagonal: " + sum);
    }
}


