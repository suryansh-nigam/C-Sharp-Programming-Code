Q1. Swap Two Numbers Without Using Third Variable
=====================================================================

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter Number A: ");
       int a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter Number B: ");
       int b = Convert.ToInt32(Console.ReadLine());
       
       a= a+b;
       b= a-b;
       a = a-b;
       
       Console.WriteLine("After Swap A is: " + a );
        Console.WriteLine("B is: "+b);

    }
}

-----------------------------------------------------------------------------
Q2. Swap Two Numbers Using Third Variable



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter Number A: ");
       int a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter Number B: ");
       int b = Convert.ToInt32(Console.ReadLine());
       
      int temp =a;
      a=b;
      b= temp;
       
       Console.WriteLine("After Swap A is: " + a );
        Console.WriteLine("B is: "+b);

 
       
    }
}
