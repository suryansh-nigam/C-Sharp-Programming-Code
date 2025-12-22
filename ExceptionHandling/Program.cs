using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            
                Console.Write("Enter a String: ");
                string input = Console.ReadLine();

                try
                {
                    number = int.Parse(input);
                    Console.WriteLine("Converted value: {0}", number);
                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception Handled : {ex.Message}");
                }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
