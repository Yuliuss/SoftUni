using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiChikens = int.Parse(Console.ReadLine());
            int broiFishes = int.Parse(Console.ReadLine());
            int broiVegiterian = int.Parse(Console.ReadLine());
            double priceWithoutDesert = broiChikens * 10.35 + broiFishes * 12.40 + broiVegiterian * 8.15;
            double desrtPrice = priceWithoutDesert * 0.20;

            Console.WriteLine($"Total: {(priceWithoutDesert + desrtPrice + 2.50):F2}");
        }
    }
}
