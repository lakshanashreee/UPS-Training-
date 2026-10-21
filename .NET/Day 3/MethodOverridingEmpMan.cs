
using System;

class Employee
{
    public virtual void DisplayRole()
    {
        Console.WriteLine("I am an employee");
    }
}

class Manager : Employee
{
    public override void DisplayRole()
    {
        Console.WriteLine("I am a manager");
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        Manager m1 = new Manager();

        e1.DisplayRole();
        m1.DisplayRole();

        Employee e2 = new Manager();
        e2.DisplayRole();
    }
}

using System;

class Employee
{
    public virtual void DisplayRole()
    {
        Console.WriteLine("I am an employee");
    }
}

class Manager : Employee
{
    public override void DisplayRole()
    {
        Console.WriteLine("I am a manager");
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee();
        Manager m1 = new Manager();

        e1.DisplayRole();
        m1.DisplayRole();

        Employee e2 = new Manager();
        e2.DisplayRole();
    }
}
