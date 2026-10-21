
using System;

class Payment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs. " + amount + " using Cash");
    }

    public void Pay(double amount, string upiId)
    {
        Console.WriteLine("Paid Rs. " + amount + " using UPI: " + upiId);
    }

    public void Pay(double amount, string cardNumber, string cardHolder)
    {
        Console.WriteLine("Paid Rs. " + amount + " using Card");
        Console.WriteLine("Card Holder: " + cardHolder);
    }
}

class Program
{
    static void Main()
    {
        Payment payment = new Payment();

        payment.Pay(500);
        payment.Pay(1000, "harinee@upi");
        payment.Pay(2000, "1234567890", "Arun");
    }
}
