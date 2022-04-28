using System;

namespace _01.USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());

            price *= 1.79549;

            Console.WriteLine(price);
        }
    }
}
