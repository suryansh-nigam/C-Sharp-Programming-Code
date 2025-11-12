    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConstructorOverloading
    {
        internal class Program
        {
            public Program() {
                Console.WriteLine("This is a first constructor.");
            }
            public Program(int a, int b)
            {
                Console.WriteLine("This is a second constructor." +  (a+b));
            }
            public Program(int a, int b, int c)
            {
                Console.WriteLine("This is a third constructor."+ (a+b+c) );

            }
            public Program(string name)
            {
                Console.WriteLine("This is a fourth constructor." +name);

            }
            static void Main(string[] args)
            {
                Program p = new Program();
                Program p1 = new Program(20,23);
                Program p2 = new Program(20,23,45);
                Program p4 = new Program("Suryansh");






            }
        }
    }
