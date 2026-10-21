using System;

class Program
{
    static void Main()
    {
        int num = 1234;
        int reverse = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num = num / 10;
        }

        Console.WriteLine("Reversed number: " + reverse);
    }
}