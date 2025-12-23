Program 1: Delegate can point to a static method.

Description: Write a C# program to demonstrate how a delegate can point to a static method.
Requirements:

Define a static method named Add that takes two int parameters and returns their sum.
Declare a delegate named Operation that matches the signature of the Add method.

In the Main() method:
Take two integer inputs from the user.
Create an instance of the delegate and assign it to the Add method.
Use the delegate to invoke the Add method with the user-input values.
Print the result using Console.WriteLine().
  
Output:-
case1:-
Enter first number: 10
Enter second number: 20
Sum: 30
case 2:-
Enter first number: 30
Enter second number: 30
Sum: 60
case 3:
Enter first number: 20
Enter second number: -10
Sum: 10

----------------------------------------------------
using System;
delegate int Operation(int a, int b);

class Program {
 public static int Add(int x, int y){
 return x + y;
 }
 
  static void Main(){
 int num1 = Convert.ToInt32(Console.ReadLine());
 int num2 = Convert.ToInt32(Console.ReadLine());
 Operation op = new Operation(Add);
 int result = op.Invoke(num1, num2);
 Console.WriteLine($"Sum: {result}");
 }
}

==================================================================================
Program 2: Multicast Delegate

Description: Write a C# program to demonstrate a delegate for calculating different areas using user
input.
  
Requirements:
Define a delegate named AreaCalculator that has a return type void and two
parameters (double p1, double p2).
Create a class named Area that includes the following methods:

Method 1:
public void CalculateSquareArea(double sideLength, double _)
 Calculates and prints the area of a square (sideLength * sideLength).
  
Method 2:
public void CalculateRectangleArea(double length, double width)
 Calculates and prints the area of a rectangle (length * width).
  
Method 3:
public void CalculateCircleArea(double radius, double _)
 Calculates and prints the area of a circle (Math.PI * radius * radius).
  
In the Test class:
Take user input for side length, rectangle length & width, and circle radius.
Create delegate instances for each method and invoke them.
Display all results.

  OutPut:-
case 1:-
Input:-side = 5
length = 5
width = 3
radius = 4
output:-
Area of Square: 25
Area of Rectangle: 15
Area of Circle: 50.26548245743669

case 2:-

side = 10
length = 8
width = 6
radius = 7
output:-
Area of Square: 100
Area of Rectangle: 48
Area of Circle: 153.93804002589985
  
case 3:-
side = 3
length = 2.5
width = 4
radius = 2
output:-
Area of Square: 9
Area of Rectangle: 10
Area of Circle: 12.566370614359172

-------------------------------------------------------------------------
  Solution Code
using System;
delegate void AreaCalculator(double d1, double d2);

class Area{
 public static void CalculateSquareArea(double sideLength, double _){
 Console.WriteLine($"Area of Square: {sideLength * sideLength}");
 }
  
 public static void CalculateRectangleArea(double sideLength, double width){
 Console.WriteLine($"Area of Rectangle: {sideLength * width}");
 }
  
 public static void CalculateCircleArea(double radius, double _){
 Console.WriteLine($"Area of Circle: {Math.PI*radius*radius}");

 }
 static void Main(){
 double side = Convert.ToDouble(Console.ReadLine());
 double length = Convert.ToDouble(Console.ReadLine());
 double width = Convert.ToDouble(Console.ReadLine());
 double radius = Convert.ToDouble(Console.ReadLine());
   
 AreaCalculator del = CalculateSquareArea;
 AreaCalculator del1 = CalculateRectangleArea;
 AreaCalculator del2 = CalculateCircleArea;
   
 del.Invoke(side, 0);
 del1.Invoke(length, width);
 del2.Invoke(radius, 0);
 }
}

=====================================================================
Program 3: Single-cast delegate that takes a string parameter.

Description: Write a C# program to demonstrate a single-cast delegate that takes a string
parameter.
  
Requirements:
Define a delegate named WelcomeDelegate that accepts a string parameter and
returns void.
Create a method named WelcomeUser that takes a string parameter and prints
"Welcome, <name>!".

Create a delegate instance and assign it to the WelcomeUser method.
Invoke the delegate by passing the users name.
Display the output.
Enter your name: Vaibhav
Welcome, Vaibhav!
-------------------------------------------------------------------------------------
Solution Code

using System;
delegate void WelcomeDelegate(string str);
class test{
 public static void WelcomeUser(string str){
 Console.WriteLine($"Welcome, {str}!");
 }
  
 static void Main(){
 string userName = Console.ReadLine();
   
 WelcomeDelegate del = new WelcomeDelegate(WelcomeUser);
 del.Invoke(userName);
 }
}
