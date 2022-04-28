using System;

namespace _05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForClothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            if (statists > 150)
            {
                priceForClothes *= 0.90;
            }
            double finalPriceForClothes = priceForClothes * statists;
            double finalMoney = decor + finalPriceForClothes;

            if (finalMoney <= budget)
            {
                double moneyLeft = budget - finalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double needMoney = finalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }

            Console.WriteLine();
        }
    }
}
