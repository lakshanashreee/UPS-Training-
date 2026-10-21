
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] products = { "Pen", "Bag", "Notebook", "Bottle", "Pencil Box" };
        int[] prices = { 20, 800, 150, 350, 450 };

        var result = Enumerable.Range(0, products.Length)
            .Where(i => prices[i] < 500)
            .Select(i => products[i] + " Rs. " + prices[i]);

        foreach (var product in result)
        {
            Console.WriteLine(product);
        }
    }
}
