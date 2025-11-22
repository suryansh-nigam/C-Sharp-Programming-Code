Q- Find sum of  digit of a number

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number:  ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int sum  = 0;
        while(num > 0){
            int digit = num % 10;
            sum += digit;
            num /= 10;
        
        }
        Console.WriteLine ("Sum of a number: " + sum);
    }
}
