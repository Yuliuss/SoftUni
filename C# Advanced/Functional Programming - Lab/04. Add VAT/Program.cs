using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(", ")
                   .Select(Decimal.Parse)
                   .Select(number => number + (number * 0.2m))
                   .ToArray();
            //numbers = Select(numbers, number => number * 5);
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
