using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void calculation(int a, int b);
    internal class Program
    {
       
        public static void addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("The sum is: " + c);
        }

        public static void subtraction(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("The sub is: " + c);
        }

        public static void multiplication(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("The mul is: " + c);
        }

        public static void division(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("The div is: " + c);
        }
        static void Main(string[] args)
        {
            calculation obj = new calculation(Program.addition);
            obj.Invoke(10, 20);
          
            calculation obj1 = new calculation(Program.subtraction);
            obj1.Invoke(20, 20);
            calculation obj2 = new calculation(Program.multiplication);
            obj2.Invoke(10, 20);
            calculation obj3 = new calculation(Program.division);
            obj3.Invoke(10, 20);

            // Also we can write like: ----- OR ------
            
            obj = subtraction;
            obj(30, 10);
            obj = multiplication;
            obj.Invoke(10, 20);
            obj = division;
            obj.Invoke(20, 10);

            Console.ReadLine();

        }
    }
}
