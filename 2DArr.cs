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



