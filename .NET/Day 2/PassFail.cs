
using System;

class Program
{
    static void Main()
    {
        int marks = 85;

        if (marks >= 35)
        {
            Console.WriteLine("Pass");

            if (marks >= 75)
            {
                Console.WriteLine("Grade A");
            }
            else
            {
                Console.WriteLine("Grade B");
            }
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
