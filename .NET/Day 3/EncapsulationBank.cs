using System;

class BankAccount
{
    private double balance = 1000;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount deposited: " + amount);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Amount withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.DisplayBalance();
        account.Deposit(500);
        account.Withdraw(200);
        account.DisplayBalance();
    }
}