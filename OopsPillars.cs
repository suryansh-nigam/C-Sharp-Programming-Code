1) Encapsulation Example
---------------------------------------------------------------------

using System;

class Student{
    
    private int age;
    
    public void SetAge(int a){
        if(a>0){
            age = a;
        }
    }
    
    public int GetAge(){
        return age;
    }
    
    static void Main(){
        Student s = new Student();
        s.SetAge(22);
        Console.Write(s.GetAge());
    }
}

============================================================================

2) Inheritance Example
---------------------------------------------------------------------

using System;

class Animal{
    
    public void Sound(){
       Console.Write("Animal Sound");
        }
   
   class Dog : Animal {
       
   }
    static void Main(){
        Dog d = new Dog();
        d.Sound();
    
    }
}

==============================================================================

3) Polymorphism Example
----------------------------------------------------------------------
  
  --- > Method Overloading

using System;

class Math{
    public int Add(int a,int b){
        return a +b;
    }
    
    public int Add(int a,int b, int c){
        return a +b + c;
    }
    
     public int Add(int a,int b, int c, int d){
        return a +b + c+ d;
    }
    
    static void Main(){
     Math obj = new Math();
        Console.WriteLine(obj.Add(2,3)); // 5
        Console.WriteLine(obj.Add(2,3,4)); // 9
        Console.WriteLine(obj.Add(2,3,4,5)); // 14
    }
}


  --- > Method Overriding

  using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal obj = new Dog();   // upcasting
        obj.Speak();              // Output: Dog barks
    }
}

-----------------------------------------------------------------
4) - Abstrction Example
================================================================
   
    using System;

abstract class Shape{
    public abstract void Draw();
    
}

class Circle : Shape{
    public override void Draw(){
        Console.WriteLine("Drawing Circle");
    }
}

class Program{
    static void Main(){
        
        Shape obj= new Circle();
        obj.Draw();
    }
}

