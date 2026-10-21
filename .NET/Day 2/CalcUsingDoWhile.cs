using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 3)
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                    Console.WriteLine("Result: " + (a + b));
                else if (choice == 2)
                    Console.WriteLine("Result: " + (a - b));
                else
                    Console.WriteLine("Result: " + (a * b));
            }
            else if (choice != 4)
            {
                Console.WriteLine("Invalid choice");
            }

        } while (choice != 4);

        Console.WriteLine("Calculator closed");
    }
}