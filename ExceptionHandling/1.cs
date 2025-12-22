using System;

namespace Exceptionhandling
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number 1 : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());

            

            try
            {
                var result = a / b;
                Console.WriteLine($"Result of two numbers: {result}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

        }
    }
}