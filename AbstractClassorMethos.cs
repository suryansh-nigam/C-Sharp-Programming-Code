using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample  
{
    abstract class Person // Abstract class
    {
       public string F_name;
        public string L_name;
        public int age;
        public long phoneNumber;

        public abstract void PrintDetails(); // abstract method
    }

   class student : Person // inheriting the abstract class
    {
        public int studentID;
        public int fee;

        public override void PrintDetails() // implementing the abstract method
        {
            Console.WriteLine("Student Name: " + F_name + " " + L_name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Fee: " + fee);
        }

    }
 class Teacher : Person // deriving the abstract class
    {
        public string qualification;
        public int salary;

        public override void  PrintDetails() // implementing the abstract method
        {
            Console.WriteLine("Teacher Name: " + F_name + " " + L_name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Qualification: " + qualification);
            Console.WriteLine("Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student suryansh = new student(); // creating object of derived class
            suryansh.F_name = "Suryansh";
            suryansh.L_name = "Kumar";
            suryansh.age = 21;
            suryansh.phoneNumber = 9876543210;
            suryansh.studentID = 101;
            suryansh.fee = 50000;

            Console.WriteLine("===============----------------==============");
            
            Teacher john = new Teacher(); // creating object of derived class
            john.F_name = "John";
            john.L_name = "Doe";
            john.age = 35;
            john.phoneNumber = 9123456780;
            john.qualification = "MSc Physics";
            john.salary = 60000;
            
            Console.WriteLine("Student Details:");
            suryansh.PrintDetails();// calling the implemented method

            Console.WriteLine("\nTeacher Details:");
            john.PrintDetails();
            
            Console.ReadLine();

        }
    }
}
