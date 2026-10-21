using System;
using System.Linq;
class Program
{
static void Main()
{
int[] numbers 5, 10, 15, 20, 25, 30);
var result from n in numbers
where n > 10
select n;
foreach (int n in result)
{
Console.WriteLine(n);
}
}
}