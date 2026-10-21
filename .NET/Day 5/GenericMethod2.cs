
using System;

class Program
{
    static void Display<T>(T value)
    {
        Console.WriteLine("Value: " + value);
        Console.WriteLine("Data Type: " + typeof(T).Name);
        Console.WriteLine();
    }

    static void Main()
    {
        Display<int>(100);
        Display<string>("Hello Students");
        Display<double>(85.5);
        Display<bool>(true);
    }
}
