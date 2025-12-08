using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    // Q1 - Write a C# program to demonstrate interface inheritance. Create an interface Application with methods OpenApp() and CloseApp(). 
  //Then create another interface Data that inherits Application and adds methods Save() and Delete().
  // Implement these in a class FileManager and call all methods inside Main()
  ======================================
  
    interface IApplication
    {
       void OpenApp();
       void Delete();
    }

    interface IData :IApplication 
    {
       void Save();
       void Delete();
    }


    internal class FileManager : IData
    {
       public void OpenApp()
       {
           Console.WriteLine("Application opened");
       }

       public void CloseApp()
       {
           Console.WriteLine("Application closed");
       }

       public void Save()
       {
           Console.WriteLine("Data saved");
       }

       public void Delete()
       {
           Console.WriteLine("Data deleted");
       }
    }
       class Test

           {
               static void Main(string[] args)
               {
                   FileManager fileManager = new FileManager();
                   fileManager.OpenApp();
                   fileManager.Save();
                   fileManager.Delete();
                   fileManager.CloseApp();
               }
       }

    // ----------------------------------------------------------------------------

    // Q2 - Write a C# program demonstrating multiple interface implementation. Create interfaces IDrawable and IResizable, each containing one method.
  // Implement both interfaces in the class Shape and call both methods in the Main method.

    interface IDrawable
    {
       void Draw();
    }
    interface IResizable
    {
       void Resize();
    }

    class Shape: IDrawable, IResizable
    {
        public void Draw()
       {
           Console.WriteLine("Drawing the shape");
       }
       public void Resize()
       {
           Console.WriteLine("Resizing the shape");
       }
    }
    class Test
    {
       static void Main()
       {
           Shape shape = new Shape();
           shape.Draw();
           shape.Resize();
       }
    }

    //--------------------------------------------------------------------------------

    // Q3 - Write a C# program using interface-based polymorphism. Create an interface IJob with methods work() and GetSalary().
  //Implement this interface in classes Doctor and Engineer. In the Main method, create objects using IJob reference and call the respective methods.
  

    interface IJob
    {
       void work();
       void GetSalary();
    }
    class Doctor : IJob
    {
       public void work()
       {
           Console.WriteLine("Doctor is treating patients.");
       }
       public void GetSalary()
       {
           Console.WriteLine("Doctor receives 30,000 per month.");
       }
    }
    class Engineer : IJob
    {
       public void work()
       {
           Console.WriteLine("Engineer is developing software.");
       }
       public void GetSalary()
       {
           Console.WriteLine("Engineer receives 128,000 per month.");
       }
    }
    class Test
    {
       static void Main()
       {
           IJob doctor = new Doctor();
           doctor.work();
           doctor.GetSalary();

           IJob engineer = new Engineer();
           engineer.work();
           engineer.GetSalary();
       }
    }

    // ----------------------------------------------------------------------------

    //Q4 -Write a C# program demonstrating multiple interfaces with return types. Create interfaces IProduct and IOnlineShopping.
  //Implement these interfaces in classes Laptop and Book. Each product should return brand, price, and quality. Also implement methods for adding to cart and checkout. Display details in the Main method.

    interface IProduct
    {
       string GetBrand();
       string GetPrice();
       string GetQuality();
    }

    interface IOnlineShopping
    {
       void AppName(string name);
       void AddCart();
       void Checkout();
    }

    class Laptop : IProduct, IOnlineShopping
    {
       public string GetBrand()
       {
           return "Brand: HP";
       }
       public string GetPrice()
       {
           return "$1200";
       }
       public string GetQuality()
       {
           return "Quality: High";
       }
       public void AppName(string name)
       {
           Console.WriteLine("Online Shopping App Name: " + name);
       }
       public void AddCart()
       {
           Console.WriteLine("Item  added to the cart.");
       }
       public void Checkout()
       {
           Console.WriteLine("Checkout completed.");
       }
    }

    class Book : IProduct, IOnlineShopping
    {
       public string GetTitle()
       {
           return "Title: Agnipankh";
       }
       public string GetBrand()
       {
           return "Brand: Penguin";
       }
       public string GetPrice()
       {
           return "$1500";
       }
       public string GetQuality()
       {
           return "Quality: Medium";
       }
       public void AppName(string name)
       {
           Console.WriteLine("Online Shopping App Name: " + name);
       }
       public void AddCart()
       {
           Console.WriteLine("Item  added to the cart.");
       }
       public void Checkout()
       {
           Console.WriteLine("Checkout completed.");
       }
    }

    class Test
    {
       static void Main()
       {
           Laptop laptop = new Laptop();
           Console.WriteLine("Laptop Details:");
           Console.WriteLine(laptop.GetBrand());
           Console.WriteLine("Price: " + laptop.GetPrice());
           Console.WriteLine(laptop.GetQuality());
           laptop.AppName("Flipkart");
           laptop.AddCart();
           laptop.Checkout();
           Console.WriteLine();

           Book book = new Book();
           Console.WriteLine("Book Details:");

           Console.WriteLine(book.GetTitle());
           Console.WriteLine(book.GetBrand());
           Console.WriteLine("Price: " + book.GetPrice());
           Console.WriteLine(book.GetQuality());
           book.AppName("Amazon");
           book.AddCart();
           book.Checkout();
           Console.WriteLine();
       }
    }

    // ----------------------------------------------------------------------------
    // Q5 - Write a C# program to implement a calculator using an interface. Create an interface ICalculator with methods Add(int, int) and Multiply(int, int).
  //Implement this interface inside SimpleCalculator class and perform addition and multiplication in the Main method.

    interface ICalculator
    {
       int Add(int a, int b);
        
       int Multiply(int a, int b);
    }
    class SimpleCalculator : ICalculator
    {
       public int Add(int a, int b)
       {
           return a + b;
       }
       public int Multiply(int a, int b)
       {
           return a * b;
       }
    }
    class Test
    {
       static void Main()
       {
           SimpleCalculator calculator = new SimpleCalculator();
           int sum = calculator.Add(20, 10);
           int product = calculator.Multiply(20, 10);

           Console.WriteLine("Addition: " + sum);
           Console.WriteLine("Multiplication: " + product);
       }
    }
}
