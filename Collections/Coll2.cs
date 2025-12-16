using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }

    class Coll2
    {
        static void Main()
        {
            ArrayList empList = new ArrayList();
            empList.Add(new Employee { ID = 1, Name = "Alice", Salary = 70000 });
            empList.Add(new Employee { ID = 2, Name = "Bob", Salary = 80000 });
            empList.Add(new Employee { ID = 3, Name = "Charlie", Salary = 90000 });
            foreach (Employee emp in empList)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }
    }
}
