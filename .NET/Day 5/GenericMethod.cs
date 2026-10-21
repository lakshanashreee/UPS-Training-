using System;

class Student<T>
{
    public T StudentID;
    public string Name;

    public Student(T id, string name)
    {
        StudentID = id;
        Name = name;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Student ID: " + StudentID);
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student<int> s1 = new Student<int>(101, "Arun");
        Student<string> s2 = new Student<string>("CSE102", "Priya");

        s1.DisplayDetails();
        s2.DisplayDetails();
    }
}