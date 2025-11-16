Q1. Reverse Number
=========================================================================

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.Write("Enter Number: ");
       int n = Convert.ToInt32(Console.ReadLine());
      
       int rev = 0;
       while(n != 0 ){
           int digit = n %10;
           rev = rev * 10+ digit;
           n /= 10;
       }
      
       
       Console.WriteLine("Reversed num is:" + rev );
    
    }
}
