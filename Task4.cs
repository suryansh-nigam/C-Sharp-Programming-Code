
Question 1) Write a C# program to calculate the area and perimeter of a rectangle using arithmetic operators.

create a class with the name "Employee" in that write the Main Method 

In the Main Method:-

length (double)
width(double)
Area(double)
Perimeter(double)

Calculate the area and Perimeter of Rectangle.

Use the formula:

Area = length × width

Perimeter = 2 × (length + width)

Finally, display the entered values along with the calculated area and perimeter.


Sample Input:-

Enter the length of the rectangle: 10
Enter the width of the rectangle: 5

Sample Output:-

--- Rectangle Details ---
Length: 10
Width: 5
Area: 50
Perimeter: 30

===============================================================
using System;
class Q1{
static void Main(){


Console.WriteLine("Enter the length of the rectangle: ");
double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the witdht of the rectangle: ");
double width = Convert.ToDouble(Console.ReadLine());

double a = length * width;
double p = 2*(length + width);

Console.WriteLine("--- Rectangle Details ---");
Console.WriteLine($"Length: {length}\n Width: {width}\n Area: {a}\n Perimeter: {p}");

}
}


------------------------------------------------------------------------------------

Question 2) Write a C# program that asks the user to enter an integer number. Using the relational operator >, check whether the entered number is greater than 100 or not. Display a suitable message based on the result.

Sample Output:-
Case 1:- When input number is Greater than or equal to 100


Enter a number: 150
150 is greater than 100

Case 2: When input number is less than or equal to 100

Enter a number: 75
75 is not greater than 100
==========================================================================
using System;
class Q2{
static void Main(){


Console.WriteLine("Enter Number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num>100){
 Console.WriteLine($"{num} is greater than 100 ") ;
}
else{
 Console.WriteLine($"{num} is not greater than 100 ");

}

}
}

-------------------------------------------------------------------------------------------------------------



Question 3) Write a C# program that reads two strings from the user. Using the relational operator ==, check whether the two strings are equal or not, and display an appropriate message.

Sample OutPut:-

Case 1: When both strings are the same

Enter first string: Hello
Enter second string: Hello
Both strings are equal.

Case 2: When strings are different

Enter first string: Hello
Enter second string: World
Strings are not equal.

======================================================
using System;

class Q3{
static void Main(){

Console.WriteLine("Enter First String: ");
string s1 = Console.ReadLine();

Console.WriteLine("Enter Second String: ");
string s2 = Console.ReadLine();

if(s1==s2){
Console.WriteLine("Both strings are equal");
}else{
Console.WriteLine("strings are not equal");
}

}
}

--------------------------------------------------------------------------------------------------------

Question 4) Write a C# program that asks the user to enter their age and checks if the person is eligible to vote (age ≥ 18). 
Use the relational operator >=.

Sample Output:-

Case 1: Age greater than 18

Enter your age: 20
You  are  eligible  to  vote.

Case 2:Age less than 18

Enter your age: 15
You are not eligible to vote.
=============================================================
using System;

class Q4{
static void Main(){

Console.WriteLine("Enter Your age: ");
int s1 = Convert.ToInt32(Console.ReadLine());



if(s1>18){
Console.WriteLine("You are  eligible to vote.");
}else{
Console.WriteLine("You are not eligible to vote.");
}


}
}
---------------------------------------------------------------------------------------------------------

Question 5) Write a C# program that accepts an integer from the user and determines whether the number is positive, negative, or zero using the ternary operator (?:). 

Output:-
Enter a number: -8
The number is Negative

Enter a number: 0
The number is Zero

Enter a number: 42
The number is Positive
=================================================
using System;

class Q4{
static void Main(){

Console.WriteLine("Enter a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());


string result = (n1>0)? "The number is Positive.":
(n1<0)? "The number is Negative.":"The number is Zero";

Console.WriteLine(result);
}
}

----------------------------------------------------------------------

Question 6)Write a C# program to find the largest of three numbers using if-else statements.
Input:-
Enter first number: 10  
Enter second number: 25  
Enter third number: 17

Output:-
The largest number is: 25

===================================
using System;

class Q4{
static void Main(){

Console.Write("Enter first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(n1>n2){
Console.WriteLine($"The largest num is:{n1} ");

}
else if(n2>n3){
Console.WriteLine($"The largest num is:{n2} ");

}else{
Console.WriteLine($"The largest num is:{n3} ");
}
}
}


