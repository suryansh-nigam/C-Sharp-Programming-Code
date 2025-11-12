using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        // Method without parameter
        public void showMessage()// Method Declaration
        {
           Console.WriteLine("Hello Suryansh!");
           Console.WriteLine("How are you?");

        }

        //---------------------------------------------------------------

        // Method with parameter

        public static void showAge(int age)
        {
           Console.WriteLine("Hello Suryansh what's your age: " + age );

        }

        public static void showName(String name)
        {
           Console.WriteLine("Hello what's your name: " + name);

        }
        static void Main(string[] args)
        {
            showName("Suryansh");// Method Call 


            showAge(21);// Method Call

            Program p1 = new Program();// Creating object of class
            p1.showMessage();
        }
    }
}
