
using System;

class Program
{
    static void Main()
    {
        int a = 20, b = 10;
        char op = '+';

        switch (op)
        {
            case '+':
                Console.WriteLine(a + b);
                break;

            case '-':
                Console.WriteLine(a - b);
                break;

            case '*':
                Console.WriteLine(a * b);
                break;

            case '/':
                Console.WriteLine(a / b);
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
    }
}
