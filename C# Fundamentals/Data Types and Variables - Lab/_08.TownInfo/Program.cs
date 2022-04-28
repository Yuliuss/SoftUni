using System;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {n} and area {n2} square km.");
        }
    }
}
