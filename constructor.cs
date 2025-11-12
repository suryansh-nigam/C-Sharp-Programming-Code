using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {

        // default constructor

        public Program()
        {
           Console.WriteLine("Constructor Invoke !!");
        }

        ============================================================

        // parameterized constructor

        public Program(int age, string name, int salary) {

           Console.WriteLine("Your age is : "+  age);
           Console.WriteLine("Your age is : " + name);
           Console.WriteLine("Your age is : " + salary);
        }


       
        static void Main(string[] args)
        {
          Program p = new Program();// default Constructor
           Program p = new Program(23,"Suryansh", 25000);// parametrzed Constructor
            Console.ReadLine();
        }
    }
}
