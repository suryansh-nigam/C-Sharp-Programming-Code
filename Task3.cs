Question 1) Write a C# program that demonstrates boxing.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

Declare an integer variable with the value 100.

Convert this integer into an object type.

Print both the original integer value and the boxed object value.

Output:-

Original integer value: 42
Boxed object value: 42

====================================================================
  using System;
class Q1{
static void Main(){

int a =100;
object obj =a;


Console.WriteLine($"Original integer value: {a}");
Console.WriteLine($"Boxed object value: {obj}");



}
}
------------------------------------Q2--------------------------------------------------------------------------

Question 2) Write a C# program to demonstrate boxing and unboxing with an integer.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

Declare an integer variable with the value 100.

Convert this integer into an object type.

Unbox the object back into an integer.

Print the original integer, the boxed object, and the unboxed integer.

OUTPUT:-

Original integer: 100
Boxed object: 100
Unboxed integer: 100
  ================================================================
  using System;
class Q1{
static void Main(){

int a =100;
object obj =a;
int u = (int)obj;


Console.WriteLine($"Original integer value: {a}");
Console.WriteLine($"Boxed object value: {obj}");
Console.WriteLine($"UnBoxed Integer: {u}");
}
}

---------------------------------------Q3---------------------------------------------------------------------------

Question 3) Write a C# program that demonstrates boxing.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

Declare a double variable with the value 99.99.

Convert this Double into an object type.

Print both the original Double value and the boxed object value.

Output:-

Original double value: 99.99
Boxed object value: 99.99
  =======================================================================
  using System;
class Q1{
static void Main(){

double d =99.99;
object obj =d;


Console.WriteLine($"Original integer value: {d}");
Console.WriteLine($"Boxed object value: {obj}");

}
}

-------------------------------------------Q4------------------------------------------------------------------------

Question 4) Write a C# program to demonstrate boxing and unboxing with a double value.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

Declare a double variable with the value 3.14159.

Convert it into an object.

Unbox it back into a double.

Print the original value, the boxed object, and the unboxed value.

Output:-

Original double: 3.14159  
Boxed object: 3.14159  
Unboxed double: 3.14159  
  ============================================================================================
  using System;
class Q1{
static void Main(){

double d =3.14159;
object obj =d;
double u = (double)obj;


Console.WriteLine($"Original integer value: {d}");
Console.WriteLine($"Boxed object value: {obj}");
Console.WriteLine($"UnBoxed Integer: {u}");


}
}

--------------------------------------Q5--------------------------------------------------------

Question 5) Write a C# program that demonstrates Var.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

using the var keyword to declare variables of different data types (integer, string, and double).

Print each variable’s value along with its runtime type using the GetType() method.

Output:-

Value: 10, Type: System.Int32
Value: Vaibhav, Type: System.String
Value: 3.14, Type: System.Double

=========================================================
using System;
class Q5{
static void Main(){

var v = 10;
var n = "vaibhav";
var pi = 3.14;

Console.WriteLine($"Value: {v} Type: {v.GetType()}"); 
Console.WriteLine($"Value: {n} Type: {n.GetType()}"); 
Console.WriteLine($"Value: {pi} Type: {pi.GetType()}"); 


}
}

--------------------------------------------Q6----------------------------------------------------

Question 6)  Write a C# program that demonstrates Dynamic.

create a class with the name "Program" in that write the Main Method 

In the Main Method:-

using the dynamic keyword to store different types of values (integer, string, and double) in the same variable.

Print the value and its runtime type after each assignment using the GetType() method.

Output:-

Value: 100, Type: System.Int32
Value: Hello World, Type: System.String
Value: 99.99, Type: System.Double
=====================================================================================
using System;
class Q6{
static void Main(){

dynamic dynamicVar = 100;
dynamic Var = "Hello World";
dynamic Var = 99.99;


Console.WriteLine($"Value: {dynamicVar}, Type: {dynamicVar.GetType()}");

Console.WriteLine($"Value: {dynamicVar}, Type: {dynamicVar.GetType()}");

Console.WriteLine($"Value: {dynamicVar}, Type: {dynamicVar.GetType()}");
}
}


