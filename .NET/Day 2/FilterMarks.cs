using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] marks = { 45, 82, 67, 91, 38, 76 };

        var result = from mark in marks
                     where mark >= 70
                     select mark;

        foreach (int mark in result)
        {
            Console.WriteLine(mark);
        }
    }
}