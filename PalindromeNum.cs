Q - WAP to print palindrome number
===============================================================
ex - MADAM, 1221
  --------------------------------------
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
       int org = num;
       int rev = 0;
       
       while(num>0){
           int digit = num %10;
           rev = rev * 10+digit;
           num /= 10;
           
       }
       if(org==rev){
           Console.Write("It is a Palindrome Number.");
       }else{
           Console.Write("It is not Palindrome Number.");
       }
    }
}
