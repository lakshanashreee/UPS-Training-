using System;

abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();

    public void Display()
    {
        Console.WriteLine("Employee: " + Name);
        Console.WriteLine("Salary: " + CalculateSalary());
    }
}

class FullTimeEmployee : Employee
{
    public double MonthlySalary;

    public FullTimeEmployee(string name, double salary)
        : base(name)
    {
        MonthlySalary = salary;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }
}

class Program
{
    static void Main()
    {
        FullTimeEmployee emp = new FullTimeEmployee("Priya", 30000);
        emp.Display();
    }
}