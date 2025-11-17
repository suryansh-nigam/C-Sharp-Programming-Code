using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Employee class
    class Employee
    {

        public int EmpId;
        public string EmpName;
        public double Salary;
        double TaxDeduction = 0.1; // 10% tax deduction
        double netSalary;


        // Constructor
        public Employee(int empId, string empName, double salary)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.Salary = salary;
        }

        // private method to calculate net salary - hiden from outside world
        void CalculateNetSalary()
        {
           if (Salary >= 40000)
            {
                netSalary = Salary - (Salary * TaxDeduction);
            Console.WriteLine("Net Salary is: {0}",netSalary);
            }
            else
            {
                Console.WriteLine("Your salary is : {0}", Salary);
            }
        }

        // public method to access private method
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Emplyee Name is: {0}", this.EmpId);
            Console.WriteLine("Emplyee Name is: {0}", this.EmpName);

            this.CalculateNetSalary();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Suryansh = new Employee(101, "Suryansh", 35000);
            Suryansh.ShowEmployeeDetails();
        }
    }
}
