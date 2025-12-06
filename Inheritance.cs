using System;

///////////////////////////////////////////////////////////
// HYBRID INHERITANCE PROGRAM - 1 (EMPLOYEE PAYROLL SYSTEM)
///////////////////////////////////////////////////////////

/*
QUESTION:
Employee Payroll System using Hybrid Inheritance

Base Class: Employee
Derived: FullTimeEmployee, PartTimeEmployee
Multilevel Derived: Manager → (inherits FullTimeEmployee)
Has-A: Manager HAS Incentive class (Composition)
*/

class Employee
{
    public int EmpID;
    public string Name;
    public double BaseSalary;

    public Employee(int empID, string name, double baseSalary)
    {
        EmpID = empID;
        Name = name;
        BaseSalary = baseSalary;
    }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee ID: {EmpID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Base Salary: {BaseSalary:0,0.00}");
    }
}

class FullTimeEmployee : Employee
{
    public double Bonus;

    public FullTimeEmployee(int empID, string name, double baseSalary, double bonus)
        : base(empID, name, baseSalary)
    {
        Bonus = bonus;
    }

    public double CalculateTotalSalary()
    {
        return BaseSalary + Bonus;
    }

    public void DisplayFullTimeEmployee()
    {
        DisplayEmployee();
        Console.WriteLine($"Bonus: {Bonus:0,0.00}");
        Console.WriteLine($"Total Salary:  {CalculateTotalSalary():0,0.00}");
    }
}

class PartTimeEmployee : Employee
{
    public int HoursWorked;
    public double HourlyRate;

    public PartTimeEmployee(int empID, string name, double baseSalary, int hours, double rate)
        : base(empID, name, baseSalary)
    {
        HoursWorked = hours;
        HourlyRate = rate;
    }

    public double CalculateWage()
    {
        return HoursWorked * HourlyRate;
    }

    public void DisplayPartTimeEmployee()
    {
        DisplayEmployee();
        Console.WriteLine($"Hours Worked: {HoursWorked}");
        Console.WriteLine($"Hourly Rate: {HourlyRate:0,0.00}");
        Console.WriteLine($"Total Wage: {CalculateWage():0,0.00}");
    }
}

class Incentive     // Composition Class
{
    public double CalculateIncentive(double totalSalary)
    {
        return totalSalary * 0.10;
    }
}

class Manager : FullTimeEmployee   // Multilevel + Composition
{
    public double Allowance;
    Incentive incentive = new Incentive();  // has-a relationship

    public Manager(int id, string name, double salary, double bonus, double allowance)
        : base(id, name, salary, bonus)
    {
        Allowance = allowance;
    }

    public double GetManagerTotalSalary()
    {
        double baseTotal = CalculateTotalSalary() + Allowance;
        double incentiveAmt = incentive.CalculateIncentive(baseTotal);
        return baseTotal + incentiveAmt;
    }

    public void DisplayManager()
    {
        DisplayEmployee();
        Console.WriteLine($"Bonus: {Bonus:0,0.00}");
        Console.WriteLine($"Allowance: {Allowance:0,0.00}");

        double baseTotal = CalculateTotalSalary() + Allowance;
        Console.WriteLine($"Incentive: {baseTotal * 0.10:0,0.00}");

        Console.WriteLine($"Total Salary with Incentive: {GetManagerTotalSalary():0,0.00}");
    }
}

///////////////////////////////////////////////////////
// HYBRID INHERITANCE PROGRAM - 2 (BANK ACCOUNT SYSTEM)
///////////////////////////////////////////////////////

/*
QUESTION:
Bank Account System using Hybrid Inheritance in C#

Base Class: Account
Hierarchical Derived: SavingsAccount, CurrentAccount
Multilevel Derived: PremiumAccount (inherits SavingsAccount)
Composition: PremiumAccount HAS Reward
*/

class Account
{
    public int AccountNumber;
    public string HolderName;
    public double Balance;

    public Account(int accNo, string name, double balance)
    {
        AccountNumber = accNo;
        HolderName = name;
        Balance = balance;
    }

    public void DisplayAccount()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Holder Name: {HolderName}");
        Console.WriteLine($"Balance: {Balance:0,0.00}");
    }
}

class SavingsAccount : Account
{
    public double InterestRate;

    public SavingsAccount(int accNo, string name, double balance, double rate)
        : base(accNo, name, balance)
    {
        InterestRate = rate;
    }

    public double GetSavingsBalance()
    {
        return Balance + (Balance * InterestRate / 100);
    }

    public void DisplaySavingsAccount()
    {
        DisplayAccount();
        Console.WriteLine($"Interest Rate: {InterestRate}%");
        Console.WriteLine($"Total Balance with Interest: {GetSavingsBalance():0,0.00}");
    }
}

class CurrentAccount : Account
{
    public double OverdraftLimit;

    public CurrentAccount(int accNo, string name, double balance, double limit)
        : base(accNo, name, balance)
    {
        OverdraftLimit = limit;
    }

    public double GetCurrentBalance()
    {
        return Balance + OverdraftLimit;
    }

    public void DisplayCurrentAccount()
    {
        DisplayAccount();
        Console.WriteLine($"Overdraft Limit: ₹{OverdraftLimit:0,0.00}");
        Console.WriteLine($"Total Available Balance: ₹{GetCurrentBalance():0,0.00}");
    }
}

class Reward     // Composition Class
{
    public double CalculateReward(double balance)
    {
        return balance * 0.02;
    }
}

class PremiumAccount : SavingsAccount   // Multilevel + Composition
{
    public double Cashback;
    Reward reward = new Reward();

    public PremiumAccount(int accNo, string name, double balance,
                          double rate, double cashback)
        : base(accNo, name, balance, rate)
    {
        Cashback = cashback;
    }

    public double GetPremiumBalance()
    {
        double totalSavings = GetSavingsBalance();
        double rewardAmount = reward.CalculateReward(totalSavings);
        return totalSavings + Cashback + rewardAmount;
    }

    public void DisplayPremiumAccount()
    {
        DisplayAccount();
        Console.WriteLine($"Interest Rate: {InterestRate}%");
        Console.WriteLine($"Cashback: {Cashback:0,0.00}");
        Console.WriteLine($"Total Balance with Interest, Cashback, and Rewards: {GetPremiumBalance():0,0.00}");
    }
}

///////////////////////////////////////////////////////
// MAIN PROGRAM
///////////////////////////////////////////////////////

class Program
{
    static void Main()
    {
        ////// EMPLOYEE PAYROLL SYSTEM //////

        Console.WriteLine("----- Full-Time Employee -----");
        FullTimeEmployee f = new FullTimeEmployee(101, "Ramesh", 40000, 5000);
        f.DisplayFullTimeEmployee();

        Console.WriteLine("\n----- Part-Time Employee -----");
        PartTimeEmployee p = new PartTimeEmployee(102, "Meena", 0, 50, 200);
        p.DisplayPartTimeEmployee();

        Console.WriteLine("\n----- Manager (Hybrid Inheritance) -----");
        Manager m = new Manager(103, "Rajesh", 60000, 10000, 5000);
        m.DisplayManager();

        Console.WriteLine("-----------------------------------------------------");

        ////// BANK ACCOUNT SYSTEM //////

        Console.WriteLine("\n----- Savings Account -----");
        SavingsAccount s = new SavingsAccount(101, "Alice", 8000, 5);
        s.DisplaySavingsAccount();

        Console.WriteLine("\n----- Current Account -----");
        CurrentAccount c = new CurrentAccount(102, "Rajiv", 12000, 3000);
        c.DisplayCurrentAccount();

        Console.WriteLine("\n----- Premium Account (Hybrid) -----");
        PremiumAccount pa = new PremiumAccount(103, "Sophia", 20000, 6, 1000);
        pa.DisplayPremiumAccount();

        Console.WriteLine("-----------------------------------------------------");
    }
}
