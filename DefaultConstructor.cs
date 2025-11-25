Q - Write a C# program to demonstrate the use of a default constructor.

Create a class named Hello.

Inside the class, define a default constructor that prints the message
"Hello from the default constructor!" to the console.

In the Main() method:

Create an object of the Hello class.

Observe the output when the object is created.

Output:-
Hello from the default constructor!

=======================================================
using System;

class Hello
{
    public Hello()
    {
        Console.WriteLine("Hello from the default constructor!");
    }

    static void Main()
    {
        Hello obj = new Hello();
    }
}

---------------------------------------------------------------------------

Default Constructor-2
Write a C# program to define a class Car with the following specifications:

The class should contain two private fields:

brand (string)

model (string)

Implement a default constructor that initializes:

brand to "Toyota"

model to "Corolla"

Add a public method called Display() that prints the brand and model to the console.

In the Main() method:

Create an object of the Car class.

Call the Display() method to show the initialized values.

Output:-

Brand=Toyota
Model=Corolla
==================================================
using System;

class Car
{
    private string brand;
    private string model;

    public Car()
    {
        brand = "Toyota";
        model = "Corolla";
    }

    public void Display()
    {
        Console.WriteLine("Brand=" + brand);
        Console.WriteLine("Model=" + model);
    }

    static void Main()
    {
        Car c = new Car();
        c.Display();
    }
}

--------------------------------------------------------------
Write a C# program to define a class Student with the following features:

The class should contain two private fields:

name of type string

age of type int

Implement a default constructor that initializes:

name to "sam"

age to 25

Add a public method Display() that prints the values of name and age.

In the Main() method:

Create an object of the Student class.

Call the Display() method to show the initialized values.

OutPut:-
Name: sam
Age: 25
============================================
using System;

class Student
{
    private string name;
    private int age;

    public Student()
    {
        name = "sam";
        age = 25;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Student s = new Student();
        s.Display();
    }
}

-------------------------------------------------------------

Write a C# program to define a class MathUtility that uses a default constructor to perform a calculation.

Create a class named MathUtility.

Inside the class:

Declare an integer field number.

Use a default constructor to initialize number with the value 10.

Create a method Square() that calculates and prints the square of number.

In the Main() method:

Create an object of the MathUtility class.

Call the Square() method to display the result.

Output:-

Square: 100
=====================================================
using System;

class MathUtility
{
    private int number;

    public MathUtility()
    {
        number = 10;
    }

    public void Square()
    {
        Console.WriteLine("Square: " + (number * number));
    }

    static void Main()
    {
        MathUtility mu = new MathUtility();
        mu.Square();
    }
}

--------------------------------------------------------------

Default Constructor-5
 Write a C# program to track how many objects of a class are created using a static field.

Create a class named Student.

Inside the class:

Declare a static integer field count and initialize it to 0.

Create a default constructor that increments count by 1 every time a Student object is created.

Define a static method GetStudentCount() that returns the current value of count.

In the Main() method:

Create three objects of the Student class.

Call the static method GetStudentCount() and print the number of objects created.

Output:-

Number of Student objects created: 3
=========================================

using System;

class Student
{
    private static int count = 0;

    public Student()
    {
        count++;
    }

    public static int GetStudentCount()	
    {
        return count;
    }

    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student();
        Student s3 = new Student();

        Console.WriteLine("Number of Student objects created: " + Student.GetStudentCount());
    }
}




