Parameterized Constructor-1
Write a C# program to demonstrate the use of a parameterized constructor.

Create a class named Person.

Inside the class:

Declare two fields:

name of type string

age of type int

Create a parameterized constructor that accepts values for name and age, and initializes the fields with those values.

Add a method Display() to print the values of name and age.

In the Main() method:

Create an object of the Person class by passing "Vaibhav" and 25 to the constructor.

Call the Display() method to show the person's details.

Output:-
Name: john
Age: 25

----------------------------------------
using System;

class Person
{
    string name;
    int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Vaibhav", 25);
        p.Display();
    }
}

===================================



Parameterized Constructor-2
Write a C# program that uses a parameterized constructor to calculate the area of a rectangle.

Create a class named Rectangle.

Inside the class:

Declare two fields:

length (int)

width (int)

Create a parameterized constructor that takes two integers (l and w) and initializes the length and width fields.

Add a method DisplayArea() that calculates and prints the area of the rectangle.
 
In the Main() method:

Create an object of the Rectangle class using the constructor and pass 5 and 3 as values.

Call the DisplayArea() method to display the area.

Output:-
Area: 15

using System;

class Rectangle
{
    int length;
    int width;

    public Rectangle(int l, int w)
    {
        length = l;
        width = w;
    }

    public void DisplayArea()
    {
        int area = length * width;
        Console.WriteLine("Area: " + area);
    }
}

class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle(5, 3);
        r.DisplayArea();
    }
}



Parameterized Constructor-3
Write a C# program to define a class Car that uses a parameterized constructor to initialize car details.

Create a class named Car.

Inside the class:

Declare three fields:

brand (string)

model (string)

year (int)

Create a parameterized constructor that accepts values for brand, model, and year and initializes the fields.

Add a method ShowCarDetails() to display the values of all three fields.

In the Main() method:

Create an object of the Car class by passing "Toyota", "Corolla", and 2020 to the constructor.

Call the ShowCarDetails() method to print the car's details.

Output:-

Brand: Toyota
Model: Corolla
Year: 2020
using System;

class Car
{
    string brand;
    string model;
    int year;

    public Car(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    public void ShowCarDetails()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car("Toyota", "Corolla", 2020);
        c.ShowCarDetails();
    }
}




Parameterized Constructor-4
Create a "Student" class which contains the following members:-
Instance Variables:-
 RollNo - int
 Name - string
 Sub1, Sub2, Sub3 - int
 Total - int
 Average - double

Generate Parameterised Constructor and Initialize the Fields

create 2 Methods:-
Return Type : Void
Name : Calc()
Accessmodifier : public 
In Calc Method calculate total & average

Return Type : Void
Name :Display()
Accessmodifier : public 
In Display Method show the all data

Create a Main Class name "Task" :-
create a object for Student Class and call the methods Calc and Display.
using System;

class Student
{
    int RollNo;
    string Name;
    int Sub1, Sub2, Sub3;
    int Total;
    double Average;

    public Student(int roll, string name, int s1, int s2, int s3)
    {
        RollNo = roll;
        Name = name;
        Sub1 = s1;
        Sub2 = s2;
        Sub3 = s3;
    }

    public void Calc()
    {
        Total = Sub1 + Sub2 + Sub3;
        Average = Total / 3.0;
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + RollNo);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Sub1: " + Sub1);
        Console.WriteLine("Sub2: " + Sub2);
        Console.WriteLine("Sub3: " + Sub3);
        Console.WriteLine("Total: " + Total);
        Console.WriteLine("Average: " + Average);
    }
}

class Task
{
    static void Main()
    {
        Student s = new Student(101, "Vaibhav", 80, 90, 85);
        s.Calc();
        s.Display();
    }
}


-------------------------------------------------------------------

Parameterized Constructor-5
Create an class Person with the following attributes.

Instance Variables: 

Name:string
Age:int
Address:string

Parameter constructor must initialize name age and address
Method:
Name:DisplayInfo
return type:string 
access modifier:public 
return the data of the person in this method.

Create another PersonDetails class

create object for Person class pass the values by using constructor and also call the DisplayInfo method. 
User has to enter the values.

using System;

class Person
{
    string Name;
    int Age;
    string Address;

    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }

    public string DisplayInfo()
    {
        return $"Name: {Name}\nAge: {Age}\nAddress: {Address}";
    }
}

class PersonDetails
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Person p = new Person(name, age, address);

        Console.WriteLine("\n--- Person Details ---");
        Console.WriteLine(p.DisplayInfo());
    }
}
