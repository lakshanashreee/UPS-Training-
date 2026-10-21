using System;

class Person
{
    public string Name;
    public int Age;

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    public string Department;
    public int Marks;

    public void DisplayStudent()
    {
        DisplayPerson();
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Marks: " + Marks);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s.Name = "Priya";
        s.Age = 21;
        s.Department = "CSE";
        s.Marks = 90;

        s.DisplayStudent();
    }
}