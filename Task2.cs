-------------------------Q1--------------------------
  Question 1) Write a C# program to read the following details of an employee from the user:

create a class with the name "Employee" in that write the Main Method 

In the Main Method:-

Employee Name (string)

Employee Id (integer)

Employee Salary (double)

After taking the input, display the details.

Sample Input:-
Enter Employee Name: Vaibhav
Enter Employee Id: 101
Enter Employee Salary: 2000000

Sample Output:-

Enter Employee Name: Vaibhav
Enter Employee Id: 101
Enter Employee Salary: 2000000
========================================================================

  Code - 

  using System;

class D2q2{

static void Main(){


 Console.WriteLine("Enter Employee Name: ");
    string s1 = Console.ReadLine();
 Console.WriteLine("Enter Employee Id: ");
     int i = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter Employee Salary: ");
     int j = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Employee Name: {s1} Employee Id: {i}\n Employee Salary: {j}");

}
}

------------------------------------Q2----------------------------------------------------

Question 2) Write a C# program to read the following car details from the user:

create a class with the name "Car" in that write the Main Method 

In the Main Method:-
Car Number (integer)

Car Owner Name (string)

Car Brand (string)

Car Mileage (double)

After reading the input, display the details.

Sample input:-

Car number: 3262
Car Owner name: Vaibhav
Car Brand: Ford
Car milage: 25.5kmpl

Sample Output:-

Car number: 3262
Car Owner name: Vaibhav
Car Brand: Ford
Car milage: 25.5kmpl

====================================================================================
code- 
    
    using System;

class D2Q2{

static void Main(){

Console.WriteLine("Car Number: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Car Owner name: ");
string s1 = Console.ReadLine();

Console.WriteLine("Car Brand: ");
string s2 = Console.ReadLine();

Console.WriteLine("Car milage: ");
double d1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Car number: {i}\n Car Owner Name: {s1}\n Car Brand: {s2}\n Car Mileage: {d1}kmpl");

}
}

------------------------------------Q3-------------------------------------------------


Question 3) Write a C# program to read and display account details of a bank customer.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

The program should take the following inputs from the user:

Account Holder Name (string)

Account Number (long)

Account Balance (decimal)

Account Active Status (bool → true/false)

Finally, print the details in a proper format.

Sample Input:-

Enter Account Holder: Vaibhav
Enter Account Number: 123456789012
Enter Balance: 25000.75
Is Account Active (true/false): true

Sample Output:-

Account Holder: Vaibhav
Account Number: 123456789012
Balance: 25000.75
Account Active: True
==========================================================================

using System;

class D2Q3{

static void Main(){

Console.WriteLine("Account Holder Name: ");
string s1 = Console.ReadLine();

Console.WriteLine("Account Number: ");
long l1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Account Balance: ");
decimal d1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Is Account Active (true/false): ");
bool b1 = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine($"Account Holder Name: {s1}\n Account Number: {l1}\n Account Balance: {d1}\n Car Active status: {b1}");
}

}
-----------------------------------Q4------------------------------------------------

Question 4) Write a C# program to read and display flight information.

create a class with the name "Flight" in that write the Main Method 

In the Main Method:-

The program should ask the user to enter the following details:

Flight Number (string)

Airline (string)

Departure Time (DateTime in the format yyyy-MM-dd HH:mm)

Ticket Price (double)

After taking the inputs, the program should display the flight details in a clear format.


Sample Input:- 

Enter Flight Number: AI202
Enter Airline: Air India
Enter Departure Time (yyyy-MM-dd HH:mm): 2025-08-20 14:30
Enter Ticket Price: 12500.75

Sample Output:-

Enter Flight Number: AI202
Enter Airline: Air India
Enter Departure Time (yyyy-MM-dd HH:mm): 2025-08-20 14:30
Enter Ticket Price: 12500.75
  ===========================================================
  code 
  using System;

class D2Q4{

static void Main(){

Console.WriteLine("Enter Flight Number: ");
string s1 = Console.ReadLine();

Console.WriteLine("Enter Airline: ");
string s2 = Console.ReadLine();

Console.WriteLine("Enter Departure Time (yyyy-MM-dd HH:mm): ");
 DateTime departure= Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Enter Ticket Price: ");
double d1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter Flight Number: {s1}\n Enter Airline: {s2}\n Enter Departure Time (yyyy-MM-dd HH:mm): {departure}\n Enter Ticket Price: {d1}");

}

}

---------------------------------Q5------------------------------------------------

Question 5) Write a C# program to read and display sports player details.

create a class with the name "Sports" in that write the Main Method 

In the Main Method:-

Inputs to be taken from the user:

Player Name (string)

Jersey Number (int)

Average Score (float)

Is Captain (bool)


Sample Input:-

Enter Player Name: Virat Kohli
Enter Jersey Number: 18
Enter Average Score: 55.67
Is Captain (true/false): true


Sample Output:-

---- Player Details ----
Player Name: Virat Kohli
Jersey Number: 18
Average Score: 55.67
Is Captain: True

=================================================================================
using System;

class D2Q5{

static void Main(){

Console.WriteLine("Player Name: ");
string s1 = Console.ReadLine();

Console.WriteLine("Jersy Number: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Average Score: ");
 float f1= Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Is Captain (true/false): ");
bool b1 = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine("----- Player Details----");
Console.WriteLine($"Enter Player Name: {s1}\n Jersey Number: {i}\n Average Score: {f1}\n Is Captain: {b1}");

}

}

------------------------------------Q6------------------------------------------------------

Question 6) Write a C# program that reads a single character from the user and displays:

create a class with the name "Aschar" in that write the Main Method 

In the Main Method:-

Inputs to be taken from the user:

myChar (char)

Print the details

The character entered.

Its ASCII value.

Sample Input:-

Enter a character: A

Sample Output:-

Character: A
ASCII Value: 65

  ==========================================================
  using System;
class D2Q6{
static void Main(){

Console.WriteLine("Enter a Character: ");
char ch = Convert.ToChar(Console.ReadLine());
int asc = Convert.ToInt32(ch);

Console.WriteLine($"Character: {ch}\n ASCII Value: {asc}");

}
}

--------------------------------------------------------------------------------


