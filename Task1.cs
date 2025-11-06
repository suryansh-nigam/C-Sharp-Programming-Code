----------------- Data Types In C# ---------------------------------------------------------

Question 1) Write a C# program to demonstrate the use of basic data types:-

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

Declare an integer variable and assign it a value.

Declare a double variable and assign it a value.

Print both variable values.

Use the .GetType() method to display the actual data type of each variable.

OutPut:-

Values:
Integer value: 25
Double value: 99.99

Types:
Type of number: System.Int32
Type of price: System.Double

================================================================================
 Q1. code ---
 using System;

public class Program{

static void Main()
{

int number = 25;
double price = 99.99;

        Console.WriteLine("Values:");
        Console.WriteLine($"Integer value: {number}");
        Console.WriteLine($"Double value: {price}");

        Console.WriteLine("\nTypes:");
        Console.WriteLine($"Type of number: {number.GetType()}");
        Console.WriteLine($"Type of price: {price.GetType()}");

}
}

----------------------------------------------Q2---------------------------------------------------------------

Question 2) Write a C# program to demonstrate the use of string and char data types.

create a class with the name "Test" in that write the Main Method 

In the Main Method:-

Declare a string variable to store your name.

Declare a char variable to store the first letter of your name.

Print both the string and char values.

Use the .GetType() method to display the actual data type of each variable.


OutPut:- 

String value (Name): Vaibhav
Char value (First letter): V

Types:
Type of name: System.String
Type of firstLetter: System.Char


=======================================================================
using System;

public class Program{

static void Main()
{

String str = "Vaibhav";
Char ch = 'V';

        
        Console.WriteLine($"Strig value (Name): {str}");
        Console.WriteLine($"char value: {ch}");

        Console.WriteLine("\nTypes:");
        Console.WriteLine($"Type of namer: {str.GetType()}");
        Console.WriteLine($"Type of firstLetter: {ch.GetType()}");



}
}


-----------------------------------------------Q3-----------------------------------------------------------

Question 3) Write a C# program to demonstrate the use of the boolean (bool) data type.

create a class with the name "Task" in that write the Main Method 

In the Main Method:-

Declare a bool variable (for example, isStudent) and assign it a value (true or false).

Print the boolean value with a meaningful message.

Use the .GetType() method to display the actual data type of the variable.


Output:-

Boolean value (isStudent): True

Type:
Type of isStudent: System.Boolean

=========================================================================
using System;

public class Program{

static void Main()
{

bool isStudent = true;

        
        Console.WriteLine($"Boolean value (isStudent): {isStudent}");

        Console.WriteLine("\nTypes:");
        Console.WriteLine($"Type of isStudent: {isStudent.GetType()}");



}
}

-------------------------------------------------Q4-----------------------------------------------------------

Question 4) Write a C# program to demonstrate the use of GUIDs (Globally Unique Identifiers).

create a class with the name "GuI id" in that write the Main Method 

In the Main Method:-

Declare a Guid  two variables (id1 and id2) using Guid.NewGuid().

Print both GUID values 

Use the .GetType() method to display the actual data type of the variable.

Output:- 
First GUID: 47238cd2-c25d-4544-a4f6-32567f0bcc15
Second GUID: 593373ad-7d2a-42a4-a8d1-cba528954eff
Type First GUID: System.Guid
Type Second GUID: System.Guid


=======================================================================================
using System;

public class Program{

static void Main()
{

Guid id1 = Guid.NewGuid();
Guid id2 = Guid.NewGuid(); 

        Console.WriteLine($"First GUID: {id1}");
        Console.WriteLine($"Second GUID: {id2}");

       
        Console.WriteLine("\nTypes:");
        Console.WriteLine($"Type of First GUID: {id1.GetType()}");
        Console.WriteLine($"Type of Second GUID: {id2.GetType()}");

}
}


-----------------------------------------------------Q5-------------------------------------------------------------

Question 5) Write a C# program to demonstrate the use of float and decimal data types.

create a class with the name "Fd" in that write the Main Method 

In the Main Method:-


Declare a float variable and assign a value.

Declare a decimal variable and assign a value.


Print their values.

Use the .GetType() method to display the actual data type of each variable.

Output: -

Values:
Float value: 12.34
Decimal value: 12345.6789

Types:
Type of floatValue: System.Single
Type of decimalValue: System.Decimal
=============================================================================
using System;

public class Program{

static void Main()
{

float v1 = 12.34f;
Decimal v2 = 12345.6789M;

        Console.WriteLine("Values:");
        Console.WriteLine($"Float value: {v1}");
        Console.WriteLine($"Decimal value: {v2}");

        Console.WriteLine("\nTypes:");
        Console.WriteLine($"Type of flaotValue: {v1.GetType()}");
        Console.WriteLine($"Type of decimalValue: {v2.GetType()}");

}
}


----------------------------------------------------Q6-----------------------------------------------------------------

Question 6) Write a C# program to demonstrate the use of DateTime data type.

create a class with the name "Dd" in that write the Main Method 

In the Main Method:-


Display the current date and time.

Display today’s date only (with time set to 00:00:00).

Display the date and time after 10 days from the current date.

Use the .GetType() method to display the actual data type of each variable.


=====================================================================================

  using System;

public class Dd
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;
	DateTime todayDate = DateTime.Today;
        DateTime after10 = currentDateTime.AddDays(10);
       

        Console.WriteLine($"Current Date and Time: {currentDateTime}");
        Console.WriteLine($"Today's Date: {todayDate}");
	Console.WriteLine($"After 10s Date: {after10}");

	Console.WriteLine("\nTypes:");
        Console.WriteLine($"Type of currentdateTime: {currentDateTime.GetType()}");
        Console.WriteLine($"Type of TodayDate: {after10.GetType()}");

   
    }
}



