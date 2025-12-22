using System;

namespace ex_3
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30 };

            Console.WriteLine("Array contents: [{0}]", string.Join(", ", numbers));
            Console.Write("Enter an index to read from the array: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int index))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            try
            {
                int value = numbers[index];
                Console.WriteLine($"Value at index {index} is {value}.");
            }
            catch (IndexOutOfRangeException ex)
            { 
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program finished.");
                Console.ReadLine();
            }
        }
    }
}
