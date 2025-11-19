using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------
            // Uncomment the following code to see the 2D array example in action
            //---------------------------------------------------------------------------

            Console.WriteLine("2D Array Example");
            int[,] arr = new int[3, 4]
            {
               {1, 2, 3, 4},
               {5, 6, 7, 8},
               {9, 10,11,12}
            };
            Console.WriteLine("Elements in the 2D array:");
            for(int  i=0; i < arr.GetLength(0); i++)
            {
               for(int j =0; j < arr.GetLength(1); j++)
               {
                   Console.Write(arr[i,j] +" ");

               }
               Console.WriteLine();

            }

            //---------------------------------------------------------------------------
            // transpose matrix - (rows become columns and columns become rows)
            //---------------------------------------------------------------------------

            Console.WriteLine("Transpose of a 2D Array");
            int[,] matrix = new int[3,2]
            {
               {1, 2},
               {3, 4},
               {5, 6 }
            };
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            for(int i =0; i <c; i++)
            {
               for(int j = 0; j<r; j++)
               {
                 Console.Write(matrix[j,i] + " ");
               }
               Console.WriteLine();
            }

            //-------------------------------- sum of column ------------------------------------------

            Console.WriteLine("Sum of column:");
            int[,] matrix = new int[3, 3]
            {
               {1, 2,3},
               {3, 4,5},
               {5, 6,7}
            };
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            for (int i = 0; i < c; i++)
            {
               int sum = 0;
               for (int j = 0; j < r; j++)
               {
                   sum += matrix[i,j];
                   Console.Write(matrix[i,j] + " ");

               }
               Console.Write("=> Sum: " + sum);
               Console.WriteLine();
            }

            //-------------------------------Sum of Rows--------------------------------------------
            Console.WriteLine("Sum of Rows:");
            int[,] matrix = new int[3, 3]
            {
               {1, 2,3},
               {3, 4,5},
               {5, 6,7}
            };
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            for (int i = 0; i < c; i++)
            {
               int sum=0;
               for (int j = 0; j < r; j++)
               {
                   sum += matrix[i, j];
                   Console.Write(matrix[j, i] + " ");

               }
               Console.Write("=> Sum: " + sum);
               Console.WriteLine();
            }

            //---------------------------Row wise and column wise both print------------------------------------------------
            Console.WriteLine("Sum of Rows:");
            int[,] matrix = new int[3, 3]
            {
               {1, 2,3},
               {3, 4,5},
               {5, 6,7}
            };
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);

            for (int i = 0; i < c; i++)
            {
               int sum = 0;
               for (int j = 0; j < r; j++)
               {
                   sum += matrix[i, j];
                   Console.Write(matrix[j, i] + " ");

               }
               Console.Write("=> Sum: " + sum);
               Console.WriteLine();
            }

            Console.WriteLine("===========================================");

            Console.WriteLine("column wise");
            for (int i = 0; i < c; i++)
            {
               int sum = 0;
               for (int j = 0; j < r; j++)
               {
                   sum += matrix[j,i];
                   Console.Write(matrix[j, i] + " ");

               }
               Console.Write("=> Sum: " + sum);
               Console.WriteLine();
            }

            //--Ask the user to enter the number of rows and columns. Read all elements of the array . Print the array in matrix form. --
            
            Console.Write("Enter number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[rows, cols];
            Console.Write($"Enter {rows * cols} elements:");

            for(int i = 0; i < rows; i++)
            {
               for (int j = 0; j < cols; j++)
               {
                   Console.Write($"Element:[{i},{j}] : ");
                   arr[i, j] = Convert.ToInt32(Console.ReadLine());
               }
            }
            Console.WriteLine("The matrix is:");
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
}
