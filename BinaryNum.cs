Q. WAP to pirnt binary value of a number?
-------------------------------------------------------------------------  
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        
        string binary = Convert.ToString(num, 2);
        Console.Write("Binary: "+ binary);
    }
}
