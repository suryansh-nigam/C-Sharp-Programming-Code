using System;

class Employee
{
    // Private fields
    private int _employeeId;
    private string _name;
    private string _department;

    // Private static fields
    private static int _totalEmployees;
    private static int _nextId;

    // Static constructor
    static Employee()
    {
        Console.WriteLine("=== Company Policies Loaded ===");
        Console.WriteLine("Policy 1: All employees get healthcare");
        Console.WriteLine("Policy 2: Standard working hours: 9 AM - 5 PM");

        _nextId = 1001;
        _totalEmployees = 0;
    }

    // Parameterized constructor
    public Employee(string name, string department)
    {
        _employeeId = _nextId;
        _name = name;
        _department = department;

        _nextId++;
        _totalEmployees++;
    }

    // Static method to get total employees
    public static int GetTotalEmployees()
    {
        return _totalEmployees;
    }

    // Method to display employee details
    public void Display()
    {
        Console.WriteLine($"ID: {_employeeId}, Name: {_name}, Department: {_department}");
    }
}

class Program
{
    static void Main()
    {
        // Creating 3 employee objects
        Employee emp1 = new Employee("John Smith", "IT");
        Employee emp2 = new Employee("Sarah Johnson", "HR");
        Employee emp3 = new Employee("Mike Brown", "Finance");

        Console.WriteLine("=== Employee Details ===");
        emp1.Display();
        emp2.Display();
        emp3.Display();

        Console.WriteLine();
        Console.WriteLine("Total Employees: " + Employee.GetTotalEmployees());
    }
}


=============================================
  === Company Policies Loaded ===
Policy 1: All employees get healthcare
Policy 2: Standard working hours: 9 AM - 5 PM
=== Employee Details ===
ID: 1001, Name: John Smith, Department: IT
ID: 1002, Name: Sarah Johnson, Department: HR
ID: 1003, Name: Mike Brown, Department: Finance

Total Employees: 3

